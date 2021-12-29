using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;


namespace BiotestCompany
{
    public partial class Email : Form
    {
        public Email()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string mail = new SmtpClient("smtp.gmail.com");
            //MailMessage mm = new MailMessage("ecoshrimpproject@gmail.com",textBox1.Text);
            //mm.Subject = "Testing mail";
            //SmtpClient sc = new SmtpClient("smtp@gmail.com", 587);
            //sc.UseDefaultCredentials = false;
            //NetworkCredential scr = new NetworkCredential("ecoshrimpproject@gmail.com", "ecoshrimp123!");
            //sc.Credentials = scr;
            //sc.EnableSsl = true;
            //sc.Send(mm);//


            //try
            //{
            //    sc.Send(mm);
            //    MessageBox.Show("wtf");
            //}
            //catch(Exception ex) {
            //    MessageBox.Show(ex.Message+"idk");

            //}

        }

        private void Email_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
