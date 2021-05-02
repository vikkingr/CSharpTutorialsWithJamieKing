using System;
using System.Collections.Generic;

/*
Using Func and Action
*/

// Instead of explicitly declaring a generic delegate, let's use Func
// delegate T MeDelegate<T>();


class Program
{
	static void Main(string[] args)
	{
		// Delegate -> MulticastDelegate -> MeDelegate

		Func<int> d = ReturnFive;
		d += ReturnTen;
		d += Return22;
		d += Return88;

		/*
		Generic funcitons with the Func keyword, up to 16 params, last param is always return type.
		Use this when there is a return value!
		*/

		// Param/Arg is an int and a string, return is a bool
		Func<int, string, bool> f = TakeAnIntAndAStringAndReturnABool;

		// Get list
		foreach (int i in GetAllReturnValues(d)) {
			Console.WriteLine(i);
		}

		/*
		Generic functions with Action keyword, up to 16 params, NO RETURN VALUES EVER (VOID)!
		*/

		Action<string> a = TakeAStringAndReturnVoid;

		f(1, "lol1");
		a("lol2");

	}// main

	static void TakeAStringAndReturnVoid(string s) {
	
		Console.WriteLine("Action says: " + s);

	}// 

	static bool TakeAnIntAndAStringAndReturnABool(int i, string s) {
	
		Console.WriteLine("Func: " + i + ", " + s + ", " + false);
		return false;
	
	}

	static IEnumerable<TArg> GetAllReturnValues<TArg>(Func<TArg> d)
	{

		List<int> ints = new List<int>();

		foreach (Func<TArg> del in d.GetInvocationList())
			yield return del();

	}// getall

	static int ReturnFive() { return 5; }
	static int ReturnTen() { return 10; }
	static int Return22() { return 22; }
	static int Return88() { return 88; }

}// class