using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BLL
{
    public class Estudios: ClaseMaestra
    {
        Conexion con = new Conexion();
        public int EstudioId { get; set; }
        public string Nombre { get; set; }

        public Estudios()
        {
            this.EstudioId = 0;
            this.Nombre = "";
        }
        public override bool Insert()
        {
            return con.Ejecutar(String.Format("Insert Into Estudios (Nombre) values('{0}')", this.Nombre));
        }

        public override bool Actualizar()
        {
            return con.Ejecutar(String.Format("Update Estudios set Nombre = '{0}' where EstudioId='{0}'", this.Nombre, this.EstudioId));
        }

        
        public override bool Delete()
        {
            return con.Ejecutar(String.Format("Delete from Estudios where EstudioId = {0}", this.EstudioId));
        }

        public override DataTable Listar(string campos, string Filtro)
        {
            return con.getDatos("Select " + campos + " from Generos where " + Filtro);
        }

        public override bool Buscar(int IdBuscado)
        {
            throw new NotImplementedException();
        }
    }
}
