using System;
using System.Collections.Generic;

namespace TestProject
{
    public enum Diractions
    {
        Up, Down, Left, Right, None,
    }


    public class Snake
    {
        public Diractions Diraction { get; private set; }
        public int Length { get { return HeadWithTale.Count;  } }

        List<Cell> HeadWithTale { get; set; }

        public bool IsHitWall(World world)
        {
            return !(Head.I >= 0 && Head.I < world.Width && Head.J >= 0 && Head.J < world.Height);
        }

        public Cell Head { get; private set; }


        public Snake() : this(0, 0) { }

        public Snake(int i,int j)
        {
            Diraction = Diractions.None;

            HeadWithTale = new List<Cell> { (Head = new Cell() { I = i, J = j }) };
        }


        public void Grow()
        {
            HeadWithTale.Add(Head = new Cell() { I = Head.I, J = Head.J });
        }


        public void Up()
        {
            if (Diraction == Diractions.Down)
                return;
            Diraction = Diractions.Up;
        }

        public void Down()
        {
            if (Diraction == Diractions.Up)
                return;
            Diraction = Diractions.Down;
        }

        public void Left()
        {
            if (Diraction == Diractions.Right)
                return;
            Diraction = Diractions.Left;
        }

        public void Right()
        {
            if (Diraction == Diractions.Left)
                return;
            Diraction = Diractions.Right;
        }

        public void MoveOneStep()
        {
            switch (Diraction)
            {
                case Diractions.Up   : moveSnake(Head.I, Head.J - 1); break;
                case Diractions.Down : moveSnake(Head.I, Head.J + 1); break;
                case Diractions.Left : moveSnake(Head.I - 1, Head.J); break;
                case Diractions.Right: moveSnake(Head.I + 1, Head.J); break;
            }
        }

        private void moveSnake(int i, int j)
        {
            HeadWithTale[Length - 1].PutOn(i, j);
            Head = HeadWithTale[Length - 1];
        }


        public bool IsEatApple(Cell apple)
        {
            return Head.OnSamePositionOf(apple);
        }


        public bool IsEatItself()
        {
            foreach (var s in HeadWithTale)
            {
                if (Head != s)
                    if (Head.OnSamePositionOf(s))
                        return true;
            }
            return false;
        }
    }
}