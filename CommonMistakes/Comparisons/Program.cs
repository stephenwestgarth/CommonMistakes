using Comparisons.Helpers;
using Comparisons.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comparisons
{
    public class Program
    {

        static void Main(string[] args)
        {
            //Passing objects by reference and by value
            var ex1 = new Example1();
            ex1.Start();

            //Passing parameters by reference and by value
            var ex2 = new Example2();
            ex2.Start();

            //Checking for Nulls in Structs
            var ex3 = new Example3();
            ex3.Start();

            //Comparing Strings
            var ex4 = new Example4();
            ex4.Start();

            //Interating Over Values instead of using Linq
            var ex5 = new Example5();
            ex5.Start();

            //Parsing Ambiguous Dates
            var ex6 = new Example6();
            ex6.Start();

            //Parsing Ambiguous Dates
            var ex7 = new Example7();
            ex7.Start();

            //Parsing Ambiguous Dates
            var ex8 = new Example8();
            ex8.Start();

            Console.ReadKey();

        }
    }

    public class Example1
    {
        public void Start()
        {
            Console.Clear();
            Console.WriteLine("START OF EXAMPLE 1");

            CreatePoint();
            CreatePen();

            Console.WriteLine("END OF EXAMPLE 1");

        }

        private void CreatePoint()
        {
            Point Point1 = new Point(50, 10);
            Console.WriteLine("The Value of Point1 X is {0}", Point1.X);

            Point Point2 = Point1;
            Console.WriteLine("The Value of Point2 X is {0}", Point2.X);

            Point2.X = 33;
            Console.WriteLine("The Value of Point2 X is {0}", Point2.X);

            Console.WriteLine("The Value of Point1 X is {0}", Point1.X);

        }

        private void CreatePen()
        {
            Pen Pen1 = new Pen("red");
            Console.WriteLine("The Value of Pen1 Color is {0}", Pen1.Colour);

            Pen Pen2 = Pen1;
            Console.WriteLine("The Value of Pen2 Color is {0}", Pen2.Colour);

            Pen2.Colour = "Blue";
            Console.WriteLine("The Value of Pen2 Clour is {0}", Pen2.Colour);

            //What is the value of X?
            Console.WriteLine("The Value of Pen1 Color is {0}", Pen1.Colour);
        }
    }



    public class Example2
    {
        public void Start()
        {
            Console.Clear();
            Console.WriteLine("START OF EXAMPLE 2");
            ShowSwapByValue();
            ShowSwapByRef();

            Console.WriteLine("END OF EXAMPLE 2");
        }

        private void ShowSwapByRef()
        {
            string firstString = "Hello";
            string secondString = "Steve";

            Console.WriteLine("{0} {1}", firstString, secondString);

            //Call method to swap the strings
            SwapStringByRef(ref firstString, ref secondString);

            Console.WriteLine("{0} {1}", firstString, secondString);
        }

        private void ShowSwapByValue()
        {
            string firstString = "Hello";
            string secondString = "Steve";

            Console.WriteLine("{0} {1}", firstString, secondString);

            //Call method to swap the strings
            var result = SwapStringByValue(firstString, secondString);

            Console.WriteLine("{0} {1}", result.Item1, result.Item2);
        }

        private void SwapStringByRef(ref string string1, ref string string2)
        {
            string temp = string1;
            string1 = string2;
            string2 = temp;
        }

        private Tuple<string, string> SwapStringByValue(string string1, string string2)
        {
            string temp = string1;
            string1 = string2;
            string2 = temp;
            return Tuple.Create(string1, string2);
        }
    }


    public class Example3
    {
        Pen Pen1;
        Point Point1;

        public void Start()
        {
            Console.Clear();
            Console.WriteLine("START OF EXAMPLE 3");
            Console.WriteLine("Will running this code generate an error?");
            try
            {
                Console.WriteLine(Pen1.Colour);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


            Console.WriteLine("Will running this code generate an error?");
            try
            {
                Console.WriteLine(Point1.X);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine(Point1.isEmpty());


            Console.WriteLine("END OF EXAMPLE 3");
        }

    }


    public class Example4
    {

        //String Comparison Methods

        public void Start()
        {
            Console.Clear();
            Console.WriteLine("START OF EXAMPLE 4");

            string string1 = "Another";
            string string2 = "Word";

            StringComparisons(string1, string2);

            string string3 = "Hello";
            string string4 = "Hello";

            StringComparisons(string3, string4);

            string string5 = "Hello";
            string string6 = "hello";

            StringComparisons(string5, string6);


            string string7 = "strasse";
            string string8 = "straße";

            StringComparisons(string7, string8);


            OrdinalComparison(string3, string4);
            OrdinalComparison(string5, string6);
            OrdinalComparison(string7, string8);

            CultureComparison(string3, string4);
            CultureComparison(string5, string6);
            CultureComparison(string7, string8);


            Console.WriteLine("END OF EXAMPLE 4");
        }

        private void StringComparisons(string string1, string string2)
        {
            Console.WriteLine("Are the strings equal? {0} and {1}",string1, string2);

            Console.WriteLine(string1 == string2);
            Console.WriteLine(string1.Equals(string2));


        }

        private void OrdinalComparison(string string1, string string2)
        {

            bool ordinaloutput = string1.Equals(string2, StringComparison.Ordinal);
            bool caseSensitiveOrdinalOutput = string1.Equals(string2,StringComparison.OrdinalIgnoreCase);

            Console.WriteLine("Are the strings equal with an Ordinal Comparison? {0} and {1}",string1,string2);

            Console.WriteLine("Is {0} equal to {1}: {2}", string1, string2, ordinaloutput);
            Console.WriteLine("Is {0} equal to {1}: {2}", string1, string2, caseSensitiveOrdinalOutput);


        }

        private void CultureComparison(string string1, string string2)
        {

            bool cultureOutput = string1.Equals(string2, StringComparison.CurrentCulture);
            bool caseSensitiveCultureOutput = string1.Equals(string2, StringComparison.CurrentCultureIgnoreCase);


            Console.WriteLine("Are the strings equal with a Culture Comparison? {0} and {1}", string1, string2);

            Console.WriteLine("Is {0} equal to {1}: {2}", string1, string2, cultureOutput);
            Console.WriteLine("Is {0} equal to {1}: {2}", string1, string2, caseSensitiveCultureOutput);

        }

    }

    public class Example5
    {
      
        //Iterating through values instead of using linq

        public void Start()
        {
            Console.Clear();
            Console.WriteLine("START OF EXAMPLE 5");
            List<Person> persons = new List<Person>();
            persons.Add(new Person("Steve", 32));
            persons.Add(new Person("Greg", 12));
            persons.Add(new Person("Adam", 22));


            var inefficientAverageAge = InnefficientAverageAge(persons);
            var efficientAverageAge = EfficientAverageAge(persons);

            Console.WriteLine(inefficientAverageAge);
            Console.WriteLine(efficientAverageAge);

            Console.WriteLine("END OF EXAMPLE 5");
        }

        public int InnefficientAverageAge(List<Person> persons)
        {
            int totalage = 0;
            foreach(var person in persons)
            {
                totalage = totalage + person.age;
            }
            return totalage / persons.Count();
        }

        public int EfficientAverageAge(List<Person> person)
        {
            return Convert.ToInt32(person.Average(p => p.age));
        }




    }


    public class Example6
    {

        //Iterating through values instead of using linq

        public void Start()
        {
            Console.Clear();
            Console.WriteLine("START OF EXAMPLE 6");
            var date = DateTime.Parse("01/12/2000");
            var dateExact = DateTime.ParseExact("01/12/2000", "MM/dd/yyyy", null);




            Console.WriteLine("END OF EXAMPLE 6");
        }
    }


    public class Example7
    {
        //Massive Try Catch Blocks

        public void Start()
        {
            Console.Clear();
            Console.WriteLine("START OF EXAMPLE 7");

            try
            {
                var date = DateTime.Parse("01/12/2000");
                var dateExact = DateTime.ParseExact("01/13/2000", "MM/dd/yyyy", null);

                List<Person> persons = new List<Person>();
                persons.Add(new Person("Steve", 32));
                persons.Add(new Person("Greg", 12));
                persons.Add(new Person("Adam", 22));


                int totalage = 0;
                foreach (var person in persons)
                {
                    totalage = totalage + person.age;
                }
                Console.WriteLine(totalage / persons.Count());
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }

            Console.WriteLine("END OF EXAMPLE 7");
        }


    }

    public class Example8
    {

        //Iterating through values instead of using linq

        public void Start()
        {
            Console.Clear();
            Console.WriteLine("START OF EXAMPLE 8");

            Console.WriteLine(Concatonate("Hello", "Steve"));
            Console.WriteLine(StringBuilder("Hello", "Steve"));

            Console.WriteLine("END OF EXAMPLE 8");
        }

        private string StringBuilder(string string1, string string2)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(string1);
            sb.Append(" ");
            sb.Append(string2);
            return sb.ToString();
        }

        private string Concatonate(string string1, string string2)
        {
            return (string1 + " " + string2);
        }
    }
}
