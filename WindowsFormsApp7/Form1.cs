using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void nametxtB_MouseEnter(object sender, EventArgs e)
        {
            if(firstnametxtB.Text=="First name")
            {
                firstnametxtB.Text=string.Empty;
                firstnametxtB.ForeColor = Color.Black;
            }
        }

        private void nametxtB_MouseLeave(object sender, EventArgs e)
        {
            if (firstnametxtB.Text.Trim() == String.Empty)
            {
                firstnametxtB.Text = "First name";
                firstnametxtB.ForeColor = Color.Silver;
            }
        }

        private void lastnametxtB_MouseEnter(object sender, EventArgs e)
        {
            if(lastnametxtB.Text=="Last name")
            {
                lastnametxtB.Text = string.Empty;
                lastnametxtB.ForeColor = Color.Black;
               
            }
        }

        private void lastnametxtB_MouseLeave(object sender, EventArgs e)
        {
            if (lastnametxtB.Text == string.Empty)
            {
                lastnametxtB.Text = "Last name";
                lastnametxtB.ForeColor = Color.Silver;
            }
        }

        

        private void femalerdB_CheckedChanged(object sender, EventArgs e)
        {
            femalerdB.ForeColor = Color.Black;
            malerdB.ForeColor = Color.Silver;
        }

        private void malerdB_CheckedChanged(object sender, EventArgs e)
        {
            malerdB.ForeColor = Color.Black;
            femalerdB.ForeColor = Color.Silver;
        }

       

        private void emailtxtB_MouseEnter(object sender, EventArgs e)
        {
            if (emailtxtB.Text == "@gmail.com")
            {
                emailtxtB.Text = String.Empty;
                emailtxtB.ForeColor = Color.Black;
            }
        }

        private void emailtxtB_MouseLeave(object sender, EventArgs e)
        {
            if (emailtxtB.Text.Trim() == string.Empty)
            {
                emailtxtB.Text = "@gmail.com";
                emailtxtB.ForeColor = Color.Silver;
            }
        }

        string text = "mes: Baki seh/Koroglu Rehimov kuc/70 menzil-15 / ev-22";
       
        private void adressrchB_MouseEnter_1(object sender, EventArgs e)
        {
            if (adressrchB.Text == text)
            {
                adressrchB.Text = string.Empty;
                adressrchB.ForeColor = Color.Black;

            }
        }

        private void adressrchB_MouseLeave_1(object sender, EventArgs e)
        {
            if (adressrchB.Text == string.Empty)
            {
                adressrchB.Text = text;
                adressrchB.ForeColor = Color.Silver;

            }
        }


        

        

        private void passwordtxtB_KeyPress(object sender, KeyPressEventArgs e)
        {
          
        }

        

        private void repeatpasswordtxtB_KeyPress(object sender, KeyPressEventArgs e)
        {
          
        }

        private void signinBtn_Click(object sender, EventArgs e)
        {
            var person = new Person
            {
                Name = firstnametxtB.Text,
                Surname = lastnametxtB.Text,
                IsMale = malerdB.Checked ? true : false,
                Birthdate = DateTime.Parse(birthdatemskB.Text),
                Email = emailtxtB.Text,
                Phone = phonemskB.Text,
                Address = adressrchB.Text,
                Password = passwordtxtB.Text,
            };
            JsonHelper.Serialize(person);
            this.BackColor = Color.Green;
            MessageBox.Show("Registration completed successfully");
        }

        private void passwordtxtB_TextChanged(object sender, EventArgs e)
        {
            if (passwordtxtB.Text.Length <= 6)
            {
                passwordnoteLbl.Text = "Your password is week";
                passwordnoteLbl.ForeColor = Color.Red;
            }
            else
            {
                passwordnoteLbl.Text = "Your password is strong";
                passwordnoteLbl.ForeColor = Color.Green;
            }
        }

        private void repeatpasswordtxtB_TextChanged(object sender, EventArgs e)
        {
            if (repeatpasswordtxtB.Text.Length == passwordtxtB.Text.Length)
            {
                repeatpasswordnoteLbl.Text = "The password is corret";
                repeatpasswordnoteLbl.ForeColor = Color.Green;
            }
            else if (repeatpasswordtxtB.Text.Length != passwordtxtB.Text.Length)
            {
                repeatpasswordnoteLbl.Text = "The password wrong";
                repeatpasswordnoteLbl.ForeColor = Color.Red;
            }
        }
    }
}
