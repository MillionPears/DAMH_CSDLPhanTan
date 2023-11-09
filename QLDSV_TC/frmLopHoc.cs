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
    public partial class frmLopHoc : Form
    {
        private Stack<Redo> processStoreStack = new Stack<Redo>();
        private int positionSelectedClass = -1;
        private String flagMode = "";
        public frmLopHoc()
        {
            InitializeComponent();
        }

        private void pushDataToProcessStack(DataRow data)
        {
            Lop lop = new Lop(data["MALOP"].ToString(), data["TENLOP"].ToString()
                , data["KHOAHOC"].ToString(), data["MAKHOA"].ToString());

            processStoreStack.Push(new Redo(flagMode, data["MALOP"].ToString(), lop));
        }
        private void frmLopHoc_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLDSV_TCDataSet.SINHVIEN' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'qLDSV_TCDataSet.SINHVIEN' table. You can move, or remove it, as needed.

            qLDSV_TCDataSet.EnforceConstraints = false;

            this.kHOATableAdapter.Connection.ConnectionString = Program.connstr;
            this.kHOATableAdapter.Fill(this.qLDSV_TCDataSet.KHOA);
            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTableAdapter.Fill(this.qLDSV_TCDataSet.LOP);
            this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sINHVIENTableAdapter.Fill(this.qLDSV_TCDataSet.SINHVIEN);
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
        }

        private void cbbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbKhoa.SelectedValue.ToString() == "System.Data.DataRowView") // ktra xem có phải cbbKhoa đang chọn giá trị mặc định hay không 
                return;
            Program.servername = cbbKhoa.SelectedValue.ToString();

            if (cbbKhoa.SelectedIndex != Program.mKhoa) // nếu mà khác với Khoa ban đầu chọn thì sử dụng link server để kết nối
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
                MessageBox.Show("Lỗi kết nối về chi nhánh mới", "", MessageBoxButtons.OK);
                return;
            }
            else
            {
                this.kHOATableAdapter.Connection.ConnectionString = Program.connstr;
                this.kHOATableAdapter.Fill(this.qLDSV_TCDataSet.KHOA);
                this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                this.lOPTableAdapter.Fill(this.qLDSV_TCDataSet.LOP);
                this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sINHVIENTableAdapter.Fill(this.qLDSV_TCDataSet.SINHVIEN);

            }
        }

        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            bdsLop.AddNew();

            positionSelectedClass = bdsLop.Count - 1;

            btnAdd.Enabled = btnEdit.Enabled = btnDelete.Enabled = btnRedo.Enabled = cbbKhoa.Enabled = false;
            btnSave.Enabled = true;

            flagMode = "ADDCLASS";
        }

        private bool checkDataClass()
        {
            DataRowView dataClass = (DataRowView)bdsLop[positionSelectedClass];
            MessageBox.Show(dataClass["MALOP"].ToString());
            if (dataClass["MALOP"].ToString().Trim() == "")
            {
                MessageBox.Show("Mã lớp không được để trống", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (dataClass["TENLOP"].ToString().Trim() == "")
            {
                MessageBox.Show("Tên lớp không được thiếu!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return false;
            }
            if (dataClass["KHOAHOC"].ToString().Trim() == "")
            {
                MessageBox.Show("Khóa học không được thiếu!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (dataClass["MAKHOA"].ToString() == "")
            {
                MessageBox.Show("Mã khoa không được để trống!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (flagMode == "ADDCLASS")
            {
                string query = " DECLARE @return_value INT" +

                               " EXEC @return_value = [dbo].[SP_CHECK_MALOP]" +

                               " N'" + dataClass["MALOP"].ToString().Trim() + "', " +

                               " 'LOP'" +

                               " SELECT @return_value";

                int resultMa = Program.CheckPrimaryKey(query);
                if (resultMa == -1)
                {
                    MessageBox.Show("Lỗi kết nối với database.\n Vui long thử lại sau!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                if (resultMa == 1)
                {
                    MessageBox.Show("Mã lớp đã tồn tại.\n Mời bạn nhập mã khác !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                if (resultMa == 2)
                {
                    MessageBox.Show("Mã lớp đã tồn tại ở khoa khác.\n Mời bạn nhập lại !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }

            if (flagMode == "ADDCLASS" || flagMode == "EDITCLASS")
            {
                string query = " DECLARE @return_value INT" +

                               " EXEC @return_value = [dbo].[SP_CHECK_TENLOP]" +

                               " N'" + dataClass["TENLOP"].ToString().Trim() + "', " +

                               " 'LOP'" +

                               " SELECT @return_value";

                int resultMa = Program.CheckPrimaryKey(query);
                if (resultMa == -1)
                {
                    MessageBox.Show("Lỗi kết nối với database.\n Vui long thử lại sau!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                if (resultMa == 1)
                {
                    MessageBox.Show("Tên lớp đã tồn tại.\n Mời bạn nhập mã khác !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                if (resultMa == 2)
                {
                    MessageBox.Show("Tên lớp đã tồn tại ở khoa khác.\n Mời bạn nhập lại !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }

            return true;
        }
        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Program.KetNoi() == 0) return;

            if (checkDataClass())
            {
                try
                {
                    bdsLop.EndEdit();
                    bdsLop.ResetCurrentItem();
                    this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                    DataRow row = ((DataRowView)bdsLop[bdsLop.Position]).Row;
                    this.lOPTableAdapter.Update(row);
                    MessageBox.Show("Thêm lớp thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (flagMode == "ADDCLASS")
                        processStoreStack.Push(new Redo(flagMode, row["MALOP"].ToString()));

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi ghi lớp: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                flagMode = "";
                positionSelectedClass = -1;

                btnAdd.Enabled = btnRedo.Enabled = cbbKhoa.Enabled = true;
                btnSave.Enabled = false;
            }
        }

        private void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String MALOP = "";
            if (bdsSV.Count > 0)
            {
                MessageBox.Show("Không thể xóa lớp này vì đã có sinh viên trong lớp", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("Bạn có thật sự muốn xóa lớp học này ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                try
                {
                    DataRow data = gvLop.GetFocusedDataRow();
                    MALOP = data["MALOP"].ToString();

                    flagMode = "DELETECLASS";
                    pushDataToProcessStack(data);

                    data.Delete();

                    this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.lOPTableAdapter.Update(this.qLDSV_TCDataSet.LOP);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa lớp: " + ex.Message, "", MessageBoxButtons.OK);
                    this.lOPTableAdapter.Fill(this.qLDSV_TCDataSet.LOP);
                    bdsLop.Position = bdsLop.Find("MALOP", MALOP);
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
            positionSelectedClass = gvLop.FocusedRowHandle;

            flagMode = "EDITCLASS";

            DataRow data = gvLop.GetFocusedDataRow();
            pushDataToProcessStack(data);

            btnSave.Enabled = true;
            btnAdd.Enabled = btnDelete.Enabled = btnEdit.Enabled = btnRedo.Enabled = cbbKhoa.Enabled = false;

        }

        private void btnCancel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (flagMode == "EDITCLASS" || flagMode == "ADDCLASS")
            {
                DialogResult dialog = MessageBox.Show("Bạn đang trong quá trình chỉnh sửa thông tin bạn thật sự muốn làm mới không?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialog == DialogResult.No)
                {
                    return;
                }
                else
                {
                    flagMode = "";
                    positionSelectedClass = -1;
                }
            }

            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTableAdapter.Fill(this.qLDSV_TCDataSet.LOP);
            this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sINHVIENTableAdapter.Fill(this.qLDSV_TCDataSet.SINHVIEN);
            btnAdd.Enabled = cbbKhoa.Enabled = true;
            btnSave.Enabled = btnDelete.Enabled = btnEdit.Enabled = false;
        }

        private void btnExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (flagMode != "EDITCLASS" && flagMode != "ADDCLASS")
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

        private void gvLop_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if ((flagMode == "EDITCLASS" || flagMode == "ADDCLASS") && bdsLop.Position != positionSelectedClass)
            {
                DialogResult dialog = MessageBox.Show("Bạn đang trong quá trình chỉnh sửa thông tin bạn thật sự muốn làm mới không?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialog == DialogResult.No)
                {
                    gvLop.FocusedRowHandle = positionSelectedClass;
                    return;
                }
                else
                {
                    flagMode = "";
                    positionSelectedClass = -1;
                }
            }

            btnDelete.Enabled = btnEdit.Enabled = true;

            if (Program.mGroup == "PGV")
                cbbKhoa.Enabled = true;
        }

        private void gvLop_ShowingEditor(object sender, CancelEventArgs e)
        {
            if (bdsLop.Position != positionSelectedClass)
                e.Cancel = true;
        }

        private void btnRedo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (processStoreStack.Count > 0)
            {
                Redo command = processStoreStack.Pop();
                String MALOP = command.primaryKey;
                Lop lop = new Lop();

                switch (command.flagMode)
                {
                    case "ADDCLASS":
                        int rowIndex = gvLop.LocateByValue("MALOP", MALOP);

                        try
                        {
                            gvLop.DeleteRow(rowIndex);
                            this.lOPTableAdapter.Update(this.qLDSV_TCDataSet.LOP);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Lỗi xóa lớp: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            this.lOPTableAdapter.Fill(this.qLDSV_TCDataSet.LOP);
                            return;
                        }
                        break;

                    case "DELETECLASS":
                        lop = (Lop)command.dataRow;

                        try
                        {
                            bdsLop.AddNew();

                            gvLop.SetFocusedRowCellValue("MALOP", lop.MaLop);
                            gvLop.SetFocusedRowCellValue("TENLOP", lop.TenLop);
                            gvLop.SetFocusedRowCellValue("KHOAHOC", lop.KhoaHoc);
                            gvLop.SetFocusedRowCellValue("MAKHOA", lop.MaKhoa);

                            bdsLop.EndEdit();

                            this.lOPTableAdapter.Update(this.qLDSV_TCDataSet.LOP);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Lỗi khôi phục lớp: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            this.lOPTableAdapter.Fill(this.qLDSV_TCDataSet.LOP);
                            return;
                        }
                        break;

                    default:
                        lop = (Lop)command.dataRow;

                        MessageBox.Show(lop.MaLop + " " + lop.TenLop + " " + lop.KhoaHoc + " " + lop.MaKhoa);

                        positionSelectedClass = gvLop.LocateByValue("MALOP", lop.MaLop);
                        gvLop.FocusedRowHandle = positionSelectedClass;

                        try
                        {
                            gvLop.SetFocusedRowCellValue("TENLOP", lop.TenLop);
                            gvLop.SetFocusedRowCellValue("KHOAHOC", lop.KhoaHoc);

                            bdsLop.EndEdit();

                            this.lOPTableAdapter.Update(this.qLDSV_TCDataSet.LOP);

                            positionSelectedClass = -1;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Lỗi khôi phục lớp: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            this.lOPTableAdapter.Fill(this.qLDSV_TCDataSet.LOP);
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
