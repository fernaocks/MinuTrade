using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace XYZ.DadosPessoais.WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface ICliente
    {

        [OperationContract]
        Dominio.Biblioteca.Colecao<Dominio.Modelo.tbCliente> obterClientes(string nome = null);

        [OperationContract]
        Dominio.Biblioteca.Instancia<Dominio.Modelo.tbCliente> obterCliente(int idCliente);

        [OperationContract]
        Dominio.Biblioteca.Instancia<Dominio.Modelo.tbCliente> salva(Dominio.Modelo.tbCliente Cliente);

        [OperationContract]
        Dominio.Biblioteca.Instancia<Dominio.Modelo.tbCliente> apaga(int idCliente);

        
    }
}
