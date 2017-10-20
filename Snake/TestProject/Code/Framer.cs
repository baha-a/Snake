using System;

namespace TestProject
{
    public class Framer
    {
        World world;
        Snake snake;

        public Framer()
        {
            world = new World();
            snake = new Snake();

            world.Initialize();
        }

        public void NextFrame()
        {
            if (snake.IsHitWall(world) && snake.IsEatItself())
            {
                gameOverEvent();
            }
            else if (snake.IsEatApple(world.Apple))
            {
                world.GenerateNewApple();
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
        public void gameOverEvent()
        {
            OnGameOver?.Invoke();
        }
    }
}