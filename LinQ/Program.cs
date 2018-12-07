using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ
{
    class Program
    {
         static string[] names = { "Tom", "Ann", "David", "Mary" };

        static void Main(string[] args)
        {
            var list = new List<string>();
            foreach (var name in names) {
                if (name.Contains("a"))
                    list.Add(name.ToUpper());
                
            }

            var query = names
                .Where(x => x.Contains("a"))
                .OrderBy(x=>x.Length)
                .Select(x => x.ToUpper());

            foreach (var name in query) {
                Console.WriteLine(name);
                Console.ReadLine();
            }

            var query2 = from n in names
                         where n.Contains("a")
                         select n.ToUpper();

        }
    }
}
