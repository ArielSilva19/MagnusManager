using MagnusManager.Classes;
using MagnusManager.Persistencia;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pages_Cadastros_CadastrodePedidos_Cadastrar : System.Web.UI.Page
{
    private void LimparCampos()
    {


    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            CarregaDDL1();
            
        }
        if (!Page.IsPostBack)
        {
            CarregaDDL2();

        }
        if (!Page.IsPostBack)
        {
            CarregaDDL3();

        }

    }
    // esse codigo vc vai incluir no aspx.cs do seu codigo 
    private void CarregaDDL1() //esse codigo vai carregar os itens na dropdownlist 
    {
        PedidoBD bd = new PedidoBD();
        DataSet ds = null;

        ddlCliente.Items.Clear();
        ds = bd.SelectUm();
        //vincula dados do ds ao componente ddl
        ddlCliente.DataSource = ds.Tables[0].DefaultView;
        ddlCliente.DataTextField = "cli_nome";
        ddlCliente.DataValueField = "cli_id";
        ddlCliente.DataBind();
        //adiciona item "Selecione" na primeira posição do ddl
        ddlCliente.Items.Insert(0, new ListItem("Selecione", "0"));

    }

    private void CarregaDDL2() //esse codigo vai carregar os itens na dropdownlist 
    {
        PedidoBD bd = new PedidoBD();
        DataSet ds = null;
        //verifica qual radiobutton foi clicado

        ddlProduto.Items.Clear();
        ds = bd.SelectDois();
        //vincula dados do ds ao componente ddl
        ddlProduto.DataSource = ds.Tables[0].DefaultView;
        ddlProduto.DataTextField = "pro_nome";
        ddlProduto.DataValueField = "pro_id";
        ddlProduto.DataBind();
        //adiciona item "Selecione" na primeira posição do ddl
        ddlProduto.Items.Insert(0, new ListItem("Selecione", "0"));

    }

    private void CarregaDDL3() //esse codigo vai carregar os itens na dropdownlist 
    {
        PedidoBD bd = new PedidoBD();
        DataSet ds = null;

        ddlTipo.Items.Clear();
        ds = bd.SelectTres();
        //vincula dados do ds ao componente ddl
        ddlTipo.DataSource = ds.Tables[0].DefaultView;
        ddlTipo.DataTextField = "cat_nome";
        ddlTipo.DataValueField = "cat_id";
        ddlTipo.DataBind();
        //adiciona item "Selecione" na primeira posição do ddl
        ddlTipo.Items.Insert(0, new ListItem("Selecione", "0"));

    }


    protected void btnAdicionar_Click(object sender, EventArgs e)
    {

    }

    protected void btnRemover_Click(object sender, EventArgs e)
    {

    }

    protected void btnSalvar_Click(object sender, EventArgs e)
    {

        Pedido pedido = new Pedido();

        pedido.Cli_id = Convert.ToInt32(ddlCliente.SelectedItem.Value);
        pedido.Pro_id = Convert.ToInt32(ddlProduto.SelectedItem.Value);
        pedido.Cat_id = Convert.ToInt32(ddlTipo.SelectedItem.Value);
        pedido.QtdePro = Convert.ToInt32(txtQtdePro.Text);
        pedido.Valor = Convert.ToDouble(txtValor.Text);
        pedido.DataPedido = Convert.ToDateTime(txtDataPedido.Text);
        pedido.DataEntrega = Convert.ToDateTime(txtDataEntrega.Text);


        PedidoBD bd = new PedidoBD();

        if (bd.Insert(pedido))
        {
            LimparCampos();
            lblMensagem.Text = "Cadastro realizado com Sucesso!";

            txtQtdePro.Text = "";
            txtValor.Text = "";
            txtDataPedido.Text = "";
            txtDataEntrega.Text = "";
        }
        else
        {
            lblMensagem.Text = "Erro!";

        }






    }
}
