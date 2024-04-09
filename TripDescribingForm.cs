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
    public partial class TripDescribingForm : Form
    {
        Form loginForm;
        int tripNumber;
        int userNumber;

        public TripDescribingForm(Form loginForm, int tripNumber, int userNumber)
        {
            InitializeComponent();

            this.loginForm = loginForm;
            this.tripNumber = tripNumber;
            this.userNumber = userNumber;

            int leaderNumber = DB.GetData("SELECT Post_number FROM participant_posts WHERE Post_number = 3 AND Participant_number IN " +
                $"(SELECT Participant_number FROM participants_list WHERE Trip_number = {tripNumber} AND User_number = {userNumber})").Rows.Count;

            if (leaderNumber == 0)
            {
                changeButton.Enabled = false;
                changeButton.Visible = false;
            }

            DataTable dt = DB.GetData($"SELECT * FROM user WHERE User_number = \"{userNumber}\"");
            userInfo.Text = dt.Rows[0][1] + " " + dt.Rows[0][3] + ", №" + userNumber.ToString();

            DownloadData();
        }

        private void DownloadData()
        {
            DataTable dt = DB.GetData($"SELECT * FROM trips_list WHERE Trip_number = {tripNumber}");

            string tripType = DB.GetData($"SELECT Type FROM trip_types WHERE Trip_type_number = {dt.Rows[0][1]}").Rows[0][0].ToString();

            tripName.Text = tripType + ", " + dt.Rows[0][2].ToString();
            areaName.Text = dt.Rows[0][5].ToString();
            dataName.Text = "С " + DataChecker.TimeToData(dt.Rows[0][3].ToString()) + " по " + DataChecker.TimeToData(dt.Rows[0][4].ToString());
            descriptionName.Text = dt.Rows[0][6].ToString();
        }

        private void tripName_SizeChanged(object sender, EventArgs e)
        {
            changeButton.Location = new Point(tripName.Location.X + tripName.Size.Width + changeButton.Size.Width / 2 - 20, tripName.Location.Y);
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

        private void myTrips_Click(object sender, EventArgs e)
        {
            MyTripListForm myTrip = new MyTripListForm(loginForm, userNumber);
            Close();
            myTrip.Show();
        }

        private void MyProfile_Click(object sender, EventArgs e)
        {
            ProfileForm profile = new ProfileForm(loginForm, userNumber);
            Close();
            profile.Show();
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            ChangeTripForm createTrip = new ChangeTripForm(userNumber, tripNumber);
            DialogResult result = createTrip.ShowDialog();
            if (result == DialogResult.OK)
                DownloadData();
        }

        private void participantButton_Click(object sender, EventArgs e)
        {
            TripParticipantForm participantForm = new TripParticipantForm(loginForm, tripNumber, userNumber);
            Close();
            participantForm.Show();
        }
    }
}
