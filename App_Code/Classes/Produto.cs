using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MagnusManager.Classes
{

    public class Produto        
    {

        public int Categoria { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Dimensao { get; set; }
        public decimal Valor { get; set; }
        public string Tempo { get; set; }

        public Produto()
        {
            //
            // TODO: Add constructor logic here
            //
        }
    }
}