using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Threading;

//Sean Woods, Mr. T, June 20th 2024, Replica of the game Crossy Road
namespace crossy_road
{
    public partial class Form1 : Form
    {
        //All rectangles/lists
        Rectangle road1 = new Rectangle(0, 20, 400, 80);
        Rectangle road2 = new Rectangle(0, 140, 400, 160);
        Rectangle rail1 = new Rectangle(0, 350, 400, 60);
        Rectangle road4 = new Rectangle(0, 450, 400, 80);
        Rectangle road5 = new Rectangle(0, 575, 400, 80);
        Rectangle road6 = new Rectangle(0, -170, 400, 160);

        List<Rectangle> roadList = new List<Rectangle>();   

        Rectangle dash1 = new Rectangle(10, 55, 30, 10);
        Rectangle dash2 = new Rectangle(80, 55, 30, 10);
        Rectangle dash3 = new Rectangle(150, 55, 30, 10);
        Rectangle dash4 = new Rectangle(220, 55, 30, 10);
        Rectangle dash5 = new Rectangle(290, 55, 30, 10);
        Rectangle dash6 = new Rectangle(360, 55, 30, 10);
        Rectangle dash7 = new Rectangle(10, 215, 30, 10);
        Rectangle dash8 = new Rectangle(80, 215, 30, 10);
        Rectangle dash9 = new Rectangle(150, 215, 30, 10);
        Rectangle dash10 = new Rectangle(220, 215, 30, 10);
        Rectangle dash11 = new Rectangle(290, 215, 30, 10);
        Rectangle dash12 = new Rectangle(360, 215, 30, 10);
        Rectangle dash13 = new Rectangle(10, 485, 30, 10);
        Rectangle dash14 = new Rectangle(80, 485, 30, 10);
        Rectangle dash15 = new Rectangle(150, 485, 30, 10);
        Rectangle dash16 = new Rectangle(220, 485, 30, 10);
        Rectangle dash17 = new Rectangle(290, 485, 30, 10);
        Rectangle dash18 = new Rectangle(360, 485, 30, 10);
        Rectangle dash19 = new Rectangle(10, 610, 30, 10);
        Rectangle dash20 = new Rectangle(80, 610, 30, 10);
        Rectangle dash21 = new Rectangle(150, 610, 30, 10);
        Rectangle dash22 = new Rectangle(220, 610, 30, 10);
        Rectangle dash23 = new Rectangle(290, 610, 30, 10);
        Rectangle dash24 = new Rectangle(360, 610, 30, 10);
        Rectangle dash25 = new Rectangle(10, -95, 30, 10);
        Rectangle dash26 = new Rectangle(80, -95, 30, 10);
        Rectangle dash27 = new Rectangle(150, -95, 30, 10);
        Rectangle dash28 = new Rectangle(220, -95, 30, 10);
        Rectangle dash29 = new Rectangle(290, -95, 30, 10);
        Rectangle dash30 = new Rectangle(360, -95, 30, 10);

        List<Rectangle> dashList = new List<Rectangle>();

        Rectangle line1 = new Rectangle(0, 175, 400, 4);
        Rectangle line2 = new Rectangle(0, 260, 400, 4);
        Rectangle line3 = new Rectangle(0, -135, 400, 4);
        Rectangle line4 = new Rectangle(0, -50, 400, 4);

        List<Rectangle> lineList = new List<Rectangle>();

        Rectangle track1 = new Rectangle(0, 359, 400, 2);
        Rectangle track2 = new Rectangle(0, 399, 400, 2);
        Rectangle track3 = new Rectangle(40, 350, 2, 60);
        Rectangle track4 = new Rectangle(80, 350, 2, 60);
        Rectangle track5 = new Rectangle(120, 350, 2, 60);
        Rectangle track6 = new Rectangle(160, 350, 2, 60);
        Rectangle track7 = new Rectangle(200, 350, 2, 60);
        Rectangle track8= new Rectangle(240, 350, 2, 60);
        Rectangle track9 = new Rectangle(280, 350, 2, 60);
        Rectangle track10 = new Rectangle(320, 350, 2, 60);
        Rectangle track11 = new Rectangle(360, 350, 2, 60);

        List<Rectangle> trackList = new List<Rectangle>();

        Rectangle player = new Rectangle(200, 675, 10, 20);

        List<Rectangle> carList = new List<Rectangle>();
        List<int> carSpeeds = new List<int>();

        //all brushes
        SolidBrush orangeBrush = new SolidBrush(Color.Orange);
        SolidBrush whiteBrush = new SolidBrush(Color.White);
        SolidBrush blackBrush = new SolidBrush(Color.Black);
        SolidBrush greyBrush = new SolidBrush(Color.SlateGray);
        SolidBrush blueBrush = new SolidBrush(Color.Blue);
    
        //RandGen
        Random randGen = new Random();

        //All bools
        bool wPressed = false;
        bool aPressed = false;
        bool dPressed = false;

        //All ints
        int randValue = 0;
        int carSize = 12;
        int playerSpeed = 5;
        int moveMax = 10;
        int moveCount = 5;

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

            carList.Clear();
            carSpeeds.Clear();
            roadList.Clear();
            roadList.Add(road1);
            roadList.Add(road2);
            roadList.Add(rail1);
            roadList.Add(road4);
            roadList.Add(road5);
            roadList.Add(road6);

            dashList.Clear();
            dashList.Add(dash1);
            dashList.Add(dash2);
            dashList.Add(dash3);
            dashList.Add(dash4);
            dashList.Add(dash5);
            dashList.Add(dash6);
            dashList.Add(dash7);
            dashList.Add(dash8);
            dashList.Add(dash9);
            dashList.Add(dash10);
            dashList.Add(dash11);
            dashList.Add(dash12);
            dashList.Add(dash13);
            dashList.Add(dash14);
            dashList.Add(dash15);
            dashList.Add(dash16);
            dashList.Add(dash17);
            dashList.Add(dash18);
            dashList.Add(dash19);
            dashList.Add(dash20);
            dashList.Add(dash21);
            dashList.Add(dash22);
            dashList.Add(dash23);
            dashList.Add(dash24);
            dashList.Add(dash25);
            dashList.Add(dash26);
            dashList.Add(dash27);
            dashList.Add(dash28);
            dashList.Add(dash29);
            dashList.Add(dash30);

            lineList.Clear();
            lineList.Add(line1);
            lineList.Add(line2);
            lineList.Add(line3);
            lineList.Add(line4);

            trackList.Clear();
            trackList.Add(track1);
            trackList.Add(track2);
            trackList.Add(track3);
            trackList.Add(track4);
            trackList.Add(track5);
            trackList.Add(track6);
            trackList.Add(track7);
            trackList.Add(track8);
            trackList.Add(track9);
            trackList.Add(track10);
            trackList.Add(track11);



        }
        public void EndGame()
        {
            //reset everything for start of game
            logoLabel.Image = Properties.Resources.images_removebg_preview__1_;
            startLabel.Image = Properties.Resources.images_removebg_preview;
            logoLabel.BackColor = Color.Transparent;
            startLabel.BackColor = Color.Transparent;
            gameTimer.Enabled = false;    
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
                for (int i = 0; i < roadList.Count(); i++)
                {
                    e.Graphics.FillRectangle(blackBrush, roadList[i]);
                }
                for (int i = 0; i < dashList.Count(); i++)
                {
                    e.Graphics.FillRectangle(orangeBrush, dashList[i]);
                }
                for (int i = 0; i < lineList.Count(); i++)
                {
                    e.Graphics.FillRectangle(whiteBrush, lineList[i]);
                }
                for (int i = 0; i < trackList.Count(); i++)
                {
                    e.Graphics.FillRectangle(greyBrush, trackList[i]);
                }
       
                e.Graphics.FillRectangle(blueBrush, player);

                for (int i = 0; i < carList.Count(); i++)
                {
                    e.Graphics.FillEllipse(whiteBrush, carList[i]);                 
                }            
            }
        }

        private void startLabel_Click(object sender, EventArgs e)
        {
            SoundPlayer player2 = new SoundPlayer(Properties.Resources.bottonClick);
            player2.Play();
            InitializeGame();            
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            //move balls across the screen
            for (int i = 0; i < carList.Count(); i++)
            {
                //get new position of y
                int x = carList[i].X + carSpeeds[i];

                //update the ball object
                carList[i] = new Rectangle(x, carList[i].Y, carSize, carSize);
            }

            randValue = randGen.Next(1, 100);

            //spawn balls on left side
            if (randValue < 3)
            {
                Rectangle car = new Rectangle(0, roadList[0].Y + 15, carSize, carSize);
                carList.Add(car);
                carSpeeds.Add(randGen.Next(4, 8));
            }
            //spawn balls on right side                  
            if (randValue > 25 && randValue <= 28)
            {
                Rectangle car = new Rectangle(400, roadList[0].Y + 60, carSize, carSize);
                carList.Add(car);
                carSpeeds.Add(randGen.Next(-8, -4));
            }
            //spawn balls on left side
            if (randValue > 5 && randValue <= 8)
            {
                Rectangle car = new Rectangle(0, roadList[1].Y + 15, carSize, carSize);
                carList.Add(car);
                carSpeeds.Add(randGen.Next(4, 8));
            }
            //spawn balls on left side                  
            if (randValue > 60 && randValue <= 63)
            {
                Rectangle car = new Rectangle(0, roadList[1].Y + 55, carSize, carSize);
                carList.Add(car);
                carSpeeds.Add(randGen.Next(4, 8));
            }
            //spawn balls on right side                  
            if (randValue > 55 && randValue <= 58)
            {
                Rectangle car = new Rectangle(400, roadList[1].Y + 95, carSize, carSize);
                carList.Add(car);
                carSpeeds.Add(randGen.Next(-8, -4));
            }
            //spawn balls on right side                  
            if (randValue > 50 && randValue <= 53)
            {
                Rectangle car = new Rectangle(400, roadList[1].Y + 145, carSize, carSize);
                carList.Add(car);
                carSpeeds.Add(randGen.Next(-8, -4));
            }
            //spawn balls on right side                  
            if (randValue > 60 && randValue <= 63)
            {
                Rectangle car = new Rectangle(400, roadList[2].Y + 25, carSize, carSize);
                carList.Add(car);
                carSpeeds.Add(randGen.Next(-8, -4));
            }
            //spawn balls on left side
            if (randValue > 10 && randValue <= 13)
            {
                Rectangle car = new Rectangle(0, roadList[3].Y + 15, carSize, carSize);
                carList.Add(car);
                carSpeeds.Add(randGen.Next(4, 8));
            }
            //spawn balls on right side                  
            if (randValue > 35 && randValue <= 38)
            {
                Rectangle car = new Rectangle(400, roadList[3].Y + 60, carSize, carSize);
                carList.Add(car);
                carSpeeds.Add(randGen.Next(-8, -4));
            }
            //spawn balls on left side
            if (randValue > 15 && randValue <= 18)
            {
                Rectangle ball = new Rectangle(0, roadList[4].Y + 15, carSize, carSize);
                carList.Add(ball);
                carSpeeds.Add(randGen.Next(4, 8));
            }
            //spawn balls on right side                  
            if (randValue > 40 && randValue <= 43)
            {
                Rectangle car = new Rectangle(400, roadList[4].Y + 60, carSize, carSize);
                carList.Add(car);
                carSpeeds.Add(randGen.Next(-8, -4));
            }
            //spawn balls on left side
            if (randValue > 20 && randValue <= 23)
            {
                Rectangle car = new Rectangle(0, roadList[5].Y + 15, carSize, carSize);
                carList.Add(car);
                carSpeeds.Add(randGen.Next(4, 8));
            }
            //spawn balls on right side                  
            if (randValue > 45 && randValue <= 48)
            {
                Rectangle car = new Rectangle(400, roadList[5].Y + 60, carSize, carSize);
                carList.Add(car);
                carSpeeds.Add(randGen.Next(-8, -4));
            }
            //Remove balls that are off screen
            for (int i = 0; i < carList.Count(); i++)
            {
                if (carList[i].X > 400)
                {
                    carList.RemoveAt(i);
                    carSpeeds.RemoveAt(i);
                }
            }
            for (int i = 0; i < carList.Count(); i++)
            {
                if (carList[i].Y > 700)
                {
                    carList.RemoveAt(i);
                    carSpeeds.RemoveAt(i);
                }
            }
            //Check to see if cars have hit player
            for (int i = 0; i < carList.Count(); i++)
            {
                if (carList[i].IntersectsWith(player))
                {
                    SoundPlayer player = new SoundPlayer(Properties.Resources.crash);
                    player.Play();
                    Thread.Sleep(1000);
                    EndGame();
                }
            }
            //Jumping motion
            moveCount--;
            if (wPressed == true && moveCount <= 0)
            {
                //Moving everything towards player when player moves
                for (int i = 0; i < roadList.Count(); i++)
                {
                    int y = roadList[i].Y + 20;
                    roadList[i] = new Rectangle(roadList[i].X, y, roadList[i].Width, roadList[i].Height);
                }
                for (int i = 0; i < dashList.Count(); i++)
                {
                    int y = dashList[i].Y + 20;
                    dashList[i] = new Rectangle(dashList[i].X, y, dashList[i].Width, dashList[i].Height);
                }
                for (int i = 0; i < lineList.Count(); i++)
                {
                    int y = lineList[i].Y + 20;
                    lineList[i] = new Rectangle(lineList[i].X, y, lineList[i].Width, lineList[i].Height);
                }
                for (int i = 0; i < trackList.Count(); i++)
                {
                    int y = trackList[i].Y + 20;
                    trackList[i] = new Rectangle(trackList[i].X, y, trackList[i].Width, trackList[i].Height);
                }
                for (int i = 0; i < carList.Count(); i++)
                {
                    int y = carList[i].Y + 20;

                    carList[i] = new Rectangle(carList[i].X, y, carSize, carSize);

                }
                moveCount = moveMax;

            }
            //Respawning roads when they hit the bottom
            if (roadList[4].Y >= 700)
            {
                roadList[4] = new Rectangle(roadList[4].X, -170, roadList[4].Width, roadList[4].Height); ;
                for (int i = 18; i < 24; i++)
                {                
                    dashList[i] = new Rectangle(dashList[i].X, -135, dashList[i].Width, dashList[i].Height);
                }
            }
            if (roadList[3].Y >= 700)
            {
                roadList[3] = new Rectangle(roadList[3].X, -170, roadList[3].Width, roadList[3].Height); ;
                for (int i = 12; i < 17; i++)
                {            
                    dashList[i] = new Rectangle(dashList[i].X, -135, dashList[i].Width, dashList[i].Height);
                }           
            }
            if (roadList[2].Y >= 700)
            {
                roadList[2] = new Rectangle(roadList[2].X, -170, roadList[2].Width, roadList[2].Height); ;
                for (int i = 0; i < 10; i++)
                {
                    trackList[i] = new Rectangle(trackList[i].X, -170, trackList[i].Width, trackList[i].Height);
                }
            }
            if (roadList[1].Y >= 700)
            {
                roadList[1] = new Rectangle(roadList[1].X, -170, roadList[1].Width, roadList[1].Height); ;
                for (int i = 6; i < 11; i++)
                {
                    dashList[i] = new Rectangle(dashList[i].X, -95, dashList[i].Width, dashList[i].Height);
                }
                for (int i = 0; i < 1; i++)
                {
                    lineList[i] = new Rectangle(lineList[i].X, -50, lineList[i].Width, lineList[i].Height);
                    lineList[i] = new Rectangle(lineList[i].X, -135, lineList[i].Width, lineList[i].Height);
                }
            }
            if (roadList[5].Y >= 700)
            {
                roadList[1] = new Rectangle(roadList[1].X, -170, roadList[1].Width, roadList[1].Height); ;
                for (int i = 24; i < 29; i++)
                {
                    dashList[i] = new Rectangle(dashList[i].X, -95, dashList[i].Width, dashList[i].Height);
                }
                for (int i = 2; i < 3; i++)
                {
                    lineList[i] = new Rectangle(lineList[i].X, -50, lineList[i].Width, lineList[i].Height);
                    lineList[i] = new Rectangle(lineList[i].X, -135, lineList[i].Width, lineList[i].Height);
                }
            }
            if (roadList[0].Y >= 700)
            {
                roadList[1] = new Rectangle(roadList[1].X, -170, roadList[1].Width, roadList[1].Height); ;

                for (int i = 0; i < 5; i++)
                {
                    dashList[i] = new Rectangle(dashList[i].X, -135, dashList[i].Width, dashList[i].Height);
                }
            }
            //MOve player side to side
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
