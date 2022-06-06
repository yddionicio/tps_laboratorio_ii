using System;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Entidades;

namespace FrmLibreMercado
{
    public partial class FrmAltaPedido : Form
    {
        Cliente cliente;

        public FrmAltaPedido(Cliente cliente)
        {
            InitializeComponent();
            this.cliente = cliente;
        }

        private void FrmAltaPedido_Load(object sender, EventArgs e)
        {
            this.txtNombre.Text = this.cliente.Nombre;
            this.txtApellido.Text = this.cliente.Apellido;
            this.txtDni.Text = this.cliente.Dni.ToString();

            this.cbTipo.Items.AddRange(new string[] { "Notebook", "Monitor" });
            this.cbTipo.SelectedIndex = 0;
        }

        private void btnPedido_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(this.cliente.ToString());
            sb.AppendLine("Pedido:");
            sb.AppendLine(this.rTxtProductos.Text);
            sb.AppendLine("----------------------------------------------------------------------------------------------------");
            sb.AppendLine("----------------------------------------------------------------------------------------------------");

            File.AppendAllText("pedidos.txt", sb.ToString() + Environment.NewLine);

            this.Close();
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            if (this.txtMarca.Text == "" || this.numUDCantidad.Value == 0 || this.cbTipo.Text == "" || this.cbCampo1.Text == "" || this.cbCampo2.Text == "")
            {
                MessageBox.Show("Faltan datos para agregar el producto");
                return;
            }

            Producto producto;

            if (this.cbTipo.Text == "Notebook")
            {
                Notebook.ETipoDisco tipoDisco;
                Enum.TryParse(cbCampo1.Text, out tipoDisco);

                producto = new Notebook(
                    this.txtMarca.Text,
                    decimal.ToInt32(this.numUDCantidad.Value),
                    tipoDisco,
                    int.Parse(cbCampo2.Text)
                );
            }
            else
            {
                bool pantallaCurva = this.cbCampo2.Text == "Si";

                producto = new Monitor(
                    this.txtMarca.Text,
                    decimal.ToInt32(this.numUDCantidad.Value),
                    int.Parse(this.cbCampo1.Text),
                    pantallaCurva
                );
            }

            this.rTxtProductos.Text += $"\t{producto}\n";
        }

        private void cbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.cbCampo1.Items.Clear();
            this.cbCampo2.Items.Clear();

            if (this.cbTipo.Text == "Notebook")
            {
                this.lblCampo1.Text = "Tipo Disco";
                this.lblCampo2.Text = "Espacio Disco";

                this.cbCampo1.Items.AddRange(new string[] { "SSD", "HDD" });
                this.cbCampo1.SelectedIndex = 0;

                this.cbCampo2.Items.AddRange(new string[] { "520", "1024" });
                this.cbCampo2.SelectedIndex = 0;
            }
            else
            {
                this.lblCampo1.Text = "Pulgadas";
                this.lblCampo2.Text = "Pantalla Curva";

                this.cbCampo1.Items.AddRange(new string[] { "24", "27", "32" });
                this.cbCampo1.SelectedIndex = 0;

                this.cbCampo2.Items.AddRange(new string[] { "Si", "No" });
                this.cbCampo2.SelectedIndex = 0;
            }
        }
    }
}
