using RegistroLibro.BLL;
using RegistroLibro.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistroLibro.UI.Registrar
{
    public partial class rLibros : Form
    {
        public rLibros()
        {
            InitializeComponent();
        }

        private Libros LlenaClase()
        {
            Libros libros = new Libros();

            libros.LibrosId = Convert.ToInt32(LibrosIdNumericUpDown.Value);
            libros.Fecha = FechaDateTimePicker.Value;
            libros.Descripcion = DescripcionTextBox.Text;
            libros.Siglas = SiglasTextBox.Text;
            libros.Tipo = TipoComboBox.Text;
            return libros;
        }

        private void Limpiar()
        {
            LibrosIdNumericUpDown.Value = 0;
            FechaDateTimePicker.Value = DateTime.Now;
            DescripcionTextBox.Clear();
            SiglasTextBox.Clear();
            TipoComboBox.SelectedIndex = 0;
            MyErrorProvider.Clear();
        }

        private bool HayErrores()
        {
            bool HayErrores = false;

            if (String.IsNullOrWhiteSpace(DescripcionTextBox.Text))
            {
                MyErrorProvider.SetError(DescripcionTextBox,
                    "Escribir La descripcion del Libro");
                HayErrores = true;
            }
            if (String.IsNullOrWhiteSpace(SiglasTextBox.Text))
            {
                MyErrorProvider.SetError(SiglasTextBox,
                    "Escribir las siglas del libro");
                HayErrores = true;
            }

            return HayErrores;
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(LibrosIdNumericUpDown.Value);
            Libros libros = LibrosBLL.Buscar(id);

            if (libros != null)
            {
                DescripcionTextBox.Text = libros.Descripcion;
                SiglasTextBox.Text = libros.Siglas;
                TipoComboBox.Text = libros.Tipo;
                FechaDateTimePicker.Value = libros.Fecha;
            }
            else
                MessageBox.Show("No se encontró!!", "Falló",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(LibrosIdNumericUpDown.Value);
            Libros libros = LibrosBLL.Buscar(id);

            if (libros != null)
            {
                if (LibrosBLL.Eliminar(id))
                {
                    MessageBox.Show("Eliminado!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                }
                else
                    MessageBox.Show("No se pudo eliminar!!", "Falló", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("El Id no existe", "Falló", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(LibrosIdNumericUpDown.Value);
            Libros libro = LibrosBLL.Buscar(id);
            Libros libros = LlenaClase();
            bool Paso = false;

            if (HayErrores())
            {
                MessageBox.Show("llenar todos los campos indicados!!!", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (LibrosIdNumericUpDown.Value == 0)
                Paso = LibrosBLL.Guardar(libros);
            else
            {

                if (libros != null)
                {
                    Paso = LibrosBLL.Modificar(LlenaClase());
                }
                else
                    MessageBox.Show("El Id no existe!!", "Falló",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (Paso)
                {
                    MessageBox.Show("Guardado!!", "Exito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                }
                else
                    MessageBox.Show("No se pudo guardar!!", "Falló",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}
