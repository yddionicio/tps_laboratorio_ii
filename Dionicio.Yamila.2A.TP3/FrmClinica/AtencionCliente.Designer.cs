
namespace FrmLibreMercado
{
    partial class AtencionCliente
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.btnArchivo = new System.Windows.Forms.Button();
            this.btnDB = new System.Windows.Forms.Button();
            this.bntCargaManual = new System.Windows.Forms.Button();
            this.btnCrearPedido = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AllowUserToDeleteRows = false;
            this.dgvClientes.AllowUserToResizeColumns = false;
            this.dgvClientes.AllowUserToResizeRows = false;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(29, 38);
            this.dgvClientes.MultiSelect = false;
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.RowHeadersWidth = 62;
            this.dgvClientes.RowTemplate.Height = 33;
            this.dgvClientes.Size = new System.Drawing.Size(789, 392);
            this.dgvClientes.TabIndex = 0;
            // 
            // btnArchivo
            // 
            this.btnArchivo.Location = new System.Drawing.Point(843, 38);
            this.btnArchivo.Name = "btnArchivo";
            this.btnArchivo.Size = new System.Drawing.Size(190, 68);
            this.btnArchivo.TabIndex = 1;
            this.btnArchivo.Text = "Cargar archivo";
            this.btnArchivo.UseVisualStyleBackColor = true;
            this.btnArchivo.Click += new System.EventHandler(this.btnArchivo_Click);
            // 
            // btnDB
            // 
            this.btnDB.Location = new System.Drawing.Point(843, 130);
            this.btnDB.Name = "btnDB";
            this.btnDB.Size = new System.Drawing.Size(190, 68);
            this.btnDB.TabIndex = 1;
            this.btnDB.Text = "Cargar Base de Datos";
            this.btnDB.UseVisualStyleBackColor = true;
            this.btnDB.Click += new System.EventHandler(this.btnDB_Click);
            // 
            // bntCargaManual
            // 
            this.bntCargaManual.Location = new System.Drawing.Point(843, 223);
            this.bntCargaManual.Name = "bntCargaManual";
            this.bntCargaManual.Size = new System.Drawing.Size(190, 68);
            this.bntCargaManual.TabIndex = 1;
            this.bntCargaManual.Text = "Carga Manual";
            this.bntCargaManual.UseVisualStyleBackColor = true;
            this.bntCargaManual.Click += new System.EventHandler(this.bntCargaManual_Click);
            // 
            // btnCrearPedido
            // 
            this.btnCrearPedido.Location = new System.Drawing.Point(29, 465);
            this.btnCrearPedido.Name = "btnCrearPedido";
            this.btnCrearPedido.Size = new System.Drawing.Size(190, 68);
            this.btnCrearPedido.TabIndex = 1;
            this.btnCrearPedido.Text = "Crear Pedido";
            this.btnCrearPedido.UseVisualStyleBackColor = true;
            this.btnCrearPedido.Click += new System.EventHandler(this.btnCrearPedido_Click);
            // 
            // AtencionCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 552);
            this.Controls.Add(this.btnCrearPedido);
            this.Controls.Add(this.bntCargaManual);
            this.Controls.Add(this.btnDB);
            this.Controls.Add(this.btnArchivo);
            this.Controls.Add(this.dgvClientes);
            this.Name = "AtencionCliente";
            this.Text = "Atencion Cliente";
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Button btnArchivo;
        private System.Windows.Forms.Button btnDB;
        private System.Windows.Forms.Button bntCargaManual;
        private System.Windows.Forms.Button btnCrearPedido;
    }
}

