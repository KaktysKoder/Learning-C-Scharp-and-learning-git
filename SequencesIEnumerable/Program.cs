using System;

namespace SetTypes
{
    internal class Program
    {
        private static void Main()
        {
            SequencesIEnumerableTest();

            Console.ReadLine();
        }

        private static void SequencesIEnumerableTest()
        {
            Progression progression = new Progression(100);

            foreach (int i in progression)
            {
                  //Console.Write($"{i} ");
                Console.WriteLine($"{i} ");
            }
        }
    }
}
