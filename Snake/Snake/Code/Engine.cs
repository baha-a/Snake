using System;

namespace SnakeGame
{
    public class Engine
    {
        public int Width { get; set; }
        public int Height { get; set; }

        Cell apple;

        Snake snake;


        public Engine()
        {
            Width = 24;
            Height = 24;

            Setup();
        }

        public void Setup()
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
            if (snake.IsHitWall(Width,Height) && snake.IsEatItself())
            {
                gameOverEvent();
            }
            else if (snake.IsEatApple(apple))
            {
                GetNewApple();
                snake.Grow();
                eatAppleEvent();
            }
            else
            {
                snake.MoveOneStep();
            }
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
    }
}