using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XYZ.DadosPessoais.Dominio.Biblioteca;
using System.Data.Entity;

namespace XYZ.DadosPessoais.Negocio
{
    public class Cliente : Dominio.Contrato.ICliente
    {
        public Dominio.Biblioteca.Colecao<Dominio.Modelo.tbCliente> obterClientes(string nome = null)
        {
            var resultado = new Colecao<Dominio.Modelo.tbCliente>();

            using (var db = new Dominio.Modelo.DadosEntities())
            {
                try
                {
                    IQueryable<Dominio.Modelo.tbCliente> Cliente = db.tbCliente;

                    if (!string.IsNullOrEmpty(nome))
                        Cliente = Cliente.Where(p => p.nome.Contains(nome));

                    Cliente = Cliente.OrderBy(p => p.nome);

                    resultado.Lista = Cliente.ToList();

                }
                catch (Exception e)
                {
                    resultado.Sucesso = false;
                    resultado.Mensagem = e.Message;
                }

                return resultado;
            }
        }

        public Dominio.Biblioteca.Instancia<Dominio.Modelo.tbCliente> obterCliente(int idCliente)
        {
            var resultado = new Instancia<Dominio.Modelo.tbCliente>();

            using (var db = new Dominio.Modelo.DadosEntities())
            {
                try
                {
                    IQueryable<Dominio.Modelo.tbCliente> Cliente = db.tbCliente;

                    Cliente = Cliente.Where(p => p.IdCliente == idCliente);

                    Cliente = Cliente.OrderBy(p => p.nome);

                    resultado.Objeto = Cliente.FirstOrDefault();

                }
                catch (Exception e)
                {
                    resultado.Sucesso = false;
                    resultado.Mensagem = e.Message;
                }

                return resultado;
            }
        }

        public Dominio.Biblioteca.Instancia<Dominio.Modelo.tbCliente> salva(Dominio.Modelo.tbCliente Cliente)
        {
            var resultado = new Instancia<Dominio.Modelo.tbCliente>();

            using (var db = new Dominio.Modelo.DadosEntities())
            {
                try
                {
                    var entry = db.Entry(Cliente);

                    if (Cliente.IdCliente > 0)
                        entry.State = System.Data.EntityState.Modified;
                    else
                        entry.State = System.Data.EntityState.Added;

                    int retlinhas = db.SaveChanges();

                    resultado.Objeto = Cliente;

                    if (retlinhas == 0)
                        resultado.Sucesso = false;
                }
                catch (Exception e)
                {
                    resultado.Sucesso = false;
                    resultado.Mensagem = e.Message;
                }

                return resultado;
            }
        }

        public Dominio.Biblioteca.Instancia<Dominio.Modelo.tbCliente> apaga(int idCliente)
        {
            var resultado = new Instancia<Dominio.Modelo.tbCliente>();

            using (var db = new Dominio.Modelo.DadosEntities())
            {
                try
                {
                    var usr = (from u in db.tbCliente
                               where u.IdCliente == idCliente
                               select u).FirstOrDefault();

                    if (usr != null)
                        db.tbCliente.Remove(usr);

                    int retlinhas = db.SaveChanges();

                    resultado.Objeto = usr;

                    if (retlinhas == 0)
                        resultado.Sucesso = false;

                }
                catch (Exception e)
                {
                    resultado.Sucesso = false;
                    resultado.Mensagem = e.Message;
                }

                return resultado;
            }
        }

    }
}
