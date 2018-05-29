using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MagnusManager.Classes;
using MagnusManager.Persistencia;
using SoftwareSerralheria;
using System.Data;


    public partial class Pages_Cadastros_CadastrodeProdutos_cadastrar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        if (!Page.IsPostBack)
        {
            CarregaCategoriaProduto();

        }
    }


    private void CarregaCategoriaProduto() //esse codigo vai carregar os itens na dropdownlist 
    {
        ProdutoBD bd = new ProdutoBD();
        DataSet ds = null;
        //verifica qual radiobutton foi clicado

        ddlCategoriaProduto.Items.Clear();
        ds = bd.SelectTipo();

        //vincula dados do ds ao componente ddl
        ddlCategoriaProduto.DataSource = ds.Tables[0].DefaultView;
        ddlCategoriaProduto.DataTextField = "cat_nome";
        ddlCategoriaProduto.DataValueField = "cat_id";
        ddlCategoriaProduto.DataBind();

        //adiciona item "Selecione" na primeira posição do ddl
        ddlCategoriaProduto.Items.Insert(0, new ListItem("Selecione", "0"));

    }

    private void LimparCampos()
        {
            txtNome.Text = "";
            txtDescricao.Text = "";
            txtDimensao.Text = "";
            txtValor.Text = "";
            txtTempo.Text = "";
        }

    protected void BtnSalvar_Click(object sender, EventArgs e)
        {
            Produto produto = new Produto();

            produto.Nome = Convert.ToString(txtNome.Text);
            produto.Categoria = Convert.ToInt32(ddlCategoriaProduto.SelectedItem.Value);
            produto.Descricao = Convert.ToString(txtDescricao.Text);
            produto.Dimensao = Convert.ToString(txtDimensao.Text);
            produto.Valor = Convert.ToDecimal(txtValor.Text);
            produto.Tempo = Convert.ToString(txtTempo.Text);

            ProdutoBD bd = new ProdutoBD();
        if (bd.Insert(produto))
        {
            lblMensagem.Text = "Produto cadastrado com sucesso";
            txtNome.Text = "";
            txtDescricao.Text = "";
            txtDimensao.Text = "";
            txtValor.Text = "";
            txtTempo.Text = "";
        }
        else
        {
            lblMensagem.Text = "Erro ao salvar.";
        }

    }
}