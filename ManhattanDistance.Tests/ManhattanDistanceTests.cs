using System.Drawing;
using Xunit;
using FluentAssertions;

namespace ManhattanDistance.Tests
{
    public class ManhattanDistanceTests
    {
        [Theory]
        [InlineData(1,1,1,1, 0)]
        [InlineData(3,2,5,4, 4)]
        public void PointAOneOneAndPointBOneOneReturns0
            (int pointAx, int pointAy, int pointBx, int pointBy, int distance)
        {
            ManhattanDistance manhattanDistance = new(
                new Point(pointAx, pointAy),
                new Point(pointBx, pointBy)
            );
            
            manhattanDistance.Calculate().Should().Be(distance);
        }
    }
}