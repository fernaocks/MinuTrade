using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYZ.DadosPessoais.Dominio.Biblioteca
{
    public class Colecao<T>
    {
        public bool Sucesso{get;set;}
        public string Mensagem { get; set; }
        public List<T> Lista { get; set; }

        public Colecao() {
            Sucesso = true;
            Lista = new List<T>();
        }
    }
}
