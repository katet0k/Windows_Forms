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
        }

        static void PlayGame()
        {
            int numberToGuess = new Random().Next(1, 2001);
            int attempts = 0;

            while (true)
            {
                string userInput = Microsoft.VisualBasic.Interaction.InputBox("Введіть вашу догадку (від 1 до 2000):", "Вгадай число", "", -1, -1);
                int guess;

                if (int.TryParse(userInput, out guess))
                {
                    attempts++;

                    if (guess == numberToGuess)
                    {
                        MessageBox.Show($"Вітаємо! Ви вгадали число {numberToGuess}!\nКількість спроб: {attempts}", "Перемога!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }
                    else
                    {
                        string message = guess < numberToGuess ? "Більше!" : "Менше!";
                        MessageBox.Show(message, "Підсказка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Введіть конкретне число!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            PlayGame();

            DialogResult playAgain = MessageBox.Show("Бажаєте зіграти ще раз?", "Гра завершена", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (playAgain == DialogResult.Yes)
            {
                PlayGame();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
