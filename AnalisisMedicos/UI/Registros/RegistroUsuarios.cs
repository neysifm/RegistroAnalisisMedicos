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
    public partial class RegistroUsuarios : MetroFramework.Forms.MetroForm
    {
        public RegistroUsuarios()
        {
            InitializeComponent();
        }

        private void LLenarCampos(Usuarios usuarios)
        {
            IDnumericUpDown.Value = usuarios.UsuariosId;
            NombreTextBox.Text = usuarios.Nombres;
            DireccionTextBox.Text = usuarios.Direccion;
            TelefonoTextBox.Text = usuarios.Telefono;
        }

        private Usuarios LlenarClase()
        {
            Usuarios usuarios = new Usuarios
            {
                UsuariosId = (int)IDnumericUpDown.Value,
                Nombres = NombreTextBox.Text,
                Direccion = DireccionTextBox.Text,
                Telefono = TelefonoTextBox.Text
            };

            return usuarios;
        }

        private bool Validar()
        {
            errorProvider.Clear();
            bool paso = true;

            if (string.IsNullOrWhiteSpace(NombreTextBox.Text))
            {
                errorProvider.SetError(NombreTextBox, "Debe llenar este campo");
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(DireccionTextBox.Text))
            {
                errorProvider.SetError(DireccionTextBox, "Debe llenar este campo");
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(TelefonoTextBox.Text))
            {
                errorProvider.SetError(TelefonoTextBox, "Debe llenar este campo");
                paso = false;
            }

            return paso;
        }

        private void Limpiar()
        {
            IDnumericUpDown.Value = 0;
            NombreTextBox.Text = string.Empty;
            DireccionTextBox.Text = string.Empty;
            TelefonoTextBox.Text = string.Empty;
        }

        private void NuevometroButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void BuscarmetroButton_Click(object sender, EventArgs e)
        {
            Usuarios usuario;
            try
            {
                usuario = UsuariosBLL.Buscar((int)IDnumericUpDown.Value);
                if (usuario != null)
                {
                    Limpiar();
                    LLenarCampos(usuario);
                }
                else
                {
                    MessageBox.Show("No se encontro el usuario");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al buscar el usuario");
            }
        }

        private void EliminarmetroButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (UsuariosBLL.Buscar((int)IDnumericUpDown.Value) == null)
                {
                    MessageBox.Show("No se puede borrar usuario");
                }
                else
                {

                    UsuariosBLL.Eliminar((int)IDnumericUpDown.Value);
                    MessageBox.Show("Eliminado correctamente");
                    Limpiar();

                }
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo eliminar el usuario");
            }
        }

        private void GuardarmetroButton_Click(object sender, EventArgs e)
        {
            if (IDnumericUpDown.Value > 0)
            {
                if (Validar())
                {
                    if (UsuariosBLL.Modificar(LlenarClase()))
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
                    if (UsuariosBLL.Guardar(LlenarClase()) == true)
                    {
                        MessageBox.Show("El registro se guardo correctamente");
                        Limpiar();
                        return;
                    }
                }
            }
            MessageBox.Show("Error al intentar guardar o modificar el registro!");
        }
    }
}
