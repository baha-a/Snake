using System;
using System.Collections.Generic;

namespace TestProject
{
    public class World
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public Cell Apple { get; set; }
        public Snake Snake { get; set; }


        public World()
        {
            Apple = new Cell();
            Snake = new Snake();

            Width = 24;
            Height = 24;
        }

        public void Initialize()
        {
            InitialzeSnake();
            InitialzeApple();
        }

        private void InitialzeSnake()
        {
            Snake = new Snake(Width / 2, Height / 2);
        }
        private void InitialzeApple()
        {
            GenerateNewApple();
        }


        static Random r = new Random();
        public void GenerateNewApple()
        {
            Apple.PutOn(r.Next(0, Width), r.Next(0, Height));
        }
    }
}