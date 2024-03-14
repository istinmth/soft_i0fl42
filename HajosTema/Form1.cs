namespace HajosTema
{
    public partial class Form1 : Form
    {
        List<Kerdes> OsszesKerdes;
        List<Kerdes> AktualisKerdesek;
        int MegjelenitettKerdesekSzama = 7;
        int MegjelenitettKerdes = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            OsszesKerdes = KerdesekBetoltese();
            AktualisKerdesek = new List<Kerdes>();
            for (int i = 0; i < 7; i++)
            {
                AktualisKerdesek.Add(OsszesKerdes[0]);
                OsszesKerdes.RemoveAt(0);
            }
            dataGridView1.DataSource = AktualisKerdesek;
            KerdesekMegjelenitese(AktualisKerdesek[MegjelenitettKerdes]);
        }

        List<Kerdes> KerdesekBetoltese()
        {
            List<Kerdes> kerdesek = new List<Kerdes>();
            StreamReader sr = new StreamReader("C:\\Users\\i0fl42\\source\\repos\\istinmth\\soft_i0fl42\\HajosTema\\hajozasi_szabalyzat_kerdessor_BOM.txt");
            while (!sr.EndOfStream)
            {
                string[] sor = sr.ReadLine().Split('\t');
                Kerdes k = new Kerdes();
                k.KerdesSzoveg = sor[1].ToUpper();
                k.Valasz1 = sor[2].Trim('"');
                k.Valasz2 = sor[3].Trim('"');
                k.Valasz3 = sor[4].Trim('"');
                k.URL = sor[5];

                int x = 0;
                if (int.TryParse(sor[6], out x))
                {
                    k.HelyesValasz = x;
                }
                else
                {
                    k.HelyesValasz = int.Parse(sor[6]);
                }
                kerdesek.Add(k);
            }
            sr.Close();
            return kerdesek;
        }
        void KerdesekMegjelenitese(Kerdes kerdes)
        {
            label1.Text = kerdes.KerdesSzoveg;
            button1.Text = kerdes.Valasz1;
            button2.Text = kerdes.Valasz2;
            button3.Text = kerdes.Valasz3;
            pictureBox1.Load("https://storage.altinum.hu/hajo/xxx-0975.jpg");
            pictureBox1.Visible = true;

        }
        private void button4_Click(object sender, EventArgs e)
        {
            MegjelenitettKerdes ++;
            if (MegjelenitettKerdes == MegjelenitettKerdesekSzama)
            {
                MegjelenitettKerdes = 0;
            }
            else
            {
                KerdesekMegjelenitese(AktualisKerdesek[MegjelenitettKerdes]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int helyesvalasz = AktualisKerdesek[MegjelenitettKerdes].HelyesValasz;
            if (helyesvalasz == 1)
            {
                button1.BackColor = Color.Green;
            }
            else
            {
                button1.BackColor = Color.Red;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int helyesvalasz = AktualisKerdesek[MegjelenitettKerdes].HelyesValasz;
            if (helyesvalasz == 2)
            {
                button2.BackColor = Color.Green;
            }
            else
            {
                button2.BackColor = Color.Red;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int helyesvalasz = AktualisKerdesek[MegjelenitettKerdes].HelyesValasz;
            if (helyesvalasz == 3)
            {
                button3.BackColor = Color.Green;
            }
            else
            {
                button3.BackColor = Color.Red;
            }
        }
    }
}