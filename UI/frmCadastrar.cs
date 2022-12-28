using Business;
using Newtonsoft.Json;
using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Security.Policy;
using System.Text;
using System.Net.Http.Formatting;

namespace UI
{
    public partial class frmCadastrar : Form
    {
        public frmCadastrar()
        {
            InitializeComponent();
        }

        private void btncadastrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtId.Text)) txtId.Text = "0";
            var pessoa = new Pessoa() {Id = Convert.ToInt32(txtId.Text), Name = txtName.Text, LastName = txtLastName.Text };
            pessoa.Salvar();

            txtId.Text=string.Empty;
            txtName.Text=string.Empty;
            txtLastName.Text=string.Empty;
            MessageBox.Show("O id " + pessoa.Id);
        }

       

        private void frmCadastrar_Load(object sender, EventArgs e)
        {
            dgvPessoas.DataSource = Pessoa.Lista();
        }

       
        private void btnPesquisar_Click_1(object sender, EventArgs e)
        {
            dgvPessoas.DataSource = Pessoa.Lista(txtpesq.Text);
        }

        private void dgvPessoas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var pessoa = (Pessoa)dgvPessoas.Rows [e.RowIndex].DataBoundItem;
            txtId.Text = pessoa.Id.ToString();
            txtName.Text = pessoa.Name;
            txtLastName.Text = pessoa.LastName;
            tbController.SelectedTab = tabPage2;

            var enderecos = pessoa.Enderecos;
          
        }

        private void dgvPessoas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var pessoa = (Pessoa)dgvPessoas.Rows[dgvPessoas.SelectedCells[0].RowIndex].DataBoundItem;
            var confirm = MessageBox.Show("Confirmar exclusão?", "Excluir",MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {

                Pessoa.Excluir(pessoa.Id);
            }
        }

        private void btnCarregar_Click(object sender, EventArgs e)
        {
            CarregarTodosAlunos();

        }

        //metodo consumir uma api

        private void CarregarApi()
        {
            var url = "http://localhost:5086/alunos/1";

            var requisicaoWeb = WebRequest.CreateHttp(url); //webRequest é o método usado para fazernos requisições http
            requisicaoWeb.Method= "GET";  //aqui definimos o verbo da requisição
            using (var resposta = requisicaoWeb.GetResponse()) // aqui estamos fazendo um comando para realizar a busca
            {
                var streamDados = resposta.GetResponseStream(); // estamos retornando os dados buscado (está realizando um stream da internet - buscando byte)
                StreamReader reader= new StreamReader(streamDados); //o reader é usado para decifrar o que vem dos bytes
                object objResponse = reader.ReadToEnd();    //aqui o reader está fazendo a leitura dos bytes
                var post = JsonConvert.DeserializeObject<Post>(objResponse.ToString()); //aqui está sendo feita a conversão dos dados que veiram da internet em json para string e entreag o objeto pronto para uso
                MessageBox.Show(post.nome);
                streamDados.Close();
                resposta.Close();

            }
        }

        private async void CarregarTodosAlunos()
        {
            var url = "http://localhost:5291/alunos";
            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync(url))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var ProdutoJsonString = await response.Content.ReadAsStringAsync();
                        dgvAlunos.DataSource = JsonConvert.DeserializeObject<Alunos[]>(ProdutoJsonString).ToList();
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível obter o produto : " + response.StatusCode);
                    }
                }
            }
        }


        public class Post
        {
            public string nome { get; set; }
        }
        public class Rootobject
        {
            public ResultadoAlunos ResultadoAlunos { get; set; }
        }

        

        public class ResultadoAlunos
        {
            public Alunos Alunos { get; set; }
        }
        public class Alunos
        {
            public int Id { get; set;}
            public string Nome { get; set; }
            public string Matricula { get; set;}
            public string notas { get; set; }
        }

        private void btnPesqAluno_Click(object sender, EventArgs e)
        {
            BuscarAlunoId(txtPesqAluno.Text);

        }
        private async void BuscarAlunoId(string id)
        {
            using (var client = new HttpClient())
            {
                BindingSource bsDados = new BindingSource();
                var url = "http://localhost:5291/alunos" + "/" + id;
               
                HttpResponseMessage response = await client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    var ProdutoJsonString = await response.Content.ReadAsStringAsync();
                    bsDados.DataSource = JsonConvert.DeserializeObject<Alunos>(ProdutoJsonString);
                    dgvAlunos.DataSource = bsDados;
                }
                else
                {
                    MessageBox.Show("Falha ao obter o produto : " + response.StatusCode);
                }
            }
        }

        private void btnCadastrarAluno_Click(object sender, EventArgs e)
        {
            AdicionarAluno();
        }

        private async void AdicionarAluno()
        {
            var url = "http://localhost:5291/alunos";
            Alunos aluno = new Alunos();
            aluno.Nome=txtNomeAluno.Text;
            aluno.Matricula=txtMatricula.Text;
            aluno.notas=txtNota.Text;
           
            using (var client = new HttpClient())
            {
                var serializedProduto = JsonConvert.SerializeObject(aluno);
                var content = new StringContent(serializedProduto, Encoding.UTF8, "application/json");
                var result = await client.PostAsync(url, content);
            }
            
        }

        private void btnDeletarAluno_Click(object sender, EventArgs e)
        {
            var id = dgvAlunos.CurrentRow.Cells[0].Value;
            DeleteProduto(id.ToString());

        }
        private async void DeleteProduto(string id)
        {
            var url = "http://localhost:5291/alunos" + "/" + id;
            //int ProdutoID = codProduto;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(url);
                HttpResponseMessage responseMessage = await
                //client.DeleteAsync(String.Format("{0}/{1}", URI, ProdutoID));
                client.DeleteAsync(url);
                if (responseMessage.IsSuccessStatusCode)
                {
                    MessageBox.Show("Cliente excluído com sucesso");
                }
                else
                {
                    MessageBox.Show("Falha ao excluir o cliente  : " + responseMessage.StatusCode);
                }
            }
            
        }

        private void btnAtualizarAluno_Click(object sender, EventArgs e)
        {
            AtualizarAluno(txtIdAluno.Text);

        }
        private async void AtualizarAluno(string id)
        {
            var url = "http://localhost:5291/alunos" + "/" + id;
            Alunos aluno = new Alunos();
            aluno.Nome = txtNomeAluno.Text;
            aluno.Matricula = txtMatricula.Text;
            aluno.notas = txtNota.Text;

            using (var client = new HttpClient())
            {
                HttpResponseMessage responseMessage = await client.PutAsJsonAsync(url, aluno );
                if (responseMessage.IsSuccessStatusCode)
                {
                    MessageBox.Show("Aluno atualizado");
                }
                else
                {
                    MessageBox.Show("Falha ao atualizar o aluno : " + responseMessage.StatusCode);
                }
            }
            
        }
    }
}
