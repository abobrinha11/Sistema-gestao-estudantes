namespace sistema_gestao_estudantes
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.eSTUDANTEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inserirEstudanteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaEstudanteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarRemoverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estatísticasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerenciarEstudantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cURSOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nOTASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LavenderBlush;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eSTUDANTEToolStripMenuItem,
            this.cURSOToolStripMenuItem,
            this.nOTASToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(501, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // eSTUDANTEToolStripMenuItem
            // 
            this.eSTUDANTEToolStripMenuItem.BackColor = System.Drawing.Color.HotPink;
            this.eSTUDANTEToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inserirEstudanteToolStripMenuItem,
            this.listaEstudanteToolStripMenuItem,
            this.editarRemoverToolStripMenuItem,
            this.estatísticasToolStripMenuItem,
            this.gerenciarEstudantesToolStripMenuItem,
            this.imprimirToolStripMenuItem});
            this.eSTUDANTEToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("eSTUDANTEToolStripMenuItem.Image")));
            this.eSTUDANTEToolStripMenuItem.Name = "eSTUDANTEToolStripMenuItem";
            this.eSTUDANTEToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.eSTUDANTEToolStripMenuItem.Text = "ESTUDANTE";
            // 
            // inserirEstudanteToolStripMenuItem
            // 
            this.inserirEstudanteToolStripMenuItem.BackColor = System.Drawing.Color.HotPink;
            this.inserirEstudanteToolStripMenuItem.Image = global::sistema_gestao_estudantes.Properties.Resources.sombrero_icone;
            this.inserirEstudanteToolStripMenuItem.Name = "inserirEstudanteToolStripMenuItem";
            this.inserirEstudanteToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.inserirEstudanteToolStripMenuItem.Text = "Inserir Estudante";
            this.inserirEstudanteToolStripMenuItem.Click += new System.EventHandler(this.inserirEstudanteToolStripMenuItem_Click);
            // 
            // listaEstudanteToolStripMenuItem
            // 
            this.listaEstudanteToolStripMenuItem.BackColor = System.Drawing.Color.HotPink;
            this.listaEstudanteToolStripMenuItem.Name = "listaEstudanteToolStripMenuItem";
            this.listaEstudanteToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.listaEstudanteToolStripMenuItem.Text = "Listar Estudantes";
            this.listaEstudanteToolStripMenuItem.Click += new System.EventHandler(this.listaEstudanteToolStripMenuItem_Click);
            // 
            // editarRemoverToolStripMenuItem
            // 
            this.editarRemoverToolStripMenuItem.BackColor = System.Drawing.Color.HotPink;
            this.editarRemoverToolStripMenuItem.Name = "editarRemoverToolStripMenuItem";
            this.editarRemoverToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.editarRemoverToolStripMenuItem.Text = "Editar/Remover";
            // 
            // estatísticasToolStripMenuItem
            // 
            this.estatísticasToolStripMenuItem.BackColor = System.Drawing.Color.HotPink;
            this.estatísticasToolStripMenuItem.Name = "estatísticasToolStripMenuItem";
            this.estatísticasToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.estatísticasToolStripMenuItem.Text = "Estatísticas";
            // 
            // gerenciarEstudantesToolStripMenuItem
            // 
            this.gerenciarEstudantesToolStripMenuItem.BackColor = System.Drawing.Color.HotPink;
            this.gerenciarEstudantesToolStripMenuItem.Name = "gerenciarEstudantesToolStripMenuItem";
            this.gerenciarEstudantesToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.gerenciarEstudantesToolStripMenuItem.Text = "Gerenciar Estudantes";
            // 
            // imprimirToolStripMenuItem
            // 
            this.imprimirToolStripMenuItem.BackColor = System.Drawing.Color.HotPink;
            this.imprimirToolStripMenuItem.Name = "imprimirToolStripMenuItem";
            this.imprimirToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.imprimirToolStripMenuItem.Text = "Imprimir";
            // 
            // cURSOToolStripMenuItem
            // 
            this.cURSOToolStripMenuItem.BackColor = System.Drawing.Color.HotPink;
            this.cURSOToolStripMenuItem.Name = "cURSOToolStripMenuItem";
            this.cURSOToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.cURSOToolStripMenuItem.Text = "CURSO";
            // 
            // nOTASToolStripMenuItem
            // 
            this.nOTASToolStripMenuItem.BackColor = System.Drawing.Color.HotPink;
            this.nOTASToolStripMenuItem.Name = "nOTASToolStripMenuItem";
            this.nOTASToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.nOTASToolStripMenuItem.Text = "NOTAS";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(501, 375);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormPrincipal";
            this.Text = "SGA - Início";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem eSTUDANTEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inserirEstudanteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaEstudanteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estatísticasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarRemoverToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imprimirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cURSOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nOTASToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerenciarEstudantesToolStripMenuItem;
    }
}