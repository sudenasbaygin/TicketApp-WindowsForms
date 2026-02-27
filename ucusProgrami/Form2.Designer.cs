namespace ucusProgrami
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            checkEkstraBagaj = new CheckBox();
            checkYemek = new CheckBox();
            checkKoltukSecimi = new CheckBox();
            groupBox2 = new GroupBox();
            radioButton2 = new RadioButton();
            radioBusiness = new RadioButton();
            groupBox3 = new GroupBox();
            checkIadeDegisim = new CheckBox();
            checkIptal = new CheckBox();
            cmbKoltuk1 = new ComboBox();
            cmbKoltuk2 = new ComboBox();
            txtFiyat = new TextBox();
            button1 = new Button();
            lblKoltuk1 = new Label();
            lblKoltuk2 = new Label();
            label3 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(checkEkstraBagaj);
            groupBox1.Controls.Add(checkYemek);
            groupBox1.Controls.Add(checkKoltukSecimi);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 125);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ekstra Hizmetler";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // checkEkstraBagaj
            // 
            checkEkstraBagaj.AutoSize = true;
            checkEkstraBagaj.Location = new Point(6, 56);
            checkEkstraBagaj.Name = "checkEkstraBagaj";
            checkEkstraBagaj.Size = new Size(112, 24);
            checkEkstraBagaj.TabIndex = 3;
            checkEkstraBagaj.Text = "Ekstra Bagaj";
            checkEkstraBagaj.UseVisualStyleBackColor = true;
            checkEkstraBagaj.CheckedChanged += checkEkstraBagaj_CheckedChanged;
            // 
            // checkYemek
            // 
            checkYemek.AutoSize = true;
            checkYemek.Location = new Point(6, 86);
            checkYemek.Name = "checkYemek";
            checkYemek.Size = new Size(74, 24);
            checkYemek.TabIndex = 4;
            checkYemek.Text = "Yemek";
            checkYemek.UseVisualStyleBackColor = true;
            checkYemek.CheckedChanged += checkYemek_CheckedChanged;
            // 
            // checkKoltukSecimi
            // 
            checkKoltukSecimi.AutoSize = true;
            checkKoltukSecimi.Location = new Point(6, 26);
            checkKoltukSecimi.Name = "checkKoltukSecimi";
            checkKoltukSecimi.Size = new Size(121, 24);
            checkKoltukSecimi.TabIndex = 2;
            checkKoltukSecimi.Text = "Koltuk Seçimi";
            checkKoltukSecimi.UseVisualStyleBackColor = true;
            checkKoltukSecimi.CheckedChanged += checkKoltukSecimi_CheckedChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(radioButton2);
            groupBox2.Controls.Add(radioBusiness);
            groupBox2.Location = new Point(12, 152);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(250, 125);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Yolcu Sınıfı";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(6, 78);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(88, 24);
            radioButton2.TabIndex = 3;
            radioButton2.TabStop = true;
            radioButton2.Text = "Ekonomi";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioBusiness
            // 
            radioBusiness.AutoSize = true;
            radioBusiness.Location = new Point(6, 39);
            radioBusiness.Name = "radioBusiness";
            radioBusiness.Size = new Size(85, 24);
            radioBusiness.TabIndex = 2;
            radioBusiness.TabStop = true;
            radioBusiness.Text = "Business";
            radioBusiness.UseVisualStyleBackColor = true;
            radioBusiness.CheckedChanged += radioBusiness_CheckedChanged;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(checkIadeDegisim);
            groupBox3.Controls.Add(checkIptal);
            groupBox3.Location = new Point(12, 293);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(250, 125);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "Bilet Değişim ve İade Hakkı";
            // 
            // checkIadeDegisim
            // 
            checkIadeDegisim.AutoSize = true;
            checkIadeDegisim.Location = new Point(6, 40);
            checkIadeDegisim.Name = "checkIadeDegisim";
            checkIadeDegisim.Size = new Size(165, 24);
            checkIadeDegisim.TabIndex = 5;
            checkIadeDegisim.Text = "Esnek Bilet Değişimi";
            checkIadeDegisim.UseVisualStyleBackColor = true;
            checkIadeDegisim.CheckedChanged += checkIadeDegisim_CheckedChanged;
            // 
            // checkIptal
            // 
            checkIptal.AutoSize = true;
            checkIptal.Location = new Point(6, 79);
            checkIptal.Name = "checkIptal";
            checkIptal.Size = new Size(140, 24);
            checkIptal.TabIndex = 6;
            checkIptal.Text = "Esnek Bilet İptali";
            checkIptal.UseVisualStyleBackColor = true;
            checkIptal.CheckedChanged += checkBox5_CheckedChanged;
            // 
            // cmbKoltuk1
            // 
            cmbKoltuk1.FormattingEnabled = true;
            cmbKoltuk1.Location = new Point(362, 98);
            cmbKoltuk1.Name = "cmbKoltuk1";
            cmbKoltuk1.Size = new Size(151, 28);
            cmbKoltuk1.TabIndex = 2;
            cmbKoltuk1.SelectedIndexChanged += cmbKoltuk1_SelectedIndexChanged;
            // 
            // cmbKoltuk2
            // 
            cmbKoltuk2.FormattingEnabled = true;
            cmbKoltuk2.Location = new Point(585, 98);
            cmbKoltuk2.Name = "cmbKoltuk2";
            cmbKoltuk2.Size = new Size(151, 28);
            cmbKoltuk2.TabIndex = 3;
            cmbKoltuk2.SelectedIndexChanged += cmbKoltuk2_SelectedIndexChanged;
            // 
            // txtFiyat
            // 
            txtFiyat.Location = new Point(362, 213);
            txtFiyat.Name = "txtFiyat";
            txtFiyat.Size = new Size(151, 27);
            txtFiyat.TabIndex = 4;
            txtFiyat.TextChanged += txtFiyat_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(393, 305);
            button1.Name = "button1";
            button1.Size = new Size(254, 78);
            button1.TabIndex = 5;
            button1.Text = "İşlemi Onayla";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lblKoltuk1
            // 
            lblKoltuk1.AutoSize = true;
            lblKoltuk1.Location = new Point(363, 69);
            lblKoltuk1.Name = "lblKoltuk1";
            lblKoltuk1.Size = new Size(114, 20);
            lblKoltuk1.TabIndex = 6;
            lblKoltuk1.Text = "1. Koltuk Seçimi";
            // 
            // lblKoltuk2
            // 
            lblKoltuk2.AutoSize = true;
            lblKoltuk2.Location = new Point(585, 69);
            lblKoltuk2.Name = "lblKoltuk2";
            lblKoltuk2.Size = new Size(114, 20);
            lblKoltuk2.TabIndex = 7;
            lblKoltuk2.Text = "2. Koltuk Seçimi\r\n";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(363, 190);
            label3.Name = "label3";
            label3.Size = new Size(40, 20);
            label3.TabIndex = 8;
            label3.Text = "Fiyat";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(lblKoltuk2);
            Controls.Add(lblKoltuk1);
            Controls.Add(button1);
            Controls.Add(txtFiyat);
            Controls.Add(cmbKoltuk2);
            Controls.Add(cmbKoltuk1);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private CheckBox checkKoltukSecimi;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private CheckBox checkIadeDegisim;
        private CheckBox checkIptal;
        private CheckBox checkEkstraBagaj;
        private CheckBox checkYemek;
        private RadioButton radioButton2;
        private RadioButton radioBusiness;
        private ComboBox cmbKoltuk1;
        private ComboBox cmbKoltuk2;
        private TextBox txtFiyat;
        private Button button1;
        private Label lblKoltuk1;
        private Label lblKoltuk2;
        private Label label3;
    }
}