using SnakeGame;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class SnakeWindowsFormClient : Form
    {
        Engine engino;
        Timer timer;

        public SnakeWindowsFormClient()
        {
            InitializeComponent();

            engino = new Engine() { Height = 20, Width = 20 };
            engino.OnGameOver += Engino_OnGameOver;
            engino.OnSnakeEatApple += Engino_OnSnakeEatApple;
            engino.SetupNewGame();


            timer = new Timer();
            timer.Tick += T_Tick;
            timer.Interval = 1000;
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            engino.SetupNewGame();
            btnStart.Text = "Start";
            if(timer.Enabled)
                timer.Stop();
            getGameStatus();
        }

        private void T_Tick(object sender, EventArgs e)
        {
            engino.NextFrame();
            getGameStatus();

            drawGameGraphicaly();
        }

        private void drawGameGraphicaly()
        {
            panel.CreateGraphics();
        }

        private void getGameStatus()
        {
            notify("Snake go " + engino.SnakeDiraction + " - " + engino.SnakeLength + " length - \r\n"
                + engino.SnakeLocation + ", apple(" + engino.AppleLocation + ")");
        }

        private void Engino_OnSnakeEatApple()
        {
            Console.Beep();
            notify("Snake Ate an Apple");
        }

        private void Engino_OnGameOver()
        {
            timer.Stop();
            notify("Game over, You Loser");
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (timer.Enabled)
            {
                ((Button)sender).Text = "Start";
                timer.Stop();

                notify("Game Stoped");
            }
            else
            {
                ((Button)sender).Text = "Pause";
                timer.Interval = (int)nudInterval.Value;
                timer.Start();

                notify("Game Started");
            }
        }

        private void nudInterval_ValueChanged(object sender, EventArgs e)
        {
            timer.Interval = (int)nudInterval.Value;

            notify("Game interval changed to " + timer.Interval);
        }

        private void notify(string v)
        {
            lblStatue.Text = v;
        }

        private void nudWidth_ValueChanged(object sender, EventArgs e)
        {
            engino.Width = (int)nudWidth.Value;
            notify("Width set to "+ nudWidth.Value);
        }

        private void nudHeight_ValueChanged(object sender, EventArgs e)
        {
            engino.Height = (int)nudHeight.Value;
            notify("Height set to " + nudHeight.Value);
        }


        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (handleKeyDown(keyData))
                return true;
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private bool handleKeyDown(Keys keyCode)
        {
            if (keyCode == Keys.Up)
                engino.Up();
            else if (keyCode == Keys.Down)
                engino.Down();
            else if (keyCode == Keys.Left)
                engino.Left();
            else if (keyCode == Keys.Right)
                engino.Right();

            return (keyCode == Keys.Up || keyCode == Keys.Down || keyCode == Keys.Left || keyCode == Keys.Right);
        }
    }
}
