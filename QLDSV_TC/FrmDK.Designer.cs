
namespace QLDSV_TC
{
    partial class FrmDK
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.nIENKHOALabel = new System.Windows.Forms.Label();
            this.hOCKYLabel = new System.Windows.Forms.Label();
            this.qLDSV_TCDataSet = new QLDSV_TC.QLDSV_TCDataSet();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnDangKi = new DevExpress.XtraBars.BarButtonItem();
            this.btnHuyDK = new DevExpress.XtraBars.BarButtonItem();
            this.btnExit = new DevExpress.XtraBars.BarButtonItem();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.txtMalop = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbHocKy = new System.Windows.Forms.ComboBox();
            this.cbbNienKhoa = new System.Windows.Forms.ComboBox();
            this.gcDSLTC = new DevExpress.XtraGrid.GridControl();
            this.bdsDSLTC = new System.Windows.Forms.BindingSource(this.components);
            this.gvDSLTC = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMALTC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNHOM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHOTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOSV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcSVDK = new DevExpress.XtraGrid.GridControl();
            this.bdsDSDK_OF_SV = new System.Windows.Forms.BindingSource(this.components);
            this.gvDK = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMALTC1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAMH1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENMH1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNHOM1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOTIET_LT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOTIET_TH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSTC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHOCPHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sP_GETDSLTC_FROM_NK_HKTableAdapter = new QLDSV_TC.QLDSV_TCDataSetTableAdapters.SP_GETDSLTC_FROM_NK_HKTableAdapter();
            this.sP_DSDK_OF_SVTableAdapter = new QLDSV_TC.QLDSV_TCDataSetTableAdapters.SP_DSDK_OF_SVTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSV_TCDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcDSLTC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDSLTC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDSLTC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcSVDK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDSDK_OF_SV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDK)).BeginInit();
            this.SuspendLayout();
            // 
            // nIENKHOALabel
            // 
            this.nIENKHOALabel.AutoSize = true;
            this.nIENKHOALabel.Location = new System.Drawing.Point(936, 32);
            this.nIENKHOALabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.nIENKHOALabel.Name = "nIENKHOALabel";
            this.nIENKHOALabel.Size = new System.Drawing.Size(95, 19);
            this.nIENKHOALabel.TabIndex = 2;
            this.nIENKHOALabel.Text = "NIENKHOA:";
            // 
            // hOCKYLabel
            // 
            this.hOCKYLabel.AutoSize = true;
            this.hOCKYLabel.Location = new System.Drawing.Point(975, 116);
            this.hOCKYLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.hOCKYLabel.Name = "hOCKYLabel";
            this.hOCKYLabel.Size = new System.Drawing.Size(67, 19);
            this.hOCKYLabel.TabIndex = 3;
            this.hOCKYLabel.Text = "HOCKY:";
            // 
            // qLDSV_TCDataSet
            // 
            this.qLDSV_TCDataSet.DataSetName = "QLDSV_TCDataSet";
            this.qLDSV_TCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnHuyDK,
            this.btnRefresh,
            this.btnExit,
            this.btnDangKi});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 4;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 1;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnDangKi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnHuyDK, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnExit, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.Text = "Tools";
            // 
            // btnDangKi
            // 
            this.btnDangKi.Caption = "Đăng Kí";
            this.btnDangKi.Id = 3;
            this.btnDangKi.Name = "btnDangKi";
            this.btnDangKi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDangKi_ItemClick);
            // 
            // btnHuyDK
            // 
            this.btnHuyDK.Caption = "Hủy đăng kí";
            this.btnHuyDK.Id = 0;
            this.btnHuyDK.Name = "btnHuyDK";
            this.btnHuyDK.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHuyDK_ItemClick);
            // 
            // btnExit
            // 
            this.btnExit.Caption = "Thoát";
            this.btnExit.Id = 2;
            this.btnExit.Name = "btnExit";
            this.btnExit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnExit_ItemClick);
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1160, 49);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 661);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1160, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 49);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 612);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1160, 49);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 612);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Caption = "Làm mới";
            this.btnRefresh.Id = 1;
            this.btnRefresh.Name = "btnRefresh";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.txtMalop);
            this.panelControl1.Controls.Add(this.txtHoTen);
            this.panelControl1.Controls.Add(this.label2);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Controls.Add(this.hOCKYLabel);
            this.panelControl1.Controls.Add(this.cbbHocKy);
            this.panelControl1.Controls.Add(this.nIENKHOALabel);
            this.panelControl1.Controls.Add(this.cbbNienKhoa);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 49);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(5);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1160, 149);
            this.panelControl1.TabIndex = 4;
            // 
            // txtMalop
            // 
            this.txtMalop.Enabled = false;
            this.txtMalop.Location = new System.Drawing.Point(213, 94);
            this.txtMalop.Margin = new System.Windows.Forms.Padding(5);
            this.txtMalop.Name = "txtMalop";
            this.txtMalop.Size = new System.Drawing.Size(344, 27);
            this.txtMalop.TabIndex = 6;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Enabled = false;
            this.txtHoTen.Location = new System.Drawing.Point(213, 28);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(5);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(344, 27);
            this.txtHoTen.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 104);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mã Lớp:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Họ và Tên:";
            // 
            // cbbHocKy
            // 
            this.cbbHocKy.DisplayMember = "1 2 3 4";
            this.cbbHocKy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbHocKy.FormattingEnabled = true;
            this.cbbHocKy.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cbbHocKy.Location = new System.Drawing.Point(1090, 111);
            this.cbbHocKy.Margin = new System.Windows.Forms.Padding(5);
            this.cbbHocKy.Name = "cbbHocKy";
            this.cbbHocKy.Size = new System.Drawing.Size(503, 27);
            this.cbbHocKy.TabIndex = 4;
            this.cbbHocKy.SelectedIndexChanged += new System.EventHandler(this.cbbHocKy_SelectedIndexChanged);
            // 
            // cbbNienKhoa
            // 
            this.cbbNienKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbNienKhoa.FormattingEnabled = true;
            this.cbbNienKhoa.Location = new System.Drawing.Point(1090, 28);
            this.cbbNienKhoa.Margin = new System.Windows.Forms.Padding(5);
            this.cbbNienKhoa.Name = "cbbNienKhoa";
            this.cbbNienKhoa.Size = new System.Drawing.Size(503, 27);
            this.cbbNienKhoa.TabIndex = 3;
            this.cbbNienKhoa.SelectedIndexChanged += new System.EventHandler(this.cbbNienKhoa_SelectedIndexChanged);
            // 
            // gcDSLTC
            // 
            this.gcDSLTC.DataSource = this.bdsDSLTC;
            this.gcDSLTC.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcDSLTC.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(5);
            this.gcDSLTC.Location = new System.Drawing.Point(0, 198);
            this.gcDSLTC.MainView = this.gvDSLTC;
            this.gcDSLTC.Margin = new System.Windows.Forms.Padding(5);
            this.gcDSLTC.MenuManager = this.barManager1;
            this.gcDSLTC.Name = "gcDSLTC";
            this.gcDSLTC.Size = new System.Drawing.Size(1160, 214);
            this.gcDSLTC.TabIndex = 15;
            this.gcDSLTC.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDSLTC});
            // 
            // bdsDSLTC
            // 
            this.bdsDSLTC.DataMember = "SP_GETDSLTC_FROM_NK_HK";
            this.bdsDSLTC.DataSource = this.qLDSV_TCDataSet;
            // 
            // gvDSLTC
            // 
            this.gvDSLTC.ColumnPanelRowHeight = 40;
            this.gvDSLTC.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMALTC,
            this.colMAMH,
            this.colTENMH,
            this.colNHOM,
            this.colHOTEN,
            this.colSOSV});
            this.gvDSLTC.GridControl = this.gcDSLTC;
            this.gvDSLTC.GroupPanelText = "DANH SÁCH LỚP TÍN CHỈ";
            this.gvDSLTC.Name = "gvDSLTC";
            this.gvDSLTC.OptionsBehavior.Editable = false;
            this.gvDSLTC.OptionsBehavior.ReadOnly = true;
            this.gvDSLTC.RowHeight = 30;
            this.gvDSLTC.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gvDSLTC_RowClick);
            this.gvDSLTC.ShowingEditor += new System.ComponentModel.CancelEventHandler(this.gvDSLTC_ShowingEditor);
            // 
            // colMALTC
            // 
            this.colMALTC.Caption = "Mã Lớp Tín Chỉ";
            this.colMALTC.FieldName = "MALTC";
            this.colMALTC.MinWidth = 25;
            this.colMALTC.Name = "colMALTC";
            this.colMALTC.Visible = true;
            this.colMALTC.VisibleIndex = 0;
            this.colMALTC.Width = 94;
            // 
            // colMAMH
            // 
            this.colMAMH.Caption = "Mã Môn Học";
            this.colMAMH.FieldName = "MAMH";
            this.colMAMH.MinWidth = 25;
            this.colMAMH.Name = "colMAMH";
            this.colMAMH.Visible = true;
            this.colMAMH.VisibleIndex = 1;
            this.colMAMH.Width = 94;
            // 
            // colTENMH
            // 
            this.colTENMH.Caption = "Tên Môn Học";
            this.colTENMH.FieldName = "TENMH";
            this.colTENMH.MinWidth = 25;
            this.colTENMH.Name = "colTENMH";
            this.colTENMH.Visible = true;
            this.colTENMH.VisibleIndex = 2;
            this.colTENMH.Width = 94;
            // 
            // colNHOM
            // 
            this.colNHOM.Caption = "Nhóm";
            this.colNHOM.FieldName = "NHOM";
            this.colNHOM.MinWidth = 25;
            this.colNHOM.Name = "colNHOM";
            this.colNHOM.Visible = true;
            this.colNHOM.VisibleIndex = 3;
            this.colNHOM.Width = 94;
            // 
            // colHOTEN
            // 
            this.colHOTEN.Caption = "Họ Tên GV";
            this.colHOTEN.FieldName = "HOTEN";
            this.colHOTEN.MinWidth = 25;
            this.colHOTEN.Name = "colHOTEN";
            this.colHOTEN.Visible = true;
            this.colHOTEN.VisibleIndex = 4;
            this.colHOTEN.Width = 94;
            // 
            // colSOSV
            // 
            this.colSOSV.Caption = "SỐ SV đã đăng kí";
            this.colSOSV.FieldName = "SOSV";
            this.colSOSV.MinWidth = 25;
            this.colSOSV.Name = "colSOSV";
            this.colSOSV.Visible = true;
            this.colSOSV.VisibleIndex = 5;
            this.colSOSV.Width = 94;
            // 
            // gcSVDK
            // 
            this.gcSVDK.DataSource = this.bdsDSDK_OF_SV;
            this.gcSVDK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcSVDK.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(5);
            gridLevelNode1.RelationName = "Level1";
            this.gcSVDK.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gcSVDK.Location = new System.Drawing.Point(0, 412);
            this.gcSVDK.MainView = this.gvDK;
            this.gcSVDK.Margin = new System.Windows.Forms.Padding(5);
            this.gcSVDK.MenuManager = this.barManager1;
            this.gcSVDK.Name = "gcSVDK";
            this.gcSVDK.Size = new System.Drawing.Size(1160, 249);
            this.gcSVDK.TabIndex = 25;
            this.gcSVDK.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDK});
            // 
            // bdsDSDK_OF_SV
            // 
            this.bdsDSDK_OF_SV.DataMember = "SP_DSDK_OF_SV";
            this.bdsDSDK_OF_SV.DataSource = this.qLDSV_TCDataSet;
            // 
            // gvDK
            // 
            this.gvDK.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMALTC1,
            this.colMAMH1,
            this.colTENMH1,
            this.colNHOM1,
            this.colSOTIET_LT,
            this.colSOTIET_TH,
            this.colSTC,
            this.colHOCPHI});
            this.gvDK.GridControl = this.gcSVDK;
            this.gvDK.GroupPanelText = "DANH SÁCH MÔN SINH VIÊN ĐÃ ĐĂNG KÍ";
            this.gvDK.Name = "gvDK";
            this.gvDK.OptionsBehavior.ReadOnly = true;
            this.gvDK.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gvDK_RowClick);
            // 
            // colMALTC1
            // 
            this.colMALTC1.FieldName = "MALTC";
            this.colMALTC1.MinWidth = 25;
            this.colMALTC1.Name = "colMALTC1";
            this.colMALTC1.Visible = true;
            this.colMALTC1.VisibleIndex = 0;
            this.colMALTC1.Width = 94;
            // 
            // colMAMH1
            // 
            this.colMAMH1.FieldName = "MAMH";
            this.colMAMH1.MinWidth = 25;
            this.colMAMH1.Name = "colMAMH1";
            this.colMAMH1.Visible = true;
            this.colMAMH1.VisibleIndex = 1;
            this.colMAMH1.Width = 94;
            // 
            // colTENMH1
            // 
            this.colTENMH1.FieldName = "TENMH";
            this.colTENMH1.MinWidth = 25;
            this.colTENMH1.Name = "colTENMH1";
            this.colTENMH1.Visible = true;
            this.colTENMH1.VisibleIndex = 2;
            this.colTENMH1.Width = 94;
            // 
            // colNHOM1
            // 
            this.colNHOM1.FieldName = "NHOM";
            this.colNHOM1.MinWidth = 25;
            this.colNHOM1.Name = "colNHOM1";
            this.colNHOM1.Visible = true;
            this.colNHOM1.VisibleIndex = 3;
            this.colNHOM1.Width = 94;
            // 
            // colSOTIET_LT
            // 
            this.colSOTIET_LT.FieldName = "SOTIET_LT";
            this.colSOTIET_LT.MinWidth = 25;
            this.colSOTIET_LT.Name = "colSOTIET_LT";
            this.colSOTIET_LT.Visible = true;
            this.colSOTIET_LT.VisibleIndex = 4;
            this.colSOTIET_LT.Width = 94;
            // 
            // colSOTIET_TH
            // 
            this.colSOTIET_TH.FieldName = "SOTIET_TH";
            this.colSOTIET_TH.MinWidth = 25;
            this.colSOTIET_TH.Name = "colSOTIET_TH";
            this.colSOTIET_TH.Visible = true;
            this.colSOTIET_TH.VisibleIndex = 5;
            this.colSOTIET_TH.Width = 94;
            // 
            // colSTC
            // 
            this.colSTC.FieldName = "STC";
            this.colSTC.MinWidth = 25;
            this.colSTC.Name = "colSTC";
            this.colSTC.Visible = true;
            this.colSTC.VisibleIndex = 6;
            this.colSTC.Width = 94;
            // 
            // colHOCPHI
            // 
            this.colHOCPHI.FieldName = "HOCPHI";
            this.colHOCPHI.MinWidth = 25;
            this.colHOCPHI.Name = "colHOCPHI";
            this.colHOCPHI.Visible = true;
            this.colHOCPHI.VisibleIndex = 7;
            this.colHOCPHI.Width = 94;
            // 
            // sP_GETDSLTC_FROM_NK_HKTableAdapter
            // 
            this.sP_GETDSLTC_FROM_NK_HKTableAdapter.ClearBeforeFill = true;
            // 
            // sP_DSDK_OF_SVTableAdapter
            // 
            this.sP_DSDK_OF_SVTableAdapter.ClearBeforeFill = true;
            // 
            // FrmDK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 681);
            this.Controls.Add(this.gcSVDK);
            this.Controls.Add(this.gcDSLTC);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmDK";
            this.Text = "FrmLTC";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmLTC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qLDSV_TCDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcDSLTC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDSLTC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDSLTC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcSVDK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDSDK_OF_SV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDK)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private QLDSV_TCDataSet qLDSV_TCDataSet;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnHuyDK;
        private DevExpress.XtraBars.BarButtonItem btnRefresh;
        private DevExpress.XtraBars.BarButtonItem btnExit;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.ComboBox cbbHocKy;
        private System.Windows.Forms.ComboBox cbbNienKhoa;
        private System.Windows.Forms.TextBox txtMalop;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.GridControl gcDSLTC;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDSLTC;
        private DevExpress.XtraGrid.Columns.GridColumn colMALTC;
        private DevExpress.XtraGrid.Columns.GridColumn colMAMH;
        private DevExpress.XtraGrid.Columns.GridColumn colTENMH;
        private DevExpress.XtraGrid.Columns.GridColumn colNHOM;
        private DevExpress.XtraGrid.Columns.GridColumn colHOTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colSOSV;
        private DevExpress.XtraGrid.GridControl gcSVDK;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDK;
        private DevExpress.XtraGrid.Columns.GridColumn colMALTC1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAMH1;
        private DevExpress.XtraGrid.Columns.GridColumn colTENMH1;
        private DevExpress.XtraGrid.Columns.GridColumn colNHOM1;
        private DevExpress.XtraGrid.Columns.GridColumn colSOTIET_LT;
        private DevExpress.XtraGrid.Columns.GridColumn colSOTIET_TH;
        private DevExpress.XtraGrid.Columns.GridColumn colSTC;
        private DevExpress.XtraGrid.Columns.GridColumn colHOCPHI;
        private System.Windows.Forms.BindingSource bdsDSDK_OF_SV;
        private System.Windows.Forms.BindingSource bdsDSLTC;
        private QLDSV_TCDataSetTableAdapters.SP_GETDSLTC_FROM_NK_HKTableAdapter sP_GETDSLTC_FROM_NK_HKTableAdapter;
        private QLDSV_TCDataSetTableAdapters.SP_DSDK_OF_SVTableAdapter sP_DSDK_OF_SVTableAdapter;
        private DevExpress.XtraBars.BarButtonItem btnDangKi;
        private System.Windows.Forms.Label nIENKHOALabel;
        private System.Windows.Forms.Label hOCKYLabel;
    }
}