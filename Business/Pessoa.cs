using DataBase;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class Pessoa
    {
        private List<Endereco> _enderecos;
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public List<Endereco> Enderecos
        {
            get
            {
                if (_enderecos == null) _enderecos = Endereco.Lista(Id);
                return _enderecos;
            }
        }
        public void Salvar()
        {
            if (string.IsNullOrEmpty(Name))
            {
                throw new Exception("Não não pode ser vazio!");
            }

            if (this.Id > 0)
            {
                new DataBase.Pessoa().Atualizar(Id, Name, LastName);

            }
            else
            {

                this.Id = new DataBase.Pessoa().Salvar(Name, LastName);
            }
        }
        public static List<Pessoa> Lista()
        {
            return Lista(string.Empty);
        }
        public static List<Pessoa> Lista(string nome)
        {
            var pessoas = new List<Pessoa>();
            DataTable dados = new DataBase.Pessoa().Listar(nome);
            for (var i = 0; i < dados.Rows.Count; i++)
            {
                pessoas.Add(new Pessoa()
                {
                    Id = Convert.ToInt32(dados.Rows[i]["id"]),
                    Name = dados.Rows[i]["name"].ToString(),
                    LastName = dados.Rows[i]["lastName"].ToString()

                });
            }
            return pessoas;
        }

        public static void Excluir(int id)
        {
            new DataBase.Pessoa().Excluir(id);
        }
    }
}
