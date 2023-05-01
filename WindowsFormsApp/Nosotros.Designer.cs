namespace WindowsFormsApp
{
    partial class Nosotros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Nosotros));
            this.menu = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nosotrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pbNosotros = new System.Windows.Forms.PictureBox();
            this.dgbNosotros = new System.Windows.Forms.DataGridView();
            this.menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbNosotros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgbNosotros)).BeginInit();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.productosToolStripMenuItem,
            this.nosotrosToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menu.Size = new System.Drawing.Size(1487, 24);
            this.menu.TabIndex = 3;
            this.menu.Text = "menu";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.productosToolStripMenuItem.Text = "Productos";
            this.productosToolStripMenuItem.Click += new System.EventHandler(this.productosToolStripMenuItem_Click);
            // 
            // nosotrosToolStripMenuItem
            // 
            this.nosotrosToolStripMenuItem.Name = "nosotrosToolStripMenuItem";
            this.nosotrosToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.nosotrosToolStripMenuItem.Text = "Nosotros";
            // 
            // pbNosotros
            // 
            this.pbNosotros.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbNosotros.ErrorImage = null;
            this.pbNosotros.InitialImage = null;
            this.pbNosotros.Location = new System.Drawing.Point(415, 153);
            this.pbNosotros.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbNosotros.Name = "pbNosotros";
            this.pbNosotros.Size = new System.Drawing.Size(468, 292);
            this.pbNosotros.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbNosotros.TabIndex = 7;
            this.pbNosotros.TabStop = false;
            // 
            // dgbNosotros
            // 
            this.dgbNosotros.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgbNosotros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgbNosotros.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgbNosotros.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgbNosotros.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgbNosotros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgbNosotros.Location = new System.Drawing.Point(483, 464);
            this.dgbNosotros.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgbNosotros.Name = "dgbNosotros";
            this.dgbNosotros.Size = new System.Drawing.Size(400, 123);
            this.dgbNosotros.TabIndex = 8;
            this.dgbNosotros.SelectionChanged += new System.EventHandler(this.dgbNosotros_SelectionChanged);
            // 
            // Nosotros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1487, 613);
            this.Controls.Add(this.dgbNosotros);
            this.Controls.Add(this.pbNosotros);
            this.Controls.Add(this.menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Nosotros";
            this.Text = "Wardrobe";
            this.Load += new System.EventHandler(this.Nosotros_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbNosotros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgbNosotros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nosotrosToolStripMenuItem;
        private System.Windows.Forms.PictureBox pbNosotros;
        private System.Windows.Forms.DataGridView dgbNosotros;
    }
}