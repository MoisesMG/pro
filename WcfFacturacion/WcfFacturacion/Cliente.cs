using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WcfFacturacion
{
    [DataContract]
    public class Cliente
    {
        private string idCliente;
        private string nombres;
        private string apellidos;
        private string direccion;
        private string telefono;
        private string correo;
        private DateTime fechaNacimineto;
        private int cupo;

        [DataMember]
        public string IdCliente
        {
            get{return idCliente;}

            set{idCliente = value;}
        }

        [DataMember]
        public string Nombres
        {
            get
            {
                return nombres;
            }

            set
            {
                nombres = value;
            }
        }

        [DataMember]
        public string Apellidos
        {
            get
            {
                return apellidos;
            }

            set
            {
                apellidos = value;
            }
        }

        [DataMember]
        public string Direccion
        {
            get
            {
                return direccion;
            }

            set
            {
                direccion = value;
            }
        }

        [DataMember]
        public string Telefono
        {
            get
            {
                return telefono;
            }

            set
            {
                telefono = value;
            }
        }

        [DataMember]
        public string Correo
        {
            get
            {
                return correo;
            }

            set
            {
                correo = value;
            }
        }

        [DataMember]
        public DateTime FechaNacimineto
        {
            get
            {
                return fechaNacimineto;
            }

            set
            {
                fechaNacimineto = value;
            }
        }

        [DataMember]
        public int Cupo
        {
            get
            {
                return cupo;
            }

            set
            {
                cupo = value;
            }
        }
    }
}