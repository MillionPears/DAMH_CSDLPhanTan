using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDSV_TC
{

    


    public partial class frmHocPhi : DevExpress.XtraEditors.XtraForm
    {

        DataTable dt_DS_HP = new DataTable();
        DataTable dt_CT_HP = new DataTable();
        String nienKhoa = "";
        String hocky = "";
        String tienNo = "";
        string ngay = "";

        bool check = false;

        public frmHocPhi()
        {
            InitializeComponent();
            // this.dgv_CT_HP.RowValidating += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgv_CT_HP_RowValidating);

            this.dgv_CT_HP.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgv_CT_HP_CellValidating);



        }
        private void dgvHP_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {


            CancelCellFormatting();

        }
        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           


            // Thêm dòng trống
            AddEmptyRow(dt_DS_HP);
            btnGhi.Enabled = mnHPGhi.Enabled = true;
            


        }
        private void HideDataGridView()
        {
            dgv_CT_HP.Visible = false;
        }
        private void ShowDataGridView()
        {
            dgv_CT_HP.Visible = true;
        }

        private void enableEdit()
        {
            dgvHP.ReadOnly = false;
            dgv_CT_HP.ReadOnly = false;

            btnGhi.Enabled = btnThem.Enabled = btnPhucHoi.Enabled = btnHuy.Enabled = mnCTHPThem.Enabled = mnHPThemMoi.Enabled = true;

            mnHPXoa.Enabled = mnCTHPXoa.Enabled = mnCTHPGhi.Enabled = mnHPGhi.Enabled = true;
        }

        private void disableEdit()
        {
            dgvHP.ReadOnly = true;
            dgv_CT_HP.ReadOnly = true;
            btnGhi.Enabled = btnThem.Enabled = btnPhucHoi.Enabled = btnHuy.Enabled = mnCTHPThem.Enabled = mnHPThemMoi.Enabled = false;

            mnHPXoa.Enabled = mnCTHPXoa.Enabled = mnCTHPGhi.Enabled = mnHPGhi.Enabled = false;
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {

            HideDataGridView();
            String masv = txtMASV.Text.ToString();



            if (checkSVNghiHoc(masv))
            {
                disableEdit();
                MessageBox.Show("Sinh Viên Đã nghỉ học!!!");
                check = true;


            }
            else
            {
                enableEdit();
                check = false;

            }

            try
            {

                String strlenh = "EXEC SP_Lay_Thong_Tin_SV_HP '" + masv + "'";
                SqlDataReader myReader = Program.ExecSqlDataReader(strlenh);
                if (myReader == null) return;
                myReader.Read();

                txtTen.Text = myReader.GetString(1);
                txtLop.Text = myReader.GetString(2);

            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.StackTrace + "hello");
                MessageBox.Show("Không tìm thấy sinh viên !!!");
            }

            try
            {
                if (Program.KetNoi() == 0) return;
                String strlenh1 = "EXEC GET_THONGTIN_HOCPHI '" + masv + "'";

                dt_DS_HP = Program.ExecSqlDataTable(strlenh1);

                bdsDSHP.DataSource = dt_DS_HP;
                //thử
                bds_HP = bdsDSHP;

                CalculateTienConNo();
                ActivateCellFormatting();


                btnGhi.Enabled = mnCTHPGhi.Enabled = mnHPGhi.Enabled = false;




            }
            catch (System.Exception ex)
            {
                MessageBox.Show("btnTimKiem_Click" + ex.Message);
            }


        }

        private void frmHocPhi_Load(object sender, EventArgs e)
        {

            dgvHP.CellValidating += dgvHP_CellValidating;
            dgvHP.CellMouseClick += dgvHP_CellMouseClick;
            btnGhi.Enabled = mnCTHPGhi.Enabled = mnHPGhi.Enabled = false;
            btnThem.Enabled = mnCTHPThem.Enabled = mnHPThemMoi.Enabled = false;
            btnXoa.Enabled = mnCTHPXoa.Enabled = mnHPXoa.Enabled = false;

            DS_HP.EnforceConstraints = false;


            this.hOCPHITableAdapter.Connection.ConnectionString = Program.connstr;
            this.cT_DONGHOCPHITableAdapter.Connection.ConnectionString = Program.connstr;
            this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            // TODO: This line of code loads data into the 'DS_HP.SINHVIEN' table. You can move, or remove it, as needed.
            this.sINHVIENTableAdapter.Fill(this.DS_HP.SINHVIEN);
            // TODO: This line of code loads data into the 'DS_HP.HOCPHI' table. You can move, or remove it, as needed.
            this.hOCPHITableAdapter.Fill(this.DS_HP.HOCPHI);
            // TODO: This line of code loads data into the 'DS_HP.CT_DONGHOCPHI' table. You can move, or remove it, as needed.
            this.cT_DONGHOCPHITableAdapter.Fill(this.DS_HP.CT_DONGHOCPHI);


        }

        private void AddEmptyRow(DataTable dt)
        {


            try
            {
                DataRow dr = dt.NewRow();
                dt.Rows.Add(dr);
                int newRowIdx = dt.Rows.IndexOf(dr);
                if (newRowIdx >= 0)
                {
                    dgvHP.CurrentCell = dgvHP.Rows[newRowIdx].Cells[0];
                }
               
               
                dgvHP.Rows[newRowIdx].Cells["nIENKHOADataGridViewTextBoxColumn"].ReadOnly = false;
                dgvHP.Rows[newRowIdx].Cells["hOCKYDataGridViewTextBoxColumn"].ReadOnly = false;
               
            }
            catch (Exception)
            {

            }
        }
        private void AddEmptyRowCTHP(DataTable dt)
        {
            try
            {
                DataRow dr = dt.NewRow();
                dt.Rows.Add(dr);
                int newRowIdx = dt.Rows.IndexOf(dr);
                if (newRowIdx >= 0)
                {
                    dgv_CT_HP.CurrentCell = dgv_CT_HP.Rows[newRowIdx].Cells[1];
                    dgv_CT_HP.Rows[newRowIdx].Cells[1].Selected = true;
                    dgv_CT_HP.BeginEdit(true);
                    dgv_CT_HP.CurrentCell.OwningColumn.DefaultCellStyle.BackColor = Color.LightYellow;
                    // dgv_CT_HP.CurrentCell.PerformClick();
                }
            }
            catch (Exception ex)
            {

            }
        }
        private void delete_emty(DataTable dt)
        {


            // Tìm các dòng trống và xóa chúng
            DataRow[] emptyRows = dt.Select().Where(r => r.ItemArray.All(c => c is DBNull || string.IsNullOrWhiteSpace(c.ToString()))).ToArray();
            foreach (DataRow row in emptyRows)
            {
                dt.Rows.Remove(row);
            }


        }

        public int check_HP(string masv,string nienkhoa,string hocky)
        {
           // if (Program.KetNoi() == 0) return 2;

            string strlenh = " DECLARE @return_value int " +
                "EXEC @return_value=SP_CHECK_ID_HOCPHI_F_CTHP '" + masv + "','" + nienkhoa + "','" + hocky + "'" +
                " SELECT  'Return Value' = @return_value ";

            SqlDataReader myReader = Program.ExecSqlDataReader(strlenh);
            if (myReader == null) return 2;
            String status = "";
            myReader.Read();
            try
            {
                status = myReader.GetValue(0).ToString();
                myReader.Close();

            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.StackTrace);

            }
            if (status.Equals("1"))
            {
                MessageBox.Show("Đã Tồn tại học phí này!!!"); return 1;
            }
            else return 0;
        }
        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            DataTable dt = new DataTable();


            dt.Columns.Add("MASV", typeof(string));
            dt.Columns.Add("NIENKHOA", typeof(string));
            dt.Columns.Add("HOCKY", typeof(int));
            dt.Columns.Add("HOCPHI", typeof(int));

            string masv = txtMASV.Text.ToUpper();
            delete_emty(dt_DS_HP);


            if (Program.KetNoi() == 0) return;

            for (int i = 0; i < dt_DS_HP.Rows.Count; i++)
            {

                /*if (check_HP(masv, dt_DS_HP.Rows[i]["NIENKHOA"].ToString(), dt_DS_HP.Rows[i]["HOCKY"].ToString()) == 1)
                {
                    

                    btnTimKiem_Click(sender, e);
                    return;
                }*/
                dt.Rows.Add(masv, dt_DS_HP.Rows[i]["NIENKHOA"], dt_DS_HP.Rows[i]["HOCKY"], dt_DS_HP.Rows[i]["HOCPHI"]);
                

            }
            



            try
            {
                SqlParameter para = new SqlParameter();
                para.SqlDbType = SqlDbType.Structured;
                para.TypeName = "dbo.TYPE_HP";
                para.ParameterName = "@HP";
                para.Value = dt;

                Program.KetNoi();
                SqlCommand Sqlcmd = new SqlCommand("SP_UPDATE_HP", Program.conn);
                Sqlcmd.Parameters.Clear();
                Sqlcmd.CommandType = CommandType.StoredProcedure;
                Sqlcmd.Parameters.Add(para);
                Sqlcmd.ExecuteNonQuery();
                MessageBox.Show("Thành Công");
                ActivateCellFormatting();
                btnGhi.Enabled = mnHPGhi.Enabled = false;
                btnTimKiem_Click(sender, e);

            }
            catch(Exception ex)
            {
                MessageBox.Show("Đã Tồn tại học phí này!!!");
                bds_HP.RemoveCurrent();

            }
            




        }


        private void dgvHP_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (check == false)
            {
                btnGhi.Enabled = mnCTHPGhi.Enabled = mnHPGhi.Enabled =btnXoa.Enabled= true;
            }

            try
            {
                // Lấy dòng được chọn
                DataGridViewRow row = dgvHP.Rows[e.RowIndex];


                // Lấy giá trị từ các ô trong dòng được chọn
                String masv = txtMASV.Text;
                nienKhoa = row.Cells[0].Value.ToString();
                hocky = row.Cells[1].Value.ToString();

                object cellValue = row.Cells[4].Value;
                if (cellValue != null)
                {
                    tienNo = cellValue.ToString();
                }








                if (Program.KetNoi() == 0) return;
                String strlenh1 = "EXEC SP_LAY_CT_HP '" + masv + "'" + ",'" + nienKhoa + "','" + hocky + "'";

                dt_CT_HP = Program.ExecSqlDataTable(strlenh1);
                // thử
                bdsCTHP.DataSource = dt_CT_HP;

                dgv_CT_HP.DataSource = dt_CT_HP;
                ShowDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show("dgvHP_CellDoubleClick" + ex.StackTrace);
            }





        }

        private void menuHP_Opening(object sender, CancelEventArgs e)
        {

        }

        private void mnHPThemMoi_Click(object sender, EventArgs e)
        {
            CancelCellFormatting();
            // Thêm dòng trống
            AddEmptyRow(dt_DS_HP);
            btnGhi.Enabled = mnHPGhi.Enabled = true;

        }

        private void mnHPGhi_Click(object sender, EventArgs e)
        {
            DevExpress.XtraBars.BarItemLink link = null; // Tạo đối tượng BarItemLink
            btnGhi_ItemClick(sender, new DevExpress.XtraBars.ItemClickEventArgs(null, link)); // Truyền đối tượng BarItemLink vào hàm ItemClickEventArgs
       
        }

        private void mnCTHPThem_Click(object sender, EventArgs e)
        {
            delete_emty(dt_DS_HP);
            if (Convert.ToInt32(dgvHP.CurrentRow.Cells["TIENCONNO"].Value) == 0)
            {
                MessageBox.Show("Sinh Viên đã đóng đủ tiền !!!");
                return;
            }

            if (tienNo == "0")
            {
                MessageBox.Show("Sinh Viên đã đóng đủ tiền !!!");
                return;
            }
            AddEmptyRowCTHP(dt_CT_HP);
            mnCTHPGhi.Enabled = true;
        }

        private void mnCTHPGhi_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("MASV", typeof(string));
            dt.Columns.Add("NIENKHOA", typeof(string));
            dt.Columns.Add("HOCKY", typeof(int));
            dt.Columns.Add("NGAYDONG", typeof(DateTime));
            dt.Columns.Add("SOTIENDONG", typeof(int));

            string masv = txtMASV.Text.ToUpper();
            delete_emty(dt_CT_HP);




            for (int i = 0; i < dt_CT_HP.Rows.Count; i++)
            {


                dt.Rows.Add(masv, nienKhoa, hocky, dt_CT_HP.Rows[i]["NGAYDONG"], dt_CT_HP.Rows[i]["SOTIENDONG"]);

            }



            try
            {

                SqlParameter para = new SqlParameter();
                para.SqlDbType = SqlDbType.Structured;
                para.TypeName = "dbo.TYPE_CTHP";
                para.ParameterName = "@CT_HP";
                para.Value = dt;

                Program.KetNoi();
                SqlCommand Sqlcmd = new SqlCommand("SP_UPDATE_CT_HP", Program.conn);
                Sqlcmd.Parameters.Clear();
                Sqlcmd.CommandType = CommandType.StoredProcedure;
                Sqlcmd.Parameters.Add(para);
                Sqlcmd.ExecuteNonQuery();
                MessageBox.Show("Thành Công");
                btnTimKiem_Click(sender, e);
                ShowDataGridView();
                mnCTHPGhi.Enabled = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Vui lòng xem lại ngày đóng!!");
               
                mnCTHPGhi.Enabled = false;
                bdsCTHP.RemoveCurrent();
            }





        }

        private void dgvHP_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow row = dgvHP.Rows[e.RowIndex];
                if (!DBNull.Value.Equals(row.Cells["hOCPHIDataGridViewTextBoxColumn"].Value) && !DBNull.Value.Equals(row.Cells["sOTIENDONGDataGridViewTextBoxColumn"].Value))
                {
                    decimal hocphi = Convert.ToDecimal(row.Cells["hOCPHIDataGridViewTextBoxColumn"].Value);
                    decimal sotiendong = Convert.ToDecimal(row.Cells["sOTIENDONGDataGridViewTextBoxColumn"].Value);

                    // Tính toán giá trị của cột TIENCONNO
                    decimal tienconno = hocphi - sotiendong;

                    // Gán giá trị mới cho cột TIENCONNO
                    row.Cells["TIENCONNO"].Value = tienconno;
                }

            }

        }

        private void CalculateTienConNo()
        {
            foreach (DataGridViewRow row in dgvHP.Rows)
            {
                // Lấy giá trị của cột HOCPHI
                decimal hocPhi = Convert.ToDecimal(row.Cells["hOCPHIDataGridViewTextBoxColumn"].Value);

                // Lấy giá trị của cột SOTIENDONG
                decimal soTienDong = Convert.ToDecimal(row.Cells["sOTIENDONGDataGridViewTextBoxColumn"].Value);

                // Tính toán giá trị của cột TIENCONNO
                decimal tienConNo = hocPhi - soTienDong;

                // Gán giá trị của cột TIENCONNO
                row.Cells["TIENCONNO"].Value = tienConNo;
            }
        }
        private void dgvHP_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {



            if (e.ColumnIndex >= 0 && e.ColumnIndex < this.dgvHP.Columns.Count)
            {
                DataGridViewColumn column = this.dgvHP.Columns[e.ColumnIndex];
                if (this.dgvHP.Columns[e.ColumnIndex].Name == "hOCPHIDataGridViewTextBoxColumn" ||
               this.dgvHP.Columns[e.ColumnIndex].Name == "sOTIENDONGDataGridViewTextBoxColumn" ||
               this.dgvHP.Columns[e.ColumnIndex].Name == "TIENCONNO")
                {
                    if (e.Value != null && double.TryParse(e.Value.ToString(), out double result))
                    {
                        e.Value = result.ToString("#,##0.0");
                        e.FormattingApplied = true;
                    }
                }
            }


        }
        private void CancelCellFormatting()
        {
            this.dgvHP.CellFormatting -= new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvHP_CellFormatting);
        }
        private void ActivateCellFormatting()
        {
            this.dgvHP.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvHP_CellFormatting);
        }

        private void dgvHP_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {


            // Check if the current cell belongs to the columns nIENKHOADataGridViewTextBoxColumn, hOCKYDataGridViewTextBoxColumn, or hOCPHIDataGridViewTextBoxColumn
            if (e.ColumnIndex == dgvHP.Columns["nIENKHOADataGridViewTextBoxColumn"].Index ||
                e.ColumnIndex == dgvHP.Columns["hOCKYDataGridViewTextBoxColumn"].Index ||
                e.ColumnIndex == dgvHP.Columns["hOCPHIDataGridViewTextBoxColumn"].Index)
            {
                // Check if the entered value is null or empty
                if (string.IsNullOrEmpty(e.FormattedValue.ToString()))
                {
                    dgvHP.Rows[e.RowIndex].ErrorText = "Ô này không được để trống!";
                    e.Cancel = true;

                    return;
                }

                // Check if the entered value is valid
                if (e.ColumnIndex == dgvHP.Columns["nIENKHOADataGridViewTextBoxColumn"].Index)
                {
                    // Check if the entered value is in the format "yyyy-yyyy"
                    if (!Regex.IsMatch(e.FormattedValue.ToString(), @"^\d{4}-\d{4}$"))
                    {
                        dgvHP.Rows[e.RowIndex].ErrorText = "Niên Khóa có phải có dang: 'yyyy-yyyy'.";
                        e.Cancel = true;
                    }
                    else
                    {
                        dgvHP.Rows[e.RowIndex].ErrorText = string.Empty;
                    }
                }
                else if (e.ColumnIndex == dgvHP.Columns["hOCKYDataGridViewTextBoxColumn"].Index ||
                         e.ColumnIndex == dgvHP.Columns["hOCPHIDataGridViewTextBoxColumn"].Index)
                {
                    // Check if the entered value is an integer
                    int intValue;
                    if (!int.TryParse(e.FormattedValue.ToString(), out intValue))
                    {
                        dgvHP.Rows[e.RowIndex].ErrorText = "Học Kỳ phải là một số nguyên";
                        e.Cancel = true;
                    }
                    else
                    {

                        dgvHP.Rows[e.RowIndex].ErrorText = string.Empty;
                    }
                }
            }
        }
       
        public void RemoveLastRow(DataTable dataTable)
        {
            if (dataTable.Rows.Count > 0)
            {
                dataTable.Rows.RemoveAt(dataTable.Rows.Count - 1);
            }
        }
        private void dgv_CT_HP_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {


            DataGridViewRow row = dgv_CT_HP.Rows[e.RowIndex];

            // Kiểm tra giá trị của cột nGAYDONGDataGridViewTextBoxColumn
            if (row.Cells["nGAYDONGDataGridViewTextBoxColumn"].Value == null || row.Cells["nGAYDONGDataGridViewTextBoxColumn"].Value.ToString() == "")
            {
                row.Cells["nGAYDONGDataGridViewTextBoxColumn"].Value = DateTime.Now.ToString("dd/MM/yyyy");
            }
            else
            {
                DateTime ngaydong;
                if (!DateTime.TryParse(row.Cells["nGAYDONGDataGridViewTextBoxColumn"].Value.ToString(), out ngaydong))
                {
                    e.Cancel = true;
                    MessageBox.Show("Định dạng ngày không hợp lệ!");
                }
            }

            if (dgv_CT_HP.Columns[e.ColumnIndex].Name == "sOTIENDONGDataGridViewTextBoxColumn1")
            {


                int newSOTIENDONG;
                if (!int.TryParse(e.FormattedValue.ToString(), out newSOTIENDONG) || newSOTIENDONG <= 0)
                {
                    e.Cancel = true;
                    MessageBox.Show("Số tiền đóng phải là một số nguyên.");
                    return;
                }

                else if (newSOTIENDONG > Convert.ToInt32(dgvHP.CurrentRow.Cells["TIENCONNO"].Value))
                {
                    if (Convert.ToInt32(dgvHP.CurrentRow.Cells["TIENCONNO"].Value) == 0)
                    {
                        return;
                    }
                    else
                    {
                        e.Cancel = true;
                        MessageBox.Show("Số tiền đóng phải bé hơn hoặc bằng Tiền còn nợ của sinh viên.\n" + "Còn nợ: " + dgvHP.CurrentRow.Cells["TIENCONNO"].Value);
                        return;
                    }

                }
                else
                {
                    int sumSOTIENDONG = 0;
                    foreach (DataGridViewRow r in dgv_CT_HP.Rows)
                    {
                        if (r.Index != e.RowIndex)
                        {
                            try
                            {
                                sumSOTIENDONG += Convert.ToInt32(r.Cells["sOTIENDONGDataGridViewTextBoxColumn1"].Value);
                            }
                            catch (Exception ex)
                            {
                                sumSOTIENDONG += 0;
                            }
                        }
                    }

                    sumSOTIENDONG += newSOTIENDONG;
                    if (sumSOTIENDONG > Convert.ToInt32(dgvHP.CurrentRow.Cells["hOCPHIDataGridViewTextBoxColumn"].Value))
                    {
                        e.Cancel = true;
                        MessageBox.Show("Số tiền bạn nhập vượt quá số tiền học phí! \nVui lòng nhập lại");

                        dgv_CT_HP.CancelEdit();

                        RemoveLastRow(dt_CT_HP);
                        return;

                    }
                }
            }
        }

        private bool checkSVNghiHoc(String masv)
        {


            String strlenh = "SELECT DANGHIHOC FROM SINHVIEN WHERE MASV='" + masv + "'";
            SqlDataReader myReader = Program.ExecSqlDataReader(strlenh);

            myReader.Read();
            bool tt = false;
            try
            {
                tt = myReader.GetBoolean(0);
            }
            catch (Exception ex) { }
             



            Program.myReader.Close();
            Program.conn.Close();
            return tt;






        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            /*if (Program.KetNoi() == 0) return;
            string strlenh = " DECLARE @return_value int " +
                "EXEC @return_value=SP_CHECK_ID_HOCPHI_F_CTHP '" + txtMASV.Text.ToString() + "','" + nienKhoa + "','" + hocky + "'" +
                " SELECT  'Return Value' = @return_value ";
          
            SqlDataReader myReader = Program.ExecSqlDataReader(strlenh);
            if (myReader == null) return;
            String status = "";
            myReader.Read();
            try
            {
                status = myReader.GetValue(0).ToString();
                myReader.Close();
               
            }
            catch (Exception ex) {
                MessageBox.Show(ex.StackTrace);

            }*/
            if (dgv_CT_HP.RowCount>0)
            {
                MessageBox.Show("Học phí đã được đóng không thể  xóa !!!");
            }
            else
            {
                DialogResult result = MessageBox.Show("Xóa Học Phí", "Xác Nhận", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                       
                       


                    }
                    catch (Exception ex)
                    {

                    }
                }
                else if (result == DialogResult.No)
                {
                    // Xử lý khi người dùng chọn No
                }

            }
        }

        private void mnHPXoa_Click(object sender, EventArgs e)
        {
            DevExpress.XtraBars.BarItemLink link = null; // Tạo đối tượng BarItemLink
            btnXoa_ItemClick(sender, new DevExpress.XtraBars.ItemClickEventArgs(null, link)); // Truyền đối tượng BarItemLink vào hàm ItemClickEventArgs

        }

        private void mnCTHPXoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Xóa Học Phí", "Xác Nhận", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                DateTime ngayDong;
                if (DateTime.TryParse(ngay, out ngayDong))
                {
                    if (Program.conn.State == ConnectionState.Closed)
                    {
                        Program.conn.Open();
                    }
                    // Gọi stored procedure DeleteCT_DONGHOCPHI và truyền các tham số
                    using (SqlCommand command = new SqlCommand("DeleteCT_DONGHOCPHI", Program.conn))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@MASV", txtMASV.Text.ToString());
                        command.Parameters.AddWithValue("@NIENKHOA", nienKhoa);
                        command.Parameters.AddWithValue("@HOCKY", hocky);
                        command.Parameters.AddWithValue("@NGAYDONG", ngayDong);

                        // Thực thi stored procedure
                        try
                        {
                            command.ExecuteNonQuery();
                            MessageBox.Show("Xóa Thành Công!!!");
                            bdsCTHP.RemoveCurrent();
                            btnTimKiem_Click(sender, e);
                            ShowDataGridView();
                        }
                        catch (SqlException ex)
                        {
                            MessageBox.Show("Xóa Thất bại!!!");
                            
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Lỗi chuyển đổi kiểu dữ liệu ngày");
                }
            }
            else if (result == DialogResult.No)
            {
                // Xử lý khi người dùng chọn No
            }


        }

        private void dgv_CT_HP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            

            try
            {
                // Lấy dòng được chọn
                DataGridViewRow row = dgv_CT_HP.Rows[e.RowIndex];


                
                ngay = row.Cells[0].Value.ToString();
                
               

                
            }
            catch (Exception ex)
            {
                MessageBox.Show("dgv_CTHP_CellClick" + ex.StackTrace);
            }





        }

    }
}