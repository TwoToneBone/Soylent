using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soylent
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> outputs = new List<string>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int calories = int.Parse(Console.ReadLine());

                if (calories % 400 == 0)
                {
                    outputs.Add((calories / 400).ToString());
                }
                else
                {
                    outputs.Add((((400 - (calories % 400)) + calories) / 400).ToString());
                }
            }

            foreach (var i in outputs)
            {
                Console.WriteLine(i);
            }
        }
    }
}
