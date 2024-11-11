/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/
using System;

class HelloWorld
{
	static void Main()
	{
		Console.WriteLine("Hello World");

		int number1=Convert.ToInt32(Console.ReadLine());
		int number2=Convert.ToInt32(Console.ReadLine());
		int add,sub,multiply,divide,reminder,average,square1,square2;

		add = number1+number2;
		sub = number1-number2;
		multiply = number1*number2;
		divide = number1/number2;
		reminder = number1%number2;
		average = number1+number2 /2;
		square1 = number1*number1;
		square2 = number2*number2;
		Console.WriteLine("add");
		Console.WriteLine("sub");
		Console.WriteLine("multiply");
		Console.WriteLine("divide");
		Console.WriteLine("reminder");
		Console.WriteLine("average");
		Console.WriteLine("square1");
		Console.WriteLine("square2");
			




	}
}
