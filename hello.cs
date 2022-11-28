//to compile: csc .\hello.cs, .\Greeting.cs
using System;

namespace blah
{
	// Returns Name if specified and Hello World in many different language that you specify.
	class Hello 
	{
		static void Main(string[] args)
        {
        	Greeting myInstance;
        	myInstance = new Greeting(args);
        	// myInstance.DisplayGreeting();

        	Greeting myInstance2;
        	myInstance2 = new Greeting(args);
        	// myInstance2.DisplayGreeting();


        	// int a = 5;


        	// Console.WriteLine(a);
        	// Blah2(a);
        	// Blah(ref a);
        	// Console.WriteLine(a);
			
			// Console.WriteLine(myInstance.X);
        	// Blah2(myInstance.X);
        	// Blah(ref myInstance.X);
        	// Console.WriteLine(myInstance.X);

        	Console.WriteLine(myInstance2.X);
        	Blah3(myInstance2);
        	Console.WriteLine(myInstance2.X);

    	}

    	private static void Blah(ref int x)
    	{
    		Console.WriteLine(x);

    		x = 10;
    		Console.WriteLine(x);
    	}

    	private static void Blah2(int x)
    	{
    		Console.WriteLine(x);

    		x = 10;
    		Console.WriteLine(x);
    	}
	    private static void Blah3(Greeting blah)
    	{
    		Console.WriteLine("Blah3");
    		Console.WriteLine(blah.X);

    		blah.X = 10;
    		Console.WriteLine(blah.X);
    	}
	}
}