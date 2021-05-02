using System;
using System.Diagnostics;

namespace Tut_Compiler_s_Implementation_of_Events
{
	class Cow
	{

		private Action mooing;

		// The event keyword adds "add" and "remove" methods
		public event Action Mooing {

			add
			{
				// This is done behind the scenes
				mooing += value;
			}
			remove
			{
				mooing -= value;
			}

		}// event

		public void PushSleepingCow()
		{

			// Ensure there are subscribers
			if (mooing != null) {
				mooing();
			}// if

		}// method

	}// Cow

	class Program
	{

		public static void Main(string[] args)
		{

			Cow c = new Cow();

			c.Mooing += () => Console.WriteLine("The cow moved!");

			c.PushSleepingCow();

		}// main

	}// class

}// namespace