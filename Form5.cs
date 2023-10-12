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
    public partial class Form5 : Form
    {
        private Label runawayStatic;
        private Random random = new Random();
        public Form5()
        {
            InitializeComponent();
             
            runawayStatic = new Label
            {
                Text = "🏃",
                Font = new Font("Arial", 18),
                AutoSize = true
            };
             
            runawayStatic.Location = GetRandomLocation();
             
            Controls.Add(runawayStatic);
             
            runawayStatic.MouseEnter += RunawayStatic_MouseEnter;
            runawayStatic.MouseMove += RunawayStatic_MouseMove;
        }

        private void RunawayStatic_MouseEnter(object sender, EventArgs e)
        { 
            runawayStatic.Location = GetRandomLocation();
        }

        private void RunawayStatic_MouseMove(object sender, MouseEventArgs e)
        { 
            runawayStatic.Location = GetRandomLocation();
        }

        private Point GetRandomLocation()
        {
            int maxX = ClientSize.Width - runawayStatic.Width;
            int maxY = ClientSize.Height - runawayStatic.Height;

            int x = random.Next(maxX);
            int y = random.Next(maxY);

            return new Point(x, y);
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }
    }
}
