using System;
using System.Collections;
using System.Collections.Generic;


namespace SnakeGame
{
    public class Snake : IEnumerable<Cell>
    {
        public Diractions Diraction { get; private set; }

        LinkedList<Cell> HeadWithTale { get; set; }

        public int Length { get { return HeadWithTale.Count;  } }

        public Cell Head { get { return HeadWithTale.First.Value; } }

        bool Locked = false;


        public Snake() : this(0, 0) { }

        public Snake(int i, int j)
        {
            Diraction = Diractions.None;

            HeadWithTale = new LinkedList<Cell>();
            HeadWithTale.AddFirst(new Cell(i, j));
        }


        public void Grow()
        {
            var t = HeadWithTale.Last.Value;
            HeadWithTale.AddLast(new Cell(t.I + 1000, t.J + 1000));
        }


        public void Up()
        {
            if (Locked)
                return;
            Locked = true;

            if (Diraction == Diractions.Down)
                return;
            Diraction = Diractions.Up;
        }

        public void Down()
        {
            if (Locked)
                return;
            Locked = true;

            if (Diraction == Diractions.Up)
                return;
            Diraction = Diractions.Down;
        }

        public void Left()
        {
            if (Locked)
                return;
            Locked = true;

            if (Diraction == Diractions.Right)
                return;
            Diraction = Diractions.Left;
        }

        public void Right()
        {
            if (Locked)
                return;
            Locked = true;

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

            Locked = false;
        }

        private void moveSnake(int i, int j)
        {
            HeadWithTale.AddFirst(new Cell(i, j));
            HeadWithTale.RemoveLast();
        }


        public bool IsHitWall(int width, int height)
        {
            return !((Head.I >= 0 && Head.I < width ) && (Head.J >= 0 && Head.J < height));
        }

        public bool IsEatApple(Cell apple)
        {
            return Head.OnSamePositionOf(apple);
        }

        public bool IsEatItself()
        {
            foreach (var s in HeadWithTale)
                if (Head != s && Head.OnSamePositionOf(s))
                        return true;
            return false;
        }

        public IEnumerator<Cell> GetEnumerator()
        {
            return HeadWithTale.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return HeadWithTale.GetEnumerator();
        }
    }
}