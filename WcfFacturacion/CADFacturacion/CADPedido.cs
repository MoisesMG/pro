using CADFacturacion.DsFacturacionTableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CADFacturacion
{
    public class CADPedido
    {
        private static PedidoTableAdapter adaptador = new PedidoTableAdapter();

        public static DsFacturacion.PedidoDataTable GetPedidos()
        {
            return adaptador.GetData();
        }

        public static void NewPedido(DateTime fecha, string idCliente, int idProducto, string notas, bool despachado, int cantidad)
        {
            adaptador.NewPedido(fecha, idCliente, idProducto, notas, despachado, cantidad);
        }
    }
}
