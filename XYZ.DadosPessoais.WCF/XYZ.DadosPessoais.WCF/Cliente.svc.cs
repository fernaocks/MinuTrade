using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace XYZ.DadosPessoais.WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Cliente : ICliente
    {
        public Dominio.Biblioteca.Colecao<Dominio.Modelo.tbCliente> obterClientes(string nome = null)
        {
            return Fachada.Negocio.Cliente.obterClientes(nome);
        }

        public Dominio.Biblioteca.Instancia<Dominio.Modelo.tbCliente> obterCliente(int idCliente)
        {
            return Fachada.Negocio.Cliente.obterCliente(idCliente);
        }


        public Dominio.Biblioteca.Instancia<Dominio.Modelo.tbCliente> salva(Dominio.Modelo.tbCliente Cliente)
        {
            return Fachada.Negocio.Cliente.salva(Cliente);
        }

        public Dominio.Biblioteca.Instancia<Dominio.Modelo.tbCliente> apaga(int idCliente)
        {
            return Fachada.Negocio.Cliente.apaga(idCliente);
        }
    }
}
