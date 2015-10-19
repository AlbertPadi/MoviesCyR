using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class Generos : ClaseMaestra
    {
        Conexion con = new Conexion();

        public int GeneroId { get; set; }
        public string Descripcion { get; set; }

        public Generos()
        {
            this.GeneroId = 0;
            this.Descripcion = "";
        }
        

        public override bool Insert()
        {
            return con.Ejecutar(String.Format("Insert Into Generos (Descripcion) Values('{0}')", this.Descripcion));
        }

        public override bool Actualizar()
        {
           return con.Ejecutar(String.Format("Update Generos set Descripcion = '{0}' where GeneroId = {1}", this.Descripcion, this.GeneroId));
        }

       public override bool Delete()
        {
            return con.Ejecutar(String.Format("Delete from Generos  where GeneroId ={0}", this.GeneroId));
        }
  
        public override DataTable Listar(string campos = "*", string Filtro = "1=1")
        {
             return con.getDatos("Select " + campos + " from Generos where " + Filtro);
        }

        
    }
}
