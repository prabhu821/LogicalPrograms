namespace LogicalPrograms;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Logical Programs");
        bool flag = true;
        while (flag)
        {
            Console.WriteLine("\n\nEnter your choice \n1.Coupon Number \n2.Day of Week \n3.Fibonacci Series \n4.Exit");
            Console.WriteLine("Enter option to execute");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    CouponNumber.GenerateCoupons(10);
                    break;
                case 2:
                    DayOfWeek.DayofWeek();
                    break;
                case 3:
                    FibonacciSeries series = new FibonacciSeries();
                    Console.WriteLine("Enter number");
                    int num=Convert.ToInt32(Console.ReadLine());
                    series.Print(num);
                    break;
                default:
                    flag = false;
                    break;
            }
        }
    }
}
