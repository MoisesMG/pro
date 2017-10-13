using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WcfFacturacion
{
    [DataContract]
    public class Producto
    {
        private int idProducto;
        private string descripcion;
        private decimal precio;
        private int stock;
        private string notas;
        private int idIva;
        private int idDepartamento;

        [DataMember]
        public int IdProducto
        {
            get
            {
                return idProducto;
            }

            set
            {
                idProducto = value;
            }
        }

        [DataMember]
        public string Descripcion
        {
            get
            {
                return descripcion;
            }

            set
            {
                descripcion = value;
            }
        }

        [DataMember]
        public decimal Precio
        {
            get
            {
                return precio;
            }

            set
            {
                precio = value;
            }
        }

        [DataMember]
        public int Stock
        {
            get
            {
                return stock;
            }

            set
            {
                stock = value;
            }
        }

        [DataMember]
        public string Notas
        {
            get
            {
                return notas;
            }

            set
            {
                notas = value;
            }
        }

        [DataMember]
        public int IdIva
        {
            get
            {
                return idIva;
            }

            set
            {
                idIva = value;
            }
        }

        [DataMember]
        public int IdDepartamento
        {
            get
            {
                return idDepartamento;
            }

            set
            {
                idDepartamento = value;
            }
        }
    }
}