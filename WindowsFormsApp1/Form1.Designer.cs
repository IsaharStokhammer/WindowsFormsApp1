namespace WindowsFormsApp1
{
    partial class Form1
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
            this.day = new System.Windows.Forms.ComboBox();
            this.dayInMmonth = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.month1 = new System.Windows.Forms.ComboBox();
            this.yaer = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // day
            // 
            this.day.FormattingEnabled = true;
            this.day.Items.AddRange(new object[] {
            "באחד בשבת",
            "בשני בשבת",
            "בשלישי בשבת",
            "ברביעי בשבת",
            "בחמישי בשבת",
            "בששי בשבת"});
            this.day.Location = new System.Drawing.Point(525, 94);
            this.day.Name = "day";
            this.day.Size = new System.Drawing.Size(121, 24);
            this.day.TabIndex = 0;
            this.day.Text = "יום";
            this.day.SelectedIndexChanged += new System.EventHandler(this.day_SelectedIndexChanged);
            // 
            // dayInMmonth
            // 
            this.dayInMmonth.FormattingEnabled = true;
            this.dayInMmonth.Items.AddRange(new object[] {
            "יום אחד",
            "שני ימים",
            "שלשה ימים",
            "ארבעה ימים",
            "חמישה ימים",
            "שישה ימים",
            "שבעה ימים",
            "שומנה ימים",
            "תשעה ימים ",
            "עשרה ימים",
            "אחד עשר יום",
            "שנים עשר יום",
            "שלשה עשר יום",
            "ארבעה עשר ימים",
            "חמישה עשר ימים",
            "ששה עשר יום",
            "שבעה עשר ימים",
            "שמונה עשר ימים",
            "תשעהעשר ימים",
            "עשרים יום",
            "עשרים ואחד ימים",
            "עשרים ושתיים ימים",
            "עשרים ושלושה ימים",
            "עשרים וארבעה ימים",
            "עשרים וחמישה ימים",
            "עשרים וששה ימים",
            "עשרים ושבעה ימים",
            "עשרים ותשעה ימים",
            "שלושים ימים"});
            this.dayInMmonth.Location = new System.Drawing.Point(375, 94);
            this.dayInMmonth.Name = "dayInMmonth";
            this.dayInMmonth.Size = new System.Drawing.Size(121, 24);
            this.dayInMmonth.TabIndex = 1;
            this.dayInMmonth.Text = "יום בחודש";
            this.dayInMmonth.SelectedIndexChanged += new System.EventHandler(this.dayInMmonth_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(339, 219);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "שלח";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // month1
            // 
            this.month1.FormattingEnabled = true;
            this.month1.Items.AddRange(new object[] {
            "ניסן",
            "אייר",
            "סיון",
            "תמוז",
            "אב",
            "אלול",
            "תשרי",
            "חשון",
            "כסליו",
            "טבת",
            "שבט",
            "אדר א",
            "אדר ב"});
            this.month1.Location = new System.Drawing.Point(230, 94);
            this.month1.Name = "month1";
            this.month1.Size = new System.Drawing.Size(121, 24);
            this.month1.TabIndex = 3;
            this.month1.Text = "חודש";
            this.month1.SelectedIndexChanged += new System.EventHandler(this.month1_SelectedIndexChanged);
            // 
            // yaer
            // 
            this.yaer.FormattingEnabled = true;
            this.yaer.Items.AddRange(new object[] {
            "תשפ\"ד",
            "תשפ\"ה",
            "תשפ\"ו",
            "תשפ\"ז",
            "תשפ\"ח",
            "תשפ\"ט",
            "תש\"צ",
            "תשצ\"א",
            "תשצ\"ב",
            "תשצ\"ג",
            "תשצ\"ד",
            "תשצ\"ה",
            "תשצ\"ו",
            "תשצ\"ז",
            "תשצ\"ח",
            "תשצ\"ט",
            "תת\"ר",
            "תת\"א",
            "תת\"ב",
            "תת\"ג",
            "תת\"ד",
            "תת\"ה",
            "תת\"ו",
            "תת\"ז",
            "תת\"ח",
            "תת\"ט",
            "תתי\"א",
            "תתי\"ב",
            "תתי\"ג",
            "תתי\"ד",
            "תתי\"ה",
            "תתי\"ו",
            "תתי\"ז",
            "תתי\"ח",
            "תתי\"ט",
            "תת\"כ",
            "תתכ\"א",
            "תתכ\"ב",
            "תתכ\"ג",
            "תתכ\"ד"});
            this.yaer.Location = new System.Drawing.Point(80, 94);
            this.yaer.Name = "yaer";
            this.yaer.Size = new System.Drawing.Size(121, 24);
            this.yaer.TabIndex = 4;
            this.yaer.Text = "שנה";
            this.yaer.SelectedIndexChanged += new System.EventHandler(this.yaer_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(329, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "כתיבת תאריך";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.yaer);
            this.Controls.Add(this.month1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dayInMmonth);
            this.Controls.Add(this.day);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox day;
        private System.Windows.Forms.ComboBox dayInMmonth;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox month1;
        private System.Windows.Forms.ComboBox yaer;
        private System.Windows.Forms.Label label1;
    }
}

