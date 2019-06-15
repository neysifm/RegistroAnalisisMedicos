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

        private void ActualizarGrip()
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
            ActualizarGrip();
        }

        private void LlenarCampos(Analisis analisis)
        {
            Limpiar();
            IDnumericUpDown.Value = analisis.AnalisisId;
            FechametroDateTime.Value = analisis.Fecha;
            UsuariometroComboBox.SelectedValue = analisis.UsuarioId;
            this.Detalles = analisis.AnalisisDetalle;
            ActualizarGrip();

        }

        private Analisis LlenarClase()
        {
            Analisis analisis = new Analisis
            {
                AnalisisId = (int)IDnumericUpDown.Value,
                Fecha = FechametroDateTime.Value,
                UsuarioId = (int)UsuariometroComboBox.SelectedValue,
                AnalisisDetalle = this.Detalles
            };
            return analisis;
        }

        private bool Validar()
        {
            bool paso = true;
            errorProvider.Clear();

            if (Detalles.Count == 0)
            {
                MessageBox.Show("Debe agregar analiis para guardar");
            }
            return paso;
        }

        private void BuscarmetroButton_Click(object sender, EventArgs e)
        {
            try
            {
                Analisis analisis;
                analisis = AnalisisBLL.Buscar((int)IDnumericUpDown.Value);
                if (analisis != null)
                {
                    Limpiar();
                    LlenarCampos(analisis);
                }
                else
                {
                    MessageBox.Show("No se encontro el analisis");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("ERROR");
            }
        }

        private void RegistroAnalisisMedicos_Load(object sender, EventArgs e)
        {

        }

        private void GuardarmetroButton_Click(object sender, EventArgs e)
        {
            if (IDnumericUpDown.Value > 0)
            {
                if (Validar())
                {
                    if (AnalisisBLL.Modificar(LlenarClase()))
                    {
                        MessageBox.Show("El registro se actualizo correctamente");
                        Limpiar();
                        return;
                    }
                }
            }
            else
            {
                if (Validar())
                {
                    if (AnalisisBLL.Guardar(LlenarClase()) == true)
                    {
                        MessageBox.Show("El registro se guardo correctamente");
                        Limpiar();
                        return;
                    }
                }
            }
            MessageBox.Show("Error al intentar guardar o modificar el registro!");
        }

        private void EliminarmetroButton_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                if (AnalisisBLL.Eliminar(Convert.ToInt32(IDnumericUpDown.Value)))
                {
                    MessageBox.Show("Registro Eliminado Correctamente!");
                    Limpiar();
                    return;
                }
                MessageBox.Show("Error al intentar eliminar el registro!");
            }
        }
    }
}

