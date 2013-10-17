using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INOVAR.DadosPessoais.Dominio.Contrato
{
    public interface ICliente
    {
        /// <summary>
        /// Retorna os clientes cadastrados no sistema com opção de filtro por nome
        /// </summary>
        /// <param name="nome">Nome do cliente que deve ser pesquisado</param>
        /// <returns>Retorna uma coleção com os clientes pesquisados</returns>
        Biblioteca.Colecao<Modelo.tbCliente> obterClientes(string nome = null);

        /// <summary>
        /// Retorna uma única instancia de cliente a partir do id
        /// </summary>
        /// <param name="idCliente">ID do cliente que deve ser recuperado</param>
        /// <returns>Instancia do Cliente</returns>
        Biblioteca.Instancia<Modelo.tbCliente> obterCliente(int idCliente);

        /// <summary>
        /// Salva a entidade no banco de dados
        /// </summary>
        /// <param name="Cliente">Instancia do cliente</param>
        /// <returns>instancia do cliente atualizada</returns>
        Biblioteca.Instancia<Modelo.tbCliente> salva(Modelo.tbCliente Cliente);

        /// <summary>
        /// Apaga o registro
        /// </summary>
        /// <param name="idCliente">Codigo do cliente</param>
        /// <returns></returns>
        Biblioteca.Instancia<Modelo.tbCliente> apaga(int idCliente);


    }
}
