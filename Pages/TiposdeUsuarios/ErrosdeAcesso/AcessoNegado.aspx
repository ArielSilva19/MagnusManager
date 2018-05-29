<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AcessoNegado.aspx.cs" Inherits="Pages_TiposdeUsuarios_ErrosdeAcesso_AcessoNegado" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="AcessoNegado" runat="server">
        
        <asp:Label ID="ErroAcesso" runat="server" Text="Acesso Negado."></asp:Label>
        <asp:HyperLink ID="VoltarLogin" runat="server" NavigateUrl="~/Pages/Login.aspx" text="Voltar para a tela de Login"></asp:HyperLink>
    </form>
</body>
</html>
