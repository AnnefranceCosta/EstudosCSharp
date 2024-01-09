using System.Globalization;

namespace ProblemaComOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangulo x, y;

            x = new Triangulo();
            y = new Triangulo();


            Console.WriteLine("Entre com as medidas do triângulo X: ");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas do triângulo Y: ");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double areaX = x.AreaTriangulo();

            double areaY = y.AreaTriangulo();
          
            if(areaX > areaY)
            {
                Console.WriteLine("Area de X é maior.");
            }
            else if(areaY > areaX)
            {
                Console.WriteLine("Área de Y é maior.");
            }
            else
            {
                Console.WriteLine("Os dois possuem a mesma área.");
            }
        }
    }
}