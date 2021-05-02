using System;

namespace Tut_EventArgs
{

	public enum CowState
	{ 
		Awake,
		Sleeping,
		Dead
	}

	// this class inherits from EventArgs hence the class : inheritClass syntax
	class CowTippedEventArgs : EventArgs
	{

		//
		public CowState CurrentCowState { get; private set; }

		// constructor
		public CowTippedEventArgs(CowState currentState)
		{
			CurrentCowState = currentState;
		}

	}

	class Cow
	{

		public string Name
		{

			get;
			set;

		}

		// Using a genering event handler
		public event EventHandler<CowTippedEventArgs> Moo;

		public void BeTippedOver()
		{

			// logic of cow
			if (Moo != null)
			{

				// pass in the sender (the current object hence "this") and the correct event argument
				Moo(this, new CowTippedEventArgs(CowState.Awake));

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

			Cow victim = new Random().Next() % 2 == 0 ? c1 : c2;

			victim.BeTippedOver();

		}// main

		static void giggle(object sender, CowTippedEventArgs e)
		{

			Cow c = sender as Cow;
			Console.WriteLine("Giggle giggle... we made " + c.Name + " moo!");

			switch(e.CurrentCowState)
			{
				case CowState.Awake:
					Console.WriteLine("Run!");
					break;
				case CowState.Sleeping:
					Console.WriteLine("Tickle it!");
					break;
				case CowState.Dead:
					Console.WriteLine("Butcher it.");
					break;
			}// switch

		}// giggle

	}// class

}// namespace