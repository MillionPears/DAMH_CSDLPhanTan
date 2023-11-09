using DevExpress.Utils;
using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDSV_TC
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
            check_quyen();
            
        }


        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }

        
        private void check_quyen()
        {
            if (Program.mGroup == "PGV"|| Program.mGroup == "KHOA")
            {
                btnHocPhi.Enabled = btnDSHPLTC.Enabled = btnDK.Enabled = false;

            }
            else if (Program.mGroup == "PKT")
            {
                btnSV.Enabled = btnMonHoc.Enabled = btnLopHoc.Enabled = btnLTC.Enabled = btnDiem.Enabled = btnDSSVLTC.Enabled = btnDSLTC.Enabled = btnBDMH.Enabled = false;
                btnDK.Enabled = btnBANGDIEMTK.Enabled =  btnPHIEUDIEMSV.Enabled = false;
            }
            else
            {
                btnSV.Enabled = btnMonHoc.Enabled = btnLopHoc.Enabled = btnLTC.Enabled = btnDiem.Enabled = btnDSSVLTC.Enabled = btnDSLTC.Enabled = btnBDMH.Enabled = false;
                btnBANGDIEMTK.Enabled = false;
                btnHocPhi.Enabled = btnDSHPLTC.Enabled  = false;
                btnTTK.Enabled = false;
            }
            


        }
       

        private void btnDiem_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmNhapDiem));
            if (frm != null) frm.Activate();
            else
            {
                frmNhapDiem f = new frmNhapDiem();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnMonHoc_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormMonH));
            if (frm != null) frm.Activate();
            else
            {
                FormMonH f = new FormMonH();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnLopHoc_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmLopHoc));
            if (frm != null) frm.Activate();
            else
            {
                frmLopHoc f = new frmLopHoc();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnLTC_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FrmLopTinC));
            if (frm != null) frm.Activate();
            else
            {
                FrmLopTinC f = new FrmLopTinC();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnHocPhi_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmHocPhi));
            if (frm != null) frm.Activate();
            else
            {
                frmHocPhi f = new frmHocPhi();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnDK_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FrmDK));
            if (frm != null) frm.Activate();
            else
            {
                FrmDK f = new FrmDK();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnSV_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmSinhVien));
            if (frm != null) frm.Activate();
            else
            {
                frmSinhVien f = new frmSinhVien();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnBANGDIEMTK_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void btnPHIEUDIEMSV_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(Frpt_PhieuDiemSV));
            if (frm != null) frm.Activate();
            else
            {
                Frpt_PhieuDiemSV f = new Frpt_PhieuDiemSV();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnDSLTC_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(Rpf_DSLTC));
            if (frm != null) frm.Activate();
            else
            {
                Rpf_DSLTC f = new Rpf_DSLTC();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnBDMH_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(Frpt_InDiemTheoMon));
            if (frm != null) frm.Activate();
            else
            {
                Frpt_InDiemTheoMon f = new Frpt_InDiemTheoMon();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnDSHPLTC_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(Frpt_HPTheoLop));
            if (frm != null) frm.Activate();
            else
            {
                Frpt_HPTheoLop f = new Frpt_HPTheoLop();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnDSSVLTC_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(Frpt_in_DSSV_DKLTC));
            if (frm != null) frm.Activate();
            else
            {
                Frpt_in_DSSV_DKLTC f = new Frpt_in_DSSV_DKLTC();
                f.MdiParent = this;
                f.Show();
            }

        }

        private void btnTTK_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FrmTaoTaiKhoan));
            if (frm != null) frm.Activate();
            else
            {
                FrmTaoTaiKhoan f = new FrmTaoTaiKhoan();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            if (Program.mGroup == Program.NhomQuyen[3])//sv
            {
                txtMaNV.Text = "Mã SV: " + Program.username;
                txtHoTen.Text = "Họ Tên: " + Program.mHoten;
                txtNhom.Text = "Nhóm: " + Program.mGroup;
            }
            else if (Program.mGroup == Program.NhomQuyen[2])//pkton
            {
                txtMaNV.Text = "Mã GV: " + Program.username;
                txtHoTen.Text = "Họ Tên: " + Program.mHoten;
                txtNhom.Text = "Nhóm: " + Program.mGroup;
            }
            else // khoa,pgv
            {
                txtMaNV.Text = "Mã GV: " + Program.username;
                txtHoTen.Text = "Họ Tên: " + Program.mHoten;
                txtNhom.Text = "Nhóm: " + Program.mGroup;
            }
        }

        private void btnDANGXUAT_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
            
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            DialogResult dialog = MessageBox.Show("Bạn có muốn đăng xuất không?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialog == DialogResult.Yes)
            {
                foreach (Form frm in this.MdiChildren)
                {
                    frm.Close();
                }

                this.Dispose();
                Program.frmChinh.Visible = true;
                Program.bds_dspm.RemoveFilter();
               

                e.Cancel = false;
            }
        }
    }
}