using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;


namespace POO_COM_CSHARP
{
    class Professor : Pessoa
    {
        public List<Aluno> alunos = new List<Aluno>();
        private Departamento departamento = new Departamento();
        public Departamento setDepartamento
        {
            get => departamento;
            set => departamento = value;
        }
        
        private int matricula;
        private int tipo;
        private double bonus;
        private double valorHora;


        public int Matricula
        {
            get => matricula;//retorna matricula
            set => matricula = value;//atribui em matricula
        }
        public int Tipo
        {
        get => tipo;
        set => tipo = value;
        }
        public double Bonus
        {
            get => bonus;
            set => bonus = value;
        }
        public double ValorHora
        {
                get => valorHora;
                set => valorHora = value;
        }

    public void imprime()
        {
            WriteLine("Nome do professor: {0}",getNome());
            WriteLine("Idade do professor: {0}",getIdade());
            WriteLine("Matricula do professor: {0}",this.matricula);
            WriteLine("Presente: {0}", ResponderPresenca());
            WriteLine("\n****************************************************************************************\n");
        }

        public string ResponderPresenca()
        {
            return "Beteu ponto hoje.";
        }
        public double CalcularSalario(int horas)
        {
            return this.ValorHora * horas;
        }
        public double CalcularSalario(int horas, double bonificacao)
        {
            double valor = this.ValorHora * horas;
            double pct = bonificacao / 100; 
            return valor+(valor*pct);
        }
        public double CalcularSalarioFinal(int horas)
        {
            if(this.Tipo == 1)
            {
                return this.CalcularSalario(horas);
            } else
            {
                var bonus = this.Bonus;
                return this.CalcularSalario(horas, this.Bonus);
            }

        }
        public void addAluno(Aluno aluno)
        {
            this.alunos.Add(aluno);
        }
        public void ImprimirAlunos()
        {
            foreach (Aluno aluno in this.alunos)
            {
                WriteLine("Aluno: {0}", aluno.getNome());
            }
            WriteLine("\n****************************************************************************************\n");
        }
    }
}
