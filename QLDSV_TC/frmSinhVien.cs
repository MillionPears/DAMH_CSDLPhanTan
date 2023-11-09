using DevExpress.XtraEditors.Repository;

using QLDSV_TC.Objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDSV_TC
{

    public partial class frmSinhVien : Form
    {
        private Stack<Redo> processStoreStack = new Stack<Redo>();
        // private String classNumberSelected = "";
        private int positionSelectedSV = -1;
        private int positionSelectedClass = -1;
        private String flagMode = "";

        public frmSinhVien()
        {
            InitializeComponent();
        }

        // Thêm 1 SinhVien vào Stack
        private void pushDataToProcessStack(DataRow data)
        {
            SinhVien SV = new SinhVien(data["MASV"].ToString(),
               data["HO"].ToString(), data["TEN"].ToString(), (bool)data["PHAI"], data["DIACHI"].ToString(), data["NGAYSINH"].ToString(),
               data["MALOP"].ToString(), (bool)data["DANGHIHOC"]);

            processStoreStack.Push(new Redo(flagMode, data["MASV"].ToString(), SV));
        }
        private void frmSinhVien_Load(object sender, EventArgs e)
        {

            qLDSV_TCDataSet.EnforceConstraints = false;

            this.kHOATableAdapter.Connection.ConnectionString = Program.connstr;
            this.kHOATableAdapter.Fill(this.qLDSV_TCDataSet.KHOA);

            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTableAdapter.Fill(this.qLDSV_TCDataSet.LOP);

            this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sINHVIENTableAdapter.Fill(this.qLDSV_TCDataSet.SINHVIEN);

            this.dANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
            this.dANGKYTableAdapter.Fill(this.qLDSV_TCDataSet.DANGKY);

            var filteredList = Program.bds_dspm.OfType<DataRowView>()
                .Where(x => x["TENCN"].ToString() == "KHOA CÔNG NGHỆ THÔNG TIN" || x["TENCN"].ToString() == "KHOA VIỄN THÔNG")
                .ToList();

            cbbKhoa.DataSource = filteredList;

            cbbKhoa.DisplayMember = "TENCN"; cbbKhoa.ValueMember = "TENSERVER";
            cbbKhoa.SelectedIndex = Program.mKhoa;
            if (Program.mGroup == "PGV")
            {
                cbbKhoa.Enabled = true;
            }
            else cbbKhoa.Enabled = false;

            txtMaLop.Enabled = false;
            //
        }



        private void cbbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbKhoa.SelectedValue.ToString() == "System.Data.DataRowView") { return; }
            Program.servername = cbbKhoa.SelectedValue.ToString();
            if (cbbKhoa.SelectedIndex != Program.mKhoa)
            {
                Program.mlogin = Program.remotelogin;
                Program.password = Program.remotepassword;
            }
            else
            {
                Program.mlogin = Program.mloginDN;
                Program.password = Program.passwordDN;
            }
            if (Program.KetNoi() == 0)
            {
                MessageBox.Show("Lỗi kết nối không thành công! ", "", MessageBoxButtons.OK);
            }
            else
            {

                this.kHOATableAdapter.Connection.ConnectionString = Program.connstr;
                this.kHOATableAdapter.Fill(this.qLDSV_TCDataSet.KHOA);
                //
                this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                this.lOPTableAdapter.Fill(this.qLDSV_TCDataSet.LOP);
                //
                this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sINHVIENTableAdapter.Fill(this.qLDSV_TCDataSet.SINHVIEN);

            }
        }


        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            qLDSV_TCDataSet.SINHVIEN.PHAIColumn.DefaultValue = false;
            qLDSV_TCDataSet.SINHVIEN.DANGHIHOCColumn.DefaultValue = false;

            bdsSinhVien.AddNew();

            positionSelectedSV = bdsSinhVien.Count - 1;
            btnAdd.Enabled = btnEdit.Enabled = btnDelete.Enabled = btnRedo.Enabled = cbbKhoa.Enabled = false;
            btnSave.Enabled = true;
            flagMode = "ADDSTUDENT";
        }
        private bool CheckDataSV()
        {

            DataRowView dataSV = (DataRowView)bdsSinhVien[positionSelectedSV];
            if (dataSV["MASV"].ToString().Trim() == "")
            {
                MessageBox.Show("Mã sinh viên không được để trống", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (dataSV["HO"].ToString().Trim() == "")
            {
                MessageBox.Show("Họ không được thiếu!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return false;
            }

            if (dataSV["TEN"].ToString().Trim() == "")
            {
                MessageBox.Show("Tên không được thiếu!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (dataSV["PHAI"].ToString() == "")
            {
                MessageBox.Show("Vui Lòng Chọn Phái!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (flagMode == "ADDSTUDENT")
            {
                string query = " DECLARE @return_value INT" +

                               " EXEC @return_value = [dbo].[SP_CHECK_MASV]" +

                               " N'" + dataSV["MASV"].ToString().Trim() + "', " +

                               " N'SINHVIEN'" +

                               " SELECT @return_value";

                int resultMa = Program.CheckPrimaryKey(query);
                if (resultMa == -1)
                {
                    MessageBox.Show("Lỗi kết nối với database. Vui long thử lại sau!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                if (resultMa == 1)
                {
                    MessageBox.Show("Mã Sinh Viên đã tồn tại. Mời bạn nhập mã khác !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }

            return true;
        }

        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Program.KetNoi() == 0) return;

            if (CheckDataSV())
            {
                try
                {
                    qLDSV_TCDataSet.SINHVIEN.PASSWORDColumn.DefaultValue = "123";
                    bdsSinhVien.EndEdit();
                    bdsSinhVien.ResetCurrentItem();

                    this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;

                    DataRow row = ((DataRowView)bdsSinhVien[bdsSinhVien.Position]).Row;
                    this.sINHVIENTableAdapter.Update(row);

                    if (flagMode == "ADDSTUDENT")
                    {
                        DataRow data = gvSV.GetFocusedDataRow();
                        pushDataToProcessStack(data);
                    }

                    MessageBox.Show("Thêm sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi ghi sinh viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                flagMode = "";
                positionSelectedSV = -1;

                btnAdd.Enabled = btnRedo.Enabled = cbbKhoa.Enabled = true;
                btnSave.Enabled = false;
            }
        }

        private void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string MASV = "";

            if (bdsDK.Count > 0)
            {
                MessageBox.Show("Không thể xóa sinh viên này vì sinh viên đã đăng kí lớp tín chỉ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("Bạn có thật sự muốn xóa sinh viên khỏi lớp học này ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                try
                {
                    DataRow data = gvSV.GetFocusedDataRow();
                    MASV = data["MASV"].ToString();

                    flagMode = "DELETESTUDENT";
                    pushDataToProcessStack(data);

                    data.Delete();

                    this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.sINHVIENTableAdapter.Update(this.qLDSV_TCDataSet.SINHVIEN);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa sinh viên: " + ex.Message, "", MessageBoxButtons.OK);
                    this.sINHVIENTableAdapter.Fill(this.qLDSV_TCDataSet.SINHVIEN);
                    bdsSinhVien.Position = bdsSinhVien.Find("MASV", MASV);
                    processStoreStack.Pop();
                    flagMode = "";
                    return;
                }

                btnAdd.Enabled = btnRedo.Enabled = true;
                btnDelete.Enabled = btnEdit.Enabled = false;
            }
        }

        private void btnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            positionSelectedSV = bdsSinhVien.Position;
            positionSelectedClass = gvLop.FocusedRowHandle;

            flagMode = "EDITSTUDENT";
            DataRow data = gvSV.GetFocusedDataRow();
            pushDataToProcessStack(data);

            btnSave.Enabled = true;
            btnAdd.Enabled = btnDelete.Enabled = btnEdit.Enabled = btnRedo.Enabled = cbbKhoa.Enabled = false;
        }

        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (flagMode == "EDITSTUDENT" || flagMode == "ADDSTUDENT")
            {
                DialogResult dialog = MessageBox.Show("Bạn đang trong quá trình chỉnh sửa thông tin bạn thật sự muốn làm mới không?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialog == DialogResult.No)
                {
                    return;
                }
                else
                {
                    flagMode = "";
                    positionSelectedSV = -1;
                }
            }

            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTableAdapter.Fill(this.qLDSV_TCDataSet.LOP);

            this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sINHVIENTableAdapter.Fill(this.qLDSV_TCDataSet.SINHVIEN);


            // reloadDataForm();

            btnAdd.Enabled = cbbKhoa.Enabled = true;
            btnSave.Enabled = btnDelete.Enabled = btnEdit.Enabled = false;
        }

        private void btnExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (flagMode != "EDITSTUDENT" && flagMode != "ADDSTUDENT")
            {
                this.Close();
            }
            else
            {
                DialogResult dialog = MessageBox.Show("Bạn đang trong quá trình chỉnh sửa thông tin bạn thật sự muốn thoát không?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialog == DialogResult.Yes)
                {
                    this.Close();
                }
            }
        }

        private void gvSV_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {

            if ((flagMode == "EDITSTUDENT" || flagMode == "ADDSTUDENT") && bdsSinhVien.Position != positionSelectedSV)
            {
                DialogResult dialog = MessageBox.Show("Bạn đang trong quá trình chỉnh sửa thông tin bạn thật sự muốn làm mới không?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialog == DialogResult.No)
                {
                    e.Handled = true;
                    gvSV.FocusedRowHandle = positionSelectedSV;
                    return;
                }
                else
                {
                    this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.lOPTableAdapter.Fill(this.qLDSV_TCDataSet.LOP);

                    this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.sINHVIENTableAdapter.Fill(this.qLDSV_TCDataSet.SINHVIEN);
                    flagMode = "";
                    positionSelectedSV = -1;
                }
            }
            if (bdsSinhVien.Position != positionSelectedSV)
            {
                btnDelete.Enabled = btnEdit.Enabled = cbbKhoa.Enabled = true;
            }
        }

        private void gvSV_ShowingEditor(object sender, CancelEventArgs e)
        {
            if (bdsSinhVien.Position != positionSelectedSV)
                e.Cancel = true;
        }

        private void btnCancel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnRedo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (processStoreStack.Count > 0)
            {
                Redo command = processStoreStack.Pop();   // Lấy ra 1 đối tượng Redo ( gồm primarykey, object SV)
                String MASV = command.primaryKey;
                SinhVien SV = new SinhVien();
                SV = (SinhVien)command.dataRow;

                switch (command.flagMode)
                {
                    case "ADDSTUDENT":
                        gvLop.FocusedRowHandle = gvLop.LocateByValue("MALOP", SV.MaLop); // chọn dòng có MÃ lớp
                        int rowIndex = gvSV.LocateByValue("MASV", MASV);  // trả về giá trị của dòng có mã sv

                        try
                        {
                            gvSV.DeleteRow(rowIndex);
                            this.sINHVIENTableAdapter.Update(this.qLDSV_TCDataSet.SINHVIEN);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Lỗi xóa sinh viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            this.sINHVIENTableAdapter.Fill(this.qLDSV_TCDataSet.SINHVIEN);
                            return;
                        }
                        break;

                    case "DELETESTUDENT":
                        gvLop.FocusedRowHandle = gvLop.LocateByValue("MALOP", SV.MaLop);

                        try
                        {
                            bdsSinhVien.AddNew();  // thêm dòng và trỏ đến dòng đó

                            gvSV.SetFocusedRowCellValue("MASV", SV.MaSV);  // thêm dữ liệu trên dòng đang đucợ trỏ đến
                            gvSV.SetFocusedRowCellValue("HO", SV.Ho);
                            gvSV.SetFocusedRowCellValue("TEN", SV.Ten);
                            gvSV.SetFocusedRowCellValue("PHAI", SV.Phai);
                            gvSV.SetFocusedRowCellValue("NGAYSINH", SV.NgaySinh);
                            gvSV.SetFocusedRowCellValue("DIACHI", SV.DiaChi);
                            gvSV.SetFocusedRowCellValue("MALOP", SV.MaLop);
                            gvSV.SetFocusedRowCellValue("DANGHIHOC", SV.DangNghiHoc);
                            //gvSV.SetFocusedRowCellValue("PASSWORD", SV.PassWord);

                            bdsSinhVien.EndEdit();
                            this.sINHVIENTableAdapter.Update(this.qLDSV_TCDataSet.SINHVIEN);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Lỗi khôi phục sinh viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            this.sINHVIENTableAdapter.Fill(this.qLDSV_TCDataSet.SINHVIEN);
                            return;
                        }
                        break;

                    default:  // Flagmode = EDITSTUDENT
                        gvLop.FocusedRowHandle = gvLop.LocateByValue("MALOP", SV.MaLop);
                        positionSelectedSV = gvSV.LocateByValue("MASV", MASV);
                        gvSV.FocusedRowHandle = positionSelectedSV;

                        try
                        {
                            gvSV.SetRowCellValue(positionSelectedSV, "HO", SV.Ho); // thêm dữ liệu vào dòng có chỉ số index
                            gvSV.SetRowCellValue(positionSelectedSV, "TEN", SV.Ten);
                            gvSV.SetRowCellValue(positionSelectedSV, "PHAI", SV.Phai);
                            gvSV.SetRowCellValue(positionSelectedSV, "NGAYSINH", SV.NgaySinh);
                            gvSV.SetRowCellValue(positionSelectedSV, "DIACHI", SV.DiaChi);
                            gvSV.SetRowCellValue(positionSelectedSV, "DANGHIHOC", SV.DangNghiHoc);

                            bdsSinhVien.EndEdit();
                            this.sINHVIENTableAdapter.Update(this.qLDSV_TCDataSet.SINHVIEN);

                            positionSelectedSV = -1;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Lỗi khôi phục sinh viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            this.sINHVIENTableAdapter.Fill(this.qLDSV_TCDataSet.SINHVIEN);
                            return;
                        }
                        break;
                }

                if (processStoreStack.Count == 0)
                    btnRedo.Enabled = false;
            }
        }
    }
}
