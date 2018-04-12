using System;

class Grade
{
  static void Main()
  {
    Console.WriteLine("What grade did you receive (A, B, C, D or F): ");
    char inputGrade = Console.ReadLine()[0];
    if (inputGrade == 'A' || inputGrade == 'B')
    {
      Console.WriteLine("You are an excellent student!");
    } else if (inputGrade == 'C')
    {
      Console.WriteLine("Keep trying; you'll get there.");
    } else 
    {
      Console. WriteLine("It would appear you're not even trying!");
    }
  }
}