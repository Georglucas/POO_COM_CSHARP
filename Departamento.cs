using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;


namespace POO_COM_CSHARP
{
    class Departamento
    {
        private string nome;
        public string Nome
        {
            get => nome;
            set => nome = value;
        }
        public List<Professor> professores = new List<Professor> ();
        private Escola escola = new Escola();
        public Escola setEscola
        {
            get => escola;
            set => escola = value;
        }

        public void addProfessor(Professor professor)
        {
            this.professores.Add(professor);
        }
        public void ListarProfessores()
        {
            foreach (Professor professor in this.professores)
            {
                WriteLine("Professor: {0}", professor.getNome());
            }
            WriteLine("\n****************************************************************************************\n");
        }
    }
}
