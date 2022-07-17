namespace WinFormsTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Text = "Hello!";
            this.BackColor = Color.BlueViolet;
            //1 method to change the form
            /*this.Width = 250;
            this.Height = 250;*/
            //2 method to change the form
            this.Size = new Size(200, 400);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackgroundImage = Image.FromFile("D:\\repos\\TeklaApp\\TeklaApp\\WinFormsTest\\Image.jpg");
        }


        private void Hello_button_Click(object? sender, EventArgs e)
        {
            MessageBox.Show("Hello!");
        }
    }
}