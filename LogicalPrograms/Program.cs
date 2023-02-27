namespace LogicalPrograms;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Logical Programs");
        bool flag = true;
        while (flag)
        {
            Console.WriteLine("\n\nEnter your choice \n1.Coupon Number \n2.Day of Week \n3.Fibonacci Series \n4.Perfect Number" +
                " \n5.Prime Number \n6.Reverse Number \n7.Exit");
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
                case 4:
                    PerfectNumber perfectNumber = new PerfectNumber();
                    Console.WriteLine("Enter number");
                    int n = Convert.ToInt32(Console.ReadLine());
                    perfectNumber.Check(n);
                    break;
                case 5:
                    PrimeNumber primeNumber = new PrimeNumber();
                    Console.WriteLine("Enter number");
                    int primeNum = Convert.ToInt32(Console.ReadLine());
                    primeNumber.CheckPrime(primeNum);
                    break;
                case 6:
                    ReverseNumber reverseNumber = new ReverseNumber();
                    Console.WriteLine("Enter number");
                    int reverseNum = Convert.ToInt32(Console.ReadLine());
                    reverseNumber.Reverse(reverseNum);
                    break;
                default:
                    flag = false;
                    break;
            }
        }
    }
}
