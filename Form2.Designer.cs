
namespace SOFTWARE_INVENTARIO
{
    partial class Form2
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            this.TPRODUCTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet1 = new SOFTWARE_INVENTARIO.DataSet1();
            this.TUsuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataTable2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.bunifuShadowPanel1 = new Bunifu.UI.WinForms.BunifuShadowPanel();
            this.cbx_Categoria = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txt_contraseña = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.txt_Documento = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.Btn_report = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.TPRODUCTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TUsuariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable2BindingSource)).BeginInit();
            this.bunifuShadowPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TPRODUCTOBindingSource
            // 
            this.TPRODUCTOBindingSource.DataMember = "TPRODUCTO";
            this.TPRODUCTOBindingSource.DataSource = this.DataSet1;
            // 
            // DataSet1
            // 
            this.DataSet1.DataSetName = "DataSet1";
            this.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TUsuariosBindingSource
            // 
            this.TUsuariosBindingSource.DataMember = "TUsuarios";
            this.TUsuariosBindingSource.DataSource = this.DataSet1;
            // 
            // DataTable2BindingSource
            // 
            this.DataTable2BindingSource.DataMember = "DataTable2";
            this.DataTable2BindingSource.DataSource = this.DataSet1;
            // 
            // reportViewer1
            // 
            this.reportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Left;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.TPRODUCTOBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.TUsuariosBindingSource;
            reportDataSource3.Name = "DataSet3";
            reportDataSource3.Value = this.DataTable2BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SOFTWARE_INVENTARIO.Report3.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(269, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 527);
            this.reportViewer1.TabIndex = 3;
            // 
            // bunifuShadowPanel1
            // 
            this.bunifuShadowPanel1.BackColor = System.Drawing.Color.White;
            this.bunifuShadowPanel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(223)))), ((int)(((byte)(5)))));
            this.bunifuShadowPanel1.BorderRadius = 15;
            this.bunifuShadowPanel1.BorderThickness = 1;
            this.bunifuShadowPanel1.Controls.Add(this.cbx_Categoria);
            this.bunifuShadowPanel1.Controls.Add(this.txt_contraseña);
            this.bunifuShadowPanel1.Controls.Add(this.txt_Documento);
            this.bunifuShadowPanel1.Controls.Add(this.bunifuLabel1);
            this.bunifuShadowPanel1.Controls.Add(this.Btn_report);
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
            this.bunifuShadowPanel1.Size = new System.Drawing.Size(269, 527);
            this.bunifuShadowPanel1.Style = Bunifu.UI.WinForms.BunifuShadowPanel.BevelStyles.Flat;
            this.bunifuShadowPanel1.TabIndex = 4;
            // 
            // cbx_Categoria
            // 
            this.cbx_Categoria.BackColor = System.Drawing.Color.Transparent;
            this.cbx_Categoria.BorderColor = System.Drawing.Color.Silver;
            this.cbx_Categoria.BorderRadius = 4;
            this.cbx_Categoria.BorderThickness = 2;
            this.cbx_Categoria.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbx_Categoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_Categoria.FocusedColor = System.Drawing.Color.Empty;
            this.cbx_Categoria.FocusedState.Parent = this.cbx_Categoria;
            this.cbx_Categoria.Font = new System.Drawing.Font("Microsoft JhengHei UI", 11F, System.Drawing.FontStyle.Bold);
            this.cbx_Categoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cbx_Categoria.FormattingEnabled = true;
            this.cbx_Categoria.HoverState.Parent = this.cbx_Categoria;
            this.cbx_Categoria.ItemHeight = 30;
            this.cbx_Categoria.ItemsAppearance.Parent = this.cbx_Categoria;
            this.cbx_Categoria.Location = new System.Drawing.Point(9, 91);
            this.cbx_Categoria.Name = "cbx_Categoria";
            this.cbx_Categoria.ShadowDecoration.Parent = this.cbx_Categoria;
            this.cbx_Categoria.Size = new System.Drawing.Size(251, 36);
            this.cbx_Categoria.TabIndex = 199;
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
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(28)))));
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_contraseña.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.Empty;
            stateProperties2.FillColor = System.Drawing.Color.White;
            stateProperties2.ForeColor = System.Drawing.Color.Empty;
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txt_contraseña.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(173)))), ((int)(((byte)(5)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_contraseña.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Gray;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_contraseña.OnIdleState = stateProperties4;
            this.txt_contraseña.PasswordChar = '●';
            this.txt_contraseña.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txt_contraseña.PlaceholderText = "";
            this.txt_contraseña.ReadOnly = false;
            this.txt_contraseña.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_contraseña.SelectedText = "";
            this.txt_contraseña.SelectionLength = 0;
            this.txt_contraseña.SelectionStart = 0;
            this.txt_contraseña.ShortcutsEnabled = true;
            this.txt_contraseña.Size = new System.Drawing.Size(252, 38);
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
            stateProperties5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(28)))));
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_Documento.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.Empty;
            stateProperties6.FillColor = System.Drawing.Color.White;
            stateProperties6.ForeColor = System.Drawing.Color.Empty;
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txt_Documento.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(173)))), ((int)(((byte)(5)))));
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_Documento.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.Silver;
            stateProperties8.FillColor = System.Drawing.Color.White;
            stateProperties8.ForeColor = System.Drawing.Color.Gray;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_Documento.OnIdleState = stateProperties8;
            this.txt_Documento.PasswordChar = '\0';
            this.txt_Documento.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txt_Documento.PlaceholderText = "Documento";
            this.txt_Documento.ReadOnly = false;
            this.txt_Documento.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_Documento.SelectedText = "";
            this.txt_Documento.SelectionLength = 0;
            this.txt_Documento.SelectionStart = 0;
            this.txt_Documento.ShortcutsEnabled = true;
            this.txt_Documento.Size = new System.Drawing.Size(250, 38);
            this.txt_Documento.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.txt_Documento.TabIndex = 197;
            this.txt_Documento.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_Documento.TextMarginBottom = 0;
            this.txt_Documento.TextMarginLeft = 5;
            this.txt_Documento.TextMarginTop = 0;
            this.txt_Documento.TextPlaceholder = "Documento";
            this.txt_Documento.UseSystemPasswordChar = false;
            this.txt_Documento.WordWrap = true;
            this.txt_Documento.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Documento_KeyDown);
            this.txt_Documento.Validated += new System.EventHandler(this.txt_Documento_Validated);
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Bold);
            this.bunifuLabel1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bunifuLabel1.Location = new System.Drawing.Point(51, 35);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(166, 41);
            this.bunifuLabel1.TabIndex = 3;
            this.bunifuLabel1.Text = "Reporte de Inventario\r\npor Categorías";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
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
            this.Btn_report.Location = new System.Drawing.Point(49, 475);
            this.Btn_report.Name = "Btn_report";
            this.Btn_report.ShadowDecoration.Parent = this.Btn_report;
            this.Btn_report.Size = new System.Drawing.Size(171, 41);
            this.Btn_report.TabIndex = 1;
            this.Btn_report.Text = "Generar Reporte";
            this.Btn_report.Click += new System.EventHandler(this.Btn_report_Click);
            // 
            // TPRODUCTOTableAdapter
            // 
            //this.TPRODUCTOTableAdapter.ClearBeforeFill = true;
            // 
            // TUsuariosTableAdapter
            // 
            //this.TUsuariosTableAdapter.ClearBeforeFill = true;
            // 
            // DataTable2TableAdapter
            // 
            //this.DataTable2TableAdapter.ClearBeforeFill = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 527);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.bunifuShadowPanel1);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TPRODUCTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TUsuariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable2BindingSource)).EndInit();
            this.bunifuShadowPanel1.ResumeLayout(false);
            this.bunifuShadowPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Bunifu.UI.WinForms.BunifuShadowPanel bunifuShadowPanel1;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txt_contraseña;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txt_Documento;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Guna.UI2.WinForms.Guna2Button Btn_report;
        private System.Windows.Forms.BindingSource TPRODUCTOBindingSource;
        private DataSet1 DataSet1;
        private System.Windows.Forms.BindingSource TUsuariosBindingSource;
        private System.Windows.Forms.BindingSource DataTable2BindingSource;
        private Guna.UI2.WinForms.Guna2ComboBox cbx_Categoria;
    }
}