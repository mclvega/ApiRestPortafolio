using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace servicio
{
    public class InsumoClase
    {
        public short Id { get; set; }
        public string Nombre { get; set; }
        public byte Unidad_Medida { get; set; }
        public string Nombre_Unidad_Medida { get; set; }
        public int Cantidad_Actual { get; set; }
        public int Stock_Min { get; set; }
        public int Stock_Max { get; set; }
        public bool Estado { get; set; }
    }
}