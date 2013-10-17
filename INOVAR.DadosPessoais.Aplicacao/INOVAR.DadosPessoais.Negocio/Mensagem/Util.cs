using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INOVAR.DadosPessoais.Negocio.Mensagem
{
    public class Util
    {
        public static Dominio.Modelo.tbCliente converteDeWcf(XYZWcf.tbCliente Cliente) {
            var retorno = new Dominio.Modelo.tbCliente();

            if (Cliente.dataNascimento.HasValue)
                retorno.dataNascimento = Cliente.dataNascimento.Value;

            retorno.endereco = Cliente.endereco;
            retorno.IdCliente = Cliente.IdCliente;
            retorno.nome = Cliente.nome;

            if (Cliente.numeroCelular != null)
                retorno.numeroCelular = Cliente.numeroCelular;

            retorno.telefoneResidencial = Cliente.telefoneResidencial;

            return retorno;
        }

        public static XYZWcf.tbCliente converteParaWcf(Dominio.Modelo.tbCliente Cliente) {
            var retorno = new XYZWcf.tbCliente();

            if (Cliente.dataNascimento.HasValue)
                retorno.dataNascimento = Cliente.dataNascimento.Value;

            retorno.endereco = Cliente.endereco;
            retorno.IdCliente = Cliente.IdCliente;
            retorno.nome = Cliente.nome;

            if (Cliente.numeroCelular != null)
                retorno.numeroCelular = Cliente.numeroCelular;

            retorno.telefoneResidencial = Cliente.telefoneResidencial;

            return retorno;
        }
    }
}
