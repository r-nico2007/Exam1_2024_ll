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

    //Además, la empresa da un beneficio extra de $100.000 si el vendedor supera el objetivo del mes.
    //El objetivo es sumar en las 3 ventas como mínimo $1.000.000 en ventas.

    //Mostrar un mensaje donde indique si ganó o no el beneficio.

    {
        Console.Write("Ingrese el valor de la primer venta: ");
        double Venta1 = Convert.ToDouble(Console.ReadLine());
        double Comision1 = ((Venta1 * 10) / 100);

        Console.Write("Ingrese el valor de la segunda venta: ");
        double Venta2 = Convert.ToDouble(Console.ReadLine());
        double Comision2 = ((Venta2 * 10) / 100);

        Console.Write("Ingrese el valor de la tercer venta: ");
        double Venta3 = Convert.ToDouble(Console.ReadLine());
        double Comision3 = ((Venta3 * 10) / 100);

        //Solución a la primera pregunta
        double DineroComisiones = (Comision1 + Comision2 + Comision3);
        Console.WriteLine($"Por comisiones se obtuvo un total de {DineroComisiones:C} por las tres ventas");

        //Solución a la segunda pregunta
        double DineroVentas = (Venta1 + Venta2 + Venta3);
        Console.WriteLine($"Se obtuvo por medio de ventas un total de {DineroVentas:C}");
        double DineroTotal = (DineroVentas + DineroComisiones);
        Console.WriteLine($"Teniendo en cuenta que su sueldo base son sus ventas. El vendedor recibirá un sueldo de {DineroTotal:C}");

        //Solución a la tercera pregunta
        if ((Venta1 > Venta2) && (Venta1 > Venta2))
        {
            Console.WriteLine($"La venta por valor de {Venta1:C} es la de mayor comisión");

        }
        else if ((Venta2 > Venta1) && (Venta2 > Venta3))
        {
            Console.WriteLine($"La venta por valor de {Venta2:C} es la de mayor comisión");
        }
        else if ((Venta3 > Venta2) && (Venta3 > Venta1))
        {
            Console.WriteLine($"La venta por valor de {Venta3:C} es la de mayor comisión");
        }

        //Solución a la cuarta pregunta
        const double CantidadComisiones = 3;
        Double PromedioComisiones = (DineroVentas / CantidadComisiones);
        Console.WriteLine($"El promedio de las comisiones por cada venta fué de {PromedioComisiones}");

        //Solución a la quinta pregunta
        const double Objetivo = 1000000;
        const double Beneficio = 100000;
        if (DineroVentas > Objetivo)
        {
            Console.Write($"El vendedor logró el objetivo mensual de {Objetivo:C}. Por ende será bonificado con {Beneficio:C}");
        }
        else
        {
            Console.Write($"El vendedor no logró el objetivo mensual de {Objetivo:C}");
        }
    }
}