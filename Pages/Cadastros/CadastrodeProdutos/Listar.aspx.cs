using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MagnusManager.Persistencia;
using System.Data;

public partial class Pages_Cadastros_CadastrodeProdutos_Listar : System.Web.UI.Page
{
    private void Carrega()
    {
        ProdutoBD bd = new ProdutoBD();
        DataSet ds = bd.SelectAll();
        grvProdutos.DataSource = ds.Tables[0].DefaultView;
        grvProdutos.DataBind();
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        Carrega();

    }
}