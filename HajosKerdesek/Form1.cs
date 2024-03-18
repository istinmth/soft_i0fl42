using static System.Net.WebRequestMethods;

namespace HajosKerdesek
{
    public partial class Form1 : Form
    {
        List<Kerdes> kerdesek;
        List<Kerdes> AktualisKerdesek;
        int MegjelenitettKerdesIndex;
        int AktualisKerdes = 0;
        public Form1()
        {
            InitializeComponent();
            valaszGomb1.MouseDown += valaszGomb1_MouseDown;
            valaszGomb2.MouseDown += valaszGomb2_MouseDown;
            valaszGomb3.MouseDown += valaszGomb3_MouseDown;
        }
        void KérdésMegjelenítés(Kerdes kérdés)
        {
            label1.Text = kérdés.KérdésSzöveg;
            valaszGomb1.Text = kérdés.Válasz1;
            valaszGomb2.Text = kérdés.Válasz2;
            valaszGomb3.Text = kérdés.Válasz3;
            if (!string.IsNullOrEmpty(kérdés.URL))
            {
                pictureBox1.Load("https://storage.altinum.hu/hajo/" + kérdés.URL);
                pictureBox1.Visible = true;
            }
            else
            {
                pictureBox1.Load("C:\\Users\\nemis\\Downloads\\istockphoto-1138179183-612x612.jpg");
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Text = "Következő";
            kerdesek = KerdesBeolvaso();
            AktualisKerdesek = new List<Kerdes>();
            for (int i = 0; i < 7; i++)
            {
                AktualisKerdesek.Add(kerdesek[i]);
                kerdesek.RemoveAt(i);
            }
            KérdésMegjelenítés(AktualisKerdesek[AktualisKerdes]);
        }

        List<Kerdes> KerdesBeolvaso()
        {
            List<Kerdes> kerdesek = new List<Kerdes>();
            StreamReader sr = new StreamReader("C:\\Users\\nemis\\source\\Repos\\istinmth\\soft_i0fl42\\HajosKerdesek\\kerdesek.txt");

            while (!sr.EndOfStream)
            {
                string sor = sr.ReadLine() ?? string.Empty;
                string[] adatok = sor.Split('\t');
                Kerdes k = new Kerdes();
                k.KérdésSzöveg = adatok[1].Trim('"');
                k.Válasz1 = adatok[2].Trim('"').Replace("?", "ű");
                k.Válasz2 = adatok[3].Trim('"').Replace("?", "ű");
                k.Válasz3 = adatok[4].Trim('"').Replace("?", "ű");
                k.URL = adatok[5];
                int x = 0;
                if (!int.TryParse(adatok[6], out x))
                {
                    k.HelyesVálasz = x;
                }
                else
                {
                    k.HelyesVálasz = int.Parse(adatok[6]);
                }
                kerdesek.Add(k);
            }
            return kerdesek;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AktualisKerdes++;
            if (AktualisKerdes == 7)
            {
                AktualisKerdes = 0;
            }
            if (AktualisKerdesek[AktualisKerdes].HelyesVálaszokSzáma >= 3)
            {
                AktualisKerdesek[0] = kerdesek[0];
                kerdesek.RemoveAt(0);
            }
            KérdésMegjelenítés(AktualisKerdesek[AktualisKerdes]);
        }
        private async void valaszGomb1_MouseDown(object sender, MouseEventArgs e)
        {
            if (this != null)
            {
                valaszGomb1.Enabled = false;
            }
            if (AktualisKerdesek[AktualisKerdes].HelyesVálasz == 1)
            {
                AktualisKerdesek[AktualisKerdes].HelyesVálaszokSzáma += 1;
                valaszGomb1.BackColor = Color.Green;
                await Task.Delay(1000);
                button1.PerformClick();
                valaszGomb1.BackColor = Color.LightGray;
                valaszGomb1.Enabled = true;
            }
            else
            {
                valaszGomb1.BackColor = Color.Red;
                await Task.Delay(1000);
                button1.PerformClick();
                valaszGomb1.BackColor = Color.LightGray;
                valaszGomb1.Enabled = true;
            }
            
        }
        private async void valaszGomb2_MouseDown(object sender, MouseEventArgs e)
        {
            if (this != null)
            {
                valaszGomb2.Enabled = false;
            }
            if (AktualisKerdesek[AktualisKerdes].HelyesVálasz == 2)
            {
                AktualisKerdesek[AktualisKerdes].HelyesVálaszokSzáma += 1;
                valaszGomb2.BackColor = Color.Green;
                await Task.Delay(1000);
                button1.PerformClick();
                valaszGomb2.BackColor = Color.LightGray;
                valaszGomb2.Enabled = true;
            }
            else
            {
                valaszGomb2.BackColor = Color.Red;
                await Task.Delay(1000);
                button1.PerformClick();
                valaszGomb2.BackColor = Color.LightGray;
                valaszGomb2.Enabled = true;
            }

        }
        private async void valaszGomb3_MouseDown(object sender, MouseEventArgs e)
        {
            if (this != null)
            {
                valaszGomb3.Enabled = false;
            }
            if (AktualisKerdesek[AktualisKerdes].HelyesVálasz == 3)
            {
                AktualisKerdesek[AktualisKerdes].HelyesVálaszokSzáma += 1;
                valaszGomb3.BackColor = Color.Green;
                await Task.Delay(1000);
                button1.PerformClick();
                valaszGomb3.BackColor = Color.LightGray;
                valaszGomb3.Enabled = true;
            }
            else
            {
                valaszGomb3.BackColor = Color.Red;
                await Task.Delay(1000);
                button1.PerformClick();
                valaszGomb3.BackColor = Color.LightGray;
                valaszGomb3.Enabled = true;
            }

        }
    }
}
