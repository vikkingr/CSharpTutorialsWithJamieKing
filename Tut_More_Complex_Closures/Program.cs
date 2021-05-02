using System;
using System.Collections.Generic;

class Program
{
	static void Main(string[] args)
	{
		Console.WriteLine("Hello World!");

	}// main

	class Displayaodi {
	
		int i = 5;

		public void myMethod1() {
			i++;
		}// method
		public void myMethod2() { 
			i+= 2;
		}// method
			
	}// class

	static Action GiveMeAction() { 
	
		Action ret = null;

		var temp = new Displayaodi();
		int j = 0;
		int k = 0;
		ret += temp.myMethod1;
		ret += temp.myMethod2;

		// Use a lambda expression to increment
		ret += () => { j++; k++; };

		return ret;
	
	}// method

}// class