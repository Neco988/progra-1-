using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        List<string> tareas = new List<string>();
        int opcion = 0;

        while (opcion != 4)
        {
            Console.WriteLine("1. Mostrar");
            Console.WriteLine("2. Agregar");
            Console.WriteLine("3. Eliminar");
            Console.WriteLine("4. Salir");

            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Tareas:");
                    foreach (string t in tareas)
                    {
                        Console.WriteLine("- " + t);
                    }
                    break;

                case 2:
                    Console.Write("Nueva tarea (solo letras y números): ");
                    string nueva = Console.ReadLine();

                    // Validación con Regex
                    if (Regex.IsMatch(nueva, @"^[a-zA-Z0-9 ]+$"))
                    {
                        tareas.Add(nueva);
                    }
                    else
                    {
                        Console.WriteLine("Texto inválido.");
                    }
                    break;

                case 3:
                    Console.Write("Eliminar tarea: ");
                    string eliminar = Console.ReadLine();
                    tareas.Remove(eliminar);
                    break;
            }
        }
    }
}
