using System;
using System.Collections.Generic;
using Methods;


namespace Game
{

  public class PingPong 
  {
    public static void Main()
    {
      Console.WriteLine("please enter a number to play ping pong");
      string stringNumber = Console.ReadLine();
      int userNumber = int.Parse(stringNumber);
      List<int> numberList = new List<int> {};
      List<string> stringList = new List<string> {};
      for(int index = 1; index <= userNumber; index++)
      {
        numberList.Add(index);
      }
      foreach (int count in numberList)
      {
        if (Substitutions.DivisibleByBoth(count))
        {
          stringList.Add("ping-pong");
        }
        else if (Substitutions.DivisibleByFive(count))
        {
          stringList.Add("pong");
        }
        else if (Substitutions.DivisableByThree(count))
        {
          stringList.Add("ping");
        }
        else
        {
          stringList.Add(count.ToString());
        }
        
      }
      foreach (string count in stringList)
      Console.WriteLine(count);
    }
  }
}
