using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace MoviesCyR.Estudios
{
    public partial class RegistroEstudios : Form
    {
        public RegistroEstudios()
        {
            InitializeComponent();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {

            BLL.Estudios es = new BLL.Estudios();

            if (EstudioIdtextBox.Text.Length == 0)
            {
                es.Nombre = NombretextBox.Text;
                es.Insert();
                MessageBox.Show("Se ha ingresado correctamente");
            }
            else
            {
                es.EstudioId = Convert.ToInt32(EstudioIdtextBox.Text);
                es.Nombre = NombretextBox.Text;
                es.Actualizar();
                MessageBox.Show("Se ha actualizado correctamente");
            }
    
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            NombretextBox.Text = "";
            EstudioIdtextBox.Text = "";
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            BLL.Estudios es = new BLL.Estudios();
            es.EstudioId = Convert.ToInt32(EstudioIdtextBox.Text);
            es.Delete();
        }

        private void RegistroEstudios_Load(object sender, EventArgs e)
        {

        }
    }
}
