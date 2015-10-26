using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BLL
{
    public abstract class ClaseMaestra
    {
        public abstract bool Actualizar();
        public abstract bool Insert();
        public abstract bool Delete();
        public abstract bool Buscar(int IdBuscado);
        public abstract DataTable Listar(string campos, string Filtro);

    }
}
