using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comparisons.Models
{
    //The struct keyword is used to defined a VALUE type
    public struct Point
    {
        public int X, Y;
   
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public bool isEmpty()
        {
            if(X == 0 && Y == 0)
            {
                return true;
            }
            return false;
        }

     

    }

    //The class keyword is used to defined a REFERENCE type
    public class Pen
    {
        public string Colour;

        public Pen(string colour)
        {
            Colour = colour;
        }
    }


    public class Person
    {
        public string name;
        public int age;

        public Person(string Name, int Age)
        {
            name = Name;
            age = Age;
        }

      
    }

    public struct Woman
    {
        public string name;
        public int age;

        public Woman(string Name, int Age)
        {
            name = Name;
            age = Age;
        }
    }

    public class Account
    {

        int myId;
        int Id;   // compiler warned you about this, but you didn’t listen!

        // Constructor
        Account(int id)
        {
            this.myId = Id;     // OOPS!
        }

    }
}
