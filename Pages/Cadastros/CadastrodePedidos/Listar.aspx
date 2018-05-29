<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Listar.aspx.cs" Inherits="Pages_Cadastros_CadastrodePedidos_Listar" %>

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
    <form id="cadastroPedido" runat="server">
        <section id="formulario" style="margin-top:40px; margin-left:25%; margin-right:25%; " >
        <h3 style="text-align:center;">Lista de Pedidos</h3>
        <br /><br />
            <div class="container">
                <div class="row">
                    <div class="col-md-12">

                        <div class="form-group">
                            <asp:GridView ID="grvPedido" runat="server" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Horizontal" AutoGenerateColumns="False" Width="900px">
                                <Columns>
                                    <asp:BoundField HeaderText="Cliente" DataField="cli_nome" />
                                    <asp:BoundField HeaderText="Produto"  DataField="pro_nome"/>
                                    <asp:BoundField HeaderText="Tipo" DataField="cat_nome"/>
                                    <asp:BoundField HeaderText="Descrição" DataField="pro_descricao"/>
                                    <asp:BoundField HeaderText="Total de Produtos"  DataField="ped_qtde_pro"  />
                                    <asp:BoundField HeaderText="Valor do Pedido" DataField="ped_valor" />
                                    <asp:BoundField HeaderText="Data do Pedido" DataField="ped_data_pedido"/>
                                    <asp:BoundField HeaderText="Data de Entrega" DataField="ped_data_entrega"/>
                                </Columns>
                                <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
                                <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
                                <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
                                <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
                                <SortedAscendingCellStyle BackColor="#F7F7F7" />
                                <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
                                <SortedDescendingCellStyle BackColor="#E5E5E5" />
                                <SortedDescendingHeaderStyle BackColor="#242121" />
                            </asp:GridView>
                            <br />


                        </div>

                    </div>

                </div>
            </div>
        

            </section>
    </form>

        </div>
</body>
</html>
