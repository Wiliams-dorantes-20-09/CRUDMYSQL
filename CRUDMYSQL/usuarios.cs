using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDMYSQL
{
    internal class usuarios
    {
        int id;
        string usuario, passwords, contpasswords, nombre;

        public string Usuario { get => usuario; set => usuario = value; }
        public string Passwords { get => passwords; set => passwords = value; }
        public string Contpasswords { get => contpasswords; set => contpasswords = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Id { get => id; set => id = value; }
    }
}
