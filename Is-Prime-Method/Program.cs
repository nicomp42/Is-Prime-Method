//*******************************************************************************
// A method to check an integer for primeness and a Main method to exercise it  *
// Bill Nicholson                                                               *
// nicholdw@ucmail.uc.edu                                                       *
// IS3050-001 Spring 2024                                                       *
// https://github.com/nicomp42/Is-Prime                                         *
//*******************************************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Is_Prime_Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsPrime(42));
            Console.WriteLine(IsPrime(3));
            Console.WriteLine(IsPrime(101));
        }
        static Boolean IsPrime(int num)
        {
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
