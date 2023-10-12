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
    public partial class Form01 : System.Windows.Forms.Form
    {
        public Form01()
        {
            InitializeComponent();
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            string myResume = "Я - Катерина.\n Навчаюсь в академії Крок.\n Знаю C# і WinForms.";

            int totalCharacters = myResume.Length;
            int numberOfMessageBoxes = 3;
            int averageCharactersPerPage = totalCharacters / numberOfMessageBoxes;

            MessageBox.Show(this, $"1:\n{myResume.Substring(0, averageCharactersPerPage)}", "Моє резюме");
            MessageBox.Show(this, $"2:\n{myResume.Substring(averageCharactersPerPage, averageCharactersPerPage)}", "Моє резюме");
            MessageBox.Show(this, $"3:\n{myResume.Substring(2 * averageCharactersPerPage)}", "Кількість символів: " + averageCharactersPerPage);

        }

        private void Form01_Load(object sender, EventArgs e)
        {

        }
    }
}
