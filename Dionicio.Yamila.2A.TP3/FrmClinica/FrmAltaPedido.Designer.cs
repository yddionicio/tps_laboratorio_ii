
namespace FrmLibreMercado
{
    partial class FrmAltaPedido
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnPedido = new System.Windows.Forms.Button();
            this.gbCliente = new System.Windows.Forms.GroupBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lnlApellido = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblDni = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.gbProducto = new System.Windows.Forms.GroupBox();
            this.cbCampo2 = new System.Windows.Forms.ComboBox();
            this.lblCampo2 = new System.Windows.Forms.Label();
            this.cbCampo1 = new System.Windows.Forms.ComboBox();
            this.lblCampo1 = new System.Windows.Forms.Label();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.numUDCantidad = new System.Windows.Forms.NumericUpDown();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.rTxtProductos = new System.Windows.Forms.RichTextBox();
            this.gbCliente.SuspendLayout();
            this.gbProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUDCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPedido
            // 
            this.btnPedido.Location = new System.Drawing.Point(89, 1007);
            this.btnPedido.Name = "btnPedido";
            this.btnPedido.Size = new System.Drawing.Size(310, 57);
            this.btnPedido.TabIndex = 9;
            this.btnPedido.Text = "Realizar pedido";
            this.btnPedido.UseVisualStyleBackColor = true;
            this.btnPedido.Click += new System.EventHandler(this.btnPedido_Click);
            // 
            // gbCliente
            // 
            this.gbCliente.Controls.Add(this.lblNombre);
            this.gbCliente.Controls.Add(this.lnlApellido);
            this.gbCliente.Controls.Add(this.txtApellido);
            this.gbCliente.Controls.Add(this.lblDni);
            this.gbCliente.Controls.Add(this.txtDni);
            this.gbCliente.Controls.Add(this.txtNombre);
            this.gbCliente.Location = new System.Drawing.Point(29, 20);
            this.gbCliente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbCliente.Name = "gbCliente";
            this.gbCliente.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbCliente.Size = new System.Drawing.Size(431, 377);
            this.gbCliente.TabIndex = 8;
            this.gbCliente.TabStop = false;
            this.gbCliente.Text = "Datos del Cliente";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(73, 57);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(78, 25);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // lnlApellido
            // 
            this.lnlApellido.AutoSize = true;
            this.lnlApellido.Location = new System.Drawing.Point(73, 157);
            this.lnlApellido.Name = "lnlApellido";
            this.lnlApellido.Size = new System.Drawing.Size(78, 25);
            this.lnlApellido.TabIndex = 0;
            this.lnlApellido.Text = "Apellido";
            // 
            // txtApellido
            // 
            this.txtApellido.Enabled = false;
            this.txtApellido.Location = new System.Drawing.Point(73, 185);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(310, 31);
            this.txtApellido.TabIndex = 2;
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(73, 247);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(51, 25);
            this.lblDni.TabIndex = 0;
            this.lblDni.Text = "D.N.I";
            // 
            // txtDni
            // 
            this.txtDni.Enabled = false;
            this.txtDni.Location = new System.Drawing.Point(73, 275);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(310, 31);
            this.txtDni.TabIndex = 3;
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Location = new System.Drawing.Point(73, 85);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(310, 31);
            this.txtNombre.TabIndex = 1;
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.Location = new System.Drawing.Point(60, 492);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(310, 57);
            this.btnAgregarProducto.TabIndex = 11;
            this.btnAgregarProducto.Text = "Agregar Producto";
            this.btnAgregarProducto.UseVisualStyleBackColor = true;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            // 
            // gbProducto
            // 
            this.gbProducto.Controls.Add(this.cbCampo2);
            this.gbProducto.Controls.Add(this.lblCampo2);
            this.gbProducto.Controls.Add(this.cbCampo1);
            this.gbProducto.Controls.Add(this.lblCampo1);
            this.gbProducto.Controls.Add(this.cbTipo);
            this.gbProducto.Controls.Add(this.numUDCantidad);
            this.gbProducto.Controls.Add(this.lblMarca);
            this.gbProducto.Controls.Add(this.lblCantidad);
            this.gbProducto.Controls.Add(this.label3);
            this.gbProducto.Controls.Add(this.txtMarca);
            this.gbProducto.Controls.Add(this.btnAgregarProducto);
            this.gbProducto.Location = new System.Drawing.Point(29, 407);
            this.gbProducto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbProducto.Name = "gbProducto";
            this.gbProducto.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbProducto.Size = new System.Drawing.Size(431, 573);
            this.gbProducto.TabIndex = 13;
            this.gbProducto.TabStop = false;
            this.gbProducto.Text = "Nuevo Producto";
            // 
            // cbCampo2
            // 
            this.cbCampo2.FormattingEnabled = true;
            this.cbCampo2.Location = new System.Drawing.Point(60, 403);
            this.cbCampo2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbCampo2.Name = "cbCampo2";
            this.cbCampo2.Size = new System.Drawing.Size(310, 33);
            this.cbCampo2.TabIndex = 25;
            // 
            // lblCampo2
            // 
            this.lblCampo2.AutoSize = true;
            this.lblCampo2.Location = new System.Drawing.Point(60, 373);
            this.lblCampo2.Name = "lblCampo2";
            this.lblCampo2.Size = new System.Drawing.Size(85, 25);
            this.lblCampo2.TabIndex = 26;
            this.lblCampo2.Text = "Campo 2";
            // 
            // cbCampo1
            // 
            this.cbCampo1.FormattingEnabled = true;
            this.cbCampo1.Location = new System.Drawing.Point(60, 318);
            this.cbCampo1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbCampo1.Name = "cbCampo1";
            this.cbCampo1.Size = new System.Drawing.Size(310, 33);
            this.cbCampo1.TabIndex = 23;
            // 
            // lblCampo1
            // 
            this.lblCampo1.AutoSize = true;
            this.lblCampo1.Location = new System.Drawing.Point(60, 288);
            this.lblCampo1.Name = "lblCampo1";
            this.lblCampo1.Size = new System.Drawing.Size(85, 25);
            this.lblCampo1.TabIndex = 24;
            this.lblCampo1.Text = "Campo 1";
            // 
            // cbTipo
            // 
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Location = new System.Drawing.Point(60, 235);
            this.cbTipo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(310, 33);
            this.cbTipo.TabIndex = 14;
            this.cbTipo.SelectedIndexChanged += new System.EventHandler(this.cbTipo_SelectedIndexChanged);
            // 
            // numUDCantidad
            // 
            this.numUDCantidad.Location = new System.Drawing.Point(60, 148);
            this.numUDCantidad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numUDCantidad.Name = "numUDCantidad";
            this.numUDCantidad.Size = new System.Drawing.Size(313, 31);
            this.numUDCantidad.TabIndex = 22;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(60, 32);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(60, 25);
            this.lblMarca.TabIndex = 12;
            this.lblMarca.Text = "Marca";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(60, 118);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(83, 25);
            this.lblCantidad.TabIndex = 13;
            this.lblCantidad.Text = "Cantidad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "Tipo";
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(61, 60);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(310, 31);
            this.txtMarca.TabIndex = 15;
            // 
            // rTxtProductos
            // 
            this.rTxtProductos.Location = new System.Drawing.Point(487, 42);
            this.rTxtProductos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rTxtProductos.Name = "rTxtProductos";
            this.rTxtProductos.Size = new System.Drawing.Size(630, 1019);
            this.rTxtProductos.TabIndex = 27;
            this.rTxtProductos.Text = "";
            // 
            // FrmAltaPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 1082);
            this.Controls.Add(this.rTxtProductos);
            this.Controls.Add(this.gbProducto);
            this.Controls.Add(this.btnPedido);
            this.Controls.Add(this.gbCliente);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmAltaPedido";
            this.Text = "Alta Pedido";
            this.Load += new System.EventHandler(this.FrmAltaPedido_Load);
            this.gbCliente.ResumeLayout(false);
            this.gbCliente.PerformLayout();
            this.gbProducto.ResumeLayout(false);
            this.gbProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUDCantidad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPedido;
        private System.Windows.Forms.GroupBox gbCliente;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lnlApellido;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnAgregarProducto;
        private System.Windows.Forms.GroupBox gbProducto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label lblCampo1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.ComboBox cbTipo;
        private System.Windows.Forms.NumericUpDown numUDCantidad;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbCampo2;
        private System.Windows.Forms.Label lblCampo2;
        private System.Windows.Forms.ComboBox cbCampo1;
        private System.Windows.Forms.RichTextBox rTxtProductos;
    }
}