namespace Presentacion
{
    partial class FormProveedores
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNit = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.chEmbutidos = new System.Windows.Forms.CheckBox();
            this.chCerdo = new System.Windows.Forms.CheckBox();
            this.chPollo = new System.Windows.Forms.CheckBox();
            this.chRes = new System.Windows.Forms.CheckBox();
            this.txtContacto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtgvProveedores = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvProveedores)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.label1.Location = new System.Drawing.Point(203, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lista de Proveedores";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label2.Location = new System.Drawing.Point(40, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label3.Location = new System.Drawing.Point(38, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Direccion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label4.Location = new System.Drawing.Point(38, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Categoria";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(115, 73);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(117, 20);
            this.txtNombre.TabIndex = 3;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(115, 112);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(117, 20);
            this.txtDireccion.TabIndex = 3;
            // 
            // btnAgregar
            // 
            this.btnAgregar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(6)))), ((int)(((byte)(27)))));
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAgregar.ImageKey = "(ninguna)";
            this.btnAgregar.Location = new System.Drawing.Point(40, 227);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(218, 29);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox1.Controls.Add(this.txtNit);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.chEmbutidos);
            this.groupBox1.Controls.Add(this.chCerdo);
            this.groupBox1.Controls.Add(this.chPollo);
            this.groupBox1.Controls.Add(this.chRes);
            this.groupBox1.Controls.Add(this.txtContacto);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.txtDireccion);
            this.groupBox1.Location = new System.Drawing.Point(587, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(287, 268);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " ";
            // 
            // txtNit
            // 
            this.txtNit.Location = new System.Drawing.Point(115, 39);
            this.txtNit.Name = "txtNit";
            this.txtNit.Size = new System.Drawing.Size(117, 20);
            this.txtNit.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label8.Location = new System.Drawing.Point(40, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 17);
            this.label8.TabIndex = 8;
            this.label8.Text = "Nit";
            // 
            // chEmbutidos
            // 
            this.chEmbutidos.AutoSize = true;
            this.chEmbutidos.Location = new System.Drawing.Point(166, 147);
            this.chEmbutidos.Name = "chEmbutidos";
            this.chEmbutidos.Size = new System.Drawing.Size(75, 17);
            this.chEmbutidos.TabIndex = 7;
            this.chEmbutidos.Text = "Embutidos";
            this.chEmbutidos.UseVisualStyleBackColor = true;
            // 
            // chCerdo
            // 
            this.chCerdo.AutoSize = true;
            this.chCerdo.Location = new System.Drawing.Point(166, 164);
            this.chCerdo.Name = "chCerdo";
            this.chCerdo.Size = new System.Drawing.Size(54, 17);
            this.chCerdo.TabIndex = 6;
            this.chCerdo.Text = "Cerdo";
            this.chCerdo.UseVisualStyleBackColor = true;
            // 
            // chPollo
            // 
            this.chPollo.AutoSize = true;
            this.chPollo.Location = new System.Drawing.Point(115, 164);
            this.chPollo.Name = "chPollo";
            this.chPollo.Size = new System.Drawing.Size(49, 17);
            this.chPollo.TabIndex = 5;
            this.chPollo.Text = "Pollo";
            this.chPollo.UseVisualStyleBackColor = true;
            // 
            // chRes
            // 
            this.chRes.AutoSize = true;
            this.chRes.Location = new System.Drawing.Point(115, 147);
            this.chRes.Name = "chRes";
            this.chRes.Size = new System.Drawing.Size(45, 17);
            this.chRes.TabIndex = 4;
            this.chRes.Text = "Res";
            this.chRes.UseVisualStyleBackColor = true;
            // 
            // txtContacto
            // 
            this.txtContacto.Location = new System.Drawing.Point(115, 192);
            this.txtContacto.Name = "txtContacto";
            this.txtContacto.Size = new System.Drawing.Size(117, 20);
            this.txtContacto.TabIndex = 3;
            this.txtContacto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtContacto_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(123, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 18);
            this.label6.TabIndex = 2;
            this.label6.Text = "PROVEEDOR";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label5.Location = new System.Drawing.Point(40, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Contacto";
            // 
            // dtgvProveedores
            // 
            this.dtgvProveedores.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dtgvProveedores.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgvProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvProveedores.Location = new System.Drawing.Point(35, 82);
            this.dtgvProveedores.Name = "dtgvProveedores";
            this.dtgvProveedores.Size = new System.Drawing.Size(546, 268);
            this.dtgvProveedores.TabIndex = 1;
            this.dtgvProveedores.Text = "dataGridView1";
            // 
            // FormProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(899, 520);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtgvProveedores);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormProveedores";
            this.Text = "Form2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvProveedores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgvProveedores;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtContacto;
        private System.Windows.Forms.CheckBox chEmbutidos;
        private System.Windows.Forms.CheckBox chCerdo;
        private System.Windows.Forms.CheckBox chPollo;
        private System.Windows.Forms.CheckBox chRes;
        private System.Windows.Forms.TextBox txtNit;
        private System.Windows.Forms.Label label8;
    }
}