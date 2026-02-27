using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ucusProgrami
{
    public partial class Form2 : Form
    {

        public int fiyat;
        public string secilenNereden;
        public string secilenNereye;
        public DateTime secilenTarih;
        public int yolcuSayisi;
        private List<string> tumKoltuklar = new List<string>() { "1A", "1B", "2A", "2B", "3A", "3B" };
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            cmbKoltuk1.Items.AddRange(tumKoltuklar.ToArray());
            cmbKoltuk2.Items.AddRange(tumKoltuklar.ToArray());

            
            KoltukSecimiKontrol();

            

            
            radioButton2.Checked = true;

            
            FiyatGuncelle();
        }
        private void KoltukSecimiKontrol()
        {
            bool aktif = checkKoltukSecimi.Checked;

            cmbKoltuk1.Enabled = aktif;
            cmbKoltuk2.Enabled = aktif && yolcuSayisi == 2;

            if (yolcuSayisi == 1)
                cmbKoltuk2.Enabled = false;
        }



        private void FiyatGuncelle()
        {
            int toplam = fiyat;

            toplam = toplam * yolcuSayisi;

            if (radioBusiness.Checked)
            {
                toplam *= 2;
            }

            if (checkKoltukSecimi.Checked)
                toplam += 50;
            if (checkEkstraBagaj.Checked)
                toplam += 100;
            if (checkIadeDegisim.Checked)
                toplam += 75;
            if (checkYemek.Checked)
                toplam += 50;
            if (checkIptal.Checked)
                toplam += 100;


            txtFiyat.Text = toplam.ToString() + " ₺";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkKoltukSecimi_CheckedChanged(object sender, EventArgs e)
        {
            
            KoltukSecimiKontrol();
            FiyatGuncelle();
        }

        private void checkEkstraBagaj_CheckedChanged(object sender, EventArgs e)
        {
            FiyatGuncelle();
        }

        private void checkYemek_CheckedChanged(object sender, EventArgs e)
        {
            FiyatGuncelle();
        }

        private void radioBusiness_CheckedChanged(object sender, EventArgs e)
        {
            FiyatGuncelle();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            FiyatGuncelle();
        }

        private void checkIadeDegisim_CheckedChanged(object sender, EventArgs e)
        {
            FiyatGuncelle();
        }

        private void cmbKoltuk1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void cmbKoltuk2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtFiyat_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            
            string yolculuk = $"{secilenNereden} → {secilenNereye}";

            
            string tarih = secilenTarih.ToShortDateString();

            
            string yolcuSayisiStr = yolcuSayisi.ToString();

            
            List<string> hizmetler = new List<string>();
            if (checkKoltukSecimi.Checked) hizmetler.Add("Koltuk Seçimi");
            if (checkEkstraBagaj.Checked) hizmetler.Add("Ekstra Bagaj");
            if (checkYemek.Checked) hizmetler.Add("Yemek");
            if (checkIadeDegisim.Checked) hizmetler.Add("Bilet Değişim ve İade");
            if (checkIptal.Checked) hizmetler.Add("Bilet İptali");

            string hizmetlerStr = hizmetler.Count > 0 ? string.Join(", ", hizmetler) : "Yok";

            
            string sinif = radioBusiness.Checked ? "Business" : "Ekonomi";

            
            List<string> koltuklar = new List<string>();
            Random rnd = new Random();

            if (checkKoltukSecimi.Checked)
            {
                koltuklar.Add(cmbKoltuk1.SelectedItem != null ? cmbKoltuk1.SelectedItem.ToString() : tumKoltuklar[rnd.Next(tumKoltuklar.Count)]);
                if (yolcuSayisi == 2)
                {
                    koltuklar.Add(cmbKoltuk2.SelectedItem != null ? cmbKoltuk2.SelectedItem.ToString() : tumKoltuklar[rnd.Next(tumKoltuklar.Count)]);
                }
            }
            else
            {
                koltuklar.Add(tumKoltuklar[rnd.Next(tumKoltuklar.Count)]);
                if (yolcuSayisi == 2)
                {
                    koltuklar.Add(tumKoltuklar[rnd.Next(tumKoltuklar.Count)]);
                }
            }

            string koltukStr = string.Join(", ", koltuklar);

            
            string mesaj = $"Yolculuk: {yolculuk}\n" +
                           $"Tarih: {tarih}\n" +
                           $"Yolcu Sayısı: {yolcuSayisiStr}\n" +
                           $"Ekstra Hizmetler: {hizmetlerStr}\n" +
                           $"Yolcu Sınıfı: {sinif}\n" +
                           $"Koltuk Numaraları: {koltukStr} \n" +
                           $"fiyat: {txtFiyat.Text}";

            MessageBox.Show(mesaj, "Bilet Bilgileri", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}

