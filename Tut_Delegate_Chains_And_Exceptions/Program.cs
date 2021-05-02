using System;
using System.Collections.Generic;

class Program
{
	static void Main(string[] args)
	{
		Console.WriteLine("Hello World!");

		Action del = (Action)Moo + BeNaughty + Goo;
		foreach (Action a in del.GetInvocationList()) {

			try { 
			
				a();
			
			} catch {
			
				// An empty catch just swallows an exception		

			}

		}
		
	}// main

	static void Moo() { Console.WriteLine("Moo()"); }
	static void BeNaughty() { throw new Exception(); }
	static void Goo() { Console.WriteLine("Goo()"); }

}// class