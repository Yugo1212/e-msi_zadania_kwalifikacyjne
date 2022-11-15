using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskForInterview
{
    public class Exercise2
    {
        //Napisz metodę która dla podanej liczby X znajdzie sumę wszystkich liczb naturalnych
        //mniejszych od niej, które są wielokrotnością liczb 3 lub 5.
        //Np. dla x = 10, wszystkie wielokrotności to 3, 5, 6 i 9, a ich suma wynosi 23.

        public int FindSumOfNumbersThatAreDivisibleBy3Or5(int number)
        {
            var sum = 0;

            if (number <= 0)
                throw new ArgumentOutOfRangeException("Number must be more than 0");

            for (var i = 0; i < number; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                    sum += i;
            }

            return sum;
        }
    }
}
