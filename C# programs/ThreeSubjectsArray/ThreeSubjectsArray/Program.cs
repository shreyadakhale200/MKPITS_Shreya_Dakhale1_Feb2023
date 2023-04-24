//create a method to accept 3 subject marks and store it in an array and then print total,per and grade

using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeSubjectsArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] subject_marks = new int[3];
            for(int i=0; i<subject_marks.Length; i++)
            {
                Console.WriteLine("Enter marks : ");
                subject_marks[i] = Convert.ToInt32(Console.ReadLine());
            }
            for(int i=0;i<subject_marks.Length;i++)
            {
                Console.Write(subject_marks[i] + " ");
            }
            //total, percent, grade
            int total = 0;
            foreach(int totalofMarks in subject_marks)
            {
                total = total + totalofMarks;
            }
            Console.WriteLine("\nTotal is : " + total);
            float percent = (total / 300f) * 100f;
            Console.WriteLine("Percentage is : " + percent + "%");
            string Grade = GradeOfPercent(percent);
            Console.WriteLine("Grade is : " +  Grade);
            Console.ReadKey();
        }
        static string GradeOfPercent(float Percent)
        {
            string grade;
            if (Percent > 90)
            {
                grade = "A";
                Console.WriteLine(grade);
            }
            else if (Percent > 80 && Percent < 90)
            {
                grade = "B";
                Console.WriteLine(grade);
            }
            else if (Percent > 70 && Percent < 80)
            {
                grade = "C";
            }
            else
            {
                grade = "You Failed";
            }
            return grade;
        }
    }
}
