using System;
using System.Collections.Generic;

class Program
{
	static void Main(string[] args)
	{
		
		Action a = GiveMeAction();
		a(); 
		a(); 
		a();
		
	}// main

	static Action GiveMeAction() {
		
		Action ret = null;
		
		// Lambda Function! Looks like an arrow function.
		int i = 0;
		
		ret += () => { 
		
			Console.WriteLine("First Method " + i++);
		
		};
		ret += () => {

			Console.WriteLine("Second Method " + i++);

		};

		// Return the chain
		return ret;

	}// method

}// class