using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MagnusManager.Classes;
using MagnusManager.Persistencia;

public partial class Pages_Cadastros_CadastrodeUsuarios_Cadastrar : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void ddlTipo_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void btnSalvar_Click(object sender, EventArgs e)
    {
        Usuario usuario = new Usuario();
        usuario.Nome = txtNome.Text;
        usuario.Cpf = Convert.ToInt64(txtCpf.Text);
        usuario.Data = txtData.Text;
        usuario.Email = txtEmail.Text;
        usuario.Telefone = Convert.ToInt64(txtTelefone.Text);
        usuario.Senha = txtSenha.Text;
        usuario.Tipo = Convert.ToInt32(ddlTipo.SelectedValue);
        UsuarioBD bd = new UsuarioBD();
        if (bd.Insert(usuario))
        {
            lblMensagem.Text = "Usuário cadastrado com sucesso";
            txtNome.Text = "";
            txtCpf.Text = "";
            txtData.Text = "";
            txtEmail.Text = "";
            txtSenha.Text = "";
            txtTelefone.Text = "";
        }
        else
        {
            lblMensagem.Text = "Erro ao salvar.";
        }

    }



}