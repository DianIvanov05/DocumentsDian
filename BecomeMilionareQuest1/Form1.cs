using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BecomeMilionareQuest1
{
    public partial class Form1 : Form
    {
        //1.Connect
        string constr = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\StaniBogat11D.mdf;Integrated Security=True;Connect Timeout=30";
        SqlConnection connectToDb;
        //command
        SqlCommand command;
        //Reader
        SqlDataReader reader;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connectToDb = new SqlConnection(constr);
            connectToDb.Open();
            MessageBox.Show("Ok!");
            string querry = "Select * from Questions";
            command = new SqlCommand(querry, connectToDb);
            reader= command.ExecuteReader();
            reader.Read();
            lblQuestion.Text = reader[1].ToString();
            lblAnsw1.Text = reader["Answ1"].ToString();
            lblAnsw2.Text = reader["Answ2"].ToString();
            lblAnsw3.Text = reader["Answ3"].ToString();
            lblAnsw4.Text = reader["Answ4"].ToString();

        }

        public void LoadRecord()
        {
            lblAnsw1.BackColor = SystemColors.Window;
            lblAnsw1.ForeColor = SystemColors.WindowText;
            lblAnsw2.BackColor = SystemColors.Window;
            lblAnsw2.ForeColor = SystemColors.WindowText;
            lblAnsw3.BackColor = SystemColors.Window;
            lblAnsw3.ForeColor = SystemColors.WindowText;
            lblAnsw4.BackColor = SystemColors.Window;
            lblAnsw4.ForeColor = SystemColors.WindowText;

            if(reader.Read()) 
            {
                lblQuestion.Text = reader[1].ToString();
                lblAnsw1.Text = reader[2].ToString();
                lblAnsw1.Text = reader[3].ToString();
                lblAnsw1.Text = reader[4].ToString();
                lblAnsw1.Text = reader[5].ToString();

            }
        }
        bool click = false;

        private void lblAnsw3_Click(object sender, EventArgs e)
        {
            
        }

        private void lblAnsw1_Click(object sender, EventArgs e)
        {
            if(lblAnsw1.Text == reader[6].ToString())
            {
                click = true;
                lblAnsw1.BackColor = Color.Red;
                LoadRecord();
            }
            else
            {
                lblAnsw1.BackColor = Color.Red;
                reader.Close();
                DialogResult result = MessageBox.Show("Do you want to restart the game?", );
                if(result == DialogResult.Yes)
                {
                    reader = command.ExecuteReader();
                    LoadRecord();
                }

            }
        }
    }
}
