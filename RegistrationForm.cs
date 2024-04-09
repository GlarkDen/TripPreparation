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
    public partial class RegistrationForm : Form
    {
        Form loginForm;

        public RegistrationForm(Form loginForm)
        {
            InitializeComponent();
            this.loginForm = loginForm;
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(helpPass, $"Пароль должен содержать цифры и заглавные буквы,\nа также быть длиной не менее {ConstVar.PasswordLen} символов");
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            loginForm.Show();
            Close();
        }

        private void registrationButton_Click(object sender, EventArgs e)
        {
            if (!DataChecker.IsEmail(emailText.Text))
            {
                MessageBox.Show("Некорректно введена электронная почта.");
                return;
            }

            bool inNumber = false, inCapital = false;

            if (!DataChecker.IsPassword(password1.Text, out inNumber, out inCapital))
            {
                if (!inNumber)
                    MessageBox.Show("Пароль должен содержать цифры.");
                else if (!inCapital)
                    MessageBox.Show("Пароль должен содержать заглавные буквы.");
                else
                    MessageBox.Show($"Пароль должен содержать не менее {ConstVar.PasswordLen} символов.");

                return;
            }

            if (password1.Text != password2.Text)
            {
                MessageBox.Show("Пароли не совпадают.");
                return;
            }

            if (!DataChecker.IsName(nameText.Text))
            {
                MessageBox.Show("Некорректно введено имя.");
                return;
            }

            if (!DataChecker.IsName(surnameText.Text))
            {
                MessageBox.Show("Некорректно введена фамилия.");
                return;
            }

            if (!DataChecker.IsName(patrText.Text))
            {
                MessageBox.Show("Некорректно введено отчество.");
                return;
            }

            if (!DataChecker.IsPhone(phoneText.Text))
            {
                MessageBox.Show("Некорректно введён телефон.");
                return;
            }

            DataTable dt = DB.GetData($"SELECT * FROM user WHERE Email_address = \"{emailText.Text}\"");

            if (dt.Rows.Count == 1)
            {
                MessageBox.Show("Пользователь с указанным логином уже существует.");
                return;
            } 

            dt = DB.GetData($"SELECT * FROM user WHERE Phone_number = \"{DataChecker.DoPhone(phoneText.Text)}\"");

            if (dt.Rows.Count == 1)
            {
                MessageBox.Show("Пользователь с указанным номером телефона уже существует.");
                return;
            }

            DB.AddUser(emailText.Text, password1.Text, nameText.Text, surnameText.Text, patrText.Text, DataChecker.DoPhone(phoneText.Text));

            int un = (int)DB.GetData("SELECT MAX(User_number) FROM user").Rows[0][0];

            DB.SendPost("INSERT INTO post_list (User_number, Post_number) " +
                $"VALUES ('{un}', '1'), ('{un}', '2'), ('{un}', '3'), ('{un}', '4'), ('{un}', '5'), " +
                $"('{un}', '6'), ('{un}', '7'), ('{un}', '8'), ('{un}', '9'), ('{un}', '10'), ('{un}', '11'), ('{un}', '12')");

            DB.SendPost("INSERT INTO food_intake_type_list (User_number, Food_intake_type_number) " +
                $"VALUES ('{un}', '1'), ('{un}', '2'), ('{un}', '3'), ('{un}', '4')");

            DB.SendPost("INSERT INTO duty_type_list (User_number, Duty_type_number) " +
                $"VALUES ('{un}', '1'), ('{un}', '2'), ('{un}', '3')");

            MessageBox.Show("Регистрация успешна.");

            loginForm.Show();
            Close();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void About_Click(object sender, EventArgs e)
        {
            AboutForm aboutWindow = new AboutForm();
            aboutWindow.ShowDialog();
        }
    }
}
