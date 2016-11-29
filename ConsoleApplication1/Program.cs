using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, f;
            for(i=2;i<=100;i++)
            {
                f = 0;
                for(j=2;j<=i-1;j++)
                {
                    if(i%j==0)
                    {
                        f = 1;
                        break;
                    }
                }
                if(f==0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
