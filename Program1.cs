using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Task_1
{
    class student
    {
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string smailid { get; set; }
        public string branch { get; set; }
        public double percentage { get; set; }
        public List<string> skills { get; set; }

    }
    class Program
    {
        static void Main(string[] args)
        {
            List<student> Slist = new List<student>()
            {
                new student() { firstname = "Kavana", lastname = "Padmashali", smailid = "kavanapadmashali@gmailcom", branch = "EE", percentage = 87,skills=new List<string>{"SQL","PHP" } },
                new student() { firstname = "Inchara", lastname = "Rao", smailid = "inchararao@gmailcom", branch = "CS", percentage = 89,skills = new List<string>{ "Python"} },
                new student() { firstname = "Ankitha", lastname = "Mesta", smailid = "ankithamesta@gmailcom", branch = "ME", percentage = 85,skills = new List<string>{"Java" }},
                new student() { firstname = "Harshitha", lastname = "Kumar", smailid = "harshithakumar@gmailcom", branch = "ME", percentage = 93,skills = new List<string>{"MySQL" } },
                new student() { firstname = "Arpitha", lastname = "M", smailid = "arpitham@gmailcom", branch = "CS", percentage = 90,skills = new List<string>{".NET","SQL" } },
                new student() { firstname = "Dhruv", lastname = "Patel", smailid = "dhruvpatel@gmailcom", branch = "EE", percentage = 88,skills = new List<string>{ "ASP.NET"} }
            };
            var query1 = from i in Slist select i;

            Console.WriteLine("Select Query");

            foreach (var i in query1)
            {
                Console.WriteLine(i.firstname + "," + i.lastname + "," + i.branch + "," + i.smailid + "," + i.percentage);
            }

            Console.WriteLine("----------------------------------");

            Console.WriteLine("Where Query");

            var query2 = from i in Slist where i.percentage > 90 select i;

            foreach (var i in query2)
            {
                Console.WriteLine(i.firstname + " " + i.lastname + "," + i.branch + "," + i.smailid + "," + i.percentage);
            }

            Console.WriteLine("----------------------------------");

            Console.WriteLine("Take Query");

            var query3 = (from i in Slist where i.percentage > 80 select i).Take(4);

            foreach (var i in query3)
            {
                Console.WriteLine(i.firstname + "," + i.percentage);
            }

            Console.WriteLine("----------------------------------");

            Console.WriteLine("Takewhile Query");

            var query4 = Slist.TakeWhile(i => i.percentage + 5 != 90);

            foreach (var i in query4)
            {
                Console.WriteLine(i.firstname);
            }

            Console.WriteLine("----------------------------------");

            Console.WriteLine("SkipWhile Query");

            IEnumerable<student> query5 = (from i in Slist select i).SkipWhile(i => i.percentage > 85);
            foreach (var i in query5)
            {
                Console.WriteLine(i.firstname + "," + i.lastname);
            }

            Console.WriteLine("----------------------------------");

            Console.WriteLine("Skip Query");

            IEnumerable<student> query6 = (from i in Slist select i).Skip(2);
            foreach (var i in query6)
            {
                Console.WriteLine(i.firstname);
            }

            Console.WriteLine("----------------------------------");

            Console.WriteLine("Orderby Query");

            var query7 = from i in Slist where i.percentage > 90 orderby i ascending select i;

            foreach (var i in query7)
            {
                Console.WriteLine(i.firstname);
            }
            Console.WriteLine("----------------------------------");

            Console.WriteLine("Groupby Query");

            var query29 = from i in Slist group i by i.branch;
            foreach (var group in query29)
            {
                Console.WriteLine(group.Key);
                Console.WriteLine("-----------");
                foreach (var i in group)
                {
                    Console.WriteLine(i.firstname + " " + i.lastname + "," + i.percentage);
                }

            }

            Console.WriteLine("----------------------------------");

            Console.WriteLine("Startswith Query");

            var query8 = (from i in Slist where i.firstname.StartsWith('K') select i);

            foreach (var i in query8)
            {
                Console.WriteLine(i.firstname);
            }

            Console.WriteLine("----------------------------------");

            Console.WriteLine("Endswith Query");

            var query9 = (from i in Slist where i.firstname.EndsWith('a') select i);

            foreach (var i in query9)
            {
                Console.WriteLine(i.firstname);
            }

            Console.WriteLine("----------------------------------");

            Console.WriteLine("Contains Query");

            var query10 = (from i in Slist where i.lastname.Contains('a') select i);
            foreach (var i in query10)
            {
                Console.WriteLine(i.lastname);
            }
            Console.WriteLine("----------------------------------");

            Console.WriteLine("Distinct Query");

            var distinct = (from i in Slist select i.branch).Distinct();

            Console.Write("Distinct Branches: ");
            foreach (var i in distinct)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine(" ");
            Console.WriteLine("----------------------------------");

            Console.WriteLine("Aggregate functions");

            double sum = (from i in Slist select i.percentage).Sum();
            Console.WriteLine("Total sum of percentage is:" + sum);

            double max = (from i in Slist select i.percentage).Max();
            Console.WriteLine("Maximum percentage is:" + max);

            double min = (from i in Slist select i.percentage).Min();
            Console.WriteLine("Minimum percentage is:" + min);

            double avg = (from i in Slist select i.percentage).Average();
            Console.WriteLine("Total average of percentage is:" + avg);

            double count = (from i in Slist select i.firstname).Count();
            Console.WriteLine("Total students are:" + count);

            Console.WriteLine("----------------------------------");

            Console.WriteLine("Offtype-double Query");

            var query11 = (from i in Slist select i.percentage).OfType<double>();
            foreach (var i in query11)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("-------------------------------------");

            Console.WriteLine("Offtype-string Query");

            var query12 = (from i in Slist select i.firstname).OfType<string>();
            foreach (var i in query12)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("-------------------------------------");

            Console.WriteLine("Let Query");

            var query13 = (from i in Slist let res = i.percentage + 5 select res);
            foreach (int i in query13)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("-------------------------------------");

            Console.WriteLine("IQueriable Query");

            IQueryable<student> query14 = (from i in Slist select i).AsQueryable();

            foreach (var i in query14)
            {
                Console.WriteLine(i.firstname + " " + i.lastname);
            }

            Console.WriteLine("-------------------------------------");

            Console.WriteLine("IEnumerable Query");

            IEnumerable<string> query15 = Slist.Select(i => i.firstname);
            foreach (var i in query15)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("-------------------------------------");

            Console.WriteLine("First Query");

            var query16 = (from i in Slist where i.branch == "ME" select i).First();
            Console.WriteLine(query16.firstname + "," + query16.smailid);

            Console.WriteLine("-------------------------------------");

            Console.WriteLine("FirstOrDefault Query");

            var query17 = (from i in Slist where i.lastname == "Padmashali" select i).FirstOrDefault();
            Console.WriteLine(query17.firstname);

            Console.WriteLine("-------------------------------------");

            Console.WriteLine("Last Query");

            var query18 = (from i in Slist where i.lastname == "Patel" select i).Last();
            Console.WriteLine(query18.firstname);

            Console.WriteLine("-------------------------------------");

            Console.WriteLine("LastOrDefault Query");

            var query19 = (from i in Slist where i.lastname == "Kumar" select i).LastOrDefault();
            Console.WriteLine(query19.firstname);

            Console.WriteLine("-------------------------------------");

            Console.WriteLine("Single Query");

            var query20 = (from i in Slist where i.lastname == "Rao" select i).Single();
            Console.WriteLine(query20.firstname);

            Console.WriteLine("-------------------------------------");

            Console.WriteLine("SingleOrDefault Query");

            var query21 = (from i in Slist where i.lastname == "M" select i).SingleOrDefault();
            Console.WriteLine(query21.firstname);

            Console.WriteLine("-------------------------------------");

            Console.WriteLine("ElementAt Query");

            var query22 = (from i in Slist select i).ElementAt(2);
            Console.WriteLine(query22.smailid);

            Console.WriteLine("-------------------------------------");

            Console.WriteLine("ElementAtOrDefault Query");

            var query23 = (from i in Slist select i).ElementAtOrDefault(4);
            Console.WriteLine(query23.firstname);

            Console.WriteLine("-------------------------------------");

            Console.WriteLine("Deferred Execution Query");

            var query24 = from i in Slist select i;

            Slist.Add(new student() { firstname = "Shreyan", lastname = "Shetty", smailid = "shreyanshetty@gmail.com", branch = "CS", percentage = 92 });
            Slist.Add(new student() { firstname = "Prajwal", lastname = "Shetty", smailid = "prajwalshetty@gmail.com", branch = "ME", percentage = 91 });

            foreach (student s in query24)
            {
                Console.WriteLine(s.firstname + "," + s.lastname);
            }

            Console.WriteLine("-------------------------------------");

            Console.WriteLine("Immediate Execution Query");

            var query25 = (from i in Slist select i).Count();

            Slist.Add(new student() { firstname = "Shobith", lastname = "Shetty", smailid = "shobithshetty@gmail.com", branch = "EE", percentage = 86 });

            var query26 = (from i in Slist select i).Count();

            Console.WriteLine(query25);
            Console.WriteLine(query26);

            Console.WriteLine("-------------------------------------");

        }
    }
}
