using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using Entidades;

namespace FrmLibreMercado
{
    public partial class AtencionCliente : Form
    {
        PlataformaDeVentas libreMercado;

        public AtencionCliente()
        {
            InitializeComponent();
            libreMercado = new PlataformaDeVentas();
        }

        private void btnArchivo_Click(object sender, EventArgs e)
        {
            try
            {
                List<Cliente> clientesJson = Cliente.LeerDesdeJson("clientes.json");
                libreMercado.AgregarClientes(clientesJson);
                UpdateDataGrid();
            }
            catch(TraerDatosException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDB_Click(object sender, EventArgs e)
        {
            try
            {
                List<Cliente> clientesDb = Cliente.LeerDesdeBaseDeDatos();
                libreMercado.AgregarClientes(clientesDb);
                UpdateDataGrid();
            }
            catch (TraerDatosException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bntCargaManual_Click(object sender, EventArgs e)
        {
            LoginCliente loginCliente = new LoginCliente(libreMercado);
            loginCliente.ShowDialog();

            if (loginCliente.DialogResult != DialogResult.Cancel)
            {
                if (loginCliente.DialogResult == DialogResult.Yes)
                {
                    AltaPedido(libreMercado.Clientes.Count - 1);
                }

                UpdateDataGrid();
            }
        }

        private void btnCrearPedido_Click(object sender, EventArgs e)
        {
            if(this.dgvClientes.CurrentCell == null)
            {
                return;
            }

            AltaPedido(this.dgvClientes.CurrentCell.RowIndex);
        }

        private void UpdateDataGrid()
        {
            BindingList<Cliente> bindingList = new BindingList<Cliente>(libreMercado.Clientes);
            dgvClientes.DataSource = new BindingSource(bindingList, null);
        }

        private void AltaPedido(int indexCliente)
        {
            FrmAltaPedido frmAltaPedido = new FrmAltaPedido(this.libreMercado.Clientes[indexCliente]);
            frmAltaPedido.ShowDialog();
        }
    }
}
