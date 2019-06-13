namespace AnalisisMedicos
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroDeAnalisisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ConcultaAnalisisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroDeAnalisisToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaDeAnalisisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.registroDeAnalisisToolStripMenuItem,
            this.ConcultaAnalisisToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(20, 60);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(484, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // registroDeAnalisisToolStripMenuItem
            // 
            this.registroDeAnalisisToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroDeAnalisisToolStripMenuItem1});
            this.registroDeAnalisisToolStripMenuItem.Name = "registroDeAnalisisToolStripMenuItem";
            this.registroDeAnalisisToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.registroDeAnalisisToolStripMenuItem.Text = "Registro";
            // 
            // ConcultaAnalisisToolStripMenuItem
            // 
            this.ConcultaAnalisisToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultaDeAnalisisToolStripMenuItem});
            this.ConcultaAnalisisToolStripMenuItem.Name = "ConcultaAnalisisToolStripMenuItem";
            this.ConcultaAnalisisToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.ConcultaAnalisisToolStripMenuItem.Text = "Conculta ";
            // 
            // registroDeAnalisisToolStripMenuItem1
            // 
            this.registroDeAnalisisToolStripMenuItem1.Name = "registroDeAnalisisToolStripMenuItem1";
            this.registroDeAnalisisToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.registroDeAnalisisToolStripMenuItem1.Text = "Registro de Analisis";
            this.registroDeAnalisisToolStripMenuItem1.Click += new System.EventHandler(this.RegistroDeAnalisisToolStripMenuItem1_Click);
            // 
            // consultaDeAnalisisToolStripMenuItem
            // 
            this.consultaDeAnalisisToolStripMenuItem.Name = "consultaDeAnalisisToolStripMenuItem";
            this.consultaDeAnalisisToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.consultaDeAnalisisToolStripMenuItem.Text = "Consulta de Analisis";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 401);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Sistema de Analisis Medicos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroDeAnalisisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ConcultaAnalisisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroDeAnalisisToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem consultaDeAnalisisToolStripMenuItem;
    }
}

