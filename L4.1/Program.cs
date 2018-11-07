using System;
using static System.Console;

public class SimplePerson
{
    public string FirstName;
    public string LastName;
    public DateTime DateOfBirth;
}

namespace Debugging
{
    class Program
    {
        static void Main(string[] args)
        {
            Person root = Familytree.BuildTree();

            Person found = Familytree.Find(root);
            WriteLine(root);
            WriteLine(found.FirstName + " " + found.LastName + " " + found.DateOfBirth);
            
            
            //WriteLine(found.Dad.FirstName + " " + found.Dad.LastName);
            //WriteLine(found.Mom.FirstName + " " + found.Mom.LastName);
        }
    }
}