using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MagnusManager.Classes;
using MagnusManager.Persistencia;
using SoftwareSerralheria;



public partial class Pages_Cadastros_CadastrodeMateriais_SobraMateriaPrima_cadastrar : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        txtNome.Focus();
    }

    private void LimparCampos()
    {
        txtNome.Text = "";
        txtUnidade.Text = "";
        txtQuantidade.Text = "";
        txtValorTotal.Text = "";
    }
    protected void btnSalvar_Click(object sender, EventArgs e)
    {

        SobraMateriaPrima sobraMateriaPrima = new SobraMateriaPrima();

        sobraMateriaPrima.Nome = txtNome.Text;
        sobraMateriaPrima.Unidade = Convert.ToString(txtUnidade.Text);
        sobraMateriaPrima.Quantidade = Convert.ToDouble(txtQuantidade.Text);
        sobraMateriaPrima.ValorTotal = Convert.ToDouble(txtValorTotal.Text);

        SobraMateriaPrimaBD bd = new SobraMateriaPrimaBD();
        int retorno = bd.Insert(sobraMateriaPrima);

        switch (retorno)
        {
            case 0:
                LimparCampos();
                txtNome.Focus();
                lblMensagem.Text = "Cadastro realizado com Sucesso!";
                break;

            case 1:
                //Erro no banco de dados
                lblMensagem.Text = "Não foi possível realizar o cadastro.";
                break;
            case 2:
                //Erro geral
                lblMensagem.Text = "Não foi possível realizar o cadastro.";
                break;
            default:
                lblMensagem.Text = "Erro geral.";
                break;
        }
    }

}