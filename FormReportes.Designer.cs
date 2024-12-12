
namespace SOFTWARE_INVENTARIO
{
    partial class FormReportes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReportes));
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.Btn_report = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.Btn_Salir = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuLabel1.Location = new System.Drawing.Point(16, 85);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(484, 22);
            this.bunifuLabel1.TabIndex = 0;
            this.bunifuLabel1.Text = "REPORTE DE INVENTARIO DE PRODUCTOS Y SOLICITANTES";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // Btn_report
            // 
            this.Btn_report.BorderRadius = 8;
            this.Btn_report.CheckedState.Parent = this.Btn_report;
            this.Btn_report.CustomImages.Parent = this.Btn_report;
            this.Btn_report.FillColor = System.Drawing.Color.White;
            this.Btn_report.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_report.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(115)))), ((int)(((byte)(35)))));
            this.Btn_report.HoverState.Parent = this.Btn_report;
            this.Btn_report.Location = new System.Drawing.Point(97, 145);
            this.Btn_report.Name = "Btn_report";
            this.Btn_report.ShadowDecoration.Parent = this.Btn_report;
            this.Btn_report.Size = new System.Drawing.Size(322, 41);
            this.Btn_report.TabIndex = 3;
            this.Btn_report.Text = "Reporte por rango de fechas de productos";
            this.Btn_report.Visible = false;
            this.Btn_report.Click += new System.EventHandler(this.Btn_report_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 8;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.White;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(115)))), ((int)(((byte)(35)))));
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(97, 208);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(322, 41);
            this.guna2Button1.TabIndex = 4;
            this.guna2Button1.Text = "Reporte por Categoría de productos";
            this.guna2Button1.Visible = false;
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // Btn_Salir
            // 
            this.Btn_Salir.BackgroundImage = global::SOFTWARE_INVENTARIO.Properties.Resources.cerrar_Mesa_de_trabajo_1;
            this.Btn_Salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_Salir.BorderColor = System.Drawing.Color.Transparent;
            this.Btn_Salir.BorderRadius = 6;
            this.Btn_Salir.CheckedState.Parent = this.Btn_Salir;
            this.Btn_Salir.CustomImages.Parent = this.Btn_Salir;
            this.Btn_Salir.FillColor = System.Drawing.Color.Transparent;
            this.Btn_Salir.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Btn_Salir.ForeColor = System.Drawing.Color.White;
            this.Btn_Salir.HoverState.Parent = this.Btn_Salir;
            this.Btn_Salir.Location = new System.Drawing.Point(479, 12);
            this.Btn_Salir.Name = "Btn_Salir";
            this.Btn_Salir.PressedColor = System.Drawing.Color.White;
            this.Btn_Salir.ShadowDecoration.Parent = this.Btn_Salir;
            this.Btn_Salir.Size = new System.Drawing.Size(25, 25);
            this.Btn_Salir.TabIndex = 12;
            this.Btn_Salir.Click += new System.EventHandler(this.Btn_Salir_Click);
            // 
            // guna2Button2
            // 
            this.guna2Button2.BorderRadius = 8;
            this.guna2Button2.CheckedState.Parent = this.guna2Button2;
            this.guna2Button2.CustomImages.Parent = this.guna2Button2;
            this.guna2Button2.FillColor = System.Drawing.Color.White;
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(115)))), ((int)(((byte)(35)))));
            this.guna2Button2.HoverState.Parent = this.guna2Button2;
            this.guna2Button2.Location = new System.Drawing.Point(97, 269);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.ShadowDecoration.Parent = this.guna2Button2;
            this.guna2Button2.Size = new System.Drawing.Size(322, 41);
            this.guna2Button2.TabIndex = 13;
            this.guna2Button2.Text = "Reporte diario de solicitante";
            this.guna2Button2.Visible = false;
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // FormReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(223)))), ((int)(((byte)(5)))));
            this.ClientSize = new System.Drawing.Size(516, 450);
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.Btn_Salir);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.Btn_report);
            this.Controls.Add(this.bunifuLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormReportes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormReportes";
            this.Load += new System.EventHandler(this.FormReportes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Guna.UI2.WinForms.Guna2Button Btn_report;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private Guna.UI2.WinForms.Guna2Button Btn_Salir;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
    }
}