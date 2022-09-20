using System.Collections.Generic;

namespace GradeBook
{
 class Book
 {
     public Book(string name)
     {
         grades = new List<double>();
         this.name = name;
     }
     public void AddGrade(double grade) 
     {
         grades.Add(grade);
     } 
     
     public void ShowStats()
     {
       //  var grades = new List<double> () {12.7, 10.3, 6.11, 4.1}; // creating a list
         //   grades.Add(56.1); // adds a new grade to the list

            var results = 0.0;
            var highGrade = double.MinValue;
            var lowGrade = double.MaxValue;
            foreach(var number in grades)
            {
                highGrade = Math.Max(number, highGrade);
                lowGrade = Math.Min(number, lowGrade); 

             /* if(number < lowGrade){
                  lowGrade = number;
                 } 
                
                if(number > highGrade){
                     highGrade = number;
                 }*/
            }
            results = grades.Average();
            //result += number; -- This is another example to get the average by adding all the numbers back into result and then dividing
            //results /= grades.Count; -- grades.Count gives you the number within the list grades
            Console.WriteLine($"The highest grade is {highGrade} and the lowest grade is {lowGrade}");
            System.Console.WriteLine($"The average of your total is {results:N1} this result comes from {grades.Count} different grades");
            System.Console.WriteLine($"The average grade is {results:N3}");

     }
    private List<double> grades;
    private string name;
 }   
}