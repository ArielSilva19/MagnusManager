using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Fornecedor  ///   Commit Zezim programador, sou zikaa!
/// </summary>

namespace MagnusManager.Classes
{
    public class Cliente
    {
        public int Id { get; set; }
        public String Nome { get; set; }
        public long Cpf { get; set; }
        public String Endereco { get; set; }
        public String Cidade { get; set; }
        public String Estado { get; set; }
        public long Telefone { get; set; }
        public String Email { get; set; }

        public Cliente()
        {

        }
    }
}