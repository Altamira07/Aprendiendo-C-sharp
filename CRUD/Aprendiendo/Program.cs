using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aprendiendo
{
    class Program
    {
        private ArrayList personas = new ArrayList();
        int id = 0;
        static void Main(string[] args)
        {
            char opcion = '1';
            Program programa = new Program();
            Console.WriteLine("Bienvenido");
            while (opcion != '0')
            {
                
                Console.WriteLine("Opciones 1 = Agregar 2 = Listar 3 = Eliminar 4 = Buscar 0 = Salir");
                opcion = Console.ReadKey().KeyChar;
                Console.WriteLine();
                switch (opcion)
                {
                    case '1':
                        
                        programa.crear();
                        break;
                    case '2':
                        programa.listar();
                        break;
                    case '3':
                        programa.eliminar();
                        break;
                    case '4':
                        programa.buscar();
                        break;
                    default:
                        Console.WriteLine("Opcion no valida");  
                        break;
                }
            }
        }

        public void crear()
        {
            String nombre;
            int edad;

            Console.WriteLine("Dame el nombre ");
            nombre = Console.ReadLine();
            Console.WriteLine("Dame la edad ");
            edad = Int32.Parse( Console.ReadLine());
            Persona persona = new Persona(nombre,edad);
            personas.Add(persona);
        }

        public void eliminar()
        {
            Console.WriteLine("A cual deseas eliminar");
            listar();
            int id = Int32.Parse(Console.ReadLine());
            personas.RemoveAt(id);

        }
        
        public void listar()
        {
            int i = 0;
            foreach (Object persona in personas)
            {
                i++;
                Console.Write("id: "+ i+" ");
                Console.WriteLine(value: persona);
            }
            
        }
        public void buscar()
        {
            Console.WriteLine("Dame el id ");
            int id = Int32.Parse(Console.ReadLine());
            Console.WriteLine(value : personas[id-1]);
        }
    }
}
