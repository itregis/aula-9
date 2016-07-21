using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;

namespace AcessoDados
{
    public class DBCliente
    {
        public void InserirCliente(string _nome, int _idade, string _telefone, string _endereco, char _sexo)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conexao"].ConnectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into cliente (nome, idade, telefone, endereco, sexo) values (@nome,@idade,@tel,@end,@sexo);");
            cmd.Connection = conn;
            cmd.Parameters.AddWithValue("@nome", _nome);
            cmd.Parameters.AddWithValue("@idade", _idade);
            cmd.Parameters.AddWithValue("@tel", _telefone);
            cmd.Parameters.AddWithValue("@end", _endereco);
            cmd.Parameters.AddWithValue("@sexo", _sexo);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void AtualizarCliente(int _codigo, string _nome, int _idade, string _telefone, string _endereco, char _sexo)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conexao"].ConnectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand("update cliente set nome=@nome, idade=@idade, telefone=@tel, endereco=@end, sexo=@sexo where id=@codigo;");
            cmd.Connection = conn;
            cmd.Parameters.AddWithValue("@codigo", _codigo);
            cmd.Parameters.AddWithValue("@nome", _nome);
            cmd.Parameters.AddWithValue("@idade", _idade);
            cmd.Parameters.AddWithValue("@tel", _telefone);
            cmd.Parameters.AddWithValue("@end", _endereco);
            cmd.Parameters.AddWithValue("@sexo", _sexo);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public DataTable ConsultarClientePorNome(string _nome)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conexao"].ConnectionString);
            SqlCommand cmd = new SqlCommand();
            string strSql = "select * from cliente where nome like '%' + @nome + '%'";
            cmd.CommandText = strSql;
            cmd.Connection = conn;
            conn.Open();
            cmd.Parameters.AddWithValue("@nome", _nome);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            conn.Close();
            return dt;
        }


        public void RemoverCliente(string _nome)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conexao"].ConnectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand("delete from cliente where nome=@nome;");
            cmd.Connection = conn;
            cmd.Parameters.AddWithValue("@nome", _nome);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public DataTable ConsultarTodosClientes()
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conexao"].ConnectionString);
            SqlCommand cmd = new SqlCommand();
            string strSql = "select * from cliente where 1=1";
            cmd.CommandText = strSql;
            cmd.Connection = conn;
            conn.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            conn.Close();
            return dt;
        }

    }
}
