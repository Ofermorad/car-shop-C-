using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proj2
{
    public partial class Form2 : Form
    {
        car pos = new car();
        List<car> carlist = new List<car>();

        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_type.Text = "";
            txt_wheels.Text = "";
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
             
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            MessageBox.Show(carlist[0].Type);
            //if (carlist.Contains(txt_type_se.Text)==true)
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //יוצר אובייקט מכונית חדש
            car c1 = new car();
            //מכניס לאובייקט את הפרמטרים
            c1.Type = txt_type.Text;
            c1.Wheels = Int32.Parse(txt_wheels.Text);
            //מוסיף מכונית חדשה לרשימת מכוניות
            carlist.Add(c1);
            MessageBox.Show("new car added to carlist");
            txt_type.Text = "";
            txt_wheels.Text = "";
        }

        private void btn_search_Click_1(object sender, EventArgs e)
        {//אם הטקסט בסוג מתאים למשהו קיים ברשימה אז מופיע מס גלגלים בשדה טקסט
            txt_wheels_se.Text = "";
            foreach (car i in carlist)
            {
                if (i.Type == txt_type_se.Text)
                {
                    txt_wheels_se.Text = Convert.ToString(i.Wheels);
                    pos = i;
                }
            }
             
        }

        private void btn_del_se_Click(object sender, EventArgs e)
        {
            if (pos.Type == txt_type_se.Text)
            {
                MessageBox.Show(pos.Type + ": car is deleted...");
                carlist.Remove(pos);
                txt_type_se.Text = "";
                txt_wheels_se.Text = "";
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btn_sql_Click(object sender, EventArgs e)
        {
            if (che_sql.Checked==true)
            {
                Form3 f3 = new Form3();
                this.Hide();
                f3.Show();
            }
            else 
            {
                MessageBox.Show(" mark the checkBox");
            }
        }
    }
}
