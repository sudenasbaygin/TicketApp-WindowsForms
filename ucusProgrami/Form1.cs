namespace ucusProgrami
{
    public partial class Form1 : Form
    {
        int bulunanFiyat;
        internal static long biletFiyati;

        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
            string[] satirlar = File.ReadAllLines("sehirler1.txt");

            foreach (string satir in satirlar)
            {
                string[] parca = satir.Split(',');
                string nereden = parca[0];
                string nereye = parca[1];

                if (!cmbNereden.Items.Contains(nereden))
                    cmbNereden.Items.Add(nereden);

                if (!cmbNereye.Items.Contains(nereye))
                    cmbNereye.Items.Add(nereye);
            }
            numericUpDown1.Maximum = 2;
            numericUpDown1.Minimum = 0;
        }

        

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] satirlar = File.ReadAllLines("sehirler1.txt");

            bulunanFiyat = 0;
            bool seferVar = false;

            foreach (string satir in satirlar)
            {
                string[] parca = satir.Split(',');
                string nereden = parca[0];
                string nereye = parca[1];
                int fiyat = int.Parse(parca[2]);

                if (nereden == cmbNereden.SelectedItem.ToString() && nereye == cmbNereye.SelectedItem.ToString())
                {
                    bulunanFiyat = fiyat;
                    seferVar = true;
                    break;
                }
            }

            if (!seferVar)
            {
                MessageBox.Show("Sefer bulunamadý.");
                return;
            }

            if (cmbNereden.SelectedItem == null || cmbNereye.SelectedItem == null)
            {
                MessageBox.Show("Lütfen hem 'Nereden' hem de 'Nereye' þehirlerini seçiniz.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            if (cmbNereden.Text == cmbNereye.Text)
            {
                MessageBox.Show("'Nereden' ve 'Nereye' þehirleri ayný olamaz!", "Hatalý Seçim", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if (monthCalendar1.SelectionStart.Date < DateTime.Now.Date)
            {
                MessageBox.Show("Geçmiþ bir tarih seçilemez.");
                return;
            }


            if (numericUpDown1.Value == 0)
            {
                MessageBox.Show("Lütfen en az 1 yolcu sayýsý giriniz.", "Yolcu Sayýsý Hatasý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Form2 frm2 = new Form2();

            
            frm2.fiyat = bulunanFiyat; 
            frm2.secilenNereden = cmbNereden.SelectedItem.ToString();
            frm2.secilenNereye = cmbNereye.SelectedItem.ToString();
            frm2.secilenTarih = monthCalendar1.SelectionStart; 
            frm2.yolcuSayisi = (int)numericUpDown1.Value;

            
            frm2.Show();
            this.Hide();


        }
    }
}
