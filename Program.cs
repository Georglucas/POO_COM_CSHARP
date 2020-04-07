using System;
using static System.Console;

namespace POO_COM_CSHARP
{
    class Program//Classe é onde classificamos os objetos
                   //
    {
        static void Main(string[] args)
        {
            Departamento humanas = new Departamento();
            humanas.Nome = "Departamento de Humanas";

            Departamento exatas = new Departamento();
            exatas.Nome = "Departamento de Exatas";

            Aluno aluno1 = new Aluno();
            aluno1.setNome("Daniel da Silva");
            aluno1.setIdade(24);
            aluno1.Matricula = 34;
            aluno1.Presente= true;
            aluno1.ResponderPresenca();
            aluno1.imprime();

            Aluno aluno2 = new Aluno();
            aluno2.setNome("Daniela da Silva");
            aluno2.setIdade(23);
            aluno2.Matricula = 67;
            aluno2.Presente = true;
            aluno2.ResponderPresenca();
            aluno2.imprime();

            Professor professor = new Professor();
            professor.setNome("Jose Machado");
            professor.setIdade(35);
            professor.Matricula = 47;
            professor.ValorHora = 30;
            professor.Tipo = 1;
            professor.Bonus = 0;
            WriteLine("Salario: {0:c}", professor.CalcularSalarioFinal(120));
            professor.ResponderPresenca();
            professor.imprime();
            professor.addAluno(aluno1);
            professor.addAluno(aluno2);
            professor.ImprimirAlunos();
            professor.setDepartamento = exatas;

            Professor professor2 = new Professor();
            professor2.setNome("Joao Ferreira");
            professor2.setIdade(55);
            professor2.Matricula = 12;
            professor2.ValorHora = 30;
            professor2.Tipo = 2;
            professor2.Bonus = 15;
            WriteLine("Salario: {0:c}", professor2.CalcularSalarioFinal(120));
            professor2.ResponderPresenca();
            professor2.imprime();
            professor2.addAluno(aluno1);
            professor2.ImprimirAlunos();
            professor.setDepartamento = humanas;

            humanas.addProfessor(professor);
            exatas.addProfessor(professor2);

            aluno1.addProfessor(professor);

        }
    }
}
