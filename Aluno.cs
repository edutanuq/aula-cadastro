using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaCadastro
{
    class Aluno
    {
        public string nome { get; set; }
        public string id { get; set; }
        public Aluno(string nome, string id)
        {
            this.nome = nome;
            this.id = id;
        }
    }
}
