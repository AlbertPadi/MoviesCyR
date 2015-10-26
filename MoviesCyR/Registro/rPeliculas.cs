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
        BLL.Actores actores = new BLL.Actores();
        BLL.Generos generos = new BLL.Generos();
        BLL.Estudios estudios = new BLL.Estudios();

        private Peliculas pelicula = new Peliculas();



        public FormRegistro()
        {
            InitializeComponent();
                 
    }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < actores.Listar("Nombre", "1=1").Rows.Count; i++)
            {
                ActorescomboBox.Items.Add(actores.Listar("Nombre", "1=1").Rows[i]["Nombre"]);
            }

            for (int i = 0; i < generos.Listar("Descripcion", "1=1").Rows.Count; i++)
            {
                GenerocomboBox.Items.Add(generos.Listar("Descripcion", "1=1").Rows[i]["Descripcion"]);
            }
            for (int i = 0; i < estudios.Listar("Nombre", "1=1").Rows.Count; i++)
            {
                EstudioscomboBox.Items.Add(estudios.Listar("Nombre", "1=1").Rows[i]["Nombre"]);
            }
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            pelicula.Estudio = EstudioscomboBox.Text;
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
            Peliculas peli = new Peliculas();
            peli.Titulo = textBoxTitulo.Text;
            peli.Descripcion = textBoxDescripcion.Text;
            peli.Ano = Convert.ToInt32(textBoxAno.Text);
            peli.Calificacion = Convert.ToInt32(textBoxCalificacion.Text);
            peli.IMDB = Convert.ToInt32(textBoxIMDB.Text);
            peli.CategoriapId = Convert.ToInt32(textBoxCategoriaId.Text);

            pelicula.CategoriapId = Convert.ToInt32(textBoxCategoriaId.Text);

            peli.Actualizar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenopenFileDialog.ShowDialog();

            OpenpictureBox.ImageLocation = OpenopenFileDialog.FileName;

        }

        private void Agregarbutton_Click(object sender, EventArgs e)
        {
            AdGenerolistBox.Items.Add(GenerocomboBox.Text);
        }

        private void Agregar1button_Click(object sender, EventArgs e)
        {
            AddActoreslistBox.Items.Add(ActorescomboBox.Text);
        }

        private void EstudioscomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
