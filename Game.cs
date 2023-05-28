using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Football
{
    public delegate void NotifyDelegate(Football_player player, string team, int minute, int score);

    public class Game
    {
        public NotifyDelegate Notify { get; set; }
        public Team homeTeam;
        public Team awayTeam;

        public Game()
        {
            Team1 team1 = new Team1();
            homeTeam = team1.Team();

            Team2 team2 = new Team2();
            awayTeam = team2.Team();
        }

        public (Team, Team) ReturnTeams() 
        { 
            return (homeTeam, awayTeam);
        }
        public (int, int) Goals()
        {
            int homeTeamScore = 0;
            int awayTeamScore = 0;

            for (int minute = 0; minute <= 90; minute++)
            {
                int isThereAGoal = Random.Shared.Next(0, 101);

                if (isThereAGoal >= 95)
                {
                    Football_player scorer;
                    int playerToScore = Random.Shared.Next(1, 11);
                    int whichTeam = Random.Shared.Next(0, 100);

                    if (whichTeam <= 50)
                    {
                        homeTeamScore++;

                        if (Notify is not null)
                        {
                            scorer = homeTeam.playerList[playerToScore];
                            Notify(scorer, homeTeam.Name, minute, homeTeamScore);
                        }
                    }
                    else
                    {
                        awayTeamScore++;
                        
                        if (Notify is not null)
                        {
                            scorer = awayTeam.playerList[playerToScore];
                            Notify(scorer ,awayTeam.Name, minute, awayTeamScore);
                        }
                    }
                }
            }

            return (homeTeamScore, awayTeamScore);
        }
    }
}


