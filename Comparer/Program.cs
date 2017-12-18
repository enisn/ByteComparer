using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comparer
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            Point:
            //Console.WriteLine("First Parameter");

            //var a = Console.ReadLine().GetHashCode();

            //Console.WriteLine("Second Parameter");
            //var b = Console.ReadLine().GetHashCode();



            byte[] file1 = File.ReadAllBytes(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "new1.txt"));

            byte[] file2 = File.ReadAllBytes(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "new2.txt"));

            //var data3 = file1.Zip(file2, (d1, d2) => Math.Abs(d1 - d2)).ToArray();

            var data3 = file2.Where((x, i) => x != file1[i]);
         
            var difference = data3.Average(x=>x);
            if (difference <= 24)
            {
                Console.WriteLine("Benzer");
            }
            else
            {
                Console.WriteLine("Alakasız");
            }


            
            Console.ReadLine();


            goto Point;

        }
        public class Person
        {
            public string Name { get; set; }
            public string Surname { get; set; }
            public DateTime Birthdate { get; set; }


        }
    }
}
