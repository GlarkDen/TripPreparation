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
    public partial class MyTripListForm : Form
    {
        Form loginForm;
        int userNumber;
        DataTable dt;

        public MyTripListForm(Form loginForm, int userNumber)
        {
            InitializeComponent();

            this.loginForm = loginForm;
            this.userNumber = userNumber;
            SetTripsMenu();

            dataGrid.CellContentClick += DataGridView_CellContentClick;
        }

        private void SetTripsMenu()
        {
            dt = DB.GetData($"SELECT * FROM user WHERE User_number = \"{userNumber}\"");
            userInfo.Text = dt.Rows[0][1] + " " + dt.Rows[0][3] + ", №" + userNumber.ToString();

            dt = DB.GetData($"SELECT * FROM trips_list WHERE Trip_number IN (SELECT Trip_number FROM participants_list WHERE User_number = {userNumber})");
            DataTable dtView;

            int stringCount = dt.Rows.Count;

            dataGrid.Columns[0].ValueType = Type.GetType("string");

            for (int i = 0; i < stringCount; i++)
            {
                dataGrid.Rows.Add();
                dataGrid.Rows[i].Height = 37;
            }

            for (int i = 0; i < stringCount; i++)
            {
                dtView = DB.GetData($"SELECT Type FROM trip_preparation.trip_types WHERE Trip_type_number = {dt.Rows[i][1]}");
                dataGrid[0, i].Value = (string)dtView.Rows[0][0] + ", " + (string)dt.Rows[i][2];
                dataGrid[1, i].Value = "С " + DataChecker.TimeToData(dt.Rows[i][3].ToString()) + " по " + DataChecker.TimeToData(dt.Rows[i][4].ToString());
                dataGrid[2, i].Value = "К походу";
                dataGrid[3, i].Value = "Выйти";
            }

            DB.ChangeFont(dataGrid, 18);
        }

        private void DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGrid.Columns.Count == 0 || dataGrid.Rows.Count == 0)
                return;

            if (e.RowIndex >= 0)
            {
                var buttonColumn = dataGrid.Columns[e.ColumnIndex] as DataGridViewButtonColumn;
                int tripNumber = (int)dt.Rows[e.RowIndex][0];

                if (buttonColumn == dataGrid.Columns[2])
                {
                    TripDescribingForm describingForm = new TripDescribingForm(loginForm, tripNumber, userNumber);
                    Close();
                    describingForm.Show();
                }
                else if (buttonColumn == dataGrid.Columns[3])
                {
                    DataTable dtb = DB.GetData($"SELECT COUNT(*) FROM participants_list WHERE Trip_number = {tripNumber}");

                    int partNumber = int.Parse(dtb.Rows[0][0].ToString());

                    if (partNumber > 1)
                    {
                        dtb = DB.GetData("SELECT Post_number FROM participant_posts WHERE Post_number = 3 AND Participant_number IN " +
                            $"(SELECT Participant_number FROM participants_list WHERE Trip_number = {tripNumber} AND User_number = {userNumber})");

                        if (dtb.Rows.Count == 1)
                        {
                            MessageBox.Show($"Вы являетесь руководителем указанного похода.\n" +
                                "Пожалуйста, передайте свои полномочия другому участнику перед тем, " +
                                "как покинуть мероприятие.");

                            return;
                        }
                    }

                    DialogResult dialog = MessageBox.Show("Вы уверены, что хотите выйти из похода?", "Выход из похода", MessageBoxButtons.YesNo);

                    if (dialog == DialogResult.Yes)
                    {
                        DB.SendPost($"DELETE FROM trips_list WHERE Trip_number = {tripNumber}");
                        dataGrid.Rows.Clear();
                        SetTripsMenu();
                    }
                }
            }
        }

        private void OutButton_Click(object sender, EventArgs e)
        {
            loginForm.Show();
            Close();
        }

        private void MyProfile_Click(object sender, EventArgs e)
        {
            ProfileForm profile = new ProfileForm(loginForm, userNumber);
            Close();
            profile.Show();
        }

        private void About_Click(object sender, EventArgs e)
        {
            AboutForm aboutWindow = new AboutForm();
            aboutWindow.ShowDialog();
        }

        private void CreateTrip_Click(object sender, EventArgs e)
        {
            CreateTripForm createTrip = new CreateTripForm(userNumber);
            DialogResult result = createTrip.ShowDialog();
            if (result == DialogResult.OK)
            {
                dataGrid.Rows.Clear();
                SetTripsMenu();
            }
        }
    }
}
