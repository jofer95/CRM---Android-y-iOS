using ejmeplo1.Enumeradores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace ejmeplo1
{
    [SQLite.Table("Contacto")]
    public class Contacto
    {
        [PrimaryKey,AutoIncrement,Column("Id")]
        public int ID { get; set; }
        public String ApellidoPaterno { get; set; }
        public String ApellidoMaterno { get; set; }
        public String Nombre { get; set; }
        public String Correo { get; set; }
        public String Telefono { get; set; }
        public TipoCliente TipoCliente { get; set; }
    }
}
