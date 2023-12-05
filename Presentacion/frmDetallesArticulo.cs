using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;
using System.Data.SqlClient;
using System.IO;

namespace Presentacion
{
    public partial class frmDetallesArticulo : Form
    {
        AccesoDatos datos = new AccesoDatos();
        private Articulo articulo = null;        
        private List<Articulo> listaArticulo;
        public frmDetallesArticulo()
        {
            InitializeComponent();
        }
        public frmDetallesArticulo(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            Text = "Detalles Articulo";
        }
        private void frmDetallesArticulo_Load(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            listaArticulo = negocio.listar();
            Helper.cargarImagen(articulo.ImagenUrl.ToString(), pbxDetalles);            
        }
        private void btnVerDetalles_Click(object sender, EventArgs e)
        {            
            AccesoDatos datos = new AccesoDatos();

            List<Articulo> lista = new List<Articulo>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            try
            {
                conexion.ConnectionString = "server= .\\SQLEXPRESS; database = CATALOGO_DB; integrated security = true";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "select Descripcion, Precio from ARTICULOS";
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();                                          

                while (lector.Read())
                    {
                        lwDetalles.Items.Add("Descripcion: " + articulo.Descripcion.ToString());
                        lwDetalles.Items.Add("Precio: " + articulo.Precio.ToString());                      
                        Helper.cargarImagen(articulo.ImagenUrl.ToString(), pbxDetalles);
                        break;
                    }
                

                conexion.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    } 
}
