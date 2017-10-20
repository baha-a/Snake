using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject
{
    [TestClass]
    public class TestGrid
    {
        GameBoard grid;

        [TestInitialize]
        public void Setup()
        {
            grid = new GameBoard();
        }

        [TestMethod]
        public void Grid_IsSnakeHitWall()
        {
            grid.Snake.I = 0;
            grid.Snake.J = 0;

             Assert.IsFalse(grid.IsSnakeHitWall());

            grid.Snake.I = -1;
            grid.Snake.J = -1;

            Assert.IsTrue(grid.IsSnakeHitWall());

            grid.Snake.I = grid.Width;
            grid.Snake.J = grid.Height;

            Assert.IsTrue(grid.IsSnakeHitWall());
        }

        [TestMethod]
        public void Grid_SnakeEatApple()
        {
            grid.Snake.I = 0;
            grid.Snake.J = 0;

            grid.Apple.I = 0;
            grid.Apple.J = 2;

            Assert.IsFalse(grid.IsSnakeEatApple());


            grid.Snake.J = 2;

            Assert.IsTrue(grid.IsSnakeEatApple());
        }

    }
}
