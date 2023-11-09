
using System.Data;
using System.Windows.Forms;

namespace QLDSV_TC
{
    partial class frmHocPhi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHocPhi));
            DevExpress.Utils.SuperToolTip superToolTip1 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem1 = new DevExpress.Utils.ToolTipTitleItem();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnGhi = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.save = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhucHoi = new DevExpress.XtraBars.BarButtonItem();
            this.btnHuy = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            this.sidePanel1 = new DevExpress.XtraEditors.SidePanel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.txtLop = new DevExpress.XtraEditors.TextEdit();
            this.txtTen = new DevExpress.XtraEditors.TextEdit();
            this.txtMASV = new DevExpress.XtraEditors.TextEdit();
            this.btnTimKiem = new DevExpress.XtraEditors.SimpleButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bdsSinhVien = new System.Windows.Forms.BindingSource(this.components);
            this.DS_HP = new QLDSV_TC.DS_HP();
            this.tableAdapterManager = new QLDSV_TC.DS_HPTableAdapters.TableAdapterManager();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.dgvHP = new System.Windows.Forms.DataGridView();
            this.menuHP = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnHPThemMoi = new System.Windows.Forms.ToolStripMenuItem();
            this.mnHPGhi = new System.Windows.Forms.ToolStripMenuItem();
            this.mnHPXoa = new System.Windows.Forms.ToolStripMenuItem();
            this.bdsDSHP = new System.Windows.Forms.BindingSource(this.components);
            this.bsd_CTHP = new System.Windows.Forms.BindingSource(this.components);
            this.cT_DONGHOCPHITableAdapter = new QLDSV_TC.DS_HPTableAdapters.CT_DONGHOCPHITableAdapter();
            this.bds_HP = new System.Windows.Forms.BindingSource(this.components);
            this.hOCPHITableAdapter = new QLDSV_TC.DS_HPTableAdapters.HOCPHITableAdapter();
            this.bdsCTHP = new System.Windows.Forms.BindingSource(this.components);
            this.sP_LAY_CT_HPTableAdapter = new QLDSV_TC.DS_HPTableAdapters.SP_LAY_CT_HPTableAdapter();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.dgv_CT_HP = new System.Windows.Forms.DataGridView();
            this.nGAYDONGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sOTIENDONGDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuCTHP = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnCTHPThem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnCTHPGhi = new System.Windows.Forms.ToolStripMenuItem();
            this.mnCTHPXoa = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hủyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gET_THONGTIN_HOCPHITableAdapter = new QLDSV_TC.DS_HPTableAdapters.GET_THONGTIN_HOCPHITableAdapter();
            this.sINHVIENTableAdapter = new QLDSV_TC.DS_HPTableAdapters.SINHVIENTableAdapter();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.nIENKHOADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hOCKYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hOCPHIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sOTIENDONGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIENCONNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.sidePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtLop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMASV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSinhVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS_HP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHP)).BeginInit();
            this.menuHP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDSHP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsd_CTHP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_HP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTHP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CT_HP)).BeginInit();
            this.menuCTHP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem1,
            this.barButtonItem2,
            this.barButtonItem3,
            this.barButtonItem4,
            this.barButtonItem5,
            this.btnThem,
            this.btnGhi,
            this.btnPhucHoi,
            this.btnHuy,
            this.barButtonItem6,
            this.btnThoat,
            this.save,
            this.btnXoa});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 15;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnGhi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThoat, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Thêm";
            this.btnThem.Hint = "Thêm";
            this.btnThem.Id = 6;
            this.btnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.Image")));
            this.btnThem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.LargeImage")));
            this.btnThem.Name = "btnThem";
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
            // 
            // btnGhi
            // 
            this.btnGhi.Caption = "Ghi";
            this.btnGhi.Hint = "Ghi";
            this.btnGhi.Id = 7;
            this.btnGhi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGhi.ImageOptions.Image")));
            this.btnGhi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnGhi.ImageOptions.LargeImage")));
            this.btnGhi.Name = "btnGhi";
            toolTipTitleItem1.Text = "Ghi";
            superToolTip1.Items.Add(toolTipTitleItem1);
            this.btnGhi.SuperTip = superToolTip1;
            this.btnGhi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGhi_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Id = 14;
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.LargeImage")));
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "Thoát";
            this.btnThoat.Id = 11;
            this.btnThoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.Image")));
            this.btnThoat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.LargeImage")));
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThoat_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.save)});
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // save
            // 
            this.save.Id = 13;
            this.save.Name = "save";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1944, 34);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 706);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1944, 30);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 34);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 672);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1944, 34);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 672);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 1;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "barButtonItem2";
            this.barButtonItem2.Id = 2;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "barButtonItem3";
            this.barButtonItem3.Id = 3;
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "barButtonItem4";
            this.barButtonItem4.Id = 4;
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "barButtonItem5";
            this.barButtonItem5.Id = 5;
            this.barButtonItem5.Name = "barButtonItem5";
            // 
            // btnPhucHoi
            // 
            this.btnPhucHoi.Caption = "Phục Hồi";
            this.btnPhucHoi.Id = 8;
            this.btnPhucHoi.Name = "btnPhucHoi";
            // 
            // btnHuy
            // 
            this.btnHuy.Caption = "Hủy";
            this.btnHuy.Id = 9;
            this.btnHuy.Name = "btnHuy";
            // 
            // barButtonItem6
            // 
            this.barButtonItem6.Caption = "Làm Mới";
            this.barButtonItem6.Id = 10;
            this.barButtonItem6.Name = "barButtonItem6";
            // 
            // sidePanel1
            // 
            this.sidePanel1.Appearance.BackColor = System.Drawing.Color.NavajoWhite;
            this.sidePanel1.Appearance.Options.UseBackColor = true;
            this.sidePanel1.Controls.Add(this.label1);
            this.sidePanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.sidePanel1.Location = new System.Drawing.Point(0, 34);
            this.sidePanel1.Name = "sidePanel1";
            this.sidePanel1.Size = new System.Drawing.Size(1944, 64);
            this.sidePanel1.TabIndex = 4;
            this.sidePanel1.Text = "sidePanel1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "THÔNG TIN SINH VIÊN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.txtLop);
            this.panelControl1.Controls.Add(this.txtTen);
            this.panelControl1.Controls.Add(this.txtMASV);
            this.panelControl1.Controls.Add(this.btnTimKiem);
            this.panelControl1.Controls.Add(this.label4);
            this.panelControl1.Controls.Add(this.label3);
            this.panelControl1.Controls.Add(this.label2);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 98);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1944, 85);
            this.panelControl1.TabIndex = 5;
            // 
            // txtLop
            // 
            this.txtLop.Location = new System.Drawing.Point(635, 23);
            this.txtLop.Name = "txtLop";
            this.txtLop.Properties.ReadOnly = true;
            this.txtLop.Size = new System.Drawing.Size(150, 28);
            this.txtLop.TabIndex = 14;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(405, 23);
            this.txtTen.Name = "txtTen";
            this.txtTen.Properties.ReadOnly = true;
            this.txtTen.Size = new System.Drawing.Size(150, 28);
            this.txtTen.TabIndex = 14;
            // 
            // txtMASV
            // 
            this.txtMASV.Location = new System.Drawing.Point(83, 23);
            this.txtMASV.MenuManager = this.barManager1;
            this.txtMASV.Name = "txtMASV";
            this.txtMASV.Size = new System.Drawing.Size(150, 28);
            this.txtMASV.TabIndex = 14;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(833, 15);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(112, 34);
            this.btnTimKiem.TabIndex = 3;
            this.btnTimKiem.Text = " Tìm";
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(580, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = " Lớp:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(267, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = " Tên Sinh Viên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(7, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = " Mã SV:";
            // 
            // bdsSinhVien
            // 
            this.bdsSinhVien.DataMember = "SINHVIEN";
            this.bdsSinhVien.DataSource = this.DS_HP;
            // 
            // DS_HP
            // 
            this.DS_HP.DataSetName = "DS_HP";
            this.DS_HP.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.CT_DONGHOCPHITableAdapter = null;
            this.tableAdapterManager.HOCPHITableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLDSV_TC.DS_HPTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.dgvHP);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(0, 183);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1944, 249);
            this.panelControl2.TabIndex = 22;
            // 
            // dgvHP
            // 
            this.dgvHP.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dgvHP.AllowUserToAddRows = false;
            this.dgvHP.AllowUserToResizeColumns = false;
            this.dgvHP.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvHP.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHP.AutoGenerateColumns = false;
            this.dgvHP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHP.BackgroundColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHP.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvHP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nIENKHOADataGridViewTextBoxColumn,
            this.hOCKYDataGridViewTextBoxColumn,
            this.hOCPHIDataGridViewTextBoxColumn,
            this.sOTIENDONGDataGridViewTextBoxColumn,
            this.TIENCONNO});
            this.dgvHP.ContextMenuStrip = this.menuHP;
            this.dgvHP.DataSource = this.bdsDSHP;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHP.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvHP.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvHP.Location = new System.Drawing.Point(2, 2);
            this.dgvHP.Name = "dgvHP";
            this.dgvHP.RowHeadersWidth = 62;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgvHP.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvHP.RowTemplate.Height = 28;
            this.dgvHP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHP.Size = new System.Drawing.Size(1940, 225);
            this.dgvHP.TabIndex = 2;
            this.dgvHP.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHP_CellDoubleClick);
            this.dgvHP.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvHP_CellFormatting);
            this.dgvHP.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHP_CellValueChanged);
            // 
            // menuHP
            // 
            this.menuHP.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuHP.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnHPThemMoi,
            this.mnHPGhi,
            this.mnHPXoa});
            this.menuHP.Name = "menuHP";
            this.menuHP.Size = new System.Drawing.Size(165, 100);
            this.menuHP.Opening += new System.ComponentModel.CancelEventHandler(this.menuHP_Opening);
            // 
            // mnHPThemMoi
            // 
            this.mnHPThemMoi.Name = "mnHPThemMoi";
            this.mnHPThemMoi.Size = new System.Drawing.Size(164, 32);
            this.mnHPThemMoi.Text = "Thêm Mới";
            this.mnHPThemMoi.Click += new System.EventHandler(this.mnHPThemMoi_Click);
            // 
            // mnHPGhi
            // 
            this.mnHPGhi.Name = "mnHPGhi";
            this.mnHPGhi.Size = new System.Drawing.Size(164, 32);
            this.mnHPGhi.Text = "Ghi";
            this.mnHPGhi.Click += new System.EventHandler(this.mnHPGhi_Click);
            // 
            // mnHPXoa
            // 
            this.mnHPXoa.Name = "mnHPXoa";
            this.mnHPXoa.Size = new System.Drawing.Size(164, 32);
            this.mnHPXoa.Text = "Xóa";
            this.mnHPXoa.Click += new System.EventHandler(this.mnHPXoa_Click);
            // 
            // bdsDSHP
            // 
            this.bdsDSHP.DataMember = "GET_THONGTIN_HOCPHI";
            this.bdsDSHP.DataSource = this.DS_HP;
            // 
            // bsd_CTHP
            // 
            this.bsd_CTHP.DataMember = "CT_DONGHOCPHI";
            this.bsd_CTHP.DataSource = this.DS_HP;
            // 
            // cT_DONGHOCPHITableAdapter
            // 
            this.cT_DONGHOCPHITableAdapter.ClearBeforeFill = true;
            // 
            // bds_HP
            // 
            this.bds_HP.DataMember = "HOCPHI";
            this.bds_HP.DataSource = this.DS_HP;
            // 
            // hOCPHITableAdapter
            // 
            this.hOCPHITableAdapter.ClearBeforeFill = true;
            // 
            // bdsCTHP
            // 
            this.bdsCTHP.DataMember = "SP_LAY_CT_HP";
            this.bdsCTHP.DataSource = this.DS_HP;
            // 
            // sP_LAY_CT_HPTableAdapter
            // 
            this.sP_LAY_CT_HPTableAdapter.ClearBeforeFill = true;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 432);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.barManager1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1944, 274);
            this.gridControl1.TabIndex = 37;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // dgv_CT_HP
            // 
            this.dgv_CT_HP.AllowUserToAddRows = false;
            this.dgv_CT_HP.AutoGenerateColumns = false;
            this.dgv_CT_HP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_CT_HP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_CT_HP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nGAYDONGDataGridViewTextBoxColumn,
            this.sOTIENDONGDataGridViewTextBoxColumn1});
            this.dgv_CT_HP.ContextMenuStrip = this.menuCTHP;
            this.dgv_CT_HP.DataSource = this.bdsCTHP;
            this.dgv_CT_HP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_CT_HP.Location = new System.Drawing.Point(0, 432);
            this.dgv_CT_HP.Name = "dgv_CT_HP";
            this.dgv_CT_HP.RowHeadersWidth = 62;
            this.dgv_CT_HP.RowTemplate.Height = 28;
            this.dgv_CT_HP.Size = new System.Drawing.Size(1944, 274);
            this.dgv_CT_HP.TabIndex = 38;
            this.dgv_CT_HP.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CT_HP_CellClick);
            // 
            // nGAYDONGDataGridViewTextBoxColumn
            // 
            this.nGAYDONGDataGridViewTextBoxColumn.DataPropertyName = "NGAYDONG";
            this.nGAYDONGDataGridViewTextBoxColumn.HeaderText = "NGÀY ĐÓNG";
            this.nGAYDONGDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nGAYDONGDataGridViewTextBoxColumn.Name = "nGAYDONGDataGridViewTextBoxColumn";
            // 
            // sOTIENDONGDataGridViewTextBoxColumn1
            // 
            this.sOTIENDONGDataGridViewTextBoxColumn1.DataPropertyName = "SOTIENDONG";
            this.sOTIENDONGDataGridViewTextBoxColumn1.HeaderText = "SỐ TIỀN ĐÓNG";
            this.sOTIENDONGDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.sOTIENDONGDataGridViewTextBoxColumn1.Name = "sOTIENDONGDataGridViewTextBoxColumn1";
            // 
            // menuCTHP
            // 
            this.menuCTHP.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuCTHP.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnCTHPThem,
            this.mnCTHPGhi,
            this.mnCTHPXoa});
            this.menuCTHP.Name = "menuCTHP";
            this.menuCTHP.Size = new System.Drawing.Size(165, 100);
            // 
            // mnCTHPThem
            // 
            this.mnCTHPThem.Name = "mnCTHPThem";
            this.mnCTHPThem.Size = new System.Drawing.Size(164, 32);
            this.mnCTHPThem.Text = "Thêm Mới";
            this.mnCTHPThem.Click += new System.EventHandler(this.mnCTHPThem_Click);
            // 
            // mnCTHPGhi
            // 
            this.mnCTHPGhi.Name = "mnCTHPGhi";
            this.mnCTHPGhi.Size = new System.Drawing.Size(164, 32);
            this.mnCTHPGhi.Text = "Ghi";
            this.mnCTHPGhi.Click += new System.EventHandler(this.mnCTHPGhi_Click);
            // 
            // mnCTHPXoa
            // 
            this.mnCTHPXoa.Name = "mnCTHPXoa";
            this.mnCTHPXoa.Size = new System.Drawing.Size(164, 32);
            this.mnCTHPXoa.Text = "Xóa";
            this.mnCTHPXoa.Click += new System.EventHandler(this.mnCTHPXoa_Click);
            // 
            // thêmToolStripMenuItem
            // 
            this.thêmToolStripMenuItem.Name = "thêmToolStripMenuItem";
            this.thêmToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // hủyToolStripMenuItem
            // 
            this.hủyToolStripMenuItem.Name = "hủyToolStripMenuItem";
            this.hủyToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // gET_THONGTIN_HOCPHITableAdapter
            // 
            this.gET_THONGTIN_HOCPHITableAdapter.ClearBeforeFill = true;
            // 
            // sINHVIENTableAdapter
            // 
            this.sINHVIENTableAdapter.ClearBeforeFill = true;
            // 
            // nIENKHOADataGridViewTextBoxColumn
            // 
            this.nIENKHOADataGridViewTextBoxColumn.DataPropertyName = "NIENKHOA";
            this.nIENKHOADataGridViewTextBoxColumn.HeaderText = "NIÊN KHÓA";
            this.nIENKHOADataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nIENKHOADataGridViewTextBoxColumn.Name = "nIENKHOADataGridViewTextBoxColumn";
            this.nIENKHOADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hOCKYDataGridViewTextBoxColumn
            // 
            this.hOCKYDataGridViewTextBoxColumn.DataPropertyName = "HOCKY";
            this.hOCKYDataGridViewTextBoxColumn.HeaderText = "HỌC KỲ";
            this.hOCKYDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.hOCKYDataGridViewTextBoxColumn.Name = "hOCKYDataGridViewTextBoxColumn";
            this.hOCKYDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hOCPHIDataGridViewTextBoxColumn
            // 
            this.hOCPHIDataGridViewTextBoxColumn.DataPropertyName = "HOCPHI";
            this.hOCPHIDataGridViewTextBoxColumn.HeaderText = "HỌC PHÍ";
            this.hOCPHIDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.hOCPHIDataGridViewTextBoxColumn.Name = "hOCPHIDataGridViewTextBoxColumn";
            // 
            // sOTIENDONGDataGridViewTextBoxColumn
            // 
            this.sOTIENDONGDataGridViewTextBoxColumn.DataPropertyName = "SOTIENDONG";
            this.sOTIENDONGDataGridViewTextBoxColumn.HeaderText = "SỐ TIỀN ĐÓNG";
            this.sOTIENDONGDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.sOTIENDONGDataGridViewTextBoxColumn.Name = "sOTIENDONGDataGridViewTextBoxColumn";
            this.sOTIENDONGDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // TIENCONNO
            // 
            this.TIENCONNO.HeaderText = "TIỀN CÒN NỢ";
            this.TIENCONNO.MinimumWidth = 8;
            this.TIENCONNO.Name = "TIENCONNO";
            this.TIENCONNO.ReadOnly = true;
            // 
            // frmHocPhi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1944, 736);
            this.Controls.Add(this.dgv_CT_HP);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.sidePanel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmHocPhi";
            this.Text = "Học Phí";
            this.Load += new System.EventHandler(this.frmHocPhi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.sidePanel1.ResumeLayout(false);
            this.sidePanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtLop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMASV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSinhVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS_HP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHP)).EndInit();
            this.menuHP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bdsDSHP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsd_CTHP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_HP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTHP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CT_HP)).EndInit();
            this.menuCTHP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnGhi;
        private DevExpress.XtraBars.BarButtonItem btnPhucHoi;
        private DevExpress.XtraBars.BarButtonItem btnHuy;
        private DevExpress.XtraBars.BarButtonItem barButtonItem6;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DevExpress.XtraEditors.SidePanel sidePanel1;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private DS_HP DS_HP;
        private DS_HPTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton btnTimKiem;
        private System.Windows.Forms.BindingSource bsd_CTHP;
        private DS_HPTableAdapters.CT_DONGHOCPHITableAdapter cT_DONGHOCPHITableAdapter;
        private System.Windows.Forms.BindingSource bds_HP;
        private DS_HPTableAdapters.HOCPHITableAdapter hOCPHITableAdapter;
        private System.Windows.Forms.BindingSource bdsCTHP;
        private DS_HPTableAdapters.SP_LAY_CT_HPTableAdapter sP_LAY_CT_HPTableAdapter;
        private System.Windows.Forms.DataGridView dgv_CT_HP;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraBars.BarButtonItem save;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem thêmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hủyToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvHP;
        private System.Windows.Forms.BindingSource bdsDSHP;
        private DS_HPTableAdapters.GET_THONGTIN_HOCPHITableAdapter gET_THONGTIN_HOCPHITableAdapter;
        private System.Windows.Forms.ContextMenuStrip menuCTHP;
        private System.Windows.Forms.ToolStripMenuItem mnCTHPThem;
        private System.Windows.Forms.ToolStripMenuItem mnCTHPGhi;
        private System.Windows.Forms.ToolStripMenuItem mnCTHPXoa;
        private System.Windows.Forms.ContextMenuStrip menuHP;
        private System.Windows.Forms.ToolStripMenuItem mnHPThemMoi;
        private System.Windows.Forms.ToolStripMenuItem mnHPGhi;
        private System.Windows.Forms.ToolStripMenuItem mnHPXoa;
        private BindingSource bdsSinhVien;
        private DS_HPTableAdapters.SINHVIENTableAdapter sINHVIENTableAdapter;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DevExpress.XtraEditors.TextEdit txtLop;
        private DevExpress.XtraEditors.TextEdit txtTen;
        private DevExpress.XtraEditors.TextEdit txtMASV;
        private DataGridViewTextBoxColumn nGAYDONGDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn sOTIENDONGDataGridViewTextBoxColumn1;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DataGridViewTextBoxColumn nIENKHOADataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn hOCKYDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn hOCPHIDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn sOTIENDONGDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn TIENCONNO;
    }
}