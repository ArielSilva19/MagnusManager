<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Cadastrar.aspx.cs" Inherits="Pages_Cadastros_CadastrodeMateriais_MateriaPrima_Cadastrar" %>

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

    <form id="CadastroMateriaPrima" runat="server">

        <section id="formulario" style="margin-top:40px; margin-left:25%; margin-right:25%; " >
        <h3 style="text-align:center;">Cadastro de Materia Prima</h3>
        <br /><br />
            <div class="container">
                <div class="row">
                    <div class="col-md-12">

                        <div class="form-group">
                            <asp:Label runat="server" ID="lblNome" Text="Nome da Materia Prima:"></asp:Label>
                            <asp:TextBox runat="server" ID="txtNome" Text="" class="form-control" placeholder="Ex: Metalon." required="required"></asp:TextBox>
                        </div>
                        <br />
                        <div class="form-group">
                            <asp:Label runat="server" ID="lblUnidade" Text="Unidade:"></asp:Label>
                            <asp:TextBox runat="server" ID="txtUnidade" Text="" class="form-control" placeholder="Unidade" required="required"></asp:TextBox>
                        </div>

                        <br />
                        <div class="form-group">
                            <asp:Label runat="server" ID="lblQuantidade" Text="Quantidade:"></asp:Label>
                            <asp:TextBox runat="server" ID="txtQuantidade" Text="" class="form-control" placeholder="Quantidade" required="required"></asp:TextBox>
                        </div>

                        <br />
                        <div class="form-group">
                            <asp:Label runat="server" ID="lblValorUnitario" Text="Valor Unitario:"></asp:Label>
                            <asp:TextBox runat="server" ID="txtValorUnitario" Text="" class="form-control" placeholder="Valor Unitario" required="required"></asp:TextBox>
                        </div>

                        <br />
                        <div class="form-group">
                            <asp:Label runat="server" ID="lblValorTotal" Text="Valor Total:"></asp:Label>
                            <asp:TextBox runat="server" ID="txtValorTotal" Text="" class="form-control" placeholder="Valor Total" required="required"></asp:TextBox>
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
