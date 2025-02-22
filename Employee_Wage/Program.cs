namespace Employee_Wage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //UC5 Calculating wages for a month assuming 20 working days in a month
            int working_days = 20;
            const int part_time = 1;
            const int full_time = 2;
            int rate_per_hour = 20;
            int hours_worked = 0;
            int total_wage = 0;
            Random rand = new Random();

            for (int days = 0; days < working_days; days++)
            {
                int check = rand.Next(0, 3);

                switch (check)
                {
                    case part_time:
                        hours_worked = 4;
                        break;
                    case full_time:
                        hours_worked = 8;
                        break;
                    default:
                        hours_worked = 0;
                        break;
                }

                total_wage += hours_worked * rate_per_hour;
               
            }
            Console.WriteLine($"Employee earned ${total_wage} in this month.");
        }
    }
}
