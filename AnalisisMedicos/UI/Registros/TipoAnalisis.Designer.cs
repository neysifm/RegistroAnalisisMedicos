namespace AnalisisMedicos.UI.Registros
{
    partial class TipoAnalisis
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
            this.components = new System.ComponentModel.Container();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.IDnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.DescripcionmetroTextBox = new MetroFramework.Controls.MetroTextBox();
            this.BuscarmetroButton = new MetroFramework.Controls.MetroButton();
            this.NuevometroButton = new MetroFramework.Controls.MetroButton();
            this.GuardarmetroButton = new MetroFramework.Controls.MetroButton();
            this.EliminarmetroButton = new MetroFramework.Controls.MetroButton();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.IDnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(62, 80);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(24, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "ID:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(62, 139);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(79, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Descripcion:";
            // 
            // IDnumericUpDown
            // 
            this.IDnumericUpDown.Location = new System.Drawing.Point(147, 80);
            this.IDnumericUpDown.Name = "IDnumericUpDown";
            this.IDnumericUpDown.Size = new System.Drawing.Size(60, 20);
            this.IDnumericUpDown.TabIndex = 2;
            // 
            // DescripcionmetroTextBox
            // 
            // 
            // 
            // 
            this.DescripcionmetroTextBox.CustomButton.Image = null;
            this.DescripcionmetroTextBox.CustomButton.Location = new System.Drawing.Point(179, 1);
            this.DescripcionmetroTextBox.CustomButton.Name = "";
            this.DescripcionmetroTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.DescripcionmetroTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.DescripcionmetroTextBox.CustomButton.TabIndex = 1;
            this.DescripcionmetroTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.DescripcionmetroTextBox.CustomButton.UseSelectable = true;
            this.DescripcionmetroTextBox.CustomButton.Visible = false;
            this.DescripcionmetroTextBox.Lines = new string[0];
            this.DescripcionmetroTextBox.Location = new System.Drawing.Point(147, 139);
            this.DescripcionmetroTextBox.MaxLength = 32767;
            this.DescripcionmetroTextBox.Name = "DescripcionmetroTextBox";
            this.DescripcionmetroTextBox.PasswordChar = '\0';
            this.DescripcionmetroTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.DescripcionmetroTextBox.SelectedText = "";
            this.DescripcionmetroTextBox.SelectionLength = 0;
            this.DescripcionmetroTextBox.SelectionStart = 0;
            this.DescripcionmetroTextBox.ShortcutsEnabled = true;
            this.DescripcionmetroTextBox.Size = new System.Drawing.Size(201, 23);
            this.DescripcionmetroTextBox.TabIndex = 3;
            this.DescripcionmetroTextBox.UseSelectable = true;
            this.DescripcionmetroTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.DescripcionmetroTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // BuscarmetroButton
            // 
            this.BuscarmetroButton.Location = new System.Drawing.Point(213, 80);
            this.BuscarmetroButton.Name = "BuscarmetroButton";
            this.BuscarmetroButton.Size = new System.Drawing.Size(75, 20);
            this.BuscarmetroButton.TabIndex = 4;
            this.BuscarmetroButton.Text = "Buscar";
            this.BuscarmetroButton.UseSelectable = true;
            this.BuscarmetroButton.Click += new System.EventHandler(this.BuscarmetroButton_Click);
            // 
            // NuevometroButton
            // 
            this.NuevometroButton.Location = new System.Drawing.Point(66, 211);
            this.NuevometroButton.Name = "NuevometroButton";
            this.NuevometroButton.Size = new System.Drawing.Size(75, 23);
            this.NuevometroButton.TabIndex = 5;
            this.NuevometroButton.Text = "Nuevo";
            this.NuevometroButton.UseSelectable = true;
            this.NuevometroButton.Click += new System.EventHandler(this.NuevometroButton_Click);
            // 
            // GuardarmetroButton
            // 
            this.GuardarmetroButton.Location = new System.Drawing.Point(171, 211);
            this.GuardarmetroButton.Name = "GuardarmetroButton";
            this.GuardarmetroButton.Size = new System.Drawing.Size(75, 23);
            this.GuardarmetroButton.TabIndex = 6;
            this.GuardarmetroButton.Text = "Guardar";
            this.GuardarmetroButton.UseSelectable = true;
            this.GuardarmetroButton.Click += new System.EventHandler(this.GuardarmetroButton_Click);
            // 
            // EliminarmetroButton
            // 
            this.EliminarmetroButton.Location = new System.Drawing.Point(273, 211);
            this.EliminarmetroButton.Name = "EliminarmetroButton";
            this.EliminarmetroButton.Size = new System.Drawing.Size(75, 23);
            this.EliminarmetroButton.TabIndex = 7;
            this.EliminarmetroButton.Text = "Eliminar";
            this.EliminarmetroButton.UseSelectable = true;
            this.EliminarmetroButton.Click += new System.EventHandler(this.EliminarmetroButton_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // TipoAnalisis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 299);
            this.Controls.Add(this.EliminarmetroButton);
            this.Controls.Add(this.GuardarmetroButton);
            this.Controls.Add(this.NuevometroButton);
            this.Controls.Add(this.BuscarmetroButton);
            this.Controls.Add(this.DescripcionmetroTextBox);
            this.Controls.Add(this.IDnumericUpDown);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "TipoAnalisis";
            this.Text = "Tipos de Analisis";
            ((System.ComponentModel.ISupportInitialize)(this.IDnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.NumericUpDown IDnumericUpDown;
        private MetroFramework.Controls.MetroTextBox DescripcionmetroTextBox;
        private MetroFramework.Controls.MetroButton BuscarmetroButton;
        private MetroFramework.Controls.MetroButton NuevometroButton;
        private MetroFramework.Controls.MetroButton GuardarmetroButton;
        private MetroFramework.Controls.MetroButton EliminarmetroButton;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}