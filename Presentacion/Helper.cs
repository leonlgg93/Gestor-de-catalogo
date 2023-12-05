using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using negocio;
using dominio;
using Presentacion;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace negocio
{
    public static class Helper
    {
        public static void cargar(DataGridView dgvArticulo)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            List<Articulo> listaArticulo;
            try
            {
                listaArticulo = negocio.listar();
                dgvArticulo.DataSource = listaArticulo;
                Helper.ocultarColumnas(dgvArticulo);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public static void ocultarColumnas(DataGridView dgvArticulo)
        {
            dgvArticulo.Columns["ImagenUrl"].Visible = false;
            dgvArticulo.Columns["Id"].Visible = false;
            dgvArticulo.Columns["Descripcion"].Visible = false;
            dgvArticulo.Columns["Precio"].Visible = false;
        }
        public static void cargarImagen(string imagen, PictureBox pbxArticulo)
        {
            try
            {
                pbxArticulo.Load(imagen);
            }
            catch (Exception)
            {
                pbxArticulo.Load("https://t3.ftcdn.net/jpg/02/48/42/64/360_F_248426448_NVKLywWqArG2ADUxDq6QprtIzsF82dMF.jpg");
            }
        }
        public static void anclarBotones(Button btnAgregar, Button btnModificar, Button btnEliminar, Button btnDetalles)
        {
            btnAgregar.Anchor = AnchorStyles.Bottom;
            btnModificar.Anchor = AnchorStyles.Bottom;
            btnEliminar.Anchor = AnchorStyles.Bottom;
            btnDetalles.Anchor = AnchorStyles.Bottom;
        }
        public static void eliminar(DataGridView dgvArticulo)
        {
            try
            {
                DialogResult respuesta = MessageBox.Show("¿Desea eliminar este artículo?", "Eliminando...", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    ArticuloNegocio negocio = new ArticuloNegocio();
                    Articulo seleccionado = (Articulo)dgvArticulo.CurrentRow.DataBoundItem;
                    negocio.eliminar(seleccionado.Id);
                    Helper.cargar(dgvArticulo);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public static void buscar(ComboBox cboCampo, ComboBox cboCriterio, TextBox txtFiltro, DataGridView dgvArticulo)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            bool validarFiltro = Helper.validarFiltro(cboCampo, cboCriterio, txtFiltro);

            try
            {
                if (validarFiltro)
                {
                    return;
                }

                string campo = cboCampo.SelectedItem.ToString();
                string criterio = cboCriterio.SelectedItem.ToString();
                string filtro = txtFiltro.Text;
                dgvArticulo.DataSource = negocio.filtrar(campo, criterio, filtro);                
            }
            catch (Exception)
            {
                if (dgvArticulo.SelectedRows == null)
                {
                    MessageBox.Show("Debe haber un elemento de la lista seleccionado para ver detalles.");
                }
                if (cboCampo.SelectedItem.ToString() == "Precio")
                {
                    if (string.IsNullOrEmpty(txtFiltro.Text))
                    {
                        txtFiltro.Text = "Ingrese un precio para buscar";
                        //txtFiltro.Clear();
                    }
                }
            }
        }
        public static bool validarFiltro(ComboBox cboCampo, ComboBox cboCriterio, TextBox txtFiltro)
        {
            bool validar = false;
            if (cboCampo != null && cboCampo.SelectedIndex < 0 || cboCampo.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un campo y un criterio para buscar");
                validar = true;
            }
            while (cboCampo.SelectedItem != null)
            {
                if (cboCriterio != null && cboCriterio.SelectedIndex < 0 || cboCriterio.SelectedItem == null)
                {
                    MessageBox.Show("Debe seleccionar un criterio para buscar");
                    validar = true;
                    return validar;
                }
                break;
            }
            
            return validar;


        }
    }
}
