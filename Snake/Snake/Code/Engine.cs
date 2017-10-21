using System;

namespace SnakeGame
{
    public class Engine
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public Diractions SnakeDiraction { get { return snake.Diraction; } }
        public int SnakeLength { get { return snake.Length; } }

        public Cell AppleLocation { get { return apple; } }
        public Cell SnakeLocation { get { return snake.Head; } }


        public void ForeachSnakeCell(Action<Cell> callback)
        {
            foreach (var c in snake)
                callback(c);
        }


        Cell apple;

        Snake snake;


        public Engine(int width = 24, int height = 24)
        {
            Width = width;
            Height = height;

            SetupNewGame();
        }

        public void SetupNewGame()
        {
            snake = getCenter();
            GetNewApple();
        }

        public void GetNewApple()
        {
            apple = getRandomCell();
        }


        private Snake getCenter()
        {
            return new Snake(Width / 2, Height / 2);
        }

        private static Random r = new Random();
        private Cell getRandomCell()
        {
            return new Cell(r.Next(0, Width), r.Next(0, Height));
        }


        public void NextFrame()
        {
            if (snake.IsHitWall(Width, Height) || snake.IsEatItself())
            {
                gameOverEvent();
            }
            else
            {
                if (snake.IsEatApple(apple))
                {
                    GetNewApple();
                    snake.Grow();
                    eatAppleEvent();
                }
                snake.MoveOneStep();
            }
        }

        public void SnakeGrow()
        {
            snake.Grow();
        }


        public event Action OnSnakeEatApple;
        private void eatAppleEvent()
        {
            OnSnakeEatApple?.Invoke();
        }

        public event Action OnGameOver;
        private void gameOverEvent()
        {
            OnGameOver?.Invoke();
        }



        public void Up()
        {
            snake.Up();
        }
        public void Right()
        {
            snake.Right();
        }
        public void Left()
        {
            snake.Left();
        }
        public void Down()
        {
            snake.Down();
        }
    }
}