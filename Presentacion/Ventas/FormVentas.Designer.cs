namespace Presentacion.Ventas
{
    partial class FormVentas
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labelDevolucion = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.btnVender = new System.Windows.Forms.Button();
            this.txtBosEfectivo = new System.Windows.Forms.RichTextBox();
            this.gridDetalles = new System.Windows.Forms.DataGridView();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtCodigoPro = new System.Windows.Forms.TextBox();
            this.txtPrecioLibra = new System.Windows.Forms.TextBox();
            this.txtExistencias = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBuscarProducto = new FontAwesome.Sharp.IconPictureBox();
            this.btnAddCart = new FontAwesome.Sharp.IconButton();
            this.btnRemoveCart = new FontAwesome.Sharp.IconButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtLibras = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDetalles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscarProducto)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(429, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = " VENTAS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label2.Location = new System.Drawing.Point(80, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Codigo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label4.Location = new System.Drawing.Point(80, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Producto:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.label5.Location = new System.Drawing.Point(596, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Fecha:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label6.Location = new System.Drawing.Point(80, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Precio x Libra:";
            // 
            // txtProducto
            // 
            this.txtProducto.Enabled = false;
            this.txtProducto.Location = new System.Drawing.Point(205, 87);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(148, 20);
            this.txtProducto.TabIndex = 11;
            this.txtProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxCantidad_KeyPress);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.lblFecha.Location = new System.Drawing.Point(714, 61);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(0, 19);
            this.lblFecha.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(6)))), ((int)(((byte)(27)))));
            this.label7.Location = new System.Drawing.Point(667, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 23);
            this.label7.TabIndex = 16;
            this.label7.Text = "Total a Pagar";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(6)))), ((int)(((byte)(27)))));
            this.label8.Location = new System.Drawing.Point(681, 234);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 23);
            this.label8.TabIndex = 16;
            this.label8.Text = "Devolución";
            // 
            // labelDevolucion
            // 
            this.labelDevolucion.AutoSize = true;
            this.labelDevolucion.BackColor = System.Drawing.SystemColors.ControlText;
            this.labelDevolucion.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.labelDevolucion.ForeColor = System.Drawing.Color.Yellow;
            this.labelDevolucion.Location = new System.Drawing.Point(0, 3);
            this.labelDevolucion.Name = "labelDevolucion";
            this.labelDevolucion.Size = new System.Drawing.Size(0, 23);
            this.labelDevolucion.TabIndex = 18;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Controls.Add(this.labelDevolucion);
            this.panel2.Location = new System.Drawing.Point(632, 272);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(214, 28);
            this.panel2.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label11.Location = new System.Drawing.Point(705, 343);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 21);
            this.label11.TabIndex = 20;
            this.label11.Text = "Efectivo:";
            // 
            // btnVender
            // 
            this.btnVender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(6)))), ((int)(((byte)(27)))));
            this.btnVender.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVender.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnVender.Location = new System.Drawing.Point(641, 449);
            this.btnVender.Name = "btnVender";
            this.btnVender.Size = new System.Drawing.Size(194, 59);
            this.btnVender.TabIndex = 21;
            this.btnVender.Text = "Vender";
            this.btnVender.UseVisualStyleBackColor = false;
            this.btnVender.Click += new System.EventHandler(this.btnVender_Click);
            // 
            // txtBosEfectivo
            // 
            this.txtBosEfectivo.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.txtBosEfectivo.Location = new System.Drawing.Point(632, 378);
            this.txtBosEfectivo.Name = "txtBosEfectivo";
            this.txtBosEfectivo.Size = new System.Drawing.Size(214, 33);
            this.txtBosEfectivo.TabIndex = 23;
            this.txtBosEfectivo.Text = "";
            this.txtBosEfectivo.TextChanged += new System.EventHandler(this.txtBosEfectivo_TextChanged);
            // 
            // gridDetalles
            // 
            this.gridDetalles.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.gridDetalles.Enabled = false;
            this.gridDetalles.Location = new System.Drawing.Point(80, 328);
            this.gridDetalles.Name = "gridDetalles";
            this.gridDetalles.Size = new System.Drawing.Size(487, 184);
            this.gridDetalles.TabIndex = 0;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(143, 138);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(0, 13);
            this.lblNombre.TabIndex = 24;
            // 
            // txtCodigoPro
            // 
            this.txtCodigoPro.Location = new System.Drawing.Point(205, 51);
            this.txtCodigoPro.Name = "txtCodigoPro";
            this.txtCodigoPro.Size = new System.Drawing.Size(148, 20);
            this.txtCodigoPro.TabIndex = 27;
            // 
            // txtPrecioLibra
            // 
            this.txtPrecioLibra.Enabled = false;
            this.txtPrecioLibra.Location = new System.Drawing.Point(205, 118);
            this.txtPrecioLibra.Name = "txtPrecioLibra";
            this.txtPrecioLibra.Size = new System.Drawing.Size(148, 20);
            this.txtPrecioLibra.TabIndex = 30;
            // 
            // txtExistencias
            // 
            this.txtExistencias.Enabled = false;
            this.txtExistencias.ForeColor = System.Drawing.Color.Red;
            this.txtExistencias.Location = new System.Drawing.Point(205, 147);
            this.txtExistencias.Name = "txtExistencias";
            this.txtExistencias.Size = new System.Drawing.Size(148, 20);
            this.txtExistencias.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label3.Location = new System.Drawing.Point(80, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 17);
            this.label3.TabIndex = 31;
            this.label3.Text = "Libras Disponibles:";
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(6)))), ((int)(((byte)(27)))));
            this.btnBuscarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarProducto.IconChar = FontAwesome.Sharp.IconChar.SearchPlus;
            this.btnBuscarProducto.IconColor = System.Drawing.Color.White;
            this.btnBuscarProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscarProducto.IconSize = 29;
            this.btnBuscarProducto.Location = new System.Drawing.Point(370, 45);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Size = new System.Drawing.Size(34, 29);
            this.btnBuscarProducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnBuscarProducto.TabIndex = 74;
            this.btnBuscarProducto.TabStop = false;
            this.btnBuscarProducto.Click += new System.EventHandler(this.btnBuscarProducto_Click);
            // 
            // btnAddCart
            // 
            this.btnAddCart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAddCart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddCart.FlatAppearance.BorderSize = 0;
            this.btnAddCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCart.IconChar = FontAwesome.Sharp.IconChar.CartPlus;
            this.btnAddCart.IconColor = System.Drawing.Color.White;
            this.btnAddCart.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddCart.IconSize = 32;
            this.btnAddCart.Location = new System.Drawing.Point(370, 215);
            this.btnAddCart.Name = "btnAddCart";
            this.btnAddCart.Size = new System.Drawing.Size(69, 42);
            this.btnAddCart.TabIndex = 75;
            this.btnAddCart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddCart.UseVisualStyleBackColor = false;
            this.btnAddCart.Click += new System.EventHandler(this.btnAddCart_Click);
            // 
            // btnRemoveCart
            // 
            this.btnRemoveCart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(6)))), ((int)(((byte)(27)))));
            this.btnRemoveCart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveCart.FlatAppearance.BorderSize = 0;
            this.btnRemoveCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveCart.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnRemoveCart.IconColor = System.Drawing.Color.White;
            this.btnRemoveCart.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRemoveCart.IconSize = 32;
            this.btnRemoveCart.Location = new System.Drawing.Point(448, 214);
            this.btnRemoveCart.Name = "btnRemoveCart";
            this.btnRemoveCart.Size = new System.Drawing.Size(69, 42);
            this.btnRemoveCart.TabIndex = 76;
            this.btnRemoveCart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRemoveCart.UseVisualStyleBackColor = false;
            this.btnRemoveCart.Click += new System.EventHandler(this.btnRemoveCart_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtValor);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.txtLibras);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.DarkRed;
            this.groupBox1.Location = new System.Drawing.Point(83, 185);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(270, 93);
            this.groupBox1.TabIndex = 77;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalles de la venta";
            // 
            // txtValor
            // 
            this.txtValor.Enabled = false;
            this.txtValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.Location = new System.Drawing.Point(77, 55);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(136, 20);
            this.txtValor.TabIndex = 81;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label14.Location = new System.Drawing.Point(12, 55);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(46, 17);
            this.label14.TabIndex = 80;
            this.label14.Text = "Valor:";
            // 
            // txtLibras
            // 
            this.txtLibras.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLibras.Location = new System.Drawing.Point(77, 29);
            this.txtLibras.Name = "txtLibras";
            this.txtLibras.Size = new System.Drawing.Size(136, 20);
            this.txtLibras.TabIndex = 79;
            this.txtLibras.TextChanged += new System.EventHandler(this.txtLibras_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label13.Location = new System.Drawing.Point(12, 29);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(48, 17);
            this.label13.TabIndex = 78;
            this.label13.Text = "Libras:";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.BackColor = System.Drawing.SystemColors.ControlText;
            this.labelTotal.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.labelTotal.ForeColor = System.Drawing.Color.Lime;
            this.labelTotal.Location = new System.Drawing.Point(0, 0);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(0, 23);
            this.labelTotal.TabIndex = 18;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Controls.Add(this.labelTotal);
            this.panel1.Location = new System.Drawing.Point(632, 147);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(214, 28);
            this.panel1.TabIndex = 19;
            // 
            // FormVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(962, 520);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnRemoveCart);
            this.Controls.Add(this.btnAddCart);
            this.Controls.Add(this.btnBuscarProducto);
            this.Controls.Add(this.txtExistencias);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPrecioLibra);
            this.Controls.Add(this.txtCodigoPro);
            this.Controls.Add(this.gridDetalles);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtBosEfectivo);
            this.Controls.Add(this.btnVender);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.txtProducto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormVentas";
            this.Text = "VENTAS";
            this.Load += new System.EventHandler(this.FormVentas_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDetalles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscarProducto)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.DataGridView gridDetalles;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelDevolucion;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnVender;
        private System.Windows.Forms.RichTextBox txtBosEfectivo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtCodigoPro;
        private System.Windows.Forms.TextBox txtPrecioLibra;
        private System.Windows.Forms.TextBox txtExistencias;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconPictureBox btnBuscarProducto;
        private FontAwesome.Sharp.IconButton btnAddCart;
        private FontAwesome.Sharp.IconButton btnRemoveCart;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtLibras;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Panel panel1;
    }
}