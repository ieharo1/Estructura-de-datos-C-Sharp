using System;
namespace List_Nodes_Queue_Isaac_Haro
{ 
//Isaac Haro
 //18/10/2020
 //version 0.1
 //Estructura de datos
    public class Node//Clase nodo de la lista
    {
        public Object data;//Dato del nodo
        public Node next;//Puntero al siguiente nodo
        public Object InfoNode()
        {
            return data;
        }
        public void PrintInfoNode()//Imprime la informacion contenida en un nodo
        {
            Console.WriteLine(data);
        }
        public Node InfoNextNode()//Devuelve la direccion del siguiente nodo
        {
            return next;
        }
        public void AddNextNode(Node nextnode)//Agrega al nodo la direccion del siguiente nodo
        {
            next = nextnode;
        }
        public void AddData(Object newfact)//Agrega el dato dentro del nodo
        {
            data = newfact;
        }
    }
    public class Queue//Clase que define una lista simple en base a el dato del primer nodo de la lista y a nodos como elmentos de la lista
    {
        public Node start;//Cabecera de la lista
        public void Push(Object data)//Inserta un nodo al inicio de la Cola
        {
            if (start == null)
            {
                start = new Node();
                start.AddData(data);
                start.AddNextNode(null);
            }
            else
            {
                Node aux = new Node();
                aux.AddData(data);
                Node current = start;
                while (aux.InfoNextNode() != null)
                {
                    current = current.InfoNextNode();
                }
                current.AddNextNode(aux);
            }
        }
        public void Pop()//Elimina un nodo al inicio de la Cola
        {
            if (start != null)
            {
                Node aux;
                aux = start.InfoNextNode();
                start = aux;
            }
            else
            {
                Console.WriteLine("Cola Vacia no es posible retirar el dato");
            }
        }
        public void PrintNodes()
        {
            Console.WriteLine("Imprime:");
            Node current = start;
            while (current != null)
            {
                current.PrintInfoNode();
                current = current.InfoNextNode();
            }
        }
    }
    class Program 
    { 
    static void Main(string[] args)//Pograma principal
    {
        Console.Title = "List";//TITULO DE LA CONSOLA
        Console.ForegroundColor = ConsoleColor.Yellow;//COLOR DE LA LETRA DE LA CONSOLA
        Queue pila1 = new Queue();//Lista
        int longp1, longp;//Variables int
        Object datop1;//Variable char
        Console.WriteLine("Ingrese la longitud con la que desea trabajar su cola");
        Console.ResetColor();//RESETEA EL COLOR DE LA CONSOLA
        Console.ForegroundColor = ConsoleColor.White;//COLOR DE LA LETRA DE LA CONSOLA
        longp1 = int.Parse(Console.ReadLine());
        if (longp1 != 0)
        {
            for (int i = 0; i < longp1; i++)
            {
                Console.WriteLine("Ingrese su dato {0} en su cola", i + 1);
                datop1 = Console.ReadLine();
                pila1.Push(datop1);
            }
            Console.ResetColor();//RESETEA EL COLOR DE LA CONSOLA
            Console.ForegroundColor = ConsoleColor.Blue;//COLOR DE LA LETRA DE LA CONSOLA
        }
        else
        {
            Console.WriteLine("Su cola esta vacia");
        }
        Console.WriteLine("Esta es su cola");
        pila1.PrintNodes();
        Console.ResetColor();//RESETEA EL COLOR DE LA CONSOLA
        Console.ForegroundColor = ConsoleColor.Yellow;//COLOR DE LA LETRA DE LA CONSOLA
        Console.WriteLine("Ingrese cuantos datos desea eliminar de su cola");
        Console.ResetColor();//RESETEA EL COLOR DE LA CONSOLA
        Console.ForegroundColor = ConsoleColor.White;//COLOR DE LA LETRA DE LA CONSOLA
        longp = int.Parse(Console.ReadLine());
        for (int i = 0; i < longp; i++)
        {
            pila1.Pop();
        }
        Console.ResetColor();//RESETEA EL COLOR DE LA CONSOLA
        Console.ForegroundColor = ConsoleColor.Blue;//COLOR DE LA LETRA DE LA CONSOLA
        Console.WriteLine("Esta es su cola, eliminado los datos");
        pila1.PrintNodes();
    }
}
}
