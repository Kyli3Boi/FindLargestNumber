using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindLargestNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a series of nubers seperated by a \",\"");
            Console.WriteLine("EG. 1,2,3,4,5");
            
            string userNumbers = Console.ReadLine();
            string[] userNumbersSplit = userNumbers.Split(',');
            int largestNumber = 0;

            for (int i = 0; i < userNumbersSplit.Length; i++)
            {
                if (Convert.ToInt32(userNumbersSplit[i]) > largestNumber)
                {
                    largestNumber = Convert.ToInt32(userNumbersSplit[i]);
                }
            }
            
            Console.WriteLine("The largest number is: {0}", largestNumber);

            Console.ReadKey();
        }
    }
}
