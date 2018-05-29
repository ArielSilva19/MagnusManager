<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Cadastar.aspx.cs" Inherits="Pages_Cadastros_CadastrodeClientes_Cadastar" %>

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
    <form id="cadastroCliente" runat="server">
        <section id="formulario" style="margin-top:40px; margin-left:25%; margin-right:25%; " >
        <h3 style="text-align:center;">Cadastro de Clientes</h3>
        <br /><br />


            <div class="container">
                <div class="row">
                    <div class="col-md-12">

                        <div class="form-group">
                            <asp:Label runat="server" ID="lblNome" Text="Nome do Cliente:"></asp:Label>
                            <asp:TextBox runat="server" ID="txtNome" Text="" class="form-control" placeholder="Nome do Cliente" required="required"     MaxLength="60"></asp:TextBox>
                            <asp:RangeValidator ID="rgNome" ControlToValidate="txtNome" runat="server" ErrorMessage=" O nome deve ter no mínimo 10 e no máximo 60 caracteres!" MinimumValue="10" MaximumValue="60" SetFocusOnError="true" type="String"></asp:RangeValidator>

                        </div>
                        <br />
                        <div class="form-group">
                            <asp:Label runat="server" ID="lblCpf" Text="CPF:"></asp:Label>
                            <asp:TextBox runat="server" ID="txtCpf" Text="" class="form-control" placeholder="CPF" required="required" MaxLength="11"></asp:TextBox>
                            <asp:RangeValidator ID="RangeValidator1" ControlToValidate="txtCpf" runat="server" ErrorMessage=" O nome deve ter no mínimo 10 e no máximo 60 caracteres!" MinimumValue="10" MaximumValue="60" SetFocusOnError="true" type="String"></asp:RangeValidator>

                            </div>

                        <br />

                        <div class="form-group">
                            <asp:Label runat="server" ID="lblEndereco" Text="Endereço:"></asp:Label>
                            <asp:TextBox runat="server" ID="txtEndereco" Text="" class="form-control" placeholder="Endereço" required="required" MaxLength="45"></asp:TextBox>
                        </div>

                        <br />
                        <div class="form-group">
                            <asp:Label runat="server" ID="lblCidade" Text="Cidade:"></asp:Label>
                            <asp:TextBox runat="server" ID="txtCidade" Text="" class="form-control" placeholder="Cidade" required="required" MaxLength="25"></asp:TextBox>
                        </div>

                        <br />
                        <div class="form-group">
                            <asp:Label runat="server" ID="lblEstado" Text="Estado:"></asp:Label>
                            <asp:TextBox runat="server" ID="txtEstado" Text="" class="form-control" placeholder="Estado" required="required" MaxLength="2"></asp:TextBox>
                        </div>

                        <br />
                        <div class="form-group">
                            <asp:Label runat="server" ID="lblTelefone" Text="Telefone:"></asp:Label>
                            <asp:TextBox runat="server" ID="txtTelefone" Text="" class="form-control" placeholder="Telefone" required="required" MaxLength="12"></asp:TextBox>
                        </div>

                        <br />
                        <div class="form-group">
                            <asp:Label runat="server" ID="lblEmail" Text="E-mail:"></asp:Label>
                            <asp:TextBox runat="server" ID="txtEmail" Text="" class="form-control" placeholder="E-mail do Cliente" required="required" MaxLength="60"></asp:TextBox>
                        </div>

                        <br />
                        <div class="form-group">
                            <asp:Button ID="btnSalvar" runat="server" Text="Salvar" OnClick="btnSalvar_Click" class="btn btn-primary"  />
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

