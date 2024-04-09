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
    public partial class ProfileForm : Form
    {
        Form loginForm;
        int userNumber;
        string email;
        string phone;

        public ProfileForm(Form loginForm, int userNumber)
        {
            InitializeComponent();
            this.loginForm = loginForm;
            this.userNumber = userNumber;

            LoadSetData();

            SetBackColorDark();

            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(helpPass, $"Пароль должен содержать цифры и заглавные буквы,\nа также быть длиной не менее {ConstVar.PasswordLen} символов");
        }

        private void About_Click(object sender, EventArgs e)
        {
            AboutForm aboutWindow = new AboutForm();
            aboutWindow.ShowDialog();
        }

        private void OutButton_Click(object sender, EventArgs e)
        {
            loginForm.Show();
            Close();
        }

        private void LoadSetData()
        {
            DataTable dt = DB.GetData($"SELECT * FROM user WHERE User_number = \"{userNumber}\"");
            userInfo.Text = dt.Rows[0][1] + " " + dt.Rows[0][3] + ", №" + userNumber.ToString();

            nameText.Text = (string)dt.Rows[0][1];
            surnameText.Text = (string)dt.Rows[0][2];
            patrText.Text = (string)dt.Rows[0][3];

            phoneText.Text = (string)dt.Rows[0][7];
            emailText.Text = (string)dt.Rows[0][8];
            passwordText.Text = (string)dt.Rows[0][9];

            email = (string)dt.Rows[0][8];
            phone = (string)dt.Rows[0][7];

            if (dt.Rows[0][4] != DBNull.Value)
                allergiesText.Text = (string)dt.Rows[0][4];
            else
                allergiesText.Text = "";

            if (dt.Rows[0][5] != DBNull.Value)
                deseasesText.Text = (string)dt.Rows[0][5];
            else
                deseasesText.Text = "";

            if (dt.Rows[0][6] != DBNull.Value)
                medicineText.Text = (string)dt.Rows[0][6];
            else
                medicineText.Text = "";
        }

        private void myTrips_Click(object sender, EventArgs e)
        {
            MyTripListForm myTrip = new MyTripListForm(loginForm, userNumber);
            Close();
            myTrip.Show();
        }

        private void ChangePassStatus()
        {
            lastPass.Visible = !lastPass.Visible;
            newPass1.Visible = !newPass1.Visible;
            newPass2.Visible = !newPass2.Visible;
            npas1.Visible = !npas1.Visible;
            npas2.Visible = !npas2.Visible;
            npas3.Visible = !npas3.Visible;
            helpPass.Visible = !helpPass.Visible;
            helpPass.Enabled = !helpPass.Enabled;
            pasCans.Enabled = !pasCans.Enabled;
            passConf.Enabled = !passConf.Enabled;
            passChange.Visible = !passChange.Visible;
            passConf.Visible = !passConf.Visible;
            pasCans.Visible = !pasCans.Visible;
        }

        private void passChange_Click(object sender, EventArgs e)
        {
            ChangePassStatus();
        }

        private void pasCans_Click(object sender, EventArgs e)
        {
            ChangePassStatus();
            lastPass.Text = "";
            newPass1.Text = "";
            newPass2.Text = "";
        }

        private void passConf_Click(object sender, EventArgs e)
        {
            if (lastPass.Text != passwordText.Text)
            {
                MessageBox.Show("Неверный пароль.");
                return;
            }

            bool inNumber = false, inCapital = false;

            if (!DataChecker.IsPassword(newPass1.Text, out inNumber, out inCapital))
            {
                if (!inNumber)
                    MessageBox.Show("Новый пароль должен содержать цифры.");
                else if (!inCapital)
                    MessageBox.Show("Новый пароль должен содержать заглавные буквы.");
                else
                    MessageBox.Show($"Новый пароль должен содержать не менее {ConstVar.PasswordLen} символов.");

                return;
            }

            if (newPass1.Text != newPass2.Text)
            {
                MessageBox.Show("Пароли не совпадают.");
                return;
            }

            MessageBox.Show("Пароль успешно изменён.");
            passwordText.Text = newPass1.Text;

            DB.SendPost($"UPDATE user SET Password = '{newPass1.Text}' WHERE user.User_number = {userNumber}");

            pasCans_Click(sender, e);
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            ChangeUserInfo();
            SetBackColorLight();
        }

        private void ChangeUserInfo()
        {
            nameText.ReadOnly = !nameText.ReadOnly;
            surnameText.ReadOnly = !surnameText.ReadOnly;
            patrText.ReadOnly = !patrText.ReadOnly;

            phoneText.ReadOnly = !phoneText.ReadOnly;
            emailText.ReadOnly = !emailText.ReadOnly;

            allergiesText.ReadOnly = !allergiesText.ReadOnly;
            deseasesText.ReadOnly = !deseasesText.ReadOnly;
            medicineText.ReadOnly = !medicineText.ReadOnly;

            cansInfo.Visible = !cansInfo.Visible;
            saveInfo.Visible = !saveInfo.Visible;

            cansInfo.Enabled = !cansInfo.Enabled;
            saveInfo.Enabled = !saveInfo.Enabled;

            changeButton.Visible = !changeButton.Visible;
            changeButton.Enabled = !changeButton.Enabled;
        }

        private void SetBackColorDark()
        {
            allergiesText.BackColor = nameText.BackColor;
            deseasesText.BackColor = nameText.BackColor;
            medicineText.BackColor = nameText.BackColor;
        }

        private void SetBackColorLight()
        {
            allergiesText.BackColor = Color.White;
            deseasesText.BackColor = Color.White;
            medicineText.BackColor = Color.White;
        }

        private void cansInfo_Click(object sender, EventArgs e)
        {
            ChangeUserInfo();
            SetBackColorDark();
            LoadSetData();
        }

        private void saveInfo_Click(object sender, EventArgs e)
        {
            if (nameText.ForeColor == Color.Red)
            {
                MessageBox.Show("Некорректно указано имя");
                return;
            }

            if (surnameText.ForeColor == Color.Red)
            {
                MessageBox.Show("Некорректно указана фамилия");
                return;
            }

            if (patrText.ForeColor == Color.Red)
            {
                MessageBox.Show("Некорректно указано отчество");
                return;
            }

            if (!DataChecker.IsPhone(phoneText.Text))
            {
                MessageBox.Show("Некорректно указан телефон");
                return;
            }

            if (emailText.ForeColor == Color.Red)
            {
                MessageBox.Show("Некорректно указан логин");
                return;
            }

            DataTable dt;

            if (email != emailText.Text)
            {
                dt = DB.GetData($"SELECT * FROM user WHERE Email_address = \"{emailText.Text}\"");

                if (dt.Rows.Count == 1)
                {
                    MessageBox.Show("Пользователь с указанным логином уже существует.");
                    return;
                }
            }

            if (phone != DataChecker.DoPhone(phoneText.Text))
            {
                dt = DB.GetData($"SELECT * FROM user WHERE Phone_number = \"{DataChecker.DoPhone(phoneText.Text)}\"");

                if (dt.Rows.Count == 1)
                {
                    MessageBox.Show("Пользователь с указанным номером телефона уже существует.");
                    return;
                }
            }

            email = emailText.Text;
            phone = DataChecker.DoPhone(phoneText.Text);

            DB.SendPost("UPDATE user SET " +
                $"Name = '{nameText.Text}', Surname = '{surnameText.Text}', Patronymic = '{patrText.Text}', " +
                $"Allergies = '{allergiesText.Text}', Сhronic_diseases = '{deseasesText.Text}', Medications_taken = '{medicineText.Text}', " +
                $"Phone_number = '{DataChecker.DoPhone(phoneText.Text)}', Email_address = '{emailText.Text}' WHERE user.User_number = {userNumber}");

            userInfo.Text = nameText.Text + " " + patrText.Text + ", №" + userNumber.ToString();

            ChangeUserInfo();
            SetBackColorDark();
        }

        private void deleteAcc_Click(object sender, EventArgs e)
        {
            DataTable dt = DB.GetData("SELECT Participant_number FROM participant_posts WHERE Post_number = 3 AND Participant_number IN " +
                $"(SELECT Participant_number FROM participants_list WHERE User_number = {userNumber})");

            int leaderTrip = dt.Rows.Count;

            if (leaderTrip == 1)
            {
                MessageBox.Show("Вы являетесь руководителем одного из походов.\n" +
                    "Пожалуйста, передайте свои полномочия другому участнику перед тем, " +
                    "как удалить аккаунт.");
                return;
            }

            if (leaderTrip > 1)
            {
                MessageBox.Show($"Вы являетесь руководителем {leaderTrip} походов.\n" +
                    "Пожалуйста, передайте свои полномочия другим участникам перед тем, " +
                    "как удалить аккаунт.");
                return;
            }

            DialogResult dialog = MessageBox.Show("Вы уверены, что хотите удалить аккаунт?", "Удаление аккаунта", MessageBoxButtons.YesNo);

            if (dialog == DialogResult.Yes)
            {
                DB.SendPost($"DELETE FROM trips_list WHERE Trip_number IN (SELECT Trip_number FROM participants_list WHERE User_number = {userNumber})");
                DB.SendPost($"DELETE FROM user WHERE User_number = {userNumber}");

                MessageBox.Show("Ваш аккаунт был удалён.");

                OutButton_Click(sender, e);
            }
        }
    }
}
