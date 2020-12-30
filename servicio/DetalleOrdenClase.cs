using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace servicio
{
    public class DetalleOrdenClase
    {
        public int Id { get; set; }
        public int Orden { get; set; }
        public DateTime fecha_orden { get; set; }
        public string hora { get; set; }
        public short mesa { get; set; }
        public byte capacidad_mesa { get; set; }
        public short Receta { get; set; }
        public string nombre_receta { get; set; }
        public int precio_receta{get;set;}
        public byte dificultad { get; set; }
        public string descripcion_dificultad { get; set; }
        public int Precio { get; set; }
        public byte Estado_Orden { get; set; }
        public string descripcion_estado_orden { get; set; }
    }
}