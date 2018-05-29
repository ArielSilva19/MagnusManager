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
    /// Summary description for PedidoBD
    /// </summary>
    public class PedidoBD
    {


        //métodos 


        //insert 
        public bool Insert(Pedido pedido)
        {
                System.Data.IDbConnection objConexao;
                System.Data.IDbCommand objCommand;
                string sql = "INSERT INTO ped_pedido(cli_id, pro_id, cat_id, ped_qtde_pro, ped_valor, ped_data_pedido, ped_data_entrega) VALUES(?cli, ?pro, ?cat, ?qtdePro, ?valor, ?dataPedido, ?dataEntrega)";

                objConexao = Mapped.Connection();
                objCommand = Mapped.Command(sql, objConexao);

                objCommand.Parameters.Add(Mapped.Parameter("?cli", pedido.Cli_id));
                objCommand.Parameters.Add(Mapped.Parameter("?pro", pedido.Pro_id));
                objCommand.Parameters.Add(Mapped.Parameter("?cat", pedido.Cat_id));
                objCommand.Parameters.Add(Mapped.Parameter("?qtdePro", pedido.QtdePro));
                objCommand.Parameters.Add(Mapped.Parameter("?valor", pedido.Valor));
                objCommand.Parameters.Add(Mapped.Parameter("?dataPedido", pedido.DataPedido));
                objCommand.Parameters.Add(Mapped.Parameter("?dataEntrega", pedido.DataEntrega));


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
            objCommand = Mapped.Command("SELECT * FROM ped_pedido pe left join cli_cliente c on pe.cli_id = c.cli_id left join pro_produto p on pe.pro_id =  p.pro_id left join cat_categoria_produto ca on pe.cat_id = ca.cat_id ", objConexao);
            objDataAdapter = Mapped.Adapter(objCommand);
            objDataAdapter.Fill(ds);

            objConexao.Close();

            objCommand.Dispose();
            objConexao.Dispose();

            return ds;
        }


        //select 

        public Pedido Select(int id)
        {
            Pedido obj = null;

            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            System.Data.IDataReader objDataReader;

            objConexao = Mapped.Connection();
            objCommand = Mapped.Command("SELECT * FROM ped_pedido WHERE ped_id = ?id", objConexao);
            objCommand.Parameters.Add(Mapped.Parameter("?id", id));

            objDataReader = objCommand.ExecuteReader();
            while (objDataReader.Read())
            {
                obj = new Pedido();

                obj.Cli_id = Convert.ToInt32(objDataReader["cli_id"]);
                obj.Pro_id = Convert.ToInt32(objDataReader["pro_id"]);
                obj.Cat_id = Convert.ToInt32(objDataReader["cat_id"]);
                obj.QtdePro = Convert.ToInt32(objDataReader["ped_qtde_pro"]);
                obj.DataPedido = Convert.ToDateTime(objDataReader["ped_data_pedido"]);
                obj.DataEntrega = Convert.ToDateTime(objDataReader["ped_data_entrega"]);
            }

            objDataReader.Close();
            objConexao.Close();

            objCommand.Dispose();
            objConexao.Dispose();
            objDataReader.Dispose();

            return obj;
        }

        public DataSet SelectUm() //aqui vc vai selecionar os itens pra exibir no dropdownlist 
        {
            DataSet ds = new DataSet();
            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            System.Data.IDataAdapter objDataAdapter;
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command("SELECT * FROM cli_cliente ", objConexao);
            objDataAdapter = Mapped.Adapter(objCommand);
            objDataAdapter.Fill(ds);
            objConexao.Close();
            objCommand.Dispose();
            objConexao.Dispose();
            return ds;
        }
        public DataSet SelectDois() //aqui vc vai selecionar os itens pra exibir no dropdownlist 
        {
            DataSet ds = new DataSet();
            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            System.Data.IDataAdapter objDataAdapter;
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command("SELECT * FROM pro_produto", objConexao);
            objDataAdapter = Mapped.Adapter(objCommand);
            objDataAdapter.Fill(ds);
            objConexao.Close();
            objCommand.Dispose();
            objConexao.Dispose();
            return ds;
        }
        public DataSet SelectTres() //aqui vc vai selecionar os itens pra exibir no dropdownlist 
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


        //update 

        //delete 

        //contrutor
        public PedidoBD()
        {
            //
            // TODO: Add constructor logic here
            //
        }
    }
}

