namespace Windows_Forms
{
    partial class Form2
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
            textBoxLastName = new TextBox();
            textBoxFirstName = new TextBox();
            textBoxPatronymic = new TextBox();
            comboBoxGender = new ComboBox();
            dateTimePickerBirthdate = new DateTimePicker();
            comboBoxMaritalStatus = new ComboBox();
            textBoxAdditionalInfo = new TextBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // textBoxLastName
            // 
            textBoxLastName.Location = new Point(184, 29);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new Size(250, 27);
            textBoxLastName.TabIndex = 0;
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.Location = new Point(184, 78);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.Size = new Size(250, 27);
            textBoxFirstName.TabIndex = 1;
            // 
            // textBoxPatronymic
            // 
            textBoxPatronymic.Location = new Point(184, 138);
            textBoxPatronymic.Name = "textBoxPatronymic";
            textBoxPatronymic.Size = new Size(250, 27);
            textBoxPatronymic.TabIndex = 2;
            // 
            // comboBoxGender
            // 
            comboBoxGender.FormattingEnabled = true;
            comboBoxGender.Location = new Point(184, 191);
            comboBoxGender.Name = "comboBoxGender";
            comboBoxGender.Size = new Size(159, 28);
            comboBoxGender.TabIndex = 3;
            // 
            // dateTimePickerBirthdate
            // 
            dateTimePickerBirthdate.Location = new Point(184, 246);
            dateTimePickerBirthdate.Name = "dateTimePickerBirthdate";
            dateTimePickerBirthdate.Size = new Size(250, 27);
            dateTimePickerBirthdate.TabIndex = 4;
            // 
            // comboBoxMaritalStatus
            // 
            comboBoxMaritalStatus.FormattingEnabled = true;
            comboBoxMaritalStatus.Location = new Point(184, 295);
            comboBoxMaritalStatus.Name = "comboBoxMaritalStatus";
            comboBoxMaritalStatus.Size = new Size(159, 28);
            comboBoxMaritalStatus.TabIndex = 5;
            // 
            // textBoxAdditionalInfo
            // 
            textBoxAdditionalInfo.Location = new Point(184, 351);
            textBoxAdditionalInfo.Multiline = true;
            textBoxAdditionalInfo.Name = "textBoxAdditionalInfo";
            textBoxAdditionalInfo.Size = new Size(250, 87);
            textBoxAdditionalInfo.TabIndex = 6;
            // 
            // button1
            // 
            button1.Location = new Point(567, 394);
            button1.Name = "button1";
            button1.Size = new Size(221, 44);
            button1.TabIndex = 7;
            button1.Text = "Сохранить";
            button1.UseVisualStyleBackColor = true;
            button1.MouseDown += btnSave_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 32);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 8;
            label1.Text = "Фамилия";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 81);
            label2.Name = "label2";
            label2.Size = new Size(39, 20);
            label2.TabIndex = 9;
            label2.Text = "Имя";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 141);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 10;
            label3.Text = "Отчество";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 194);
            label4.Name = "label4";
            label4.Size = new Size(37, 20);
            label4.TabIndex = 11;
            label4.Text = "Пол";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(25, 251);
            label5.Name = "label5";
            label5.Size = new Size(116, 20);
            label5.TabIndex = 12;
            label5.Text = "Дата рождения";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(25, 298);
            label6.Name = "label6";
            label6.Size = new Size(128, 20);
            label6.TabIndex = 13;
            label6.Text = "Семейный статус";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(26, 354);
            label7.Name = "label7";
            label7.Size = new Size(131, 40);
            label7.TabIndex = 14;
            label7.Text = "Дополнительная \r\nинформация";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(textBoxAdditionalInfo);
            Controls.Add(comboBoxMaritalStatus);
            Controls.Add(dateTimePickerBirthdate);
            Controls.Add(comboBoxGender);
            Controls.Add(textBoxPatronymic);
            Controls.Add(textBoxFirstName);
            Controls.Add(textBoxLastName);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxLastName;
        private TextBox textBoxFirstName;
        private TextBox textBoxPatronymic;
        private ComboBox comboBoxGender;
        private DateTimePicker dateTimePickerBirthdate;
        private ComboBox comboBoxMaritalStatus;
        private TextBox textBoxAdditionalInfo;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}