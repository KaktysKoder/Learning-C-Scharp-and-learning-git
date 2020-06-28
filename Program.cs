using System;

namespace SetTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Progression progression = new Progression(100);

            foreach(int i in progression)
            {
                Console.Write($"{i} ");
            }

            Console.ReadLine();
        }
    }
}
