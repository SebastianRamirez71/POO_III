using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Empleado> empleados = new List<Empleado>();
            empleados.Add(new Empleado() { Id = 1, Nombre = "Agustin", Cargo = "Desarrollador", Salario = 25000, Edad = 15 });
            empleados.Add(new Empleado() { Id = 2, Nombre = "Sebastian", Cargo = "Profesor", Salario = 15000, Edad = 19 });
            empleados.Add(new Empleado() { Id = 3, Nombre = "Lucas", Cargo = "Administrador", Salario = 32000, Edad = 32 });
            empleados.Add(new Empleado() { Id = 4, Nombre = "Pedro", Cargo = "Arquitecto", Salario = 15000, Edad = 18 });

            List<int> numeros = new List<int>{12, 6, 16, 24, 234};

            

            var list1 = 
                empleados.Where(x => x.Edad >= 18)
                .ToList();

                foreach (var item in list1)
                {
                    string ejer1 = $"El empleado {item.Nombre} {item.Cargo} Tiene {item.Edad} años";
                    Console.WriteLine(ejer1);
                }

                Console.Write("\n");

                // ******* //

            var list2 =
                empleados.Where(x => x.Edad >= 0)
                .OrderByDescending(x => x.Edad).ToList();

                foreach (var item in list2)
                {
                    Console.WriteLine($"{item.Nombre} tiene {item.Edad} años");
                }
                Console.Write("\n");
            // ******* //

            var list3 = 
                empleados.Where(x => x.Edad % 2 != 0)
                .ToList();

                foreach (var item in list3)
                {
                    Console.WriteLine($"tiene {item.Edad} años impar");
                }

                Console.Write("\n");

                // ****** //

            var list4 =
                numeros.Where(x => x > 0).Average();
                Console.WriteLine($"El promedio de la lista de numeros es: {list4} \n");

                // +++++++ //
            
            var list5 =
                numeros.Where(x => x > 10 & x < 20).ToList();
                
                foreach (var item in list5)
                {
                    Console.WriteLine($"Estos son los numeros mayores que 10 y menores que 20: {item}");
                
                }

                // ++++++++++ //

                // Edad maxima
            var list6 = empleados.Max(x => x.Edad);
            Console.WriteLine($"El empleado con la edad mas alta es de: {list6}");
            var list6_2 = empleados.Min(x => x.Edad);
            Console.WriteLine($"El empleado con la edad mas baja es de: {list6_2}");

           












        }

    }
    public class Empleado
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Cargo { get; set; }
        public int Salario { get; set; }
        public int Edad { get; set; }
        public DateTime FechaNacimiento { get; set; }
    }

   
}
