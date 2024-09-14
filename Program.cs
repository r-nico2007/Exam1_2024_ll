public class Program
{
    private static void Main(string[] args)
    //Realizar un algoritmo con C# donde se solucione el siguiente problema: Un vendedor recibe un
    //sueldo base de $XXXX.Además, recibe una comisión del 10% sobre el valor total de cada venta que
    //realiza. El vendedor desea saber:
    //¿Cuánto dinero obtendrá por concepto de comisiones por las tres ventas que realiza en el mes?
    //¿Cuál es el total que recibirá en el mes tomando en cuenta su sueldo base y comisiones?
    //¿Cuál fue la venta que le generó la mayor comisión?
    //¿Cuál fue el promedio de las comisiones que recibió por cada venta?

    {
        Console.Write("Ingrese el valor de la primer venta: ");
        double Venta1 = Convert.ToDouble(Console.ReadLine());
        double Comision1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el valor de la segunda venta: ");
        double Venta2 = Convert.ToDouble(Console.ReadLine());
        double Comision2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el valor de la tercer venta: ");
        double Venta3 = Convert.ToDouble(Console.ReadLine());
        double Comision3 = Convert.ToDouble(Console.ReadLine());
    }
}