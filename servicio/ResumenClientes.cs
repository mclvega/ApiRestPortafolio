using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace servicio
{
    public class ResumenClientes
    {
        public Int16 Mesa { get; set; }
        public DateTime Fecha_Reserva { get; set; }
        public string Reserva { get; set; }
        public byte Cantidad_Clientes{get;set;}
    }
}