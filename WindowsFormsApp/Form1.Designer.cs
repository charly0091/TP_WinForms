namespace WindowsFormsApp
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
            this.dgbArt = new System.Windows.Forms.DataGridView();
            this.pbArt = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgbArt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbArt)).BeginInit();
            this.SuspendLayout();
            // 
            // dgbArt
            // 
            this.dgbArt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgbArt.Location = new System.Drawing.Point(328, 100);
            this.dgbArt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgbArt.Name = "dgbArt";
            this.dgbArt.RowHeadersWidth = 51;
            this.dgbArt.Size = new System.Drawing.Size(565, 267);
            this.dgbArt.TabIndex = 0;
            this.dgbArt.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgbArt_CellContentClick);
            this.dgbArt.SelectionChanged += new System.EventHandler(this.dgbArt_SelectionChanged);
            // 
            // pbArt
            // 
            this.pbArt.Location = new System.Drawing.Point(27, 100);
            this.pbArt.Name = "pbArt";
            this.pbArt.Size = new System.Drawing.Size(285, 266);
            this.pbArt.TabIndex = 1;
            this.pbArt.TabStop = false;
            // 
            // Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 476);
            this.Controls.Add(this.pbArt);
            this.Controls.Add(this.dgbArt);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Productos";
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.Productos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgbArt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbArt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgbArt;
        private System.Windows.Forms.PictureBox pbArt;
    }
}

