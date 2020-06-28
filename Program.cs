using System;

namespace SetTypes
{
    class Program
    {
        static void Main()
        {
            Progression progression = new Progression(100);

            foreach(int i in progression)
            {
                  //Console.Write($"{i} ");
                Console.WriteLine($"{i} ");
            }

            Console.ReadLine();
        }
    }
}
