using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Pedido
/// </summary>

namespace MagnusManager.Classes
{
    public class Pedido
    {

        public int Cli_id { get; set; }
        public int Pro_id { get; set; }
        public int Cat_id { get; set; }
        public int QtdePro { get; set; }
        public Double Valor { get; set; }
        public DateTime DataPedido { get; set; }
        public DateTime DataEntrega { get; set; }

        public Pedido()
        {

        }
    }

}