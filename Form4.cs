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
    public partial class Form4 : Form
    {
        private List<CustomStatic> statics = new List<CustomStatic>();
        private int currentOrderNumber = 1;
        public Form4()
        {
            InitializeComponent();
            this.MouseDown += MainForm_MouseDown;
            this.MouseMove += MainForm_MouseMove;
            this.MouseUp += MainForm_MouseUp;
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                CustomStatic newStatic = new CustomStatic
                {
                    OrderNumber = currentOrderNumber++,
                    StartPoint = e.Location,
                    Rectangle = new Rectangle(e.Location, new Size(0, 0))
                };

                statics.Add(newStatic);
                Refresh();
            }
        }

        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && statics.Any())
            {
                var currentStatic = statics.Last();
                var width = Math.Max(e.X - currentStatic.StartPoint.X, 10);
                var height = Math.Max(e.Y - currentStatic.StartPoint.Y, 10);

                currentStatic.Rectangle = new Rectangle(currentStatic.StartPoint, new Size(width, height));
                Refresh();
            }
        }

        private void MainForm_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && statics.Any())
            {
                var currentStatic = statics.Last();

                if (currentStatic.Rectangle.Width < 10 || currentStatic.Rectangle.Height < 10)
                {
                    MessageBox.Show("Минимальный размер статика составляет 10x10.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    statics.Remove(currentStatic);
                }
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            foreach (var customStatic in statics)
            {
                e.Graphics.FillRectangle(Brushes.LightBlue, customStatic.Rectangle);
                e.Graphics.DrawString(customStatic.OrderNumber.ToString(), Font, Brushes.Black, customStatic.Rectangle.Location);
            }
        }

        private void MainForm_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var clickedStatics = statics.Where(s => s.Rectangle.Contains(e.Location)).ToList();

                if (clickedStatics.Any())
                {
                    var selectedStatic = clickedStatics.OrderBy(s => s.OrderNumber).Last();
                    MessageBox.Show($"Площадь: {selectedStatic.Rectangle.Width * selectedStatic.Rectangle.Height}\nКоординаты: X = {selectedStatic.Rectangle.X}, Y = {selectedStatic.Rectangle.Y}", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void MainForm_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                var clickedStatics = statics.Where(s => s.Rectangle.Contains(e.Location)).ToList();

                if (clickedStatics.Any())
                {
                    var selectedStatic = clickedStatics.OrderBy(s => s.OrderNumber).First();
                    statics.Remove(selectedStatic);
                    Refresh();
                }
            }
        }
        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }

    public class CustomStatic
    {
        public int OrderNumber { get; set; }
        public Point StartPoint { get; set; }
        public Rectangle Rectangle { get; set; }
    }
}

