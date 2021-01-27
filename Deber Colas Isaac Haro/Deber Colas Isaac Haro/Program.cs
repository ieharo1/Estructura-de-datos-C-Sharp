using System;

namespace Deber_Colas_Isaac_Haro
{
    class PERSON
    {
        static public int NumElements = 0;
        private string[] Name;
        private int[] Age;
        private int start, final;
        public PERSON(int a)
        {
            start = -1;
            final = -1;
            Name = new string[a];
            Age = new int[a];
            for (int z = 0; z < a; z++)
            {
                Name[z]= null;
                Age[z]= -1;
            }
        }
        public bool EMPTY()
        {
            if (final.Equals(NumElements - 1))
                return true;
            else
                return false;
        }
        public void PRINT(int number)
        {
            for (int cont = start + 1; cont < number; cont++)
            {
                if (Age[cont].Equals(-1))
                    cont++;
                else
                    Console.WriteLine("Name:{0}, Age:{1}", Name[cont], Age[cont]);
            } 
        }
        public void ORDER(int number)
        {
            string auxn = "";
            int aux = 0,cont;
            for (int i = final+1; i < number - 1; i++)
            {
                for (cont = 0; cont <number - 1; cont++)
                {
                    if (Age[cont] > Age[cont + 1])
                    {
                        aux = Age[cont];
                        Age[cont] = Age[cont + 1];
                        Age[cont + 1] = aux;
                        auxn = Name[cont];
                        Name[cont] = Name[cont + 1];
                        Name[cont + 1] = auxn;
                    }
                }
                cont = 0;
                final++;
            }
            if ((final+1).Equals(NumElements - 1))
                final = -1;
            if (start.Equals(final))
                Console.WriteLine("Tail is full, it does not support adding elements");    
        }
        public void REMOVE(int REMOVE_AGE)
        {
            if (EMPTY())
                Console.WriteLine("Tail is empty, it does not possible remove elements");
            for (int aux = start + 1; aux < REMOVE_AGE; aux++)
            {
                Age[aux] = -1;
                Name[aux] = "";
            }
        }
        public void INSERT(int number, int number2)
        {
            for(int cont= final+1; cont < number2; cont++)
            {

            }
        }
        public void ENTER_PERSON(int number)
        {
            for (int cont = final + 1; cont <number; cont++)
            {
                Console.WriteLine("Introduce the name of the person:");
                Name[cont] = Console.ReadLine();
                Console.WriteLine("Introduce the age of the person:");
                Age[cont] = int.Parse(Console.ReadLine());
            }
        }
    }
    class Program
    {
        static void Main(string[] args) 
        {
            int number,REMOVE_AGE, number2;
            Console.WriteLine("Introduce the number of persons with you want to work");
            number = int.Parse(Console.ReadLine());
            PERSON Person1= new PERSON(number);
            Person1.ENTER_PERSON(number);
            Person1.ORDER(number);
            Person1.PRINT(number);
            Console.WriteLine("If you want to remove persons, introduce the number of persons to remove");
            REMOVE_AGE = int.Parse(Console.ReadLine());
            Person1.REMOVE(REMOVE_AGE);
            Person1.PRINT(number);
            Console.WriteLine("If you want to insert persons, introduce the number of persons to insert");
            number2 = int.Parse(Console.ReadLine());
            Person1.INSERT(number, number2);
        }
    }
}
