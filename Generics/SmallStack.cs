using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class SmallStack
    {
        private int[] pole = new int[10];
        private int index = 0; //index ktory ukazuje na vrch zasobniku

        public void Push(int cislo)
        {
            // index je na konci pola a preto sa uz neda prijat dalsia polozka 
            if (index == pole.Length - 1)
            {
                throw new IndexOutOfRangeException();  // vykopnutie 
            }
            pole[index] = cislo;
            index++;


        }
        public int Pop()
        {
            if(index -1 < 0)
            {

                throw new IndexOutOfRangeException();  // vykopnutie 
            }
            return pole[index--];
            
        }
    }
}
