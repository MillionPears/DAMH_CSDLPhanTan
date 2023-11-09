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
    public partial class Frpt_InDiemTheoMon : Form
    {
       
        public Frpt_InDiemTheoMon()
        {
            InitializeComponent();

        }
        private void fillComboboxNienKhoa()
        {
            int currentYear = DateTime.Now.Year;

            for (int i = 2015; i <= currentYear - 1; i++)
                cbxNienKhoa.Items.Add((i.ToString() + "-" + (i + 1).ToString()));
        }

        private void cbxKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxKhoa.SelectedValue.ToString() == "System.Data.DataRowView")
                return;
            Program.servername = cbxKhoa.SelectedValue.ToString();
            if (cbxKhoa.SelectedIndex != Program.mChiNhanh)
            {
                Program.mlogin = Program.remotelogin;
                Program.password = Program.remotepassword;
            }
            else
            {
                Program.mlogin = Program.mloginDN;
                Program.password = Program.mpassword;
            }
            if (Program.KetNoi() == 0)
            {
                MessageBox.Show("Kết nối csdl thất bại!", "", MessageBoxButtons.OK);
                return;
            }


        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

       
        
        private void Frpt_InDiemTheoMon_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS1.MONHOC' table. You can move, or remove it, as needed.
            this.mONHOCTableAdapter.Fill(this.dS1.MONHOC);
            fillComboboxNienKhoa();
            dS1.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'qLDSV_TCDataSet2.LOPTINCHI' table. You can move, or remove it, as needed.

            dS1.EnforceConstraints = false;
            this.lOPTINCHITableAdapter.Connection.ConnectionString = Program.connstr;

            this.lOPTINCHITableAdapter.Fill(this.dS1.LOPTINCHI);

            Program.bds_dspm.Filter = "TENCN LIKE 'KHOA%'";
            cbxKhoa.DataSource = Program.bds_dspm;
            cbxKhoa.DisplayMember = "TENCN";
            cbxKhoa.ValueMember = "TENSERVER";
            cbxKhoa.SelectedValue = Program.servername;
            if (Program.mGroup == "PGV")
            {
                cbxKhoa.Enabled = true;
            }
            else cbxKhoa.Enabled = false;
        }

        private void btnIN_Click(object sender, EventArgs e)
        {

            int hk = Convert.ToInt32(cbxHocKy.Text);
            int nh = Convert.ToInt32(cbxNhom.Text);
            string nienKhoa = cbxNienKhoa.Text;
            string monHoc = cbxMonHoc.SelectedValue.ToString();
            string khoa = cbxKhoa.Text;
            //  MessageBox.Show(hk + "-" + nh + "-" + nienKhoa + "-" + monHoc + "-" + khoa);
            Xrpt_SP_GETDSNHAPDIEM rpt = new Xrpt_SP_GETDSNHAPDIEM(nienKhoa, hk, monHoc, nh);
            /*string khoatmp = "";
            if (khoa == "CNTT") khoatmp = "CÔNG NGHỆ THÔNG TIN";
            else khoatmp = "VIỄN THÔNG";*/
            //rpt.lblKhoa.Text = khoatmp;
            rpt.lblKhoa.Text = khoa;
            rpt.lblNienKhoa.Text = nienKhoa;
            rpt.lblHocKy.Text = hk + "";
            rpt.lblMonHoc.Text = cbxMonHoc.Text;
            rpt.lblNhom.Text = nh + "";

            ReportPrintTool print = new ReportPrintTool(rpt);
            print.ShowPreviewDialog();
        }
    }
}
