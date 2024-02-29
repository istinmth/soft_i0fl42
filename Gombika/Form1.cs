namespace Gombika
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Button b = new Button();
            Controls.Add(b);

            b.Left = ClientRectangle.Width / 2 - b.Width / 2;
            b.Top = ClientRectangle.Height / 2 - b.Height / 2;
            Random rnd = new Random();
            b.Height = 50;
            for (int i = 0; i < 10; i++)
            {  
                for (int j = 0; j < 20; j++)
                {
                    Button c = new FlashingButton();
                    Controls.Add(c);
                    c.Height = 20;
                    c.Width = 20;
                    c.Left = rnd.Next(20,100) * i;
                    c.Top = rnd.Next(20, 100) * j;
                }
            }
        }
    }
}