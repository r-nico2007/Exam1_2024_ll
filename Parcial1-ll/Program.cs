public class Program
{
    private static void Main(string[] args)

    //Escriba un programa que pida los coeficientes de una ecuación de primer grado (a x + b = 0) y muestre la solución.
    //Una ecuación de primer grado puede no tener solución, tener una solución única, o que todos los 
    //números sean solución. La fórmula de las soluciones es x = -b / a
   
    {
        Console.WriteLine("ax + b = 0");

        Console.Write("Ingrese el valor de a: ");
        decimal num1 = Convert.ToDecimal(Console.ReadLine());

        Console.WriteLine("Ingrese el valor de b: ");
        Decimal num2 = Convert.ToDecimal(Console.ReadLine());

        if (num1 > 0)
        {
            decimal Solución = (-num2 / num1);
            Console.Write($"El coeficiente de la ecuación es igual");
        }

    }

   
}