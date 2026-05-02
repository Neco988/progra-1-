using System;

class Program
{
    static void Main()
    {
        int[,] compras = new int[5,5]
        {
            {50, 20, 10, 5, 10},
            {200, 150, 100, 50, 20},
            {500, 300, 200, 100, 50},
            {1200, 300, 200, 100, 50},
            {80, 10, 5, 3, 2}
        };

        CalcularDescuentos(compras);
    }

    static void CalcularDescuentos(int[,] matriz)
    {
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            int total = 0;

            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                total += matriz[i, j];
            }

            double descuento = 0;

            if (total >= 100 && total <= 1000)
                descuento = total * 0.10;
            else if (total > 1000)
                descuento = total * 0.20;

            double totalFinal = total - descuento;

            Console.WriteLine("Cliente " + (i + 1));
            Console.WriteLine("Total: " + total);
            Console.WriteLine("Descuento: " + descuento);
            Console.WriteLine("Total Final: " + totalFinal);
            Console.WriteLine("----------------------");
        }
    }
}
