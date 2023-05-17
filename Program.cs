using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    namespace probability
    {
        public class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("enter  the number of elements : ");
                int size = int.Parse(Console.ReadLine());

                float[] array = new float[size];
                for (int i = 0; i < size; i++)
                {
                    Console.WriteLine("enter the value of (" + (i + 1) + ")");
                    array[i] = float.Parse(Console.ReadLine());
                }
                Array.Sort(array);
                for (int i = 0; i < size; i++)
                {
                    Console.WriteLine("(" + (i + 1) + ")=" + array[i], (i + 1));
                }


                float median;
                if (size % 2 != 0)
                {
                    median = array[(size / 2)];
                    Console.WriteLine("The Median=" + median);
                }
                else
                {
                    median = array[(size / 2) - 1] + array[(size / 2)];
                    Console.WriteLine("The Median  = " + (median / 2));
                }
                float range;
                float max = array[0];
                float min = array[0];
                for (int i = 0; i < size; i++)
                {
                    if (max < array[i])
                    {
                        max = array[i];
                    }
                    if (min > array[0])
                    {
                        min = array[i];
                    }
                }
                range = max - min;
                Console.WriteLine("The range = " + range);


                float firstQuartile;
                firstQuartile = array[(size) / 4];
                Console.WriteLine("The first QUARTILE = " + firstQuartile);

                float thirdQuartile;
                thirdQuartile = array[3 * (size) / 4];
                Console.WriteLine("The third QUARTILE = " + thirdQuartile);

                float p90 = (((size + 1) * 90) / 100);
                Console.WriteLine("The p90 of the value= " + p90);

                float interquartile = thirdQuartile - firstQuartile;
                Console.WriteLine("The interquartile= " + interquartile);


                double lower;
                double upper;

                lower = firstQuartile - 1.5 * interquartile;
                Console.WriteLine("The lower outlier boundary = " + lower);

                upper = thirdQuartile + 1.5 * interquartile;
                Console.WriteLine("The lower outlier boundary = " + upper);


                float value;
                Console.WriteLine("enter the value = ");
                value = float.Parse(Console.ReadLine());
                if (lower <= value & value <= upper)
                {
                    Console.WriteLine("The value {0} is not outlier ", value);

                }
                else
                {
                    Console.WriteLine("The value {0} is outlier ", value);
                }



            }
        }
    }

