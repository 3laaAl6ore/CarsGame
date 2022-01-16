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
    public partial class EntryWindow : Form
    {
        public EntryWindow()
        {
            InitializeComponent();
        }
        private string MyServer = "server=(local)\\SQLEXPRESS;database=collge;Integrated Security=SSPI;";
        private void btbSignUp_Click(object sender, EventArgs e)
        {
            if(txtFnameSignUP.Text !="" && txtLname.Text != "" &&  txtCity.Text != "" && txtPasswordSignUP.Text != "")
            {
                try
                {
                    SqlConnection mySqlConnection = new SqlConnection(MyServer);
                    SqlCommand mySqlCommand = mySqlConnection.CreateCommand();
                    mySqlCommand.CommandText = "insert into Player values('" + txtFnameSignUP.Text + "','" + txtLname.Text + "','" + txtCity.Text + "','" + txtPasswordSignUP.Text + "',"+0+");";
                    mySqlConnection.Open();
                    SqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                    mySqlDataReader.Close();
                    PlayerWindow P1w = new PlayerWindow(txtFnameSignUP.Text, txtLname.Text, txtCity.Text, txtPasswordSignUP.Text);
                    P1w.ShowDialog();
                    txtCity.Text = "";
                    txtFnameSignUP.Text = "";
                    txtLname.Text = "";
                    txtPasswordSignUP.Text = "";
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
            }
           else
                MessageBox.Show("fill all detalis ..! ");

        }
        private bool LogIn(string fname , string pass )
        {
            try
            {
                SqlConnection mySqlConnection = new SqlConnection(MyServer);
                SqlCommand mySqlCommand = mySqlConnection.CreateCommand();
                mySqlCommand.CommandText = " select Fname , Password from Player where Fname='"+ fname + "' and Password ='"+ pass+"';";
                mySqlConnection.Open();
                SqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();

                while (mySqlDataReader.Read())
                {
                    if (mySqlDataReader[0].ToString() == fname && mySqlDataReader[1].ToString() == pass)
                        return true;
                }
                mySqlDataReader.Close();
                txtPasswordLogIn.Text = "";
                txtFnameLogIn.Text = "";
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            return false;
        }
        private void btnLogIn_Click(object sender, EventArgs e)
        {
            if (LogIn(txtFnameLogIn.Text, txtPasswordLogIn.Text))
            {
                PlayerWindow P1w = new PlayerWindow(txtFnameLogIn.Text, txtPasswordLogIn.Text);
                P1w.ShowDialog();
            }
            else
                MessageBox.Show("invalid account");
        }
        public string Statistics(string sup)
        {
            string Statistic = "";
            try
            {
                SqlConnection mySqlConnection = new SqlConnection(MyServer);
                SqlCommand mySqlCommand = mySqlConnection.CreateCommand();
                mySqlCommand.CommandText = @" select Fname,Lname,City,Score from Player where 
                                        Fname like('" + sup + "%') order by Score desc;";
                mySqlConnection.Open();
                SqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                Statistic = "";
                while (mySqlDataReader.Read())
                {
                    Statistic += " First Name :" + mySqlDataReader[0].ToString() + "\n";
                    Statistic += " Last Name :" + mySqlDataReader[1].ToString() + "\n";
                    Statistic += " City :" + mySqlDataReader[2].ToString() + "\n";
                    Statistic += " Score :" + mySqlDataReader[3].ToString() + "\n";

                    Statistic += "-----------------------------\n";
                }
                mySqlDataReader.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            return Statistic;
        }
        public int Score(string name,int score)
        {
          //  string score = "";
            try
            {
                SqlConnection mySqlConnection = new SqlConnection(MyServer);
                SqlCommand mySqlCommand = mySqlConnection.CreateCommand();
                mySqlCommand.CommandText = "select Score from Player where Fname='"+name+"' UPDATE Player SET Score += " + score+" WHERE Fname = '"+name+"'; ";
                mySqlConnection.Open();
                SqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                while (mySqlDataReader.Read())
                {
                   score+= int.Parse(mySqlDataReader[0].ToString());
                }
                mySqlDataReader.Close();
            //    MessageBox.Show(name);

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }

            return score;
        }
        private void txtStatics_TextChanged(object sender, EventArgs e)
        {
           lstStatistics.Items.Clear();
           string[] st = { };
             st = Statistics(txtStatics.Text).Split('\n');
                foreach (string s in st)
                  lstStatistics.Items.Add(s);
            if(txtStatics.Text == "")
                lstStatistics.Items.Clear();


        }

        private void lstStatistics_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lstStatistics_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void EntryWindow_Load(object sender, EventArgs e)
        {

        }
    }
}
