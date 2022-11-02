using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AulaCadastro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cadastrarBtn_Click(object sender, EventArgs e)
        {
            //1o Passo: guardar em variáveis os valores digitados na tela para nome e matrícula.
            string nome = txtBnome.Text;
            string id = txtBid.Text;
            //2o Passo: Instanciar a classe Aluno.
            Aluno al = new Aluno(nome, id);
            //3o Passo: Conectar ao Banco de Dados.
            BancoDeDados BD = new BancoDeDados();
            if (BD.conecta()) //tenta conectar ao banco de dados
            {
                //4o Passo: Inserir o aluno no Banco de Dados.
                if (BD.inserir_aluno(al))

                    MessageBox.Show("Aluno cadastrado com sucesso");
                else

                    MessageBox.Show("Não foi possível cadastrar o aluno");
                //5o Passo: Desconectar do Banco de Dados.
                BD.desconecta();
            }
            else //quando não consegue conectar ao banco de dados, mostra uma mensagem de erro de conexão.

                MessageBox.Show("Não foi possível conectar-se ao servidor");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
