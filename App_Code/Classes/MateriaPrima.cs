using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MagnusManager.Classes
{

    public class MateriaPrima
    {

        public int Id { get; set; }
        public String Nome { get; set; }
        public String Unidade { get; set; }
        public Double Quantidade { get; set; }
        public Double ValorUnitario { get; set; }
        public Double ValorTotal { get; set; }

        public MateriaPrima()
        {
            
        }
    }
}