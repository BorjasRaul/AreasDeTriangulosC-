using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_de_Figuras
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double Lc, ACuadrado, Radioc,ACirculo,pi=3.14, Drombo,drombo,ARombo,Atrapecio,Btrapecio,Areatrapecio,Htrapecio;
            Console.WriteLine("Area de un Cuadrado");
            Console.WriteLine("Ingresa el valor de lado de un cuadraddo");
            Lc = double.Parse(Console.ReadLine());
            ACuadrado = Lc * Lc;
            Console.WriteLine("El area de un cuadrado es : " + ACuadrado);
            Console.WriteLine();
            Console.WriteLine("Area de un Circulo");
            Console.WriteLine("Ingrese el radio de un circulo");
            Radioc = double.Parse(Console.ReadLine());
            ACirculo = pi * Radioc * Radioc;
            Console.WriteLine("El area de el circulo es : " + ACirculo);
            Console.WriteLine();
            Console.WriteLine("Area de un Rombo");
            Console.WriteLine("Ingrese el valor de la diagonal mayor de un rombo");
            Drombo = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor de la diagonal menor de un rombo ");
            drombo = double.Parse(Console.ReadLine());
            ARombo = (Drombo * drombo) / 2;
            Console.WriteLine("El area de el rombo es :" + ARombo);
            Console.WriteLine();
            Console.WriteLine("Area de un Trapecio");
            Console.WriteLine("Ingresa el valor del lado a de un trapecio");
            Atrapecio= double.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa el valor del lado B de un trapecio");
            Btrapecio = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa la altura del trapecio");
            Htrapecio = Double.Parse(Console.ReadLine());
            Areatrapecio = Htrapecio * ((Atrapecio * Btrapecio) / 2);
            Console.WriteLine("El area del trapecio es "+ Areatrapecio);





        }
    }
}
