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
    public partial class CreateTripForm : Form
    {
        int userNumber;

        public CreateTripForm(int userNumber)
        {
            InitializeComponent();
            this.userNumber = userNumber;
            startDate.MinDate = DateTime.Now;
            endDate.MinDate = DateTime.Now;
            DataTable dt = DB.GetData("SELECT Type FROM trip_types");

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                tripTypes.Items.Add(dt.Rows[i][0].ToString());
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void createTrip_Click(object sender, EventArgs e)
        {
            if (placeName.ForeColor == Color.Red)
            {
                MessageBox.Show("Некорректно указано название места");
                return;
            }

            if (regionName.ForeColor == Color.Red)
            {
                MessageBox.Show("Некорректно указано название региона");
                return;
            }

            if (startDate.Value.Date > endDate.Value.Date)
            {
                MessageBox.Show("Дата начала не может быть больше даты конца");
                return;
            }

            if (tripTypes.Text == "")
            {
                MessageBox.Show("Пожалуйста, укажите вид похода");
                return;
            }

            int tripNumber = (int)DB.GetData($"SELECT Trip_type_number FROM trip_types WHERE Type = '{tripTypes.Text}'").Rows[0][0];

            DB.SendPost("INSERT INTO trips_list (Trip_number, Trip_type_number, Place, Start_date, End_date, Region, Description) " +
                $"VALUES (NULL, '{tripNumber}', '{placeName.Text}', '{DataChecker.DataToDbData(startDate.Value.ToString())}', " +
                $"'{DataChecker.DataToDbData(endDate.Value.ToString())}', '{regionName.Text}', '{descriptionName.Text}')");

            tripNumber = (int)DB.GetData("SELECT MAX(Trip_number) FROM trips_list").Rows[0][0];

            DB.SendPost("INSERT INTO participants_list (Participant_number, User_number, Trip_number, Tent_number, Boat_number) " +
                $"VALUES (NULL, '{userNumber}', '{tripNumber}', NULL, NULL)");

            int participantNumber = (int)DB.GetData("SELECT MAX(Participant_number) FROM participants_list").Rows[0][0];

            DB.SendPost($"INSERT INTO participant_posts (Participant_number, Post_number) VALUES ('{participantNumber}', '3')");

            MessageBox.Show("Поход успешно создан.");
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
