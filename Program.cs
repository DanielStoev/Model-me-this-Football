namespace Football
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Game game = new Game();
            (Team homeTeam, Team awayTeam) = game.ReturnTeams();

            Console.WriteLine("The game between {0} and {1} starts", homeTeam.Name, awayTeam.Name );
            game.Notify = (player, team, minute, score) =>
            {
                Console.WriteLine($"{player.Name} scores in the {minute}th minute " +
                    $"making the score {score} for {team}");
            };

            (int homeScore, int awayScore) = game.Goals();

            Console.WriteLine("The final score is {0} {1} : {2} {3}"
                , homeTeam.Name, homeScore, awayScore, awayTeam.Name);

            if (homeScore == awayScore)
            {
                Console.WriteLine("It's a draw!");
            }

            else if (homeScore > awayScore)
            {
                Console.WriteLine("{0} wins with coach {1}", homeTeam.Name, homeTeam.Coach.Name);
            }

            else 
            {
                Console.WriteLine("{0} wins with coach {1}", awayTeam.Name, awayTeam.Coach.Name);
            }
        }
    }
}