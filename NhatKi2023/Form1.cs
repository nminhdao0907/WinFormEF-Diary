using NhatKi2023.Models;

namespace NhatKi2023
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Nhatki2023Context context = new Nhatki2023Context();
        Dictionary<int, RadioButton> rbtn = new Dictionary<int, RadioButton>();
        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer
        {
            Interval = 1000,
        };

        int count = 0;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtName.Focus();
            timer.Tick += (s, args) =>
            {
                count++;
                if (count == 10)
                {
                    btnExit_Click(sender, e);
                }

            };
            timer.Start();
        }

        private void lblSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            RegisterForm r = new RegisterForm();
            r.Show();
        }

        private void cbShowPass_CheckedChanged(object sender, EventArgs e)
        {
            timer.Start();
            count = 0;
            if (cbShowPass.Checked)
            {
                txtPass.PasswordChar = '\0';
            }
            else
            {
                txtPass.PasswordChar = '•';
            }
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            count = 0;
        }

        int count2 = 0;
        private void btnLogin_Click(object sender, EventArgs e)
        {
            timer.Stop();
            count = 0;
            string username = txtName.Text;
            string password = txtPass.Text;
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter both username and password", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                count2++;
                if (count2 == 3)
                {
                    MessageBox.Show("Let's create new one!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    RegisterForm regis = new RegisterForm();
                    this.Hide();
                    regis.Show();
                }
                return;
            }
            User user = context.Users.FirstOrDefault(u => u.Username == txtName.Text && u.Password == txtPass.Text);
            if (user != null)
            {
                MessageBox.Show("Login successfully", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                Home home = new Home();
                home.Show();
            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                count2++;
                if (count2 == 3)
                {
                    MessageBox.Show("Let's create new one!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    RegisterForm regis = new RegisterForm();
                    this.Hide();
                    regis.Show();
                }
                return;
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            count = 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtName_Enter(object sender, EventArgs e)
        {
            txtName.BackColor = Color.Thistle;
        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            txtName.BackColor = Color.Gainsboro;
        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            txtPass.BackColor = Color.Thistle;
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            txtPass.BackColor = Color.Gainsboro;
        }

        private void Form1_MouseLeave(object sender, EventArgs e)
        {
            timer.Start();
            count = 0;
        }
    }
}