using System;

namespace lesson_1
{
    class Program
    {
        static void Main(string[] args)
        {

            Random rnd = new Random(); //запуск рандомайзера

            int[] array = new int[100];
            int[] arraytemp = new int[array.Length];

            //заполняем массив
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(1, 200);
                arraytemp[i] = array[i];
                //Console.WriteLine(array[i]);
            }

            
            // сортировка
            int temp;
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        
                        temp = array[i];

                        array[i] = array[j];

                        array[j] = temp;

                    }
                }
            }

            // вывод
            Console.WriteLine("Вывод отсортированного массива");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(arraytemp[i] + "  после сортировки   " + array[i]);
            }

        }
    }
}
