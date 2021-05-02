using System;
using System.Collections.Generic;

/*
* The event keyword stops me from directly invoking a delegate.
* It also stops me from assigning to it directly.
* Meaning, no myDelegate = null; allowed.
* 
* This has a further meaning.
* The subscribers to this event cannot be unsubscribed like so.
* 
* An event is a delegate reference that prohibits directly invoking delegate references
* AND
* assigning to the delegate references.
*/



class TrainSignal
{
	
	// add "event" before action to make it an event
	public Action TrainsAComing;
	public void HereComesATrain()
	{
		// imagine a ton of logic here

		// check if anyone is subscribed to this action
		if (TrainsAComing != null) { 
		
			TrainsAComing.Invoke();
		
		}// if

	}// method

}// class

class Car
{

	public Car(TrainSignal trainSignal)
	{

		trainSignal.TrainsAComing += StopTheCar;

		void StopTheCar()
		{

			Console.WriteLine("SCREEEEETCH");

		}// method

	}// constructor

}// class

class Program
{
	static void Main(string[] args)
	{
		Console.WriteLine("Hello World!");

		TrainSignal trainSignal = new TrainSignal();
		new Car(trainSignal);
		new Car(trainSignal);
		new Car(trainSignal);
		new Car(trainSignal);
		new Car(trainSignal);

		trainSignal.HereComesATrain();

		// access delegate directly
		trainSignal.TrainsAComing();
		trainSignal.TrainsAComing();
		trainSignal.TrainsAComing();
		trainSignal.TrainsAComing();

		// now to do something bad, the trainsignal is now broken
		trainSignal.TrainsAComing = null;

		// later on... The real train comes and no one knows!
		trainSignal.HereComesATrain();

	}// main

}// class