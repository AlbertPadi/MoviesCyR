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



namespace MoviesCyR.Eliminar
{
    public partial class Eliminar : Form
    {
        Pelicula p = new Pelicula();

        public Eliminar()
        {
            InitializeComponent();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {

        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            p.CategoriapId = Convert.ToInt32(textBoxEliminar.Text);
            p.Delete();
            MessageBox.Show("Consulte para confirmar si se elimino la pellicula");
        }
    
        private void button1_Click(object sender, EventArgs e)
        {
            
            }
        }
   
    }

