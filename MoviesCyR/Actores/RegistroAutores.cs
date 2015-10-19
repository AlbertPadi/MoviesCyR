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

namespace MoviesCyR.Actores
{
    public partial class RegistroAutores : Form
    {
        public RegistroAutores()
        {
            InitializeComponent();
        }

        private void RegistroAutores_Load(object sender, EventArgs e)
        {
            
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            BLL.Actores ac = new BLL.Actores();
           
            if (ActorIdtextBox.Text.Length == 0)
            {
                ac.Nombre = NombretextBox.Text;
                ac.Insert();
                MessageBox.Show("Se ha ingresado correctamente");
            }
            else
            {
                ac.ActorId = Convert.ToInt32(ActorIdtextBox.Text);
                ac.Nombre = NombretextBox.Text;
                ac.Actualizar();
                MessageBox.Show("Se ha actualizado correctamente");
            }
        }

        private void Actualizarbutton_Click(object sender, EventArgs e)
        {
            NombretextBox.Text = "";
            ActorIdtextBox.Text = "";

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BLL.Actores ac = new BLL.Actores();
            ac.ActorId = Convert.ToInt32(ActorIdtextBox.Text);
            ac.Delete();
        }
    }
}
