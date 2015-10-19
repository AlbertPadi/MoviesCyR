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

namespace MoviesCyR.Consulta
{
    /// <summary>
    /// clase para consultar las peliculas
    /// </summary>
    public partial class CPelicula : Form
    {
        public CPelicula()
        {
            InitializeComponent();
        }

        private void CPelicula_Load(object sender, EventArgs e)
        {
            comboBoxFiltr.SelectedIndex = 0;
        }
        /// <summary>
        /// este es el boton para consulta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            Pelicula p = new Pelicula();
            DataTable dt = new DataTable();
            string filtro = "1=1";
            if (comboBoxFiltr.SelectedIndex == 0)
            {
                if(textBoxFiltro.Text.Trim().Length == 0)
                {
                    filtro = "1=1";
                }
                else
                {
                    filtro = "PeliculaId = " + textBoxFiltro.Text;
                }
                

                dt = p.Listar(" PeliculaId, titulo, descripcion, Ano, calificacion, IMDB, CategoriaId, Generos, Actores, Estudio ", filtro);
                dataGridViewConsulta.DataSource = dt;
            }
            if (comboBoxFiltr .SelectedIndex == 2)
            {
                if (textBoxFiltro .Text .Trim ().Length ==1)
                {
                    filtro = "3=3";
                }
                dt = p.Listar(" PeliculaId, titulo, descripcion, Ano, calificacion, IMDB, CategoriaId, Generos, Actores, Estudio ", filtro);
                dataGridViewConsulta.DataSource = dt;
            }
               
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
