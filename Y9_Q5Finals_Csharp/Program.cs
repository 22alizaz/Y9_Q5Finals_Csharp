using System.Threading.Channels;

namespace Y9_Q5Finals_Csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int e1 = 50;
            int e2 = 50;
            int e3 = 50;


            Console.WriteLine("Input the number of essays handed in late");
            int late = Convert.ToInt32(Console.ReadLine());
            float total = e1 + e2 + e3;
            while (total >= 0)
            {
                if (late==1)
                {
                        total = total - 10;
                    
                } 
                if (late>=2) 
                {
                    total = total / 2;
                }
            }
            if (total<=-1)
            {
                float leftover = total*-1;
                total = total + leftover;   
            }
            Console.WriteLine("The total mark is " + total);


        }
    }
}
