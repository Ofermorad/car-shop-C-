using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace proj2
{
    public partial class Form3 : Form
    {
        user user_tmp = new user();

        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SQLiteConnection con = new SQLiteConnection(@"data source=C:\Users\oferm\Downloads\C#\proj2\db\sq.db");
            con.Open();
            string quary1 = "SELECT* from users_table";
            SQLiteCommand command1 = new SQLiteCommand(quary1,con);
            DataTable dt = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(command1);
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
        }

        private void btn_add_user_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(name_txt.Text) || string.IsNullOrEmpty(pass_txt.Text))
            {
                MessageBox.Show("fill all details: name & pass..");
            }
            else
            {
                user_tmp.Name = name_txt.Text;
                user_tmp.Password = pass_txt.Text;
                //start insert to sqlite
                SQLiteConnection con2 = new SQLiteConnection(@"data source=C:\Users\oferm\Downloads\C#\proj2\db\sq.db");
                con2.Open();
                string quary2 = "INSERT INTO users_table (name,password) VALUES (@name,@password)";
                SQLiteCommand com2 = new SQLiteCommand(quary2, con2);
                com2.Parameters.AddWithValue("name", user_tmp.Name);
                com2.Parameters.AddWithValue("password", user_tmp.Password);
                com2.ExecuteNonQuery();
                con2.Close();
                name_txt.Text = "";
                pass_txt.Text = "";
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            name_txt.Text = "";
            pass_txt.Text = "";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_find_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(name_txt.Text) || string.IsNullOrEmpty(pass_txt.Text))
            {
                MessageBox.Show("fill name to show pass and delete..");
            }
            else
            {
                user_tmp.Name = name_txt.Text;
                 //start delete to sqlite
                SQLiteConnection con2 = new SQLiteConnection(@"data source=C:\Users\oferm\Downloads\C#\proj2\db\sq.db");
                con2.Open();
                string quary2 = "SELECT * FROM users_table WHERE name=ofer";
                SQLiteCommand com2 = new SQLiteCommand(quary2, con2);
                //del_pass_txt = pass_;
            }
        }
    }
}
