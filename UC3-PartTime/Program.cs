namespace UC3_PartTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n************Checking Part/Full Time Wage**************");
            int Full_Time = 1;
            int Part_Time = 0;
            int empRatePerHr = 20;
            Random random = new Random();
            int empCheck = random.Next(0, 3);

            if (empCheck == 1)
            {
                int empHour = 8;
                int salary = (empRatePerHr * empHour);
                Console.WriteLine("\nEmployee present for full day then salary is: " + salary);
            }
            else if (empCheck == 2)
            {
                int empHour = 4;
                int salary = (empRatePerHr * empHour);
                Console.WriteLine("\nEmployee present for half day then salary is: " + salary);
            }
            else
            {
                int salary = 0;
                Console.WriteLine("\nEmployee is absent then salary is:" + salary);
            }
        }
    }
}