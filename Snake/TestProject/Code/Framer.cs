using System;

namespace TestProject
{
    public class Framer
    {
        GameBoard board;
        Snake snake;

        public Framer()
        {
            board = new GameBoard();
            snake = new Snake();

            board.Initialize();
        }

        public void NextFrame()
        {
            if (board.IsSnakeHitWall() && board.IsSnakeEatItself())
            {
                GameOver();
            }
            else if (board.IsSnakeEatApple())
            {
                board.ChangeApplePosition();
                snake.Grow();
                EatApple();
            }
            else
            {
                switch (snake.Diraction)
                {
                    case Diractions.Up:
                        board.SnakeUp();
                        break;
                    case Diractions.Down:
                        board.SnakeDown();
                        break;
                    case Diractions.Left:
                        board.SnakeLeft();
                        break;
                    case Diractions.Right:
                        board.SnakeRight();
                        break;
                }
            }
        }

        public event Action OnSnakeEatApple;
        private void EatApple()
        {
            OnSnakeEatApple?.Invoke();
        }

        public event Action OnGameOver;
        public void GameOver()
        {
            OnGameOver?.Invoke();
        }
    }
}