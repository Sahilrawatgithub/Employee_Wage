namespace Employee_Wage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //UC4 Calculating Employee wage using switch statement

            const int part_time = 1;
            const int full_time = 2;
            int hours_worked = 0;
            int rate_per_hour = 10;

            Random rand=new Random();

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
            int wage=rate_per_hour*hours_worked;
            Console.WriteLine($"The wage is {wage}");
        }
    }
}
