using NhatKi2023.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NhatKi2023
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
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
        private void RegisterForm_Load(object sender, EventArgs e)
        {
            txtName2.Focus();
            timer.Tick += (s, args) =>
            {
                count++;
                if (count == 15)
                {   
                    btnExit_Click(sender, e);
                }
            };
            timer.Start();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            timer.Stop();
            count = 0;
            if (txtName2.Text == "" || txtPass2.Text == "" || txtComPass.Text == "")
            {
                MessageBox.Show("Your username or password field is empty!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtPass2.Text == txtComPass.Text)
            {
                try
                {
                    User user = new User()
                    {
                        Username = txtName2.Text,
                        Password = txtPass2.Text,
                        ConPassword = txtComPass.Text,
                    };
                    if (user != null)
                    {
                        context.Users.Add(user);
                        if (context.SaveChanges() > 0)
                        {
                            MessageBox.Show("Registration successfully!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Registration Failed: " + ex.Message);
                    throw;
                }
            }
            else
            {
                MessageBox.Show("Password and confirm password do not match. Please try again.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtName2.Text = "";
                txtPass2.Text = "";
                txtComPass.Text = "";
                txtName2.Focus();
            }
        }

        private void lblSignIn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.Show();
        }

        private void cbShowPass_CheckedChanged(object sender, EventArgs e)
        {
            timer.Start();
            count = 0;
            if (cbShowPass.Checked)
            {
                txtComPass.PasswordChar = '\0';
            }
            else
            {
                txtComPass.PasswordChar = '•';
            }
        }

        private void RegisterForm_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void RegisterForm_MouseLeave(object sender, EventArgs e)
        {
            timer.Start();
            count = 0;
        }

        private void txtName2_TextChanged(object sender, EventArgs e)
        {
            count = 0;
        }

        private void txtPass2_TextChanged(object sender, EventArgs e)
        {
            count = 0;
        }

        private void txtComPass_TextChanged(object sender, EventArgs e)
        {
            count = 0;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtName2_Enter(object sender, EventArgs e)
        {
            txtName2.BackColor = Color.Thistle;
        }

        private void txtName2_Leave(object sender, EventArgs e)
        {
            txtName2.BackColor = Color.Gainsboro;
        }

        private void txtPass2_LocationChanged(object sender, EventArgs e)
        {

        }

        private void txtPass2_Leave(object sender, EventArgs e)
        {
            txtPass2.BackColor = Color.Gainsboro;
        }

        private void txtPass2_Enter(object sender, EventArgs e)
        {
            txtPass2.BackColor = Color.Thistle;
        }

        private void txtComPass_Leave(object sender, EventArgs e)
        {
            txtComPass.BackColor = Color.Gainsboro;
        }

        private void txtComPass_Enter(object sender, EventArgs e)
        {
            txtComPass.BackColor = Color.Thistle;
        }
    }
}

