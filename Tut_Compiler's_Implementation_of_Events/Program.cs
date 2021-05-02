using System;

namespace Tut_Compiler_s_Implementation_of_Events
{
	class Cow {

		public event Action Mooing;
	
	}// Cow

	class Program {

		public static void main(string[] args) {
		
			Cow c = new Cow();
			
			// Notice it is now a lightning bolt in the pop up menu. It is now an event, can't directly call it!
			// UNCOMMENT BELOW
			//c.Mooing();

		// main
	
	}// class

}// namespace
