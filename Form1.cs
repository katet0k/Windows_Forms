namespace Windows_Forms
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            Form01 secondForm = new Form01();
            secondForm.ShowDialog();
        }

        private void button2_MouseDown(object sender, MouseEventArgs e)
        {
            Form2 secondForm = new Form2();
            secondForm.ShowDialog();
        }

        private void button3_MouseDown(object sender, MouseEventArgs e)
        {
            Form3 secondForm = new Form3();
            secondForm.ShowDialog();
        }
        private void button4_MouseDown(object sender, MouseEventArgs e)
        {
            Form4 secondForm = new Form4();
            secondForm.ShowDialog();
        }
        private void button5_MouseDown(object sender, MouseEventArgs e)
        {
            Form5 secondForm = new Form5();
            secondForm.ShowDialog();
        }
        private void button6_MouseDown(object sender, MouseEventArgs e)
        {
            Form6 secondForm = new Form6();
            secondForm.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}