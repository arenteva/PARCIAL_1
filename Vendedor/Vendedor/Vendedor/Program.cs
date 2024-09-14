internal class Program
{
    private static void Main(string[] args)
    {
        //Solicitar por teclado sueldo base
        Console.Write("Ingrese el sueldo base del vendedor:  ");
        double sueldoBase = Convert.ToDouble(Console.ReadLine());

        // Solicitar el valor de la ventas
        Console.Write("Ingrese el valor de la venta 1:  ");
        double venta1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el valor de la venta 2:  ");
        double venta2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el valor de la venta 3:  ");
        double venta3 = Convert.ToDouble(Console.ReadLine());

        //Calcular comision de las ventas
        double comision1 = venta1 * 0.10;
        double comision2 = venta2 * 0.10;
        double comision3 = venta3 * 0.10;

        //Calcular total de comisiones
        double totalComisiones = comision1 + comision2 + comision3;

        //Calcular total recibido en el mes
        double totalRecibido = sueldoBase + totalComisiones;

        //Identificar la venta con mayor comision
        double comisionMayor = comision1;
        double ventaMayor = venta1;

        if (comision2 > comisionMayor)
        {
            comisionMayor = comision2;
            ventaMayor = venta2;
        }

        if (comision3 > comisionMayor)
        {
            comisionMayor = comision3;
            ventaMayor = venta3;
        }

        //Calcular el promedio de las comisiones
        double promedioComisiones = totalComisiones / 3;

        //Verificar si hay beneficio extra
        double totalVentas = venta1 + venta2 + venta3;
        double beneficioExtra = (totalVentas >= 1000000) ? 100000 : 0;

        //Mostrar resultados
        Console.WriteLine($"Comisiones totales por las tres ventas: {totalComisiones:C0}");
        Console.WriteLine($"Total recibido en el mes (sueldo base + comisiones + beneficio extra): {totalRecibido + beneficioExtra:C0}");
        Console.WriteLine($"Venta que generó la mayor comisión: {ventaMayor:C0}");
        Console.WriteLine($"Promedio de las comisiones: {promedioComisiones:C0}");
        Console.WriteLine($"Beneficio extra recibido: {beneficioExtra:C0}");


    }
}