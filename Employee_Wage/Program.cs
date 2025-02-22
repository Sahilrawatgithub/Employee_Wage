namespace Employee_Wage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //UC2: Calculate daily employee wage
            int isFullTime = 1;
            int ratePerHour = 10;

            int hoursWorked = 0;
            Random rand = new Random();
            int check = rand.Next(0, 2);

            if (check == isFullTime)
            {
                hoursWorked = 8;
            }
            else
            {
                hoursWorked = 0;
            }

            int Wage = hoursWorked * ratePerHour;

            Console.WriteLine($"Daily wage is ${Wage}");

        }
    }
}
