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
            this.pbArt.Location = new System.Drawing.Point(72, 109);
            this.pbArt.Margin = new System.Windows.Forms.Padding(2);
            this.pbArt.Name = "pbArt";
            this.pbArt.Size = new System.Drawing.Size(312, 340);
            this.pbArt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbArt.TabIndex = 0;
            this.pbArt.TabStop = false;
            // 
            // lblArtNombre
            // 
            this.lblArtNombre.AutoSize = true;
            this.lblArtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArtNombre.Location = new System.Drawing.Point(517, 108);
            this.lblArtNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblArtNombre.Name = "lblArtNombre";
            this.lblArtNombre.Size = new System.Drawing.Size(96, 26);
            this.lblArtNombre.TabIndex = 1;
            this.lblArtNombre.Text = "Nombre";
            // 
            // lblArtId
            // 
            this.lblArtId.AutoSize = true;
            this.lblArtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArtId.Location = new System.Drawing.Point(419, 161);
            this.lblArtId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblArtId.Name = "lblArtId";
            this.lblArtId.Size = new System.Drawing.Size(22, 18);
            this.lblArtId.TabIndex = 2;
            this.lblArtId.Text = "ID";
            // 
            // lblArtCodigo
            // 
            this.lblArtCodigo.AutoSize = true;
            this.lblArtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArtCodigo.Location = new System.Drawing.Point(419, 201);
            this.lblArtCodigo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblArtCodigo.Name = "lblArtCodigo";
            this.lblArtCodigo.Size = new System.Drawing.Size(56, 18);
            this.lblArtCodigo.TabIndex = 3;
            this.lblArtCodigo.Text = "Codigo";
            // 
            // lblArtDescripcion
            // 
            this.lblArtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArtDescripcion.Location = new System.Drawing.Point(419, 364);
            this.lblArtDescripcion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblArtDescripcion.Name = "lblArtDescripcion";
            this.lblArtDescripcion.Size = new System.Drawing.Size(258, 84);
            this.lblArtDescripcion.TabIndex = 4;
            this.lblArtDescripcion.Text = "Descripción";
            // 
            // lblArtMarca
            // 
            this.lblArtMarca.AutoSize = true;
            this.lblArtMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArtMarca.Location = new System.Drawing.Point(419, 283);
            this.lblArtMarca.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblArtMarca.Name = "lblArtMarca";
            this.lblArtMarca.Size = new System.Drawing.Size(50, 18);
            this.lblArtMarca.TabIndex = 5;
            this.lblArtMarca.Text = "Marca";
            // 
            // lblArtCategoria
            // 
            this.lblArtCategoria.AutoSize = true;
            this.lblArtCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArtCategoria.Location = new System.Drawing.Point(419, 323);
            this.lblArtCategoria.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblArtCategoria.Name = "lblArtCategoria";
            this.lblArtCategoria.Size = new System.Drawing.Size(72, 18);
            this.lblArtCategoria.TabIndex = 6;
            this.lblArtCategoria.Text = "Categoria";
            // 
            // lblArtPrecio
            // 
            this.lblArtPrecio.AutoSize = true;
            this.lblArtPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArtPrecio.Location = new System.Drawing.Point(419, 242);
            this.lblArtPrecio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblArtPrecio.Name = "lblArtPrecio";
            this.lblArtPrecio.Size = new System.Drawing.Size(51, 18);
            this.lblArtPrecio.TabIndex = 7;
            this.lblArtPrecio.Text = "Precio";
            // 
            // Detalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.lblArtPrecio);
            this.Controls.Add(this.lblArtCategoria);
            this.Controls.Add(this.lblArtMarca);
            this.Controls.Add(this.lblArtDescripcion);
            this.Controls.Add(this.lblArtCodigo);
            this.Controls.Add(this.lblArtId);
            this.Controls.Add(this.lblArtNombre);
            this.Controls.Add(this.pbArt);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Detalle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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