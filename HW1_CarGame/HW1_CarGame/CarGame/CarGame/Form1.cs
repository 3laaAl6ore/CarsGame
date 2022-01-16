using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CarGame
{
    public partial class TheRace : Form
    {
        public TheRace()
        {
            InitializeComponent();
        }
        enum Dir { Left,Right,none,up,Dawn}
        public  int sped = 5 ,score=0;
        private int car;
        private string PlayerName ;
        public int GetScore() => this.score;
        Random rnd = new Random();
        Dir dir = Dir.none;
        EntryWindow en = new EntryWindow();
        public TheRace(string player )
        {
            InitializeComponent();
            this.PlayerName = player;
            lblPlayer.Text = "Player : "+this.PlayerName;
           // MessageBox.Show(this.PlayerName);

        }
        private void MakeRoad()
        {
            L1.Top += sped;
            if (L1.Top > panelGame.Height) L1.Top = -L1.Height;
            L2.Top += sped;
            if (L2.Top > panelGame.Height) L2.Top = -L2.Height;
            L3.Top += sped;
            if (L3.Top > panelGame.Height) L3.Top = -L3.Height;
            L4.Top += sped;
            if (L4.Top > panelGame.Height) L4.Top = -L4.Height;
            L5.Top += sped;
            if (L5.Top > panelGame.Height) L5.Top = -L5.Height;
            L6.Top += sped;
            if (L6.Top > panelGame.Height) L6.Top = -L6.Height;
        }
        private void Car1back()
        {

            Car1.Visible = false;
            Car1.Top = -Car1.Height;
            Car1.Left = rnd.Next((panelGame.Width - player.Width) / 2);
            car = rnd.Next(1, 6);
            if (car == 1) Car1.Image = Properties.Resources.car1;
            else if (car == 2) Car1.Image = Properties.Resources.car2;
            else if (car == 3) Car1.Image = Properties.Resources.car3;
            else if (car == 4) Car1.Image = Properties.Resources.car4;
            else Car1.Image = Properties.Resources.car5;
            Car1.Visible = true;

        }
        private void Car2back() 
        {
            Car2.Visible = false;
            Car2.Top = -Car2.Height;
            Car2.Left = rnd.Next(panelGame.Width / 2, panelGame.Width - player.Width);
            car = rnd.Next(1, 5);
            if (car == 1) Car2.Image = Properties.Resources.car1;
            else if (car == 2) Car2.Image = Properties.Resources.car2;
            else if (car == 3) Car2.Image = Properties.Resources.car3;
            else if (car == 4) Car2.Image = Properties.Resources.car4;
            else Car2.Image = Properties.Resources.car5;
            Car2.Visible = true;

        }
        private void Directions()
        {
            if (dir == Dir.Left && player.Left > 0)
                player.Left -= sped * 2;
            if (dir == Dir.Right && player.Left < panelGame.Width - player.Width)
                player.Left += sped * 2;
            if (dir == Dir.up && player.Top > 0)
                player.Top -= sped;
            if (dir == Dir.Dawn && player.Top < panelGame.Height - player.Height)
                player.Top += sped * 2;
        }
        private void Crash()
        {
            if (player.Bounds.IntersectsWith(Car1.Bounds) || player.Bounds.IntersectsWith(Car2.Bounds))
            {
                timerAction.Enabled = false;
                GameEnd.Text = "Game Over :(\n"+"+"+(score+1);
                GameEnd.ForeColor = Color.Red;
                en.Score(this.PlayerName, this.score);
                GameEnd.Visible = true;
            }
        }
        private void Score()
        {
            score++;
            labelScore.Text = "Score: " + score;
            if (score == 1000) sped++;
            if (score == 2000) sped++;
            if (score == 3000) sped++;
            if (score == 4000) sped++;
            if (score == 5000)
            {
                GameEnd.Text = "YOU WIN :)";
                timerAction.Enabled = false;
                en.Score(this.PlayerName, this.score);
                GameEnd.Visible = true;
            }

        }
        public int SetScore()
        {
            return en.Score(this.PlayerName, this.score);
        }
        private void timerAction_Tick(object sender, EventArgs e)
        {

            MakeRoad();

            if (Car1.Visible) Car1.Top += sped;
            if (Car1.Top > panelGame.Height)
                Car1back();

            if (Car2.Visible) Car2.Top += sped;
            if (Car2.Top > panelGame.Height)
                Car2back();

            Directions();

            Crash();

            Score();

        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Left)
                dir = Dir.Left;
            else if (e.KeyData == Keys.Right)
                dir = Dir.Right;
            else if (e.KeyData == Keys.Up)
                dir = Dir.up;
            else if (e.KeyData == Keys.Down)
                dir = Dir.Dawn;
            else dir = Dir.none;


            if (GameEnd.Visible == true)
                if (e.KeyData == Keys.Space)
                    ReStartGame();
        }
        private void ReStartGame()
        {
            GameEnd.Visible = false;
            player.Left = panelGame.Width / 2;
            Car1.Left = 0;
            Car2.Left = panelGame.Width - Car2.Width;
            sped = 5;
            score = 0;
            timerAction.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panelGame_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblPlayer_Click(object sender, EventArgs e)
        {

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            dir = Dir.none;
        }
    }
}
