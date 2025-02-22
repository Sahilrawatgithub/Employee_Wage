namespace Employee_Wage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //UC3 Add Part time employee and wage
            int PartTime = 1;
            int FullTime = 2;


            int Hourly_Rate = 10;
            int wage = 0;

            Random rand = new Random();

            int check = rand.Next(3);

            if (check == PartTime)
            {
                wage = 4 * Hourly_Rate;
                Console.WriteLine($"Employee works part time and their wage is ${wage}");
            }
            else if (check == FullTime)
            {
                wage = 8 * Hourly_Rate;
                Console.WriteLine($"Employee works full time and their wage is ${wage}");
            }
            else
            {
                Console.WriteLine($"Person did not work. Wage = ${wage}");
            }
        }
    }
}
