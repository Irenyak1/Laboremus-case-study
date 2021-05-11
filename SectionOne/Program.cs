using System;
using System.Linq;

namespace SectionOne
{
    class Program
    {
        // Function to return the total number of distinct values in an array between 0 and 100,000
        public static int WorkingWithArrays(int [] A)
        {
            int count = 0;
            var integers = (from N in A select N).Distinct<int>();
            foreach(var i in integers){
                if (i >= 0 && i <= 100000){
                    count++;
                }
                
            }

            return count;
        }
     
         static void Main(string[] args)
        {
           
            int[] A = {-10, 0, 10, 10, 20, 30, 30, 40, 40, 100000, 200000};
            Console.WriteLine(WorkingWithArrays(A));
   
        }
    }
}
