using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using negocio;
using dominio;
using System.Data.SqlClient;


namespace Presentacion
{
    public partial class frmCatalogo : Form
    {
        private ToolTip toolTipBotones;
        public frmCatalogo()
        {
            InitializeComponent();
            toolTipBotones = new ToolTip();
            toolTipBotones.SetToolTip(btnAgregar, "Agregar Artículo");
            toolTipBotones.SetToolTip(btnModificar, "Modificar Artículo");
            toolTipBotones.SetToolTip(btnEliminar, "Eliminar Artículo");
            toolTipBotones.SetToolTip(btnDetalles, "Ver más");
            toolTipBotones.SetToolTip(btnBusqueda, "Buscar Artículo");
        }
        private void frmCatalogo_Load(object sender, EventArgs e)
        {
            Helper.cargar(dgvArticulo);
            cboCampo.Items.Add("Categoria");
            cboCampo.Items.Add("Marca");
            cboCampo.Items.Add("Precio");
            cboCampo.Items.Add("Nombre");
            Helper.anclarBotones(btnAgregar, btnModificar, btnEliminar, btnDetalles);
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAltaArticulo alta = new frmAltaArticulo();
            alta.ShowDialog();
            Helper.cargar(dgvArticulo);
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvArticulo.SelectedRows.Count > 0)
            {
                Articulo seleccionado;
                seleccionado = (Articulo)dgvArticulo.CurrentRow.DataBoundItem;
                frmAltaArticulo modificar = new frmAltaArticulo(seleccionado);
                modificar.ShowDialog();
                Helper.cargar(dgvArticulo);
            }
            else
            {
                MessageBox.Show("No hay ningun articulo seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Helper.eliminar(dgvArticulo);
        }
        private void btnDetalles_Click(object sender, EventArgs e)
        {
            if (dgvArticulo.SelectedRows.Count > 0)
            {               
                Articulo seleccionado;
                seleccionado = (Articulo)dgvArticulo.CurrentRow.DataBoundItem;
                frmDetallesArticulo detalles = new frmDetallesArticulo(seleccionado);
                detalles.ShowDialog();
                Helper.cargar(dgvArticulo);
            }
            else
            {               
                MessageBox.Show("No hay ningun articulo seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void cboCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = cboCampo.SelectedItem.ToString();
            if (opcion == "Precio")
            {
                cboCriterio.Items.Clear();
                cboCriterio.Items.Add("Mayor a");
                cboCriterio.Items.Add("Menor a");
                cboCriterio.Items.Add("Igual a");


            }
            else
            {
                cboCriterio.Items.Clear();
                cboCriterio.Items.Add("Comienza con...");
                cboCriterio.Items.Add("Termina con...");
                cboCriterio.Items.Add("Contiene...");
            }
        }
        private void btnBusqueda_Click(object sender, EventArgs e)
        {
            Helper.buscar(cboCampo, cboCriterio, txtFiltro, dgvArticulo);
        }
        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            string campoSeleccionada = cboCampo.SelectedItem?.ToString();

            if (campoSeleccionada != null && campoSeleccionada.Equals("Precio"))
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                    e.Handled = true;
            }
        }
        private void txtFiltro_Enter(object sender, EventArgs e)
        {
            if (txtFiltro.Text == "Ingrese un precio para buscar")
            {
                txtFiltro.Text = string.Empty;
            }
        }
    }
}
