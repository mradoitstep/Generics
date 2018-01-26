using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class GenericSmallStack<T> //zadany T 
    {
        private T[] pole = new T[10];
        private int index = 0; //index ktory ukazuje na vrch zasobniku

        public void Push(T obj)
        {
            // index je na konci pola a preto sa uz neda prijat dalsia polozka 
            if (index == pole.Length - 1)
            {
                throw new IndexOutOfRangeException();  // vykopnutie 
            }
            pole[index] = obj;
            index++;


        }
        public T Pop()
        {
            if (index - 1 < 0)
            {

                throw new IndexOutOfRangeException();  // vykopnutie 
            }
            return pole[index--];
        }
}
