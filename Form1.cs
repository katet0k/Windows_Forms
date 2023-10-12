namespace Windows_Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            Form1 secondForm = new Form1();
            secondForm.ShowDialog();
        }
        private void button2_MouseDown(object sender, MouseEventArgs e)
        {
            Form2 secondForm = new Form2();
            secondForm.ShowDialog();
        }
    }
}