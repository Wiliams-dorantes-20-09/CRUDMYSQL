using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDMYSQL
{
    internal class tggrProducts
    {
        int id;
        string accion, fecha;

        public string Accion { get => accion; set => accion = value; }
        public string Fecha { get => fecha; set => fecha = value; }
        public int Id { get => id; set => id = value; }
    }
}
