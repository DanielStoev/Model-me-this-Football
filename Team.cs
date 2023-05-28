using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football
{
    public class Team
    {
        public Coach Coach { get; set; }

        public List<Football_player> playerList { get; private set; }

        public Team()
        {
            playerList = new List<Football_player>();
            
        }

        public string Name { get; set;}
        public void AddGoalkeeper(Goalkeeper goalkeeper)
        {
            playerList.Add(goalkeeper);
        }

        public void AddDefender(Defender defender)
        {
            playerList.Add(defender);
        }

        public void AddMidfield(Midfield midfield)
        {
            playerList.Add(midfield);
        }

        public void AddStriker(Striker striker)
        {
            playerList.Add(striker);
        }

        public int AverageTeamAge()
        {
            int avarageTeamAge = 0;
            foreach (var player in playerList) 
            {
                avarageTeamAge += player.Age;
            }
            return avarageTeamAge / playerList.Count;
        }
    }
}
