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
    public partial class Form3 : Form
    {
        private const int RectangleMargin = 10;
        public Form3()
        {
            InitializeComponent();
        }

        private void MainForm_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                string message;
                if (e.X >= 10 && e.X <= Width - 10 && e.Y >= 10 && e.Y <= Height - 10)
                {
                    message = "Точка знаходится всередині прямокутника.";
                }
                else if (e.X < 10 || e.X > Width - 10 || e.Y < 10 || e.Y > Height - 10)
                {
                    message = "Точка знаходится зовні прямокутника.";
                }
                else
                {
                    message = "Точка знаходится на границі прямокутника.";
                }

                if (Control.ModifierKeys == Keys.Control)
                {
                    MessageBox.Show("Вікно буде зачинено.", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    MessageBox.Show(message, "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            Text = $"Координати миші: X = {e.X}, Y = {e.Y}";
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                Text = $"Розмір клієнської області: Ширина = {ClientSize.Width}, Висота = {ClientSize.Height}";
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}