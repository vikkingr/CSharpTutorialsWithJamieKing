using System;

namespace Tut_EventHandler_And_Sender
{
	class Cow
	{
		
		public string Name 
		{ 

			get;
			set;

		}

		public event EventHandler Moo;

		public void BeTippedOver()
		{

			if (Moo != null) { 
				Moo(this, EventArgs.Empty);
			}// if
		
		}// ()
	
	}// cow

	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");

			Cow c1 = new Cow { Name = "Betsy" };

			// subscribe c1 to the event
			c1.Moo += giggle;

			Cow c2 = new Cow { Name = "Georgy" };

			// subscribe c2 to the event
			c2.Moo += giggle;

			Cow victim = new Random().Next() % 2 == 0? c1 : c2;

			victim.BeTippedOver();

		}// main

		static void giggle(object sender, EventArgs e) { 
		
			Cow c = sender as Cow;
			Console.WriteLine("Giggle giggle... we made " + c.Name + " moo!");
		
		}// giggle
	}
}
