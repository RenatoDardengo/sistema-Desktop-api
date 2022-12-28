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
    public class Endereco
    {
        private string connString = "";

        //Crio um construtor da classe para setar a string de conexao
        public Endereco()
        {
            connString = ConfigurationManager.ConnectionStrings["Conexao"].ConnectionString;
        }
       


        public DataTable Listar(int cliente_id)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(connString))
            {
                string sql = "select * from tbl_enderecos where pessoa_id =" + cliente_id;
                
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

       

      
    }

}
