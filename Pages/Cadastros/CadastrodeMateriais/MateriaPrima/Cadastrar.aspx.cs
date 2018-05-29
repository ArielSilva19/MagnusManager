using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MagnusManager.Classes;
using MagnusManager.Persistencia;
using SoftwareSerralheria;

public partial class Pages_Cadastros_CadastrodeMateriais_MateriaPrima_Cadastrar : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {
        txtNome.Focus();

    }

    private void LimparCampos()
    {

    }

    protected void btnSalvar_Click(object sender, EventArgs e)
    {
        MateriaPrima MateriaPrima = new MateriaPrima();

        MateriaPrima.Nome = txtNome.Text;
        MateriaPrima.Unidade = Convert.ToString(txtUnidade.Text);
        MateriaPrima.Quantidade = Convert.ToDouble(txtQuantidade.Text);
        MateriaPrima.ValorUnitario = Convert.ToDouble(txtValorUnitario.Text);
        MateriaPrima.ValorTotal = Convert.ToDouble(txtValorTotal.Text);

        MateriaPrimaBD bd = new MateriaPrimaBD();
        if (bd.Insert(MateriaPrima))
        {
            LimparCampos();
            lblMensagem.Text = "Cadastro realizado com Sucesso!";

            txtNome.Text = "";
            txtUnidade.Text = "";
            txtQuantidade.Text = "";
            txtValorUnitario.Text = "";
            txtValorTotal.Text = "";
        }
        else
        {
            lblMensagem.Text = "Erro!";

        }

    }
}