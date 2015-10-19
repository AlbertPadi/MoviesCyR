using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MoviesCyR.Eliminar;
using MoviesCyR.Generos;
using MoviesCyR.Actores;
using MoviesCyR.Estudios;

namespace MoviesCyR
{
    /// <summary>
    /// clase principal para registrar o consultar
    /// 
    /// </summary>
    public partial class Principal : Form
    {
       
        public Principal()
        {
            InitializeComponent();
        }

        private void buttonRegistrar_Click(object sender, EventArgs e)
        {
            FormRegistro fr = new FormRegistro();
            fr.Show();
        }

        private void buttonConsultar_Click(object sender, EventArgs e)
        {
            Consulta.CPelicula cp = new Consulta.CPelicula();
            cp.Show();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Para registrar precione el boton registrar,\npara salir precione el boton cancelar,\npara ver los datos guardados precione consultar,\nal consultar encontrara datos registrados solo\ntiene que precionar consultar y listara los\ndatos ya registrados");
        }

        private void hacercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("MoviesCyR es un software que te permite registrar,\nconsultar y pronto tendra la proxima vercion\nque incluira mas opciones, como:\nactualizar, borrar y mas");
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            Eliminar.Eliminar ee = new Eliminar.Eliminar();
            ee.Show();
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private void Reproducirbutton_Click(object sender, EventArgs e)
        {
            
        }

        private void Generosbutton_Click(object sender, EventArgs e)
        {
            GenerosPeli gp = new GenerosPeli();
            gp.Show();
            
        }

        private void Actoresbutton_Click(object sender, EventArgs e)
        {
            RegistroAutores RA = new RegistroAutores();
            RA.Show();
        }

        private void Estudiosbutton_Click(object sender, EventArgs e)
        {
            RegistroEstudios Re = new RegistroEstudios();
            Re.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
