using System;
using System.Collections.Generic;

class Program
{

	static bool EquivalentLambdaExpression(int i) { 
		return i > 5;
	}// method

	static void Main(string[] args)
	{
		// new generic function that takes an int and returns a bool. Evaluates a lambda expression returning boolean if i > 5
		Func<int, bool> func = i => i > 5;

		// Anonymous method
		Func<int, bool> func2 = delegate(int i) { return i > 5; };

		// Pass in params
		Console.WriteLine(func(3));
		Console.WriteLine(func(7));

	}// main

}// class