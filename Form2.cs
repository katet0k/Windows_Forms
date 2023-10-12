using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_Forms
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            comboBoxMaritalStatus.Items.Add("Холост/Не замужем");
            comboBoxMaritalStatus.Items.Add("В браке");
            comboBoxMaritalStatus.Items.Add("Разведен(а)");
            comboBoxMaritalStatus.Items.Add("Вдовец/Вдова");

            comboBoxGender.Items.Add("Мужской");
            comboBoxGender.Items.Add("Женский");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
            saveFileDialog.DefaultExt = "txt";
            saveFileDialog.FileName = "PersonalInfo.txt";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                {
                    writer.WriteLine($"Фамилия: {textBoxLastName.Text}");
                    writer.WriteLine($"Имя: {textBoxFirstName.Text}");
                    writer.WriteLine($"Отчество: {textBoxPatronymic.Text}");
                    writer.WriteLine($"Пол: {comboBoxGender.Text}");
                    writer.WriteLine($"Дата рождения: {dateTimePickerBirthdate.Value.ToShortDateString()}");
                    writer.WriteLine($"Семейный статус: {comboBoxMaritalStatus.Text}");
                    writer.WriteLine($"Дополнительная информация: {textBoxAdditionalInfo.Text}");
                }

                MessageBox.Show("Информация сохранена успешно!", "Сохранение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

    }
}
