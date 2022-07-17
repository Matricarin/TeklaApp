namespace WinFormsTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Load += LoadEvent;
        }

        private void LoadEvent(object? sender, EventArgs e)
        {
            this.BackColor = SystemColors.Window;
        }

        private void Hello_button_Click(object? sender, EventArgs e)
        {
            MessageBox.Show("Hello!");
        }

        private void Hello_button2_Click(object sender, EventArgs e)
        {
            Form2 newForm2 = new Form2(this);
            newForm2.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CircleFormButton_Click(object sender, EventArgs e)
        {
            Form3 newForm3 = new Form3(this);
            newForm3.Show();
        }
    }
}