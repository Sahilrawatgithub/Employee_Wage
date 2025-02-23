namespace Employee_Wage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter company name, hourly rate, maximum hours and days for a month");
            string company=Console.ReadLine();
            int hourly_rate=Convert.ToInt32(Console.ReadLine());
            int maximum_hours = Convert.ToInt32(Console.ReadLine());
            int total_days = Convert.ToInt32(Console.ReadLine());
            WageBuilder SahilCo = new WageBuilder(company,hourly_rate,maximum_hours,total_days);
            SahilCo.ComputeWage();
        }
    }

    class WageBuilder
    {
        const int part_time = 1;
        const int full_time = 2;

        String company;
        int hourly_rate;
        int max_hours;
        int total_days;

        int total_wage;

        public WageBuilder(string company, int hourly_rate, int max_hours, int total_days)
        {
            this.company = company;
            this.hourly_rate = hourly_rate;
            this.max_hours = max_hours;
            this.total_days = total_days;
            
        }

        public void ComputeWage()
        {
            int hours_worked = 0;
            int days_worked = 0;
            
            Random random = new Random();

            for (days_worked = 0; days_worked < total_days; days_worked++)
            {
                if (hours_worked < max_hours)
                {
                    int check = random.Next(1, 3);

                    switch (check)
                    {
                        case (part_time):
                            hours_worked += 4;
                            break;
                        case (full_time):
                            hours_worked += 8;
                            break;
                        default:
                            break;
                    }
                }
                else break;
            }
            total_wage= hours_worked*hourly_rate;
            Console.WriteLine($"Employee wage for {company} is ${total_wage} when Employee worked for {hours_worked} hours or {days_worked} days.");
        }
    }
}
