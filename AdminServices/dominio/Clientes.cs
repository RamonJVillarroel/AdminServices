using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
     public class Clientes
    {
        public int Id { get; set; }
        public string NombreCliente { get; set; }
        public string FechaServicio { get; set; }
        public string LugarServicio { get; set; }
        public decimal PagoRecibido { get; set; }
        public int Celular { get; set; }
        public string Mail { get; set; }
        public string Descripcion { get; set; }
    }
}
