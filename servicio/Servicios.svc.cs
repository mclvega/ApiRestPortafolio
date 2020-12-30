using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace servicio
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Servicios" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Servicios.svc o Servicios.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Servicios : IServicios
    {

        public List<DetalleOrdenClase> ListarDetalleOrden()
        {
            using (restaurantEntities bdd = new restaurantEntities())
            {
                return bdd.F_LISTA_DETALLE_ORDEN().Select(l => new DetalleOrdenClase
                {
                    Id = l.id,
                    Orden = l.orden,
                    fecha_orden = l.fecha_orden,
                    mesa = l.numero_mesa,
                    capacidad_mesa = l.capacidad_mesa,
                    Receta = l.receta,
                    nombre_receta = l.nombre_receta,
                    precio_receta = l.precio_receta,
                    dificultad = l.dificultad,
                    descripcion_dificultad = l.descripcion_dificultad,
                    Precio = l.precio_orden,
                    Estado_Orden = l.estado_orden,
                    descripcion_estado_orden = l.descripcion_estado_orden
                }).ToList();
            }
        }
        public List<DetalleOrdenClase> ListarDetalleOrdenFinalizados()
        {
            using (restaurantEntities bdd = new restaurantEntities())
            {
                return bdd.F_LISTA_DETALLE_ORDEN().Where(D => D.estado_orden == 3 ).Select(l => new DetalleOrdenClase
                {
                    Id = l.id,
                    Orden = l.orden,
                    fecha_orden = l.fecha_orden,
                    mesa = l.numero_mesa,
                    capacidad_mesa = l.capacidad_mesa,
                    Receta = l.receta,
                    nombre_receta = l.nombre_receta,
                    precio_receta = l.precio_receta,
                    dificultad = l.dificultad,
                    descripcion_dificultad = l.descripcion_dificultad,
                    Precio = l.precio_orden,
                    Estado_Orden = l.estado_orden,
                    descripcion_estado_orden = l.descripcion_estado_orden
                }).ToList();
            }
        }

        public string ActualizarEstadoOrden(string id, string estado)
        {
            using (restaurantEntities bdd = new restaurantEntities())
            {
                int cod = int.Parse(id);
                byte est = byte.Parse(estado);
                bdd.P_ACTUALIZAR_ESTADO_ORDEN(cod, est);

                return "Actualizado Correctamente";

            }
        }

        public string ActualizarEstadoMesa(string id,string capacidad)
        {
            using (restaurantEntities bdd = new restaurantEntities())
            {
                short cod = short.Parse(id);
                byte cap = byte.Parse(capacidad);
                bdd.P_OCUPAR_MESA_SIN_RESERVA(cod,cap);

                return "Actualizado Correctamente";

            }
        }

        public List<MesaClase> ListarMesas()
        {
            using (restaurantEntities bdd = new restaurantEntities())
            {
                return bdd.F_LISTA_DE_MESAS().Select(l => new MesaClase
                {
                    Id = l.Id,
                    Estado=l.Estado,
                    Capacidad = l.Capacidad,
                    Numero = l.Numero
                }).ToList();

            }
        }

        public List<MesaClase> ListarMesasLibres()
        {
            using (restaurantEntities bdd = new restaurantEntities())
            {
                return bdd.F_LISTA_DE_MESAS_LIBRES().Select(l => new MesaClase
                {
                    Id = l.Id,
                    Estado=l.Estado,
                    Capacidad = l.Capacidad,
                    Numero = l.Numero
                }).ToList();

            }
        }

        public List<MesaClase> ListarMesasLibresC(string capacidad)
        {
            using (restaurantEntities bdd = new restaurantEntities())
            {
                byte cap = byte.Parse(capacidad);
                return bdd.F_LISTA_DE_MESAS_LIBRES().Where(c=>c.Capacidad>=cap).Select(l => new MesaClase
                {
                    Id = l.Id,
                    Estado = l.Estado,
                    Capacidad = l.Capacidad,
                    Numero = l.Numero
                }).ToList();

            }
        }

        public List<MesaClase> ListarMesasOcupadas()
        {
            using (restaurantEntities bdd = new restaurantEntities())
            {
                return bdd.F_LISTA_DE_MESAS_OCUPADAS().Select(l => new MesaClase
                {
                    Id = l.Id,
                    Estado=l.Estado,
                    Capacidad = l.Capacidad,
                    Numero = l.Numero
                }).ToList();

            }
        }

        public List<OrdenClase> ListarOrdenes()
        {
            using (restaurantEntities bdd = new restaurantEntities())
            {
                return bdd.F_LISTA_DE_ORDENES().Select(l => new OrdenClase
                {
                    fecha = l.Fecha,
                    Receta = l.Recetas,
                    Total = l.Total
                   

                }).ToList();

            }
        }

        public List<DetalleOrdenClase> ListarOrdenesEnCocina()
        {
            using (restaurantEntities bdd = new restaurantEntities())
            {
                return bdd.F_LISTA_DE_ORDENES_EN_COCINA().Select(l => new DetalleOrdenClase
                {
                    Orden = l.Orden,
                    hora = l.Hora_Encargo,
                    mesa = l.Numero_Mesa,
                    nombre_receta = l.Receta,
                    descripcion_dificultad = l.Dificultad




                }).ToList();

            }
        }

        public List<DetalleOrdenClase> ListarOrdenesSinPagar()
        {
            using (restaurantEntities bdd = new restaurantEntities())
            {


                return bdd.F_LISTA_DE_ORDENES_SIN_PAGAR().Select(l => new DetalleOrdenClase
                {
                    fecha_orden = l.Fecha,
                    mesa = l.Mesa

                }).ToList();

            }
        }
        public bool Pagar(string id)
        {
            using (restaurantEntities bdd = new restaurantEntities())
            {
                int cod=int.Parse(id);
                bdd.P_ACTUALIZAR_ORDEN_PAGADA(cod);

                return true;

            }
        }

        public List<DetalleRecetaClase> ListarPlatosResumen()
        {
            using (restaurantEntities bdd = new restaurantEntities())
            {


                return bdd.F_LISTA_DE_PLATOS_RESUMEN().Select(l => new DetalleRecetaClase
                {
                    Receta = l.Receta,
                    Cantidad = l.Cantidad


                }).ToList();

            }
        }

        public List<RecetaClase> ListarRecetas()
        {
            using (restaurantEntities bdd = new restaurantEntities())
            {
                return bdd.F_LISTA_DE_RECETAS_COMPLETA().Select(l => new RecetaClase
                {
                    Id = l.Id,
                    Precio = l.Precio,
                    Tipo = l.Tipo,
                    Estado = l.Estado,
                    Nombre = l.Nombre
                }).ToList();
            }
        }
        public List<RecetaClase> ListarRecetasTipo(string tipo)
        {
            using (restaurantEntities bdd = new restaurantEntities())
            {
                byte t = byte.Parse(tipo);
                return bdd.F_LISTA_DE_RECETAS_MENU_TIPO(t).Select(l => new RecetaClase
                {
                    Id = l.Id,
                    Precio = l.Precio,
                    Estado = l.Estado,
                    Tipo = l.Tipo,
                    Nombre = l.Nombre
                }).ToList();
            }
        }

        public List<RecetaClase> ListarRecetasMenu()
        {
            using (restaurantEntities bdd = new restaurantEntities())
            {
                return bdd.F_LISTA_DE_RECETAS_MENU().Select(l => new RecetaClase
                {
                    Id = l.Id,
                    Precio = l.Precio,
                    Tipo = l.Tipo,
                    Estado = true,
                    Nombre = l.Nombre
                }).ToList();
            }
        }



        public bool testAgregarOrden(string mesa, string json)
        {
            using (restaurantEntities bdd = new restaurantEntities())
            {
                try
                {

                    short m = short.Parse(mesa);

                    bdd.P_INSERTAR_ORDENES(DateTime.Now, false, m, json);
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }


            }
        }

        public int AgregarOrden(TestOrden x)
        {
            using (restaurantEntities bdd = new restaurantEntities())
            {
                try
                {

                    bdd.P_INSERTAR_ORDENES(DateTime.Now, false, x.mesa, x.json);
                    return 1;
                }
                catch (Exception ex)
                {
                    return 0;
                }


            }
        }

        public List<t> ListarOrdenesSinPagarPorMesa(string mesa)
        {
            using (restaurantEntities bdd = new restaurantEntities())
            {

                int m = int.Parse(mesa);
                return bdd.F_LISTA_DE_ORDENES_SIN_PAGAR_POR_MESA(m).Select(l => new t
                {
                    
                    Id=l.Orden
                    

                }).ToList();

            }
        }

        public List<DetalleOrdenClase> ListarOrdenesCocina()
        {
            using (restaurantEntities bdd = new restaurantEntities())
            {
                return bdd.F_LISTA_DETALLE_ORDEN().Where(D => D.estado_orden == 1||D.estado_orden==2).Select(l => new DetalleOrdenClase
                {
                    Id = l.id,
                    Orden = l.orden,
                    fecha_orden = l.fecha_orden,
                    mesa = l.numero_mesa,
                    capacidad_mesa = l.capacidad_mesa,
                    Receta = l.receta,
                    nombre_receta = l.nombre_receta,
                    precio_receta = l.precio_receta,
                    dificultad = l.dificultad,
                    descripcion_dificultad = l.descripcion_dificultad,
                    Precio = l.precio_orden,
                    Estado_Orden = l.estado_orden,
                    descripcion_estado_orden = l.descripcion_estado_orden
                }).ToList();
            }
        }

        public List<DetalleOrdenClase> ListarOrdenesCocinaPorMesa(string mesa)
        {
            using (restaurantEntities bdd = new restaurantEntities())
            {
                byte nm = byte.Parse(mesa);
                return bdd.F_LISTA_DE_ORDENES_EN_COCINA_POR_MESA(nm).Select(l => new DetalleOrdenClase
                {
                    
                    Orden = l.Orden,
                    mesa = l.Numero_Mesa,
                    nombre_receta = l.Receta,
                    descripcion_dificultad = l.Dificultad,
                    descripcion_estado_orden = l.Descripcion
                }).ToList();
            }
        }
    }
}
