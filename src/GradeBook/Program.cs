// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;


namespace GradeBook
{

  class Program
  {
    static void Main(string[] args)
    {
      var book = new Book("John's Gradebook");
      book.AddGrade(89.3);
      book.AddGrade(100);
      book.AddGrade(81);
      book.AddGrade(88);
      var stats = book.GetStatistics();
      Console.WriteLine($"Your average points are {stats.Average:N2}. Your Highest score is {stats.High} and your lowest score is {stats.Low}. ");

    }
  }
}


 