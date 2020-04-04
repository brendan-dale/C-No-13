using System;

namespace fizzbuzz
{

class MainClass {
  public static void Main () {
    
    
  Console.WriteLine("Enter a number: ");
  int userInput = Convert.ToInt32(Console.ReadLine());
  Console.WriteLine("Result of Math.cs operations:");
  Console.WriteLine(Math.addMethod(userInput));
  Console.WriteLine(Math.multiplyMethod(userInput));
  Console.WriteLine(Math.subtractMethod(userInput));
  
  }
}

}