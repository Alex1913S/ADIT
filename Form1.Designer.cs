
namespace SOFTWARE_INVENTARIO
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties9 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties10 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties11 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties12 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties13 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties14 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties15 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties16 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            this.DataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet1 = new SOFTWARE_INVENTARIO.DataSet1();
            this.DataTable2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TUsuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Btn_report = new Guna.UI2.WinForms.Guna2Button();
            this.txt_Fdevol = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txt_Fprest = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.bunifuShadowPanel1 = new Bunifu.UI.WinForms.BunifuShadowPanel();
            this.txt_contraseña = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.txt_Documento = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.cbx_Solicitante = new Guna.UI2.WinForms.Guna2ComboBox();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.DataSet2 = new SOFTWARE_INVENTARIO.DataSet2();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TUsuariosBindingSource)).BeginInit();
            this.bunifuShadowPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // DataTable1BindingSource
            // 
            this.DataTable1BindingSource.DataMember = "DataTable1";
            this.DataTable1BindingSource.DataSource = this.DataSet1;
            // 
            // DataSet1
            // 
            this.DataSet1.DataSetName = "DataSet1";
            this.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DataTable2BindingSource
            // 
            this.DataTable2BindingSource.DataMember = "DataTable2";
            this.DataTable2BindingSource.DataSource = this.DataSet1;
            // 
            // TUsuariosBindingSource
            // 
            this.TUsuariosBindingSource.DataMember = "TUsuarios";
            this.TUsuariosBindingSource.DataSource = this.DataSet1;
            // 
            // Btn_report
            // 
            this.Btn_report.BorderRadius = 8;
            this.Btn_report.CheckedState.Parent = this.Btn_report;
            this.Btn_report.CustomImages.Parent = this.Btn_report;
            this.Btn_report.FillColor = System.Drawing.Color.Gray;
            this.Btn_report.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.Btn_report.ForeColor = System.Drawing.Color.White;
            this.Btn_report.HoverState.Parent = this.Btn_report;
            this.Btn_report.Location = new System.Drawing.Point(10, 475);
            this.Btn_report.Name = "Btn_report";
            this.Btn_report.ShadowDecoration.Parent = this.Btn_report;
            this.Btn_report.Size = new System.Drawing.Size(171, 41);
            this.Btn_report.TabIndex = 1;
            this.Btn_report.Text = "Generar Reporte";
            this.Btn_report.Click += new System.EventHandler(this.Btn_report_Click);
            // 
            // txt_Fdevol
            // 
            this.txt_Fdevol.BorderRadius = 8;
            this.txt_Fdevol.CheckedState.Parent = this.txt_Fdevol;
            this.txt_Fdevol.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(115)))), ((int)(((byte)(35)))));
            this.txt_Fdevol.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Fdevol.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_Fdevol.HoverState.Parent = this.txt_Fdevol;
            this.txt_Fdevol.Location = new System.Drawing.Point(8, 175);
            this.txt_Fdevol.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txt_Fdevol.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txt_Fdevol.Name = "txt_Fdevol";
            this.txt_Fdevol.ShadowDecoration.Parent = this.txt_Fdevol;
            this.txt_Fdevol.Size = new System.Drawing.Size(175, 36);
            this.txt_Fdevol.TabIndex = 2;
            this.txt_Fdevol.Value = new System.DateTime(2021, 8, 5, 20, 2, 30, 604);
            // 
            // txt_Fprest
            // 
            this.txt_Fprest.BorderRadius = 8;
            this.txt_Fprest.CheckedState.Parent = this.txt_Fprest;
            this.txt_Fprest.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(115)))), ((int)(((byte)(35)))));
            this.txt_Fprest.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Fprest.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_Fprest.HoverState.Parent = this.txt_Fprest;
            this.txt_Fprest.Location = new System.Drawing.Point(8, 133);
            this.txt_Fprest.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txt_Fprest.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txt_Fprest.Name = "txt_Fprest";
            this.txt_Fprest.ShadowDecoration.Parent = this.txt_Fprest;
            this.txt_Fprest.Size = new System.Drawing.Size(175, 36);
            this.txt_Fprest.TabIndex = 1;
            this.txt_Fprest.Value = new System.DateTime(2021, 8, 5, 20, 2, 30, 604);
            // 
            // reportViewer1
            // 
            this.reportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Left;
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SOFTWARE_INVENTARIO.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(191, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 527);
            this.reportViewer1.TabIndex = 1;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // bunifuShadowPanel1
            // 
            this.bunifuShadowPanel1.BackColor = System.Drawing.Color.White;
            this.bunifuShadowPanel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(115)))), ((int)(((byte)(35)))));
            this.bunifuShadowPanel1.BorderRadius = 15;
            this.bunifuShadowPanel1.BorderThickness = 1;
            this.bunifuShadowPanel1.Controls.Add(this.txt_contraseña);
            this.bunifuShadowPanel1.Controls.Add(this.txt_Documento);
            this.bunifuShadowPanel1.Controls.Add(this.cbx_Solicitante);
            this.bunifuShadowPanel1.Controls.Add(this.bunifuLabel1);
            this.bunifuShadowPanel1.Controls.Add(this.Btn_report);
            this.bunifuShadowPanel1.Controls.Add(this.txt_Fprest);
            this.bunifuShadowPanel1.Controls.Add(this.txt_Fdevol);
            this.bunifuShadowPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.bunifuShadowPanel1.FillStyle = Bunifu.UI.WinForms.BunifuShadowPanel.FillStyles.Solid;
            this.bunifuShadowPanel1.GradientMode = Bunifu.UI.WinForms.BunifuShadowPanel.GradientModes.Vertical;
            this.bunifuShadowPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuShadowPanel1.Name = "bunifuShadowPanel1";
            this.bunifuShadowPanel1.PanelColor = System.Drawing.Color.White;
            this.bunifuShadowPanel1.PanelColor2 = System.Drawing.Color.White;
            this.bunifuShadowPanel1.ShadowColor = System.Drawing.Color.Gray;
            this.bunifuShadowPanel1.ShadowDept = 2;
            this.bunifuShadowPanel1.ShadowDepth = 3;
            this.bunifuShadowPanel1.ShadowStyle = Bunifu.UI.WinForms.BunifuShadowPanel.ShadowStyles.Surrounded;
            this.bunifuShadowPanel1.ShadowTopLeftVisible = false;
            this.bunifuShadowPanel1.Size = new System.Drawing.Size(191, 527);
            this.bunifuShadowPanel1.Style = Bunifu.UI.WinForms.BunifuShadowPanel.BevelStyles.Flat;
            this.bunifuShadowPanel1.TabIndex = 2;
            // 
            // txt_contraseña
            // 
            this.txt_contraseña.AcceptsReturn = false;
            this.txt_contraseña.AcceptsTab = false;
            this.txt_contraseña.AnimationSpeed = 200;
            this.txt_contraseña.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txt_contraseña.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_contraseña.BackColor = System.Drawing.Color.Transparent;
            this.txt_contraseña.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txt_contraseña.BackgroundImage")));
            this.txt_contraseña.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txt_contraseña.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(28)))));
            this.txt_contraseña.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.txt_contraseña.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(173)))), ((int)(((byte)(5)))));
            this.txt_contraseña.BorderColorIdle = System.Drawing.Color.Silver;
            this.txt_contraseña.BorderRadius = 8;
            this.txt_contraseña.BorderThickness = 2;
            this.txt_contraseña.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_contraseña.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_contraseña.DefaultFont = new System.Drawing.Font("Microsoft JhengHei UI", 11F, System.Drawing.FontStyle.Bold);
            this.txt_contraseña.DefaultText = "";
            this.txt_contraseña.FillColor = System.Drawing.Color.White;
            this.txt_contraseña.ForeColor = System.Drawing.Color.Gray;
            this.txt_contraseña.HideSelection = true;
            this.txt_contraseña.IconLeft = null;
            this.txt_contraseña.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_contraseña.IconPadding = 10;
            this.txt_contraseña.IconRight = null;
            this.txt_contraseña.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_contraseña.Lines = new string[0];
            this.txt_contraseña.Location = new System.Drawing.Point(8, 431);
            this.txt_contraseña.MaxLength = 32767;
            this.txt_contraseña.MinimumSize = new System.Drawing.Size(100, 35);
            this.txt_contraseña.Modified = false;
            this.txt_contraseña.Multiline = false;
            this.txt_contraseña.Name = "txt_contraseña";
            stateProperties9.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(28)))));
            stateProperties9.FillColor = System.Drawing.Color.Empty;
            stateProperties9.ForeColor = System.Drawing.Color.Empty;
            stateProperties9.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_contraseña.OnActiveState = stateProperties9;
            stateProperties10.BorderColor = System.Drawing.Color.Empty;
            stateProperties10.FillColor = System.Drawing.Color.White;
            stateProperties10.ForeColor = System.Drawing.Color.Empty;
            stateProperties10.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txt_contraseña.OnDisabledState = stateProperties10;
            stateProperties11.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(173)))), ((int)(((byte)(5)))));
            stateProperties11.FillColor = System.Drawing.Color.Empty;
            stateProperties11.ForeColor = System.Drawing.Color.Empty;
            stateProperties11.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_contraseña.OnHoverState = stateProperties11;
            stateProperties12.BorderColor = System.Drawing.Color.Silver;
            stateProperties12.FillColor = System.Drawing.Color.White;
            stateProperties12.ForeColor = System.Drawing.Color.Gray;
            stateProperties12.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_contraseña.OnIdleState = stateProperties12;
            this.txt_contraseña.PasswordChar = '●';
            this.txt_contraseña.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txt_contraseña.PlaceholderText = "";
            this.txt_contraseña.ReadOnly = false;
            this.txt_contraseña.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_contraseña.SelectedText = "";
            this.txt_contraseña.SelectionLength = 0;
            this.txt_contraseña.SelectionStart = 0;
            this.txt_contraseña.ShortcutsEnabled = true;
            this.txt_contraseña.Size = new System.Drawing.Size(175, 38);
            this.txt_contraseña.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.txt_contraseña.TabIndex = 198;
            this.txt_contraseña.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_contraseña.TextMarginBottom = 0;
            this.txt_contraseña.TextMarginLeft = 5;
            this.txt_contraseña.TextMarginTop = 0;
            this.txt_contraseña.TextPlaceholder = "";
            this.txt_contraseña.UseSystemPasswordChar = true;
            this.txt_contraseña.WordWrap = true;
            this.txt_contraseña.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_contraseña_KeyDown);
            this.txt_contraseña.Validated += new System.EventHandler(this.txt_contraseña_Validated);
            // 
            // txt_Documento
            // 
            this.txt_Documento.AcceptsReturn = false;
            this.txt_Documento.AcceptsTab = false;
            this.txt_Documento.AnimationSpeed = 200;
            this.txt_Documento.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txt_Documento.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_Documento.BackColor = System.Drawing.Color.Transparent;
            this.txt_Documento.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txt_Documento.BackgroundImage")));
            this.txt_Documento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txt_Documento.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(28)))));
            this.txt_Documento.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.txt_Documento.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(173)))), ((int)(((byte)(5)))));
            this.txt_Documento.BorderColorIdle = System.Drawing.Color.Silver;
            this.txt_Documento.BorderRadius = 8;
            this.txt_Documento.BorderThickness = 2;
            this.txt_Documento.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_Documento.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Documento.DefaultFont = new System.Drawing.Font("Microsoft JhengHei UI", 11F, System.Drawing.FontStyle.Bold);
            this.txt_Documento.DefaultText = "";
            this.txt_Documento.FillColor = System.Drawing.Color.White;
            this.txt_Documento.ForeColor = System.Drawing.Color.Gray;
            this.txt_Documento.HideSelection = true;
            this.txt_Documento.IconLeft = null;
            this.txt_Documento.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Documento.IconPadding = 10;
            this.txt_Documento.IconRight = null;
            this.txt_Documento.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Documento.Lines = new string[0];
            this.txt_Documento.Location = new System.Drawing.Point(10, 387);
            this.txt_Documento.MaxLength = 32767;
            this.txt_Documento.MinimumSize = new System.Drawing.Size(100, 35);
            this.txt_Documento.Modified = false;
            this.txt_Documento.Multiline = false;
            this.txt_Documento.Name = "txt_Documento";
            stateProperties13.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(28)))));
            stateProperties13.FillColor = System.Drawing.Color.Empty;
            stateProperties13.ForeColor = System.Drawing.Color.Empty;
            stateProperties13.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_Documento.OnActiveState = stateProperties13;
            stateProperties14.BorderColor = System.Drawing.Color.Empty;
            stateProperties14.FillColor = System.Drawing.Color.White;
            stateProperties14.ForeColor = System.Drawing.Color.Empty;
            stateProperties14.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txt_Documento.OnDisabledState = stateProperties14;
            stateProperties15.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(173)))), ((int)(((byte)(5)))));
            stateProperties15.FillColor = System.Drawing.Color.Empty;
            stateProperties15.ForeColor = System.Drawing.Color.Empty;
            stateProperties15.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_Documento.OnHoverState = stateProperties15;
            stateProperties16.BorderColor = System.Drawing.Color.Silver;
            stateProperties16.FillColor = System.Drawing.Color.White;
            stateProperties16.ForeColor = System.Drawing.Color.Gray;
            stateProperties16.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_Documento.OnIdleState = stateProperties16;
            this.txt_Documento.PasswordChar = '\0';
            this.txt_Documento.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txt_Documento.PlaceholderText = "Documento";
            this.txt_Documento.ReadOnly = false;
            this.txt_Documento.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_Documento.SelectedText = "";
            this.txt_Documento.SelectionLength = 0;
            this.txt_Documento.SelectionStart = 0;
            this.txt_Documento.ShortcutsEnabled = true;
            this.txt_Documento.Size = new System.Drawing.Size(175, 38);
            this.txt_Documento.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.txt_Documento.TabIndex = 197;
            this.txt_Documento.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_Documento.TextMarginBottom = 0;
            this.txt_Documento.TextMarginLeft = 5;
            this.txt_Documento.TextMarginTop = 0;
            this.txt_Documento.TextPlaceholder = "Documento";
            this.txt_Documento.UseSystemPasswordChar = false;
            this.txt_Documento.WordWrap = true;
            this.txt_Documento.TextChanged += new System.EventHandler(this.txt_Documento_TextChanged);
            this.txt_Documento.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Documento_KeyDown);
            this.txt_Documento.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txt_Documento_MouseDown);
            this.txt_Documento.Validated += new System.EventHandler(this.txt_Documento_Validated);
            // 
            // cbx_Solicitante
            // 
            this.cbx_Solicitante.BackColor = System.Drawing.Color.Transparent;
            this.cbx_Solicitante.BorderColor = System.Drawing.Color.Silver;
            this.cbx_Solicitante.BorderRadius = 4;
            this.cbx_Solicitante.BorderThickness = 2;
            this.cbx_Solicitante.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbx_Solicitante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_Solicitante.Enabled = false;
            this.cbx_Solicitante.FocusedColor = System.Drawing.Color.Empty;
            this.cbx_Solicitante.FocusedState.Parent = this.cbx_Solicitante;
            this.cbx_Solicitante.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Bold);
            this.cbx_Solicitante.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(115)))), ((int)(((byte)(35)))));
            this.cbx_Solicitante.FormattingEnabled = true;
            this.cbx_Solicitante.HoverState.Parent = this.cbx_Solicitante;
            this.cbx_Solicitante.ItemHeight = 30;
            this.cbx_Solicitante.ItemsAppearance.Parent = this.cbx_Solicitante;
            this.cbx_Solicitante.Location = new System.Drawing.Point(8, 261);
            this.cbx_Solicitante.Name = "cbx_Solicitante";
            this.cbx_Solicitante.ShadowDecoration.Parent = this.cbx_Solicitante;
            this.cbx_Solicitante.Size = new System.Drawing.Size(175, 36);
            this.cbx_Solicitante.TabIndex = 16;
            this.cbx_Solicitante.Visible = false;
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Bold);
            this.bunifuLabel1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bunifuLabel1.Location = new System.Drawing.Point(12, 35);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(166, 41);
            this.bunifuLabel1.TabIndex = 3;
            this.bunifuLabel1.Text = "Reporte de Inventario\r\npor rango de Fechas";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // DataSet2
            // 
            this.DataSet2.DataSetName = "DataSet2";
            this.DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 527);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.bunifuShadowPanel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TUsuariosBindingSource)).EndInit();
            this.bunifuShadowPanel1.ResumeLayout(false);
            this.bunifuShadowPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button Btn_report;
        private Guna.UI2.WinForms.Guna2DateTimePicker txt_Fdevol;
        private Guna.UI2.WinForms.Guna2DateTimePicker txt_Fprest;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource DataTable1BindingSource;
        private DataSet1 DataSet1;
        private Bunifu.UI.WinForms.BunifuShadowPanel bunifuShadowPanel1;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Guna.UI2.WinForms.Guna2ComboBox cbx_Solicitante;
        private System.Windows.Forms.BindingSource DataTable2BindingSource;
        private DataSet2 DataSet2;
        private System.Windows.Forms.BindingSource TUsuariosBindingSource;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txt_Documento;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txt_contraseña;
    }
}