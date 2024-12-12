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
    public partial class FormCategoria : Form
    {
        public FormCategoria()
        {
            InitializeComponent();
        }


        COMPLEMENTO ONTEnter = new COMPLEMENTO(); //Carga la clase complementos con el nombre ONTEnter
        CONEXION_DB Conn = new CONEXION_DB();
        string Opc = "0"; //Define que operación se va a trabajar Nuevo, Editar.. --> tipo texto
        DataRow fila;
        string ValNomUser = string.Empty; //Valida el Nombre del Usuario al Editar
        string ValDocUser = string.Empty; //Valida el Documento del Usuario al Editar

        private void FormCategoria_Load(object sender, EventArgs e)
        {
            Conn.Conectar();
            UltimoRegistro();
            guna2ShadowForm1.SetShadowForm(this);
        }

        private void CargarDatos(int Pos)
        {
            fila = Conn.Ds.Tables[0].Rows[Pos];//Guarda el Registro (pos) en la variable "fila"
            textBox1.Text = Convert.ToString(fila["IdCategoria"]).Trim(); // Carga los datos del Campo al textBox 
            textBox2.Text = Convert.ToString(fila["Nombre"]).Trim(); // Carga los datos del Campo al textBox 
            textBox2.Text = Convert.ToString(fila["Estado"]).Trim(); // Carga los datos del Campo al textBox 
        }

        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            {
                string Agregar = "Insert Into TCATEGORIA SELECT '"  //(IdCliente,Nombres,Apellidos,Direccion,Correo,Telefono,IdLugar,IdPerfil,NomUser,Clave,Foto,Huella)
                + textBox1.Text.Trim() + "','"
                + textBox2.Text.Trim() + "','"
                + textBox3.Text.Trim() + "'";

                if (Conn.Insertar(Agregar))
                { MessageBox.Show("Agregando Registro"); }
                else { MessageBox.Show("Error al Agregar Registro"); }
                this.Btn_Cerrar_Click(null, null);
            }

        }

        public void UltimoRegistro()
        {
            //CapaEntidades entities = new CapaEntidades();
            //CapaNegocio business = new CapaNegocio();
            //business.UltimoRegistro(entities);

            //label5.Text = "ID Ult. Registro: 0" + entities.UltCargo;
        }

        private void Btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
