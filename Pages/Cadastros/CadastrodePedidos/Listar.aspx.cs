using MagnusManager.Persistencia;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pages_Cadastros_CadastrodePedidos_Listar : System.Web.UI.Page
{
    private void Carrega()
    {
        PedidoBD bd = new PedidoBD();
        DataSet ds = bd.SelectAll();
        grvPedido.DataSource = ds.Tables[0].DefaultView;
        grvPedido.DataBind();
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        Carrega();
    }
}