using CADFacturacion.DsFacturacionTableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CADFacturacion
{
    public class CADCliente
    {
        private static ClienteTableAdapter adaptador = new ClienteTableAdapter();

        public static DsFacturacion.ClienteDataTable GetClientes()
        {
            return adaptador.GetClientes();
        }

    }
}
