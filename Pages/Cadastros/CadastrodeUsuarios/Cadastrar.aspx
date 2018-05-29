<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Cadastrar.aspx.cs" Inherits="Pages_Cadastros_CadastrodeUsuarios_Cadastrar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
     <link href="~/Content/css/bootstrap.min.css" rel="stylesheet" />
    <script src="~/Scripts/bootstrap.min.js"></script>
    <script src="~/Scripts/jquery-3.3.1.min.js"></script>
</head>
<body class="jumbotron">
     <div class="jumbotron">
    <form id="cadastroProdutos" runat="server">

        <section id="formulario" style="margin-top:40px; margin-left:25%; margin-right:25%">

        <h3 style="text-align:center;">Cadastro de Usuários</h3>
        <br /><br />
            <div class="container">
                <div class="row">
                    <div class="col-md-12">

                        <div class="form-group">
            <asp:Label ID="lblNome" runat="server" Text="Nome completo do Usuário:"></asp:Label> <br />
                            <asp:TextBox runat="server" ID="txtNome" Text="" class="form-control" placeholder="descricao" required="required"></asp:TextBox>
                        </div>

                        <br />
                        <div class="form-group">
            <asp:Label ID="lblCpf" runat="server" Text="CPF:"></asp:Label><br />
                            <asp:TextBox runat="server" ID="txtCpf" Text="" class="form-control" placeholder="Dimensao" required="required"></asp:TextBox>
                        </div>

                        <br />
                        <div class="form-group">
            <asp:Label ID="lblData" runat="server" Text="Data de nascimento:"></asp:Label><br />
                            <asp:TextBox runat="server" ID="txtData" Text="" class="form-control" placeholder="Valor" required="required"></asp:TextBox>
                        </div>

                        <br />
                        <div class="form-group">
            <asp:Label ID="lblEmail" runat="server" Text="E-mail:"></asp:Label><br />
                            <asp:TextBox runat="server" ID="txtEmail" Text="" class="form-control" placeholder="Tempo" required="required"></asp:TextBox>
                        </div>
                        <br />
                         <div class="form-group">
                                    <asp:Label ID="lblSenha" runat="server" Text="Senha:"></asp:Label><br />
                          <asp:TextBox runat="server" ID="txtSenha" Text="" class="form-control" placeholder="Tempo" required="required" TextMode="Password"></asp:TextBox>
                        </div>
                        <br />


                         <div class="form-group">
                                    <asp:Label ID="lblTelefone" runat="server" Text="Telefone:"></asp:Label><br />
                         <asp:TextBox runat="server" ID="txtTelefone" Text="" class="form-control" placeholder="Tempo" required="required"></asp:TextBox>
                        </div>

                        <br />
                                    <asp:Label ID="lblTipo" runat="server" Text="Tipo de usuário do Sistema:"></asp:Label>
            <br />
            <asp:DropDownList ID="ddlTipo" runat="server" OnSelectedIndexChanged="ddlTipo_SelectedIndexChanged">
            <asp:ListItem Selected="True">Escolha um dos itens abaixo:</asp:ListItem>
            <asp:ListItem Value="0">Administrador</asp:ListItem>
            <asp:ListItem Value="1">Secretario</asp:ListItem>
            <asp:ListItem Value="2">Operario</asp:ListItem>
        </asp:DropDownList>
                        <br />
                        <br />
                        <div class="form-group">
                            <asp:Button ID="Button1" runat="server" Text="Salvar" OnClick="btnSalvar_Click" class="btn btn-primary"  />
                        </div>
                        <br />
                        <div class="alert alert-danger" ">
            <asp:Label ID="lblMensagem" runat="server"></asp:Label>
                        </div>

                    </div>

                </div>
            </div>
        

            </section>

                    <br />

&nbsp;<asp:HyperLink ID="hlVoltar" runat="server" NavigateUrl="~/Pages/TiposdeUsuarios/Gerente/Index.aspx">Voltar a tela principal</asp:HyperLink>
            <br />

    </form>

        </div>



</body>
</html>