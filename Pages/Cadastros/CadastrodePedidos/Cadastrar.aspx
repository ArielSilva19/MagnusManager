<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Cadastrar.aspx.cs" Inherits="Pages_Cadastros_CadastrodePedidos_Cadastrar" %>

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
    <form id="cadastrarPedido" runat="server">
        <section id="formulario" style="margin-top:40px; margin-left:25%; margin-right:25%; " >
        <h3 style="text-align:center;">Cadastro de Pedidos</h3>
        <br /><br />
            <div class="container">
                <div class="row">
                    <div class="col-md-12">

                        <div class="form-group">
                            <asp:Label runat="server" ID="lblCliente" Text="Cliente:"></asp:Label>
                            <br />
                            <asp:DropDownList ID="ddlCliente" runat="server" Height="35px" Width="493px" >
                            </asp:DropDownList>

                            &nbsp;</div>
                        <br />
  
                        <div class="form-group">
                            <asp:Label runat="server" ID="lblProduto" Text="Produto:"></asp:Label>
                            &nbsp;<br />
                            <asp:DropDownList ID="ddlProduto" runat="server" Height="35px" Width="204px">
                            </asp:DropDownList>

                        </div>

                        <br />

                        <div class="form-group">
                            <asp:Label runat="server" ID="lblTipo" Text="Tipo:"></asp:Label>

                            <br />

                            <asp:DropDownList ID="ddlTipo" runat="server" Height="35px" Width="185px">
                            </asp:DropDownList>

                        </div>

                        <br />
                        <div class="form-group">
                            <asp:Label runat="server" ID="lblQtdePro" Text="Total de Produtos:"></asp:Label>
                            <asp:TextBox runat="server" ID="txtQtdePro" Text="" class="form-control"  required="required" MaxLength="9" Width="180px" Height="35px"></asp:TextBox>

                        </div>

                        <br />
                        <div class="form-group">
                            <asp:Label runat="server" ID="lblValor" Text="Valor do pedido:"></asp:Label>
                           <asp:TextBox runat="server" ID="txtValor" Text="" class="form-control"  required="required" MaxLength="10" Height="35px" Width="180px"></asp:TextBox>

                        </div>

                        <br />
                        <div class="form-group">
                            <asp:Label runat="server" ID="lblDataPedido" Text="Data do Pedido:"></asp:Label>
                            <asp:TextBox runat="server" ID="txtDataPedido" Text="" class="form-control" placeholder="dd/mm/aaaa" required="required" MaxLength="11" Height="35px" Width="180px"></asp:TextBox>

                        </div>

                        <br />
                        <div class="form-group">
                            <asp:Label runat="server" ID="lblDataEntrega" Text="Data do Entrega:"></asp:Label>
                            <asp:TextBox runat="server" ID="txtDataEntrega" Text="" class="form-control" placeholder="dd/mm/aaaa" required="required" MaxLength="11" Height="34px" Width="180px"></asp:TextBox>


                            <br />
                            <br />


                        </div>
                        <br />
                        <br />
                        <br />
                        <div class="form-group">
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="btnSalvar" runat="server" Text="Salvar" OnClick="btnSalvar_Click" class="btn btn-primary" Height="38px" Width="82px"  />

                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

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

