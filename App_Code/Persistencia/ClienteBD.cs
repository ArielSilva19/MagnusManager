using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SoftwareSerralheria; //para acesso a classe Mapped
using System.Data;
using MagnusManager.Classes;

namespace MagnusManager.Persistencia
{
    /// <summary>
    /// Summary description for FornecedorBD
    /// </summary>
    public class ClienteBD
    {



        public int Insert(Cliente cliente)
        {
            int retorno = 0;
            try
            {
                System.Data.IDbConnection objConexao;
                System.Data.IDbCommand objCommand;
                string sql = "INSERT INTO cli_cliente(cli_nome, cli_cpf, cli_endereco, cli_cidade, cli_estado, cli_telefone, cli_email) VALUES(?nome, ?cpf, ?endereco, ?cidade, ?estado, ?telefone, ?email )";

                objConexao = Mapped.Connection();
                objCommand = Mapped.Command(sql, objConexao);

                objCommand.Parameters.Add(Mapped.Parameter("?nome", cliente.Nome));
                objCommand.Parameters.Add(Mapped.Parameter("?cpf", cliente.Cpf));
                objCommand.Parameters.Add(Mapped.Parameter("?endereco", cliente.Endereco));
                objCommand.Parameters.Add(Mapped.Parameter("?cidade", cliente.Cidade));
                objCommand.Parameters.Add(Mapped.Parameter("?estado", cliente.Estado));
                objCommand.Parameters.Add(Mapped.Parameter("?telefone", cliente.Telefone));
                objCommand.Parameters.Add(Mapped.Parameter("?email", cliente.Email));

                objCommand.ExecuteNonQuery();
                objConexao.Close();
                objCommand.Dispose();
                objConexao.Dispose();
            }
            catch (MySql.Data.MySqlClient.MySqlException)
            {
                retorno = -1;
            }
            catch (Exception)
            {
                retorno = -2;
            }
            return retorno;
        }


        public ClienteBD()
        {
            //
            // TODO: Add constructor logic here
            //
        }
    }
}