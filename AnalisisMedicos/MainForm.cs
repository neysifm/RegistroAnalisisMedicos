﻿using AnalisisMedicos.UI.Registros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnalisisMedicos
{
    public partial class MainForm : MetroFramework.Forms.MetroForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void RegistroDeAnalisisToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RegistroAnalisisMedicos Ram = new RegistroAnalisisMedicos();
            Ram.ShowDialog();
        }
    }
}
