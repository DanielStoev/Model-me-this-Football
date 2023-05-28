using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football
{
    public class Goalkeeper : Football_player
    {
        public Goalkeeper(string name, int age, int number, decimal height)
            : base(name, age, number, height)
        {
        
        }
    }
}
