using Microsoft.Data.SqlClient;

namespace Form_task
{
    public partial class FormsName : Form
    {
        public FormsName()
        {
            InitializeComponent();
        }

        private void FormsName_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(textBoxID.Text))
            {
                MessageBox.Show("Please enter a valid Student ID.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(textBoxID.Text, out int studID))
            {
                MessageBox.Show("Student ID must be a number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection con = new SqlConnection("Data Source=SWIFT\\SQLEXPRESS;Initial Catalog=Students;Integrated Security=True;Trust Server Certificate=True"))
            {
                con.Open();
                string query = "SELECT COUNT(*) FROM Studlogin WHERE StudID = @StudID AND FullName = @FullName AND IsActive = 1";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@StudID", studID);
                    cmd.Parameters.AddWithValue("@FullName", textBoxName.Text);

                    int result = (int)cmd.ExecuteScalar();

                    if (result > 0) //if isActive
                    {
                        MessageBox.Show("Student is Enrolled in the Study program", "info", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("Unknown Data or Inactive Account", "info", MessageBoxButtons.OK);
                    }
                }
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 newForm = new Form2(); // new window
            newForm.Show();
        }
    }
}
