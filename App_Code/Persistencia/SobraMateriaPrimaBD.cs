using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MagnusManager.Classes;
using System.Data;
using SoftwareSerralheria;


namespace MagnusManager.Persistencia
{
    public class SobraMateriaPrimaBD
    {

        public int Insert(SobraMateriaPrima sobraMateriaPrima)
        {
            int retorno = 0;
            try
            {
                System.Data.IDbConnection objConexao;
                System.Data.IDbCommand objCommand;
                string sql = "INSERT INTO sob_sobra_materia_prima(sob_nome,sob_unidade,sob_quantidade,sob_valor_total) VALUES(?nome, ?unidade, ?quantidade, ?valorTotal)";

                objConexao = Mapped.Connection();
                objCommand = Mapped.Command(sql, objConexao);

                objCommand.Parameters.Add(Mapped.Parameter("?nome", sobraMateriaPrima.Nome));
                objCommand.Parameters.Add(Mapped.Parameter("?unidade", sobraMateriaPrima.Unidade));
                objCommand.Parameters.Add(Mapped.Parameter("?quantidade", sobraMateriaPrima.Quantidade));
                objCommand.Parameters.Add(Mapped.Parameter("?valorTotal", sobraMateriaPrima.ValorTotal));

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


        public DataSet SelectAll()
        {
            DataSet ds = new DataSet();

            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            System.Data.IDataAdapter objDataAdapter;

            objConexao = Mapped.Connection();
            objCommand = Mapped.Command("SELECT * FROM sob_sobra_materia_prima", objConexao);
            objDataAdapter = Mapped.Adapter(objCommand);
            objDataAdapter.Fill(ds);
            objConexao.Close();
            objCommand.Dispose();
            objConexao.Dispose();

            return ds;
        }

        public SobraMateriaPrimaBD()
        {
            //
            // TODO: Add constructor logic here
            //
        }

    }
}