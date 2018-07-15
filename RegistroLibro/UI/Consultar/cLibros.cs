using RegistroLibro.BLL;
using RegistroLibro.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistroLibro.UI.Consultar
{
    public partial class cLibros : Form
    {
        public cLibros()
        {
            InitializeComponent();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            Expression<Func<Libros, bool>> filtro = x => true;
            int id;
            switch (FiltroComboBox.SelectedIndex)
            {
                case 0://ID
                    id = Convert.ToInt32(CriterioTextBox.Text);
                    filtro = x => x.LibrosId == id;
                    break;
                case 1://Por fecha
                    filtro = x => x.Fecha >= DesdeDateTimePicker.Value && x.Fecha <= HastaDateTimePicker.Value;
                    break;
                case 2://Filtrando por Siglas del Libro y Fecha.
                    filtro = x => x.Siglas.Contains(CriterioTextBox.Text) && x.Fecha >= DesdeDateTimePicker.Value && x.Fecha <= HastaDateTimePicker.Value;
                    break;
                case 3://Filtrando por Tipo del Libro y Fecha.
                    filtro = x => x.Tipo.Contains(CriterioTextBox.Text) && x.Fecha >= DesdeDateTimePicker.Value && x.Fecha <= HastaDateTimePicker.Value;
                    break;

            }
            LibrosConsultaDataGridView.DataSource = LibrosBLL.GetList(filtro);
        }
    }
}
