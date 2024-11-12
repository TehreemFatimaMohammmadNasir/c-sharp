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
       
        string vegetable = "close";   
        string meatshop = "close";  
        string supermart = "open";   

  
        if (vegetable == "open")
        {
            Console.WriteLine("Buy vegetable");
        }
        else
        {
            
            if (meatshop == "open")
            {
                Console.WriteLine("Buy meat");
            }
            else
            {
               
                Console.WriteLine("No vegetables and meat are available, go to mart");

              
                if (supermart == "open")
                {
                    Console.WriteLine("Go to mart");

                  
                    int bill = 17000; 
                   
                    if (bill >17000)
                    {
                        Console.WriteLine("Pay all payment from card except 5000");
                    }
                    else if (bill < 17000)
                    {
                        Console.WriteLine("pay 50% from card and 50% from cash");
                    }
                    else if (bill == 50000)
                    {
                       
                        int discount = bill * 75 / 100; 
                     
                        Console.WriteLine("The bill is 50000" + discount);
                    }
                    else
                    {
                        Console.WriteLine("Pay the full bill of " + bill);
                    }
                }
            }
        }
    }
}