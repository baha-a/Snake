namespace TestProject
{
    public class Cell
    {
        public Cell() : this(0, 0) { }
        public Cell(int i,int j)
        {
            I = i;
            J = j;
        }
        public int I { get; set; }
        public int J { get; set; }


        public void PutOn(int i, int j)
        {
            I = i;
            J = j;
        }

        public bool OnSamePositionOf(Cell x)
        {
            return (x.I == I && x.J == J);
        }
    }
}