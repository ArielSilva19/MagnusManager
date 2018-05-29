<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Pages_Login" culture="auto" meta:resourcekey="PageResource1" uiculture="auto" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Pagina de Login</title>
    <link href="../Content/css/bootstrap.min.css" rel="stylesheet" />
    <script src="../Scripts/bootstrap.min.js"></script>
    <script src="../Scripts/bootstrap-notify.min.js"></script>
    <script src="../Scripts/jquery-3.3.1.min.js"></script>
    <script src="../Scripts/jquery.mask.min.js"></script>
       

</head>



<body>

        <div class="container-fluid">

        <div class="row">
    <header class="col-10" style="max-height: 180px; min-width: 100%; clear: both; padding: 4px 7px 3px 3px; background-color: #0e0e0e; -moz-box-shadow: 8px 8px 5px #000000; -webkit-box-shadow: 8px 8px 5px #000000; box-shadow: 8px 8px 5px #000000;">
        <img src="Imagens/Cabecalho/cabecalho.png" style="height: 160px; width: 160px; padding: 5px; margin-left:10px;"  /><img src="Imagens/Cabecalho/logo%20retangular.png" style="height: 160px; width:800px; padding: 5px; float:right; margin-top:24px;"/>
    </header>
            </div>



        <section id="secFormulario" style="margin-top: 40px; margin-bottom: 40px; margin-left: 20%; margin-right: 20%; background-color: rgba(255, 119, 42, 0.6);">

            <form id="login" runat="server">

                <div class="container-fluid">
                    <div id="titulo" style="text-align: center;">
                        <h2 style="font-size: 50px"><b>Login</b></h2>
                    </div>


                    <div class="row">


                        <div class="col-md-12" style="background-color: rgba(255, 119, 42, 0.6);">



                            <div class="form-group" style="margin-top: 50px; margin-left: 15%; margin-right: 15%;">
                                <asp:Label ID="lblEmail" runat="server" Text="E-mail:" meta:resourcekey="Label2Resource1"></asp:Label>
                                <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control" placeholder="Email" required="required" meta:resourcekey="txtEmailResource1"></asp:TextBox>
                            </div>

                            <div class="form-group" style="margin-top: 20px; margin-left: 15%; margin-right: 15%;">

                                <asp:Label ID="lblSenha" runat="server" Text="Senha:" meta:resourcekey="Label3Resource1"></asp:Label>

                                <asp:TextBox ID="txtSenha" runat="server" CssClass="form-control" placeholder="Senha" required="required" meta:resourcekey="txtSenhaResource1" password="recovery" TextMode="Password"></asp:TextBox>


                            </div>

                            <div class="form-group" style="text-align: center; margin-top: 70px;">
                                <asp:Button ID="btnEntrar" runat="server" Text="Entrar" OnClick="btnEntrar_Click" CssClass="btn btn-primary btn-lg" meta:resourcekey="btnEntrarResource1" max-Height="60" max-Width="220px" Width="170px"></asp:Button>
                            </div>


                            <div class="alert alert-danger" style="margin-top: 50px; margin-left: 15%; margin-right: 15%; margin-bottom: 10px;">

                                <asp:Label ID="lblMensagem" runat="server" meta:resourcekey="lblMensagemResource1"></asp:Label>
                            </div>
                        </div>
                    </div>

                </div>

            </form>

        </section>
            

    </div>
    

</body>

</html>
