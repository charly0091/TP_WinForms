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
            this.menu = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nosotroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nosotrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnVerDetalle = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminarFisico = new System.Windows.Forms.Button();
            this.btnEliminarLogico = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgbArt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbArt)).BeginInit();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgbArt
            // 
            this.dgbArt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgbArt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgbArt.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgbArt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgbArt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgbArt.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgbArt.Location = new System.Drawing.Point(437, 123);
            this.dgbArt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgbArt.MultiSelect = false;
            this.dgbArt.Name = "dgbArt";
            this.dgbArt.RowHeadersWidth = 51;
            this.dgbArt.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgbArt.Size = new System.Drawing.Size(753, 329);
            this.dgbArt.TabIndex = 0;
            this.dgbArt.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgbArt_CellContentClick);
            this.dgbArt.SelectionChanged += new System.EventHandler(this.dgbArt_SelectionChanged);
            // 
            // pbArt
            // 
            this.pbArt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbArt.Location = new System.Drawing.Point(36, 123);
            this.pbArt.Margin = new System.Windows.Forms.Padding(4);
            this.pbArt.Name = "pbArt";
            this.pbArt.Size = new System.Drawing.Size(380, 327);
            this.pbArt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbArt.TabIndex = 1;
            this.pbArt.TabStop = false;
            // 
            // menu
            // 
            this.menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.productosToolStripMenuItem,
            this.categoriasToolStripMenuItem,
            this.nosotroToolStripMenuItem,
            this.nosotrosToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menu.Size = new System.Drawing.Size(1243, 28);
            this.menu.TabIndex = 2;
            this.menu.Text = "menu";
            this.menu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menu_ItemClicked);
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
            this.productosToolStripMenuItem.Text = "Productos";
            // 
            // categoriasToolStripMenuItem
            // 
            this.categoriasToolStripMenuItem.Name = "categoriasToolStripMenuItem";
            this.categoriasToolStripMenuItem.Size = new System.Drawing.Size(94, 24);
            this.categoriasToolStripMenuItem.Text = "Categorias";
            this.categoriasToolStripMenuItem.Click += new System.EventHandler(this.categoriasToolStripMenuItem_click);
            // 
            // nosotroToolStripMenuItem
            // 
            this.nosotroToolStripMenuItem.Name = "nosotroToolStripMenuItem";
            this.nosotroToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.nosotroToolStripMenuItem.Text = "Marcas";
            this.nosotroToolStripMenuItem.Click += new System.EventHandler(this.marcasToolStripMenuItem_Click);
            // 
            // nosotrosToolStripMenuItem
            // 
            this.nosotrosToolStripMenuItem.Name = "nosotrosToolStripMenuItem";
            this.nosotrosToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.nosotrosToolStripMenuItem.Text = "Nosotros";
            this.nosotrosToolStripMenuItem.Click += new System.EventHandler(this.nosotrosToolStripMenuItem_Click);
            // 
            // btnVerDetalle
            // 
            this.btnVerDetalle.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnVerDetalle.Location = new System.Drawing.Point(591, 516);
            this.btnVerDetalle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVerDetalle.Name = "btnVerDetalle";
            this.btnVerDetalle.Size = new System.Drawing.Size(120, 34);
            this.btnVerDetalle.TabIndex = 4;
            this.btnVerDetalle.Text = "Ver detalle";
            this.btnVerDetalle.UseVisualStyleBackColor = true;
            this.btnVerDetalle.Click += new System.EventHandler(this.btnVerDetalle_Click_1);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAgregar.Location = new System.Drawing.Point(437, 465);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(100, 28);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnModificar.Location = new System.Drawing.Point(545, 465);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(100, 28);
            this.btnModificar.TabIndex = 8;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminarFisico
            // 
            this.btnEliminarFisico.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEliminarFisico.Location = new System.Drawing.Point(653, 465);
            this.btnEliminarFisico.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminarFisico.Name = "btnEliminarFisico";
            this.btnEliminarFisico.Size = new System.Drawing.Size(111, 28);
            this.btnEliminarFisico.TabIndex = 9;
            this.btnEliminarFisico.Text = "Eliminar fisico";
            this.btnEliminarFisico.UseVisualStyleBackColor = true;
            this.btnEliminarFisico.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEliminarLogico
            // 
            this.btnEliminarLogico.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEliminarLogico.Location = new System.Drawing.Point(772, 465);
            this.btnEliminarLogico.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminarLogico.Name = "btnEliminarLogico";
            this.btnEliminarLogico.Size = new System.Drawing.Size(110, 28);
            this.btnEliminarLogico.TabIndex = 11;
            this.btnEliminarLogico.Text = "Eliminar logico";
            this.btnEliminarLogico.UseVisualStyleBackColor = true;
            this.btnEliminarLogico.Click += new System.EventHandler(this.btnEliminarLogico_Click);
            // 
            // Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1243, 586);
            this.Controls.Add(this.btnEliminarLogico);
            this.Controls.Add(this.btnEliminarFisico);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnVerDetalle);
            this.Controls.Add(this.pbArt);
            this.Controls.Add(this.dgbArt);
            this.Controls.Add(this.menu);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menu;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Productos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wardrobe";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Productos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgbArt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbArt)).EndInit();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgbArt;
        private System.Windows.Forms.PictureBox pbArt;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nosotroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nosotrosToolStripMenuItem;
        private System.Windows.Forms.Button btnVerDetalle;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminarFisico;
        private System.Windows.Forms.Button btnEliminarLogico;
    }
}

