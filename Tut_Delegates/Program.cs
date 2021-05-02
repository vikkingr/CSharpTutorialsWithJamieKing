using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Create Delegate
delegate void MeDelegate();

delegate Boolean MeDel1(int n);

    class Program
    {
        static void Main(string[] args)
        {
            
            ////////////////////////////////////////////////////////////////////////////////////    
        
            // Instantiate a delegate. Pass in method WITHOUT parentheses "()", references Foo()
            MeDelegate myDel1 = new MeDelegate(Foo);

            // Make a call to the delegate WITH parentheses "()"
            myDel1();

            // Syntax sugar, use: delegate.Invoke(). == delegate();
            myDel1.Invoke();

            // Instantiate delegate with different syntax, reference Foo()
            MeDelegate myDel2 = Foo;

            // Call most recent delegate
            myDel2();

            // Call the custom delegate invoking method
            InvokeTheDelegate(myDel1);

            // Call the custom delegate invoking method, pass in methods directly!
            InvokeTheDelegate(Goo);
            InvokeTheDelegate(Hoo);

            ////////////////////////////////////////////////////////////////////////////////////

            int[] numbers = new[] { 2, 7, 3, 9, 5, 7, 1, 8 };

            // Instantiate the IEnumerable object
            IEnumerable<int> result = RunNumbersThroughGauntlet(numbers, LessThanTen);

            // Print all of the proper numbers.
            foreach (int n in result) {
                
                Console.WriteLine(n);
            
            }// end foreach

    }// end main

    // another method
    static bool LessThanFive (int n) {
        
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
    static IEnumerable<int> RunNumbersThroughGauntlet(IEnumerable<int> numbers, MeDel1 gauntlet) {

        foreach (int number in numbers) {

            if (gauntlet(number)) {
            
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
