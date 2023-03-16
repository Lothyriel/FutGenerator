namespace Fut.Domain
{
    public class Match
    {
        public static (Team TeamA, Team TeamB) Equalize(List<Player> bench)
        {
            var globalAverage = bench.Average(p => p.Score);
            var teams = new List<Team>() { new(), new() };

            while (bench.Any())
            {
                AddGoalKeepers(teams, bench);

                foreach (var player in bench.OrderBy(x => x.Score))
                {
                    var weakerTeam = teams.MinBy(t => t.Players.Sum(p => p.Score));

                    weakerTeam!.Add(player);

                    bench.Remove(player);
                }
            }

            return (teams.First(), teams.Last());
        }

        private static void AddGoalKeepers(List<Team> teams, List<Player> players)
        {
            foreach (var team in teams)
            {
                var goalKeeper = players.First(p => p.GoalKeeper);
                players.Remove(goalKeeper);
                team.Add(goalKeeper);
            }
        }
    }
    public class Team
    {
        public double Score => Players.Average(p => p.Score);
        public List<Player> Players { get; init; } = new();

        public void Add(Player player)
        {
            Players.Add(player);
        }
    }
}
