using System;
namespace Homework2
{
    class Sequence
    {
        public void sequence()
        {
            for (int i = 2; i < 12; i++) {
                if (i % 2 != 0) {
                    Console.Write(i - i * 2 + " ");
                } else {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
