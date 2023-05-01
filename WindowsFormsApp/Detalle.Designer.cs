using dominio;

namespace WindowsFormsApp
{
    partial class Detalle
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
            this.pbArt = new System.Windows.Forms.PictureBox();
            this.lblArtNombre = new System.Windows.Forms.Label();
            this.lblArtId = new System.Windows.Forms.Label();
            this.lblArtCodigo = new System.Windows.Forms.Label();
            this.lblArtDescripcion = new System.Windows.Forms.Label();
            this.lblArtMarca = new System.Windows.Forms.Label();
            this.lblArtCategoria = new System.Windows.Forms.Label();
            this.lblArtPrecio = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbArt)).BeginInit();
            this.SuspendLayout();
            // 
            // pbArt
            // 
            this.pbArt.Location = new System.Drawing.Point(482, 32);
            this.pbArt.Name = "pbArt";
            this.pbArt.Size = new System.Drawing.Size(339, 430);
            this.pbArt.TabIndex = 0;
            this.pbArt.TabStop = false;
            // 
            // lblArtNombre
            // 
            this.lblArtNombre.AutoSize = true;
            this.lblArtNombre.Location = new System.Drawing.Point(192, 32);
            this.lblArtNombre.Name = "lblArtNombre";
            this.lblArtNombre.Size = new System.Drawing.Size(44, 16);
            this.lblArtNombre.TabIndex = 1;
            this.lblArtNombre.Text = "label1";
            // 
            // lblArtId
            // 
            this.lblArtId.AutoSize = true;
            this.lblArtId.Location = new System.Drawing.Point(40, 97);
            this.lblArtId.Name = "lblArtId";
            this.lblArtId.Size = new System.Drawing.Size(44, 16);
            this.lblArtId.TabIndex = 2;
            this.lblArtId.Text = "label2";
            // 
            // lblArtCodigo
            // 
            this.lblArtCodigo.AutoSize = true;
            this.lblArtCodigo.Location = new System.Drawing.Point(40, 147);
            this.lblArtCodigo.Name = "lblArtCodigo";
            this.lblArtCodigo.Size = new System.Drawing.Size(44, 16);
            this.lblArtCodigo.TabIndex = 3;
            this.lblArtCodigo.Text = "label3";
            // 
            // lblArtDescripcion
            // 
            this.lblArtDescripcion.AutoSize = true;
            this.lblArtDescripcion.Location = new System.Drawing.Point(40, 201);
            this.lblArtDescripcion.Name = "lblArtDescripcion";
            this.lblArtDescripcion.Size = new System.Drawing.Size(44, 16);
            this.lblArtDescripcion.TabIndex = 4;
            this.lblArtDescripcion.Text = "label4";
            // 
            // lblArtMarca
            // 
            this.lblArtMarca.AutoSize = true;
            this.lblArtMarca.Location = new System.Drawing.Point(40, 249);
            this.lblArtMarca.Name = "lblArtMarca";
            this.lblArtMarca.Size = new System.Drawing.Size(44, 16);
            this.lblArtMarca.TabIndex = 5;
            this.lblArtMarca.Text = "label5";
            // 
            // lblArtCategoria
            // 
            this.lblArtCategoria.AutoSize = true;
            this.lblArtCategoria.Location = new System.Drawing.Point(40, 301);
            this.lblArtCategoria.Name = "lblArtCategoria";
            this.lblArtCategoria.Size = new System.Drawing.Size(96, 16);
            this.lblArtCategoria.TabIndex = 6;
            this.lblArtCategoria.Text = "lblArtCategoria";
            // 
            // lblArtPrecio
            // 
            this.lblArtPrecio.AutoSize = true;
            this.lblArtPrecio.Location = new System.Drawing.Point(40, 353);
            this.lblArtPrecio.Name = "lblArtPrecio";
            this.lblArtPrecio.Size = new System.Drawing.Size(44, 16);
            this.lblArtPrecio.TabIndex = 7;
            this.lblArtPrecio.Text = "label7";
            // 
            // Detalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 474);
            this.Controls.Add(this.lblArtPrecio);
            this.Controls.Add(this.lblArtCategoria);
            this.Controls.Add(this.lblArtMarca);
            this.Controls.Add(this.lblArtDescripcion);
            this.Controls.Add(this.lblArtCodigo);
            this.Controls.Add(this.lblArtId);
            this.Controls.Add(this.lblArtNombre);
            this.Controls.Add(this.pbArt);
            this.Name = "Detalle";
            this.Text = "Detalle";
            this.Load += new System.EventHandler(this.Detalle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbArt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbArt;
        private System.Windows.Forms.Label lblArtNombre;
        private System.Windows.Forms.Label lblArtId;
        private System.Windows.Forms.Label lblArtCodigo;
        private System.Windows.Forms.Label lblArtDescripcion;
        private System.Windows.Forms.Label lblArtMarca;
        private System.Windows.Forms.Label lblArtCategoria;
        private System.Windows.Forms.Label lblArtPrecio;
    }
}