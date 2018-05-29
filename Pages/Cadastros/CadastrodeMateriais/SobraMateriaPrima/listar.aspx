<%@ Page Language="C#" AutoEventWireup="true" CodeFile="listar.aspx.cs" Inherits="Pages_Cadastros_CadastrodeMateriais_SobraMateriaPrima_listar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<title></title>
    <link href="~/Content/css/bootstrap.min.css" rel="stylesheet" />
    <script src="~/Scripts/bootstrap.min.js"></script>
    <script src="~/Scripts/jquery-3.3.1.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
       
        <div class="jumbotron">
            <section id="formulario" style="margin-top:40px; margin-left:25%; margin-right:25%; " >
        <h3 style="text-align:center;">Lista de Pedidos</h3>
        <br /><br />
            <div class="container">
                <div class="row">
                    <div class="col-md-12">

                        <div class="form-group">
                            <asp:GridView ID="GridViewSobras" runat="server" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Horizontal" AutoGenerateColumns="False" Height="140px" Width="500px">
                                <columns>
                                    <asp:BoundField HeaderText="Nome do Material" DataField="sob_nome" />
                                    <asp:BoundField HeaderText="Unidade"  DataField="sob_unidade"/>
                                    <asp:BoundField HeaderText="Quantidade" DataField="sob_quantidade"/>
                                    <asp:BoundField HeaderText="Valor Total" DataField="sob_valor_total"/>
                                  </columns>
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
                    </div>

    </form>

</body>
</html>
