using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class Endereco
    {
        
        public int Id { get; set; }
        public int PessoaId { get; set; }
        public string Rua { get; set; }

        
     
        
         public static List<Endereco> Lista(int cliente_id)
         {
                var enderecos = new List<Endereco>();
                DataTable dados = new DataBase.Endereco().Listar(cliente_id);
                for (var i = 0; i < dados.Rows.Count; i++)
                {
                    enderecos.Add(new Endereco()
                    {
                        Id = Convert.ToInt32(dados.Rows[i]["id"]),
                        PessoaId = Convert.ToInt32(dados.Rows[i]["pessoa_id"]),
                        Rua = dados.Rows[i]["endereco"].ToString(),
                   

                    });
                }
                return enderecos;
           
         }
         


    }
}
