using FluentAssertions;
using Fut.Domain;

namespace Fut.Test
{
    public class Tests
    {
        [Test]
        public void Test1()
        {
            var banco = Player.PlayerBase.Randomize();

            var (teamA, teamB) = Match.Equalize(banco);

            teamA.Score.Should().BeApproximately(teamB.Score, 0.3);
        }
    }
}