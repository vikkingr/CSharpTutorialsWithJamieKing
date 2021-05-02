using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

/*
 * Build from Tut_Delegates
 * 
 * Practicing with lambda expressions
 * 
 */

// Create Delegate
delegate void MeDelegate();

delegate Boolean MeDel1(int n);

class Program
{
    static void Main(string[] args)
    {

        ////////////////////////////////////////////////////////////////////////////////////

        int[] numbers = new[] { 2, 7, 3, 9, 5, 17, 1, 8, 13 };

        Console.WriteLine("Less than 10");

        // Instantiate the IEnumerable object, pass in a lambda expression
        IEnumerable<int> result = RunNumbersThroughGauntlet(numbers, n => n < 10);

        // Print all of the proper numbers.
        foreach (int n in result)
        {

            Console.WriteLine(n);

        }// end foreach

        Console.WriteLine("Greater than 10");

        // reset result to include numbers greater than 10
        result = RunNumbersThroughGauntlet(numbers, n => n > 10);

        // Print all of the proper numbers.
        foreach (int n in result)
        {

            Console.WriteLine(n);

        }// end foreach

        Console.WriteLine("Less than 5");

        // finally, only include numbers less than five
        result = RunNumbersThroughGauntlet(numbers, n => n < 5);

        // Print all of the proper numbers.
        foreach (int n in result)
        {

            Console.WriteLine(n);

        }// end foreach

    }// end main

    // another method
    static bool LessThanFive(int n)
    {
        return n < 5;
    }
    // another method
    static bool LessThanTen(int n)
    {
        return n < 10;
    }
    // another method
    static bool GreaterThanThirteen(int n)
    {
        return n > 13;
    }

    // Returns numbers less than anything
    static IEnumerable<int> RunNumbersThroughGauntlet(IEnumerable<int> numbers, MeDel1 gauntlet)
    {

        foreach (int number in numbers)
        {

            if (gauntlet(number))
            {

                yield return number;

            }

        }

    }// 

    // Method that invokes the passed delegate;
    static void InvokeTheDelegate(MeDelegate del)
    {

        Console.WriteLine("InvokeTheDelegate executed.");
        del();

    }

    // Demonstration method, void.
    static void Foo()
    {

        Console.WriteLine("Foo()");

    }// end foo

    // Demonstration method, void.
    static void Goo()
    {

        Console.WriteLine("Goo()");

    }// end goo

    // Demonstration method, void.
    static void Hoo()
    {

        Console.WriteLine("Hoo()");

    }// end hoo

}// end class
