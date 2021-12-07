using System;
using System.Collections.Generic;

public class Program
{

static void Main(){
  Console.WriteLine("Enter a number to play Ping Pong: ");
  string stringinputtedNumber = Console.ReadLine();
  int inputtedNumber = int.Parse(stringinputtedNumber);

  for(int index=1; index <=inputtedNumber; index++)
  {
    if (index%3 == 0 && index%5 == 0)
    {
      Console.WriteLine("ping-pong");
    }
    else if (index%3 == 0)
    {
      Console.WriteLine("ping");
    }
    else if (index%5 == 0)
    {
      Console.WriteLine("pong");
    }
    else
    {
      Console.WriteLine(index);
    }
  }
}
}














/*class Number
{
  static void Main()
  {
    int[] array = { 1, 3, 5, 7, 9 };
    Console.WriteLine(array : + string.Join);
  }
}
/*public class Number
{
  static void Main()
  {
  Console.WriteLine("lets play ping pong! Enter a number to get started: ");
  int[] pingPong = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 ,15}; 
  {
  return pingPong;
  }

 

  }
}*/

/*class Number
{
  static void Main()
  {
    /*Console.WriteLine("Enter a number to play pong");
    string pingPong = Console.ReadLine();
    int enteredNumber = int.Parse(pingPong);
    int[] numberArray = new int[enteredNumber];
    Console.WriteLine(numberArray);
    

    //Console.WriteLine(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 ,15);
    //for (int num = enteredNumber; num )
  }*/

  
  
    
//}








// foreach loop
// Console.ReadLine/
//Use system 
//  import statements 
// ping pong class
// 