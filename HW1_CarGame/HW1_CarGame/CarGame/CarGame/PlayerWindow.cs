using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarGame
{
    public partial class PlayerWindow : Form
    {
        public PlayerWindow()
        {
            InitializeComponent();
        }
        EntryWindow en = new EntryWindow();
        TheRace p = new TheRace();

        private string _fname;
        private string _lname;
        private string _city;
        private string _password;
        public PlayerWindow(string fn , string ln , string c , string pass)
        {
            this._fname = fn;
            this._lname = ln;
            this._city = c;
            this._password = pass;
            InitializeComponent();
        }
        public PlayerWindow(string fn,  string pass)
        {
            this._fname = fn;
            this._password = pass;
            InitializeComponent();
        }
        private void btnNewGame_Click(object sender, EventArgs e)
        {
            p = new TheRace(this._fname);
            p.ShowDialog();
        }
    
        private void PlayerWindow_Load(object sender, EventArgs e)
        {
            p = new TheRace(this._fname);
            lblTitle.Text += this._fname;
            lblScore.Text +=en.Score(_fname,0);
        }

        private void txtStatics_TextChanged(object sender, EventArgs e)
        {
            lstStatistics.Items.Clear();
            string[] st = { };
            st = en.Statistics(txtStatics.Text).Split('\n');
            foreach (string s in st)
                lstStatistics.Items.Add(s);
            if (txtStatics.Text == "")
                lstStatistics.Items.Clear();
        }


        private void PlayerWindow_MouseHover(object sender, EventArgs e)
        {
            lblScore.Text = "Your Total Score is :";
            lblScore.Text += en.Score(_fname, 0);
       //     n1.Text = 

        }

        
    }
}
