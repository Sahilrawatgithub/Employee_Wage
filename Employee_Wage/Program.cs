namespace Employee_Wage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //UC1 Check Employee is present or absent
            Random random = new Random();
            int CheckAttendance = random.Next(0, 2);

            if (CheckAttendance > 0)
            {
                Console.WriteLine("Employee is present");
            }
            else
            {
                Console.WriteLine("Employee is absent");
            }
        }
    }
}
