using System;
using System.Collections.Generic;

namespace TestProject
{
    public class GameBoard
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public Cell Apple { get; set; }

        public IList<Cell> Snake { get; set; }


        public IRandom Randomer { get; set; }


        public GameBoard()
        {
            Randomer = new Randomer();
            Snake = new List<Cell>();
            Apple = new Cell();

            Width = 24;
            Height = 24;
        }

        public bool IsSnakeEatItself()
        {
            throw new NotImplementedException();
        }

        public void Initialize()
        {
            InitialzeSnake();
            InitialzeApple();
        }

        public bool IsSnakeHitWall()
        {
            return !((Snake[0].I >= 0 && Snake[0].I < Width) &&  (Snake[0].J >= 0 && Snake[0].J < Height));
        }

        public void SnakeUp()
        {
            throw new NotImplementedException();
        }

        public void SnakeDown()
        {
            throw new NotImplementedException();
        }

        public void SnakeLeft()
        {
            throw new NotImplementedException();
        }
        public void SnakeRight()
        {
            throw new NotImplementedException();
        }


        public bool IsSnakeEatApple()
        {
            return Snake[0].OnSamePositionOf(Apple);
        }

        private void InitialzeSnake()
        {
            Snake[0].PutOn(Width / 2, Height / 2);
        }


        private void InitialzeApple()
        {
            ChangeApplePosition();
        }

        public void ChangeApplePosition()
        {
            Apple.PutOn(Randomer.Get(0, Width), Randomer.Get(0, Height));
        }
    }
}