using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SoftwareSerralheria; //para acesso a classe Mapped
using System.Data;
using MagnusManager.Classes;

public class MateriaPrimaBD
{
    
    public bool Insert(MateriaPrima MateriaPrima)
    {
            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            string sql = "INSERT INTO mat_materia_prima(mat_nome, mat_unidade,mat_quantidade,mat_valor_unitario,mat_valor_total) VALUES(?nome, ?unidade, ?quantidade, ?valorUnitario, ?valorTotal)";

            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);

            objCommand.Parameters.Add(Mapped.Parameter("?nome", MateriaPrima.Nome));
            objCommand.Parameters.Add(Mapped.Parameter("?unidade", MateriaPrima.Unidade));
            objCommand.Parameters.Add(Mapped.Parameter("?quantidade", MateriaPrima.Quantidade));
            objCommand.Parameters.Add(Mapped.Parameter("?valorUnitario", MateriaPrima.ValorUnitario));
            objCommand.Parameters.Add(Mapped.Parameter("?valorTotal", MateriaPrima.ValorTotal));

            objCommand.ExecuteNonQuery();
            objConexao.Close();
            objCommand.Dispose();
            objConexao.Dispose();
        return true;
        }



    public MateriaPrimaBD()
    {
        //
        // TODO: Add constructor logic here
        //
    }
}