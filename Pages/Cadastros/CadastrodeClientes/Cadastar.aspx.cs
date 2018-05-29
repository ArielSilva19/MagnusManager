using MagnusManager.Classes;
using MagnusManager.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pages_Cadastros_CadastrodeClientes_Cadastar : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        txtNome.Focus();
    }






    private void LimparCampos()
    {
        txtNome.Text = "";
        txtCpf.Text = "";
        txtEndereco.Text = "";
        txtCidade.Text = "";
        txtEstado.Text = "";
        txtTelefone.Text = "";
        txtEmail.Text = "";
    }
    protected void btnSalvar_Click(object sender, EventArgs e)
    {
        Cliente cliente = new Cliente();

        cliente.Nome = txtNome.Text;
        cliente.Cpf = Convert.ToInt64(txtCpf.Text);
        cliente.Endereco = txtEndereco.Text;
        cliente.Cidade = txtCidade.Text;
        cliente.Estado = txtEstado.Text;
        cliente.Telefone = Convert.ToInt64(txtTelefone.Text);
        cliente.Email = txtEmail.Text;


        ClienteBD bd = new ClienteBD();


        int retorno = bd.Insert(cliente);

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
      /*  if (bd.Insert(cliente))
        {
            lblMensagem.Text = "Produto cadastrado com sucesso";
            txtNome.Text = "";
            txtCpf.Text = "";
            txtEndereco.Text = "";
            txtCidade.Text = "";
            txtEstado.Text = "";
            txtTelefone.Text = "";
            txtEmail.Text = "";
        }
        else
        {
            lblMensagem.Text = "Erro ao salvar.";
        }

    }
}
*/