using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDSV_TC
{
    public partial class FrmDK : Form
    {
        private DataTable dt = new DataTable();
        public FrmDK()
        {
            InitializeComponent();
        }

        private void fillStudentInformation()
        {
            string command = "EXEC SP_GET_TTSV " + "'" + Program.username + "'";
            Program.myReader = Program.ExecSqlDataReader(command);

            if (Program.myReader == null) return;


            Program.myReader.Read();
            txtHoTen.Text = Program.myReader.GetString(0);
            txtMalop.Text = Program.myReader.GetString(1) + " " + Program.myReader.GetString(2);

            Program.myReader.Close();
        }
        private void fillCbbNienKhoa()
        {
            String command = "EXEC SP_GETKHOAHOC_FROM_MASV " + "'" + Program.username + "'";
            Program.myReader = Program.ExecSqlDataReader(command);

            if (Program.myReader == null) return;

            Program.myReader.Read();

            String nienKhoa = Program.myReader.GetString(0);
            Program.myReader.Close();

            int fromYear;
            if (int.TryParse(nienKhoa.Split('-')[0], out fromYear))
            {
                int currentYear = DateTime.Now.Year;

                for (int i = fromYear; i <= currentYear - 1; i++)
                    cbbNienKhoa.Items.Add((i.ToString() + "-" + (i + 1).ToString()));
            }
        }

        private void fill_GridControl_DSLTC()
        {
            /*string nienkhoa = cbbNienKhoa.Text;
            int hocky = Convert.ToInt32(cbbHocKy.Text);
            string cmd = "EXEC SP_GETDSLTC_FROM_NK_HK 'nienkhoa',"+ hocky.ToString();

            DataTable dt = Program.ExecSqlQuery(cmd);
            gcDSLTC.DataSource = dt;*/
            try
            {
                this.qLDSV_TCDataSet.EnforceConstraints = false;
                this.sP_GETDSLTC_FROM_NK_HKTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sP_GETDSLTC_FROM_NK_HKTableAdapter.Fill(this.qLDSV_TCDataSet.SP_GETDSLTC_FROM_NK_HK, cbbNienKhoa.Text, Convert.ToInt32(cbbHocKy.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void fill_GridControl_DKSV()
        {
            try
            {
                this.qLDSV_TCDataSet.EnforceConstraints = false;
                this.sP_DSDK_OF_SVTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sP_DSDK_OF_SVTableAdapter.Fill(this.qLDSV_TCDataSet.SP_DSDK_OF_SV, Program.username, cbbNienKhoa.Text, Convert.ToInt32(cbbHocKy.Text), Program.hocPhi);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void FrmLTC_Load(object sender, EventArgs e)
        {
            fillStudentInformation();
            fillCbbNienKhoa();
        }

        private void cbbNienKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbNienKhoa.SelectedIndex == -1 || cbbHocKy.SelectedIndex == -1) return;
            fill_GridControl_DSLTC();
            fill_GridControl_DKSV();
        }

        private void cbbHocKy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbNienKhoa.SelectedIndex == -1 || cbbHocKy.SelectedIndex == -1) return;
            fill_GridControl_DSLTC();
            fill_GridControl_DKSV();
        }



        private void gvDSLTC_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            btnDangKi.Enabled = true;
        }

        private void gvDK_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            btnHuyDK.Enabled = true;
        }

        private void btnDangKi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();

            String maLTC = gvDSLTC.GetRowCellValue(gvDSLTC.FocusedRowHandle, "MALTC").ToString();
            String maMH = gvDSLTC.GetRowCellValue(gvDSLTC.FocusedRowHandle, "MAMH").ToString();

            String spString = "SP_DKY_LOPTINCHI";
            SqlCommand command = Program.conn.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = spString;
            command.Parameters.Add("@MALTC", SqlDbType.Int).Value = maLTC;
            command.Parameters.Add("@NIENKHOA", SqlDbType.NChar).Value = cbbNienKhoa.Text;
            command.Parameters.Add("@HOCKY", SqlDbType.Int).Value = Convert.ToInt32(cbbHocKy.Text);
            command.Parameters.Add("@MAMH", SqlDbType.NChar).Value = maMH;
            command.Parameters.Add("@MASV", SqlDbType.NChar).Value = Program.username;
            command.Parameters.Add("@CHIPHI", SqlDbType.Int).Value = Program.hocPhi;

            try
            {
                command.ExecuteNonQuery();

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Lỗi đăng ký", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Program.conn.Close();
            }

            fill_GridControl_DKSV();
        }

        private void btnHuyDK_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();

            String maLTC = gvDK.GetRowCellValue(gvDK.FocusedRowHandle, "MALTC").ToString();
            String maMH = gvDK.GetRowCellValue(gvDK.FocusedRowHandle, "MAMH").ToString();

            String spString = "SP_DELETE_DKY_SV";
            SqlCommand command = Program.conn.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = spString;
            command.Parameters.Add("@MALTC", SqlDbType.Int).Value = maLTC;
            command.Parameters.Add("@NIENKHOA", SqlDbType.NChar).Value = cbbNienKhoa.Text;
            command.Parameters.Add("@HOCKY", SqlDbType.Int).Value = Convert.ToInt32(cbbHocKy.Text);
            command.Parameters.Add("@MASV", SqlDbType.NChar).Value = Program.username;
            command.Parameters.Add("@CHIPHI", SqlDbType.Int).Value = Program.hocPhi;

            try
            {
                command.ExecuteNonQuery();

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Lỗi hủy đăng ký", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Program.conn.Close();
            }

            fill_GridControl_DKSV();
        }

        private void btnExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void gvDSLTC_ShowingEditor(object sender, CancelEventArgs e)
        {

        }
    }
}
