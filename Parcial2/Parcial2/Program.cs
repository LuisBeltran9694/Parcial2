using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2
{
    class Program
    {
        static void Main(string[] args)
         int des;
            Class1 obj = new Class1();
            Console.WriteLine("ingrese 1) para multiplicar 2) para dividir 3) para los nombres y 4) para edades");
            des = int.Parse(Console.ReadLine());
            obj.operaciones(des);
        }
    }
}
    }
}