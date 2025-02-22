namespace Employee_Wage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //UC6 Calculate Wages till a condition of total working hours of 100 or max days of 20 is reached for a month

            const int part_time = 1;
            const int full_time = 2;

            int hours_worked = 0;
            int rate_per_hour = 20;

            int days_worked = 0;
            Random random = new Random();

            for (days_worked = 0; days_worked < 21; days_worked++)
            {
                int check = random.Next(1, 3);
                if (hours_worked < 100)
                {
                    switch (check)
                    {
                        case part_time:
                            hours_worked += 4;
                            break;

                        case full_time:
                            hours_worked += 8;
                            break;

                        default:
                            hours_worked = 0;
                            break;
                    }
                }
                else
                {
                    break;
                } 
            }

            int wage = hours_worked * rate_per_hour;
            Console.WriteLine($"Employee worked for {hours_worked} hours and made ${wage} when the hourly rate was $20");

        }
    }
}
