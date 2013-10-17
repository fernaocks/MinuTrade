using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INOVAR.DadosPessoais.Negocio
{
    public class Cliente:Dominio.Contrato.ICliente
    {

        public Dominio.Biblioteca.Colecao<Dominio.Modelo.tbCliente> obterClientes(string nome = null)
        {
            var retorno = new Dominio.Biblioteca.Colecao<Dominio.Modelo.tbCliente>();

            try
            {
                var xyz = new XYZWcf.ClienteClient();
                var clientes = xyz.obterClientes(nome);

                foreach (var item in clientes.Lista)
                {
                    retorno.Lista.Add(Mensagem.Util.converteDeWcf(item));
                }

                return retorno;
            }
            catch (Exception ex)
            {
                retorno.Sucesso = false;
                retorno.Mensagem = ex.Message;
                return retorno;
            }

            
        }

        public Dominio.Biblioteca.Instancia<Dominio.Modelo.tbCliente> obterCliente(int idCliente)
        {
            var retorno = new Dominio.Biblioteca.Instancia<Dominio.Modelo.tbCliente>();

            try
            {
                var xyz = new XYZWcf.ClienteClient();
                var cliente = xyz.obterCliente(idCliente);

                retorno.Objeto = new Dominio.Modelo.tbCliente();

                retorno.Objeto = Mensagem.Util.converteDeWcf(cliente.Objeto);

                return retorno;
            }
            catch (Exception ex)
            {

                retorno.Sucesso = false;
                retorno.Mensagem = ex.Message;
                return retorno;
            }
        }

        public Dominio.Biblioteca.Instancia<Dominio.Modelo.tbCliente> salva(Dominio.Modelo.tbCliente Cliente)
        {
            var retorno = new Dominio.Biblioteca.Instancia<Dominio.Modelo.tbCliente>();

            try
            {
                var xyz = new XYZWcf.ClienteClient();
                var wsCliente = Mensagem.Util.converteParaWcf(Cliente);

                var salva = xyz.salva(wsCliente);

                retorno.Objeto = new Dominio.Modelo.tbCliente();

                retorno.Objeto = Mensagem.Util.converteDeWcf(wsCliente);

                return retorno;
            }
            catch (Exception ex)
            {
                retorno.Sucesso = false;
                retorno.Mensagem = ex.Message;

                return retorno;
            }
        }

        public Dominio.Biblioteca.Instancia<Dominio.Modelo.tbCliente> apaga(int idCliente)
        {
            var retorno = new Dominio.Biblioteca.Instancia<Dominio.Modelo.tbCliente>();

            try
            {
                var xyz = new XYZWcf.ClienteClient();
                var apaga = xyz.apaga(idCliente);

                retorno.Objeto = new Dominio.Modelo.tbCliente();

                retorno.Objeto = Mensagem.Util.converteDeWcf(apaga.Objeto);

                return retorno;
            }
            catch (Exception ex)
            {
                retorno.Sucesso = false;
                retorno.Mensagem = ex.Message;
                return retorno;
            }

            
        }
    }
}
