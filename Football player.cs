using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football
{
    public class Football_player : Person
    {
        public int Number { get; private set; }

        public decimal Height { get; private set; }

        public Football_player(string name, int age, int number, decimal height) 
            : base(name, age)
        {
            Number = number;
            Height = height;
        }
    }
}
