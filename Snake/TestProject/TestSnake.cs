using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject
{
    [TestClass]
    public class TestSnake
    {
        Snake snake;

        [TestInitialize]
        public void Setup()
        {
            snake = new Snake();
        }

        [TestMethod]
        public void Snake_StartWithNoDiraaction()
        {
            Assert.AreEqual(snake.Diraction, Diractions.None);
        }

        [TestMethod]
        public void Snake_StartWithOneCellLength()
        {
            Assert.AreEqual(snake.Length, 1);
        }


        [TestMethod]
        public void Snake_GrowByOne_LengthTwoCells()
        {
            snake.Grow();
            Assert.AreEqual(snake.Length, 2);
        }


        [TestMethod]
        public void Snake_MoveUp()
        {
            snake.Up();

            Assert.AreEqual(snake.Diraction, Diractions.Up);
        }

        [TestMethod]
        public void Snake_MoveDown()
        {
            snake.Down();

            Assert.AreEqual(snake.Diraction, Diractions.Down);
        }

        [TestMethod]
        public void Snake_MoveLeft()
        {
            snake.Left();

            Assert.AreEqual(snake.Diraction, Diractions.Left);
        }

        [TestMethod]
        public void Snake_MoveRight()
        {
            snake.Right();

            Assert.AreEqual(snake.Diraction, Diractions.Right);
        }

        [TestMethod]
        public void Snake_MoveUpThenDown()
        {
            snake.Up();
            snake.Down();

            Assert.AreEqual(snake.Diraction, Diractions.Up);
        }

        [TestMethod]
        public void Snake_MoveDownThenUp()
        {
            snake.Down();
            snake.Up();

            Assert.AreEqual(snake.Diraction, Diractions.Down);
        }


        [TestMethod]
        public void Snake_MoveLeftThenRight()
        {
            snake.Left();
            snake.Right();

            Assert.AreEqual(snake.Diraction, Diractions.Left);
        }

        [TestMethod]
        public void Snake_MoveRightThenLeft()
        {
            snake.Right();
            snake.Left();

            Assert.AreEqual(snake.Diraction, Diractions.Right);
        }

        [TestMethod]
        public void Snake_MoveUpThenLeftThenDowntThenRightTheUp()
        {
            snake.Up();
            Assert.AreEqual(snake.Diraction, Diractions.Up);

            snake.Left();
            Assert.AreEqual(snake.Diraction, Diractions.Left);

            snake.Down();
            Assert.AreEqual(snake.Diraction, Diractions.Down);

            snake.Right();
            Assert.AreEqual(snake.Diraction, Diractions.Right);

            snake.Up();
            Assert.AreEqual(snake.Diraction, Diractions.Up);
        }
    }
}
