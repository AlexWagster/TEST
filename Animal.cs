using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOL_Practice_3
{
    internal class Animal
    {
        //SET VARIABLES
        public string Name, Owner;
        public int Cost, Level;

        //CONSTRUCTOR METHOD
        public Animal(string Name, int Cost)
        {
            Level = 0;
            Name = Name;
            Cost = Cost;
        }
    }
}
