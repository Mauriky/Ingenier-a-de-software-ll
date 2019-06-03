namespace CapaPresentacion
{
    partial class VentanaPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaPrincipal));
            this.menuVertical = new System.Windows.Forms.Panel();
            this.BtnRegistrarVenta = new System.Windows.Forms.Button();
            this.BtnRegistrarLicor = new System.Windows.Forms.Button();
            this.BtnRegistrarCliente = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.IconoCerrar = new System.Windows.Forms.PictureBox();
            this.IconoMinimizar = new System.Windows.Forms.PictureBox();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.menuVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconoCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconoMinimizar)).BeginInit();
            this.SuspendLayout();
            // 
            // menuVertical
            // 
            this.menuVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.menuVertical.Controls.Add(this.BtnRegistrarVenta);
            this.menuVertical.Controls.Add(this.BtnRegistrarLicor);
            this.menuVertical.Controls.Add(this.BtnRegistrarCliente);
            this.menuVertical.Controls.Add(this.pictureBox1);
            this.menuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuVertical.Location = new System.Drawing.Point(0, 0);
            this.menuVertical.Name = "menuVertical";
            this.menuVertical.Size = new System.Drawing.Size(250, 550);
            this.menuVertical.TabIndex = 0;
            // 
            // BtnRegistrarVenta
            // 
            this.BtnRegistrarVenta.FlatAppearance.BorderSize = 0;
            this.BtnRegistrarVenta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.BtnRegistrarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRegistrarVenta.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegistrarVenta.ForeColor = System.Drawing.Color.White;
            this.BtnRegistrarVenta.Image = ((System.Drawing.Image)(resources.GetObject("BtnRegistrarVenta.Image")));
            this.BtnRegistrarVenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnRegistrarVenta.Location = new System.Drawing.Point(0, 324);
            this.BtnRegistrarVenta.Name = "BtnRegistrarVenta";
            this.BtnRegistrarVenta.Size = new System.Drawing.Size(250, 50);
            this.BtnRegistrarVenta.TabIndex = 3;
            this.BtnRegistrarVenta.Text = "Registrar Venta";
            this.BtnRegistrarVenta.UseVisualStyleBackColor = true;
            this.BtnRegistrarVenta.Click += new System.EventHandler(this.BtnRegistrarVenta_Click);
            // 
            // BtnRegistrarLicor
            // 
            this.BtnRegistrarLicor.FlatAppearance.BorderSize = 0;
            this.BtnRegistrarLicor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.BtnRegistrarLicor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRegistrarLicor.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegistrarLicor.ForeColor = System.Drawing.Color.White;
            this.BtnRegistrarLicor.Image = ((System.Drawing.Image)(resources.GetObject("BtnRegistrarLicor.Image")));
            this.BtnRegistrarLicor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnRegistrarLicor.Location = new System.Drawing.Point(0, 243);
            this.BtnRegistrarLicor.Name = "BtnRegistrarLicor";
            this.BtnRegistrarLicor.Size = new System.Drawing.Size(250, 50);
            this.BtnRegistrarLicor.TabIndex = 2;
            this.BtnRegistrarLicor.Text = "Registrar Licor";
            this.BtnRegistrarLicor.UseVisualStyleBackColor = true;
            this.BtnRegistrarLicor.Click += new System.EventHandler(this.BtnRegistrarLicor_Click);
            // 
            // BtnRegistrarCliente
            // 
            this.BtnRegistrarCliente.FlatAppearance.BorderSize = 0;
            this.BtnRegistrarCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.BtnRegistrarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRegistrarCliente.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegistrarCliente.ForeColor = System.Drawing.Color.White;
            this.BtnRegistrarCliente.Image = ((System.Drawing.Image)(resources.GetObject("BtnRegistrarCliente.Image")));
            this.BtnRegistrarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnRegistrarCliente.Location = new System.Drawing.Point(0, 160);
            this.BtnRegistrarCliente.Name = "BtnRegistrarCliente";
            this.BtnRegistrarCliente.Size = new System.Drawing.Size(250, 50);
            this.BtnRegistrarCliente.TabIndex = 1;
            this.BtnRegistrarCliente.Text = "Registrar Cliente";
            this.BtnRegistrarCliente.UseVisualStyleBackColor = true;
            this.BtnRegistrarCliente.Click += new System.EventHandler(this.BtnRegistrarCliente_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 116);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // BarraTitulo
            // 
            this.BarraTitulo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BarraTitulo.Controls.Add(this.IconoCerrar);
            this.BarraTitulo.Controls.Add(this.IconoMinimizar);
            this.BarraTitulo.Cursor = System.Windows.Forms.Cursors.NoMove2D;
            this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTitulo.Location = new System.Drawing.Point(250, 0);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(750, 30);
            this.BarraTitulo.TabIndex = 1;
            this.BarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraTitulo_MouseDown);
            // 
            // IconoCerrar
            // 
            this.IconoCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IconoCerrar.Image = ((System.Drawing.Image)(resources.GetObject("IconoCerrar.Image")));
            this.IconoCerrar.Location = new System.Drawing.Point(718, 0);
            this.IconoCerrar.Name = "IconoCerrar";
            this.IconoCerrar.Size = new System.Drawing.Size(30, 30);
            this.IconoCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IconoCerrar.TabIndex = 0;
            this.IconoCerrar.TabStop = false;
            this.IconoCerrar.Click += new System.EventHandler(this.IconoCerrar_Click);
            // 
            // IconoMinimizar
            // 
            this.IconoMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IconoMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("IconoMinimizar.Image")));
            this.IconoMinimizar.Location = new System.Drawing.Point(686, 0);
            this.IconoMinimizar.Name = "IconoMinimizar";
            this.IconoMinimizar.Size = new System.Drawing.Size(30, 30);
            this.IconoMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IconoMinimizar.TabIndex = 0;
            this.IconoMinimizar.TabStop = false;
            this.IconoMinimizar.Click += new System.EventHandler(this.IconoMinimizar_Click);
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(250, 30);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(750, 520);
            this.panelContenedor.TabIndex = 2;
            // 
            // VentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 550);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.BarraTitulo);
            this.Controls.Add(this.menuVertical);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VentanaPrincipal";
            this.Text = "VentanaPrincipal";
            this.menuVertical.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.BarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.IconoCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconoMinimizar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menuVertical;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Button BtnRegistrarVenta;
        private System.Windows.Forms.Button BtnRegistrarLicor;
        private System.Windows.Forms.Button BtnRegistrarCliente;
        private System.Windows.Forms.PictureBox IconoCerrar;
        private System.Windows.Forms.PictureBox IconoMinimizar;
    }
}