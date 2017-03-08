using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Country
    {
        public string Name;
        public string President;
        public float Landmass;
        public decimal GDP;
        public List<string> States; //store a list of states

        //print out profile
        public void PrintProfile()
        {
            Console.WriteLine("Name: " + Name + ", President: " + President + ", Landmass: " + Landmass);
        }

        //add a new state to existing state collection
        public void AddState(string newstate)
        {
            if (States == null)
            {
                States = new List<string>(); //create states object
            }

            States.Add(newstate);
        }

        //print out states
        public void PrintState()
        {
            foreach (string s in States)
            {
                Console.WriteLine(s);
            }
        }
    }
}
