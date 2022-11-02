using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace AulaCadastro
{
    class BancoDeDados
    {
        private MySqlConnection bdConn;
        //método para fazer a conexão ao banco de dados
        public bool conecta()
        {
            bool retorno = true; //cria variável de retorno
                                 //instancia a classe MySqlConnection passando a string de conexão
            bdConn = new
            MySqlConnection("server=localhost;database=bd_cadastro;uid=root;pwd=''");
            try
            {
                bdConn.Open(); // tenta abrir uma conexão com o banco de dados.
            }
            catch
            {
                retorno = false; //altera a variável de retorno para false se não conseguir conexão.
}
            return retorno;
        }

        public void desconecta()
        {
            bdConn.Close(); //desconecta a base de dados
        }

        public bool inserir_aluno(Aluno al)
        {
            bool retorno = true;
            try // vai tentar inserir o aluno
            {
                string comandoSql = "INSERT INTO tab_aluno(nome,id) VALUES (@nome, @id)";
            MySqlCommand cmd = new MySqlCommand(comandoSql, bdConn);
                cmd.Parameters.AddWithValue("@nome", al.nome);
                cmd.Parameters.AddWithValue("@id", al.id);
                cmd.ExecuteNonQuery(); //executa o comando SQL.
            }
            catch // quando não consegue inserir retorna falso.
            {
                retorno = false;
            }
            return retorno;
        }
    }
}
