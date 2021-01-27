//ÁRBOLES BINARIOS CON CADENAS INFIJAS, PREFIJAS Y POSFIJAS
//GRUPO 6
//ALAN GUIJARRO, JACK NARVÁEZ, MARTÍN GUERRA, ISAAC HARO 
//ESTRUCTURA DE DATOS
//PARALELO 1
//FECHA DE ENTREGA: 23/11/2020


using System;//Librerias
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace CadenasArboles
{
    class Nodo//Clase Nodo
    {
        public Object data;//Variable publica de tipo string para guardar los datos
        public Nodo izquierdo;//Nodo izquierdo
        public Nodo derecho;//Nodo derecho
        public Nodo()//Constructor Nodo
        {
            data = null;
            izquierdo = null;
            derecho = null;
        }
    }
    class Arbol//Clase Arbol
    {
        public Nodo raiz;//Variable publica de tipo Nodo para identificar la raiz del arbol
        public Object aux = "";//Variable publica string inicializada en ""
        public Arbol()//Constructor Arbol
        {
            raiz = null;
        }
        public Nodo Izquierdo(Nodo p)//Nodo izquierdo
        {
            return p.izquierdo;
        }
        public Nodo SetIzquierdo(Nodo p, Object x)//Funcion para agregar directamente el nodo en el lado izquierdo
        {
            if (p.izquierdo == null)
            {
                p.izquierdo = new Nodo();
                p.izquierdo.data = x;
            }
            return p.izquierdo;
        }
        public Nodo SetDerecho(Nodo p, Object x)//Funcion para agregar directamente el nodo en el lado derecho
        {
            if (p.derecho == null)
            {
                p.derecho = new Nodo();
                p.derecho.data = x;
            }
            return p.derecho;
        }
        public Nodo PonerNodos(Object[] arr)//Funcion para Ingresar los Nodos
        {
            bool doble = false;
            if (raiz == null)
            {
                raiz = new Nodo();
                raiz.data = arr[0];
                if (arr.Length >= 7)
                {
                    if ((arr[0].ToString() == "+" || arr[0].ToString() == "-" || arr[0].ToString() == "*" || arr[0].ToString() == "/") && (arr[1].ToString() == "+" || arr[1].ToString() == "-" || arr[1].ToString() == "*" || arr[1].ToString() == "/") && (arr[2].ToString() == "+" || arr[2].ToString() == "-" || arr[2].ToString() == "*" || arr[2].ToString() == "/"))
                    {
                        SetDerecho(raiz, arr[6]);
                    }
                }
            }
            Nodo aux = raiz;
            Nodo aux2;
            for (int i = 1; i < arr.Length; i++)
            {
                if (aux.izquierdo == null)
                {
                    if (arr[i].ToString() == "+" || arr[i].ToString() == "-" || arr[i].ToString() == "*" || arr[i].ToString() == "/")
                    {
                        if (arr[i + 1].ToString() != "+" || arr[i + 1].ToString() != "-" || arr[i + 1].ToString() != "/" || arr[i + 1].ToString() != "*" || arr[i + 2].ToString() != "+" || arr[i + 2].ToString() != "-" || arr[i + 2].ToString() != "/" || arr[i + 2].ToString() != "*")
                        {
                            aux = SetIzquierdo(aux, arr[i]);
                            SetIzquierdo(aux, arr[i + 1]);
                            SetDerecho(aux, arr[i + 2]);
                            aux = raiz;
                            i = i + 2;
                        }
                        else if ((arr[i + 1].ToString() == "+" || arr[i + 1].ToString() == "-" || arr[i + 1].ToString() == "*" || arr[i + 1].ToString() == "/") && (arr[i + 2].ToString() == "+" || arr[i + 2].ToString() == "-" || arr[i + 2].ToString() == "*" || arr[i + 2].ToString() == "/"))
                        {
                            aux = SetIzquierdo(aux, arr[i]);
                            aux2 = SetIzquierdo(aux, arr[i + 1]);
                            SetDerecho(aux, arr[i + 6]);
                            aux = aux2;
                            doble = true;
                        }
                        else if ((arr[i + 1].ToString() == "+" || arr[i + 1].ToString() == "-" || arr[i + 1].ToString() == "*" || arr[i + 1].ToString() == "/") && (arr[i + 2].ToString() != "+" && arr[i + 2].ToString() != "-" && arr[i + 2].ToString() != "/" && arr[i + 2].ToString() != "*"))
                        {
                            if (doble)
                            {
                                aux2 = SetIzquierdo(aux, arr[i + 1]);
                                SetDerecho(aux, arr[i + 4]);
                                aux = aux2;
                            }
                            else
                            {
                                aux = SetIzquierdo(aux, arr[i]);
                                aux2 = SetIzquierdo(aux, arr[i + 1]);
                                SetDerecho(aux, arr[i + 4]);
                                aux = aux2;
                            }
                            i = i + 1;
                        }
                        else if ((arr[i + 2].ToString() == "+" || arr[i + 2].ToString() == "-" || arr[i + 2].ToString() == "*" || arr[i + 2].ToString() == "/"))
                        {
                            aux = SetIzquierdo(aux, arr[i]);
                            SetIzquierdo(aux, arr[i + 1]);
                            aux2 = SetDerecho(aux, arr[i + 2]);

                            aux = aux2;
                            i = i + 2;
                        }
                    }
                    else
                    {
                        SetIzquierdo(aux, arr[i]);
                    }
                }
                else if (aux.derecho == null)
                {
                    if (arr[i].ToString() == "+" || arr[i].ToString() == "-" || arr[i].ToString() == "*" || arr[i].ToString() == "/")
                    {
                        if (arr[i + 1].ToString() != "+" && arr[i + 1].ToString() != "-" && arr[i + 1].ToString() != "/" && arr[i + 1].ToString() != "*" && arr[i + 2].ToString() != "+" && arr[i + 2].ToString() != "-" && arr[i + 2].ToString() != "/" && arr[i + 2].ToString() != "*")
                        {
                            aux = SetDerecho(aux, arr[i]);
                            SetIzquierdo(aux, arr[i + 1]);
                            SetDerecho(aux, arr[i + 2]);
                            aux = raiz;
                            i = i + 2;
                        }
                        else if ((arr[i + 1].ToString() == "+" || arr[i + 1].ToString() == "-" || arr[i + 1].ToString() == "*" || arr[i + 1].ToString() == "/") && (arr[i + 2].ToString() == "+" || arr[i + 2].ToString() == "-" || arr[i + 2].ToString() == "*" || arr[i + 2].ToString() == "/"))
                        {
                            aux = SetDerecho(aux, arr[i]);
                            aux2 = SetIzquierdo(aux, arr[i + 1]);
                            SetDerecho(aux, arr[i + 6]);
                            doble = true;

                            aux = aux2;
                        }
                        else if ((arr[i + 1].ToString() == "+" || arr[i + 1].ToString() == "-" || arr[i + 1].ToString() == "*" || arr[i + 1].ToString() == "/") && (arr[i + 2].ToString() != "+" && arr[i + 2].ToString() != "-" && arr[i + 2].ToString() != "/" && arr[i + 2].ToString() != "*"))
                        {
                            if (doble)
                            {
                                aux2 = SetIzquierdo(aux, arr[i + 1]);
                                SetDerecho(aux, arr[i + 4]);
                                aux = aux2;
                            }
                            else
                            {
                                aux = SetDerecho(aux, arr[i]);
                                aux2 = SetIzquierdo(aux, arr[i + 1]);
                                SetDerecho(aux, arr[i + 4]);

                                aux = aux2;
                            }

                            i = i + 1;
                        }
                        else if ((arr[i + 2].ToString() == "+" || arr[i + 2].ToString() == "-" || arr[i + 2].ToString() == "*" || arr[i + 2].ToString() == "/"))
                        {
                            aux = SetDerecho(aux, arr[i]);
                            SetIzquierdo(aux, arr[i + 1]);
                            aux2 = SetDerecho(aux, arr[i + 2]);

                            aux = aux2;

                            i = i + 2;
                        }
                    }
                    else
                    {
                        SetDerecho(aux, arr[i]);
                    }
                }
                else
                {
                    aux = raiz;
                    if (aux.derecho == null || aux.izquierdo == null)
                    {
                        i--;
                    }
                }
            }

            return raiz;
        }

        public void Imprimir()//Sobrecarga de función que nos permite llamar a la otra función Imprimir
        {
            Imprimir(raiz, 4);
        }

        public void Imprimir(Nodo p, int padding)//Función que nos permite imprimir todos los nodos de nuestro árbol
        {
            if (p != null)
            {
                if (p.derecho != null)
                {
                    Imprimir(p.derecho, padding + 4);
                }
                if (padding > 0)
                {
                    Console.Write(" ".PadLeft(padding));
                }
                if (p.derecho != null)
                {
                    Console.Write("/\n");
                    Console.Write(" ".PadLeft(padding));
                }
                Console.Write(p.data + "\n ");
                if (p.izquierdo != null)
                {
                    Console.Write(" ".PadLeft(padding) + "\\\n");
                    Imprimir(p.izquierdo, padding + 4);
                }
            }
        }
        public Nodo temp;//Atributo de la clase que nos ayuda a guardar un valor temporal para las siguientes funciones
        public Object LeerPosfijo(Nodo p)//Función que nos permite leer el árbol según una notación Posfija
        {
            if (p.izquierdo != null)
            {
                temp = p;
                p = p.izquierdo;
                LeerPosfijo(p);
            }
            else if (p.derecho != null)
            {
                temp = p;
                p = p.derecho;
                LeerPosfijo(p);
            }
            else if (p.data != null)
            {
                aux += p.data.ToString();
                if (temp.izquierdo != null)
                {
                    temp.izquierdo = null;
                    LeerPosfijo(raiz);
                }
                else if (temp.derecho != null)
                {
                    temp.derecho = null;
                    LeerPosfijo(raiz);
                }
            }
            raiz = null;
            return aux;
        }
        public Object ImprimirPrefijo(Nodo p)//Función que nos permite recorrer el árbol según una notación prefija
        {
            if (p.izquierdo != null || p.derecho != null)
            {
                aux += p.data.ToString();
                temp = p;
                p.data = "";
                if (p.izquierdo != null)
                {
                    p = p.izquierdo;
                    ImprimirPrefijo(p);
                }
                else if (p.derecho != null)
                {
                    p = p.derecho;
                    ImprimirPrefijo(p);
                }
            }
            else
            {
                if (temp.izquierdo != null)
                {
                    if (temp.izquierdo.izquierdo == null)
                    {

                        aux += temp.izquierdo.data.ToString();

                        temp.izquierdo.data = "";

                        temp.izquierdo = null;
                    }
                }
                if (temp.derecho != null)
                {
                    if (temp.derecho.derecho == null)
                    {

                        aux += temp.derecho.data.ToString();

                        temp.derecho.data = "";

                        temp.derecho = null;
                    }
                    else
                    {
                        if (temp.derecho != null)
                        {
                            ImprimirPrefijo(temp.derecho);
                        }
                    }

                }
                if (temp != raiz)
                {

                    ImprimirPrefijo(raiz);
                }
            }
            return aux;
        }
        public Object Infijo(Nodo p, Object r) //Función que nos permite recorrer el árbol según una notación infija
        {
            if (p.izquierdo != null)
            {
                aux += p.data.ToString();
                temp = p;
                p.data = "";
                if (p.izquierdo != null)
                {
                    p = p.izquierdo;
                }
                else if (p.derecho != null)
                {
                    p = p.derecho;
                }
            }
            else
            {
                if (temp == raiz)
                {
                    if (temp.izquierdo.izquierdo == null)
                    {

                        aux += temp.izquierdo.data.ToString();

                        temp.izquierdo.data = ")";

                        temp.izquierdo = null;
                    }
                }
                if (temp.derecho != null)
                {
                    if (temp.derecho.derecho == null)
                    {

                        aux += temp.derecho.data.ToString();

                        temp.derecho.data = "(";

                        temp.derecho = null;
                    }
                    else
                    {
                        Infijo(temp.derecho, r);
                    }

                }
            }
            raiz = null;
            return r;
        }

    }
    //Función principal
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            //Definición de variables
            Object Infijo;
            string prefijo = "", prueba = "";
            int aux;

            Stack<string> Prefijo = new Stack<string>();
            Stack<string> opstk = new Stack<string>();

            //Ingreso de datos
            Console.WriteLine("Ingrese su cadena infija");
            Infijo = Console.ReadLine().Replace(" ", "").ToString();

            //Ingreso de datos a las pilas Posfijo y opstk
            for (int i = Infijo.ToString().Length - 1; i >= 0; i--)
            {
                if ((Infijo.ToString().Substring(i, 1) == "+" || Infijo.ToString().Substring(i, 1) == "-" && Infijo.ToString().Substring(i, 1) == "*" && Infijo.ToString().Substring(i, 1) == "/") && Infijo.ToString().Substring(i, 1) != "(" && Infijo.ToString().Substring(i, 1) != ")")
                    opstk.Push(Infijo.ToString().Substring(i, 1));
                else if ( (Infijo.ToString().Substring(i, 1) == "+" && Infijo.ToString().Substring(i, 1) == "-" || Infijo.ToString().Substring(i, 1) == "*" && Infijo.ToString().Substring(i, 1) == "/") && Infijo.ToString().Substring(i, 1) != "(" && Infijo.ToString().Substring(i, 1) != ")")
                        opstk.Push(Infijo.ToString().Substring(i, 1));
                else
                    Prefijo.Push(Infijo.ToString().Substring(i, 1));

                if (Infijo.ToString().Substring(i, 1) == "(")
                    Prefijo.Push(opstk.Pop());
            }
            //Pasamos todos los elemntos sobrantes de la pila opstk a la pila Posfijo
            for (int i = 0; i <= opstk.Count; i++)
            {
                Prefijo.Push(opstk.Peek());
                opstk.Pop();
            }

            //Pasamos nuestra pila a un string
            aux = Prefijo.Count;
            for (int j = 0; j < aux; j++)
            {
                prefijo += Prefijo.Pop();
            }

            Arbol Arbol1 = new Arbol();


            string[] nodeData = new string[prefijo.Length];

            for (int i = 0; i < prefijo.Length; i++)
            {
                nodeData[i] = prefijo.Substring(i, 1);
            }
            Arbol1.PonerNodos(nodeData);
            Arbol1.Imprimir();



            do
            {
                Console.WriteLine("\n¿Qué operación desea realizar?");
                Console.WriteLine("1 Posfijo");
                Console.WriteLine("2 Prefijo");
                Console.WriteLine("3 Infijo");
                Console.WriteLine("4 Salir");

                aux = int.Parse(Console.ReadLine());

                switch (aux)
                {
                    case 1:
                        Console.WriteLine("Su cadena posfija es {0}", Arbol1.LeerPosfijo(Arbol1.raiz));
                        Arbol1.aux = "";
                        Arbol1.raiz = null;
                        Arbol1.PonerNodos(nodeData);
                        break;
                    case 2:
                        Console.WriteLine("Su cadena prefija es {0}", Arbol1.ImprimirPrefijo(Arbol1.raiz));
                        Arbol1.aux = "";
                        Arbol1.raiz = null;
                        Arbol1.PonerNodos(nodeData);
                        break;
                    case 3:
                        Console.WriteLine("Su cadena infija es {0}", Arbol1.Infijo(Arbol1.raiz, Infijo));
                        Arbol1.aux = "";
                        Arbol1.raiz = null;
                        Arbol1.PonerNodos(nodeData);
                        break;
                    default:
                        break;
                }
            } while (aux != 4);
        }
    }
}
