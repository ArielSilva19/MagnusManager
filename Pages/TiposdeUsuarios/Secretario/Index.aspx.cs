﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MagnusManager.Classes;
using MagnusManager.Persistencia;

public partial class Pages_TiposdeUsuarios_Secretario_Index : System.Web.UI.Page
{
    private bool IsSecretario(int tipo)
    {
        bool retorno = false;
        if (tipo == 1)
        {
            retorno = true;
        }
        return retorno;
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        int id = Convert.ToInt32(Session["ID"]);
        UsuarioBD bd = new UsuarioBD();
        Usuario usuario = bd.Select(id);

        if (!IsSecretario(usuario.Tipo))
        {
            Response.Redirect("../../ErrosdeAcesso/AcessoNegado.aspx");
        }
        else
        {
            lblTitulo.Text = "Bem vindo (Secretario) : " + usuario.Nome;
        }
    }

    protected void lbSair_Click(object sender, EventArgs e)
    {
        Session.Abandon();
        Session.Clear();
        Session.RemoveAll();
        Response.Redirect("../../Login.aspx");
    }
}