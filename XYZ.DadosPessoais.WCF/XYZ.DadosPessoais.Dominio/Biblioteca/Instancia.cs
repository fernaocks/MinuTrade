using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYZ.DadosPessoais.Dominio.Biblioteca
{
    public class Instancia<T>
    {
        public bool Sucesso { get; set; }
        public string Mensagem { get; set; }
        public T Objeto { get; set; }

        public Instancia() {
            Sucesso = true;
        }
    }
}
