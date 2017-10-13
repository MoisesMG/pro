using CADFacturacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WcfFacturacion;

namespace WcfFacturacion
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class ServicioFacturacion : IServiceFacturacion
    {
        public IList<Cliente> GetClientes()
        {
            DsFacturacion.ClienteDataTable misclientes = CADCliente.GetClientes();
            if(misclientes.Rows.Count == 0)return null;

            List<Cliente> clientes = new List<Cliente>();
            foreach(DsFacturacion.ClienteRow miRegistro in misclientes.Rows)
            {
                Cliente cliente = new Cliente();
                cliente.IdCliente = miRegistro.IDCliente;
                cliente.Nombres = miRegistro.Nombres;
                cliente.Apellidos = miRegistro.Apellidos;
                cliente.Correo = miRegistro.Correo;
                cliente.Cupo = miRegistro.Cupo;
                cliente.Telefono = miRegistro.Telefono;
                cliente.Direccion = miRegistro.Direccion;
                cliente.FechaNacimineto = miRegistro.FechaNacimiento;

                clientes.Add(cliente);
            }

            return clientes;
        }

        public Producto GetProducto(int idProducto)
        {
            DsFacturacion.ProductoDataTable miProducto = CADProducto.GetProducto(idProducto);
           if (miProducto.Rows.Count == 0) return null;

            DsFacturacion.ProductoRow miRegistro = (DsFacturacion.ProductoRow)miProducto.Rows[0];

            Producto producto = new Producto();
            producto.IdProducto = miRegistro.IDProducto;
            producto.Descripcion = miRegistro.Descripcion;
            producto.Precio = miRegistro.Precio;
            producto.Stock = miRegistro.Stock;
            producto.IdIva = miRegistro.IDIVA;
            producto.IdDepartamento = miRegistro.IDDepartamento;
            producto.Notas = miRegistro.Notas;

            return producto;

        }

        public IList<Producto> GetProductos()
        {
            DsFacturacion.ProductoDataTable misProductos = CADProducto.GetProductos();
            if (misProductos.Rows.Count == 0) return null;

            List<Producto> productos = new List<Producto>();
            foreach (DsFacturacion.ProductoRow miRegistro in misProductos.Rows)
            {
                Producto producto = new Producto();
                producto.IdProducto = miRegistro.IDProducto;
                producto.Descripcion = miRegistro.Descripcion;
                producto.Precio = miRegistro.Precio;
                producto.Stock = miRegistro.Stock;
                producto.IdIva = miRegistro.IDIVA;
                producto.IdDepartamento = miRegistro.IDDepartamento;
                producto.Notas = miRegistro.Notas;

                productos.Add(producto);
            }

            return productos;
        }

        public void NewPedido(DateTime fecha, string idCliente, int idProducto, string notas, bool despachado, int cantidad)
        {
            CADPedido.NewPedido(fecha, idCliente, idProducto, notas, despachado, cantidad);
        }
    }
}
