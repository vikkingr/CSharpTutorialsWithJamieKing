using System;
using System.Collections.Generic;

/*
* Delegate Chaining! 
* Woohoo!
*/

// Create a new delegate
delegate void MeDelegate();

class Program
{
	static void Main(string[] args)
	{
		
		/*
		d references a chain of delegates, foo, goo, sue
		*/
		
		MeDelegate d = Foo;

		// Add another delegate to create a chain of delegates
		d = (MeDelegate)Delegate.Combine(d, new MeDelegate(Goo));

		// Do the same thing as above but simpler syntax.
		d += Sue;
		d += Foo;

		// Very last Foo is removed.
		d -= Foo;

		// Get list of delegates
		foreach (MeDelegate m in d.GetInvocationList()) { Console.WriteLine(m.Target + ": " + m.Method); }

		// Invoke the delegate!
		d();

	}// main

	// Some methods
	static void Foo() { Console.WriteLine("Foo()!"); }
	static void Goo() { Console.WriteLine("Goo()!"); }
	static void Sue() { Console.WriteLine("Sue()!"); }

}// class