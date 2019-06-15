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
    public partial class TipoAnalisis : MetroFramework.Forms.MetroForm
    {
        public TipoAnalisis()
        {
            InitializeComponent();
        }

        private void TipoAnalisis_Load(object sender, EventArgs e)
        {

        }

        private TiposAnalisis LlenarClase()
        {
            TiposAnalisis tipo = new TiposAnalisis
            {
                TipoId = (int)IDnumericUpDown.Value,
                Descripcion = DescripcionmetroTextBox.Text
            };

            return tipo;
        }

        private bool Validar()
        {
            bool paso = true;
            errorProvider.Clear();

            if (string.IsNullOrWhiteSpace(DescripcionmetroTextBox.Text))
            {
                errorProvider.SetError(DescripcionmetroTextBox, "Este campo no puede estar en blanco");
                paso = false;
            }


            return paso;
        }

        private void LlenarCampos(TiposAnalisis tipo)
        {
            IDnumericUpDown.Value = tipo.TipoId;
            DescripcionmetroTextBox.Text = tipo.Descripcion;
        }

        private void Limpiar()
        {
            IDnumericUpDown.Value = 0;
            DescripcionmetroTextBox.Text = string.Empty;
        }

        private void NuevometroButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void BuscarmetroButton_Click(object sender, EventArgs e)
        {
            TiposAnalisis tipo = new TiposAnalisis();

            try
            {
                tipo = TipoAnalisisBLL.Buscar((int)IDnumericUpDown.Value);

                if (tipo != null)
                {
                    Limpiar();
                    LlenarCampos(tipo);
                }
                else
                {
                    MessageBox.Show("Tipo de analisis no encontrado");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }

        }

        private void GuardarmetroButton_Click(object sender, EventArgs e)
        {
            if (!Validar())
                return;

            TiposAnalisis tipo = new TiposAnalisis();
            tipo = LlenarClase();

            try
            {
                if (TipoAnalisisBLL.Buscar((int)IDnumericUpDown.Value) != null)
                {
                    TipoAnalisisBLL.Modificar(tipo);
                    MessageBox.Show("Modificado Correctamente");
                    Limpiar();
                }
                else
                {
                    if (IDnumericUpDown.Value == 0)
                    {
                        if (!TipoAnalisisBLL.Duplicado(DescripcionmetroTextBox.Text))
                        {
                            TipoAnalisisBLL.Guardar(tipo);
                            MessageBox.Show("Se guardo correctamente");
                            Limpiar();
                        }
                        else
                        {
                            errorProvider.SetError(DescripcionmetroTextBox, "Este Tipo ya existe");
                        }

                    }
                }
            }

    }

        private void EliminarmetroButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (TipoAnalisisBLL.Buscar((int)IDnumericUpDown.Value) == null)
                {
                    MessageBox.Show("No se puede eliminar");
                }
                else
                {
                    TipoAnalisisBLL.Eliminar((int)IDnumericUpDown.Value);
                    MessageBox.Show("Eliminado correctamente");
                    Limpiar();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }
    }
