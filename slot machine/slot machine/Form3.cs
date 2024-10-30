using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace slot_machine
{
    public partial class Form3 : Form
    {
        SQLiteConnection conn;

        String connectionString = "Data Source=db1.db;";
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            conn = new SQLiteConnection(connectionString);
            conn.Open();
            String displayQuery = "Select * FROM slotmachine1";
            SQLiteCommand cmd1 = new SQLiteCommand(displayQuery, conn);
            SQLiteDataReader reader1 = cmd1.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(reader1);

            conn.Close();
            dataGridView1.DataSource = dt;

        }
    }
}
