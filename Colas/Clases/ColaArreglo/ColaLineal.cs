using System;
using System.Collections.Generic;
using System.Text;

namespace Colas.Clases.ColaArreglo
{
    class ColaLineal
    {
        protected int fin;
        private static int MAXTAMQ = 39;
        protected int frente;

        protected Object[] listaCola;

        public ColaLineal() {
            frente = 0;
            fin = -1;
            listaCola = new object[MAXTAMQ];
        
        }

        public bool colaVacia() {
            return frente > fin;
        }

        public bool colaLLena() {
            return fin == MAXTAMQ - 1;    
        }

        //operaciones oara trabajr con datos en la cola
        public void insertar(Object elemento) {
            if (!colaLLena())
            {

                listaCola[++fin] = elemento;
            }
            else {
                throw new Exception("Overflow de la Cola");            
            }
        }

        //quitar elemento de la cola
        public Object quitar() {
            if (!colaVacia())
            {
                return listaCola[frente++];
            }
            else {
                throw new Exception("Cola Vacia");
            
            }
        }

        //Limpiar la Cola 
        public void borrarCola() {
            frente = 0;
            fin = -1;
        }

        //Acceder al valor de frente de la cola
        public Object frenteCola() {
            if (!colaVacia())
            {
                return listaCola[frente];
            }
            else {
                throw new Exception("cola Vacia");
            }
        }

    }//fin class
}
