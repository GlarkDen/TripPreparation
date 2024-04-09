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
    public partial class TripParticipantForm : Form
    {
        Form loginForm;
        int tripNumber;
        int userNumber;
        bool isLeader = false;
        DataTable dt;

        public TripParticipantForm(Form loginForm, int tripNumber, int userNumber)
        {
            InitializeComponent();

            this.loginForm = loginForm;
            this.tripNumber = tripNumber;
            this.userNumber = userNumber;

            int leaderNumber = DB.GetData("SELECT Post_number FROM participant_posts WHERE Post_number = 3 AND Participant_number IN " +
                $"(SELECT Participant_number FROM participants_list WHERE Trip_number = {tripNumber} AND User_number = {userNumber})").Rows.Count;

            if (leaderNumber != 0)
                isLeader = true;

            dataGrid.Columns.Add(new DataGridViewTextBoxColumn() 
            { 
                Name = "partNum", 
                HeaderText = "№", 
                Width = 40,
                Resizable = DataGridViewTriState.False
            });

            dataGrid.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "partFio",
                HeaderText = "ФИО",
                Width = 300,
                Resizable = DataGridViewTriState.True
            });

            dataGrid.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "partCont",
                HeaderText = "Контакты",
                Width = 160,
                Resizable = DataGridViewTriState.True
            });

            if (!isLeader)
            {
                dataGrid.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    Name = "partPosts",
                    HeaderText = "Должности",
                    Width = 150,
                    Resizable = DataGridViewTriState.True
                });

                button1.Enabled = false;
                button1.Visible = false;
            } 
            else
            {
                dataGrid.Columns.Add(new DataGridViewButtonColumn()
                {
                    Name = "partPosts",
                    HeaderText = "Должности",
                    Width = 150,
                    Resizable = DataGridViewTriState.True
                });

                dataGrid.Columns.Add(new DataGridViewButtonColumn()
                {
                    Name = "delPart",
                    HeaderText = "Удаление",
                    Width = 150,
                    Resizable = DataGridViewTriState.True
                });
            }

            dataGrid.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "partFio",
                HeaderText = "Аллергии",
                Width = 150,
                Resizable = DataGridViewTriState.True
            });

            dataGrid.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "partFio",
                HeaderText = "Хронические заболевания",
                Width = 150,
                Resizable = DataGridViewTriState.True
            });

            dataGrid.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "partFio",
                HeaderText = "Принимаемые препараты",
                Width = 170,
                Resizable = DataGridViewTriState.True
            });

            dt = DB.GetData($"SELECT * FROM user WHERE User_number = \"{userNumber}\"");
            userInfo.Text = dt.Rows[0][1] + " " + dt.Rows[0][3] + ", №" + userNumber.ToString();

            DownloadData();

            dataGrid.CellContentClick += DataGridView_CellContentClick;

            DB.ChangeFont(dataGrid, 18);
        }

        private void DownloadData()
        {
            dt = DB.GetData($"SELECT * FROM user WHERE User_number IN (SELECT User_number FROM participants_list WHERE Trip_number = {tripNumber})");

            int stringCount = dt.Rows.Count;

            for (int i = 0; i < stringCount; i++)
            {
                dataGrid.Rows.Add();
            }

            if (isLeader)
            {
                for (int i = 0; i < stringCount; i++)
                {
                    dataGrid[0, i].Value = i + 1;
                    dataGrid[1, i].Value = dt.Rows[i][2].ToString() + " " + dt.Rows[i][1].ToString() + " " + dt.Rows[i][3].ToString();
                    dataGrid[2, i].Value = DataChecker.BeautyPhone(dt.Rows[i][7].ToString()) + "\n" + dt.Rows[i][8].ToString();

                    string posts = "";
                    DataTable dtb = DB.GetData($"SELECT Name FROM post WHERE Post_number " +
                        $"IN (SELECT Post_number FROM participant_posts WHERE Participant_number " +
                        $"IN (SELECT Participant_number FROM participants_list WHERE Trip_number = {tripNumber} AND User_number = {dt.Rows[i][0]}))");

                    posts += dtb.Rows[0][0];
                    for (int j = 1; j < dtb.Rows.Count; j++)
                    {
                        posts += ", " + char.ToLower((dtb.Rows[j][0].ToString())[0]) + dtb.Rows[j][0].ToString().Substring(1);
                    }

                    dataGrid[3, i].Value = posts;

                    dataGrid[4, i].Value = "Удалить";

                    string deaseses = dt.Rows[i][4].ToString();
                    if (deaseses.Length == 0)
                        dataGrid[5, i].Value = "-";
                    else
                        dataGrid[5, i].Value = deaseses;

                    deaseses = dt.Rows[i][5].ToString();
                    if (deaseses.Length == 0)
                        dataGrid[6, i].Value = "-";
                    else
                        dataGrid[6, i].Value = deaseses;

                    deaseses = dt.Rows[i][6].ToString();
                    if (deaseses.Length == 0)
                        dataGrid[7, i].Value = "-";
                    else
                        dataGrid[7, i].Value = deaseses;
                }
            }
            else
            {
                for (int i = 0; i < stringCount; i++)
                {
                    dataGrid[0, i].Value = i + 1;
                    dataGrid[1, i].Value = dt.Rows[i][2].ToString() + " " + dt.Rows[i][1].ToString() + " " + dt.Rows[i][3].ToString();
                    dataGrid[2, i].Value = DataChecker.BeautyPhone(dt.Rows[i][7].ToString()) + "\n" + dt.Rows[i][8].ToString();

                    string posts = "";
                    DataTable dtb = DB.GetData($"SELECT Name FROM post WHERE Post_number " +
                        $"IN (SELECT Post_number FROM participant_posts WHERE Participant_number " +
                        $"IN (SELECT Participant_number FROM participants_list WHERE Trip_number = {tripNumber} AND User_number = {dt.Rows[i][0]}))");

                    posts += dtb.Rows[0][0];
                    for (int j = 1; j < dtb.Rows.Count; j++)
                    {
                        posts += ", " + char.ToLower((dtb.Rows[j][0].ToString())[0]) + dtb.Rows[j][0].ToString().Substring(1);
                    }

                    dataGrid[3, i].Value = posts;

                    string deaseses = dt.Rows[i][4].ToString();
                    if (deaseses.Length == 0)
                        dataGrid[4, i].Value = "-";
                    else
                        dataGrid[4, i].Value = deaseses;

                    deaseses = dt.Rows[i][5].ToString();
                    if (deaseses.Length == 0)
                        dataGrid[5, i].Value = "-";
                    else
                        dataGrid[5, i].Value = deaseses;

                    deaseses = dt.Rows[i][6].ToString();
                    if (deaseses.Length == 0)
                        dataGrid[6, i].Value = "-";
                    else
                        dataGrid[6, i].Value = deaseses;
                }
            }
        }

        private void DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGrid.Columns.Count == 0 || dataGrid.Rows.Count == 0)
                return;

            if (e.RowIndex >= 0)
            {
                var buttonColumn = dataGrid.Columns[e.ColumnIndex] as DataGridViewButtonColumn;

                if (buttonColumn == dataGrid.Columns[3])
                {
                    int partNumb = (int)dt.Rows[e.RowIndex][0];

                    ChangePostForm changePost = new ChangePostForm(DB.GetParticipantNumber(partNumb, tripNumber), 
                        DB.GetParticipantNumber(userNumber, tripNumber), partNumb, (string)dataGrid[1, e.RowIndex].Value, userNumber);

                    DialogResult dialog = changePost.ShowDialog();

                    if (dialog == DialogResult.Yes)
                    {
                        MyTripListForm myTrip = new MyTripListForm(loginForm, userNumber);
                        Close();
                        myTrip.Show();
                    } 
                    else
                    {
                        dataGrid.Rows.Clear();
                        DownloadData();
                    }
                }
                else if (buttonColumn == dataGrid.Columns[4])
                {
                    if ((int)dt.Rows[e.RowIndex][0] == userNumber)
                    {
                        MessageBox.Show("Вы не можете удалить себя из похода.");
                        return;
                    }

                    DialogResult dialog = MessageBox.Show("Вы уверены, что хотите удалить участника из похода?", "Удаление участника", MessageBoxButtons.YesNo);

                    if (dialog == DialogResult.Yes)
                    {
                        DB.SendPost($"DELETE FROM participants_list WHERE Trip_number = {tripNumber} AND User_number = {dt.Rows[e.RowIndex][0]}");
                        dataGrid.Rows.Clear();
                        DownloadData();
                    }
                }
            }
        }

        private void OutButton_Click(object sender, EventArgs e)
        {
            loginForm.Show();
            Close();
        }

        private void describeButton_Click(object sender, EventArgs e)
        {
            TripDescribingForm describe = new TripDescribingForm(loginForm, tripNumber, userNumber);
            Close();
            describe.Show();
        }

        private void About_Click_1(object sender, EventArgs e)
        {
            AboutForm aboutWindow = new AboutForm();
            aboutWindow.ShowDialog();
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

        private void button1_Click(object sender, EventArgs e)
        {
            AddParticipantForm addParticipant = new AddParticipantForm(tripNumber);
            DialogResult dialog = addParticipant.ShowDialog();
            if (dialog == DialogResult.OK)
            {
                dataGrid.Rows.Clear();
                DownloadData();
            }
        }
    }
}
