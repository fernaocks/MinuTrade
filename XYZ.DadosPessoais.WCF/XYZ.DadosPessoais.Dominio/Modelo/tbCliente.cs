//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace XYZ.DadosPessoais.Dominio.Modelo
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbCliente
    {
        public int IdCliente { get; set; }
        public string nome { get; set; }
        public string telefoneResidencial { get; set; }
        public string endereco { get; set; }
        public Nullable<System.DateTime> dataNascimento { get; set; }
        public string numeroCelular { get; set; }
    }
}
