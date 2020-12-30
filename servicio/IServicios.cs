using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace servicio
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IServicios" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServicios
    {
       
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "ListarRecetas", ResponseFormat = WebMessageFormat.Json)]
        List<RecetaClase> ListarRecetas();

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "ListarRecetasTipo/{tipo}", ResponseFormat = WebMessageFormat.Json)]
        List<RecetaClase> ListarRecetasTipo(string tipo);

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "ListarRecetasMenu", ResponseFormat = WebMessageFormat.Json)]
        List<RecetaClase> ListarRecetasMenu();

        
        
        
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "ActualizarEstadoOrden/{id},{estado}", ResponseFormat = WebMessageFormat.Json)]
        string ActualizarEstadoOrden(string id,string estado);
        
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "ActualizarEstadoMesa/{id},{capacidad}", ResponseFormat = WebMessageFormat.Json)]
        string ActualizarEstadoMesa(string id,string capacidad);
        
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "ListarDetalleOrden", ResponseFormat = WebMessageFormat.Json)]
        List<DetalleOrdenClase> ListarDetalleOrden();

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "ListarDetalleOrdenFinalizados", ResponseFormat = WebMessageFormat.Json)]
        List<DetalleOrdenClase> ListarDetalleOrdenFinalizados();

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "ListarMesas", ResponseFormat = WebMessageFormat.Json)]
        List<MesaClase> ListarMesas();

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "ListarMesasLibres", ResponseFormat = WebMessageFormat.Json)]
        List<MesaClase> ListarMesasLibres();

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "ListarMesasLibresC/{capacidad}", ResponseFormat = WebMessageFormat.Json)]
        List<MesaClase> ListarMesasLibresC(string capacidad);

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "ListarMesasOcupadas", ResponseFormat = WebMessageFormat.Json)]
        List<MesaClase> ListarMesasOcupadas();

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "ListarOrdenes", ResponseFormat = WebMessageFormat.Json)]
        List<OrdenClase> ListarOrdenes();

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "ListarOrdenesEnCocina", ResponseFormat = WebMessageFormat.Json)]
        List<DetalleOrdenClase> ListarOrdenesEnCocina();

      
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "ListarOrdenesSinPagar", ResponseFormat = WebMessageFormat.Json)]
        List<DetalleOrdenClase> ListarOrdenesSinPagar();

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "ListarPlatosResumen", ResponseFormat = WebMessageFormat.Json)]
        List<DetalleRecetaClase> ListarPlatosResumen();
        
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "testAgregarOrden/{mesa},{json}", ResponseFormat = WebMessageFormat.Json)]
        bool testAgregarOrden(string mesa,string json);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "AgregarOrden", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        int AgregarOrden(TestOrden x);

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "Pagar/{id}", ResponseFormat = WebMessageFormat.Json)]
        bool Pagar(string id);

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "ListarOrdenesSinPagarPorMesa/{mesa}", ResponseFormat = WebMessageFormat.Json)]
        List<t> ListarOrdenesSinPagarPorMesa(string mesa);


        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "ListarOrdenesCocina", ResponseFormat = WebMessageFormat.Json)]
        List<DetalleOrdenClase> ListarOrdenesCocina();

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "ListarOrdenesCocinaPorMesa/{mesa}", ResponseFormat = WebMessageFormat.Json)]
        List<DetalleOrdenClase> ListarOrdenesCocinaPorMesa(string mesa);


    }
}
