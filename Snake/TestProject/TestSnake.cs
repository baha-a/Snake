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
        public void Snake_GrowByNine_LengthTenCells()
        {
            for (int i = 1; i <= 9; i++)
                snake.Grow();
            Assert.AreEqual(snake.Length, 10);
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


        [TestMethod]
        public void Snake_IsHitWall()
        {
            var b = new World() { Width = 10, Height = 10 };
            PutSnakeInPositions(0, 0);
            Assert.IsFalse(snake.IsHitWall(b));

            PutSnakeInPositions(-1, -1);
            Assert.IsTrue(snake.IsHitWall(b));

            PutSnakeInPositions(b.Width, b.Height);
            Assert.IsTrue(snake.IsHitWall(b));
        }

        private void PutSnakeInPositions(int V, int V1)
        {
            snake.Head.I = V;
            snake.Head.J = V1;
        }


        [TestMethod]
        public void Snake_SnakeEatApple()
        {
            var apple = new Cell() { I = 0, J = 2 };

            PutSnakeInPositions(0, 0);
            Assert.IsFalse(snake.IsEatApple(apple));

            PutSnakeInPositions(0, 2);
            Assert.IsTrue(snake.IsEatApple(apple));
        }



        [TestMethod]
        public void Snake_OneLengthSnakeDoseNotEatItself()
        {
            Assert.IsFalse(snake.IsEatItself());
        }


        [TestMethod]
        public void Snake_ThreeLengthSnakeMoveCorrectly()
        {
            snake.Grow();
            snake.Grow();

            snake.Up();
            snake.MoveOneStep();
            Assert.IsTrue(snake.Head.OnSamePositionOf(new Cell(0,-1)));
            snake.Right();
            snake.MoveOneStep();
            Assert.IsTrue(snake.Head.OnSamePositionOf(new Cell(1, -1)));
            snake.Down();
            snake.MoveOneStep();
            Assert.IsTrue(snake.Head.OnSamePositionOf(new Cell(1, 0)));
            snake.Left();
            snake.MoveOneStep();
            Assert.IsTrue(snake.Head.OnSamePositionOf(new Cell(0, 0)));
        }

        [TestMethod]
        public void Snake_ThreeLengthSnakeDoseNotEatItself()
        {
            snake.Grow();
            snake.Grow();

            snake.Up();
            snake.MoveOneStep();
            snake.Right();
            snake.MoveOneStep();
            snake.Down();
            snake.MoveOneStep();
            snake.Left();
            snake.MoveOneStep();
            Assert.IsFalse(snake.IsEatItself());
        }


        [TestMethod]
        public void Snake_FourLengthSnakeDoseNotEatItself()
        {
            snake.Grow();
            snake.Grow();
            snake.Grow();

            snake.Up();
            snake.MoveOneStep();
            snake.Right();
            snake.MoveOneStep();
            snake.Down();
            snake.MoveOneStep();
            snake.Left();
            snake.MoveOneStep();
            Assert.IsFalse(snake.IsEatItself());
        }

        [TestMethod]
        public void Snake_FiveLengthSnakeEatItself()
        {
            snake.Grow();
            snake.Grow();
            snake.Grow();
            snake.Grow();

            snake.Up();
            snake.MoveOneStep();
            snake.Right();
            snake.MoveOneStep();
            snake.Down();
            snake.MoveOneStep();
            snake.Left();
            snake.MoveOneStep();
            Assert.IsTrue(snake.IsEatItself());
        }
    }
}
