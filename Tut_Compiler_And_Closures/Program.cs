using System;
using System.Collections.Generic;

class Program
{

	class DisplayClass {
	
		public int i;
		public void theMethodGeneratedFromTheLambdaExpression() {
		
			i++;
		
		}
	
	}// class

	static void Main(string[] args)
	{
		Console.WriteLine("Hello World!");

		Action a = GiveMeAction();
		a();
		Action b = GiveMeAction();
		b();
		a();
		a();

	}// main

	static Action GiveMeAction()
	{
		return new Action(new DisplayClass().theMethodGeneratedFromTheLambdaExpression);
	}

}// class