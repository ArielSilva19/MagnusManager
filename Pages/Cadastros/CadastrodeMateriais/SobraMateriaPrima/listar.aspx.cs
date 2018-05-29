using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using MagnusManager.Persistencia;


public partial class Pages_Cadastros_CadastrodeMateriais_SobraMateriaPrima_listar : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {
        SobraMateriaPrimaBD bd = new SobraMateriaPrimaBD();
        DataSet ds = bd.SelectAll();
        //verifica a quantidade de Sobras
        int quantidade = ds.Tables[0].Rows.Count;
        if (quantidade > 0)
        {
            GridViewSobras.DataSource = ds.Tables[0].DefaultView;
            GridViewSobras.DataBind();
 //           lblMensagem.Text = "Existem " + quantidade + " engenheiros cadastrados";
        }
        else
        {
 //          lblMensagem.Text = "Nenhum material na Sobra";
        }


    }
}