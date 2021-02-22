using System;
using System.Collections.Generic;
using Game;

namespace Methods
{
  public class Substitutions
  {
    public static bool DivisableByThree(int number)
    {
      return (number % 3 == 0);
    }
    public static bool DivisibleByFive(int number)
    {
      return (number % 5 == 0);
    }
    public static bool DivisibleByBoth(int number)
    {
      return (number % 3 == 0 && number % 5 == 0);
    }
  }
}