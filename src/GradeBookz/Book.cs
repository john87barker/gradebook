using System.Collections.Generic;

namespace GradeBookz
{
  class Book{
    public Book(string name)
    {
      grades = new List<double>();
      this.name = name;
    }

    private List<double> grades;
    private string name;


    public void AddGrade(double grade)
    {
      grades.Add(grade);
    }

    public void ShowStatistics()
    {
      
      var result = 0.0;
      var highGrade = double.MinValue;
      var lowGrade = double.MaxValue;
      foreach (double number in grades)
      {
        highGrade = Math.Max(number, highGrade);
        lowGrade = Math.Min(number, lowGrade);
        result += number;        
      }
      result /= grades.Count;
       Console.WriteLine($"{name} - - - Your average points are {result:N2}. Your Highest score is {highGrade} and your lowest score is {lowGrade}. ");
    }
  }
}