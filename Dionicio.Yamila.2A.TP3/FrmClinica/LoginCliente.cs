using System;
using System.Windows.Forms;
using Entidades;

namespace FrmLibreMercado
{
    public partial class LoginCliente : Form
    {
        PlataformaDeVentas libreMercado;

        public LoginCliente(PlataformaDeVentas libreMercado)
        {
            InitializeComponent();
            this.libreMercado = libreMercado;
        }

        private void btnDarAlta_Click(object sender, EventArgs e)
        {
            agregarCliente(DialogResult.No);
        }

        private void btnPedido_Click(object sender, EventArgs e)
        {
            agregarCliente(DialogResult.Yes);
        }

        private void agregarCliente(DialogResult generarPedido)
        {
            if (this.txtNombre.Text == "" || this.txtApellido.Text == "" || this.txtDni.Text == "")
            {
                MessageBox.Show("Faltan datos para dar de alta al cliente.");
                return;
            }

            Cliente cliente = new Cliente(
                int.Parse(this.txtDni.Text),
                this.txtNombre.Text,
                this.txtApellido.Text
            );

            if(!(libreMercado + cliente))
            {
                MessageBox.Show("El cliente ya existe.");
                return;
            }

            this.DialogResult = generarPedido;
        }

        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
