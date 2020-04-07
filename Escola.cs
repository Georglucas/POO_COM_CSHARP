using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;


namespace POO_COM_CSHARP
{
    class Escola
    {
        private string nome;
        public string Nome
        {
            get => nome;
            set => nome = value;
        }

        public List<Departamento> departamentos = new List<Departamento>();

        public void addDepartamento(Departamento departamento)
        {
            this.departamentos.Add(departamento);
        }
        public void ListarDepartamentos()
        {
            foreach (Departamento departamento in this.departamentos)
            {
                WriteLine("Departamento: {0}", departamento.Nome);
            }
            WriteLine("\n****************************************************************************************\n");
        }
    }
}
