
namespace TripPreparation
{
    partial class CreateTripForm
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
            this.components = new System.ComponentModel.Container();
            this.placeName = new ControlLibrary.NameTextBox(this.components);
            this.regionName = new ControlLibrary.NameTextBox(this.components);
            this.descriptionName = new System.Windows.Forms.RichTextBox();
            this.startDate = new System.Windows.Forms.DateTimePicker();
            this.cancel = new System.Windows.Forms.Button();
            this.createTrip = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.endDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.tripTypes = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // placeName
            // 
            this.placeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.placeName.ForeColor = System.Drawing.Color.Red;
            this.placeName.Location = new System.Drawing.Point(128, 19);
            this.placeName.MaxLength = 40;
            this.placeName.Name = "placeName";
            this.placeName.Size = new System.Drawing.Size(201, 35);
            this.placeName.TabIndex = 0;
            // 
            // regionName
            // 
            this.regionName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.regionName.ForeColor = System.Drawing.Color.Red;
            this.regionName.Location = new System.Drawing.Point(128, 83);
            this.regionName.MaxLength = 40;
            this.regionName.Name = "regionName";
            this.regionName.Size = new System.Drawing.Size(201, 35);
            this.regionName.TabIndex = 1;
            // 
            // descriptionName
            // 
            this.descriptionName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.descriptionName.Location = new System.Drawing.Point(18, 186);
            this.descriptionName.MaxLength = 300;
            this.descriptionName.Name = "descriptionName";
            this.descriptionName.Size = new System.Drawing.Size(311, 254);
            this.descriptionName.TabIndex = 2;
            this.descriptionName.Text = "";
            // 
            // startDate
            // 
            this.startDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startDate.Location = new System.Drawing.Point(590, 26);
            this.startDate.MaxDate = new System.DateTime(2026, 1, 1, 0, 0, 0, 0);
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(200, 29);
            this.startDate.TabIndex = 3;
            // 
            // cancel
            // 
            this.cancel.BackColor = System.Drawing.Color.White;
            this.cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancel.Location = new System.Drawing.Point(442, 405);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(161, 44);
            this.cancel.TabIndex = 9;
            this.cancel.Text = "Отмена";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // createTrip
            // 
            this.createTrip.BackColor = System.Drawing.Color.White;
            this.createTrip.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createTrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.createTrip.Location = new System.Drawing.Point(620, 405);
            this.createTrip.Name = "createTrip";
            this.createTrip.Size = new System.Drawing.Size(202, 44);
            this.createTrip.TabIndex = 10;
            this.createTrip.Text = "Создать поход";
            this.createTrip.UseVisualStyleBackColor = true;
            this.createTrip.Click += new System.EventHandler(this.createTrip_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 31);
            this.label1.TabIndex = 11;
            this.label1.Text = "Место:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 31);
            this.label2.TabIndex = 12;
            this.label2.Text = "Регион:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 31);
            this.label3.TabIndex = 13;
            this.label3.Text = "Описание:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(403, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 31);
            this.label4.TabIndex = 14;
            this.label4.Text = "Дата начала:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(403, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 31);
            this.label5.TabIndex = 15;
            this.label5.Text = "Дата конца:";
            // 
            // endDate
            // 
            this.endDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.endDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.endDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.endDate.Location = new System.Drawing.Point(590, 75);
            this.endDate.MaxDate = new System.DateTime(2026, 1, 1, 0, 0, 0, 0);
            this.endDate.Name = "endDate";
            this.endDate.Size = new System.Drawing.Size(200, 29);
            this.endDate.TabIndex = 16;
            this.endDate.Value = new System.DateTime(2023, 3, 25, 0, 0, 0, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(403, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 31);
            this.label6.TabIndex = 17;
            this.label6.Text = "Вид:";
            // 
            // tripTypes
            // 
            this.tripTypes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tripTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tripTypes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tripTypes.FormattingEnabled = true;
            this.tripTypes.Location = new System.Drawing.Point(480, 152);
            this.tripTypes.Name = "tripTypes";
            this.tripTypes.Size = new System.Drawing.Size(200, 33);
            this.tripTypes.TabIndex = 18;
            // 
            // CreateTripForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.cancel;
            this.ClientSize = new System.Drawing.Size(834, 461);
            this.Controls.Add(this.tripTypes);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.endDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.createTrip);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.startDate);
            this.Controls.Add(this.descriptionName);
            this.Controls.Add(this.regionName);
            this.Controls.Add(this.placeName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "CreateTripForm";
            this.Text = "Создание похода";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ControlLibrary.NameTextBox placeName;
        private ControlLibrary.NameTextBox regionName;
        private System.Windows.Forms.RichTextBox descriptionName;
        private System.Windows.Forms.DateTimePicker startDate;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button createTrip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker endDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox tripTypes;
    }
}