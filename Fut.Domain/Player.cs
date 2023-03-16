namespace Fut.Domain
{
    public record Player(string Nome, double Score, bool GoalKeeper = false)
    {
        public static List<Player> PlayerBase => new()
        {
            new("Oscar", 8.78, true),
            new("Sellzinho", 9.5, true),
            new("Daniel", 9.5),
            new("Davi", 9.5),
            new("Tuco", 8.3),
            new("Vito", 9.1),
            new("Wolff", 9.5),
            new("Celo", 9.5),
            new("Gelo", 9.28),
            new("João", 8.43),
            new("Churras", 9.35),
            new("Macas", 8.2),
            new("Emannuel", 9.38),
            new("Gabriel", 8.8)
        };
    }
}