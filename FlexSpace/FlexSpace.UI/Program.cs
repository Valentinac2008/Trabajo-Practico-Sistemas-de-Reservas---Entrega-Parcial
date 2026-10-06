using System;

namespace FlexSpace.UI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion;

```
        do
            {
                Console.Clear();

                Console.WriteLine("FLEXSPACE");
                Console.WriteLine("1. Registrar reserva");
                Console.WriteLine("2. Cancelar reserva");
                Console.WriteLine("3. Consultar reservas activas por puesto");
                Console.WriteLine("4. Listar clientes sancionados");
                Console.WriteLine("5. Salir");
                Console.Write("Seleccione una opción: ");

                opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Registrar reserva");
                        break;

                    case 2:
                        Console.WriteLine("Cancelar reserva");
                        break;

                    case 3:
                        Console.WriteLine("Consultar reservas activas por puesto");
                        break;

                    case 4:
                        Console.WriteLine("Listar clientes sancionados");
                        break;

                    case 5:
                        Console.WriteLine("Saliendo...");
                        break;

                    default:
                        Console.WriteLine("Opción inválida.");
                        break;
                }

                if (opcion != 5)
                {
                    Console.WriteLine();
                    Console.WriteLine("Presione una tecla para continuar...");
                    Console.ReadKey();
                }

            } while (opcion != 5);
        }
    }

}
