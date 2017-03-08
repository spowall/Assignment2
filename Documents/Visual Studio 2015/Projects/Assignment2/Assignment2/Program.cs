using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            //create object of the country class
            Country uk = new Country();
            uk.Name = "United Kingdom";
            uk.President = "Theresa May";
            uk.Landmass = 945999f;
            uk.GDP = 51.4m;
            uk.States = new List<string> { "London", "Manchester", "Liverpool" };
            //print out country info
            uk.PrintProfile();

            //create another object
            Country nigeria = new Country();
            nigeria.Name = "Nigeria";
            nigeria.President = "Buhari";
            nigeria.Landmass = 945999f;
            nigeria.GDP = 51.4m;
            nigeria.States = new List<string> { "Lagos", "Kaduna", "Owerri" };
            nigeria.AddState("Ondo");
            nigeria.AddState("Jigawa");
            nigeria.PrintProfile();
            nigeria.PrintState();

            //create cameroun object
            Country cameroun = new Country();
            cameroun.Name = "Cameroun";
            cameroun.President = "Biya";
            cameroun.Landmass = 23443f;
            cameroun.GDP = 50m;
            cameroun.States = new List<string> { "State 1", "State 2", "State 3" };
            cameroun.PrintProfile();

            Console.ReadLine();
        }
    }
}
