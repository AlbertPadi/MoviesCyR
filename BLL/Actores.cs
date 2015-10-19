using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class Actores: ClaseMaestra
    {
        Conexion con = new Conexion();
        public int ActorId { get; set; }
        public string Nombre { get; set; }


        public Actores()
                {
                    this.ActorId = 0;
                    this.Nombre = "";
                }
        public override bool Insert()
        {
            return con.Ejecutar(String.Format("insert into Actores (Nombre) Values('{0}')", this.Nombre));
        }
        public override bool Actualizar()
        {
            return con.Ejecutar(String.Format("Update Actores set Nombre ='{0}' where ActorId = '{1}'", this.Nombre, this.ActorId ));
        }

        public override bool Delete()
        {
            return con.Ejecutar(String.Format("Delete From Actores where ActorId={0}", this.ActorId));
        }

        public override DataTable Listar(string campos, string Filtro)
        {
            
            return con.getDatos("Select "+ campos + " From Actores where "+ Filtro);
        }

       
    }
}
