using System;

namespace Homework2
{
    class main
    {
        static void Main()
        {
            HelloCSharp prob4 = new HelloCSharp();
            PrintMyName prob5 = new PrintMyName();
            PrintNumbers prob6 = new PrintNumbers();
            PrintNames prob7 = new PrintNames();
            SquareRoute prob8 = new SquareRoute();
            Sequence prob9 = new Sequence();

            prob4.printHello();
            prob5.printName();
            prob6.numbers();
            prob7.printNames();
            prob8.squareRoute();
            prob9.sequence();
        }
    }
}
