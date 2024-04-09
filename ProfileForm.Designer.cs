
namespace TripPreparation
{
    partial class ProfileForm
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
            this.myTrips = new System.Windows.Forms.Button();
            this.MyProfile = new System.Windows.Forms.Button();
            this.userInfo = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.phoneText = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.npas3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.patrText = new ControlLibrary.NameTextBox(this.components);
            this.surnameText = new ControlLibrary.NameTextBox(this.components);
            this.nameText = new ControlLibrary.NameTextBox(this.components);
            this.emailText = new ControlLibrary.EmailTextBox(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.passChange = new System.Windows.Forms.Button();
            this.newPass1 = new ControlLibrary.PasswordTextBox(this.components);
            this.newPass2 = new ControlLibrary.PasswordTextBox(this.components);
            this.npas1 = new System.Windows.Forms.Label();
            this.npas2 = new System.Windows.Forms.Label();
            this.changeButton = new System.Windows.Forms.Button();
            this.helpPass = new System.Windows.Forms.PictureBox();
            this.About = new System.Windows.Forms.Button();
            this.OutButton = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.allergiesText = new System.Windows.Forms.RichTextBox();
            this.deseasesText = new System.Windows.Forms.RichTextBox();
            this.medicineText = new System.Windows.Forms.RichTextBox();
            this.lastPass = new System.Windows.Forms.MaskedTextBox();
            this.pasCans = new System.Windows.Forms.Button();
            this.passConf = new System.Windows.Forms.Button();
            this.passwordText = new System.Windows.Forms.MaskedTextBox();
            this.saveInfo = new System.Windows.Forms.Button();
            this.cansInfo = new System.Windows.Forms.Button();
            this.deleteAcc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.helpPass)).BeginInit();
            this.SuspendLayout();
            // 
            // myTrips
            // 
            this.myTrips.BackColor = System.Drawing.Color.White;
            this.myTrips.Cursor = System.Windows.Forms.Cursors.Hand;
            this.myTrips.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.myTrips.Location = new System.Drawing.Point(717, 33);
            this.myTrips.Name = "myTrips";
            this.myTrips.Size = new System.Drawing.Size(264, 54);
            this.myTrips.TabIndex = 8;
            this.myTrips.Text = "Мои походы";
            this.myTrips.UseVisualStyleBackColor = true;
            this.myTrips.Click += new System.EventHandler(this.myTrips_Click);
            // 
            // MyProfile
            // 
            this.MyProfile.BackColor = System.Drawing.Color.Cornsilk;
            this.MyProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MyProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MyProfile.Location = new System.Drawing.Point(1001, 33);
            this.MyProfile.Name = "MyProfile";
            this.MyProfile.Size = new System.Drawing.Size(264, 54);
            this.MyProfile.TabIndex = 9;
            this.MyProfile.Text = "Профиль";
            this.MyProfile.UseVisualStyleBackColor = false;
            // 
            // userInfo
            // 
            this.userInfo.AutoSize = true;
            this.userInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userInfo.Location = new System.Drawing.Point(24, 26);
            this.userInfo.Name = "userInfo";
            this.userInfo.Size = new System.Drawing.Size(336, 31);
            this.userInfo.TabIndex = 11;
            this.userInfo.Text = "Денис Вячеславович, №1";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Enabled = false;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(30, 116);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(309, 54);
            this.button1.TabIndex = 13;
            this.button1.Text = "Справочные таблицы";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // phoneText
            // 
            this.phoneText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phoneText.Location = new System.Drawing.Point(564, 409);
            this.phoneText.Mask = "0 (000) 000-00-00";
            this.phoneText.Name = "phoneText";
            this.phoneText.ReadOnly = true;
            this.phoneText.Size = new System.Drawing.Size(253, 38);
            this.phoneText.TabIndex = 34;
            this.phoneText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(408, 409);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 33);
            this.label7.TabIndex = 32;
            this.label7.Text = "Телефон:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(407, 301);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 33);
            this.label6.TabIndex = 31;
            this.label6.Text = "Отчество:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(408, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 33);
            this.label5.TabIndex = 30;
            this.label5.Text = "Фамилия:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(407, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 33);
            this.label4.TabIndex = 29;
            this.label4.Text = "Имя:";
            // 
            // npas3
            // 
            this.npas3.AutoSize = true;
            this.npas3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.npas3.Location = new System.Drawing.Point(1018, 671);
            this.npas3.Name = "npas3";
            this.npas3.Size = new System.Drawing.Size(261, 33);
            this.npas3.TabIndex = 28;
            this.npas3.Text = "Повторите пароль";
            this.npas3.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(408, 517);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 33);
            this.label2.TabIndex = 27;
            this.label2.Text = "Пароль:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(408, 463);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 33);
            this.label1.TabIndex = 26;
            this.label1.Text = "Логин:";
            // 
            // patrText
            // 
            this.patrText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.patrText.Location = new System.Drawing.Point(564, 301);
            this.patrText.MaxLength = 30;
            this.patrText.Name = "patrText";
            this.patrText.ReadOnly = true;
            this.patrText.Size = new System.Drawing.Size(253, 38);
            this.patrText.TabIndex = 25;
            // 
            // surnameText
            // 
            this.surnameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.surnameText.Location = new System.Drawing.Point(564, 246);
            this.surnameText.MaxLength = 30;
            this.surnameText.Name = "surnameText";
            this.surnameText.ReadOnly = true;
            this.surnameText.Size = new System.Drawing.Size(253, 38);
            this.surnameText.TabIndex = 24;
            // 
            // nameText
            // 
            this.nameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameText.Location = new System.Drawing.Point(564, 193);
            this.nameText.MaxLength = 30;
            this.nameText.Name = "nameText";
            this.nameText.ReadOnly = true;
            this.nameText.Size = new System.Drawing.Size(253, 38);
            this.nameText.TabIndex = 23;
            // 
            // emailText
            // 
            this.emailText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.emailText.ForeColor = System.Drawing.Color.Red;
            this.emailText.Location = new System.Drawing.Point(564, 463);
            this.emailText.MaxLength = 30;
            this.emailText.Name = "emailText";
            this.emailText.ReadOnly = true;
            this.emailText.Size = new System.Drawing.Size(253, 38);
            this.emailText.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(406, 122);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(167, 39);
            this.label8.TabIndex = 35;
            this.label8.Text = "Профиль";
            // 
            // passChange
            // 
            this.passChange.BackColor = System.Drawing.Color.White;
            this.passChange.Cursor = System.Windows.Forms.Cursors.Hand;
            this.passChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passChange.Location = new System.Drawing.Point(564, 587);
            this.passChange.Name = "passChange";
            this.passChange.Size = new System.Drawing.Size(253, 47);
            this.passChange.TabIndex = 36;
            this.passChange.Text = "Сменить пароль";
            this.passChange.UseVisualStyleBackColor = false;
            this.passChange.Click += new System.EventHandler(this.passChange_Click);
            // 
            // newPass1
            // 
            this.newPass1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newPass1.ForeColor = System.Drawing.Color.Red;
            this.newPass1.Location = new System.Drawing.Point(706, 707);
            this.newPass1.Name = "newPass1";
            this.newPass1.Size = new System.Drawing.Size(241, 38);
            this.newPass1.TabIndex = 38;
            this.newPass1.UseSystemPasswordChar = true;
            this.newPass1.Visible = false;
            // 
            // newPass2
            // 
            this.newPass2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newPass2.ForeColor = System.Drawing.Color.Red;
            this.newPass2.Location = new System.Drawing.Point(1024, 707);
            this.newPass2.Name = "newPass2";
            this.newPass2.Size = new System.Drawing.Size(241, 38);
            this.newPass2.TabIndex = 39;
            this.newPass2.UseSystemPasswordChar = true;
            this.newPass2.Visible = false;
            // 
            // npas1
            // 
            this.npas1.AutoSize = true;
            this.npas1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.npas1.Location = new System.Drawing.Point(424, 671);
            this.npas1.Name = "npas1";
            this.npas1.Size = new System.Drawing.Size(222, 33);
            this.npas1.TabIndex = 40;
            this.npas1.Text = "Старый пароль";
            this.npas1.Visible = false;
            // 
            // npas2
            // 
            this.npas2.AutoSize = true;
            this.npas2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.npas2.Location = new System.Drawing.Point(724, 671);
            this.npas2.Name = "npas2";
            this.npas2.Size = new System.Drawing.Size(208, 33);
            this.npas2.TabIndex = 41;
            this.npas2.Text = "Новый пароль";
            this.npas2.Visible = false;
            // 
            // changeButton
            // 
            this.changeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.changeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.changeButton.FlatAppearance.BorderSize = 0;
            this.changeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeButton.Image = global::TripPreparation.Properties.Resources.Change;
            this.changeButton.Location = new System.Drawing.Point(579, 122);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(41, 41);
            this.changeButton.TabIndex = 42;
            this.changeButton.UseVisualStyleBackColor = true;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // helpPass
            // 
            this.helpPass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.helpPass.Cursor = System.Windows.Forms.Cursors.Help;
            this.helpPass.Enabled = false;
            this.helpPass.Image = global::TripPreparation.Properties.Resources.Help;
            this.helpPass.Location = new System.Drawing.Point(953, 711);
            this.helpPass.Name = "helpPass";
            this.helpPass.Size = new System.Drawing.Size(30, 30);
            this.helpPass.TabIndex = 33;
            this.helpPass.TabStop = false;
            this.helpPass.Visible = false;
            // 
            // About
            // 
            this.About.Cursor = System.Windows.Forms.Cursors.Hand;
            this.About.FlatAppearance.BorderSize = 0;
            this.About.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.About.ForeColor = System.Drawing.Color.White;
            this.About.Image = global::TripPreparation.Properties.Resources.About;
            this.About.Location = new System.Drawing.Point(1284, 14);
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(81, 81);
            this.About.TabIndex = 12;
            this.About.UseVisualStyleBackColor = true;
            this.About.Click += new System.EventHandler(this.About_Click);
            // 
            // OutButton
            // 
            this.OutButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OutButton.FlatAppearance.BorderSize = 0;
            this.OutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OutButton.ForeColor = System.Drawing.Color.White;
            this.OutButton.Image = global::TripPreparation.Properties.Resources.Out;
            this.OutButton.Location = new System.Drawing.Point(1375, 16);
            this.OutButton.Name = "OutButton";
            this.OutButton.Size = new System.Drawing.Size(81, 81);
            this.OutButton.TabIndex = 10;
            this.OutButton.UseVisualStyleBackColor = true;
            this.OutButton.Click += new System.EventHandler(this.OutButton_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(968, 503);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(373, 33);
            this.label11.TabIndex = 48;
            this.label11.Text = "Принимаемые препараты:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(968, 347);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(383, 33);
            this.label12.TabIndex = 47;
            this.label12.Text = "Хронические заболевания:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(968, 193);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(151, 33);
            this.label13.TabIndex = 46;
            this.label13.Text = "Аллергии:";
            // 
            // allergiesText
            // 
            this.allergiesText.BackColor = System.Drawing.Color.White;
            this.allergiesText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.allergiesText.Location = new System.Drawing.Point(974, 229);
            this.allergiesText.MaxLength = 249;
            this.allergiesText.Name = "allergiesText";
            this.allergiesText.ReadOnly = true;
            this.allergiesText.Size = new System.Drawing.Size(406, 87);
            this.allergiesText.TabIndex = 49;
            this.allergiesText.Text = "";
            // 
            // deseasesText
            // 
            this.deseasesText.BackColor = System.Drawing.Color.White;
            this.deseasesText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deseasesText.Location = new System.Drawing.Point(974, 383);
            this.deseasesText.MaxLength = 249;
            this.deseasesText.Name = "deseasesText";
            this.deseasesText.ReadOnly = true;
            this.deseasesText.Size = new System.Drawing.Size(406, 87);
            this.deseasesText.TabIndex = 50;
            this.deseasesText.Text = "";
            // 
            // medicineText
            // 
            this.medicineText.BackColor = System.Drawing.Color.White;
            this.medicineText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.medicineText.Location = new System.Drawing.Point(974, 539);
            this.medicineText.MaxLength = 249;
            this.medicineText.Name = "medicineText";
            this.medicineText.ReadOnly = true;
            this.medicineText.Size = new System.Drawing.Size(406, 95);
            this.medicineText.TabIndex = 51;
            this.medicineText.Text = "";
            // 
            // lastPass
            // 
            this.lastPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lastPass.Location = new System.Drawing.Point(414, 707);
            this.lastPass.Name = "lastPass";
            this.lastPass.Size = new System.Drawing.Size(241, 38);
            this.lastPass.TabIndex = 52;
            this.lastPass.UseSystemPasswordChar = true;
            this.lastPass.Visible = false;
            // 
            // pasCans
            // 
            this.pasCans.BackColor = System.Drawing.Color.White;
            this.pasCans.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pasCans.Enabled = false;
            this.pasCans.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pasCans.Location = new System.Drawing.Point(413, 774);
            this.pasCans.Name = "pasCans";
            this.pasCans.Size = new System.Drawing.Size(242, 47);
            this.pasCans.TabIndex = 53;
            this.pasCans.Text = "Отмена";
            this.pasCans.UseVisualStyleBackColor = false;
            this.pasCans.Visible = false;
            this.pasCans.Click += new System.EventHandler(this.pasCans_Click);
            // 
            // passConf
            // 
            this.passConf.BackColor = System.Drawing.Color.White;
            this.passConf.Cursor = System.Windows.Forms.Cursors.Hand;
            this.passConf.Enabled = false;
            this.passConf.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passConf.Location = new System.Drawing.Point(706, 774);
            this.passConf.Name = "passConf";
            this.passConf.Size = new System.Drawing.Size(241, 47);
            this.passConf.TabIndex = 54;
            this.passConf.Text = "Сменить";
            this.passConf.UseVisualStyleBackColor = false;
            this.passConf.Visible = false;
            this.passConf.Click += new System.EventHandler(this.passConf_Click);
            // 
            // passwordText
            // 
            this.passwordText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordText.Location = new System.Drawing.Point(564, 517);
            this.passwordText.Name = "passwordText";
            this.passwordText.ReadOnly = true;
            this.passwordText.Size = new System.Drawing.Size(253, 38);
            this.passwordText.TabIndex = 55;
            this.passwordText.UseSystemPasswordChar = true;
            // 
            // saveInfo
            // 
            this.saveInfo.BackColor = System.Drawing.Color.White;
            this.saveInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveInfo.Enabled = false;
            this.saveInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveInfo.Location = new System.Drawing.Point(920, 118);
            this.saveInfo.Name = "saveInfo";
            this.saveInfo.Size = new System.Drawing.Size(322, 47);
            this.saveInfo.TabIndex = 57;
            this.saveInfo.Text = "Сохранить изменения";
            this.saveInfo.UseVisualStyleBackColor = false;
            this.saveInfo.Visible = false;
            this.saveInfo.Click += new System.EventHandler(this.saveInfo_Click);
            // 
            // cansInfo
            // 
            this.cansInfo.BackColor = System.Drawing.Color.White;
            this.cansInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cansInfo.Enabled = false;
            this.cansInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cansInfo.Location = new System.Drawing.Point(650, 118);
            this.cansInfo.Name = "cansInfo";
            this.cansInfo.Size = new System.Drawing.Size(242, 47);
            this.cansInfo.TabIndex = 56;
            this.cansInfo.Text = "Отмена";
            this.cansInfo.UseVisualStyleBackColor = false;
            this.cansInfo.Visible = false;
            this.cansInfo.Click += new System.EventHandler(this.cansInfo_Click);
            // 
            // deleteAcc
            // 
            this.deleteAcc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.deleteAcc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteAcc.Location = new System.Drawing.Point(30, 184);
            this.deleteAcc.Name = "deleteAcc";
            this.deleteAcc.Size = new System.Drawing.Size(309, 54);
            this.deleteAcc.TabIndex = 58;
            this.deleteAcc.Text = "Удалить аккаунт";
            this.deleteAcc.UseVisualStyleBackColor = false;
            this.deleteAcc.Click += new System.EventHandler(this.deleteAcc_Click);
            // 
            // ProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1484, 861);
            this.Controls.Add(this.deleteAcc);
            this.Controls.Add(this.saveInfo);
            this.Controls.Add(this.cansInfo);
            this.Controls.Add(this.passwordText);
            this.Controls.Add(this.passConf);
            this.Controls.Add(this.pasCans);
            this.Controls.Add(this.lastPass);
            this.Controls.Add(this.medicineText);
            this.Controls.Add(this.deseasesText);
            this.Controls.Add(this.allergiesText);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.npas2);
            this.Controls.Add(this.npas1);
            this.Controls.Add(this.newPass2);
            this.Controls.Add(this.newPass1);
            this.Controls.Add(this.passChange);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.phoneText);
            this.Controls.Add(this.helpPass);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.npas3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.patrText);
            this.Controls.Add(this.surnameText);
            this.Controls.Add(this.nameText);
            this.Controls.Add(this.emailText);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.About);
            this.Controls.Add(this.userInfo);
            this.Controls.Add(this.OutButton);
            this.Controls.Add(this.MyProfile);
            this.Controls.Add(this.myTrips);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ProfileForm";
            this.Text = "Профиль";
            ((System.ComponentModel.ISupportInitialize)(this.helpPass)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button myTrips;
        private System.Windows.Forms.Button MyProfile;
        private System.Windows.Forms.Button OutButton;
        private System.Windows.Forms.Label userInfo;
        private System.Windows.Forms.Button About;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox phoneText;
        private System.Windows.Forms.PictureBox helpPass;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label npas3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private ControlLibrary.NameTextBox patrText;
        private ControlLibrary.NameTextBox surnameText;
        private ControlLibrary.NameTextBox nameText;
        private ControlLibrary.EmailTextBox emailText;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button passChange;
        private ControlLibrary.PasswordTextBox newPass1;
        private ControlLibrary.PasswordTextBox newPass2;
        private System.Windows.Forms.Label npas1;
        private System.Windows.Forms.Label npas2;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.RichTextBox allergiesText;
        private System.Windows.Forms.RichTextBox deseasesText;
        private System.Windows.Forms.RichTextBox medicineText;
        private System.Windows.Forms.MaskedTextBox lastPass;
        private System.Windows.Forms.Button pasCans;
        private System.Windows.Forms.Button passConf;
        private System.Windows.Forms.MaskedTextBox passwordText;
        private System.Windows.Forms.Button saveInfo;
        private System.Windows.Forms.Button cansInfo;
        private System.Windows.Forms.Button deleteAcc;
    }
}