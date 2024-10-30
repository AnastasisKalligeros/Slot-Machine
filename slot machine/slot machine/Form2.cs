using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace slot_machine
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(textBox1.Text) == false && String.IsNullOrEmpty(textBox2.Text) == false)
            { 
            new Form1().Show();
            Player player = new Player();
            player.Firstname = textBox1.Text;
            player.Surname = textBox2.Text;
            MessageBox.Show(player.WelcomePlayer());
            }
            else
            {
                MessageBox.Show("Please fill all the fields.");
            }
}
    }
}
