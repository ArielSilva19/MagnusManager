<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Index.aspx.cs" Inherits="Pages_TiposdeUsuarios_Secretario_Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Tela Inicial do Secretario</title>

    <link href="../../../Content/css/bootstrap.min.css" rel="stylesheet" />
    <script src="../../../Scripts/popper.min.js"></script>
    <script src="../../../Scripts/jquery-3.3.1.min.js"></script>
    <script src="../../../Scripts/bootstrap.min.js"></script>
</head>
<body class="container" >

              <form id="Secretario" runat="server" style="width: 100%;">

        <header style="height: 200px; width: 100%; background-color: #0e0e0e; -moz-box-shadow: 8px 8px 5px #000000; -webkit-box-shadow: 8px 8px 5px #000000; box-shadow: 8px 8px 5px #000000;">
            <img src="../../Imagens/Cabecalho/cabecalho.png" style="height: 180px; width: 180px; padding: 5px;" /><img src="../../Imagens/Cabecalho/logo%20retangular.png" style="height: 180px; width:600px; padding: 5px; float:right; margin-right:5px; margin-top:30px;"/>
        </header>



        <div class="container" style="max-width: 25%; min-height: 600px; clear: both; float: left">

            <div class="jumbotron" style="background-color: chocolate; padding: 15px; margin-top: 14px; text-align: left;">

                <ul class="nav navbar-nav">

                    <div class="form-group">

                        <li class="TopoMenu">
                            <h2>
                    <h2> <asp:Label ID="lblTitulo" runat="server" Text="Tela Principal do Secretario"></asp:Label></h2>
                            </h2>
                        </li>
                    </div>



                    <div class="form-group">

                        <h3 class="btn-group" style="text-align: center;"><b>Painel Principal</b><br />
                        </h3>
                    </div>

                    <li class="nav-item dropdown">
                        <a class="nav-link dropdown-toggle" data-toggle="dropdown" href="#">Usuários</a>
                        <div class="dropdown-menu" id="menuCadastrosdeUsuarios">
                            <a class="dropdown-item" href="../../Cadastros/CadastrodeUsuarios/Cadastrar.aspx">Cadastrar Usuários</a>
                        </div>
                    </li>


                    <li class="nav-item dropdown">
                        <a class="nav-link dropdown-toggle" data-toggle="dropdown" href="#">Matéria Prima</a>
                        <div class="dropdown-menu" id="menuCadastrosdeMateriaPrima">
                            <a class="dropdown-item" href="../../Cadastros/CadastrodeMateriais/MateriaPrima/Cadastrar.aspx">Cadastrar Matéria Prima</a>
                        </div>
                    </li>

                    <li class="nav-item dropdown">
                        <a class="nav-link dropdown-toggle" data-toggle="dropdown" href="#">Fornecedores</a>
                        <div class="dropdown-menu" id="menuCadastrosdeFornecedores">
                            <a class="dropdown-item" href="../../Cadastros/CadastrodeFornecedores/cadastrar.aspx">Cadastrar Fornecedores</a>
                        </div>
                    </li>


                    <li class="nav-item dropdown">
                        <a class="nav-link dropdown-toggle" data-toggle="dropdown" href="#">Clientes</a>
                        <div class="dropdown-menu" id="menuCadastrosdeClientes">
                            <a class="dropdown-item" href="../../Cadastros/CadastrodeClientes/Cadastar.aspx">Cadastrar Clientes</a>
                        </div>
                    </li>

                    <li class="nav-item dropdown">
                        <a class="nav-link dropdown-toggle" data-toggle="dropdown" href="#">Sobras de Matéria Prima</a>
                        <div class="dropdown-menu" id="menuCadastrosdeSobras">
                            <a class="dropdown-item" href="../../Cadastros/CadastrodeMateriais/SobraMateriaPrima/cadastrar.aspx">Cadastrar Sobra de Matéria Prima</a>
                            <a class="dropdown-item" href="../../Cadastros/CadastrodeMateriais/SobraMateriaPrima/listar.aspx">Listar Sobra de Matéria Prima</a>



                        </div>
                    </li>


                    <li class="nav-item dropdown">
                        <a class="nav-link dropdown-toggle" data-toggle="dropdown" href="#">Produtos</a>
                        <div class="dropdown-menu" id="menuCadastrosdeProdutos">
                            <a class="dropdown-item" href="../../Cadastros/CadastrodeProdutos/cadastrar.aspx">Cadastrar Produtos</a>
                            <a class="dropdown-item" href="../../Cadastros/CadastrodeProdutos/Listar.aspx">Listar Produtos</a>


                        </div>
                    </li>


                    <li class="nav-item dropdown">
                        <a class="nav-link dropdown-toggle" data-toggle="dropdown" href="#">Pedidos</a>
                        <div class="dropdown-menu" id="menuCadastrosdePedidos">
                            <a class="dropdown-item" href="../../Cadastros/CadastrodePedidos/Cadastrar.aspx">Cadastrar Pedidos</a>
                            <a class="dropdown-item" href="../../Cadastros/CadastrodePedidos/Listar.aspx">Listar Pedidos</a>
                        </div>
                    </li>


                    <div class="form-group">
                        <li>
                            <asp:LinkButton ID="lbSair" runat="server" OnClick="lbSair_Click"><br /><h2><b>Sair</b></h2></asp:LinkButton>
                        </li>
                    </div>


                </ul>

            </div>

        </div>

        <div class="cool col-9" style="float: left; width:74%; min-height: 600px;">
            <div class="jumbotron" style="background-color: chocolate; padding: 15px; margin-top: 14px; text-align: left; float: left;">
                Aqui vai o conteudo com links ou outras pags...  Aqui vai o conteudo com links ou outras pags...  Aqui vai o conteudo com links ou outras pags...  Aqui vai o conteudo com links ou outras pags...<br />
                <br />
                Aqui vai o conteudo com links ou outras pags...  Aqui vai o conteudo com links ou outras pags...  Aqui vai o conteudo com links ou outras pags...  Aqui vai o conteudo com links ou outras pags...<br />
                <br />
                Aqui vai o conteudo com links ou outras pags...  Aqui vai o conteudo com links ou outras pags...  Aqui vai o conteudo com links ou outras pags...  Aqui vai o conteudo com links ou outras pags...<br />
                <br />
                Aqui vai o conteudo com links ou outras pags...  Aqui vai o conteudo com links ou outras pags...  Aqui vai o conteudo com links ou outras pags...  Aqui vai o conteudo com links ou outras pags...<br />
                <br />
                Aqui vai o conteudo com links ou outras pags...  Aqui vai o conteudo com links ou outras pags...  Aqui vai o conteudo com links ou outras pags...  Aqui vai o conteudo com links ou outras pags...<br />
                <br />
            </div>
        </div>









        <footer class="container">
            <div class="container" style="float: left; min-width: 100%; min-height: 100px;">
                <div class="jumbotron" style="background-color: chocolate; padding: 15px; margin-top: 14px; text-align: center; float: left;">

                    <h4><b>Desenvolvedores do Software: Ariel, Claudio, Nycolas, Jessica e Regina</b></h4>
                </div>

            </div>





        </footer>

    </form>    
</body>
</html>
