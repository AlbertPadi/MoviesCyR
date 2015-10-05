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
            pelicula.Ano = Convert.ToInt32(textBoxAno.Text );                   
            pelicula.Calificacion = Convert.ToInt32(textBoxCalificacion.Text ); 
            pelicula.IMDB = Convert.ToInt32(textBoxIMDB.Text);                  
            pelicula.CategoriapId = Convert.ToInt32(textBoxCategoriaId.Text);   

            pelicula.Insert();
           
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxTitulo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
