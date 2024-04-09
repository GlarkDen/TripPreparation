using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary;

namespace TripPreparation
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            //loginText.Text = "dgexample@mail.ru";
            //passwordText.Text = "12345w";
        }

        private void About_Click(object sender, EventArgs e)
        {
            AboutForm aboutWindow = new AboutForm();
            aboutWindow.ShowDialog();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            //bool inNumber = false, inCapital = false;

            //if (!DataChecker.IsPassword(passwordText.Text, out inNumber, out inCapital) ||
            //    !DataChecker.IsEmail(loginText.Text))
            //{
            //    MessageBox.Show("Неверные логин или пароль.");
            //    return;
            //}

            DataTable dt = DB.GetData($"SELECT Password, User_number FROM user WHERE Email_address = \"{loginText.Text}\"");
            
            if (dt.Rows.Count == 1)
            {
                if ((string)dt.Rows[0][0] == passwordText.Text)
                {
                    loginText.Text = "";
                    passwordText.Text = "";
                    MyTripListForm trip = new MyTripListForm(this, (int)dt.Rows[0][1]);
                    Hide();
                    trip.Show();
                } 
                else
                {
                    MessageBox.Show("Неверный пароль");
                }
            } 
            else
            {
                MessageBox.Show("Пользователя с указанным логином не найдено");
            }
        }

        private void registrationButton_Click(object sender, EventArgs e)
        {
            RegistrationForm regForm = new RegistrationForm(this);
            Hide();
            regForm.Show();
        }
    }
}
