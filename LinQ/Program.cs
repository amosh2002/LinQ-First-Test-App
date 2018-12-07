using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

            var count = query.Count();

            foreach (var name in query) {
                Console.WriteLine(name);
                Console.ReadLine();
            }
            Console.WriteLine(count);

            //-------------------Filtration-------------------//
            //names.Take(5);  //takes first five elements
            //names.Skip(2);  //skips first two elements
            //names.SkipWhile();  //skips while something
            //names.TakeWhile();  //takes while something
            //names.Distinct(); //takes only unique, non-repeatable elements

            //-------------------Select-------------------//
            //names.Select();  //selects an element and changes it to other one
            //names.SelectMany();  //selects many elements and changes them to other ones

            //-------------------Join-------------------//
            //names.Join();  //joins elements 
            //names.GroupJoin();  //Harcnel

            //-------------------Order-------------------//
            //names.OrderBy();  //puts elements in the mentioned order (ascending)
            //names.OrderByDescending(); //puts elements in the mentioned order (descending)

            //-------------------Connect-------------------//
            //names.Concat();  //connects 2 lists in 1
            //names.union();  //connects 2 lists in 1 without repeating ones
            //names.Intercect();  //finds repeating elements in 2 lists
            //names.Except();  //finds non-repeating elements in 2 lists

            //-------------------Export-------------------//
            //names.ToArray();  //converts the elements to array 
            //names.ToList();  //converts the elements to list

            //-------------------Elementing-------------------//
            //names.Single();  //takes the only element matching the mentioned principe
            //names.SingleOrDefault();  //takes the only element matching the mentioned principe, if nothing found returns the whole list

            //-------------------Other-------------------//
            //Enumerable.Empty<string>();  //returns an empty list, to prevent thr program from being excepted if the list is null


            var query2 = from n in names
                         where n.Contains("a")
                         select n.ToUpper();












            IEnumerable<string> query3 =
                from n in names
                select Regex.Replace(n, "[aeiou]", "")
                into NewValue
                where NewValue.Length > 2 //Harcnel
                orderby NewValue
                select NewValue;

            var query4 =
                from a in (
                    from b in names
                    select Regex.Replace(b, "[aeiou]", "")
                    )
                where a.Length > 2
                orderby a
                select a;

        }
    }
}
