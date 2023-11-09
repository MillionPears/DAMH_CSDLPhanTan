namespace QLDSV_TC
{
    partial class FormMonH
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMonH));
            this.sOTIET_THLabel = new System.Windows.Forms.Label();
            this.sOTIET_LTLabel = new System.Windows.Forms.Label();
            this.tENMHLabel = new System.Windows.Forms.Label();
            this.mAMHLabel = new System.Windows.Forms.Label();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.bar4 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnSua = new DevExpress.XtraBars.BarButtonItem();
            this.BtnGhi = new DevExpress.XtraBars.BarButtonItem();
            this.BtnHTac = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.bar5 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.BtnPhucHoi = new DevExpress.XtraBars.BarButtonItem();
            this.BtnHoanTac = new DevExpress.XtraBars.BarButtonItem();
            this.gcMonHoc = new DevExpress.XtraGrid.GridControl();
            this.BDSMHoc = new System.Windows.Forms.BindingSource(this.components);
            this.qLDSV_TCDataSet2 = new QLDSV_TC.QLDSV_TCDataSet2();
            this.gvMonHoc = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOTIET_LT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOTIET_TH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tableAdapterManager = new QLDSV_TC.QLDSV_TCDataSet2TableAdapters.TableAdapterManager();
            this.pnMH = new DevExpress.XtraEditors.PanelControl();
            this.spinSTTH = new DevExpress.XtraEditors.SpinEdit();
            this.spinSTLT = new DevExpress.XtraEditors.SpinEdit();
            this.txtTenMH = new DevExpress.XtraEditors.TextEdit();
            this.txtMaMH = new System.Windows.Forms.TextBox();
            this.mONHOCTableAdapter = new QLDSV_TC.QLDSV_TCDataSet2TableAdapters.MONHOCTableAdapter();
            this.BDSLopTChi = new System.Windows.Forms.BindingSource(this.components);
            this.lOPTINCHITableAdapter = new QLDSV_TC.QLDSV_TCDataSet2TableAdapters.LOPTINCHITableAdapter();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcMonHoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BDSMHoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSV_TCDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMonHoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnMH)).BeginInit();
            this.pnMH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinSTTH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinSTLT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenMH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BDSLopTChi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // sOTIET_THLabel
            // 
            this.sOTIET_THLabel.AutoSize = true;
            this.sOTIET_THLabel.Location = new System.Drawing.Point(413, 166);
            this.sOTIET_THLabel.Name = "sOTIET_THLabel";
            this.sOTIET_THLabel.Size = new System.Drawing.Size(130, 19);
            this.sOTIET_THLabel.TabIndex = 20;
            this.sOTIET_THLabel.Text = "Số tiết thực hành";
            // 
            // sOTIET_LTLabel
            // 
            this.sOTIET_LTLabel.AutoSize = true;
            this.sOTIET_LTLabel.Location = new System.Drawing.Point(417, 123);
            this.sOTIET_LTLabel.Name = "sOTIET_LTLabel";
            this.sOTIET_LTLabel.Size = new System.Drawing.Size(120, 19);
            this.sOTIET_LTLabel.TabIndex = 18;
            this.sOTIET_LTLabel.Text = "Số tiết lý thuyết";
            // 
            // tENMHLabel
            // 
            this.tENMHLabel.AutoSize = true;
            this.tENMHLabel.Location = new System.Drawing.Point(442, 77);
            this.tENMHLabel.Name = "tENMHLabel";
            this.tENMHLabel.Size = new System.Drawing.Size(101, 19);
            this.tENMHLabel.TabIndex = 16;
            this.tENMHLabel.Text = "Tên Môn học";
            // 
            // mAMHLabel
            // 
            this.mAMHLabel.AutoSize = true;
            this.mAMHLabel.Location = new System.Drawing.Point(438, 34);
            this.mAMHLabel.Name = "mAMHLabel";
            this.mAMHLabel.Size = new System.Drawing.Size(96, 19);
            this.mAMHLabel.TabIndex = 14;
            this.mAMHLabel.Text = "Mã môn học";
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.FloatLocation = new System.Drawing.Point(230, 241);
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // bar1
            // 
            this.bar1.BarName = "Main menu";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.FloatLocation = new System.Drawing.Point(230, 241);
            this.bar1.OptionsBar.MultiLine = true;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Main menu";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar3,
            this.bar4,
            this.bar5});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnThem,
            this.btnXoa,
            this.btnSua,
            this.BtnGhi,
            this.BtnPhucHoi,
            this.BtnHoanTac,
            this.BtnHTac,
            this.barButtonItem1});
            this.barManager1.MainMenu = this.bar4;
            this.barManager1.MaxItemId = 9;
            this.barManager1.StatusBar = this.bar5;
            // 
            // bar3
            // 
            this.bar3.BarName = "Tools";
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 1;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar3.Text = "Tools";
            // 
            // bar4
            // 
            this.bar4.BarName = "Main menu";
            this.bar4.DockCol = 0;
            this.bar4.DockRow = 0;
            this.bar4.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar4.FloatLocation = new System.Drawing.Point(230, 241);
            this.bar4.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnThem),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnXoa),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnSua),
            new DevExpress.XtraBars.LinkPersistInfo(this.BtnGhi),
            new DevExpress.XtraBars.LinkPersistInfo(this.BtnHTac),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem1)});
            this.bar4.OptionsBar.MultiLine = true;
            this.bar4.OptionsBar.UseWholeRow = true;
            this.bar4.Text = "Main menu";
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Thêm";
            this.btnThem.Id = 0;
            this.btnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.Image")));
            this.btnThem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.LargeImage")));
            this.btnThem.Name = "btnThem";
            this.btnThem.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Id = 1;
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.LargeImage")));
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick_1);
            // 
            // btnSua
            // 
            this.btnSua.Caption = "Sửa";
            this.btnSua.Id = 2;
            this.btnSua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.Image")));
            this.btnSua.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.LargeImage")));
            this.btnSua.Name = "btnSua";
            this.btnSua.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnSua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSua_ItemClick_1);
            // 
            // BtnGhi
            // 
            this.BtnGhi.Caption = "Ghi";
            this.BtnGhi.Id = 3;
            this.BtnGhi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnGhi.ImageOptions.Image")));
            this.BtnGhi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnGhi.ImageOptions.LargeImage")));
            this.BtnGhi.Name = "BtnGhi";
            this.BtnGhi.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.BtnGhi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnGhi_ItemClick_1);
            // 
            // BtnHTac
            // 
            this.BtnHTac.Caption = "Hoàn tác";
            this.BtnHTac.Id = 7;
            this.BtnHTac.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnHTac.ImageOptions.Image")));
            this.BtnHTac.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnHTac.ImageOptions.LargeImage")));
            this.BtnHTac.Name = "BtnHTac";
            this.BtnHTac.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.BtnHTac.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnHTac_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Thoat";
            this.barButtonItem1.Id = 8;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // bar5
            // 
            this.bar5.BarName = "Status bar";
            this.bar5.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar5.DockCol = 0;
            this.bar5.DockRow = 0;
            this.bar5.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar5.OptionsBar.AllowQuickCustomization = false;
            this.bar5.OptionsBar.DrawDragBorder = false;
            this.bar5.OptionsBar.UseWholeRow = true;
            this.bar5.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1872, 55);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 1030);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1872, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 55);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 975);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1872, 55);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 975);
            // 
            // BtnPhucHoi
            // 
            this.BtnPhucHoi.Caption = "Phục hồi";
            this.BtnPhucHoi.Id = 5;
            this.BtnPhucHoi.Name = "BtnPhucHoi";
            this.BtnPhucHoi.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // BtnHoanTac
            // 
            this.BtnHoanTac.Caption = "Hoàn tác";
            this.BtnHoanTac.Id = 6;
            this.BtnHoanTac.Name = "BtnHoanTac";
            // 
            // gcMonHoc
            // 
            this.gcMonHoc.DataSource = this.BDSMHoc;
            this.gcMonHoc.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcMonHoc.Location = new System.Drawing.Point(0, 65);
            this.gcMonHoc.MainView = this.gvMonHoc;
            this.gcMonHoc.MenuManager = this.barManager1;
            this.gcMonHoc.Name = "gcMonHoc";
            this.gcMonHoc.Size = new System.Drawing.Size(1872, 204);
            this.gcMonHoc.TabIndex = 5;
            this.gcMonHoc.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvMonHoc});
            this.gcMonHoc.Click += new System.EventHandler(this.gcMonHoc_Click_1);
            // 
            // BDSMHoc
            // 
            this.BDSMHoc.DataMember = "MONHOC";
            this.BDSMHoc.DataSource = this.qLDSV_TCDataSet2;
            // 
            // qLDSV_TCDataSet2
            // 
            this.qLDSV_TCDataSet2.DataSetName = "QLDSV_TCDataSet2";
            this.qLDSV_TCDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gvMonHoc
            // 
            this.gvMonHoc.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAMH,
            this.colTENMH,
            this.colSOTIET_LT,
            this.colSOTIET_TH});
            this.gvMonHoc.GridControl = this.gcMonHoc;
            this.gvMonHoc.Name = "gvMonHoc";
            this.gvMonHoc.OptionsBehavior.ReadOnly = true;
            // 
            // colMAMH
            // 
            this.colMAMH.FieldName = "MAMH";
            this.colMAMH.MinWidth = 30;
            this.colMAMH.Name = "colMAMH";
            this.colMAMH.Visible = true;
            this.colMAMH.VisibleIndex = 0;
            this.colMAMH.Width = 112;
            // 
            // colTENMH
            // 
            this.colTENMH.FieldName = "TENMH";
            this.colTENMH.MinWidth = 30;
            this.colTENMH.Name = "colTENMH";
            this.colTENMH.Visible = true;
            this.colTENMH.VisibleIndex = 1;
            this.colTENMH.Width = 112;
            // 
            // colSOTIET_LT
            // 
            this.colSOTIET_LT.FieldName = "SOTIET_LT";
            this.colSOTIET_LT.MinWidth = 30;
            this.colSOTIET_LT.Name = "colSOTIET_LT";
            this.colSOTIET_LT.Visible = true;
            this.colSOTIET_LT.VisibleIndex = 2;
            this.colSOTIET_LT.Width = 112;
            // 
            // colSOTIET_TH
            // 
            this.colSOTIET_TH.FieldName = "SOTIET_TH";
            this.colSOTIET_TH.MinWidth = 30;
            this.colSOTIET_TH.Name = "colSOTIET_TH";
            this.colSOTIET_TH.Visible = true;
            this.colSOTIET_TH.VisibleIndex = 3;
            this.colSOTIET_TH.Width = 112;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.LOPTINCHITableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLDSV_TC.QLDSV_TCDataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // pnMH
            // 
            this.pnMH.Controls.Add(this.sOTIET_THLabel);
            this.pnMH.Controls.Add(this.spinSTTH);
            this.pnMH.Controls.Add(this.sOTIET_LTLabel);
            this.pnMH.Controls.Add(this.spinSTLT);
            this.pnMH.Controls.Add(this.tENMHLabel);
            this.pnMH.Controls.Add(this.txtTenMH);
            this.pnMH.Controls.Add(this.mAMHLabel);
            this.pnMH.Controls.Add(this.txtMaMH);
            this.pnMH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMH.Location = new System.Drawing.Point(0, 269);
            this.pnMH.Name = "pnMH";
            this.pnMH.Size = new System.Drawing.Size(1872, 761);
            this.pnMH.TabIndex = 18;
            // 
            // spinSTTH
            // 
            this.spinSTTH.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.BDSMHoc, "SOTIET_TH", true));
            this.spinSTTH.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinSTTH.Location = new System.Drawing.Point(550, 162);
            this.spinSTTH.MenuManager = this.barManager1;
            this.spinSTTH.Name = "spinSTTH";
            this.spinSTTH.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinSTTH.Size = new System.Drawing.Size(386, 28);
            this.spinSTTH.TabIndex = 21;
            // 
            // spinSTLT
            // 
            this.spinSTLT.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.BDSMHoc, "SOTIET_LT", true));
            this.spinSTLT.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinSTLT.Location = new System.Drawing.Point(550, 119);
            this.spinSTLT.MenuManager = this.barManager1;
            this.spinSTLT.Name = "spinSTLT";
            this.spinSTLT.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinSTLT.Size = new System.Drawing.Size(386, 28);
            this.spinSTLT.TabIndex = 19;
            // 
            // txtTenMH
            // 
            this.txtTenMH.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BDSMHoc, "TENMH", true));
            this.txtTenMH.Location = new System.Drawing.Point(550, 74);
            this.txtTenMH.MenuManager = this.barManager1;
            this.txtTenMH.Name = "txtTenMH";
            this.txtTenMH.Size = new System.Drawing.Size(386, 28);
            this.txtTenMH.TabIndex = 17;
            // 
            // txtMaMH
            // 
            this.txtMaMH.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BDSMHoc, "MAMH", true));
            this.txtMaMH.Location = new System.Drawing.Point(550, 31);
            this.txtMaMH.Name = "txtMaMH";
            this.txtMaMH.Size = new System.Drawing.Size(386, 27);
            this.txtMaMH.TabIndex = 15;
            // 
            // mONHOCTableAdapter
            // 
            this.mONHOCTableAdapter.ClearBeforeFill = true;
            // 
            // BDSLopTChi
            // 
            this.BDSLopTChi.DataMember = "FK_LOPTINCHI_MONHOC";
            this.BDSLopTChi.DataSource = this.BDSMHoc;
            // 
            // lOPTINCHITableAdapter
            // 
            this.lOPTINCHITableAdapter.ClearBeforeFill = true;
            // 
            // panelControl1
            // 
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 55);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1872, 10);
            this.panelControl1.TabIndex = 4;
            // 
            // FormMonH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1872, 1050);
            this.Controls.Add(this.pnMH);
            this.Controls.Add(this.gcMonHoc);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FormMonH";
            this.Text = "FormMonH";
            this.Load += new System.EventHandler(this.FormMonH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcMonHoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BDSMHoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSV_TCDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMonHoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnMH)).EndInit();
            this.pnMH.ResumeLayout(false);
            this.pnMH.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinSTTH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinSTLT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenMH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BDSLopTChi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.Bar bar4;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnSua;
        private DevExpress.XtraBars.BarButtonItem BtnGhi;
        private DevExpress.XtraBars.BarButtonItem BtnPhucHoi;
        private DevExpress.XtraBars.BarButtonItem BtnHTac;
        private DevExpress.XtraBars.Bar bar5;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraGrid.GridControl gcMonHoc;
        private DevExpress.XtraGrid.Views.Grid.GridView gvMonHoc;

        private DevExpress.XtraBars.BarButtonItem BtnHoanTac;
        private QLDSV_TCDataSet2 qLDSV_TCDataSet2;
        private DevExpress.XtraGrid.Columns.GridColumn colMAMH;
        private DevExpress.XtraGrid.Columns.GridColumn colTENMH;
        private DevExpress.XtraGrid.Columns.GridColumn colSOTIET_LT;
        private DevExpress.XtraGrid.Columns.GridColumn colSOTIET_TH;
        private QLDSV_TCDataSet2TableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.PanelControl pnMH;
        private DevExpress.XtraEditors.SpinEdit spinSTTH;
        private DevExpress.XtraEditors.SpinEdit spinSTLT;
        private DevExpress.XtraEditors.TextEdit txtTenMH;
        private System.Windows.Forms.TextBox txtMaMH;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private System.Windows.Forms.BindingSource BDSMHoc;
        private QLDSV_TCDataSet2TableAdapters.MONHOCTableAdapter mONHOCTableAdapter;
        private System.Windows.Forms.BindingSource BDSLopTChi;
        private QLDSV_TCDataSet2TableAdapters.LOPTINCHITableAdapter lOPTINCHITableAdapter;
        private System.Windows.Forms.Label sOTIET_THLabel;
        private System.Windows.Forms.Label sOTIET_LTLabel;
        private System.Windows.Forms.Label tENMHLabel;
        private System.Windows.Forms.Label mAMHLabel;
        private DevExpress.XtraEditors.PanelControl panelControl1;
    }
}