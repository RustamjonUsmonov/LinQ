using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aisd10
{
    class Program
    {
        static void Main(string[] args)
        {
            int L = int.Parse(Console.ReadLine());
            String[] A = { "QWE", "ASD", "ZXC", "ASDA", "OLKJ", "ZXF" };

            var query = from s in A
                        where s.Length == L
                        select s;

            Console.WriteLine(query.Max());

            Console.ReadKey();
        }

    }