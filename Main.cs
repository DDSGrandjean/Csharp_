using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassEnrollmentParallel
{
    class Main
    {
        static void Main(string[] args)
        {
            string[] className = { "CS150", "CS250", "CS270", "CS300", "CS350" };
            int[] currentEnrollment = { 180, 21, 09, 04, 20 };
            int[] maxEnrollement = { 200, 30, 20, 20, 20 };

            ProduceHeading();

            Enrollment enrollment = new Enrollment();

            enrollment.ClassArray = className;
            enrollment.CurrentArray = currentEnrollment;
            enrollment.MaxArray = maxEnrollement;
            Console.WriteLine(enrollment.Classes());

            Console.Write("Enter course: ");
            enrollment.CLS = Console.ReadLine();
            Console.WriteLine(enrollment.CLS);
            Console.Read();

        }
        private static void ProduceHeading()
        {
            Console.WriteLine("\tClass Enrollment App\n\n" +
                              "Class\tCurrent\t\tSeats\t\tSeats\n" +
                              "Name\tEnrollment\tAvailable\tLeft\n");
        }
    }
}
