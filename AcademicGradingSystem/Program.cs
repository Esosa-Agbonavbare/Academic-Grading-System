using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademicGradingSystem
{
    public class Program
    {
        static void Main(string[] args)
        {
            int currentAssignment = 10;

            int[] fionaScores = { 90, 86, 87, 98, 100, 94, 90, 90, 88, 76, 97, 99 };
            int[] peterScores = { 92, 89, 81, 96, 90, 89, 67, 90, 86, 99, 88, 90 };
            int[] elliotScores = { 90, 85, 87, 98, 68, 89, 89, 89, 100, 90, 99, 90 };
            int[] sashaScores = { 90, 95, 87, 88, 96, 96, 77, 82, 90, 77, 89, 88 };
            int[] ollieScores = { 90, 55, 68, 91, 50, 89, 66, 70, 83, 86, 90, 99 };

            string[] studentNames = { "Fiona", "Peter", "Elliot", "Sasha", "Ollie" };

            int[] studentScores = new int[12];

            Console.WriteLine($"Student\t\tExam Score\tOverall\tGrade\tExtra Credit\n");

            foreach (string student in studentNames)
            {
                if (student == "Fiona")
                {
                    studentScores = fionaScores;
                }
                else if (student == "Peter")
                {
                    studentScores = peterScores;
                }
                else if (student == "Elliot")
                {
                    studentScores = elliotScores;
                }
                else if (student == "Sasha")
                {
                    studentScores = sashaScores;
                }
                else if (student == "Ollie")
                {
                    studentScores = ollieScores;
                }

                int examScore = 0;
                decimal creditScore = 0;
                int totalExamSum = 0;
                int totalCreditSum = 0;
                int creditAverage = 0;
                decimal overallScore = 0;

                int examScoreCounter = 0;

                foreach (int score in studentScores)
                {
                    examScoreCounter++;
                    if (examScoreCounter <= currentAssignment)
                    {
                        totalExamSum += score;
                    }
                    else
                    {
                        totalCreditSum += score;
                    }
                }
                examScore = totalExamSum / currentAssignment;

                creditAverage = totalCreditSum / currentAssignment;

                creditScore = ((decimal)totalCreditSum * 0.1m) / currentAssignment;

                overallScore = examScore + creditScore;

                string currentStudentLetterGrade = "";

                if (overallScore >= 97)
                    currentStudentLetterGrade = "A+";

                else if (overallScore >= 93)
                    currentStudentLetterGrade = "A";

                else if (overallScore >= 90)
                    currentStudentLetterGrade = "A-";

                else if (overallScore >= 87)
                    currentStudentLetterGrade = "B+";

                else if (overallScore >= 83)
                    currentStudentLetterGrade = "B";

                else if (overallScore >= 80)
                    currentStudentLetterGrade = "B-";

                else if (overallScore >= 77)
                    currentStudentLetterGrade = "C+";

                else if (overallScore >= 73)
                    currentStudentLetterGrade = "C";

                else if (overallScore >= 70)
                    currentStudentLetterGrade = "C-";

                else if (overallScore >= 67)
                    currentStudentLetterGrade = "D+";

                else if (overallScore >= 63)
                    currentStudentLetterGrade = "D";

                else if (overallScore >= 60)
                    currentStudentLetterGrade = "D-";

                else
                    currentStudentLetterGrade = "F";

                Console.WriteLine($"{student}\t\t{examScore}\t\t{overallScore}\t{currentStudentLetterGrade}\t{creditAverage} ({creditScore})");

            }
        }
    }
}
