using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sortingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            Random random = new Random();
            int swapOne, swapTwo;

            for (int i = 0; i < 6; i++)
            {
                list.Add(random.Next(0, 100));
            }

            Console.WriteLine("Swap the numbers in the list until they're in asceding numerical order.");

            while (true)
            {
                swapOne = -1;
                swapTwo = -1;

                WriteOulist(list);

                while (list.Contains(swapOne) == false)
                {
                    Console.WriteLine("what's the first number you want to swap?");
                    swapOne = Convert.ToInt32(Console.ReadLine());
                }

                while (list.Contains(swapTwo) == false || swapTwo == swapOne)
                {
                    Console.WriteLine("what's the second number you want to swap?");
                    swapTwo = Convert.ToInt32(Console.ReadLine());
                }

                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i] == swapOne)
                        list[i] = swapTwo;

                    else if (list[i] == swapTwo)
                        list[i] = swapOne;
                }

                List<int> sortedList = new List<int>(list);
                sortedList.Sort();

                if (list.SequenceEqual(sortedList) == true)
                {
                    WriteOulist(list);
                    Console.WriteLine("You Win!");
                    break;
                }
            }

            Console.ReadLine();
        }

        static void WriteOulist(List<int> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i] + ",");
            }

            Console.WriteLine();
        }
    }
}
