namespace EmployAttendance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n***************EMPLOYEE ATTENDANCE PROGRAM**********************");
            int Full_Time = 1;
            Random random = new Random();
            int empCheck = random.Next(0, 2);

            if (empCheck == 1)
            {
                Console.WriteLine("\nEmployee is Present");
            }
            else
            {
                Console.WriteLine("\nEmployee is Absent");
            }
        }
    }
}