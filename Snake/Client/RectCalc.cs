using SnakeGame;
using System.Drawing;

namespace Client
{
    public class RectCalc
    {
        public int CellWidth { get; private set; }
        public int CellHeight { get; private set; }

        public int BorderThing { get; set; }

        public RectCalc(int panalHeight, int panelWidth, int countCellInRow, int countCellInColumn)
        {
            CellHeight = panalHeight / countCellInColumn;
            CellWidth = panelWidth / countCellInRow;

            BorderThing = 1;
        }

        public Rectangle Locat(int i,int j)
        {
            return new Rectangle() {
                X = (i * CellWidth) + BorderThing,
                Y = (j * CellHeight) + BorderThing,
                Height = CellHeight - BorderThing,
                Width = CellWidth - BorderThing,
            };
        }

        public Rectangle Locat(Cell c)
        {
            return Locat(c.I, c.J);
        }
    }
}
