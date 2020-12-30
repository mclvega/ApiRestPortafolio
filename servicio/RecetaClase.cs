using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace servicio
{
    public class RecetaClase
    {
        public short Id { get; set; }
        public string Nombre { get; set; }
        public int Precio { get; set; }
        public byte Tipo { get; set; }
        public bool Estado { get; set; }
    }
}