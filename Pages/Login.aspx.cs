using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MagnusManager.Classes;
using MagnusManager.Persistencia;

public partial class Pages_Login : System.Web.UI.Page
{

    private bool IsPreenchido(string str)
    {
        bool retorno = false;
        if (str != string.Empty)
        {
            retorno = true;
        }
        return retorno;
    }
    private bool UsuarioEncontrado(Usuario usuario)
    {
        bool retorno = false;
        if (usuario != null)
        {
            retorno = true;
        }
        return retorno;
    }

    protected void Page_Load(object sender, EventArgs e)
    {
      
    }




    protected void btnEntrar_Click(object sender, EventArgs e)
    {
        string email = txtEmail.Text.Trim();
        string senha = txtSenha.Text.Trim();

        if (!IsPreenchido(email))
        {
            lblMensagem.Text = "Preencha o email";
            txtEmail.Focus();
            return;
        }

        if (!IsPreenchido(senha))
        {
            lblMensagem.Text = "Preencha a senha";
            txtSenha.Focus();
            return;
        }

        UsuarioBD bd = new UsuarioBD();
        Usuario usuario = new Usuario();

        usuario = bd.Autentica(email, senha);
        if (!UsuarioEncontrado(usuario))
        {
            lblMensagem.Text = "Usuário não encontrado";
            txtEmail.Focus();
            return;
        }
        Session["ID"] = usuario.Id;
        switch (usuario.Tipo)
        {
            case 0:
                Response.Redirect("TiposdeUsuarios/Gerente/Index.aspx");
                break;
            case 1:
                Response.Redirect("TiposdeUsuarios/Secretario/Index.aspx");
                break;
            case 2:
                Response.Redirect("TiposdeUsuarios/Operario/Index.aspx");
                break;

            default:
                break;
        }
    }


   
}