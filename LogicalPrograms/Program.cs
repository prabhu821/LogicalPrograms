namespace LogicalPrograms;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Logical Programs");
        bool flag = true;
        while (flag)
        {
            Console.WriteLine("\nEnter your choice \n1.Coupon Number \n2.Day of Week \n3.Exit");
            Console.WriteLine("\nEnter option to execute");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    CouponNumber.GenerateCoupons(10);
                    break;
                case 2:
                    DayOfWeek.DayofWeek();
                    break;
                default:
                    flag = false;
                    break;
            }
        }
    }
}
