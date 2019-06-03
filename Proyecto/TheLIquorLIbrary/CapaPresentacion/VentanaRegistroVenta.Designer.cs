namespace CapaPresentacion
{
    partial class VentanaRegistroVenta
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtClienteID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnFijarCliente = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLicorID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nUpDown = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAgregarLicor = new System.Windows.Forms.Button();
            this.dGV = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pais = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRegistrarVenta = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGV)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Font = new System.Drawing.Font("Copperplate Gothic Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(123, 12);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(570, 29);
            this.txtNombre.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Copperplate Gothic Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre";
            // 
            // txtClienteID
            // 
            this.txtClienteID.Font = new System.Drawing.Font("Copperplate Gothic Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClienteID.ForeColor = System.Drawing.Color.LightGray;
            this.txtClienteID.Location = new System.Drawing.Point(123, 53);
            this.txtClienteID.Name = "txtClienteID";
            this.txtClienteID.Size = new System.Drawing.Size(368, 29);
            this.txtClienteID.TabIndex = 1;
            this.txtClienteID.Text = "Ingresa ID";
            this.txtClienteID.Enter += new System.EventHandler(this.txtClienteID_Enter);
            this.txtClienteID.Leave += new System.EventHandler(this.txtClienteID_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Copperplate Gothic Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "ID";
            // 
            // btnFijarCliente
            // 
            this.btnFijarCliente.Font = new System.Drawing.Font("Copperplate Gothic Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFijarCliente.Location = new System.Drawing.Point(497, 47);
            this.btnFijarCliente.Name = "btnFijarCliente";
            this.btnFijarCliente.Size = new System.Drawing.Size(196, 38);
            this.btnFijarCliente.TabIndex = 0;
            this.btnFijarCliente.Text = "aceptar";
            this.btnFijarCliente.UseVisualStyleBackColor = true;
            this.btnFijarCliente.Click += new System.EventHandler(this.btnFijarCliente_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Copperplate Gothic Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Licor ID";
            // 
            // txtLicorID
            // 
            this.txtLicorID.Font = new System.Drawing.Font("Copperplate Gothic Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLicorID.ForeColor = System.Drawing.Color.LightGray;
            this.txtLicorID.Location = new System.Drawing.Point(126, 125);
            this.txtLicorID.Name = "txtLicorID";
            this.txtLicorID.Size = new System.Drawing.Size(205, 29);
            this.txtLicorID.TabIndex = 7;
            this.txtLicorID.Text = "Ingresa ID";
            this.txtLicorID.Enter += new System.EventHandler(this.txtLicorID_Enter);
            this.txtLicorID.Leave += new System.EventHandler(this.txtLicorID_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Copperplate Gothic Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(463, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "Cantidad";
            // 
            // nUpDown
            // 
            this.nUpDown.Font = new System.Drawing.Font("Copperplate Gothic Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nUpDown.Location = new System.Drawing.Point(598, 126);
            this.nUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUpDown.Name = "nUpDown";
            this.nUpDown.Size = new System.Drawing.Size(95, 29);
            this.nUpDown.TabIndex = 9;
            this.nUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Copperplate Gothic Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(680, 21);
            this.label5.TabIndex = 10;
            this.label5.Text = "___________________________________________________________________";
            // 
            // btnAgregarLicor
            // 
            this.btnAgregarLicor.Font = new System.Drawing.Font("Copperplate Gothic Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarLicor.Location = new System.Drawing.Point(295, 160);
            this.btnAgregarLicor.Name = "btnAgregarLicor";
            this.btnAgregarLicor.Size = new System.Drawing.Size(196, 38);
            this.btnAgregarLicor.TabIndex = 11;
            this.btnAgregarLicor.Text = "agregar";
            this.btnAgregarLicor.UseVisualStyleBackColor = true;
            this.btnAgregarLicor.Click += new System.EventHandler(this.btnAgregarLicor_Click);
            // 
            // dGV
            // 
            this.dGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nombre,
            this.precio,
            this.pais,
            this.cantidad});
            this.dGV.Location = new System.Drawing.Point(26, 204);
            this.dGV.Name = "dGV";
            this.dGV.RowTemplate.Height = 24;
            this.dGV.Size = new System.Drawing.Size(667, 161);
            this.dGV.TabIndex = 12;
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Licor";
            this.nombre.Name = "nombre";
            // 
            // precio
            // 
            this.precio.HeaderText = "Precio";
            this.precio.Name = "precio";
            // 
            // pais
            // 
            this.pais.HeaderText = "País";
            this.pais.Name = "pais";
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.Name = "cantidad";
            // 
            // btnRegistrarVenta
            // 
            this.btnRegistrarVenta.Font = new System.Drawing.Font("Copperplate Gothic Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarVenta.Location = new System.Drawing.Point(245, 459);
            this.btnRegistrarVenta.Name = "btnRegistrarVenta";
            this.btnRegistrarVenta.Size = new System.Drawing.Size(196, 38);
            this.btnRegistrarVenta.TabIndex = 13;
            this.btnRegistrarVenta.Text = "registrar venta";
            this.btnRegistrarVenta.UseVisualStyleBackColor = true;
            this.btnRegistrarVenta.Click += new System.EventHandler(this.btnRegistrarVenta_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Copperplate Gothic Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(69, 384);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(194, 21);
            this.label6.TabIndex = 15;
            this.label6.Text = "Formato de pago";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Copperplate Gothic Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Contado",
            "Crédito",
            "PayPal",
            "Moneda Virtual"});
            this.comboBox1.Location = new System.Drawing.Point(270, 381);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(322, 29);
            this.comboBox1.TabIndex = 16;
            this.comboBox1.Text = "...";
            // 
            // VentanaRegistroVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 547);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnRegistrarVenta);
            this.Controls.Add(this.dGV);
            this.Controls.Add(this.btnAgregarLicor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nUpDown);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtLicorID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnFijarCliente);
            this.Controls.Add(this.txtClienteID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label1);
            this.Name = "VentanaRegistroVenta";
            this.Text = "VentanaRegistroLicor";
            ((System.ComponentModel.ISupportInitialize)(this.nUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtClienteID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnFijarCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLicorID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nUpDown;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAgregarLicor;
        private System.Windows.Forms.DataGridView dGV;
        private System.Windows.Forms.Button btnRegistrarVenta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn pais;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
    }
}