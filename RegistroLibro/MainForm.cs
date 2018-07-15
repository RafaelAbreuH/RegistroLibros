using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RegistroLibro.UI.Consultar;
using RegistroLibro.UI.Registrar;

namespace RegistroLibro
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void registrarLibroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rLibros view = new rLibros();
            view.Show();
        }

        private void consultarLibrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cLibros view = new cLibros();
            view.Show();
        }
    }
}
