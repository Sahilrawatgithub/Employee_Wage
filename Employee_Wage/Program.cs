namespace Employee_Wage
{
    internal class Program
    {
        static int ComputeWage(string company,int max_hours,int rate_per_hour,int total_working_days)
        {
            const int part_time = 1;
            const int full_time = 2;

            int hours_worked = 0;
            int days_worked = 0;
            Random random = new Random();

            for (days_worked = 0; days_worked < total_working_days; days_worked++)
            {
                int check = random.Next(1, 3);
                if (hours_worked < max_hours)
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
            Console.WriteLine($"Employee worked for {hours_worked} hours at {company} and made ${wage} when the hourly rate was $20");
            return wage;
        }
        static void Main(string[] args)
        {
            //UC8 Compute Employee wage for multiple company in procedural way using class methods

            Console.WriteLine("Input company name, monthly maximum hours, hourly rate and monthly maximum working days ");
            string ?company=Console.ReadLine();
            int max_hours = Convert.ToInt32(Console.ReadLine());
            int hourly_rate = Convert.ToInt32(Console.ReadLine());
            int total_working_days = Convert.ToInt32(Console.ReadLine());

            ComputeWage( company, max_hours, hourly_rate, total_working_days);

            
        }
    }
}
