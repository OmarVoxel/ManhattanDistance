using System.Drawing;
using Xunit;
using FluentAssertions;

namespace ManhattanDistance.Tests
{
    public class ManhattanDistanceTests
    {
        [Fact]
        public void PointAOneOneAndPointBOneOneReturns0()
        {
            ManhattanDistance manhattanDistance = new(
                new Point(1, 1),
                new Point(1, 1)
            );

            manhattanDistance.Calculate().Should().Be(0);
        }
    }
}