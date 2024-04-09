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
    public partial class ChangePostForm : Form
    {
        int partNumber, currentPart, userNumber, curUsNum;
        DataTable dt, dta;
        List<string> postsList;

        public ChangePostForm(int partNumber, int currentPart, int userNumber, string fio, int curUsNum)
        {
            InitializeComponent();
            this.partNumber = partNumber;
            this.currentPart = currentPart;
            this.userNumber = userNumber;
            this.curUsNum = curUsNum;

            label1.Text = fio;

            FillTable();

            dataGrid.CellContentClick += DataGridView_CellContentClick;

            DB.ChangeFont(dataGrid, 18);

            FillBox();

            if (currentPart == partNumber)
                add.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text.Length < 2 || comboBox1.Text.Length > 40)
            {
                MessageBox.Show("Некорректное название должности");
                return;
            }

            bool dataGridInclude = false;

            for (int i = 0; i < dataGrid.Rows.Count; i++)
                if ((string)dataGrid[0, i].Value == comboBox1.Text) {
                    dataGridInclude = true;
                    break;
                }

            if (dataGridInclude)
            {
                MessageBox.Show("Участник уже имеет указанную должность");
                return;
            }

            if (!postsList.Contains(comboBox1.Text))
            {
                DataTable dtTemp = DB.GetData($"SELECT Post_number FROM post WHERE Name = '{comboBox1.Text}'");

                if (dtTemp.Rows.Count == 1)
                {
                    DB.SendPost($"INSERT INTO post_list (User_number, Post_number) VALUES ('{curUsNum}', '{dtTemp.Rows[0][0]}')");
                }
                else
                {
                    DB.SendPost($"INSERT INTO post (Post_number, Name, Responsibilities) VALUES (NULL, '{comboBox1.Text}', NULL)");
                    int pn = (int)DB.GetData("SELECT MAX(Post_number) FROM post").Rows[0][0];
                    DB.SendPost($"INSERT INTO post_list (User_number, Post_number) VALUES ('{curUsNum}', '{pn}')");
                }
            }

            int pnu = (int)DB.GetData($"SELECT Post_number FROM post WHERE Name = '{comboBox1.Text}'").Rows[0][0];

            DB.SendPost($"INSERT INTO participant_posts (Participant_number, Post_number) VALUES ('{partNumber}', '{pnu}')");

            FillTable();
            FillBox();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
            DialogResult = DialogResult.No;
        }

        private void add_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Вы уверены, что хотите передать обязанности руководителя?", "Смена руководителя", MessageBoxButtons.YesNo);

            if (dialog == DialogResult.Yes)
            {
                DB.SendPost($"DELETE FROM participant_posts WHERE Participant_number = {currentPart} AND Post_number = 3");
                DB.SendPost($"INSERT INTO participant_posts (Participant_number, Post_number) VALUES ('{partNumber}', '3')");
                int a = DB.GetData($"SELECT Post_number FROM participant_posts WHERE Participant_number = {currentPart}").Rows.Count;
                if (a == 0)
                    DB.SendPost($"INSERT INTO participant_posts (Participant_number, Post_number) VALUES ('{currentPart}', '12')");
                DialogResult = DialogResult.Yes;
                Close();
            }
        }

        private void DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGrid.Columns.Count == 0 || dataGrid.Rows.Count == 0)
                return;

            if (e.RowIndex >= 0)
            {
                var buttonColumn = dataGrid.Columns[e.ColumnIndex] as DataGridViewButtonColumn;

                if (buttonColumn == dataGrid.Columns[1])
                {
                    if ((string)dataGrid[0, e.RowIndex].Value == "Руководитель")
                    {
                        MessageBox.Show("Если вы хотите снять с себя должность руководителя,\nвам необходимо передать её кому-то другому.");
                        return;
                    }

                    int pnu = (int)DB.GetData($"SELECT Post_number FROM post WHERE Name = '{dataGrid[0, e.RowIndex].Value}'").Rows[0][0];

                    DB.SendPost($"DELETE FROM participant_posts WHERE Participant_number = {partNumber} AND Post_number = {pnu}");

                    int a = DB.GetData($"SELECT Post_number FROM participant_posts WHERE Participant_number = {partNumber}").Rows.Count;
                    if (a == 0)
                        DB.SendPost($"INSERT INTO participant_posts (Participant_number, Post_number) VALUES ('{partNumber}', '12')");

                    FillTable();
                    FillBox();
                }
            }
        }

        private void FillBox()
        {
            List<string> posts = new List<string>();
            foreach (DataRow st in dt.Rows)
                posts.Add(st[0].ToString());

            postsList = new List<string>();
            foreach (DataRow st in dta.Rows)
                postsList.Add(st[0].ToString());

            foreach (DataRow st in dt.Rows)
                posts.Add(st[0].ToString());

            comboBox1.Items.Clear();

            foreach (DataRow st in dta.Rows)
                if (!posts.Contains(st[0].ToString()) && st[0].ToString() != "Руководитель")
                {
                    comboBox1.Items.Add(st[0].ToString());
                }
        }

        private void FillTable()
        {
            dataGrid.Rows.Clear();

            dt = DB.GetData($"SELECT Name FROM post WHERE Post_number IN (SELECT Post_number FROM participant_posts WHERE Participant_number = {partNumber})");
            dta = DB.GetData($"SELECT Name FROM post WHERE Post_number IN (SELECT Post_number FROM post_list WHERE User_number = {curUsNum})");

            int stringCount = dt.Rows.Count;

            for (int i = 0; i < stringCount; i++)
            {
                dataGrid.Rows.Add();
                dataGrid.Rows[i].Height = 30;
            }

            for (int i = 0; i < stringCount; i++)
            {
                dataGrid[0, i].Value = dt.Rows[i][0];
                dataGrid[1, i].Value = "Удалить";
            }
        }
    }
}
