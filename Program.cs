using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ClosestBy7Divident(18));
            { 
                public static int ClosestBy7Num(int num)
                {
                    int divident = 7;
                    if (num%divident==0)  
                        return num;
            }else
                {
                    int i = 0;
                    while (i < num)
                    {
                        i += divident;
                    }
                    if (i-num<=3)
                    {
                        return i;
                    }else
                    {
                        return i - divident;
                    }
                }
         
            //sual2
            //int i, n, sum = 0;
            //Console.WriteLine("Enter the value of n :");

            //n = Convert.ToInt32(Console.ReadLine());

            //for (i = 1; i <= n; i++)
            //{
            //    sum += i;
            //}

            //Console.WriteLine("Total sum: " + sum);
 
        }
    }
}
        
        

