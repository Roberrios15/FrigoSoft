namespace Presentacion
{
    partial class FormProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProductos));
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.btnCerdo = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPollo = new System.Windows.Forms.PictureBox();
            this.btnEmbutido = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerdo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPollo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEmbutido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox5
            // 
            this.pictureBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(34, 155);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(206, 201);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 1;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnCerdo
            // 
            this.btnCerdo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerdo.Image = ((System.Drawing.Image)(resources.GetObject("btnCerdo.Image")));
            this.btnCerdo.Location = new System.Drawing.Point(552, 155);
            this.btnCerdo.Name = "btnCerdo";
            this.btnCerdo.Size = new System.Drawing.Size(196, 201);
            this.btnCerdo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerdo.TabIndex = 1;
            this.btnCerdo.TabStop = false;
            this.btnCerdo.Click += new System.EventHandler(this.btnCerdo_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(465, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "PRODUCTOS";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnPollo
            // 
            this.btnPollo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPollo.Image = ((System.Drawing.Image)(resources.GetObject("btnPollo.Image")));
            this.btnPollo.Location = new System.Drawing.Point(287, 155);
            this.btnPollo.Name = "btnPollo";
            this.btnPollo.Size = new System.Drawing.Size(206, 201);
            this.btnPollo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnPollo.TabIndex = 1;
            this.btnPollo.TabStop = false;
            this.btnPollo.Click += new System.EventHandler(this.pictureBox8_Click);
            // 
            // btnEmbutido
            // 
            this.btnEmbutido.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmbutido.Image = ((System.Drawing.Image)(resources.GetObject("btnEmbutido.Image")));
            this.btnEmbutido.Location = new System.Drawing.Point(809, 155);
            this.btnEmbutido.Name = "btnEmbutido";
            this.btnEmbutido.Size = new System.Drawing.Size(196, 201);
            this.btnEmbutido.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnEmbutido.TabIndex = 1;
            this.btnEmbutido.TabStop = false;
            this.btnEmbutido.Click += new System.EventHandler(this.btnEmbutido_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1029, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(17, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // FormProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1058, 600);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnEmbutido);
            this.Controls.Add(this.btnPollo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCerdo);
            this.Controls.Add(this.pictureBox5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.FormProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerdo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPollo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEmbutido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox btnCerdo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox btnPollo;
        private System.Windows.Forms.PictureBox btnEmbutido;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}