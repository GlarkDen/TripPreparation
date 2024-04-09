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
    public partial class ChangeTripForm : Form
    {
        int userNumber;
        int tripNumber;

        public ChangeTripForm(int userNumber, int tripNumber)
        {
            InitializeComponent();
            this.userNumber = userNumber;
            this.tripNumber = tripNumber;
            startDate.MinDate = DateTime.Now.Date;
            endDate.MinDate = DateTime.Now.Date;
            DataTable dt = DB.GetData("SELECT Type FROM trip_types");

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                tripTypes.Items.Add(dt.Rows[i][0].ToString());
            }

            dt = DB.GetData($"SELECT * FROM trips_list WHERE Trip_number = {tripNumber}");

            string tripType = DB.GetData($"SELECT Type FROM trip_types WHERE Trip_type_number = {dt.Rows[0][1]}").Rows[0][0].ToString();

            tripTypes.Text = tripType;
            placeName.Text = dt.Rows[0][2].ToString();
            regionName.Text = dt.Rows[0][5].ToString();
            startDate.Value = (DateTime)dt.Rows[0][3];
            endDate.Value = (DateTime)dt.Rows[0][4];
            descriptionName.Text = dt.Rows[0][6].ToString();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void changeTrip_Click(object sender, EventArgs e)
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

            int tripTypeNumber = (int)DB.GetData($"SELECT Trip_type_number FROM trip_types WHERE Type = '{tripTypes.Text}'").Rows[0][0];

            DB.SendPost($"UPDATE trips_list SET Trip_type_number = '{tripTypeNumber}', Place = '{placeName.Text}', Start_date = '{DataChecker.DataToDbData(startDate.Value.ToString())}', " +
                $"End_date = '{DataChecker.DataToDbData(endDate.Value.ToString())}', Region = '{regionName.Text}', Description = '{descriptionName.Text}' WHERE Trip_number = {tripNumber}");

            MessageBox.Show("Изменения сохранены.");
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
