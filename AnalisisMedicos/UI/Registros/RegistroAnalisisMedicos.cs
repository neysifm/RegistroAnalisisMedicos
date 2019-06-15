using AnalisisMedicos.BLL;
using AnalisisMedicos.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnalisisMedicos.UI.Registros
{
    public partial class RegistroAnalisisMedicos : MetroFramework.Forms.MetroForm
    {
        public RegistroAnalisisMedicos()
        {
            InitializeComponent();
            Detalles = new List<AnalisisDetalle>();
            CargarUsuarios();
            CargarTipos();
        }

        List<AnalisisDetalle> Detalles;

        private void CargarUsuarios()
        {
            try
            {
                List<Usuarios> Usuarios = new List<Usuarios>();
                Usuarios = UsuariosBLL.GetList(p => true);
                UsuariometroComboBox.DataSource = null;
                UsuariometroComboBox.DataSource = Usuarios;
                UsuariometroComboBox.ValueMember = "UsuarioId";
                UsuariometroComboBox.DisplayMember = "Nombres";
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }

        }

        private void CargarTipos()
        {
            try
            {
                List<TiposAnalisis> tipos = new List<TiposAnalisis>();
                tipos = TipoAnalisisBLL.GetList(p => true);
                AnalisismetroComboBox.DataSource = null;
                AnalisismetroComboBox.DataSource = tipos;
                AnalisismetroComboBox.ValueMember = "TipoId";
                AnalisismetroComboBox.DisplayMember = "Descripcion";
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }


        }

        private void CargarGrip()
        {
            DetallesdataGridView.DataSource = null;
            DetallesdataGridView.DataSource = Detalles;
        }

        private void Limpiar()
        {
            IDnumericUpDown.Value = 0;
            FechametroDateTime.Value = DateTime.Now;
            UsuariometroComboBox.SelectedIndex = 0;
            AnalisismetroComboBox.SelectedIndex = 0;
            ResultadometroTextBox.Text = string.Empty;
            Detalles = new List<AnalisisDetalle>();
            CargarGrip();
        }


     
    }
}
