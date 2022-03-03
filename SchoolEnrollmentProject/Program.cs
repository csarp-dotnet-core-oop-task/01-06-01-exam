using System;

namespace SchoolEnrollmentProject
{
    class Program
    {
        static void Main(string[] args)
        {
            PointSummary josephScore = new PointSummary(83, 94);
            Student joseph = new Student("József", josephScore);

            PointSummary elisabethScore = new PointSummary(87, 93);
            Student elisabeth = new Student("Erzsébet", elisabethScore);

            Console.Write("Felvételi sorrend: ");
            if (elisabeth.TotalScore > joseph.TotalScore)
                Console.WriteLine("1."+elisabeth.Name+", 2."+ joseph.Name);
            else if (elisabeth.TotalScore < joseph.TotalScore)
                Console.WriteLine("1." + joseph.Name + ", 2." + elisabeth.Name);
            else
                Console.WriteLine("1." + elisabeth.Name + ", 1." + joseph.Name);

        }
    }
}
