using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MagnusManager.Classes;
using MagnusManager.Persistencia;
using SoftwareSerralheria;





public partial class Pages_Cadastros_CadastrodeFornecedores_cadastrar : System.Web.UI.Page
{




    protected void Page_Load(object sender, EventArgs e)
    {
        txtNome.Focus();
    }



    private void LimparCampos()
    {
        txtNome.Text = "";
        txtCnpj.Text = "";
        txtNomeContato.Text = "";
        txtEndereco.Text = "";
        txtCidade.Text = "";
        txtEstado.Text = "";
        txtTelefone.Text = "";
        txtEmail.Text = "";
    }




    protected void btnSalvar_Click(object sender, EventArgs e)
    {


        Fornecedor fornecedor = new Fornecedor();

        fornecedor.Nome = txtNome.Text;
        fornecedor.Cnpj = Convert.ToInt64(txtCnpj.Text);
        fornecedor.NomeContato = txtNomeContato.Text;
        fornecedor.Endereco = txtEndereco.Text;
        fornecedor.Cidade = txtCidade.Text;
        fornecedor.Estado = txtEstado.Text;
        fornecedor.Telefone = Convert.ToInt64(txtTelefone.Text);
        fornecedor.Email = txtEmail.Text;


        FornecedorBD bd = new FornecedorBD();
        int retorno = bd.Insert(fornecedor);

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