using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MagnusManager.Classes;
using System.Data;
using SoftwareSerralheria;


namespace MagnusManager.Persistencia
{
    /// <summary>
    /// Summary description for UsuarioBD
    /// </summary>
    public class UsuarioBD
    {
        public Usuario Autentica(string email, string senha)
        {
            Usuario obj = null;
            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            System.Data.IDataReader objDataReader;
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command("SELECT * FROM usu_usuario WHERE usu_email = ?email and usu_senha = ?senha", objConexao);
            objCommand.Parameters.Add(Mapped.Parameter("?email", email));
            objCommand.Parameters.Add(Mapped.Parameter("?senha", senha));
            objDataReader = objCommand.ExecuteReader();

        while (objDataReader.Read())
            {
                obj = new Usuario();
                obj.Id = Convert.ToInt32(objDataReader["usu_id"]);
                obj.Nome = Convert.ToString(objDataReader["usu_nome"]);
                obj.Email = Convert.ToString(objDataReader["usu_email"]);
                obj.Senha = Convert.ToString(objDataReader["usu_senha"]);
                obj.Cpf = Convert.ToInt64(objDataReader["usu_cpf"]);
                obj.Data = Convert.ToString(objDataReader["usu_data"]);
                obj.Telefone = Convert.ToInt64(objDataReader["usu_telefone"]);
                obj.Tipo = Convert.ToInt32(objDataReader["usu_tipo"]);
            }
            objDataReader.Close();
            objConexao.Close();
            objCommand.Dispose();
            objConexao.Dispose();
            objDataReader.Dispose();
            return obj;
        }
        public Usuario Select(int id)
        {
            Usuario obj = null;
            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            System.Data.IDataReader objDataReader;
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command("SELECT * FROM usu_usuario WHERE usu_id = ?id",objConexao);
            objCommand.Parameters.Add(Mapped.Parameter("?id", id));
            objDataReader = objCommand.ExecuteReader();
            while (objDataReader.Read())
            {
                obj = new Usuario();
                obj.Id = Convert.ToInt32(objDataReader["usu_id"]);
                obj.Nome = Convert.ToString(objDataReader["usu_nome"]);
                obj.Email = Convert.ToString(objDataReader["usu_email"]);
                obj.Senha = Convert.ToString(objDataReader["usu_senha"]);
                obj.Cpf = Convert.ToInt64(objDataReader["usu_cpf"]);
                obj.Data = Convert.ToString(objDataReader["usu_data"]);
                obj.Telefone = Convert.ToInt64(objDataReader["usu_telefone"]);
                obj.Tipo = Convert.ToInt32(objDataReader["usu_tipo"]);
            }
            objDataReader.Close();
            objConexao.Close();
            objCommand.Dispose();
            objConexao.Dispose();
            objDataReader.Dispose();
            return obj;
        }


        public DataSet SelectAll()
        {
            DataSet ds = new DataSet();

            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            System.Data.IDataAdapter objDataAdapter;

            objConexao = Mapped.Connection();
            objCommand = Mapped.Command("SELECT * FROM usu_usuario", objConexao);
            objDataAdapter = Mapped.Adapter(objCommand);
            objDataAdapter.Fill(ds);

            objConexao.Close();

            objCommand.Dispose();
            objConexao.Dispose();

            return ds;
        }
        public DataSet SelectAllGerentes()
        {
            DataSet ds = new DataSet();

            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            System.Data.IDataAdapter objDataAdapter;

            objConexao = Mapped.Connection();
            objCommand = Mapped.Command("SELECT * FROM usu_usuario WHERE usu_tipo = 0",objConexao);

            objDataAdapter = Mapped.Adapter(objCommand);
            objDataAdapter.Fill(ds);

            objConexao.Close();

            objCommand.Dispose();
            objConexao.Dispose();

            return ds;
        }
        public DataSet SelectAllSecretarios()
        {
            DataSet ds = new DataSet();

            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            System.Data.IDataAdapter objDataAdapter;

            objConexao = Mapped.Connection();
            objCommand = Mapped.Command("SELECT * FROM usu_usuario WHERE usu_tipo = 1",objConexao);

            objDataAdapter = Mapped.Adapter(objCommand);
            objDataAdapter.Fill(ds);

            objConexao.Close();

            objCommand.Dispose();
            objConexao.Dispose();

            return ds;
        }

        public DataSet SelectAllOperarios()
        {
            DataSet ds = new DataSet();

            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            System.Data.IDataAdapter objDataAdapter;

            objConexao = Mapped.Connection();
            objCommand = Mapped.Command("SELECT * FROM usu_usuario WHERE usu_tipo = 2", objConexao);

            objDataAdapter = Mapped.Adapter(objCommand);
            objDataAdapter.Fill(ds);

            objConexao.Close();

            objCommand.Dispose();
            objConexao.Dispose();

            return ds;
        }


        public bool Insert(Usuario usuario)
        {
            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            string sql = "INSERT INTO usu_usuario(usu_nome, usu_cpf, usu_data, usu_email, usu_telefone, usu_tipo, usu_senha) VALUES (?nome, ?cpf, ?data, ?email, ?telefone, ?tipo, ?senha)";
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);

            objCommand.Parameters.Add(Mapped.Parameter("?nome", usuario.Nome));
            objCommand.Parameters.Add(Mapped.Parameter("?cpf", usuario.Cpf));
            objCommand.Parameters.Add(Mapped.Parameter("?data", usuario.Data));
            objCommand.Parameters.Add(Mapped.Parameter("?email", usuario.Email));
            objCommand.Parameters.Add(Mapped.Parameter("?senha", usuario.Senha));
            objCommand.Parameters.Add(Mapped.Parameter("?telefone", usuario.Telefone));
            objCommand.Parameters.Add(Mapped.Parameter("?tipo", usuario.Tipo));

            objCommand.ExecuteNonQuery();
            objConexao.Close();
            objCommand.Dispose();
            objConexao.Dispose();
            return true;
        }


        public bool Update(Usuario usuario)
        {
            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            string sql = "UPDATE usu_usuario SET usu_nome=?nome, usu_cpf=?cpf, usu_data=?data, usu_email=?email, usu_telefone=?telefone, usu_senha=?senha, usu_tipo=?tipo WHERE usu_id=?id";
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);
            objCommand.Parameters.Add(Mapped.Parameter("?nome", usuario.Nome));
            objCommand.Parameters.Add(Mapped.Parameter("?cpf", usuario.Cpf));
            objCommand.Parameters.Add(Mapped.Parameter("?data", usuario.Data));
            objCommand.Parameters.Add(Mapped.Parameter("?email", usuario.Email));
            objCommand.Parameters.Add(Mapped.Parameter("?telefone", usuario.Telefone));
            objCommand.Parameters.Add(Mapped.Parameter("?senha", usuario.Senha));
            objCommand.Parameters.Add(Mapped.Parameter("?tipo", usuario.Tipo));
            objCommand.Parameters.Add(Mapped.Parameter("?id", usuario.Id));
            objCommand.ExecuteNonQuery();
            objConexao.Close();
            objCommand.Dispose();
            objConexao.Dispose();
            return true;
        }
        //delete
        public bool Delete(int id)
        {
            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            string sql = "DELETE FROM usu_usuario WHERE usu_id=?id";
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);
            objCommand.Parameters.Add(Mapped.Parameter("?id", id));

            objCommand.ExecuteNonQuery();
            objConexao.Close();
            objCommand.Dispose();
            objConexao.Dispose();
            return true;
        }


        public UsuarioBD()
        {
            //
            // TODO: Add constructor logic here
            //
        }
    }
}