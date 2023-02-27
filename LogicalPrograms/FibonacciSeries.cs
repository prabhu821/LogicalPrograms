using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms;

public class FibonacciSeries
{
      public void Print(int num)
        {
        int firstNumber = 0, SecondNumber = 1, nextNumber;
        if (num < 2)
        {
            Console.Write("Please Enter a number greater than two");
        }
        else
        {
            //First print first and second number
            Console.Write(firstNumber + " " + SecondNumber + " ");
            //Starts the loop from 2 because 0 and 1 are already printed
            for (int i = 2; i < num; i++)
            {
                nextNumber = firstNumber + SecondNumber;
                Console.Write(nextNumber + " ");
                firstNumber = SecondNumber;
                SecondNumber = nextNumber;
            }
        }
    }
}
