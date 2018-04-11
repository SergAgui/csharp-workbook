using System;

namespace HelloWorld{
					
    public class Program
    {
        public static void Main()
        {
            int prin = 0;
            decimal rate = 0.0M;
            int time = 0;
            
            Console.WriteLine("Please enter the Principal amount: ");
            prin = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the Intrest Rate: ");
            rate = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Please enter the time period in years: ");
            time = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Your Accrued amount will be {0}", prin*(1+rate*time));
        }
    }
}