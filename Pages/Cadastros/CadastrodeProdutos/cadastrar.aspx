<%@ Page Language="C#" AutoEventWireup="true" CodeFile="cadastrar.aspx.cs" Inherits="Pages_Cadastros_CadastrodeProdutos_cadastrar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
 <link href="~/Content/css/bootstrap.min.css" rel="stylesheet" />
    <script src="~/Scripts/bootstrap.min.js"></script>
    <script src="~/Scripts/jquery-3.3.1.min.js"></script>
</head>
<body>
    <div class="jumbotron">
    <form id="cadastroProdutos" runat="server">

        <section id="formulario" style="margin-top:40px; margin-left:25%; margin-right:25%">

        <h3 style="text-align:center;">Cadastro de Produtos</h3>
        <br /><br />
            <div class="container">
                <div class="row">
                    <div class="col-md-12">

                        <div class="form-group">
                            <asp:Label runat="server" ID="lblNome" Text="Nome do Produto:"></asp:Label>
                            <asp:TextBox runat="server" ID="txtNome" Text="" class="form-control" placeholder="Ex: Portao." required="required" Width="445px"></asp:TextBox>
                        </div>
            <br />
            <asp:Label ID="lblCategoria" runat="server" Text="Categoria do Produto:"></asp:Label>
            <br />
                        
                        <br />
            <asp:DropDownList ID="ddlCategoriaProduto" runat="server" Width="471px"></asp:DropDownList>
        
                        <br />
                        <br />
        
            <br />

                        <div class="form-group">
                            <asp:Label runat="server" ID="lblDescricao" Text="Descrição:"></asp:Label>
                            <asp:TextBox runat="server" ID="txtDescricao" Text="" class="form-control" placeholder="descricao" required="required" Height="94px" TextMode="MultiLine" Width="574px"></asp:TextBox>
                        </div>

                        <br />
                        <div class="form-group">
                            <asp:Label runat="server" ID="lblDimensao" Text="Dimensão:"></asp:Label>
                            <asp:TextBox runat="server" ID="txtDimensao" Text="" class="form-control" placeholder="Dimensao" required="required"></asp:TextBox>
                        </div>

                        <br />
                        <div class="form-group">
                            <asp:Label runat="server" ID="lblValor" Text="Valor:"></asp:Label>
                            <asp:TextBox runat="server" ID="txtValor" Text="" class="form-control" placeholder="Valor" required="required"></asp:TextBox>
                        </div>

                        <br />
                        <div class="form-group">
                            <asp:Label runat="server" ID="lblTempo" Text="Tempo:"></asp:Label>
                            <asp:TextBox runat="server" ID="txtTempo" Text="" class="form-control" placeholder="Tempo" required="required"></asp:TextBox>
                        </div>

                        <br />
                        <div class="form-group">
                            <asp:Button ID="btnSalvar" runat="server" Text="Salvar" OnClick="BtnSalvar_Click" class="btn btn-primary"  />
                        </div>
                        <br />
                        <div class="alert alert-danger" ">
                            <asp:Label runat="server" ID="lblMensagem" Text="" ></asp:Label>
                        </div>

                    </div>

                </div>
            </div>
        

            </section>
    </form>

        </div>
</body>
</html>
