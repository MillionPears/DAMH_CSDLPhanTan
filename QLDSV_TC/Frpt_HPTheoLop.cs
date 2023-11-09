using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
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
    public partial class Frpt_HPTheoLop : DevExpress.XtraEditors.XtraForm
    {
        string lop = "";
        string nienkhoa = "";
        string hocky = "";

        public Frpt_HPTheoLop()
        {
            InitializeComponent();

        }

        private void layDSLop(String cmd)
        {
            DataTable dt = new DataTable();
            this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            SqlDataAdapter da = new SqlDataAdapter(cmd, Program.connstr);
            da.Fill(dt);


            cbxLop.DataSource = dt;
            cbxLop.DisplayMember = "MALOP";
            cbxLop.ValueMember = "MAKHOA";

        }
        private void layDSNK(String cmd)
        {
            DataTable dt = new DataTable();
            this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            SqlDataAdapter da = new SqlDataAdapter(cmd, Program.connstr);
            da.Fill(dt);


            cbxNienKhoa.DataSource = dt;
            cbxNienKhoa.DisplayMember = "NIENKHOA";
            cbxNienKhoa.ValueMember = "NIENKHOA";

        }
        private void layDSHK(String cmd)
        {
            DataTable dt = new DataTable();
            //this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            SqlDataAdapter da = new SqlDataAdapter(cmd, Program.connstr);
            da.Fill(dt);


            cbxHocKy.DataSource = dt;
            cbxHocKy.DisplayMember = "HOCKY";
            cbxHocKy.ValueMember = "HOCKY";

        }

        private void Frpt_HPTheoLop_Load(object sender, EventArgs e)
        {
            dS_HP.EnforceConstraints = false;
            this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;

            // TODO: This line of code loads data into the 'dS_HP.SINHVIEN' table. You can move, or remove it, as needed.
            this.sINHVIENTableAdapter.Fill(this.dS_HP.SINHVIEN);

            String strlenh = "SELECT MALOP,MAKHOA FROM LOP ";
            layDSLop(strlenh);
            cbxLop.SelectedIndex = 0;




        }

        private void btnIN_Click(object sender, EventArgs e)
        {

            int hk = 1;
            try
            {
                hk = int.Parse(hocky);
            }
            catch (Exception ex)
            {

            }
            Xrpt_SP_RP_DSDHP rpt = new Xrpt_SP_RP_DSDHP(lop, nienkhoa, hk);

            String k = cbxLop.SelectedValue.ToString().Trim();
            string khoatmp = "";
            if (k=="VT") khoatmp = "Viễn Thông";
            else khoatmp = "Công Nghệ Thông Tin";
           
            rpt.lblKhoa.Text = khoatmp;
            rpt.lblLop.Text = lop;


            if (Program.KetNoi() == 0) return;
            string strlenh= "EXEC SP_RP_SUM_DSDHP '"+ lop+"','" + nienkhoa+"','" + hk + "'";
          
            SqlDataReader myReader = Program.ExecSqlDataReader(strlenh);
            if (myReader == null) return;
            String sum = "";
            myReader.Read();
            try
            {
                 sum = myReader.GetInt32(0).ToString();
            }
            catch(Exception ex) { }
           
            rpt.lblTienChu.Text = MoneyConverter.ConvertMoneyToString(sum);
            


            ReportPrintTool print = new ReportPrintTool(rpt);
            
            print.ShowPreviewDialog();
        }

        private void cbxLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            lop = cbxLop.Text.ToString();
            string strlenh = "SELECT DISTINCT NIENKHOA FROM (SELECT NIENKHOA,MASV FROM HOCPHI) HP "
                + "INNER JOIN (SELECT MASV FROM SINHVIEN WHERE MALOP='" + lop + "') SV "
                + "ON SV.MASV = HP.MASV";
            layDSNK(strlenh);




        }

        private void cbxHocKy_SelectedIndexChanged(object sender, EventArgs e)
        {
            hocky = cbxHocKy.SelectedValue.ToString();
        }

        private void cbxNienKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            nienkhoa = cbxNienKhoa.SelectedValue.ToString();
            String strlenh = "SELECT DISTINCT HOCKY FROM HOCPHI WHERE NIENKHOA='" + nienkhoa + "'";
            layDSHK(strlenh);

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}