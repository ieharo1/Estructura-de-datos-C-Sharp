using System;
using System.Collections.Generic;
//Isaac Haro
namespace Lista_de_adyacencia
{
    class Nodo//Clase Nodo
    {
        public int dato;//variable int
        private Nodo Siguiente;//Nodo
        public Nodo()//constructor
        {
            Siguiente = null;
        }
        public Nodo(int d)//ingreso de datos
        {
            dato = d;
            Siguiente = null;
        }
        public Nodo siguiente//siguiente
        {
            get { return Siguiente; }
            set { Siguiente = value; }
        }
        public int Dato//dato
        {
            get { return dato; }
            set { dato = value; }
        }
    }
    class Nodo2//nodo2 para strings
    {
        public string dato;//variable de tipo string
        private Nodo2 Siguiente2;//Nodo2
        public Nodo2()//constructor
        {
            Siguiente2 = null;
        }
        public Nodo2(string d)//ingreso de datos
        {
            dato = d;
            Siguiente2 = null;
        }
        public Nodo2 siguiente//siguiente
        {
            get { return Siguiente2; }
            set { Siguiente2 = value; }
        }
        public string Dato//dato
        {
            get { return dato; }
            set { dato = value; }
        }

    }
    class Program//Clase program
    {
        public static void INICIALIZAR(List<Nodo2> p1)//Incializa el nodo 2
        {
            string[] n2;
            char r;
            for (int i = 0; i < p1.Count; i++)
            {
                Nodo2 comienzo = p1[i];
                Console.WriteLine("¿Su nodo " + p1[i].dato + " tiene alguna conexión? s o n");
                r = char.Parse(Console.ReadLine().ToUpper());
                if (r == 'S')
                {
                    Console.WriteLine("A qué nodo se conecta su nodo: " + p1[i].dato);
                    n2 = Console.ReadLine().Split(",");
                    for (int j = 0; j < n2.Length; j++)
                    {
                        comienzo.siguiente = new Nodo2(n2[j]);
                        comienzo = comienzo.siguiente;
                    }
                }
            }
        }
        public static void PRINTLIST(List<Nodo2> p1)//Imprime el nodo 2
        {
            Console.WriteLine("Esta es su lista de adyacencia:");

            for (int i = 0; i < p1.Count; i++)
            {
                Nodo2 aux = p1[i];
                while (aux != null)
                {
                    Console.Write(aux.dato);
                    if (aux.siguiente != null)
                    {
                        Console.Write("->");
                    }
                    aux = aux.siguiente;
                }
                Console.WriteLine(" ");
            }

        }
        public static void PrintList(List<Nodo>p1)//Imprime el nodo 1
        {
            Console.WriteLine("Esta es su lista de adyacencia");
            for (int i = 0; i < p1.Count; i++)
            {
                Nodo aux = p1[i];
                while (aux != null)
                {
                    Console.Write(aux.dato);
                    if (aux.siguiente!=null)
                    {
                        Console.Write("->");
                    }
                    aux = aux.siguiente;
                }
                Console.WriteLine("");
            }
        }
        public static void Inicializar(List<Nodo> p1)//Incializa el nodo 1
        {
            int nod;
            char r;
            for (int i = 0; i < p1.Count; i++)
            {
                Nodo comienzo = p1[i];
                Console.WriteLine("Su nodo " + p1[i].dato + " tiene alguna conexión? s o n");
                r = char.Parse(Console.ReadLine().ToUpper());
                if (r == 'S')
                {
                    Console.WriteLine("Cuantos nodos desea conectar a su nodo: " + p1[i].dato);
                    nod = int.Parse(Console.ReadLine());
                    int[] nodos2 = new int[nod];
                    for (int j = 0; j < nod; j++)
                    {
                        Console.WriteLine("Ingrese el nodo que desea agregar");
                        nodos2[j] = int.Parse(Console.ReadLine());
                        comienzo.siguiente = new Nodo(nodos2[j]);
                        comienzo = comienzo.siguiente;
                    }
                    nod = 0;
                }
            }
        }
        static void Main(string[] args)
        {
            int s;
            int nodos;
            Nodo aux;//Nodo
            Nodo2 auxi;//Nodo2
            Console.ForegroundColor = ConsoleColor.Yellow;//Color de consola
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Bienvenido desea crear su lista de adyacencia con 1: entero o con 2: caracteres?");
            s = int.Parse(Console.ReadLine());
            Console.ResetColor();
            switch (s)//switch para que el usuario escoja como trabajar su lista de adyacencia
            {
                case 1:
                    List<Nodo> p1 = new List<Nodo>();
                    Stack<int> s1 = new Stack<int>();
                    Console.BackgroundColor = ConsoleColor.DarkMagenta;
                    Console.ForegroundColor = ConsoleColor.Green;

                    Console.WriteLine("Ingrese cuantos nodos va a utilizar");
                    nodos = int.Parse(Console.ReadLine());
                    int[] n = new int[nodos];
                    for (int i = 0; i < nodos; i++)
                    {
                        Console.WriteLine("Ingrese el nodo con el que va a trabajar");
                        n[i] = int.Parse(Console.ReadLine());
                        aux = new Nodo(n[i]);
                        p1.Add(aux);
                    }
                    Inicializar(p1);
                    PrintList(p1);
                    break;
                case 2:
                    List<Nodo2> p2 = new List<Nodo2>();
                    string[] no;
                    Stack<string> s2 = new Stack<string>();
                    Console.BackgroundColor = ConsoleColor.DarkMagenta;
                    Console.ForegroundColor = ConsoleColor.Green;

                    Console.WriteLine("Ingrese en orden alfabetico los nodos con los que va a trabajar seguido de una coma\nEjemplo: A,B,C");
                    no = Console.ReadLine().Split(",");
                    for (int i = 0; i < no.Length; i++)
                    {
                        auxi = new Nodo2(no[i]);
                        p2.Add(auxi);
                    }
                    INICIALIZAR(p2);
                    PRINTLIST(p2);

                    break;
                default:
                    Console.WriteLine("Ingreso un digito no valido intente nuevamente");
                    break;
            }
        }
    }
}
