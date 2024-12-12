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
using System.Runtime.InteropServices;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using System.IO;

namespace SOFTWARE_INVENTARIO
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            txt_contraseña.Enabled = false;
            Btn_report.Enabled = true;
            //MostrarDatos();
        }


        CONEXION_DB Conn = new CONEXION_DB();
        /*private void MostrarDatos()
        {
            Conn.ConsultaDatosDM("select CodPers FROM TUsuarios order by Idpersona", "TUsuarios");
            cbx_Solicitante.DataSource = Conn.DsDM.Tables["TUsuarios"];
            cbx_Solicitante.DisplayMember = "CodPers";
        }*/

        private void Btn_report_Click(object sender, EventArgs e)
        {
           // string fechapres = txt_Fprest.Value.ToString("yyyy/MM/dd");
           // string fechadevol = txt_Fdevol.Value.ToString("yyyy/MM/dd");
           // string var1 = txt_Documento.Text.Trim();
           // string var2 = txt_contraseña.Text.Trim();
            // TODO: esta línea de código carga datos en la tabla 'DataSet1.DataTable1' Puede moverla o quitarla según sea necesario.
            //this.DataTable1TableAdapter.Fill(this.DataSet1.DataTable1,fechapres,fechadevol);
            // TODO: esta línea de código carga datos en la tabla 'DataSet1.DataTable2' Puede moverla o quitarla según sea necesario.
            //this.DataTable2TableAdapter.Fill(this.DataSet1.DataTable2,var1);
            // TODO: esta línea de código carga datos en la tabla 'DataSet1.DataTable1' Puede moverla o quitarla según sea necesario
            //this.TUsuariosTableAdapter.Fill(this.DataSet1.TUsuarios,var1,var2);
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void txt_Documento_Validated(object sender, EventArgs e)
        {
            if (txt_Documento.Text == string.Empty)
            {
                MessageBox.Show("Si no Digita su número de cedula no podrá generar este reporte");
                Btn_report.Enabled = false;
            }
            else
            {
                txt_contraseña.Enabled = true;
                txt_contraseña.Focus();
                Btn_report.Enabled = false;
            }

        }

        private void txt_contraseña_Validated(object sender, EventArgs e)
        {
            if (txt_Documento.Text != string.Empty && txt_contraseña.Text != string.Empty)
            {
                Btn_report.Enabled = true;
            }

        }

        private void txt_Documento_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void txt_Documento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txt_Documento.Text == string.Empty)
                {
                    MessageBox.Show("Si no Digita su número de cedula no podrá generar este reporte");
                    Btn_report.Enabled = false;
                }
                else
                {
                    txt_contraseña.Enabled = true;
                    txt_contraseña.Focus();
                    Btn_report.Enabled = false;
                }
            }
        }

        private void txt_contraseña_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txt_Documento.Text != string.Empty && txt_contraseña.Text != string.Empty)
                {
                    Btn_report.Enabled = true;
                    Btn_report.Focus();
                }
            }
        }

        private void txt_Documento_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
