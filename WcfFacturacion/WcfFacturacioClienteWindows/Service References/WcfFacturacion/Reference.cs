﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WcfFacturacioClienteWindows.WcfFacturacion {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Producto", Namespace="http://schemas.datacontract.org/2004/07/WcfFacturacion")]
    [System.SerializableAttribute()]
    public partial class Producto : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescripcionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdDepartamentoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdIvaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdProductoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NotasField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal PrecioField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int StockField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Descripcion {
            get {
                return this.DescripcionField;
            }
            set {
                if ((object.ReferenceEquals(this.DescripcionField, value) != true)) {
                    this.DescripcionField = value;
                    this.RaisePropertyChanged("Descripcion");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int IdDepartamento {
            get {
                return this.IdDepartamentoField;
            }
            set {
                if ((this.IdDepartamentoField.Equals(value) != true)) {
                    this.IdDepartamentoField = value;
                    this.RaisePropertyChanged("IdDepartamento");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int IdIva {
            get {
                return this.IdIvaField;
            }
            set {
                if ((this.IdIvaField.Equals(value) != true)) {
                    this.IdIvaField = value;
                    this.RaisePropertyChanged("IdIva");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int IdProducto {
            get {
                return this.IdProductoField;
            }
            set {
                if ((this.IdProductoField.Equals(value) != true)) {
                    this.IdProductoField = value;
                    this.RaisePropertyChanged("IdProducto");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Notas {
            get {
                return this.NotasField;
            }
            set {
                if ((object.ReferenceEquals(this.NotasField, value) != true)) {
                    this.NotasField = value;
                    this.RaisePropertyChanged("Notas");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal Precio {
            get {
                return this.PrecioField;
            }
            set {
                if ((this.PrecioField.Equals(value) != true)) {
                    this.PrecioField = value;
                    this.RaisePropertyChanged("Precio");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Stock {
            get {
                return this.StockField;
            }
            set {
                if ((this.StockField.Equals(value) != true)) {
                    this.StockField = value;
                    this.RaisePropertyChanged("Stock");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Cliente", Namespace="http://schemas.datacontract.org/2004/07/WcfFacturacion")]
    [System.SerializableAttribute()]
    public partial class Cliente : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ApellidosField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CorreoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CupoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DireccionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime FechaNaciminetoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IdClienteField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NombresField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TelefonoField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Apellidos {
            get {
                return this.ApellidosField;
            }
            set {
                if ((object.ReferenceEquals(this.ApellidosField, value) != true)) {
                    this.ApellidosField = value;
                    this.RaisePropertyChanged("Apellidos");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Correo {
            get {
                return this.CorreoField;
            }
            set {
                if ((object.ReferenceEquals(this.CorreoField, value) != true)) {
                    this.CorreoField = value;
                    this.RaisePropertyChanged("Correo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Cupo {
            get {
                return this.CupoField;
            }
            set {
                if ((this.CupoField.Equals(value) != true)) {
                    this.CupoField = value;
                    this.RaisePropertyChanged("Cupo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Direccion {
            get {
                return this.DireccionField;
            }
            set {
                if ((object.ReferenceEquals(this.DireccionField, value) != true)) {
                    this.DireccionField = value;
                    this.RaisePropertyChanged("Direccion");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime FechaNacimineto {
            get {
                return this.FechaNaciminetoField;
            }
            set {
                if ((this.FechaNaciminetoField.Equals(value) != true)) {
                    this.FechaNaciminetoField = value;
                    this.RaisePropertyChanged("FechaNacimineto");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string IdCliente {
            get {
                return this.IdClienteField;
            }
            set {
                if ((object.ReferenceEquals(this.IdClienteField, value) != true)) {
                    this.IdClienteField = value;
                    this.RaisePropertyChanged("IdCliente");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nombres {
            get {
                return this.NombresField;
            }
            set {
                if ((object.ReferenceEquals(this.NombresField, value) != true)) {
                    this.NombresField = value;
                    this.RaisePropertyChanged("Nombres");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Telefono {
            get {
                return this.TelefonoField;
            }
            set {
                if ((object.ReferenceEquals(this.TelefonoField, value) != true)) {
                    this.TelefonoField = value;
                    this.RaisePropertyChanged("Telefono");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WcfFacturacion.IServiceFacturacion")]
    public interface IServiceFacturacion {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceFacturacion/GetProducto", ReplyAction="http://tempuri.org/IServiceFacturacion/GetProductoResponse")]
        WcfFacturacioClienteWindows.WcfFacturacion.Producto GetProducto(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceFacturacion/GetProducto", ReplyAction="http://tempuri.org/IServiceFacturacion/GetProductoResponse")]
        System.Threading.Tasks.Task<WcfFacturacioClienteWindows.WcfFacturacion.Producto> GetProductoAsync(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceFacturacion/GetProductos", ReplyAction="http://tempuri.org/IServiceFacturacion/GetProductosResponse")]
        WcfFacturacioClienteWindows.WcfFacturacion.Producto[] GetProductos();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceFacturacion/GetProductos", ReplyAction="http://tempuri.org/IServiceFacturacion/GetProductosResponse")]
        System.Threading.Tasks.Task<WcfFacturacioClienteWindows.WcfFacturacion.Producto[]> GetProductosAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceFacturacion/GetClientes", ReplyAction="http://tempuri.org/IServiceFacturacion/GetClientesResponse")]
        WcfFacturacioClienteWindows.WcfFacturacion.Cliente[] GetClientes();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceFacturacion/GetClientes", ReplyAction="http://tempuri.org/IServiceFacturacion/GetClientesResponse")]
        System.Threading.Tasks.Task<WcfFacturacioClienteWindows.WcfFacturacion.Cliente[]> GetClientesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceFacturacion/NewPedido", ReplyAction="http://tempuri.org/IServiceFacturacion/NewPedidoResponse")]
        void NewPedido(System.DateTime Fecha, string idCliente, int idProducto, string notas, bool despachado, int cantidad);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceFacturacion/NewPedido", ReplyAction="http://tempuri.org/IServiceFacturacion/NewPedidoResponse")]
        System.Threading.Tasks.Task NewPedidoAsync(System.DateTime Fecha, string idCliente, int idProducto, string notas, bool despachado, int cantidad);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceFacturacionChannel : WcfFacturacioClienteWindows.WcfFacturacion.IServiceFacturacion, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceFacturacionClient : System.ServiceModel.ClientBase<WcfFacturacioClienteWindows.WcfFacturacion.IServiceFacturacion>, WcfFacturacioClienteWindows.WcfFacturacion.IServiceFacturacion {
        
        public ServiceFacturacionClient() {
        }
        
        public ServiceFacturacionClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceFacturacionClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceFacturacionClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceFacturacionClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public WcfFacturacioClienteWindows.WcfFacturacion.Producto GetProducto(int value) {
            return base.Channel.GetProducto(value);
        }
        
        public System.Threading.Tasks.Task<WcfFacturacioClienteWindows.WcfFacturacion.Producto> GetProductoAsync(int value) {
            return base.Channel.GetProductoAsync(value);
        }
        
        public WcfFacturacioClienteWindows.WcfFacturacion.Producto[] GetProductos() {
            return base.Channel.GetProductos();
        }
        
        public System.Threading.Tasks.Task<WcfFacturacioClienteWindows.WcfFacturacion.Producto[]> GetProductosAsync() {
            return base.Channel.GetProductosAsync();
        }
        
        public WcfFacturacioClienteWindows.WcfFacturacion.Cliente[] GetClientes() {
            return base.Channel.GetClientes();
        }
        
        public System.Threading.Tasks.Task<WcfFacturacioClienteWindows.WcfFacturacion.Cliente[]> GetClientesAsync() {
            return base.Channel.GetClientesAsync();
        }
        
        public void NewPedido(System.DateTime Fecha, string idCliente, int idProducto, string notas, bool despachado, int cantidad) {
            base.Channel.NewPedido(Fecha, idCliente, idProducto, notas, despachado, cantidad);
        }
        
        public System.Threading.Tasks.Task NewPedidoAsync(System.DateTime Fecha, string idCliente, int idProducto, string notas, bool despachado, int cantidad) {
            return base.Channel.NewPedidoAsync(Fecha, idCliente, idProducto, notas, despachado, cantidad);
        }
    }
}