namespace WinFormsTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Hello_button.Click += Hello_button_Click;
        }
             

        private void Hello_button_Click(object? sender, EventArgs e)
        {
            MessageBox.Show("Hello!");
        }
    }
}