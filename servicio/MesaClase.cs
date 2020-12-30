using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace servicio
{
    public class MesaClase
    {
        public short Id { get; set; }
        public short Numero { get; set; }
        public byte Capacidad { get; set; }
        public bool Estado { get; set; }
    }
}