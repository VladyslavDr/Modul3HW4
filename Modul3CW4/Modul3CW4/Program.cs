using System;
using System.Linq;

namespace Modul3CW4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // ----------------task1------------------
            var item = new Task1();
            var res = 0;

            item.TryCatch(() =>
            {
                res = item.Run();
            });

            Console.WriteLine($"task1: {res}");

            // ----------------task2------------------
            var item2 = new Task2();

            var list = item2.GetContacts();

            var firstOrDefaultList1 = list.Where(w => w.FirstName.ToUpper().StartsWith("V")).FirstOrDefault();
            var firstOrDefaultList2 = list.Where(w => w.FirstName.ToUpper().StartsWith("V")).Select(o => o.FirstName.Length);

            Console.WriteLine($"task2: {firstOrDefaultList1.FirstName}");

            Console.WriteLine($"task2:");
            foreach (var i in firstOrDefaultList2)
            {
                Console.Write($"{i} ");
            }

            Console.WriteLine();
            Console.WriteLine($"task2:");
            var firstOrDefaultList3 = list.Where(w => w.FirstName.ToUpper().StartsWith("V")).Where(o => o.LaststName.ToUpper().StartsWith("O"));

            foreach (var i in firstOrDefaultList3)
            {
                Console.Write($"{i.FirstName} ");
            }

            var firstOrDefaultList4 = list.Where(w => w.FirstName.ToUpper().StartsWith("V")).Count();

            Console.WriteLine();
            Console.WriteLine($"task2: {firstOrDefaultList4}");

            var firstOrDefaultList5 = list.Where(w => w.FirstName.ToUpper().StartsWith("S")).OrderBy(o => o.FirstName);

            foreach (var i in firstOrDefaultList5)
            {
                Console.Write($"{i.FirstName} ");
            }
        }
    }
}
