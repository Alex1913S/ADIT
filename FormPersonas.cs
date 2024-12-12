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
    public partial class FormPersonas : Form
    {
        public FormPersonas()
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
        private void FormPersonas_Load(object sender, EventArgs e)
        {
            ActDesObjetos(false);
            MostrarDatos();
            Btn_Guardar.Enabled = false;
            guna2ShadowForm1.SetShadowForm(this);


            txt_Codigo.Enabled = false;
            txt_Nombre.Enabled = false;
            txt_Apellido.Enabled = false;
            txt_Direccion.Enabled = false;
            txt_Telefono.Enabled = false;
            txt_Correo.Enabled = false;
            cbx_Cargo.Enabled = false;
            txt_codper.Enabled = false;
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

            groupBox1.Enabled = true;
            groupBox1.Visible = true;
        }

        private void MostrarDatos()
        {
            Conn.ConsultaDatos("Select * From TPERSONA Order By IdPersona", "TPERSONA");
            dataGridView1.DataSource = Conn.Ds.Tables["TPERSONA"];
            dataGridView1.Enabled = true;

            Conn.ConsultaDatosDM("Select (IdCargoPna+' | '+LTrim(RTrim(NombreC))) As Nombre From TCARGOPNA Order By IdCargoPna", "TCARGOPNA");
            cbx_Cargo.DataSource = Conn.DsDM.Tables["TCARGOPNA"];
            cbx_Cargo.DisplayMember = "Nombre";

            //Conn.ConsultaDatosDM("Select (IdCargoPna+' | '+LTrim(RTrim(Nombre))) As Nombre From TCargoPna Order By Nombre", "TCargoPna");
            //cbx_Cargo.DataSource = Conn.DsDM.Tables["TCargoPna"];
            //cbx_Cargo.DisplayMember = "Nombre";


            if (Opc == "0") //Ejecuta el procedimiento por primera y solo una vez -- Compara si es igual a Cero para ejecutarlo...
            { CargarDatos(Pos); } // Procedimiento que Carga en los TextBox los Datos segun el registro Pos
            dataGridView1.Enabled = true;
            CargarDatos(Pos);  // Procedimiento que Carga en los TextBox los Datos segun el registro Pos

            dataGridView1.Columns[0].Width = 131;
            dataGridView1.Columns[1].Width = 131;
            dataGridView1.Columns[2].Width = 131;
            dataGridView1.Columns[3].Width = 131;
            dataGridView1.Columns[4].Width = 250;
            dataGridView1.Columns[5].Width = 131;
            dataGridView1.Columns[6].Width = 250;
            dataGridView1.Columns[7].Width = 109;
            dataGridView1.Columns[8].Visible = false;


            dataGridView1.Columns["IdPersona"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridView1.Columns["Nombre"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridView1.Columns["Apellido"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridView1.Columns["Direccion"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridView1.Columns["Telefono"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridView1.Columns["Correo"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridView1.Columns["Cargo"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridView1.Columns["CodPers"].SortMode = DataGridViewColumnSortMode.NotSortable;




            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.MultiSelect = false;

            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;

            //dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
        }

        private void CargarDatos(int Pos)
        {
            dataGridView1.ClearSelection();
            if ((Conn.Ds.Tables[0].Rows.Count) < 1) // dt.Rows.Count < 1) //Controlar si hay registros en la TABLA
            {
                EstadoBton(false); //Procedimientos que desactiva todos los Botones porque ActDes = False
                Pri.Enabled = true; // Activa el Boton 1 Nuevo
                //button7.Image = GanaSoft.Properties.Resources._2_8___Salir; //Cambia la Imagen del Boton 7 Salir
                Btn_Salir.Text = "Salir"; //
                //Opc = "1"; ActDesObjetos(false); Opc = "0";
                return; //Sale del procedimiento y no ejecuta el resto de los pasos.
            }
            fila = Conn.Ds.Tables[0].Rows[Pos];//Guarda el Registro (pos) en la variable "fila"
            txt_Codigo.Text =    Convert.ToString(fila["IdPersona"]).Trim(); // Carga los datos del Campo al textBox 
            txt_Nombre.Text =    Convert.ToString(fila["Nombre"]).Trim(); // Carga los datos del Campo al textBox 
            txt_Apellido.Text =  Convert.ToString(fila["Apellido"]).Trim(); // Carga los datos del Campo al textBox 
            txt_Direccion.Text = Convert.ToString(fila["Direccion"]).Trim(); // Carga los datos del Campo al textBox 
            txt_Telefono.Text =  Convert.ToString(fila["Telefono"]).Trim(); // Carga los datos del Campo al textBox 
            txt_Correo.Text =    Convert.ToString(fila["Correo"]).Trim(); // Carga los datos del Campo al textBox 
            cbx_Cargo.Text =     Convert.ToString(fila["Cargo"]).Trim(); // Carga los datos del Campo al textBox 
            txt_codper.Text =    Convert.ToString(fila["CodPers"]).Trim(); // Carga los datos del Campo al textBox 



            //cbx_Cargo.SelectedIndex = cbx_Cargo.FindString(((string)fila["IdCargoPna"]).Substring(0, 2));
            cbx_Cargo.SelectedIndex = cbx_Cargo.FindString(((string)fila["Cargo"]).Substring(0, 4));

            dataGridView1.Rows[Pos].Selected = true;//El Grid en la Fila con posición X "Seleccionela" (true/false)   
            dataGridView1.CurrentCell = dataGridView1.Rows[Pos].Cells[dataGridView1.CurrentCell.ColumnIndex];

            try
            {
                byte[] PicF = (byte[])fila["Foto"];
                System.IO.MemoryStream CargarFoto = new System.IO.MemoryStream(PicF);
                PBox1.Image = System.Drawing.Bitmap.FromStream(CargarFoto); // Image.FromStream(CargarFoto);

            }
            catch (Exception m) { }
        }


        private void EstadoBton(Boolean ActDes) //Procedimiento para Activar o Desactivar los Botones
        {
            Pri.Enabled = ActDes; //Activa o Desactiva el Boton
            Ult.Enabled = ActDes;
            Btn_Guardar.Enabled = ActDes;
            //button5.Enabled = ActDes;
            Btn_Eliminar.Enabled = ActDes;
            Pri.Enabled = ActDes;
            Pri.Enabled = ActDes;
            Ant.Enabled = ActDes;
            Sig.Enabled = ActDes;
            Ult.Enabled = ActDes;
            if (ActDes == false)
            { //Compara si la variable ActDes es igual a false
                //button7.Image = GanaSoft.Properties.Resources._2_7___Cerrar; //Cambia la Imagen si ActDes es Igual a falso
                Btn_Salir.Text = "Cerrar"; //Pone texto Cerrar en el boton
                toolTip1.SetToolTip(Btn_Salir, "Cerrar procedimiento");
            }
            else
            {
                //button7.Image = GanaSoft.Properties.Resources._2_8___Salir; //Cambia la Imagen si ActDes es Igual a true
                Btn_Salir.Text = "Salir";  //Pone texto Salir en el boton
                toolTip1.SetToolTip(Btn_Salir, "Cerrar / Salir del Formulario");
            }
        }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            DialogResult Rta = MessageBox.Show("¿Está seguro de salir?", "Saliendo el sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
            if (Rta == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void Txt_Buscar_KeyUp(object sender, KeyEventArgs e)
        {
            SqlConnection Conn = new SqlConnection("Data source=.\\; Initial Catalog=ControlEquipos; Integrated Security=true");
            Conn.Open();
            SqlCommand comando = Conn.CreateCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "SELECT * FROM TPERSONA where Nombre like '" + Txt_Buscar.Text + "%' Order by IdPersona";
            comando.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(comando);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            Conn.Close();
        }

        private void Btn_Nuevo_Click(object sender, EventArgs e)
        {
            Opc = "1"; //Identifica el Tipo de Operación Opc="1" --> Nuevo
            EstadoBton(false); //Ejecuta el procedimiento EstadoBton (Activar o Deshabilitar botones).. aca los activa por ser true.
            txt_Codigo.Enabled = true; //Habilita el textBox
            txt_Codigo.Text = string.Empty; //Limpia el TextBox con Vacio tipo texto
            txt_Codigo.Focus(); //Ubica el Cursor en el TextBox Seleccionado
            txt_Nombre.Enabled = true;
            Btn_Guardar.Enabled = true; //Habilita el boton
            groupBox1.Enabled = true;
            groupBox1.Visible = true;
        }
        private void ConverPic()
        {
            string RutaF = Application.StartupPath + "\\Recursos\\1-Fotos\\";
            try
            {
                if (Opc == "2" || PBox1.Image != null)
                {
                    PBox1.Image.Save(RutaF + txt_Nombre.Text.ToString() + ".png", System.Drawing.Imaging.ImageFormat.Png);
                    PBox1.Load(RutaF + txt_Nombre.Text.ToString() + ".png");
                }
                else { PBox1.Load(RutaF + "SinFoto.png"); }
            }
            catch { }
        }


        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (CONEXION_DB.VariablesGlobales.xEstIni == 0)
            {
                MessageBox.Show("Los Invitados no pueden Eliminar Usuarios");
            }
            else
            {
                //NOTIFICACION_EMERGENTE FrmEMERGENT1 = new NOTIFICACION_EMERGENTE(); //(ref instance);
                //FrmEMERGENT1.ShowDialog();
                //MessageBox.Show(CONEXION_DB.VariablesGlobales.xTipoU + "123");
                if (CONEXION_DB.VariablesGlobales.xTipoU == "ADMINISTRADOR")
                {
                    //NOTIFICACION_EMERGENTE FrmEMERGENT1 = new NOTIFICACION_EMERGENTE(); //(ref instance);
                    //FrmEMERGENT1.ShowDialog();

                    DialogResult resu = MessageBox.Show("Esta seguro de eliminar <" + txt_Codigo.Text +
                     "> de la Base de Datos?", "A D V E R T E N C I A", MessageBoxButtons.YesNo);
                    if (resu == DialogResult.Yes)
                        try
                        {
                            string reg = "IdPersona='" + txt_Codigo.Text.Trim() + "'";
                            Conn.Eliminar("TPERSONA", reg);
                            Pos += -1; int PosN = Pos;
                            if (PosN < 1) { PosN = 0; }
                            MostrarDatos();
                            CargarDatos(PosN);
                        }
                        catch (Exception m) { MessageBox.Show(m.Message); }
                    //NOTIFICACION_CONFIRMAR FrmEMERGENT = new NOTIFICACION_CONFIRMAR(); //(ref instance);
                    //FrmEMERGENT.ShowDialog();
                }
                else { MessageBox.Show("Solo los Administradores pueden Eliminar Usuarios"); }
            }
        }

        private void Btn_Actualizar_Click(object sender, EventArgs e)
        {
            Opc = "2";  //Identifica el Tipo de Operación Opc="2" --> Editar
            EstadoBton(false); // Habilitar los Objetos Botones
            Btn_Guardar.Enabled = true; //habilitar Boton Guardar
            ActDesObjetos(true); // Habilitar los Objetos Cuadros de Textos
            txt_Codigo.Enabled = false; //Deshabilita el cuadro de texto
            txt_Nombre.Focus(); //Ubica el curso en el Objeto
            groupBox1.Enabled = true;
        }

        private void Pri_Click(object sender, EventArgs e)
        {
            Pos = 0; //Inicializa Pos en Cero "este es el primer registro de la tabla
            CargarDatos(Pos); //Carga los datos Ubicados en la Posición Cero
            Pri.Enabled = false; Ant.Enabled = false;
            Sig.Enabled = true; Ult.Enabled = true;
        }

        private void Ult_Click(object sender, EventArgs e)
        {
            Pos = Conn.Ds.Tables[0].Rows.Count - 1; //Hacerlo en el DataGrid
            CargarDatos(Pos);
            Pri.Enabled = true; Ant.Enabled = true;
            Sig.Enabled = false; Ult.Enabled = false;
        }

        private void Ant_Click(object sender, EventArgs e)
        {
            Pos += -1; //Retrocede un registro --- Si es el primer registro ejecuta el procedimiento Pri_Click
            if (Pos < 1) { Pos = 0; Pri_Click(null, null); }
            else { CargarDatos(Pos); Sig.Enabled = true; Ult.Enabled = true; }
        }

        private void Sig_Click(object sender, EventArgs e)
        {
            Pos += 1;
            if (Pos >= (Conn.Ds.Tables[0].Rows.Count - 1)) { Ult_Click(null, null); }
            else { CargarDatos(Pos); Pri.Enabled = true; Ant.Enabled = true; }
        }

        private void txt_Codigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                if (txt_Codigo.Text == string.Empty) { txt_Codigo.Focus(); MessageBox.Show("Digite el número del Usuario"); }
                else
                {
                    
                    int BakPos = Pos; // Captura la posición Actual --- Cerrar sin guardar...
                    string reg = "IdPersona='" + txt_Codigo.Text.Trim() + "'";
                    if (Conn.ConsultaItem("TPERSONA", reg))
                    {
                        Conn.Ds.Tables[0].PrimaryKey = new DataColumn[] { Conn.Ds.Tables[0].Columns["IdPersona"] }; //Crea Indice el Tabla temporal dt
                        Pos = Conn.Ds.Tables[0].Rows.IndexOf(Conn.Ds.Tables[0].Rows.Find(txt_Codigo.Text.Trim()));
                        this.Btn_Salir_Click(null, null); CargarDatos(Pos);
                        MessageBox.Show("Usuario Existente en la Base de Datos "); 
                        return;
                        
                    }
                    else
                    {

                        if (Opc == "4") //Selecciono el Procedimiento BUSCAR y no encotro el registro.
                        {
                            MessageBox.Show("Resgistro NO ENCONTRADO");
                            txt_Codigo.Focus(); Pos = BakPos;
                            //this.Btn_Cerrar_Click(null, null);
                        }
                        else if (Opc == "1") //Selecciono el Procedimiento NUEVO
                        {

                            ActDesObjetos(true);
                            txt_Codigo.Enabled = false; txt_Codigo.Focus();
                            txt_Nombre.Enabled = true;
                            txt_Apellido.Enabled = true;
                            txt_Direccion.Enabled = true;
                            txt_Telefono.Enabled = true;
                            txt_Correo.Enabled = true;
                            cbx_Cargo.Enabled = true;
                            txt_codper.Enabled = true;
                            txt_Nombre.Text = "";
                            txt_Apellido.Text = "";
                            txt_Direccion.Text = "";
                            txt_Telefono.Text = "";
                            txt_Correo.Text = "";
                            txt_codper.Text = "";

                            //cbx_Tpersona.Text = "";
                            //cbx_Cargo.Text = "";
                        }  
                    }  
                }
                txt_Nombre.Focus();
            }
        }

        private void txt_Nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                txt_Apellido.Focus();
            }
        }

        private void txt_Codigo_Validated(object sender, EventArgs e)
        {
            
                if (txt_Codigo.Text == string.Empty) { txt_Codigo.Focus(); MessageBox.Show("Digite el número del Usuario"); }
                else
                {

                    int BakPos = Pos; // Captura la posición Actual --- Cerrar sin guardar...
                    string reg = "IdPersona='" + txt_Codigo.Text.Trim() + "'";
                    if (Conn.ConsultaItem("TPERSONA", reg))
                    {
                        Conn.Ds.Tables[0].PrimaryKey = new DataColumn[] { Conn.Ds.Tables[0].Columns["IdPersona"] }; //Crea Indice el Tabla temporal dt
                        Pos = Conn.Ds.Tables[0].Rows.IndexOf(Conn.Ds.Tables[0].Rows.Find(txt_Codigo.Text.Trim()));
                        this.Btn_Salir_Click(null, null); CargarDatos(Pos);
                        MessageBox.Show("Usuario Existente en la Base de Datos ");
                        return;

                    }
                    else
                    {

                        if (Opc == "4") //Selecciono el Procedimiento BUSCAR y no encotro el registro.
                        {
                            MessageBox.Show("Resgistro NO ENCONTRADO");
                            txt_Codigo.Focus(); Pos = BakPos;
                            //this.Btn_Cerrar_Click(null, null);
                        }
                        else if (Opc == "1") //Selecciono el Procedimiento NUEVO
                        {

                            ActDesObjetos(true);
                            txt_Codigo.Enabled = false; txt_Codigo.Focus();
                            txt_Nombre.Enabled = true;
                            txt_Apellido.Enabled = true;
                            txt_Direccion.Enabled = true;
                            txt_Telefono.Enabled = true;
                            txt_Correo.Enabled = true;
                            cbx_Cargo.Enabled = true;
                            txt_codper.Enabled = false;
                            txt_Nombre.Text = "";
                            txt_Apellido.Text = "";
                            txt_Direccion.Text = "";
                            txt_Telefono.Text = "";
                            txt_Correo.Text = "";
                            txt_codper.Text = "";

                            //cbx_Tpersona.Text = "";
                            //cbx_Cargo.Text = "";
                        }
                    }
                } 
        }

        

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.Title = "Buscando Archivos de Imagenes";
                string Filtro = "Todas las Imagenes (*.*) |*.bmp; *.jpg; *.jpeg; *.png; *.gif; *.tif; *.ico|" +
                                "Imágenes BMP (*.bmp) |*.bmp|" +
                                "Imágenes JPG (*.jpg) |*.jpg|" +
                                "Imágenes JPG (*.jpeg) |*.jpeg|" +
                                "Imágenes PNG (*.png) |*.png|" +
                                "Imágenes GIF (*.gif) |*.gif|" +
                                "Imágenes TIF (*.tif) |*.tif|" +
                                "Imágenes ICO (*.ico) |*.ico";
                openFileDialog1.Filter = Filtro;
                if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.Cancel) { return; }
                else { PBox1.Load(openFileDialog1.FileName); }

            }
            catch (Exception es) { MessageBox.Show(es.ToString()); }
        }

        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            if (Opc == "1")
            {
                ConverPic();
                string Agregar =  //(IdUsuario,documento,Nombres,Apellidos,Direccion,Correo,Telefono,IdLugar,IdPerfil,NomUser,Clave,Foto,Huella)
               "Insert Into TPERSONA (IdPersona,Nombre,Apellido,Direccion,Telefono,Correo,Cargo,Foto) SELECT '"
               + txt_Codigo.Text.Trim() + "','"
               + txt_Nombre.Text.Trim() + "','"
               + txt_Apellido.Text.Trim() + "','"
               + txt_Direccion.Text.Trim() + "','"
               + txt_Telefono.Text.Trim() + "','"
               + txt_Correo.Text.Trim() + "','"
               + cbx_Cargo.Text.Substring(0, 4) + "'" +
               ",xFoto.* From OpenRowSet(Bulk N'" + PBox1.ImageLocation + "', Single_Blob) As xFoto";

                if (Conn.Insertar(Agregar))
                { MessageBox.Show("Agregando Registro"); MostrarDatos(); Pos = Conn.Ds.Tables[0].Rows.Count - 1; }
                else { MessageBox.Show("Error al Agregar Registro"); }

            }

            if (Opc == "2")
            {
                ConverPic();
                string Actualizar =
                      "   Nombre     = '" + txt_Nombre.Text.Trim()
                    + "', Apellido   = '" + txt_Apellido.Text.Trim()
                    + "', Direccion   = '" + txt_Direccion.Text.Trim()
                    + "', Telefono  = '" + txt_Telefono.Text.Trim()
                    + "', Correo   = '" + txt_Correo.Text.Trim()
                    + "', Cargo     = '" + cbx_Cargo.Text.Substring(0, 4) + "'" +
                      ",Foto = (SELECT * From OpenRowSet(Bulk N'" + PBox1.ImageLocation + "', Single_Blob) As xFoto)";

                if (Conn.Actualizar("TPERSONA", Actualizar, "IdPersona=" + txt_Codigo.Text))
                { MessageBox.Show("Datos Actualizados"); int NPos = Pos; MostrarDatos(); CargarDatos(NPos); }
                else { MessageBox.Show("Error al Actualizar"); }
                //this.Btn_Cerrar_Click(null, null);
            }
            groupBox1.Enabled = true;
            groupBox1.Visible = true;
            EstadoBton(true);
            //NOTIFICACION_CONFIRMAR FrmEMERGENT = new NOTIFICACION_CONFIRMAR(); //(ref instance);
            //FrmEMERGENT.ShowDialog();
        }
    }
}
