namespace HaromszogGombok
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                for(int j = 0; j < 10; j++)
                {
                    if (i <= j)
                    {
                        Button btn = new Button();
                        btn.Width = 50;
                        btn.Height = 50;
                        btn.Left = i * 50;
                        btn.Top = j * 50;
                        this.Controls.Add(btn);
                    }
                }
            }
        }
    }
}
