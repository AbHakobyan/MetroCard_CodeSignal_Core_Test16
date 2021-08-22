using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetroCard_CodeSignal_Core_Test16
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = metroCard(28);
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }

        }

        static int[] metroCard(int lastNumberOfDays)
        {
            int[] arr = new int[3] { 28,30,31 };
            List<int> list = new List<int>();   
            if (lastNumberOfDays == 28)
            {
                list.Add(31);   
            }
            else if (lastNumberOfDays == 30)
            {
                list.Add(31);
            }
            else if (lastNumberOfDays == 31)
            {
                list.AddRange(arr);
            }
            return list.ToArray();
        }
    }
}
