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




    }
}