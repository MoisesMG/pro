using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfFacturacion
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServiceFacturacion
    {

        [OperationContract]
        Producto GetProducto(int value);

        [OperationContract]
        IList<Producto> GetProductos();

        [OperationContract]
        IList<Cliente> GetClientes();

        [OperationContract]
        void NewPedido(DateTime Fecha, string idCliente, int idProducto, string notas, bool despachado, int cantidad);
        // TODO: agregue aquí sus operaciones de servicio
    }

    // Utilice un contrato de datos, como se ilustra en el ejemplo siguiente, para agregar tipos compuestos a las operaciones de servicio.
}
