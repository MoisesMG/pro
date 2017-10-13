using CADFacturacion.DsFacturacionTableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CADFacturacion
{
    public class CADProducto
    {
        private static ProductoTableAdapter adaptador = new ProductoTableAdapter();

        public static DsFacturacion.ProductoDataTable GetProducto(int idProducto)
        {
            return adaptador.GetProducto(idProducto);
        }

        public static DsFacturacion.ProductoDataTable GetProductos()
        {
            return adaptador.GetProductos();
        }

    }
}
