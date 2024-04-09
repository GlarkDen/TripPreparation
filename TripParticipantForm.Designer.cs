
namespace TripPreparation
{
    partial class TripParticipantForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tripName = new System.Windows.Forms.Label();
            this.myTrips = new System.Windows.Forms.Button();
            this.MyProfile = new System.Windows.Forms.Button();
            this.userInfo = new System.Windows.Forms.Label();
            this.toolkitButton = new System.Windows.Forms.Button();
            this.dutyButton = new System.Windows.Forms.Button();
            this.tentButton = new System.Windows.Forms.Button();
            this.routeButton = new System.Windows.Forms.Button();
            this.firstkitButton = new System.Windows.Forms.Button();
            this.planButton = new System.Windows.Forms.Button();
            this.moneyButton = new System.Windows.Forms.Button();
            this.foodButton = new System.Windows.Forms.Button();
            this.productButton = new System.Windows.Forms.Button();
            this.equipmentButton = new System.Windows.Forms.Button();
            this.participantButton = new System.Windows.Forms.Button();
            this.describeButton = new System.Windows.Forms.Button();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.About = new System.Windows.Forms.Button();
            this.OutButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // tripName
            // 
            this.tripName.AutoSize = true;
            this.tripName.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tripName.Location = new System.Drawing.Point(395, 131);
            this.tripName.Name = "tripName";
            this.tripName.Size = new System.Drawing.Size(188, 39);
            this.tripName.TabIndex = 66;
            this.tripName.Text = "Участники";
            // 
            // myTrips
            // 
            this.myTrips.Cursor = System.Windows.Forms.Cursors.Hand;
            this.myTrips.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.myTrips.Location = new System.Drawing.Point(715, 32);
            this.myTrips.Name = "myTrips";
            this.myTrips.Size = new System.Drawing.Size(264, 54);
            this.myTrips.TabIndex = 53;
            this.myTrips.Text = "Мои походы";
            this.myTrips.UseVisualStyleBackColor = true;
            this.myTrips.Click += new System.EventHandler(this.myTrips_Click);
            // 
            // MyProfile
            // 
            this.MyProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MyProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MyProfile.Location = new System.Drawing.Point(1004, 32);
            this.MyProfile.Name = "MyProfile";
            this.MyProfile.Size = new System.Drawing.Size(264, 54);
            this.MyProfile.TabIndex = 52;
            this.MyProfile.Text = "Профиль";
            this.MyProfile.UseVisualStyleBackColor = true;
            this.MyProfile.Click += new System.EventHandler(this.MyProfile_Click);
            // 
            // userInfo
            // 
            this.userInfo.AutoSize = true;
            this.userInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userInfo.Location = new System.Drawing.Point(23, 25);
            this.userInfo.Name = "userInfo";
            this.userInfo.Size = new System.Drawing.Size(336, 31);
            this.userInfo.TabIndex = 51;
            this.userInfo.Text = "Денис Вячеславович, №1";
            // 
            // toolkitButton
            // 
            this.toolkitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.toolkitButton.Enabled = false;
            this.toolkitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolkitButton.Location = new System.Drawing.Point(29, 792);
            this.toolkitButton.Name = "toolkitButton";
            this.toolkitButton.Size = new System.Drawing.Size(261, 47);
            this.toolkitButton.TabIndex = 78;
            this.toolkitButton.Text = "Ремнабор";
            this.toolkitButton.UseVisualStyleBackColor = true;
            // 
            // dutyButton
            // 
            this.dutyButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dutyButton.Enabled = false;
            this.dutyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dutyButton.Location = new System.Drawing.Point(29, 731);
            this.dutyButton.Name = "dutyButton";
            this.dutyButton.Size = new System.Drawing.Size(261, 47);
            this.dutyButton.TabIndex = 77;
            this.dutyButton.Text = "Дежурство";
            this.dutyButton.UseVisualStyleBackColor = true;
            // 
            // tentButton
            // 
            this.tentButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tentButton.Enabled = false;
            this.tentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tentButton.Location = new System.Drawing.Point(29, 671);
            this.tentButton.Name = "tentButton";
            this.tentButton.Size = new System.Drawing.Size(261, 47);
            this.tentButton.TabIndex = 76;
            this.tentButton.Text = "Палатки и суда";
            this.tentButton.UseVisualStyleBackColor = true;
            // 
            // routeButton
            // 
            this.routeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.routeButton.Enabled = false;
            this.routeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.routeButton.Location = new System.Drawing.Point(29, 612);
            this.routeButton.Name = "routeButton";
            this.routeButton.Size = new System.Drawing.Size(261, 47);
            this.routeButton.TabIndex = 75;
            this.routeButton.Text = "Маршрут";
            this.routeButton.UseVisualStyleBackColor = true;
            // 
            // firstkitButton
            // 
            this.firstkitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.firstkitButton.Enabled = false;
            this.firstkitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.firstkitButton.Location = new System.Drawing.Point(29, 550);
            this.firstkitButton.Name = "firstkitButton";
            this.firstkitButton.Size = new System.Drawing.Size(261, 47);
            this.firstkitButton.TabIndex = 74;
            this.firstkitButton.Text = "Аптечка";
            this.firstkitButton.UseVisualStyleBackColor = true;
            // 
            // planButton
            // 
            this.planButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.planButton.Enabled = false;
            this.planButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.planButton.Location = new System.Drawing.Point(29, 485);
            this.planButton.Name = "planButton";
            this.planButton.Size = new System.Drawing.Size(261, 47);
            this.planButton.TabIndex = 73;
            this.planButton.Text = "План";
            this.planButton.UseVisualStyleBackColor = true;
            // 
            // moneyButton
            // 
            this.moneyButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.moneyButton.Enabled = false;
            this.moneyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.moneyButton.Location = new System.Drawing.Point(29, 420);
            this.moneyButton.Name = "moneyButton";
            this.moneyButton.Size = new System.Drawing.Size(261, 47);
            this.moneyButton.TabIndex = 72;
            this.moneyButton.Text = "Финансы";
            this.moneyButton.UseVisualStyleBackColor = true;
            // 
            // foodButton
            // 
            this.foodButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.foodButton.Enabled = false;
            this.foodButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.foodButton.Location = new System.Drawing.Point(29, 354);
            this.foodButton.Name = "foodButton";
            this.foodButton.Size = new System.Drawing.Size(261, 47);
            this.foodButton.TabIndex = 71;
            this.foodButton.Text = "Питание";
            this.foodButton.UseVisualStyleBackColor = true;
            // 
            // productButton
            // 
            this.productButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.productButton.Enabled = false;
            this.productButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productButton.Location = new System.Drawing.Point(29, 292);
            this.productButton.Name = "productButton";
            this.productButton.Size = new System.Drawing.Size(261, 47);
            this.productButton.TabIndex = 70;
            this.productButton.Text = "Продукты";
            this.productButton.UseVisualStyleBackColor = true;
            // 
            // equipmentButton
            // 
            this.equipmentButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.equipmentButton.Enabled = false;
            this.equipmentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.equipmentButton.Location = new System.Drawing.Point(29, 231);
            this.equipmentButton.Name = "equipmentButton";
            this.equipmentButton.Size = new System.Drawing.Size(261, 47);
            this.equipmentButton.TabIndex = 69;
            this.equipmentButton.Text = "Снаряжение";
            this.equipmentButton.UseVisualStyleBackColor = true;
            // 
            // participantButton
            // 
            this.participantButton.BackColor = System.Drawing.Color.Cornsilk;
            this.participantButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.participantButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.participantButton.Location = new System.Drawing.Point(29, 171);
            this.participantButton.Name = "participantButton";
            this.participantButton.Size = new System.Drawing.Size(261, 47);
            this.participantButton.TabIndex = 68;
            this.participantButton.Text = "Участники";
            this.participantButton.UseVisualStyleBackColor = false;
            // 
            // describeButton
            // 
            this.describeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.describeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.describeButton.Location = new System.Drawing.Point(29, 108);
            this.describeButton.Name = "describeButton";
            this.describeButton.Size = new System.Drawing.Size(261, 47);
            this.describeButton.TabIndex = 79;
            this.describeButton.Text = "Описание";
            this.describeButton.UseVisualStyleBackColor = true;
            this.describeButton.Click += new System.EventHandler(this.describeButton_Click);
            // 
            // dataGrid
            // 
            this.dataGrid.AllowUserToAddRows = false;
            this.dataGrid.AllowUserToDeleteRows = false;
            this.dataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGrid.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGrid.Location = new System.Drawing.Point(402, 183);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGrid.Size = new System.Drawing.Size(964, 535);
            this.dataGrid.TabIndex = 80;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(735, 733);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(315, 54);
            this.button1.TabIndex = 81;
            this.button1.Text = "Новый участник";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // About
            // 
            this.About.Cursor = System.Windows.Forms.Cursors.Hand;
            this.About.FlatAppearance.BorderSize = 0;
            this.About.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.About.ForeColor = System.Drawing.Color.White;
            this.About.Image = global::TripPreparation.Properties.Resources.About;
            this.About.Location = new System.Drawing.Point(1291, 13);
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(81, 81);
            this.About.TabIndex = 50;
            this.About.UseVisualStyleBackColor = true;
            this.About.Click += new System.EventHandler(this.About_Click_1);
            // 
            // OutButton
            // 
            this.OutButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OutButton.FlatAppearance.BorderSize = 0;
            this.OutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OutButton.ForeColor = System.Drawing.Color.White;
            this.OutButton.Image = global::TripPreparation.Properties.Resources.Out;
            this.OutButton.Location = new System.Drawing.Point(1379, 13);
            this.OutButton.Name = "OutButton";
            this.OutButton.Size = new System.Drawing.Size(81, 81);
            this.OutButton.TabIndex = 49;
            this.OutButton.UseVisualStyleBackColor = true;
            this.OutButton.Click += new System.EventHandler(this.OutButton_Click);
            // 
            // TripParticipantForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1484, 861);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.describeButton);
            this.Controls.Add(this.toolkitButton);
            this.Controls.Add(this.dutyButton);
            this.Controls.Add(this.tentButton);
            this.Controls.Add(this.routeButton);
            this.Controls.Add(this.firstkitButton);
            this.Controls.Add(this.planButton);
            this.Controls.Add(this.moneyButton);
            this.Controls.Add(this.foodButton);
            this.Controls.Add(this.productButton);
            this.Controls.Add(this.equipmentButton);
            this.Controls.Add(this.participantButton);
            this.Controls.Add(this.tripName);
            this.Controls.Add(this.myTrips);
            this.Controls.Add(this.MyProfile);
            this.Controls.Add(this.userInfo);
            this.Controls.Add(this.About);
            this.Controls.Add(this.OutButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "TripParticipantForm";
            this.Text = "Участники похода";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label tripName;
        private System.Windows.Forms.Button myTrips;
        private System.Windows.Forms.Button MyProfile;
        public System.Windows.Forms.Label userInfo;
        private System.Windows.Forms.Button About;
        private System.Windows.Forms.Button OutButton;
        private System.Windows.Forms.Button toolkitButton;
        private System.Windows.Forms.Button dutyButton;
        private System.Windows.Forms.Button tentButton;
        private System.Windows.Forms.Button routeButton;
        private System.Windows.Forms.Button firstkitButton;
        private System.Windows.Forms.Button planButton;
        private System.Windows.Forms.Button moneyButton;
        private System.Windows.Forms.Button foodButton;
        private System.Windows.Forms.Button productButton;
        private System.Windows.Forms.Button equipmentButton;
        private System.Windows.Forms.Button participantButton;
        private System.Windows.Forms.Button describeButton;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.Button button1;
    }
}