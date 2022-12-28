using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Windows.Forms;
using System.Xml.Linq;

namespace DataBase
{
    public class Pessoa
    {
        private string connString = "";

        //Crio um construtor da classe para setar a string de conexao
        public Pessoa()
        {
            connString = ConfigurationManager.ConnectionStrings["Conexao"].ConnectionString;
        }
        public int Salvar(string name, string lastName)

        {
            //string connString = ConfigurationManager.ConnectionStrings["Conexao"].ConnectionString;
            int id = 0;
            using (SqlConnection conn = new SqlConnection(connString))
            {
                // string sql = "INSERT INTO tbl_pessoas (name, last_name) VALUES (@name, @lastName)";
                string sql = "SalvarPessoa2";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@name", SqlDbType.VarChar);
                cmd.Parameters["@name"].Value = name;

                cmd.Parameters.Add("@lastName", SqlDbType.VarChar);
                cmd.Parameters["@lastName"].Value = lastName;
                try
                {
                    conn.Open();
                    id = Convert.ToInt32(cmd.ExecuteScalar());

                    MessageBox.Show("Cadastrado com sucesso");

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
            return id;

        }


        public DataTable Listar(string nome)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(connString))
            {
                string sql = "select * from tbl_pessoas";
                if (!string.IsNullOrEmpty(nome))
                {
                    sql += " where name like '%" + nome + "%'";
                }
                SqlCommand cmd = new SqlCommand(sql, conn);

                try
                {
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
            return dt;

        }

        public void Atualizar(int id, string name, string lastName)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                string sql = "UPDATE tbl_pessoas SET name=@name, lastName=@lastName where id=@id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add("@id", SqlDbType.Int);
                cmd.Parameters["@id"].Value = id;

                cmd.Parameters.Add("@name", SqlDbType.VarChar);
                cmd.Parameters["@name"].Value = name;

                cmd.Parameters.Add("@lastName", SqlDbType.VarChar);
                cmd.Parameters["@lastName"].Value = lastName;
                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Atualizado com sucesso");

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }

        public void Excluir(int id)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                string sql = "delete from tbl_pessoas  where id=@id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add("@id", SqlDbType.Int);
                cmd.Parameters["@id"].Value = id;

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Excluido com sucesso");

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }
    }

}
