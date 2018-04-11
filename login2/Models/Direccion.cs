using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace login2.Models
{
    public class Direccion
    {
        public int Id { get; set; }
        public String Calle { get; set; }
        public int ClienteId { get; set; }
    }
}
