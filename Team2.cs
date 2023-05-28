using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football
{
    public class Team2
    {
        public Team Team()
        {
            Team team2 = new();

            team2.Name = "Levski";

            team2.Coach = new Coach("Stanimir Stoilov", 56);

            team2.AddGoalkeeper(new Goalkeeper("Joam Zagorov", 17, 0, 1.84m));

            team2.AddDefender(new Defender("Jeremy Petris", 25, 2, 1.84m));
            team2.AddDefender(new Defender("Kellyanne van der Kaap", 24, 5, 1.84m));
            team2.AddDefender(new Defender("Tsunami", 27, 6, 1.84m));
            team2.AddDefender(new Defender("Ante Blazevic", 27, 21, 1.84m));

            team2.AddMidfield(new Midfield("Ivelin Popov", 35, 10, 1.84m));
            team2.AddMidfield(new Midfield("Ilian Stefanov", 24, 14, 1.84m));
            team2.AddMidfield(new Midfield("Assen Chandirov", 24, 20, 1.84m));

            team2.AddStriker(new Striker("Ricardinho", 22, 9, 1.84m));
            team2.AddStriker(new Striker("Javad El Jemili", 20, 11, 1.84m));
            team2.AddStriker(new Striker("Welton", 25, 17, 1.84m));

            return team2;
        }
    }
}
