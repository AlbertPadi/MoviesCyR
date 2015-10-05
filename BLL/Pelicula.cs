using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BLL
{
    public class Pelicula
    {
        Conexion con = new Conexion();

        public int PeliculaId { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public int Ano { get; set; }
        public int Calificacion { get; set; }
        public int IMDB { get; set; }
        public int CategoriapId { get; set; }

        public Pelicula()
        {
            this.PeliculaId = 0;
            this.Titulo = "";
            this.Descripcion = "";
            this.Ano = 0;
            this.Calificacion = 0;
            this.IMDB = 0;
            this.CategoriapId = 0;
        }

        public bool Insert()
        {
            bool paso = false;

            

            con.Ejecutar(String.Format("Insert Into Registro (Titulo, Descripcion, Ano, Calificacion, IMDB, CategoriaId) Values('{0}','{1}', {2}, {3}, {4}, {5})", this.Titulo, this.Descripcion, this.Ano, this.Calificacion, this.IMDB, this.CategoriapId));


            return paso;
        }

       

        public DataTable Listar(string campos = "*", string Filtro = "1=1")
        {
            return con.getDatos("Select" + campos + "from Registro where " + Filtro);
        }

        public bool Delete()
        {
            
            return con.Ejecutar(String.Format("Delete from Registro where PeliculaId ={0}", CategoriapId));
           
        }
     }
}

