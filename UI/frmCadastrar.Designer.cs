namespace UI
{
    partial class frmCadastrar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbController = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.txtpesq = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.dgvPessoas = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btncadastrar = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnDeletarAluno = new System.Windows.Forms.Button();
            this.btnPesqAluno = new System.Windows.Forms.Button();
            this.txtPesqAluno = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCarregar = new System.Windows.Forms.Button();
            this.dgvAlunos = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.txtNota = new System.Windows.Forms.TextBox();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.txtIdAluno = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNomeAluno = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnCadastrarAluno = new System.Windows.Forms.Button();
            this.btnAtualizarAluno = new System.Windows.Forms.Button();
            this.tbController.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPessoas)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlunos)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbController
            // 
            this.tbController.Controls.Add(this.tabPage1);
            this.tbController.Controls.Add(this.tabPage2);
            this.tbController.Controls.Add(this.tabPage3);
            this.tbController.Controls.Add(this.tabPage4);
            this.tbController.Location = new System.Drawing.Point(1, 2);
            this.tbController.Name = "tbController";
            this.tbController.SelectedIndex = 0;
            this.tbController.Size = new System.Drawing.Size(809, 448);
            this.tbController.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.txtpesq);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.btnPesquisar);
            this.tabPage1.Controls.Add(this.dgvPessoas);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(801, 420);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cadastro de Pessoas";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(624, 373);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Excluir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtpesq
            // 
            this.txtpesq.Location = new System.Drawing.Point(16, 36);
            this.txtpesq.Name = "txtpesq";
            this.txtpesq.Size = new System.Drawing.Size(310, 23);
            this.txtpesq.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Pesquisar";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(351, 36);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 10;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click_1);
            // 
            // dgvPessoas
            // 
            this.dgvPessoas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPessoas.Location = new System.Drawing.Point(8, 76);
            this.dgvPessoas.Name = "dgvPessoas";
            this.dgvPessoas.RowTemplate.Height = 25;
            this.dgvPessoas.Size = new System.Drawing.Size(766, 269);
            this.dgvPessoas.TabIndex = 0;
            this.dgvPessoas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPessoas_CellContentClick);
            this.dgvPessoas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPessoas_CellDoubleClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtLastName);
            this.tabPage2.Controls.Add(this.txtId);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.txtName);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.btncadastrar);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(801, 420);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Cadastrar Pessoa";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(61, 190);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(310, 23);
            this.txtLastName.TabIndex = 9;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(61, 63);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(310, 23);
            this.txtId.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Id";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(63, 118);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(310, 23);
            this.txtName.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "SobreNome";
            // 
            // btncadastrar
            // 
            this.btncadastrar.Location = new System.Drawing.Point(63, 305);
            this.btncadastrar.Name = "btncadastrar";
            this.btncadastrar.Size = new System.Drawing.Size(75, 23);
            this.btncadastrar.TabIndex = 7;
            this.btncadastrar.Text = "Cadastrar";
            this.btncadastrar.UseVisualStyleBackColor = true;
            this.btncadastrar.Click += new System.EventHandler(this.btncadastrar_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnDeletarAluno);
            this.tabPage3.Controls.Add(this.btnPesqAluno);
            this.tabPage3.Controls.Add(this.txtPesqAluno);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.btnCarregar);
            this.tabPage3.Controls.Add(this.dgvAlunos);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(801, 420);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = " Cadastro de Alunos";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnDeletarAluno
            // 
            this.btnDeletarAluno.Location = new System.Drawing.Point(593, 368);
            this.btnDeletarAluno.Name = "btnDeletarAluno";
            this.btnDeletarAluno.Size = new System.Drawing.Size(75, 23);
            this.btnDeletarAluno.TabIndex = 5;
            this.btnDeletarAluno.Text = "Deletar";
            this.btnDeletarAluno.UseVisualStyleBackColor = true;
            this.btnDeletarAluno.Click += new System.EventHandler(this.btnDeletarAluno_Click);
            // 
            // btnPesqAluno
            // 
            this.btnPesqAluno.Location = new System.Drawing.Point(322, 37);
            this.btnPesqAluno.Name = "btnPesqAluno";
            this.btnPesqAluno.Size = new System.Drawing.Size(75, 23);
            this.btnPesqAluno.TabIndex = 4;
            this.btnPesqAluno.Text = "Pesquisar";
            this.btnPesqAluno.UseVisualStyleBackColor = true;
            this.btnPesqAluno.Click += new System.EventHandler(this.btnPesqAluno_Click);
            // 
            // txtPesqAluno
            // 
            this.txtPesqAluno.Location = new System.Drawing.Point(62, 37);
            this.txtPesqAluno.Name = "txtPesqAluno";
            this.txtPesqAluno.Size = new System.Drawing.Size(254, 23);
            this.txtPesqAluno.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "Pesquisar";
            // 
            // btnCarregar
            // 
            this.btnCarregar.Location = new System.Drawing.Point(672, 37);
            this.btnCarregar.Name = "btnCarregar";
            this.btnCarregar.Size = new System.Drawing.Size(75, 23);
            this.btnCarregar.TabIndex = 1;
            this.btnCarregar.Text = "Carregar";
            this.btnCarregar.UseVisualStyleBackColor = true;
            this.btnCarregar.Click += new System.EventHandler(this.btnCarregar_Click);
            // 
            // dgvAlunos
            // 
            this.dgvAlunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlunos.Location = new System.Drawing.Point(10, 80);
            this.dgvAlunos.Name = "dgvAlunos";
            this.dgvAlunos.RowTemplate.Height = 25;
            this.dgvAlunos.Size = new System.Drawing.Size(749, 223);
            this.dgvAlunos.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btnAtualizarAluno);
            this.tabPage4.Controls.Add(this.txtNota);
            this.tabPage4.Controls.Add(this.txtMatricula);
            this.tabPage4.Controls.Add(this.txtIdAluno);
            this.tabPage4.Controls.Add(this.label6);
            this.tabPage4.Controls.Add(this.txtNomeAluno);
            this.tabPage4.Controls.Add(this.label9);
            this.tabPage4.Controls.Add(this.label7);
            this.tabPage4.Controls.Add(this.label8);
            this.tabPage4.Controls.Add(this.btnCadastrarAluno);
            this.tabPage4.Location = new System.Drawing.Point(4, 24);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(801, 420);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Cadastrar Aluno";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // txtNota
            // 
            this.txtNota.Location = new System.Drawing.Point(69, 236);
            this.txtNota.Name = "txtNota";
            this.txtNota.Size = new System.Drawing.Size(310, 23);
            this.txtNota.TabIndex = 15;
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(70, 169);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(310, 23);
            this.txtMatricula.TabIndex = 15;
            // 
            // txtIdAluno
            // 
            this.txtIdAluno.Location = new System.Drawing.Point(70, 42);
            this.txtIdAluno.Name = "txtIdAluno";
            this.txtIdAluno.Size = new System.Drawing.Size(310, 23);
            this.txtIdAluno.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(69, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Id";
            // 
            // txtNomeAluno
            // 
            this.txtNomeAluno.Location = new System.Drawing.Point(72, 97);
            this.txtNomeAluno.Name = "txtNomeAluno";
            this.txtNomeAluno.Size = new System.Drawing.Size(310, 23);
            this.txtNomeAluno.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(69, 218);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 15);
            this.label9.TabIndex = 14;
            this.label9.Text = "Nota";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(71, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "Nome";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(70, 151);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 15);
            this.label8.TabIndex = 14;
            this.label8.Text = "Matricula";
            // 
            // btnCadastrarAluno
            // 
            this.btnCadastrarAluno.Location = new System.Drawing.Point(72, 333);
            this.btnCadastrarAluno.Name = "btnCadastrarAluno";
            this.btnCadastrarAluno.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrarAluno.TabIndex = 11;
            this.btnCadastrarAluno.Text = "Cadastrar";
            this.btnCadastrarAluno.UseVisualStyleBackColor = true;
            this.btnCadastrarAluno.Click += new System.EventHandler(this.btnCadastrarAluno_Click);
            // 
            // btnAtualizarAluno
            // 
            this.btnAtualizarAluno.Location = new System.Drawing.Point(177, 333);
            this.btnAtualizarAluno.Name = "btnAtualizarAluno";
            this.btnAtualizarAluno.Size = new System.Drawing.Size(75, 23);
            this.btnAtualizarAluno.TabIndex = 18;
            this.btnAtualizarAluno.Text = "Atualizar";
            this.btnAtualizarAluno.UseVisualStyleBackColor = true;
            this.btnAtualizarAluno.Click += new System.EventHandler(this.btnAtualizarAluno_Click);
            // 
            // frmCadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 449);
            this.Controls.Add(this.tbController);
            this.Name = "frmCadastrar";
            this.Text = "frmCadastrar";
            this.Load += new System.EventHandler(this.frmCadastrar_Load);
            this.tbController.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPessoas)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlunos)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tbController;
        private TabPage tabPage1;
        private DataGridView dgvPessoas;
        private TabPage tabPage2;
        private TextBox txtLastName;
        private TextBox txtName;
        private Label label1;
        private Label label2;
        private Button btncadastrar;
        private TextBox txtpesq;
        private Label label3;
        private Button btnPesquisar;
        private TextBox txtId;
        private Label label4;
        private Button button1;
        private TabPage tabPage3;
        private Button btnCarregar;
        private DataGridView dgvAlunos;
        private Button btnPesqAluno;
        private TextBox txtPesqAluno;
        private Label label5;
        private TabPage tabPage4;
        private TextBox txtNota;
        private TextBox txtMatricula;
        private TextBox txtIdAluno;
        private Label label6;
        private TextBox txtNomeAluno;
        private Label label9;
        private Label label7;
        private Label label8;
        private Button btnCadastrarAluno;
        private Button btnDeletarAluno;
        private Button btnAtualizarAluno;
    }
}