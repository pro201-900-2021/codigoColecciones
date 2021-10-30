using System;
using System.Collections.Generic;
//using System.Collections.Generic;

namespace codigoColecciones
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayNumeros = new int[3];
            arrayNumeros[0] = 25;
            arrayNumeros[1] = 250;
            arrayNumeros[2] = 100;

            int numero3 = 100;
            //tipo de dato List<int>
            List<int> listaNumeros = new List<int>();

            //Con Add, añado elementos a la lista.
            listaNumeros.Add(25);//0
            listaNumeros.Add(250);//1
            listaNumeros.Add(numero3);//2

            //tipo de dato - nombre 
            mostrarDatosLista(listaNumeros);

            listaNumeros.ToArray(); // List<T> ==> T[]
            //Clear limpia una lista de todos los datos, vuelve la lista vacia.
            //listaNumeros.Clear();
            //mostrarDatosLista(listaNumeros);

            Console.WriteLine("La llista tiene "+listaNumeros.Count+" elementos.");

            listaNumeros.RemoveAt(1);
            mostrarDatosLista(listaNumeros);


            //QUEUE --> Colas
            //Primero que se registra, posteriormente será el primero en salir, y así sucesivamente.
            Console.WriteLine("Aquí comienza el trabajo con Queues");
            Queue<int> colaNumeros = new Queue<int>();
            //Enqueue
            //Dequeue
            //Peek
            colaNumeros.Enqueue(5);
            colaNumeros.Enqueue(10);
            colaNumeros.Enqueue(15);

            foreach(int elementoCola in colaNumeros)
            {
                Console.WriteLine(elementoCola);
            }
            Console.WriteLine("=");
            colaNumeros.Dequeue();

            foreach (int elementoCola in colaNumeros)
            {
                Console.WriteLine(elementoCola);
            }
            Console.WriteLine("=");
            colaNumeros.Dequeue();

            foreach (int elementoCola in colaNumeros)
            {
                Console.WriteLine(elementoCola);
            }

            Console.WriteLine("El siguiente elemento en salir de la cola será: "+colaNumeros.Peek());


            //Aquí comienzo trabajo con Pilas
            Console.WriteLine("Aquí comienza el trabajo con Stack");
            Stack<int> pilaNumeros = new Stack<int>();
            //push
            //Pop
            //peek
            pilaNumeros.Push(5);
            pilaNumeros.Push(10);
            pilaNumeros.Push(15);

            foreach (int elementoDeLaPila in pilaNumeros)
            {
                Console.WriteLine(elementoDeLaPila);
            }
            Console.WriteLine("El siguiente elemento que saldrá de la pila será: " + pilaNumeros.Peek());
            pilaNumeros.Pop();
            Console.WriteLine("=pop");
            foreach (int elementoDeLaPila in pilaNumeros)
            {
                Console.WriteLine(elementoDeLaPila);
            }

            //Aquí comienzo el trabajo con diccionarios
            Console.WriteLine("Diccionarios...");
            //Key: llave a través de la cual accedo al valor
            //Value: es el valor
            //lista = [ 4 , 5, 6] => lista[0] 
            //diccionario = {numero1: 4 , numero2: 5, numero3: 6} ==>> diccionario[numero1] == 4
            Dictionary<string, string> diccionarioEjemplo = new Dictionary<string, string>();
            diccionarioEjemplo.Add("Nombre", "Diego");
            //{"Nombre": "Diego"}
            diccionarioEjemplo["Apellido"] = "Lucero";
            //diccionarioEjemplo.Add("Apellido", "Lucero");

            foreach(var elemento in diccionarioEjemplo)
            {
                Console.WriteLine(elemento.Key);
                Console.WriteLine(elemento.Value);
            }

            Console.WriteLine(diccionarioEjemplo["Nombre"]);
            Console.WriteLine(diccionarioEjemplo["Apellido"]);

            Console.WriteLine(diccionarioEjemplo.ContainsKey("Edad"));


            //Trabajo con LinkedList
            Console.WriteLine("Aquí comienzo con LinkedList");

            LinkedList<string> ejemploLinked = new LinkedList<string>();

            LinkedListNode<string> ejemploNodo = new LinkedListNode<string>("Pía");

            ejemploLinked.AddLast(ejemploNodo);

            LinkedListNode<string> primerNodo = ejemploLinked.First.Next;

            foreach(string elemento in ejemploLinked)
            {
                Console.WriteLine(elemento);
            }
        }

        private static void mostrarDatosLista(List<int> lista)
        {
            Console.WriteLine("*********************************");
            foreach (int numeroEnEsteMomento in lista)
            {
                Console.WriteLine(numeroEnEsteMomento);
                Console.WriteLine("*********************************");
            }
            
        }
    }
}
