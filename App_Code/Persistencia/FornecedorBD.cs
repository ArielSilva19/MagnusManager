using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MagnusManager.Classes; //para acesso a classe Mapped
using System.Data;
using SoftwareSerralheria;

namespace MagnusManager.Persistencia
{
    /// <summary>
    /// Summary description for FornecedorBD
    /// </summary>
    public class FornecedorBD
    {



        public int Insert(Fornecedor fornecedor)
        {
            int retorno = 0;
            try
            {
                System.Data.IDbConnection objConexao;
                System.Data.IDbCommand objCommand;
                string sql = "INSERT INTO for_fornecedor(for_nome,for_cnpj,for_nome_contato,for_endereco,for_cidade,for_estado,for_telefone,for_email) VALUES(?nome, ?cnpj, ?nomeContato, ?endereco, ?cidade, ?estado, ?telefone, ?email )";

                objConexao = Mapped.Connection();
                objCommand = Mapped.Command(sql, objConexao);

                objCommand.Parameters.Add(Mapped.Parameter("?nome", fornecedor.Nome));
                objCommand.Parameters.Add(Mapped.Parameter("?cnpj", fornecedor.Cnpj));
                objCommand.Parameters.Add(Mapped.Parameter("?nomeContato", fornecedor.NomeContato));
                objCommand.Parameters.Add(Mapped.Parameter("?endereco", fornecedor.Endereco));
                objCommand.Parameters.Add(Mapped.Parameter("?cidade", fornecedor.Cidade));
                objCommand.Parameters.Add(Mapped.Parameter("?estado", fornecedor.Estado));
                objCommand.Parameters.Add(Mapped.Parameter("?telefone", fornecedor.Telefone));
                objCommand.Parameters.Add(Mapped.Parameter("?email", fornecedor.Email));

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

        public FornecedorBD()
        {
            //
            // TODO: Add constructor logic here
            //
        }
    }
}