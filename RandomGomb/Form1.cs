namespace RandomGomb
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
               Button btn = new RandomButton();
               this.Controls.Add(btn);
            }   
        }
    }
}
