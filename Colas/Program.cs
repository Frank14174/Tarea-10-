using Colas.Clases.ColaArreglo;
using Colas.Pila_Lista;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace Colas
{
    class Program
    {
        private static bool valido(String numero) {
            bool sw = true;
            int i = 0;

            while (sw && (i < numero.Length)) {
                char c;
                c = numero[i++];
                sw = (c >= '0' && c <= '9');
            }
            return sw;
        }

        static void capicua() {
            Queue qt = new Queue();
            //qt.Enqueue("hola");
            //qt.Enqueue("esto");
            //qt.Enqueue("es");
            //qt.Enqueue("una");
            //qt.Enqueue("prueba");

            //Console.WriteLine($"La cola tiene {qt.Count} elementos");
            //Console.WriteLine($"Desencolando {qt.Dequeue()}");

            //programa capicua
            bool capicua;
            string numero;
            PilaLista pila = new PilaLista();
            ColaCircular circula_Cola = new ColaCircular();



            try
            {
                capicua = false;
                while (!capicua)
                {
                    do
                    {
                        Console.WriteLine("Tecleea un numero: ");
                        numero = Console.ReadLine();

                    } while (!valido(numero));

                    //pone en la cola y en la pila cada digito 

                    for (int i = 0; i < numero.Length; i++)
                    {
                        Char c;
                        c = numero[i];
                        circula_Cola.insertar(c);
                        pila.insertar(c);



                    }

                    //se retira de la cola y de la pila comparar
                    do
                    {
                        Char d;
                        d = (Char)circula_Cola.quitar();
                        capicua = d.Equals(pila.quitar());



                    } while (capicua && !circula_Cola.colaVacia());
                    if (capicua)
                    {
                        Console.WriteLine($"Numero{numero} es Capicua");
                    }
                    else
                    {
                        Console.WriteLine($"El numero {numero} no es capicua");

                        Console.WriteLine("Ingrese otro numero: ");
                    }
                    //vaciar estructuras

                    circula_Cola.borrarCola();
                    pila.limpiarPila();
                }


            }
            catch (Exception error)
            {
                Console.WriteLine($"Error en {error.Message} ");
            }

        }

        // TAREA 10
        static void tareaStackQueueCapi() {
            
            bool capicua;
            string numero;

            Queue<Object> cola = new Queue<Object>();
            Stack<Object> pila1 = new Stack<Object>();
            
            try
            {
                capicua = false;
                while (!capicua)
                {
                    do
                    {
                        Console.WriteLine(" Tecleea un numero: ");
                        numero = Console.ReadLine();

                    } while (!valido(numero));

                    //pone en la cola y en la pila cada digito 

                    for (int i = 0; i < numero.Length; i++)
                    {
                        Char c;
                        c = numero[i];
                                           
                        cola.Enqueue(c);
                        pila1.Push(c);

                    }
         
                    //se retira de la cola y de la pila comparar
                    do
                    {
                        Char d;

                        d = (Char)cola.Dequeue();
                        capicua = d.Equals(pila1.Pop());


                    } while (capicua && cola.Count !=0);
                    if (capicua)
                    {
                        //foreach (Char caracter in cola) ;
                        Console.WriteLine($"El Numero {numero} es Capicua");
                    }
                    else
                    {
                        Console.WriteLine($"El Numero {numero} NO es capicua");
                        Console.WriteLine();

                        Console.WriteLine("Ingresa otro numero");
                    }
                    //vaciar estructuras

                    cola.Clear();
                    pila1.Clear();
                }

            }
            catch (Exception error)
            {
                Console.WriteLine($"Error en {error.Message} ");
            }
        }
        static void Main(string[] args)
        {

            
            tareaStackQueueCapi();
        }
    }
}