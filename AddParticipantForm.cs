using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TripPreparation
{
    public partial class AddParticipantForm : Form
    {
        int tripNumber;

        public AddParticipantForm(int tripNumber)
        {
            InitializeComponent();

            this.tripNumber = tripNumber;

            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(label1, "Каждый пользователь может посмотреть его в левом верхнем углу или в своём профиле.");
        }

        private void add_Click(object sender, EventArgs e)
        {
            int userNumber = 0;
            if (int.TryParse(textBox1.Text, out userNumber)) 
            {
                if (textBox1.Text[0] == '0' && textBox1.Text.Length > 1)
                {
                    MessageBox.Show("Номер введён некорректно");
                    return;
                }

                if (userNumber == 0)
                {
                    MessageBox.Show("Не найдено пользователя с указанным номером");
                    return;
                }

                DataTable dt = DB.GetData($"SELECT User_number FROM user WHERE User_number = {userNumber}");

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Не найдено пользователя с указанным номером");
                    return;
                }

                dt = DB.GetData($"SELECT Participant_number FROM participants_list WHERE User_number = {userNumber} AND Trip_number = {tripNumber}");

                if (dt.Rows.Count == 1)
                {
                    MessageBox.Show("Указанный пользователь уже является участником данного похода");
                    return;
                }

                DB.SendPost("INSERT INTO participants_list (Participant_number, User_number, Trip_number, Tent_number, Boat_number) " +
                    $"VALUES (NULL, '{userNumber}', '{tripNumber}', NULL, NULL)");

                dt = DB.GetData("SELECT MAX(Participant_number) FROM participants_list");

                DB.SendPost("INSERT INTO participant_posts (Participant_number, Post_number) " +
                    $"VALUES ('{dt.Rows[0][0]}', '12')");
            }
            else
            {
                MessageBox.Show("Номер введён некорректно");
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
