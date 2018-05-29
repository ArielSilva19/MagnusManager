using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SoftwareSerralheria; //para acesso a classe Mapped
using System.Data;
using MagnusManager.Classes;


namespace MagnusManager.Persistencia
{
    public class ProdutoBD
    {

        public bool Insert(Produto produto)
        {
          
        
            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            string sql = "insert INTO pro_produto(cat_id ,pro_nome ,pro_descricao ,pro_dimensao,pro_valor,pro_tempo) VALUES(?categoria,?nome,?descricao,?dimensao,?valor,?tempo)";

            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);

            objCommand.Parameters.Add(Mapped.Parameter("?categoria", produto.Categoria));

            objCommand.Parameters.Add(Mapped.Parameter("?nome", produto.Nome));
            objCommand.Parameters.Add(Mapped.Parameter("?descricao", produto.Descricao));
            objCommand.Parameters.Add(Mapped.Parameter("?dimensao", produto.Dimensao));
            objCommand.Parameters.Add(Mapped.Parameter("?valor", produto.Valor));
            objCommand.Parameters.Add(Mapped.Parameter("?tempo", produto.Tempo));

            objCommand.ExecuteNonQuery();
            objConexao.Close();
            objCommand.Dispose();
            objConexao.Dispose();
                return true;
            }

        //selectall
        public DataSet SelectAll()
        {
            DataSet ds = new DataSet();

            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            System.Data.IDataAdapter objDataAdapter;

            objConexao = Mapped.Connection();
            objCommand = Mapped.Command("SELECT * FROM pro_produto p left join cat_categoria_produto ca on p.cat_id = ca.cat_id ", objConexao);
            objDataAdapter = Mapped.Adapter(objCommand);
            objDataAdapter.Fill(ds);

            objConexao.Close();

            objCommand.Dispose();
            objConexao.Dispose();

            return ds;
        }



        public DataSet SelectTipo() 
        {
            DataSet ds = new DataSet();
            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            System.Data.IDataAdapter objDataAdapter;
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command("SELECT * FROM cat_categoria_produto", objConexao);
            objDataAdapter = Mapped.Adapter(objCommand);
            objDataAdapter.Fill(ds);
            objConexao.Close();
            objCommand.Dispose();
            objConexao.Dispose();
            return ds;
        }

        public ProdutoBD()
        {
            //
            // TODO: Add constructor logic here
            //
        }
    }
}