using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BiotestCompany
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            button1.Hide();
            button2.Hide();
            button3.Hide();
            button4.Hide();
            button5.Hide();
            button6.Hide();

        }

        private void ButtLogin_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Length < 8 || textBox2.Text.Length > 14 || (!textBox2.Text.Any(char.IsUpper)) || (!textBox2.Text.Any(char.IsLower)) ||
                (!textBox2.Text.Any(char.IsDigit)) ||  (textBox2.Text.Contains(" "))){
                if (textBox2.Text.Contains(" ")) {
                    MessageBox.Show("Please do no use space in your password");
                }
                else {
                    MessageBox.Show("Please use a password with 8-14 letters and atleast 1 upper letter, \n lower letter and digit");
                }
            }
            //if (!Program.checkUser(textBox3.Text)) {
            //    MessageBox.Show("Could not find this User please check your Usermail");

            //}
            //else if (!Program.checkPassword(textBox2.Text)) {
            //    MessageBox.Show("Password was not correct please try another password");
            //}

            Form menu = new MenuForm();
            menu.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextUsername_TextChanged(object sender, EventArgs e)
        {
            //string username = TextUsername.Text;
            //string password = TextPassword.Text;
            //if (username == "a" && password == "b")
            //{
            //    yariv mf = new yariv();
            //    mf.Show();
            //    this.Close();
            //}
        }

        private void TextPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.PasswordChar == '\0')
            {
                button2.BringToFront();
                textBox2.PasswordChar = '*';
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            button2.Show();
            button1.Show();
            if (textBox2.Text.Length < 8 || textBox2.Text.Length > 14 || (!textBox2.Text.Any(char.IsUpper)) || (!textBox2.Text.Any(char.IsLower)) ||
               (!textBox2.Text.Any(char.IsDigit)) || (textBox2.Text.Contains(" ")))
            {
                button4.Show();
            }
            else {
                button4.Hide();
                button6.Show();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.PasswordChar == '*')
            {
                button1.BringToFront();
                textBox2.PasswordChar = '\0';
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if ((!textBox3.Text.Contains('@')) || (!textBox3.Text.Contains("biotest")) || (textBox3.Text.Contains(" ")))
            {
                button3.Show();
            }
            else
            {
                button3.Hide();
                button5.Show();

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
