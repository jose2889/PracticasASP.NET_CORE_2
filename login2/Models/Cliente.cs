using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace login2.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public Direccion Direccion { get; set; }
    }
}
