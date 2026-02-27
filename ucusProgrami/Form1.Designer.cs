namespace ucusProgrami
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cmbNereden = new ComboBox();
            cmbNereye = new ComboBox();
            monthCalendar1 = new MonthCalendar();
            button1 = new Button();
            numericUpDown1 = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // cmbNereden
            // 
            cmbNereden.FormattingEnabled = true;
            cmbNereden.Location = new Point(215, 70);
            cmbNereden.Name = "cmbNereden";
            cmbNereden.Size = new Size(151, 28);
            cmbNereden.TabIndex = 0;
            cmbNereden.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // cmbNereye
            // 
            cmbNereye.FormattingEnabled = true;
            cmbNereye.Location = new Point(215, 124);
            cmbNereye.Name = "cmbNereye";
            cmbNereye.Size = new Size(151, 28);
            cmbNereye.TabIndex = 1;
            cmbNereye.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(104, 178);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 2;
            monthCalendar1.DateChanged += monthCalendar1_DateChanged;
            // 
            // button1
            // 
            button1.Location = new Point(458, 222);
            button1.Name = "button1";
            button1.Size = new Size(211, 81);
            button1.TabIndex = 3;
            button1.Text = "Bilet Al";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(458, 125);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(211, 27);
            numericUpDown1.TabIndex = 4;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(148, 70);
            label1.Name = "label1";
            label1.Size = new Size(66, 20);
            label1.TabIndex = 5;
            label1.Text = "Nereden";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(148, 127);
            label2.Name = "label2";
            label2.Size = new Size(56, 20);
            label2.TabIndex = 6;
            label2.Text = "Nereye";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(458, 92);
            label3.Name = "label3";
            label3.Size = new Size(85, 20);
            label3.TabIndex = 7;
            label3.Text = "Yolcu Sayısı";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(numericUpDown1);
            Controls.Add(button1);
            Controls.Add(monthCalendar1);
            Controls.Add(cmbNereye);
            Controls.Add(cmbNereden);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbNereden;
        private ComboBox cmbNereye;
        private MonthCalendar monthCalendar1;
        private Button button1;
        private NumericUpDown numericUpDown1;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
