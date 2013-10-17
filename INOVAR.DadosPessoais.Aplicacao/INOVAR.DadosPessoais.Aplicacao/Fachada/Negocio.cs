using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace INOVAR.DadosPessoais.Aplicacao.Fachada
{
    public class Negocio
    {
        private static Dominio.Contrato.ICliente _Cliente = null;
        public static Dominio.Contrato.ICliente Cliente
        {
            get
            {
                if (_Cliente == null)
                    _Cliente = new INOVAR.DadosPessoais.Negocio.Cliente();

                return _Cliente;
            }
        }
    }
}