namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Class1 c = new Class1();
            dataGridView1.DataSource = c.Display();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Class1 c = new Class1();
            dataGridView1.DataSource=c.Display();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (id_txt.Text == "" && name_txt.Text == "")
            {
                MessageBox.Show("Complete the fields");
            }
            else
            {
                Class1 c = new Class1();
                int x = Convert.ToInt16(id_txt.Text);
                int t = c.Add_data(x, name_txt.Text);

                if (t > 0)
                {
                    MessageBox.Show("User Added Successfully");
                }
                dataGridView1.DataSource = c.Display();
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (id_txt.Text == "" && name_txt.Text == "")
            {
                MessageBox.Show("Complete the fields");
            }
            else
            {
                Class1 c = new Class1();
                int x = Convert.ToInt16(id_txt.Text);
                int t = c.Update_data(x, name_txt.Text);

                if (t > 0)
                {
                    MessageBox.Show("Update Successfully");
                }
                dataGridView1.DataSource = c.Display();
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (id_txt.Text == "")
            {
                MessageBox.Show("Complete the fields");
            }
            else
            {
                Class1 c = new Class1();
                int x = Convert.ToInt16(id_txt.Text);
                int t = c.Delete_user(x);
                if (t > 0)
                {
                    MessageBox.Show("User Deleted");
                }
                dataGridView1.DataSource = c.Display();
            }
        }
    }
}