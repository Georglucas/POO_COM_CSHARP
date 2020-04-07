using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;


namespace POO_COM_CSHARP
{
    class Aluno : Pessoa//Classe aluno herda os atributos e metodos da classe pessoa
    {
        
        private int matricula;
        private bool presente;
        public List<Professor> professores = new List<Professor>();

        public int Matricula
        {
            get => matricula;//retorna matricula
            set => matricula = value > 100 ? throw new Exception("Matricula não pode ser maior do que 100"):value;
            //atribui em matricula
        }
        public bool Presente
        {
            get => presente;//retorna Presente
            set => presente = value;//atribui em Presente
        }

        public void imprime()// n tem retorno
        {

            WriteLine("Nome: {0}", getNome());
            WriteLine("Idade: {0}", getIdade());
            WriteLine("Matricula: {0}", this.matricula);
            WriteLine("Presente: {0}", this.Presente);
            WriteLine("Presente: {0}", this.ResponderPresenca());
            WriteLine("\n****************************************************************************************\n");

        }
        /*public void estaPresente(bool presente)
        {
            this.presente = presente;
            if (presente==false)
            {
                WriteLine("Não está presente");
            }
            else
            {
                WriteLine("Está presente");
            }
        }*/
        public string ResponderPresenca()// isso é uma assinatura, ele tem uma visibilidade, tipo de retorno, o nome do metodo e os atributos
        {
            if (this.Presente== true)
            {
                return "PRESENTE!";
            }else
            {
                return "FALTOU!!";
            }
            
        }
        public void addProfessor(Professor professor)
        {
            this.professores.Add(professor);
        }


    }
}
