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

namespace MoviesCyR
{
    public partial class FormRegistro : Form
    {

        private Pelicula pelicula = new Pelicula();


        public FormRegistro()
        {
            InitializeComponent();
    }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            
        
            pelicula.Titulo = textBoxTitulo.Text;
            pelicula.Descripcion = textBoxDescripcion.Text;                     
            pelicula.Ano = Convert.ToInt32(textBoxAno.Text);                   
            pelicula.Calificacion = Convert.ToInt32(textBoxCalificacion.Text); 
            pelicula.IMDB = Convert.ToInt32(textBoxIMDB.Text);                  
            pelicula.CategoriapId = Convert.ToInt32(textBoxCategoriaId.Text);   

            pelicula.Insert();
           
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            textBoxTitulo.Text = "";
            textBoxDescripcion.Text = "";
            textBoxAno.Text = "";
            textBoxCalificacion.Text = "";
            textBoxIMDB.Text = "";
            textBoxCategoriaId.Text = "";
        }

        private void textBoxTitulo_TextChanged(object sender, EventArgs e)
        {

        }

        private void Actualizarbutton_Click(object sender, EventArgs e)
        {
            Pelicula peli = new Pelicula();
            peli.Titulo = textBoxTitulo.Text;
            peli.Descripcion = textBoxDescripcion.Text;
            peli.Ano = Convert.ToInt32(textBoxAno.Text);
            peli.Calificacion = Convert.ToInt32(textBoxCalificacion.Text);
            peli.IMDB = Convert.ToInt32(textBoxIMDB.Text);
            peli.CategoriapId = Convert.ToInt32(textBoxCategoriaId.Text);

            if (pelicula.Actualizar(Convert.ToInt32(textBoxCategoriaId.Text)))
            {
                MessageBox.Show("Se ha modificado");
            }
            else
            {
                MessageBox.Show("No se pudo modificar");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenopenFileDialog.ShowDialog();

            OpenpictureBox.ImageLocation = OpenopenFileDialog.FileName;

        }
    }
}
