using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDeCSharp.ClassesEMetodos
{
     class Pessoa
    {
        public string Nome;
        public int Idade;

        public string Apresentar()
        {
            return string.Format($"{Nome} tem {Idade} anos.");
        }
        public void ApresentarNoConsole(){
            Console.WriteLine(Apresentar());   
        }
        public void Zerar()
        {
            Nome = "";
            Idade = 0;
        }
    }
} 
