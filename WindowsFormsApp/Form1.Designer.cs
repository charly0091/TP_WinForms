﻿namespace WindowsFormsApp
{
    partial class Productos
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
            this.dataProd = new System.Windows.Forms.DataGridView();
            this.imgProd = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataProd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgProd)).BeginInit();
            this.SuspendLayout();
            // 
            // dataProd
            // 
            this.dataProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataProd.Location = new System.Drawing.Point(536, 73);
            this.dataProd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataProd.Name = "dataProd";
            this.dataProd.RowHeadersWidth = 51;
            this.dataProd.Size = new System.Drawing.Size(476, 390);
            this.dataProd.TabIndex = 0;
            this.dataProd.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataProd_CellContentClick);
            // 
            // imgProd
            // 
            this.imgProd.Location = new System.Drawing.Point(56, 73);
            this.imgProd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.imgProd.Name = "imgProd";
            this.imgProd.Size = new System.Drawing.Size(453, 390);
            this.imgProd.TabIndex = 1;
            this.imgProd.TabStop = false;
            // 
            // Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.imgProd);
            this.Controls.Add(this.dataProd);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Productos";
            this.Text = "Productos";
            ((System.ComponentModel.ISupportInitialize)(this.dataProd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgProd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataProd;
        private System.Windows.Forms.PictureBox imgProd;
    }
}

