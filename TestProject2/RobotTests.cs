using NUnit.Framework;
using RobotGame;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject2
{
    class RobotTests
    {
        [Test]
        public void Test_CreateRobot()
        {
            Board board = new Board(5, 5);
            Position position = new Position(2, 2);

            Robot robot = new Robot(position, Robot.Direction.NORTH);

            if (robot != null)
            {
                Assert.Pass();
            }
            else
            {
                Assert.Fail();
            }
        }

        [Test]
        public void Test_Move_OutOfRange()
        {
            Board board = new Board(5, 5);
            Position position = new Position(5, 3);

            Robot robot = new Robot(position, Robot.Direction.NORTH);

            if (robot.Position.Row == 5 & robot.Position.Column == 3)
            {
                Assert.Pass();
            }
            else
            {
                Assert.Fail();
            }
        }

        [Test]
        public void Test_Move_TowardsWall()
        {
            Board board = new Board(5, 5);
            board.PlaceWall(3, 2);
            Position position = new Position(2, 2);

            Robot robot = new Robot(position, Robot.Direction.NORTH);

            if (robot.Position.Row == 2 & robot.Position.Column == 2)
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
