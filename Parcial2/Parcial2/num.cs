using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Parcial2
{
    class num
    {
        public double num1, num2, num3, num4;
      public double n1, n2;
        string nombre;
        int des , edad;
        int i;
        public void operaciones(int des ){
            des = this.des;
            switch(des){
                case 1 : 
                    Console.WriteLine("Ingrese el primer numero");
                    n1 = Double.Parse(Console.ReadLine());
                    if (n1 == 0)
                    {
                        Console.WriteLine("***El producto de cualquier numero es 0**** ");
                    }else{
                        Console.WriteLine("Ingrese el segundo numero");
                        n2 = Double.Parse(Console.ReadLine());
                    }
                    Console.WriteLine("EL producto es: " + (n1*n2));
                    Console.ReadKey();
                    break;
                case 2 : 
                    Console.WriteLine("Ingrese el tercer nuero");
                    n1 = Double.Parse(Console.ReadLine());
                    if (n1 == 0)
                    {
                        Console.WriteLine("No se puede dividir ");
                    }
                    else
                    {
                        Console.WriteLine(" Difgite el segundo numero");
                        n2 = Double.Parse(Console.ReadLine());
                    }
                    Console.WriteLine("el resultado de la division es: " + (n1/n2));
                    Console.ReadKey();
                    break;
                case 3 :
                    for (i = 0; i <= 5; i++)
                    {
                        Console.WriteLine("Ingrese  un nombre");
                        nombre = Convert.ToString(Console.ReadLine());
                        Console.WriteLine(" su nombre es: " + nombre);
                    }
                    Console.ReadKey();
                    break;
                case 4 :
                    do
                    {
                        Console.WriteLine("Ingrese su edad");
                        Console.WriteLine("su edad es: " + edad);
                        i++;
                    } while (i <= 5);
                    Console.ReadKey();
                    break;

            }
        }

    }
}





    }
}
