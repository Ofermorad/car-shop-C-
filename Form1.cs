namespace proj2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_go_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_user.Text) || string.IsNullOrEmpty(txt_pass.Text))
            {
                MessageBox.Show("please fill in user name and password..");
            }
            if (txt_user.Text == "ofer" && txt_pass.Text == "ofer123")
            {
                MessageBox.Show("Welcom Boss we miss you..");
                //מסתיר חלון נוכחי
                this.Hide();
                //מעלה קדימה חלון חדש
                Form2 f2= new Form2();
                f2.Show();
             }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}