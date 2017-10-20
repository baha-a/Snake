namespace TestProject
{
    public enum Diractions
    {
        Up, Down, Left, Right, None,
    }


    public class Snake
    {
        public Diractions Diraction { get; private set; }
        public int Length { get; private set;}



        public Snake()
        {
            Diraction = Diractions.None;

            Length = 1;
        }



        public void Grow()
        {
            Length++;
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


        public void Right()
        {
            if (Diraction == Diractions.Left)
                return;
            Diraction = Diractions.Right;
        }

        public void Left()
        {
            if (Diraction == Diractions.Right)
                return;
            Diraction = Diractions.Left;
        }
    }
}