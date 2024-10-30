using System;
using System.Windows.Forms;
using System.Data.SQLite;

namespace slot_machine
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox2.Text = countercredit.ToString();
            textBox1.Text = counterbet.ToString();
            textBox3.Text = counterwin.ToString();
            box4.Visible = false;
        }

        Random rnd = new Random();
        int a, b, c,d, move;
        int countercredit = 0;
        int counterbet = 0;
        int counterwin = 0;
        bool win = false;
        int wa1 = 0;
        int le1 = 0;
        int che1 = 0;
        int ora1 = 0;
        int gra1 = 0;
        int wa2 = 0;
        int le2 = 0;
        int che2 = 0;
        int ora2 = 0;
        int gra2 = 0;
        int wa3 = 0;
        int le3 = 0;
        int che3 = 0;
        int ora3 = 0;
        int gra3 = 0;
        int wa4 = 0;
        int le4 = 0;
        int che4 = 0;
        int ora4 = 0;
        int gra4 = 0;
        string query = "";
        DB database1 = new DB();

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            countercredit = countercredit + int.Parse(textBox4.Text);
            textBox2.Text = countercredit.ToString();
            query = "INSERT INTO slotmachine1 ('CREDITS') VALUES ("+countercredit.ToString()+")";
            SQLiteCommand myCommand = new SQLiteCommand(query, database1.myconn);
            database1.myconn.Open();
            myCommand.ExecuteNonQuery();
            database1.myconn.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button5.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            box4.Visible = true;
            MessageBox.Show("Added new list");
            button5.Visible = true;
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new Form3().Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            box4.Visible = false;
            button5.Hide();
        }

        private void box4_Click(object sender, EventArgs e)
        {
          
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            counterbet = int.Parse(textBox1.Text);
            countercredit = int.Parse(textBox2.Text);
            if (countercredit.Equals(0))
            {
                MessageBox.Show("Add credit to continue");
            } 
            else if (counterbet > countercredit)
            {
                MessageBox.Show("Betting is more than Credits");
            }
            else if (counterbet.Equals(0))
            {
                MessageBox.Show("Insert Bet to continue!!!");
            }
            else
            {
                win = false;
                timer1.Enabled = true;
                countercredit = countercredit - counterbet;
                textBox2.Text = countercredit.ToString();

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            move++;
            if (move < 6)
            {
                if (box4.Visible == true)
                {
                    a = rnd.Next(1,6);
                    b = rnd.Next(1,6);
                    c = rnd.Next(1,6);
                    d = rnd.Next(1,6);
                }
                else
                {
                    a = rnd.Next(1,5);
                    b = rnd.Next(1,5);
                    c = rnd.Next(1,5);
                    d = rnd.Next(1,5);
                }

                wa1 = 0;
                le1 = 0;
                che1 = 0;
                ora1 = 0;
                gra1 = 0;
                wa2 = 0;
                le2 = 0;
                che2 = 0;
                ora2 = 0;
                gra2 = 0;
                wa3 = 0;
                le3 = 0;
                che3 = 0;
                ora3 = 0;
                gra3 = 0;
                wa4 = 0;
                le4 = 0;
                che4 = 0;
                ora4 = 0;
                gra4 = 0;

                switch (a)
                {
                    case 1:
                        box1.Image = Properties.Resources.watermelon;
                        wa1 = 1;
                        break;
                    case 2:
                        box1.Image = Properties.Resources.cherries;
                        che1 = 2;
                        break;
                    case 3:
                        box1.Image = Properties.Resources.lemon;
                        le1 = 3;
                        break;
                    case 4:
                        box1.Image = Properties.Resources.orange;
                        ora1 = 4;
                        break;
                    case 5:
                        box1.Image = Properties.Resources.grape;
                        gra1 = 5;
                        break; 
                }

                switch (b)
                {
                    case 1:
                        box2.Image = Properties.Resources.orange;
                        ora2 = 4;
                        break;
                    case 2:
                        box2.Image = Properties.Resources.cherries;
                        che2 = 2;
                        break;
                    case 3:
                        box2.Image = Properties.Resources.lemon;
                        le2 = 3;
                        break;
                    case 4:
                        box2.Image = Properties.Resources.watermelon;
                        wa2 = 1;
                        break;
                    case 5:
                        box2.Image = Properties.Resources.grape;
                        gra2 = 5;
                        break;
                }

                switch (c)
                {
                    case 1:
                        box3.Image = Properties.Resources.orange;
                        ora3 = 4;
                        break;
                    case 2:
                        box3.Image = Properties.Resources.cherries;
                        che3 = 2;
                        break;
                    case 3:
                        box3.Image = Properties.Resources.lemon;
                        le3 = 3;
                        break;
                    case 4:
                        box3.Image = Properties.Resources.watermelon;
                        wa3 = 1;
                        break;
                    case 5:
                        box3.Image = Properties.Resources.grape;
                        gra3 = 5;
                        break;
                }

                switch (d)
                {
                case 1:
                    box4.Image = Properties.Resources.orange;
                    ora4 = 4;
                    break;
                case 2:
                    box4.Image = Properties.Resources.cherries;
                    che4 = 2;
                    break;
                case 3:
                    box4.Image = Properties.Resources.lemon;
                    le4 = 3;
                    break;
                case 4:
                    box4.Image = Properties.Resources.watermelon;
                    wa4 = 1;
                    break;
                case 5:
                    box4.Image = Properties.Resources.grape;
                    gra4 = 5;
                    break;
                }
        }
            else
            {
                timer1.Enabled = false;
                move = 0;
            }

            if (timer1.Enabled == false)
            {
                if (box4.Visible == false)
                {
                    if (wa1 == 1 && wa2 == 1 && wa3 == 1)
                        win = true;

                    else if (che1 == 2 && che2 == 2 && che3 == 2)
                        win = true;

                    else if (le1 == 3 && le2 == 3 && le3 == 3)
                        win = true;

                    else  if (ora1 == 4 && ora2 == 4 && ora3 == 4)
                        win = true;
                }
                else
                {
                    if (wa1 == 1 && wa2 == 1 && wa3 == 1 && wa4 == 1)
                        win = true;

                    else if (che1 == 2 && che2 == 2 && che3 == 2 && che4 == 2)
                        win = true;

                    else if (le1 == 3 && le2 == 3 && le3 == 3 && le4 == 3)
                        win = true;

                    else if (ora1 == 4 && ora2 == 4 && ora3 == 4 && ora4 == 4)
                        win = true;

                    else if (gra1 == 5 && gra2 == 5 && gra3 == 5 && gra4 == 5)
                        win = true;
                }

                if (win == true)
                {
                    if (box4.Visible == false)
                    {
                        MessageBox.Show("CONGRATULATIONS!!!! YOU WON!");
                        counterwin = counterbet * 15;
                        textBox3.Text = counterwin.ToString();
                        countercredit = countercredit + counterwin;
                        textBox2.Text = countercredit.ToString();
                        query = "INSERT INTO slotmachine1 ('WINS') VALUES (" + counterwin.ToString() + ")";
                        SQLiteCommand myCommand = new SQLiteCommand(query, database1.myconn);
                        database1.myconn.Open();
                        myCommand.ExecuteNonQuery();
                        database1.myconn.Close();
                    }
                    else
                    {
                        MessageBox.Show("JACKPOT!!!! YOU WON!");
                        counterwin = counterbet * 1000;
                        textBox3.Text = counterwin.ToString();
                        countercredit = countercredit + counterwin;
                        textBox2.Text = countercredit.ToString();
                        query = "INSERT INTO slotmachine1 ('WINS') VALUES (" + counterwin.ToString() + ")";
                        SQLiteCommand myCommand = new SQLiteCommand(query, database1.myconn);
                        database1.myconn.Open();
                        myCommand.ExecuteNonQuery();
                        database1.myconn.Close();
                    }
                }
                else
                {
                    counterwin = 0;
                    textBox3.Text = counterwin.ToString();
                }
            }
        }
    }
}
