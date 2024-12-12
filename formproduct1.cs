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

namespace SOFTWARE_INVENTARIO.FORMULARIOS_SEGUNDARIOS
{
    public partial class formproduct1 : Form
    {
        public formproduct1()
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

        [DllImport("user32.Dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.Dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void formproduct1_Load(object sender, EventArgs e)
        {
            this.Opacity = 0.0;
            circularProgressBar1.Value = 0;
            circularProgressBar1.Minimum = 0;
            circularProgressBar1.Maximum = 100;
            timer1.Start();

            guna2ShadowForm1.SetShadowForm(this);
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

        private void MostrarDatos()
        {
            Conn.ConsultaDatos("Select * From TPRODUCTO Order By IdProducto", "TPRODUCTO");

            Conn.ConsultaDatosDM("Select (IdCategoria+'  |  '+LTrim(RTrim(Nombre))) As Nombre From TCATEGORIA Order By Nombre", "TCATEGORIA");
            cbx_Categoria.DataSource = Conn.DsDM.Tables["TCATEGORIA"];
            cbx_Categoria.DisplayMember = "Nombre";
        }

        private void CargarDatos(int Pos)
        {
            if ((Conn.Ds.Tables[0].Rows.Count) < 1) // dt.Rows.Count < 1) //Controlar si hay registros en la TABLA
            {
                //EstadoBton(false); //Procedimientos que desactiva todos los Botones porque ActDes = False
                //button1.Enabled = true; // Activa el Boton 1 Nuevo
                //Btn_Cerrar.Text = "Salir"; 
                //Opc = "1"; ActDesObjetos(false); Opc = "0";
                return; //Sale del procedimiento y no ejecuta el resto de los pasos.
            }
            fila = Conn.Ds.Tables[0].Rows[Pos];//Guarda el Registro (pos) en la variable "fila"
            txt_Codigo.Text = Convert.ToString(fila["IdProducto"]).Trim(); // Carga los datos del Campo al textBox 
            cbx_Categoria.Text = Convert.ToString(fila["IdCategoria"]).Trim(); // Carga los datos del Campo al textBox 
            txt_Nombre.Text = Convert.ToString(fila["NOMBRE_ELEMENTO"]).Trim(); // Carga los datos del Campo al textBox 
            txt_Cantidad.Text = Convert.ToString(fila["CANTIDAD"]).Trim(); // Carga los datos del Campo al textBox 
            txt_Descripcion.Text = Convert.ToString(fila["DESCRIPCION_P"]).Trim(); // Carga los datos del Campo al textBox 
            txt_fecha.Text = Convert.ToString(fila["FECHA"]).Trim(); // Carga los datos del Campo al textBox 
            txt_Estado.Text = Convert.ToString(fila["Estado"]).Trim(); // Carga los datos del Campo al textBox 
            txt_Elemento.Text = Convert.ToString(fila["ELEMENTO"]).Trim(); // Carga los datos del Campo al textBox 




            //cbx_genero.SelectedIndex = cbx_genero.FindString(((string)fila["IdGenero"]).Substring(0, 2));
            cbx_Categoria.SelectedIndex = cbx_Categoria.FindString(((string)fila["IdCategoria"]).Substring(0, 3));
            //cbx_Ciudad.SelectedIndex = cbx_Ciudad.FindString(((string)fila["IdLugar"]).Substring(0, 5));
            //cbx_RolUser.SelectedIndex = cbx_RolUser.FindString(((string)fila["IdPerfil"]).Substring(0, 2));

            //txt_Usuario.Text = Convert.ToString(fila["NomUser"]).Trim();
            //txt_clave.Text = Convert.ToString(fila["ClaUser"]).Trim();

            //CORREGIR

        }

        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            int cantdad = int.Parse(txt_Cantidad.Text);
            if (Opc == "1")
            {
                string fechapres = txt_fecha.Value.ToString("yyyy/MM/dd");
                string Agregar = "Insert Into TPRODUCTO SELECT '"  //(IdCliente,Nombres,Apellidos,Direccion,Correo,Telefono,IdLugar,IdPerfil,NomUser,Clave,Foto,Huella)
                + txt_Codigo.Text.Trim() + "','"
                + cbx_Categoria.Text.Substring(0, 3) + "','"
                + txt_Nombre.Text.Trim() + "','"
                + int.Parse(txt_Cantidad.Text.Trim()) + "','"
                + txt_Descripcion.Text.Trim() + "','"
                + fechapres.Trim() + "','"
                + txt_Estado.Text.Trim() + "'"; 

                if (Conn.Insertar(Agregar))
                { MessageBox.Show("Agregando Registro"); MostrarDatos(); Pos = Conn.Ds.Tables[0].Rows.Count - 1; }
                else { MessageBox.Show("Error al Agregar Registro"); }

                //txt_Codigo.Enabled = false;
                //cbx_Categoria.Enabled = false;
                //txt_Nombre.Enabled = false;
                //txt_Cantidad.Enabled = false;
                //txt_Descripcion.Enabled = false;
                //txt_fecha.Enabled = false;
                //txt_Elemento.Enabled = false;
                //txt_Estado.Enabled = false;
            }
        }


    }
}
