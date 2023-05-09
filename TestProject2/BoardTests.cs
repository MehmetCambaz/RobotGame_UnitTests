using NUnit.Framework;
using RobotGame;
using System.Linq;

namespace TestProject2
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test_isCoordinateValid()
        {
            Board board = new Board(5,5);
            Assert.AreEqual(board.isCoordinateValid(1, 1), true);
        }
        [Test]
        public void Test_isCoordinateValid_OutOfBound()
        {
            Board board = new Board(5, 5);

            Assert.AreEqual(board.isCoordinateValid(10, 10), false);
        }

        [Test]
        public void Test_PlaceWall()
        {
            Board board = new Board(5, 5);
            board.PlaceWall(2, 3);

            var wall = board.WallList.FirstOrDefault(o => o.Row == 2 & o.Column == 3);

            if (wall != null)
            {
                Assert.Pass();
            }
            else
            {
                Assert.Fail();
            }
        }

        [Test]
        public void Test_PlaceWall_InvalidCoordinates()
        {
            Board board = new Board(5, 5);
            board.PlaceWall(7, 9);

            var wall = board.WallList.FirstOrDefault(o => o.Row == 7 & o.Column == 9);

            if (wall == null)
            {
                Assert.Pass();
            }
            else
            {
                Assert.Fail();
            }
        }
    }
}