using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizi
{
    public class Array
    {
        public static int[] array(int[] array)
        {

            int x, y;
            int temp;
            for (x = 0; x < array.Length; x++)
            {
                for (y = 0; y < array.Length - 1; y++)
                {
                    if (array[y] > array[y + 1])
                    {
                        temp = array[y];
                        array[y] = array[y + 1];
                        array[y + 1] = temp;

                    }
                }

            }
            return array;
        }
        



    }
}
                 
                        
                    

