using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SOFTWARE_INVENTARIO
{
    public partial class FormReportes : Form
    {
        public FormReportes()
        {
            InitializeComponent();
        }

        private void Btn_report_Click(object sender, EventArgs e)
        {
            Form1 frminvetg = new Form1();
            frminvetg.Show();
        }

        private void FormReportes_Load(object sender, EventArgs e)
        {
            guna2ShadowForm1.SetShadowForm(this);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Form2 frminvetg2 = new Form2();
            frminvetg2.Show();
        }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            DialogResult Rta = MessageBox.Show("¿Está seguro de salir de Productos?", "PRODUCTOS", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
            if (Rta == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esta opción se encuentra pendiente para una próxima actualización.");
        }
    }
}
