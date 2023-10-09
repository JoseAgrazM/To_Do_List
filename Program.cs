using System.Linq.Expressions;
using System.Net.Http.Headers;

namespace To_Do_List
{
    internal class Program
    {

        static void Main(string[] args)
        {
            

            Logica_menu();

            Console.ReadLine();
        }

        

        static void Menu_Interacciones()
        {
            string casos = "";

            casos += "╔════════════════════╗" + Environment.NewLine;
            casos += "║      L I S T A     ║" + Environment.NewLine;
            casos += "╠════════════════════╣" + Environment.NewLine;
            casos += "║  1. Mostar lista   ║" + Environment.NewLine;
            casos += "║  2. Agregar tarea  ║" + Environment.NewLine;
            casos += "║  3. Borrar tarea   ║" + Environment.NewLine;
            casos += "║  4. Salir          ║" + Environment.NewLine;
            casos += "╚════════════════════╝" + Environment.NewLine;

            Console.WriteLine(casos);

        }

        static void Lista()
        {
            
        }

        static void Logica_menu()
        {

            int opcion = 0;

            List<string> listaMenu = new List<string>();


            while (opcion != 4)
            {
                Console.Clear();

                Menu_Interacciones();
            Console.WriteLine("Pulsa el numero de lo que quieres hacer.");
            
            opcion = Convert.ToInt32(Console.ReadLine());


                if (opcion == 1)
                {
                    Console.Clear() ;
                    Console.WriteLine("------ Lista de elementos ------");
                    Console.WriteLine();
                    foreach (string elem in listaMenu)
                    {

                        Console.WriteLine($"{elem}");

                    }
                    Console.WriteLine("Presione cualquier tecla para continuar");

                    Console.ReadKey();


                }
                else if (opcion == 2)
                {
                    Console.Clear();
                    Console.WriteLine("------ Agregar elemento ------");
                    Console.WriteLine();
                    Console.WriteLine("Escribe el elemento que deseas guardar");
                    string el = Console.ReadLine();

                    listaMenu.Add(el);

                    Console.WriteLine("Elemento añadido, presione cualquier tecla para continuar");

                    Console.ReadKey ();
                }
                else if (opcion == 3)
                {
                    Console.Clear();
                    Console.WriteLine("------ Borrar elemento ------");
                    Console.WriteLine();
                        Console.WriteLine("Presione el numero que desea borrar");


                    foreach(string elem in listaMenu)
                    {

                        Console.WriteLine($"{listaMenu.IndexOf(elem) + 1}. {elem}");

                    }

                    int borrarElem = Convert.ToInt32(Console.ReadLine());

                    if (borrarElem > 0 && borrarElem < listaMenu.Count())
                    {
                        listaMenu.RemoveAt(borrarElem -1) ;

                    }

                    Console.WriteLine("Elemento eliminado, presione cualquier tecla para continuar");

                    Console.ReadKey();




                }
            }
        }

    }
}