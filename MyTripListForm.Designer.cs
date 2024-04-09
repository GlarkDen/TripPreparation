
namespace TripPreparation
{
    partial class MyTripListForm
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
            this.userInfo = new System.Windows.Forms.Label();
            this.myTrips = new System.Windows.Forms.Button();
            this.MyProfile = new System.Windows.Forms.Button();
            this.CreateTrip = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.OutButton = new System.Windows.Forms.Button();
            this.About = new System.Windows.Forms.Button();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.NameTrip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dates = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Go = new System.Windows.Forms.DataGridViewButtonColumn();
            this.leave = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // userInfo
            // 
            this.userInfo.AutoSize = true;
            this.userInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userInfo.Location = new System.Drawing.Point(23, 28);
            this.userInfo.Name = "userInfo";
            this.userInfo.Size = new System.Drawing.Size(336, 31);
            this.userInfo.TabIndex = 6;
            this.userInfo.Text = "Денис Вячеславович, №1";
            // 
            // myTrips
            // 
            this.myTrips.BackColor = System.Drawing.Color.Cornsilk;
            this.myTrips.Cursor = System.Windows.Forms.Cursors.Hand;
            this.myTrips.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.myTrips.Location = new System.Drawing.Point(714, 32);
            this.myTrips.Name = "myTrips";
            this.myTrips.Size = new System.Drawing.Size(264, 54);
            this.myTrips.TabIndex = 7;
            this.myTrips.Text = "Мои походы";
            this.myTrips.UseVisualStyleBackColor = false;
            // 
            // MyProfile
            // 
            this.MyProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MyProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MyProfile.Location = new System.Drawing.Point(1005, 32);
            this.MyProfile.Name = "MyProfile";
            this.MyProfile.Size = new System.Drawing.Size(264, 54);
            this.MyProfile.TabIndex = 8;
            this.MyProfile.Text = "Профиль";
            this.MyProfile.UseVisualStyleBackColor = true;
            this.MyProfile.Click += new System.EventHandler(this.MyProfile_Click);
            // 
            // CreateTrip
            // 
            this.CreateTrip.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CreateTrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreateTrip.Location = new System.Drawing.Point(29, 126);
            this.CreateTrip.Name = "CreateTrip";
            this.CreateTrip.Size = new System.Drawing.Size(264, 54);
            this.CreateTrip.TabIndex = 9;
            this.CreateTrip.Text = "Создать поход...";
            this.CreateTrip.UseVisualStyleBackColor = true;
            this.CreateTrip.Click += new System.EventHandler(this.CreateTrip_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(401, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 39);
            this.label4.TabIndex = 15;
            this.label4.Text = "Походы";
            // 
            // OutButton
            // 
            this.OutButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OutButton.FlatAppearance.BorderSize = 0;
            this.OutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OutButton.ForeColor = System.Drawing.Color.White;
            this.OutButton.Image = global::TripPreparation.Properties.Resources.Out;
            this.OutButton.Location = new System.Drawing.Point(1379, 18);
            this.OutButton.Name = "OutButton";
            this.OutButton.Size = new System.Drawing.Size(81, 81);
            this.OutButton.TabIndex = 5;
            this.OutButton.UseVisualStyleBackColor = true;
            this.OutButton.Click += new System.EventHandler(this.OutButton_Click);
            // 
            // About
            // 
            this.About.Cursor = System.Windows.Forms.Cursors.Hand;
            this.About.FlatAppearance.BorderSize = 0;
            this.About.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.About.ForeColor = System.Drawing.Color.White;
            this.About.Image = global::TripPreparation.Properties.Resources.About;
            this.About.Location = new System.Drawing.Point(1290, 18);
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(81, 81);
            this.About.TabIndex = 16;
            this.About.UseVisualStyleBackColor = true;
            this.About.Click += new System.EventHandler(this.About_Click);
            // 
            // dataGrid
            // 
            this.dataGrid.AllowUserToAddRows = false;
            this.dataGrid.AllowUserToDeleteRows = false;
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
            this.dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameTrip,
            this.Dates,
            this.Go,
            this.leave});
            this.dataGrid.Location = new System.Drawing.Point(408, 186);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGrid.Size = new System.Drawing.Size(963, 581);
            this.dataGrid.TabIndex = 17;
            // 
            // NameTrip
            // 
            this.NameTrip.Frozen = true;
            this.NameTrip.HeaderText = "Название";
            this.NameTrip.Name = "NameTrip";
            this.NameTrip.ReadOnly = true;
            this.NameTrip.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.NameTrip.Width = 345;
            // 
            // Dates
            // 
            this.Dates.HeaderText = "Даты";
            this.Dates.Name = "Dates";
            this.Dates.ReadOnly = true;
            this.Dates.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Dates.Width = 345;
            // 
            // Go
            // 
            this.Go.HeaderText = "Перейти";
            this.Go.Name = "Go";
            this.Go.ReadOnly = true;
            this.Go.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Go.Text = "К походу";
            this.Go.Width = 115;
            // 
            // leave
            // 
            this.leave.HeaderText = "Выход";
            this.leave.Name = "leave";
            this.leave.ReadOnly = true;
            this.leave.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.leave.Text = "Выйти";
            this.leave.Width = 115;
            // 
            // MyTripListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1484, 861);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.About);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CreateTrip);
            this.Controls.Add(this.MyProfile);
            this.Controls.Add(this.myTrips);
            this.Controls.Add(this.userInfo);
            this.Controls.Add(this.OutButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MyTripListForm";
            this.Text = "Мои походы";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OutButton;
        private System.Windows.Forms.Button myTrips;
        private System.Windows.Forms.Button MyProfile;
        private System.Windows.Forms.Button CreateTrip;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button About;
        public System.Windows.Forms.Label userInfo;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameTrip;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dates;
        private System.Windows.Forms.DataGridViewButtonColumn Go;
        private System.Windows.Forms.DataGridViewButtonColumn leave;
    }
}