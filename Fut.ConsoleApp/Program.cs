using ConsoleTables;
using Fut.Domain;

while (true)
{
    var bench = Player.PlayerBase.Randomize();
    var (teamA, teamB) = Match.Equalize(bench);

    var table = new ConsoleTable($"Time A: {teamA.Score:#.####}", $"Time B: {teamB.Score:#.####}");
    foreach (var (playerTimeA, playerTimeB) in teamA.Players.Zip(teamB.Players))
    {
        table.AddRow($"{playerTimeA.Nome}", $"{playerTimeB.Nome}");
    }

    table.Write();
    Console.ReadKey();
}