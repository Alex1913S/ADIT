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

namespace SOFTWARE_INVENTARIO
{
    public partial class FormSystemUser : Form
    {
        public FormSystemUser()
        {
            InitializeComponent();
        }
        COMPLEMENTO ONTEnter = new COMPLEMENTO(); //Carga la clase complementos con el nombre ONTEnter
        CONEXION_DB Conn = new CONEXION_DB();
        int Pos = 0; //Define variable tipo entero llamada pos e inicializada en cero tipo publico
        string Opc = "0"; //Define que operación se va a trabajar Nuevo, Editar.. --> tipo texto
        DataRow fila;
        string ValNomUser = string.Empty; //Valida el Nombre del Usuario al Editar
        string ValDocUser = string.Empty; //Valida el Documento del Usuario al Editar
        //-----------------------------------------------------------------------------------------------------------
        [DllImport("user32.Dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.Dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void FormSystemUser_Load(object sender, EventArgs e)
        {
            this.Opacity = 0.0;
            circularProgressBar1.Value = 0;
            circularProgressBar1.Minimum = 0;
            circularProgressBar1.Maximum = 100;
            timer1.Start();

            ActDesObjetos(false);
            MostrarDatos();
            Btn_Guardar.Enabled = false;
            //guna2ShadowForm1.SetShadowForm(this);

            txt_Codigo.Enabled = false;
            txt_Documento.Enabled = false;
            txt_Nombre.Enabled = false;
            txt_Apellido.Enabled = false;
            txt_Correo.Enabled = false;
            txt_telefono.Enabled = false;
            txt_direccion.Enabled = false;
            txt_Usuario.Enabled = false;
            txt_clave.Enabled = false;
        }

        private void ActDesObjetos(Boolean ActDes)
        {
            foreach (Control TBox in this.groupBox1.Controls) //Recorre todos los Objetos
            {
                if (TBox is TextBox || TBox is ComboBox) //Tipo TextBox y ComboBox
                {
                    if (Opc == "0") //Ejecuta el procedimiento por primera y solo una vez -- Compara si es igual a Cero para ejecutarlo...
                    {
                        TBox.KeyDown += new KeyEventHandler(COMPLEMENTO.PCEnter); //Para con Enter cada Objeto
                        TBox.GotFocus += new EventHandler(COMPLEMENTO.Recibefoco); //Cambiar el Color del objeto
                        TBox.LostFocus += new EventHandler(COMPLEMENTO.Pierdefoco); //Volver al color inicial del Objeto
                    }
                    TBox.Enabled = ActDes; //Deshabilita todos los Objetos TextBox y ComboBox
                    if (Opc == "1" && TBox.TabIndex > 0) { TBox.Text = string.Empty; }
                }
            }
        }

        private void CargarDatos(int Pos)
        {
            if ((Conn.Ds.Tables[0].Rows.Count) < 1) // dt.Rows.Count < 1) //Controlar si hay registros en la TABLA
            {
                //EstadoBton(false); //Procedimientos que desactiva todos los Botones porque ActDes = False
                //button1.Enabled = true; // Activa el Boton 1 Nuevo
                Btn_Salir.Text = "Salir"; //
                //Opc = "1"; ActDesObjetos(false); Opc = "0";
                return; //Sale del procedimiento y no ejecuta el resto de los pasos.
            }
            fila = Conn.Ds.Tables[0].Rows[Pos];//Guarda el Registro (pos) en la variable "fila"
            txt_Codigo.Text =        Convert.ToString(fila["IdUsuario"]); // Carga los datos del Campo al textBox 
            txt_Documento.Text = Convert.ToString(fila["Documento"]); // Carga los datos del Campo al textBox 
            txt_Nombre.Text =       Convert.ToString(fila["Nombre"]); // Carga los datos del Campo al textBox 
            txt_Apellido.Text =       Convert.ToString(fila["Apellido"]); // Carga los datos del Campo al textBox 
            txt_direccion.Text =      Convert.ToString(fila["Direccion"]); // Carga los datos del Campo al textBox 
            txt_telefono.Text =       Convert.ToString(fila["Telefono"]); // Carga los datos del Campo al textBox 
            txt_Correo.Text =         Convert.ToString(fila["Correo"]); // Carga los datos del Campo al textBox 

            cbx_departamento.SelectedIndex = cbx_departamento.FindString(((string)fila["IdLugar"]).Substring(0, 2));
            cbx_Ciudad.SelectedIndex = cbx_Ciudad.FindString(((string)fila["IdLugar"]).Substring(0, 5));
            cbx_RolUser.SelectedIndex = cbx_RolUser.FindString(((string)fila["IdPerfil"]).Substring(0, 2));

            txt_Usuario.Text = Convert.ToString(fila["NomUser"]).Trim();
            txt_clave.Text =     Convert.ToString(fila["ClaUser"]).Trim();

            //CORREGIR
            try
            {
                byte[] PicF = (byte[])fila["Foto"];
                System.IO.MemoryStream CargarFoto = new System.IO.MemoryStream(PicF);
                PBox1.Image = System.Drawing.Bitmap.FromStream(CargarFoto); // Image.FromStream(CargarFoto);

            }
            catch (Exception m) { }

        }

        private void MostrarDatos()
        {
            Conn.ConsultaDatos("Select * From TUsuarios Order By Nombre", "TUsuarios");
            dataGridView1.DataSource = Conn.Ds.Tables["TUsuarios"];
            dataGridView1.Enabled = true;

            Conn.ConsultaDatosDM("Select (IdDpto+' | '+LTrim(RTrim(Nombre))) As Nombre From TDpto Order By Nombre", "TDpto");
            cbx_departamento.DataSource = Conn.DsDM.Tables["TDpto"];
            cbx_departamento.DisplayMember = "Nombre";

            Conn.ConsultaDatosDM("Select (IdLugar+' | '+LTrim(RTrim(Nombre))) As Nombre From TMpio Order By Nombre", "TMpio");
            cbx_Ciudad.DataSource = Conn.DsDM.Tables["TMpio"];
            cbx_Ciudad.DisplayMember = "Nombre";

            Conn.ConsultaDatosDM("Select (IdPerfil+' | '+LTrim(RTrim(Nombre))) As Nombre From TPerfilUser Order By Nombre", "TPerfilUser");
            cbx_RolUser.DataSource = Conn.DsDM.Tables["TPerfilUser"];
            cbx_RolUser.DisplayMember = "Nombre";

            Conn.ConsultaDatosDM("Select (IdGenero+' | '+LTrim(RTrim(Nombre))) As Nombre From Genero Order By Nombre", "Genero");
            cbx_genero.DataSource = Conn.DsDM.Tables["Genero"];
            cbx_genero.DisplayMember = "Nombre";

            if (Opc == "0") //Ejecuta el procedimiento por primera y solo una vez -- Compara si es igual a Cero para ejecutarlo...
            { CargarDatos(Pos); } // Procedimiento que Carga en los TextBox los Datos segun el registro Pos
            dataGridView1.Enabled = true;
            CargarDatos(Pos);  // Procedimiento que Carga en los TextBox los Datos segun el registro Pos

            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Width = 131;
            dataGridView1.Columns[2].Width = 131;
            dataGridView1.Columns[3].Width = 131;
            dataGridView1.Columns[4].Width = 350;
            dataGridView1.Columns[5].Width = 131;
            dataGridView1.Columns[6].Width = 250;
            dataGridView1.Columns[7].Width = 109;
            dataGridView1.Columns[8].Width = 109;
            dataGridView1.Columns[9].Width = 109;
            dataGridView1.Columns[10].Width = 109;
            dataGridView1.Columns[11].Width = 109;
            dataGridView1.Columns[12].Width = 109;
            dataGridView1.Columns[13].Width = 109;
            dataGridView1.Columns[14].Visible = false;


            dataGridView1.Columns["IdUsuario"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridView1.Columns["Documento"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridView1.Columns["Nombre"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridView1.Columns["Apellido"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridView1.Columns["Direccion"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridView1.Columns["Telefono"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridView1.Columns["Correo"].SortMode = DataGridViewColumnSortMode.NotSortable;

            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.MultiSelect = false;

            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1) this.Opacity += 0.1;
            circularProgressBar1.Value += 1;
            circularProgressBar1.Text = circularProgressBar1.Value.ToString();
            if (circularProgressBar1.Value == 100)
            {
                timer1.Stop();
            }
        }
    }
}
