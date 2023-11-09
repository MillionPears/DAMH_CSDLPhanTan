using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Reflection;
using System.Data.SqlClient;
using DevExpress.XtraBars;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using QLDSV_TC.Objects;

namespace QLDSV_TC
{
    public partial class FrmLopTinC : DevExpress.XtraEditors.XtraForm
    {
        private Stack<Undo> processStoreStack = new Stack<Undo>();

        private int positionSelectedTC = -1;
        private int positionSelectedClass = -1;
        private String flagMode = "";
        private SqlConnection conn_publisher = new SqlConnection();

        private void pushDataToProcessStack(DataRow data)
        {
            LopTinChi TC = new LopTinChi((int)data["MALTC"],
                data["NIENKHOA"].ToString(), (int)data["HOCKY"], data["MAMH"].ToString(), (int)data["NHOM"],
                data["MAGV"].ToString(), data["MAKHOA"].ToString(), (int)data["SOSVTOITHIEU"], (bool)data["HUYLOP"]);

            processStoreStack.Push(new Undo(flagMode, data["MALTC"].ToString(), TC));
        }
        public FrmLopTinC()
        {
            InitializeComponent();
        }

        private void FrmLopTinC_Load(object sender, EventArgs e)
        {
            
            this.dSMHTableAdapter.Connection.ConnectionString = Program.connstr;
            // TODO: This line of code loads data into the 'dS1.DSMH' table. You can move, or remove it, as needed.
            this.dSMHTableAdapter.Fill(this.dS1.DSMH);


            dS1.EnforceConstraints = false;
            this.dSGVTableAdapter.Connection.ConnectionString = Program.connstr;
            this.dSGVTableAdapter.Fill(this.dS1.DSGV);

            //this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;

            this.lOPTINCHITableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTINCHITableAdapter.Fill(this.dS1.LOPTINCHI);

            this.dANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
            this.dANGKYTableAdapter.Fill(this.dS1.DANGKY);

            Program.bds_dspm.Filter = "TENCN  LIKE 'KHOA%'  ";
            cmbKhoa.DataSource = Program.bds_dspm;
            cmbKhoa.DisplayMember = "TENCN";
            cmbKhoa.ValueMember = "TENSERVER";
            cmbKhoa.SelectedValue = Program.servername;


            //textKhoa.Text = cmbKhoa.Items[Program.mChiNhanh].ToString();


            //    cbKhoa.SelectedIndex = Program.mPhongBan;
            if (Program.mGroup == "PGV")
            {
                cmbKhoa.Enabled = true;
            }
            else
            {
                cmbKhoa.Enabled = false;
            }
            if (Program.mGroup == "SV")
            {

                btnThem.Enabled = btnSua.Enabled = btnGhi.Enabled =
                btnPhuchoi.Enabled = btnHtac.Enabled = btnXoa.Enabled = false;

            }
            else
            {
                btnThem.Enabled = btnSua.Enabled = btnHtac.Enabled = btnXoa.Enabled = true;
                btnGhi.Enabled = btnPhuchoi.Enabled = false;

            }

        }


        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void gridControl1_Click_1(object sender, EventArgs e)
        {

        }

        private void panelControl2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void nHOMSpinEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void mAKHOATextEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void BtnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            positionSelectedTC = BDSLopTinC.Position;
            positionSelectedClass = gvLTC.FocusedRowHandle;
            //pnMH.Enabled = true;
            //gcMonHoc.Enabled = false;
            flagMode = "EDITLOPTINCHI";
            DataRow data = gvLTC.GetFocusedDataRow();
            pushDataToProcessStack(data);
            btnGhi.Enabled = btnHtac.Enabled = btnPhuchoi.Enabled = true;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = false;
        }

        private void cmbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbKhoa.SelectedValue.ToString() == "System.Data.DataRowView")
                return;
            Program.servername = cmbKhoa.SelectedValue.ToString();
            if (cmbKhoa.SelectedIndex != Program.mChiNhanh)
            {
                Program.mlogin = Program.remotelogin;
                Program.mpassword = Program.remotepassword;
            }
            else
            {
                Program.mlogin = Program.mloginDN;
                Program.mpassword = Program.passwordDN;
            }
            if (Program.KetNoi() == 0)
            {
                MessageBox.Show("Lỗi kết nối về chi nhánh mới", "", MessageBoxButtons.OK);
            }
            else
            {
                this.lOPTINCHITableAdapter.Connection.ConnectionString = Program.connstr;
                this.lOPTINCHITableAdapter.Fill(this.dS1.LOPTINCHI);

                this.dANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
                this.dANGKYTableAdapter.Fill(this.dS1.DANGKY);
                Program.mMAKHOA = ((DataRowView)BDSLopTinC[0])["MAKHOA"].ToString();
                textKhoa.Text = (string)Program.mMAKHOA;
            }
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            fillComboboxNienKhoa();
           
            BDSLopTinC.AddNew();
            //pnMH.Enabled = true;
            positionSelectedTC = BDSLopTinC.Count - 1;
            flagMode = "ADDLOPTINCHI";
            cbbNienKhoa.Focus();

            String cmd = "SELECT MAMH FROM dbo.MONHOC";
            DataTable dt = new DataTable();
            dt = Program.ExecSqlDataTable(cmd);
            cmbMAMH.DataSource = dt;
            cmbMAMH.DisplayMember = "MAMH";
            cmbMAMH.ValueMember = "MAMH";
            cmbMAMH.SelectedIndex = 0;

            String cmd1 = "SELECT * FROM dbo.GIANGVIEN";
            DataTable _dt1 = new DataTable();
            _dt1 = Program.ExecSqlDataTable(cmd1);
            cmbMaGV.DataSource = _dt1;
            cmbMaGV.DisplayMember = "MAGV";
            cmbMaGV.ValueMember = "MAGV";
            cmbMaGV.SelectedIndex = 0;

            
            cbHuyLop.Enabled = false;
            cbHuyLop.CheckState = CheckState.Unchecked;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnHtac.Enabled = false;
            btnGhi.Enabled = btnPhuchoi.Enabled = true;

            gcLopTinC.Enabled = false;
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Program.KetNoi() == 0) return;

            if (checkfield() == true)
            {
                try
                {
                    BDSLopTinC.EndEdit();
                    BDSLopTinC.ResetCurrentItem();

                    this.lOPTINCHITableAdapter.Connection.ConnectionString = Program.connstr;

                    DataRow row = ((DataRowView)BDSLopTinC[BDSLopTinC.Position]).Row;
                    this.lOPTINCHITableAdapter.Update(row);

                    if (flagMode == "ADDLOPTINCHI")
                    {
                        DataRow data = gvLTC.GetFocusedDataRow();
                        pushDataToProcessStack(data);
                    }


                    MessageBox.Show("Thêm  lớp tín chỉ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi ghi sinh viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                flagMode = "";
                positionSelectedTC = -1;
                gcLopTinC.Enabled = true;
                btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnHtac.Enabled = true;
                btnGhi.Enabled = btnHtac.Enabled = false;
                //this.DisablePanelControl();
            }
        }
        private void fillComboboxNienKhoa()
        {
            int currentYear = DateTime.Now.Year;

            for (int i = 2015; i <= currentYear - 1; i++)
                cbbNienKhoa.Items.Add((i.ToString() + "-" + (i + 1).ToString()));
        }
        private int KiemTraTrung(String strLenh)
        {

            SqlDataReader dataReader = Program.ExecSqlDataReader(strLenh);

            // nếu null thì thoát luôn  ==> lỗi kết nối
            if (dataReader == null)
            {
                return -1;
            }
            dataReader.Read();
            int result = int.Parse(dataReader.GetValue(0).ToString());
            dataReader.Close();
            return result;
        }
        private bool checkfield()
        {
            if (flagMode == "ADDLOPTINCHI")
            {
                if (cbbNienKhoa.Text.Trim().Equals(" "))
                {
                    MessageBox.Show("Niên khoá không được để trống", "", MessageBoxButtons.OK);
                    cbbNienKhoa.Focus();
                    return false;
                }

                if (spinSL.Text.Trim().Equals(" ") ||spinSL.Value <0 )
                {
                    MessageBox.Show("Số lượng không được để trống hoặc giá trị âm", "", MessageBoxButtons.OK);
                    spinSL.Focus();
                    return false;
                }

                string strLenh = "DECLARE  @return_value int \n"
                 + "EXEC	@return_value = [dbo].[CHECK_LOPTC] \n"
                                + "@NIENKHOA = N'" + cbbNienKhoa.Text + "',@HOCKY = N'" + cbbHK.SelectedItem
                                + "',@MAMH = N'" + cmbMAMH.SelectedValue.ToString() + "',@NHOM = N'" + cbbNhom.SelectedItem + "' \n"
                                + "SELECT  'Return Value' = @return_value ";
                int result = this.KiemTraTrung(strLenh);
                MessageBox.Show(result.ToString());
                if (result == 1)
                {
                    MessageBox.Show("Lớp tín chỉ đã có trong cơ sơ dữ liệu", "", MessageBoxButtons.OK);
                    cbbNienKhoa.Focus();
                    return false;
                }
            }

            return true;
        }

        private void btnXoa_ItemClick(object sender, ItemClickEventArgs e)
        {
            string MALTC = "";

            if (BDSDK.Count > 0)
            {
                MessageBox.Show("Không thể xóa  Lớp tín chỉ này vì  đã  có giảng viên dạy ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("Bạn có thật sự muốn xóa lớp tín chỉ này ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                try
                {
                    DataRow data = gvLTC.GetFocusedDataRow();
                    MALTC = data["MALTC"].ToString();

                    flagMode = "DELETELOPTINCHI";
                    pushDataToProcessStack(data);

                    data.Delete();

                    this.lOPTINCHITableAdapter.Connection.ConnectionString = Program.connstr;
                    this.lOPTINCHITableAdapter.Update(this.dS1.LOPTINCHI);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa sinh viên: " + ex.Message, "", MessageBoxButtons.OK);
                    this.lOPTINCHITableAdapter.Fill(this.dS1.LOPTINCHI);
                    BDSLopTinC.Position = BDSLopTinC.Find("MAMH", MALTC);
                    processStoreStack.Pop();
                    flagMode = "";
                    return;
                }

                btnThem.Enabled = btnPhuchoi.Enabled = true;
                btnXoa.Enabled = btnSua.Enabled = false;
            }
        }

        private void btnPhuchoi_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (processStoreStack.Count > 0)
            {
                Undo command = processStoreStack.Pop();   // Lấy ra 1 đối tượng Redo ( gồm primarykey, object SV)
                String MALTC = command.primaryKey;

                LopTinChi LTC = new LopTinChi();
                LTC = (LopTinChi)command.dataRow;

                switch (command.flagMode)
                {
                    case "ADDlOPTINCHI":

                        int rowIndex = gvLTC.LocateByValue("MAMH", MALTC);  // trả về giá trị của dòng có mã sv

                        if (rowIndex != -1)
                        {
                            MessageBox.Show("Row index: " + rowIndex.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        try
                        {
                            //MessageBox.Show(MAMH);
                            gvLTC.DeleteRow(rowIndex);
                            this.lOPTINCHITableAdapter.Update(this.dS1.LOPTINCHI);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Lỗi xóa Môn học: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            this.lOPTINCHITableAdapter.Fill(this.dS1.LOPTINCHI);
                            return;
                        }
                        break;

                    case "DELETELOPTINCHI":


                        try
                        {
                            BDSLopTinC.AddNew();  // thêm dòng và trỏ đến dòng đó

                            gvLTC.SetFocusedRowCellValue("MALTC", LTC.MaLTC);  // thêm dữ liệu trên dòng đang đucợ trỏ đến
                            gvLTC.SetFocusedRowCellValue("NIENKHOA", LTC.NienKhoa);
                            gvLTC.SetFocusedRowCellValue("HOCKY", LTC.HocKy);
                            gvLTC.SetFocusedRowCellValue("MAMH", LTC.MaMH);
                            gvLTC.SetFocusedRowCellValue("NHOM", LTC.Nhom);
                            gvLTC.SetFocusedRowCellValue("MAGV", LTC.MaGV);
                            gvLTC.SetFocusedRowCellValue("MAKHOA", LTC.MaKhoa);
                            gvLTC.SetFocusedRowCellValue("SOSVTOITHIEU", LTC.SVToiThieu);
                            gvLTC.SetFocusedRowCellValue("HUYLOP", LTC.HuyLop);

                            //gvSV.SetFocusedRowCellValue("PASSWORD", SV.PassWord);

                            BDSLopTinC.EndEdit();
                            this.lOPTINCHITableAdapter.Update(this.dS1.LOPTINCHI);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Lỗi khôi phục Môn học : " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            this.lOPTINCHITableAdapter.Fill(this.dS1.LOPTINCHI);
                            return;
                        }
                        break;

                    default:  // Flagmode = EDITSTUDENT

                        positionSelectedTC = gvLTC.LocateByValue("MALTC", MALTC);
                        gvLTC.FocusedRowHandle = positionSelectedTC;

                        try
                        {
                            gvLTC.SetFocusedRowCellValue("MALTC", LTC.MaLTC);  // thêm dữ liệu trên dòng đang đucợ trỏ đến
                            gvLTC.SetFocusedRowCellValue("NIENKHOA", LTC.NienKhoa);
                            gvLTC.SetFocusedRowCellValue("HOCKY", LTC.HocKy);
                            gvLTC.SetFocusedRowCellValue("MAMH", LTC.MaMH);
                            gvLTC.SetFocusedRowCellValue("NHOM", LTC.Nhom);
                            gvLTC.SetFocusedRowCellValue("MAGV", LTC.MaGV);
                            gvLTC.SetFocusedRowCellValue("MAKHOA", LTC.MaKhoa);
                            gvLTC.SetFocusedRowCellValue("SOSVTOITHIEU", LTC.SVToiThieu);
                            gvLTC.SetFocusedRowCellValue("HUYLOP", LTC.HuyLop);


                            BDSLopTinC.EndEdit();
                            this.lOPTINCHITableAdapter.Update(this.dS1.LOPTINCHI);

                            positionSelectedTC = -1;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Lỗi khôi phục sinh viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            this.lOPTINCHITableAdapter.Fill(this.dS1.LOPTINCHI);
                            return;
                        }
                        break;
                }

                if (processStoreStack.Count == 0)
                    btnPhuchoi.Enabled = false;
            }
        }

        private void btnHtac_ItemClick(object sender, ItemClickEventArgs e)
        {
            BDSLopTinC.CancelEdit();
            // if (btnThem.Enabled == false) BDSLopTinC.Position = vitri;
            gcLopTinC.Enabled = true;
            gcLopTinC.Dock = DockStyle.Fill;
            //this.DisablePanelControl();
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnPhuchoi.Enabled = true;
            btnGhi.Enabled = btnHtac.Enabled = false;
        }

        private void gridView1_RowClick(object sender, RowClickEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cbbNienKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void spinSL_EditValueChanged(object sender, EventArgs e)
        {
          
        }

        private void cbbMaKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void mAKHOALabel1_Click(object sender, EventArgs e)
        {

        }

        private void mAKHOATextEdit_EditValueChanged_1(object sender, EventArgs e)
        {

        }

        private void cmbMaGV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMaGV.Text != "System.Data.DataRowView" && cmbMaGV.Text != null)
            {
                cbbTenGV.SelectedValue = cmbMaGV.Text;
            }
            
        }


        private void cmbMAMH_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMAMH.Text != "System.Data.DataRowView" && cmbMAMH.Text != null)
            {
                cbbtenMH.SelectedValue = cmbMAMH.Text;
            }
        }

        private void cbbTenGV_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbbTenGV.SelectedValue != null)
                cmbMaGV.Text = cbbTenGV.SelectedValue.ToString();


        }

        private void cbbtenMH_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbbtenMH.SelectedValue != null)
               cmbMAMH.Text = cbbtenMH.SelectedValue.ToString();

        }
    }
}