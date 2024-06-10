using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace crossy_road
{
    public partial class Form1 : Form
    {
        //All shapes
        Rectangle road1 = new Rectangle(0, 20, 400, 50);
        Rectangle road2 = new Rectangle(0, 120, 400, 50);
        Rectangle road3 = new Rectangle(0, 200, 400, 50);
        Rectangle road4 = new Rectangle(0, 300, 400, 50);
        Rectangle road5 = new Rectangle(0, 380, 400, 50);
        Rectangle player = new Rectangle(200, 575, 10, 20);
      

        SolidBrush redBrush = new SolidBrush(Color.Red);
        SolidBrush whiteBrush = new SolidBrush(Color.White);
        SolidBrush blackBrush = new SolidBrush(Color.Black);

        //All bools
        bool wPressed = false;
        bool aPressed = false;
        bool dPressed = false;

        int playerSpeed = 5;

        public Form1()
        {
            InitializeComponent();
        }

        public void InitializeGame()
        {
            //reset everything for start of game
            logoLabel.Image = null;
            startLabel.Image = null;
            logoLabel.BackColor = Color.Transparent;
            startLabel.BackColor = Color.Transparent;

            gameTimer.Enabled = true;

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //Key controls
            switch (e.KeyCode)
            {
                case Keys.W:
                    wPressed = true;
                    break;
                case Keys.A:
                    aPressed = true;
                    break;
                case Keys.D:
                    dPressed = true;
                    break;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            //Key controls 
            switch (e.KeyCode)
            {
                case Keys.W:
                    wPressed = false;
                    break;
                case Keys.A:
                    aPressed = false;
                    break;
                case Keys.D:
                    dPressed = false;
                    break;
              
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if (gameTimer.Enabled == true)
            {
                //draw shapes
                e.Graphics.FillRectangle(whiteBrush, player);
                e.Graphics.FillRectangle(blackBrush, road1);
                e.Graphics.FillRectangle(blackBrush, road2);
                e.Graphics.FillRectangle(blackBrush, road3);
                e.Graphics.FillRectangle(blackBrush, road4);
                e.Graphics.FillRectangle(blackBrush, road5);

            }

        }

        private void startLabel_Click(object sender, EventArgs e)
        {
           
            
                InitializeGame();
            
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            //move player 1
            if (wPressed == true)
            {
                road1.Y = road1.Y + 10;
                road2.Y = road2.Y + 10;
                road3.Y = road3.Y + 10;
                road4.Y = road4.Y + 10;
                road5.Y = road5.Y + 10;
            }
            if (aPressed == true)
            {
                player.X = player.X - playerSpeed;

              
            }
            if (dPressed == true)
            {
                player.X = player.X + playerSpeed;

            
            }
            Refresh();

        }
    }
}
