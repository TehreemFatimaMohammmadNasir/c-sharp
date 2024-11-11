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
        
        int product1 = 500;
        int product2 = 1500;
        int product3 = 3000;
        int product4 = 660;
        int product5 = 2000;

       
        int totalPrice = product1 + product2 + product3 + product4 + product5;

       
        if (totalPrice > 5000)
        {
            int discount = totalPrice * 5 / 100;
       Console.WriteLine("Discount applied");

        }
    }
}
