using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MagnusManager.Classes
{
    /// <summary>
    /// Summary description for Usuario
    /// </summary>
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public long Cpf { get; set; }
        public string Data { get; set; }
        public long Telefone { get; set; }
        public int Tipo { get; set;}
        public Usuario()
        {
            //
            // TODO: Add constructor logic here
            //
        }
    }
}