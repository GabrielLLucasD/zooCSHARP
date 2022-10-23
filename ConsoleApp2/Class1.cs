using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{

    class Pessoa
    {
        public string Nome;
        public int Idade;

    }

    class Aluno : Pessoa
    {

        public string Turma;
        
        public int Matricula;

        public  Aluno(string nome, int idade, string turma, int matricula){
            this.Nome = nome;
            this.Idade = idade;
            this.Turma = turma;
            this.Matricula = matricula;
            }

        public void aluno1(string nome, int idade, string turma, int matricula)
        {

        }

    }

    internal class Class1
    {

        void Main()
        {
            Aluno pedrin = new Aluno("robertinha",145,"Van Gogh",123456);
            Console.WriteLine(pedrin.Nome); 

        }
        static List<Aluno> alunos = new List<Aluno>();
    


    }
}
