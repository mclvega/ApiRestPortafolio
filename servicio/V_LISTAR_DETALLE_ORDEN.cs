//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace servicio
{
    using System;
    using System.Collections.Generic;
    
    public partial class V_LISTAR_DETALLE_ORDEN
    {
        public int id { get; set; }
        public int orden { get; set; }
        public System.DateTime fecha_orden { get; set; }
        public short numero_mesa { get; set; }
        public byte capacidad_mesa { get; set; }
        public short receta { get; set; }
        public string nombre_receta { get; set; }
        public int precio_receta { get; set; }
        public byte dificultad { get; set; }
        public string descripcion_dificultad { get; set; }
        public int precio_orden { get; set; }
        public byte estado_orden { get; set; }
        public string descripcion_estado_orden { get; set; }
    }
}