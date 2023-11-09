using DevExpress.XtraSpellChecker.Parser;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using QLDSV_TC.Objects;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Internal.WinApi.Windows.UI.Notifications;
using System.Collections.Specialized;

namespace QLDSV_TC
{
    public partial class FormMonH : Form
    {
        private Stack<Undo> processStoreStack = new Stack<Undo>();

        private int positionSelectedMH = -1;
        private int positionSelectedClass = -1;
        private String flagMode = "";
        public FormMonH()
        {
            InitializeComponent();
        }


        string oldMaMH = "";
        String oldTenMH = "";



        private void pushDataToProcessStack(DataRow data)
        {
            MonHoc MH = new MonHoc(data["MAMH"].ToString(),
                data["TENMH"].ToString(), (int)data["SOTIET_LT"], (int)data["SOTIET_TH"]);

            processStoreStack.Push(new Undo(flagMode, data["MAMH"].ToString(), MH));
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


        private bool CheckDataSV()
        {

            DataRowView dataMH = (DataRowView)BDSMHoc[positionSelectedMH];
            if (dataMH["MAMH"].ToString().Trim() == "")
            {
                MessageBox.Show("Mã sinh viên không được để trống", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (dataMH["TENMH"].ToString().Trim() == "")
            {
                MessageBox.Show("Họ không được thiếu!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return false;
            }

            if (dataMH["SOTIET_LT"].ToString().Trim() == "")
            {
                MessageBox.Show("Tên không được thiếu!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (dataMH["SOTIET_TH"].ToString() == "")
            {
                MessageBox.Show("Vui Lòng Chọn Phái!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (spinSTLT.Value < 0)
            {
                MessageBox.Show("Số Tiết Lý Thuyết >= 0!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                spinSTLT.Focus();
                return false;
            }
            if (spinSTTH.Value < 0)
            {
                MessageBox.Show("Số tiết thưc hành >= 0!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                spinSTTH.Focus();
                return false;
            }
            if ((spinSTLT.Value + spinSTTH.Value) <= 0 || (spinSTLT.Value + spinSTTH.Value) % 15 != 0)
            {
                MessageBox.Show("Số Tiết LT + Số Tiết TH phải lơn hơn 0 và là bội số của 15 (1 tín chỉ)", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                spinSTLT.Focus();
                return false;
            }

            if (flagMode == "ADDMONHOC")
            {
                string strLenh = "DECLARE  @return_value int \n"
                         + "EXEC  @return_value = SP_CHECKID \n"
                         + "@Code = N'" + dataMH["MAMH"].ToString().Trim() + "',@Type = N'MAMONHOC' \n"
                         + "SELECT  'Return Value' = @return_value ";

                int result = KiemTraTrung(strLenh);
                ;
                if (result == -1)
                {
                    MessageBox.Show("Lỗi kết nối với database. Vui lòng thử lại sau", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                if (result != 0)
                {
                    MessageBox.Show("Mã Môn Học đã tồn tại. Mời bạn nhập mã khác !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMaMH.Focus();
                    return false;
                }
            }

            if (flagMode == "ADDMONHOC" || (flagMode == "EDITMONHOC" && oldTenMH != txtTenMH.Text.Trim()))
            {
                string strLenh1 = "DECLARE @return_value int \n"
                                  + "EXEC @return_value = SP_CHECKNAME \n"
                                  + "@Name = N'" + dataMH["TENMH"].ToString().Trim() + "', @Type = N'TENMONHOC' \n"
                                  + "SELECT 'Return Value' = @return_value ";
                int result1 = KiemTraTrung(strLenh1);

                if (result1 == -1)
                {
                    MessageBox.Show("Lỗi kết nối với database. Vui lòng thử lại sau", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                if (result1 != 0)
                {
                    MessageBox.Show("Tên Môn Học đã tồn tại. Mời bạn nhập tên khác !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTenMH.Focus();
                    return false;
                }
            }

            return true;
        }

        private void FormMonH_Load(object sender, EventArgs e)
        {
            qLDSV_TCDataSet2.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'qLDSV_TCDataSet2.LOPTINCHI' table. You can move, or remove it, as needed.
            this.lOPTINCHITableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTINCHITableAdapter.Fill(this.qLDSV_TCDataSet2.LOPTINCHI);

            this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            // TODO: This line of code loads data into the 'qLDSV_TCDataSet2.MONHOC' table. You can move, or remove it, as needed.
            this.mONHOCTableAdapter.Fill(this.qLDSV_TCDataSet2.MONHOC);



            if (Program.mGroup == "SV")
            {
                btnThem.Enabled = btnSua.Enabled = BtnGhi.Enabled =
                BtnHTac.Enabled = btnXoa.Enabled = false;
            }
            else
            {
                btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = true;
                BtnGhi.Enabled = BtnHTac.Enabled = false;
            }
        }

        private void mAMHTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void mAMHLabel_Click(object sender, EventArgs e)
        {

        }



        private void BtnHTac_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (processStoreStack.Count > 0)
            {
                Undo command = processStoreStack.Pop();   // Lấy ra 1 đối tượng Redo ( gồm primarykey, object SV)
                String MAMH = command.primaryKey;

                MonHoc MH = new MonHoc();
                MH = (MonHoc)command.dataRow;

                switch (command.flagMode)
                {
                    case "ADDMONHOC":

                        int rowIndex = gvMonHoc.LocateByValue("MAMH", MAMH);  // trả về giá trị của dòng có mã sv

                        if (rowIndex != -1)
                        {
                            MessageBox.Show("Row index: " + rowIndex.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        try
                        {
                            MessageBox.Show(MAMH);
                            gvMonHoc.DeleteRow(rowIndex);
                            this.mONHOCTableAdapter.Update(this.qLDSV_TCDataSet2.MONHOC);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Lỗi xóa Môn học: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            this.mONHOCTableAdapter.Fill(this.qLDSV_TCDataSet2.MONHOC);
                            return;
                        }
                        break;

                    case "DELETEMONHOC":


                        try
                        {
                            BDSMHoc.AddNew();  // thêm dòng và trỏ đến dòng đó

                            gvMonHoc.SetFocusedRowCellValue("MAMH", MH.MaMH);  // thêm dữ liệu trên dòng đang đucợ trỏ đến
                            gvMonHoc.SetFocusedRowCellValue("TENMH", MH.TenMH);
                            gvMonHoc.SetFocusedRowCellValue("SOTIET_LT", MH.STLT);
                            gvMonHoc.SetFocusedRowCellValue("SOTIET_TH", MH.STTH);

                            //gvSV.SetFocusedRowCellValue("PASSWORD", SV.PassWord);

                            BDSMHoc.EndEdit();
                            this.mONHOCTableAdapter.Update(this.qLDSV_TCDataSet2.MONHOC);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Lỗi khôi phục Môn học : " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            this.mONHOCTableAdapter.Fill(this.qLDSV_TCDataSet2.MONHOC);
                            return;
                        }
                        break;

                    default:  // Flagmode = EDITSTUDENT

                        positionSelectedMH = gvMonHoc.LocateByValue("MAMH", MAMH);
                        gvMonHoc.FocusedRowHandle = positionSelectedMH;

                        try
                        {
                            gvMonHoc.SetRowCellValue(positionSelectedMH, "MAMH", MH.MaMH); // thêm dữ liệu vào dòng có chỉ số index
                            gvMonHoc.SetRowCellValue(positionSelectedMH, "TENMH", MH.TenMH);
                            gvMonHoc.SetRowCellValue(positionSelectedMH, "SOTIET_LT", MH.STLT);
                            gvMonHoc.SetRowCellValue(positionSelectedMH, "SOTIET_TH", MH.STTH);


                            BDSMHoc.EndEdit();
                            this.mONHOCTableAdapter.Update(this.qLDSV_TCDataSet2.MONHOC);

                            positionSelectedMH = -1;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Lỗi khôi phục sinh viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            this.mONHOCTableAdapter.Fill(this.qLDSV_TCDataSet2.MONHOC);
                            return;
                        }
                        break;
                }

                if (processStoreStack.Count == 0)
                    BtnHTac.Enabled = false;
            }
        }








        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            BDSMHoc.AddNew();
            pnMH.Enabled = true;
            positionSelectedMH = BDSMHoc.Count - 1;
            flagMode = "ADDMONHOC";
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = false;
            BtnGhi.Enabled = BtnHTac.Enabled = true;

            //gcMonHoc.Enabled = false;
            txtMaMH.Enabled = true;
            spinSTLT.Value = 0;
            spinSTTH.Value = 0;


        }

        private void gcMonHoc_Click(object sender, EventArgs e)
        {

        }

        private void gvMonHoc_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            MessageBox.Show(flagMode);
            if ((flagMode == "EDITMONHOC" || flagMode == "ADDMONHOC") && BDSMHoc.Position != positionSelectedMH)
            {
                DialogResult dialog = MessageBox.Show("Bạn đang trong quá trình chỉnh sửa thông tin bạn thật sự muốn làm mới không?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialog == DialogResult.No)
                {
                    e.Handled = true;
                    gvMonHoc.FocusedRowHandle = positionSelectedMH;
                    return;
                }
                else
                {

                    this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.mONHOCTableAdapter.Fill(this.qLDSV_TCDataSet2.MONHOC);
                    flagMode = "";
                    positionSelectedMH = -1;
                }

            }

            if (BDSMHoc.Position != positionSelectedMH)
            {
                btnXoa.Enabled = btnSua.Enabled = true;
            }

        }

        private void BtnGhi_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Program.KetNoi() == 0) return;

            if (CheckDataSV() == true)
            {
                try
                {
                    BDSMHoc.EndEdit();
                    BDSMHoc.ResetCurrentItem();

                    this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;

                    DataRow row = ((DataRowView)BDSMHoc[BDSMHoc.Position]).Row;
                    this.mONHOCTableAdapter.Update(row);

                    if (flagMode == "ADDMONHOC")
                    {
                        DataRow data = gvMonHoc.GetFocusedDataRow();
                        pushDataToProcessStack(data);
                    }


                    MessageBox.Show("Thêm môn hàm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi ghi sinh viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                flagMode = "";
                positionSelectedMH = -1;

                btnThem.Enabled = BtnHTac.Enabled = true;
                BtnGhi.Enabled = false;

                gcMonHoc.Enabled = true;
                pnMH.Enabled = false;
            }
        }

        private void btnXoa_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string MAMH = "";

            if (BDSLopTChi.Count > 0)
            {
                MessageBox.Show("Không thể xóa sinh viên này vì sinh viên đã đăng kí lớp tín chỉ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("Bạn có thật sự muốn xóa sinh viên khỏi lớp học này ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                try
                {
                    DataRow data = gvMonHoc.GetFocusedDataRow();
                    MAMH = data["MAMH"].ToString();

                    flagMode = "DELETEMONHOC";
                    pushDataToProcessStack(data);

                    data.Delete();

                    this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.mONHOCTableAdapter.Update(this.qLDSV_TCDataSet2.MONHOC);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa sinh viên: " + ex.Message, "", MessageBoxButtons.OK);
                    this.mONHOCTableAdapter.Fill(this.qLDSV_TCDataSet2.MONHOC);
                    BDSMHoc.Position = BDSMHoc.Find("MAMH", MAMH);
                    processStoreStack.Pop();
                    flagMode = "";
                    return;
                }

                btnThem.Enabled = BtnHTac.Enabled = true;
                btnXoa.Enabled = btnSua.Enabled = false;
            }
        }

        private void btnSua_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            positionSelectedMH = BDSMHoc.Position;
            positionSelectedClass = gvMonHoc.FocusedRowHandle;
            //pnMH.Enabled = true;
            //gcMonHoc.Enabled = false;
            flagMode = "EDITMONHOC";
            DataRow data = gvMonHoc.GetFocusedDataRow();
            pushDataToProcessStack(data);

            BtnGhi.Enabled = BtnHTac.Enabled = true;
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = false;
        }

        private void gcMonHoc_Click_1(object sender, EventArgs e)
        {

        }
    }
}