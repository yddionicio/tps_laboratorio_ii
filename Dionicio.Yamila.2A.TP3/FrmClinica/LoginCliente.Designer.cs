
namespace FrmLibreMercado
{
    partial class LoginCliente
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.lnlApellido = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.btnDarAlta = new System.Windows.Forms.Button();
            this.gbCliente = new System.Windows.Forms.GroupBox();
            this.btnPedido = new System.Windows.Forms.Button();
            this.gbCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(193, 57);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(78, 25);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // lnlApellido
            // 
            this.lnlApellido.AutoSize = true;
            this.lnlApellido.Location = new System.Drawing.Point(193, 157);
            this.lnlApellido.Name = "lnlApellido";
            this.lnlApellido.Size = new System.Drawing.Size(78, 25);
            this.lnlApellido.TabIndex = 0;
            this.lnlApellido.Text = "Apellido";
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(206, 247);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(51, 25);
            this.lblDni.TabIndex = 0;
            this.lblDni.Text = "D.N.I";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(73, 85);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(310, 31);
            this.txtNombre.TabIndex = 1;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(73, 185);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(310, 31);
            this.txtApellido.TabIndex = 2;
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(73, 275);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(310, 31);
            this.txtDni.TabIndex = 3;
            this.txtDni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDni_KeyPress);
            // 
            // btnDarAlta
            // 
            this.btnDarAlta.Location = new System.Drawing.Point(86, 420);
            this.btnDarAlta.Name = "btnDarAlta";
            this.btnDarAlta.Size = new System.Drawing.Size(310, 57);
            this.btnDarAlta.TabIndex = 4;
            this.btnDarAlta.Text = "Dar de Alta";
            this.btnDarAlta.UseVisualStyleBackColor = true;
            this.btnDarAlta.Click += new System.EventHandler(this.btnDarAlta_Click);
            // 
            // gbCliente
            // 
            this.gbCliente.Controls.Add(this.lblNombre);
            this.gbCliente.Controls.Add(this.lnlApellido);
            this.gbCliente.Controls.Add(this.txtApellido);
            this.gbCliente.Controls.Add(this.lblDni);
            this.gbCliente.Controls.Add(this.txtDni);
            this.gbCliente.Controls.Add(this.txtNombre);
            this.gbCliente.Location = new System.Drawing.Point(13, 20);
            this.gbCliente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbCliente.Name = "gbCliente";
            this.gbCliente.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbCliente.Size = new System.Drawing.Size(431, 377);
            this.gbCliente.TabIndex = 5;
            this.gbCliente.TabStop = false;
            this.gbCliente.Text = "Datos del Cliente";
            // 
            // btnPedido
            // 
            this.btnPedido.Location = new System.Drawing.Point(87, 542);
            this.btnPedido.Name = "btnPedido";
            this.btnPedido.Size = new System.Drawing.Size(310, 57);
            this.btnPedido.TabIndex = 6;
            this.btnPedido.Text = "Realizar pedido";
            this.btnPedido.UseVisualStyleBackColor = true;
            this.btnPedido.Click += new System.EventHandler(this.btnPedido_Click);
            // 
            // LoginCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 612);
            this.Controls.Add(this.btnPedido);
            this.Controls.Add(this.gbCliente);
            this.Controls.Add(this.btnDarAlta);
            this.Name = "LoginCliente";
            this.Text = "Login Cliente";
            this.gbCliente.ResumeLayout(false);
            this.gbCliente.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lnlApellido;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Button btnDarAlta;
        private System.Windows.Forms.GroupBox gbCliente;
        private System.Windows.Forms.Button btnPedido;
    }
}