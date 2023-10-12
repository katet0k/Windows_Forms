using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_Forms
{
    public partial class Form3 : Form
    {

        private DateTimePicker dateTimePickerStart;
        private DateTimePicker dateTimePickerEnd;
        private Label labelResult;
        public Form3()
        {

            InitializeComponent();
            InitializeComponents();
        }

        private void InitializeComponents()
        {
            dateTimePickerStart = new DateTimePicker();
            dateTimePickerStart.Location = new Point(10, 10);
            dateTimePickerStart.Format = DateTimePickerFormat.Short;
            dateTimePickerStart.Width = 100;
            Controls.Add(dateTimePickerStart);

            dateTimePickerEnd = new DateTimePicker();
            dateTimePickerEnd.Location = new Point(10, 40);
            dateTimePickerEnd.Format = DateTimePickerFormat.Short;
            dateTimePickerEnd.Width = 100;
            Controls.Add(dateTimePickerEnd);

            labelResult = new Label();
            labelResult.Location = new Point(10, 70);
            labelResult.AutoSize = true;
            Controls.Add(labelResult);

            dateTimePickerStart.ValueChanged += DateTimePicker_ValueChanged;
            dateTimePickerEnd.ValueChanged += DateTimePicker_ValueChanged;

            this.FormBorderStyle = FormBorderStyle.None;
            this.Size = new Size(300, 300);
            this.Paint += MainForm_Paint;
        }

        private void DateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            TimeSpan difference = dateTimePickerEnd.Value - dateTimePickerStart.Value;
            labelResult.Text = $"Разница: {difference.Days} дней";
        }

        private void MainForm_Paint(object sender, PaintEventArgs e)
        {
            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddEllipse(0, 0, this.Width, this.Height);
                this.Region = new Region(path);
            }
        }
    }
}
