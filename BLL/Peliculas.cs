using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BLL
{
    public class Peliculas: ClaseMaestra
    {
        Conexion con = new Conexion();

        

        public int PeliculaId { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public int Ano { get; set; }
        public int Calificacion { get; set; }
        public int IMDB { get; set; }
        public int CategoriapId { get; set; }

        public String Estudio { get; set; }

        public List<Actores> Actores { get; set; }
        public Peliculas()
        {
            this.PeliculaId = 0;
            this.Titulo = "";
            this.Descripcion = "";
            this.Ano = 0;
            this.Calificacion = 0;
            this.IMDB = 0;
            this.CategoriapId = 0;
           
            this.Estudio = "";

            Actores = new List<Actores>();
        }


        public void AgregarActores(int ActorId, string Nombre)
        {
            this.Actores.Add(new Actores(ActorId, Nombre));
        }

        public override bool Insert()
        {
          
                bool retorno = false;
                StringBuilder Comando = new StringBuilder();

            try
            {
                retorno = con.Ejecutar(String.Format("Insert Into Registro(titulo, Descripcion, Ano, calificacion, IMDB, CategoriaId, Estudio) Values('{0}','{1}', {2}, {3}, {4}, {5}, '{6}')", this.Titulo, this.Descripcion, this.Ano, this.Calificacion, this.IMDB, this.CategoriapId, this.Estudio));
                if (retorno)
                {
                    this.PeliculaId = (int)con.getDatos("Select Max(PeliculaId) as PeliculaId from Registro").Rows[0]["PeliculaId"];

                    foreach (var autor in this.Actores)
                    {
                        Comando.AppendLine(String.Format("insert into PeliculasActores(PeliculaId,ActorId) Values({0},{1});", this.PeliculaId, autor.ActorId));

                    }

                    retorno = con.Ejecutar(Comando.ToString());
                }
                return retorno;
            }
            catch (Exception)
            {

                return false;
            }
               
            
        }
            
        

        public override bool Actualizar()
        {
            bool retorno = false;
            StringBuilder Comando = new StringBuilder();
            
                retorno =  con.Ejecutar(String.Format("Update Registro set titulo = '{0}', Descripcion = '{1}', Ano={2}, calificacion = {3}, IMDB = {4}, CategoriaId = {5},  Estudio = '{8}'", this.Titulo, this.Descripcion, this.Ano, this.Calificacion, this.IMDB, this.CategoriapId, this.Estudio));
            if (retorno)
            {
                con.Ejecutar("Delete From PeliculasActores Where PeliculaId="+this.PeliculaId);
                foreach (var Actor in this.Actores )
                {
                    Comando.AppendLine(String.Format("insert into PeliculasActores(PeliculaId, ActorId) values({0}, {1});", this.PeliculaId, Actor.ActorId));

                }
                retorno = con.Ejecutar(Comando.ToString());
            }
                return retorno;
            
        }

        public override bool Delete()
        {
            bool retorno = false;
            retorno =  con.Ejecutar(String.Format("Delete from Registro where PeliculaId ={0}", this.CategoriapId+";"+"Delete From PeliculasActores where PeliculaId="+this.PeliculaId));
            return retorno;
        }


        public override bool Buscar(int IdBuscado)
        {
            DataTable dt = new DataTable();
            DataTable dtActores = new DataTable();
            dt = con.getDatos(String.Format("select  PeliculaId,Titulo,Descripcion,Ano,Calificacion,IMBD, CategoriaId,Foto,Video from Registro where PeliculaId='{0}'", IdBuscado));
            if (dt.Rows.Count > 0)
            {
                this.PeliculaId = (int)dt.Rows[0]["PeliculaId"];
                this.Titulo = dt.Rows[0]["Titulo"].ToString();
                this.Descripcion = dt.Rows[0]["Descripcion"].ToString();
                this.Ano = (int)dt.Rows[0]["Ano"];
                this.Calificacion = (int)dt.Rows[0]["Calificacion"];


                dtActores = con.getDatos("Select p.ActorId,a.Nombre " +
                                                    "From PeliculasActores p " +
                                                    "Inner Join Actores a On p.ActorId=a.ActorId" +
                                                    "Where p.PeliculaId=" + this.PeliculaId);

                foreach (DataRow row in dtActores.Rows)
                {
                    this.AgregarActores((int)row["ActorId"], row["Nombre"].ToString());
                }
            }

            return dt.Rows.Count > 0;
        }


        public override DataTable Listar(string campos = "*", string Filtro = "1=1")
        {
            return con.getDatos("Select" + campos + "from Registro where " + Filtro);
        }
    }
}

