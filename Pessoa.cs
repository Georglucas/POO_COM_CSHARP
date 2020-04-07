using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace POO_COM_CSHARP
{
    class Pessoa
    {
        private string nome;
        private int idade;

        public string getNome()//metodo tem que retornar o msm tipo
        {
            return this.nome;
        }

        public void setNome(string nome)
        {
            this.nome = nome;
        }
        public int getIdade()
        {
            return this.idade;
        }

        public void setIdade(int idade)
        {
            this.idade = idade;
        }

        public string ResponderPresenca()// isso é uma assinatura, ele tem uma visibilidade, tipo de retorno, o nome do metodo e os atributos
        {
            return "Estou aqui.";
        }
        
    }
}
