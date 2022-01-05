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
        string title = "";
        string text = "";
        string sendto = "";

        public Email()
        {
            InitializeComponent();
            this.sendto = sendto;
            this.title = title;
            this.text = text;
        }
        //public Email(string sendto, string title, string text) //now a method in Program
        //{
        //    this.sendto = sendto;
        //    this.title = title;
        //    this.text = text;
        //    InitializeComponent();

        //    SmtpClient mail = new SmtpClient("smtp.gmail.com", 587);
        //    NetworkCredential Credentials = new NetworkCredential("BiotestCompany@gmail.com", "crudMaster");
        //    mail.Credentials = Credentials;
        //    mail.EnableSsl = true;

        //    mail.Send("BiotestCompany@gmail.com", sendto, title, text);
        //}

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.sendto = textBox1.Text;
            this.title = textBox2.Text;
            this.text = textBox4.Text;
            SmtpClient mail = new SmtpClient("smtp.gmail.com", 587);
            NetworkCredential Credentials = new NetworkCredential("BiotestCompany@gmail.com", "crudMaster");
            mail.Credentials = Credentials;
            mail.EnableSsl = true;

            try
            {
                var mailMessage = new MailMessage
                {
                    From = new MailAddress("BiotestCompany@gmail.com"),
                    Subject = textBox2.Text,
                    Body = textBox4.Text,
                    IsBodyHtml = true,
                };
                mailMessage.To.Add(sendto);
                mail.Send(mailMessage);

                MessageBox.Show("mail sent");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " ");

            }

        }

        private void Email_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.sendto = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            this.title = textBox2.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
