
namespace TripPreparation
{
    partial class RegistrationForm
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
            this.BackButton = new System.Windows.Forms.Button();
            this.registrationButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.helpPass = new System.Windows.Forms.PictureBox();
            this.Exit = new System.Windows.Forms.Button();
            this.About = new System.Windows.Forms.Button();
            this.phoneText = new System.Windows.Forms.MaskedTextBox();
            this.patrText = new ControlLibrary.NameTextBox(this.components);
            this.surnameText = new ControlLibrary.NameTextBox(this.components);
            this.nameText = new ControlLibrary.NameTextBox(this.components);
            this.emailText = new ControlLibrary.EmailTextBox(this.components);
            this.password2 = new ControlLibrary.PasswordTextBox(this.components);
            this.password1 = new ControlLibrary.PasswordTextBox(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.helpPass)).BeginInit();
            this.SuspendLayout();
            // 
            // BackButton
            // 
            this.BackButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BackButton.Location = new System.Drawing.Point(684, 685);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(158, 54);
            this.BackButton.TabIndex = 0;
            this.BackButton.Text = "Назад";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // registrationButton
            // 
            this.registrationButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registrationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.registrationButton.Location = new System.Drawing.Point(635, 471);
            this.registrationButton.Name = "registrationButton";
            this.registrationButton.Size = new System.Drawing.Size(264, 54);
            this.registrationButton.TabIndex = 1;
            this.registrationButton.Text = "Регистрация";
            this.registrationButton.UseVisualStyleBackColor = true;
            this.registrationButton.Click += new System.EventHandler(this.registrationButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(303, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 33);
            this.label1.TabIndex = 11;
            this.label1.Text = "Логин (почта)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(698, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 33);
            this.label2.TabIndex = 12;
            this.label2.Text = "Пароль";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(985, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(261, 33);
            this.label3.TabIndex = 13;
            this.label3.Text = "Повторите пароль";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(358, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 33);
            this.label4.TabIndex = 14;
            this.label4.Text = "Имя";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(687, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 33);
            this.label5.TabIndex = 15;
            this.label5.Text = "Фамилия";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(1038, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 33);
            this.label6.TabIndex = 16;
            this.label6.Text = "Отчество";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(327, 314);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 33);
            this.label7.TabIndex = 17;
            this.label7.Text = "Телефон";
            // 
            // helpPass
            // 
            this.helpPass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.helpPass.Cursor = System.Windows.Forms.Cursors.Help;
            this.helpPass.Image = global::TripPreparation.Properties.Resources.Help;
            this.helpPass.Location = new System.Drawing.Point(882, 98);
            this.helpPass.Name = "helpPass";
            this.helpPass.Size = new System.Drawing.Size(30, 30);
            this.helpPass.TabIndex = 18;
            this.helpPass.TabStop = false;
            // 
            // Exit
            // 
            this.Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit.FlatAppearance.BorderSize = 0;
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.ForeColor = System.Drawing.Color.White;
            this.Exit.Image = global::TripPreparation.Properties.Resources.Exit;
            this.Exit.Location = new System.Drawing.Point(1375, 24);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(81, 81);
            this.Exit.TabIndex = 4;
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // About
            // 
            this.About.Cursor = System.Windows.Forms.Cursors.Hand;
            this.About.FlatAppearance.BorderSize = 0;
            this.About.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.About.ForeColor = System.Drawing.Color.White;
            this.About.Image = global::TripPreparation.Properties.Resources.About;
            this.About.Location = new System.Drawing.Point(28, 24);
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(81, 81);
            this.About.TabIndex = 3;
            this.About.UseVisualStyleBackColor = true;
            this.About.Click += new System.EventHandler(this.About_Click);
            // 
            // phoneText
            // 
            this.phoneText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phoneText.Location = new System.Drawing.Point(269, 350);
            this.phoneText.Mask = "0 (000) 000-00-00";
            this.phoneText.Name = "phoneText";
            this.phoneText.Size = new System.Drawing.Size(251, 38);
            this.phoneText.TabIndex = 19;
            this.phoneText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // patrText
            // 
            this.patrText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.patrText.Location = new System.Drawing.Point(1001, 223);
            this.patrText.MaxLength = 30;
            this.patrText.Name = "patrText";
            this.patrText.Size = new System.Drawing.Size(227, 38);
            this.patrText.TabIndex = 9;
            // 
            // surnameText
            // 
            this.surnameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.surnameText.Location = new System.Drawing.Point(635, 223);
            this.surnameText.MaxLength = 30;
            this.surnameText.Name = "surnameText";
            this.surnameText.Size = new System.Drawing.Size(241, 38);
            this.surnameText.TabIndex = 8;
            // 
            // nameText
            // 
            this.nameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameText.Location = new System.Drawing.Point(269, 223);
            this.nameText.MaxLength = 30;
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(251, 38);
            this.nameText.TabIndex = 7;
            // 
            // emailText
            // 
            this.emailText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.emailText.ForeColor = System.Drawing.Color.Red;
            this.emailText.Location = new System.Drawing.Point(269, 95);
            this.emailText.MaxLength = 30;
            this.emailText.Name = "emailText";
            this.emailText.Size = new System.Drawing.Size(251, 38);
            this.emailText.TabIndex = 6;
            // 
            // password2
            // 
            this.password2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.password2.ForeColor = System.Drawing.Color.Red;
            this.password2.Location = new System.Drawing.Point(1001, 95);
            this.password2.Name = "password2";
            this.password2.Size = new System.Drawing.Size(227, 38);
            this.password2.TabIndex = 5;
            this.password2.UseSystemPasswordChar = true;
            // 
            // password1
            // 
            this.password1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.password1.ForeColor = System.Drawing.Color.Red;
            this.password1.Location = new System.Drawing.Point(635, 95);
            this.password1.Name = "password1";
            this.password1.Size = new System.Drawing.Size(241, 38);
            this.password1.TabIndex = 2;
            this.password1.UseSystemPasswordChar = true;
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1484, 861);
            this.Controls.Add(this.phoneText);
            this.Controls.Add(this.helpPass);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.patrText);
            this.Controls.Add(this.surnameText);
            this.Controls.Add(this.nameText);
            this.Controls.Add(this.emailText);
            this.Controls.Add(this.password2);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.About);
            this.Controls.Add(this.password1);
            this.Controls.Add(this.registrationButton);
            this.Controls.Add(this.BackButton);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "RegistrationForm";
            this.Text = "Регистрация";
            ((System.ComponentModel.ISupportInitialize)(this.helpPass)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button registrationButton;
        private ControlLibrary.PasswordTextBox password1;
        private System.Windows.Forms.Button About;
        private System.Windows.Forms.Button Exit;
        private ControlLibrary.PasswordTextBox password2;
        private ControlLibrary.EmailTextBox emailText;
        private ControlLibrary.NameTextBox nameText;
        private ControlLibrary.NameTextBox surnameText;
        private ControlLibrary.NameTextBox patrText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox helpPass;
        private System.Windows.Forms.MaskedTextBox phoneText;
    }
}