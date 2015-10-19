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

namespace MoviesCyR.Generos
{
    public partial class GenerosPeli : Form
    {
        
        public GenerosPeli()
        {
            InitializeComponent();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            BLL.Generos g = new BLL.Generos();
            g.Descripcion = DescripciontextBox.Text;

            MessageBox.Show("Se ha ingresado la descripcion");

            if (GeneroIdtextBox.Text.Trim().Length == 0)
            {
                g.Insert();

            }
            else
            {
                g.GeneroId = Convert.ToInt32(GeneroIdtextBox.Text);
                g.Actualizar();
                MessageBox.Show("Se ha modificado");
            }
        }

    
/*
        private void Actualizarbutton_Click(object sender, EventArgs e)
        {
            BLL.Generos g = new BLL.Generos();
            g.Descripcion = DescripciontextBox.Text;
        }

            */

        private void Generos_Load(object sender, EventArgs e)
        {
            
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            BLL.Generos g = new BLL.Generos();
            g.GeneroId = Convert.ToInt32(GeneroIdtextBox.Text);
            g.Delete();
        }
    }
}
