namespace prjRestaurante.visao
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.menu = new System.Windows.Forms.MenuStrip();
            this.mnProdutos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnMesas = new System.Windows.Forms.ToolStripMenuItem();
            this.mnCardapios = new System.Windows.Forms.ToolStripMenuItem();
            this.mnSair = new System.Windows.Forms.ToolStripMenuItem();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Dock = System.Windows.Forms.DockStyle.Right;
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnProdutos,
            this.mnMesas,
            this.mnCardapios,
            this.mnSair});
            this.menu.Location = new System.Drawing.Point(707, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(89, 540);
            this.menu.TabIndex = 1;
            this.menu.Text = "menuStrip1";
            // 
            // mnProdutos
            // 
            this.mnProdutos.Image = ((System.Drawing.Image)(resources.GetObject("mnProdutos.Image")));
            this.mnProdutos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnProdutos.Name = "mnProdutos";
            this.mnProdutos.Size = new System.Drawing.Size(76, 67);
            this.mnProdutos.Text = "PRODUTOS";
            this.mnProdutos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.mnProdutos.Click += new System.EventHandler(this.mnProdutos_Click);
            // 
            // mnMesas
            // 
            this.mnMesas.Image = ((System.Drawing.Image)(resources.GetObject("mnMesas.Image")));
            this.mnMesas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnMesas.Name = "mnMesas";
            this.mnMesas.Size = new System.Drawing.Size(76, 67);
            this.mnMesas.Text = "MESAS";
            this.mnMesas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // mnCardapios
            // 
            this.mnCardapios.Image = ((System.Drawing.Image)(resources.GetObject("mnCardapios.Image")));
            this.mnCardapios.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnCardapios.Name = "mnCardapios";
            this.mnCardapios.Size = new System.Drawing.Size(76, 67);
            this.mnCardapios.Text = "CARDÁPIOS";
            this.mnCardapios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // mnSair
            // 
            this.mnSair.Image = ((System.Drawing.Image)(resources.GetObject("mnSair.Image")));
            this.mnSair.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnSair.Name = "mnSair";
            this.mnSair.Size = new System.Drawing.Size(76, 67);
            this.mnSair.Text = "SAIR";
            this.mnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.mnSair.Click += new System.EventHandler(this.mnSair_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 540);
            this.Controls.Add(this.menu);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menu;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimizeBox = false;
            this.Name = "FormPrincipal";
            this.ShowIcon = false;
            this.Text = "Controle de Restaurante V1.0";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem mnProdutos;
        private System.Windows.Forms.ToolStripMenuItem mnMesas;
        private System.Windows.Forms.ToolStripMenuItem mnCardapios;
        private System.Windows.Forms.ToolStripMenuItem mnSair;
    }
}