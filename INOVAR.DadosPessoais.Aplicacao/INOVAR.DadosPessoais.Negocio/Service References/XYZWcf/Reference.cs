﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18052
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace INOVAR.DadosPessoais.Negocio.XYZWcf {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ColecaoOftbClienteg4i8yo8o", Namespace="http://schemas.datacontract.org/2004/07/XYZ.DadosPessoais.Dominio.Biblioteca")]
    [System.SerializableAttribute()]
    public partial class ColecaoOftbClienteg4i8yo8o : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private INOVAR.DadosPessoais.Negocio.XYZWcf.tbCliente[] ListaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MensagemField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool SucessoField;
        
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
        public INOVAR.DadosPessoais.Negocio.XYZWcf.tbCliente[] Lista {
            get {
                return this.ListaField;
            }
            set {
                if ((object.ReferenceEquals(this.ListaField, value) != true)) {
                    this.ListaField = value;
                    this.RaisePropertyChanged("Lista");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Mensagem {
            get {
                return this.MensagemField;
            }
            set {
                if ((object.ReferenceEquals(this.MensagemField, value) != true)) {
                    this.MensagemField = value;
                    this.RaisePropertyChanged("Mensagem");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool Sucesso {
            get {
                return this.SucessoField;
            }
            set {
                if ((this.SucessoField.Equals(value) != true)) {
                    this.SucessoField = value;
                    this.RaisePropertyChanged("Sucesso");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="tbCliente", Namespace="http://schemas.datacontract.org/2004/07/XYZ.DadosPessoais.Dominio.Modelo")]
    [System.SerializableAttribute()]
    public partial class tbCliente : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdClienteField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.DateTime> dataNascimentoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string enderecoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string nomeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string numeroCelularField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string telefoneResidencialField;
        
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
        public int IdCliente {
            get {
                return this.IdClienteField;
            }
            set {
                if ((this.IdClienteField.Equals(value) != true)) {
                    this.IdClienteField = value;
                    this.RaisePropertyChanged("IdCliente");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> dataNascimento {
            get {
                return this.dataNascimentoField;
            }
            set {
                if ((this.dataNascimentoField.Equals(value) != true)) {
                    this.dataNascimentoField = value;
                    this.RaisePropertyChanged("dataNascimento");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string endereco {
            get {
                return this.enderecoField;
            }
            set {
                if ((object.ReferenceEquals(this.enderecoField, value) != true)) {
                    this.enderecoField = value;
                    this.RaisePropertyChanged("endereco");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string nome {
            get {
                return this.nomeField;
            }
            set {
                if ((object.ReferenceEquals(this.nomeField, value) != true)) {
                    this.nomeField = value;
                    this.RaisePropertyChanged("nome");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string numeroCelular {
            get {
                return this.numeroCelularField;
            }
            set {
                if ((object.ReferenceEquals(this.numeroCelularField, value) != true)) {
                    this.numeroCelularField = value;
                    this.RaisePropertyChanged("numeroCelular");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string telefoneResidencial {
            get {
                return this.telefoneResidencialField;
            }
            set {
                if ((object.ReferenceEquals(this.telefoneResidencialField, value) != true)) {
                    this.telefoneResidencialField = value;
                    this.RaisePropertyChanged("telefoneResidencial");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="InstanciaOftbClienteg4i8yo8o", Namespace="http://schemas.datacontract.org/2004/07/XYZ.DadosPessoais.Dominio.Biblioteca")]
    [System.SerializableAttribute()]
    public partial class InstanciaOftbClienteg4i8yo8o : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MensagemField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private INOVAR.DadosPessoais.Negocio.XYZWcf.tbCliente ObjetoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool SucessoField;
        
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
        public string Mensagem {
            get {
                return this.MensagemField;
            }
            set {
                if ((object.ReferenceEquals(this.MensagemField, value) != true)) {
                    this.MensagemField = value;
                    this.RaisePropertyChanged("Mensagem");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public INOVAR.DadosPessoais.Negocio.XYZWcf.tbCliente Objeto {
            get {
                return this.ObjetoField;
            }
            set {
                if ((object.ReferenceEquals(this.ObjetoField, value) != true)) {
                    this.ObjetoField = value;
                    this.RaisePropertyChanged("Objeto");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool Sucesso {
            get {
                return this.SucessoField;
            }
            set {
                if ((this.SucessoField.Equals(value) != true)) {
                    this.SucessoField = value;
                    this.RaisePropertyChanged("Sucesso");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="XYZWcf.ICliente")]
    public interface ICliente {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICliente/obterClientes", ReplyAction="http://tempuri.org/ICliente/obterClientesResponse")]
        INOVAR.DadosPessoais.Negocio.XYZWcf.ColecaoOftbClienteg4i8yo8o obterClientes(string nome);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICliente/obterClientes", ReplyAction="http://tempuri.org/ICliente/obterClientesResponse")]
        System.Threading.Tasks.Task<INOVAR.DadosPessoais.Negocio.XYZWcf.ColecaoOftbClienteg4i8yo8o> obterClientesAsync(string nome);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICliente/obterCliente", ReplyAction="http://tempuri.org/ICliente/obterClienteResponse")]
        INOVAR.DadosPessoais.Negocio.XYZWcf.InstanciaOftbClienteg4i8yo8o obterCliente(int idCliente);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICliente/obterCliente", ReplyAction="http://tempuri.org/ICliente/obterClienteResponse")]
        System.Threading.Tasks.Task<INOVAR.DadosPessoais.Negocio.XYZWcf.InstanciaOftbClienteg4i8yo8o> obterClienteAsync(int idCliente);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICliente/salva", ReplyAction="http://tempuri.org/ICliente/salvaResponse")]
        INOVAR.DadosPessoais.Negocio.XYZWcf.InstanciaOftbClienteg4i8yo8o salva(INOVAR.DadosPessoais.Negocio.XYZWcf.tbCliente Cliente);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICliente/salva", ReplyAction="http://tempuri.org/ICliente/salvaResponse")]
        System.Threading.Tasks.Task<INOVAR.DadosPessoais.Negocio.XYZWcf.InstanciaOftbClienteg4i8yo8o> salvaAsync(INOVAR.DadosPessoais.Negocio.XYZWcf.tbCliente Cliente);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICliente/apaga", ReplyAction="http://tempuri.org/ICliente/apagaResponse")]
        INOVAR.DadosPessoais.Negocio.XYZWcf.InstanciaOftbClienteg4i8yo8o apaga(int idCliente);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICliente/apaga", ReplyAction="http://tempuri.org/ICliente/apagaResponse")]
        System.Threading.Tasks.Task<INOVAR.DadosPessoais.Negocio.XYZWcf.InstanciaOftbClienteg4i8yo8o> apagaAsync(int idCliente);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IClienteChannel : INOVAR.DadosPessoais.Negocio.XYZWcf.ICliente, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ClienteClient : System.ServiceModel.ClientBase<INOVAR.DadosPessoais.Negocio.XYZWcf.ICliente>, INOVAR.DadosPessoais.Negocio.XYZWcf.ICliente {
        
        public ClienteClient() {
        }
        
        public ClienteClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ClienteClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ClienteClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ClienteClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public INOVAR.DadosPessoais.Negocio.XYZWcf.ColecaoOftbClienteg4i8yo8o obterClientes(string nome) {
            return base.Channel.obterClientes(nome);
        }
        
        public System.Threading.Tasks.Task<INOVAR.DadosPessoais.Negocio.XYZWcf.ColecaoOftbClienteg4i8yo8o> obterClientesAsync(string nome) {
            return base.Channel.obterClientesAsync(nome);
        }
        
        public INOVAR.DadosPessoais.Negocio.XYZWcf.InstanciaOftbClienteg4i8yo8o obterCliente(int idCliente) {
            return base.Channel.obterCliente(idCliente);
        }
        
        public System.Threading.Tasks.Task<INOVAR.DadosPessoais.Negocio.XYZWcf.InstanciaOftbClienteg4i8yo8o> obterClienteAsync(int idCliente) {
            return base.Channel.obterClienteAsync(idCliente);
        }
        
        public INOVAR.DadosPessoais.Negocio.XYZWcf.InstanciaOftbClienteg4i8yo8o salva(INOVAR.DadosPessoais.Negocio.XYZWcf.tbCliente Cliente) {
            return base.Channel.salva(Cliente);
        }
        
        public System.Threading.Tasks.Task<INOVAR.DadosPessoais.Negocio.XYZWcf.InstanciaOftbClienteg4i8yo8o> salvaAsync(INOVAR.DadosPessoais.Negocio.XYZWcf.tbCliente Cliente) {
            return base.Channel.salvaAsync(Cliente);
        }
        
        public INOVAR.DadosPessoais.Negocio.XYZWcf.InstanciaOftbClienteg4i8yo8o apaga(int idCliente) {
            return base.Channel.apaga(idCliente);
        }
        
        public System.Threading.Tasks.Task<INOVAR.DadosPessoais.Negocio.XYZWcf.InstanciaOftbClienteg4i8yo8o> apagaAsync(int idCliente) {
            return base.Channel.apagaAsync(idCliente);
        }
    }
}
