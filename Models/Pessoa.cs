using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace Csharp.Models
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Age { get; set; }

        public void Presentation()
        {
          Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Age} anos.");  
        }
    }
    
}
