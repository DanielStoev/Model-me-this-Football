using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Football
{
    public class Team1
    {
        public Team Team()
        {
            Team team1 = new Team();

            team1.Name = "CSKA";

            team1.Coach = new Coach("Sasha Ilic", 45);

            team1.AddGoalkeeper(new Goalkeeper("Ilya Shalamanov", 20, 0, 1.84m));

            team1.AddDefender(new Defender("Jürgen Mattei", 30, 2, 1.84m));
            team1.AddDefender(new Defender("Meno Koch", 28, 4, 1.84m));
            team1.AddDefender(new Defender("Bradley de Noyer", 25, 5, 1.84m));
            team1.AddDefender(new Defender("Christian Petrov", 20, 6, 1.84m));

            team1.AddMidfield(new Midfield("Jefferson", 29, 3, 1.84m));
            team1.AddMidfield(new Midfield("Jonathan Lindseth", 27, 7, 1.84m));
            team1.AddMidfield(new Midfield("Stanislav Shopov", 21, 8, 1.84m));

            team1.AddStriker(new Striker("Dukens Nazon", 29, 9, 1.84m));
            team1.AddStriker(new Striker("Mauricio Garcés", 26, 10, 1.84m));
            team1.AddStriker(new Striker("Bismarck Charles", 22, 17, 1.84m));

            return team1;
        }
    }
}
