using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc_GPA_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {        
            double totalGrade = 0;
            //string get name
            Console.WriteLine("Please enter the Student Name: ");
            string studentName = Console.ReadLine();
            for (int i = 1; i <= 5; i++)
            {
            //asked for 5 grades (letter grades) inside the loop so it asks 5x
                Console.WriteLine("Please enter a letter grade:");
                string letterGrade = Console.ReadLine();
                switch (letterGrade)
                //inside that, a switch case
                {
                    case "A":
                        {
                            totalGrade = totalGrade + 4;
                            break;
                        }
                    case "B":
                        {
                            totalGrade = totalGrade + 3;
                            break;
                        }
                    case "C":
                        {
                            totalGrade = totalGrade + 2;
                            break;
                        }
                    case "D":
                        {
                            totalGrade = totalGrade + 1;
                            break;
                        }
                    case "F":
                        {
                            totalGrade = totalGrade + 0;
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Invalid");
                            break;
                        }
                }
            }
            double gpa = (totalGrade / 5);//finds the average of the 5 inputs
            Console.WriteLine("Student Name: " + studentName);
            Console.WriteLine("GPA: " + gpa);
            Console.ReadLine();
        }
    }
}

