namespace ZPI2018_Z_GAMMA
{
    partial class MainForm
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
            this.Waluta2 = new System.Windows.Forms.ComboBox();
            this.Waluta = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Czas = new System.Windows.Forms.ComboBox();
            this.Sesje = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.Mediana = new System.Windows.Forms.RadioButton();
            this.Dominata = new System.Windows.Forms.RadioButton();
            this.OdchylenieStd = new System.Windows.Forms.RadioButton();
            this.WspolczynnikZmiennosci = new System.Windows.Forms.RadioButton();
            this.RozkladCzestosci = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Waluta2
            // 
            this.Waluta2.FormattingEnabled = true;
            this.Waluta2.Items.AddRange(new object[] {
            "AUD",
            "BGN",
            "BRL",
            "CAD",
            "CHF",
            "CLP",
            "CNY",
            "CZK",
            "DKK",
            "EUR",
            "GBP",
            "HKD",
            "HRK",
            "HUF",
            "IDR",
            "ILS",
            "INR",
            "ISK",
            "JPY",
            "KRW",
            "MXN",
            "MYR",
            "NOK",
            "NZD",
            "PHP",
            "RON",
            "RUB",
            "SEK",
            "SGD",
            "THB",
            "TRY",
            "UAH",
            "USD",
            "XDR",
            "ZAR"});
            this.Waluta2.Location = new System.Drawing.Point(39, 104);
            this.Waluta2.Name = "Waluta2";
            this.Waluta2.Size = new System.Drawing.Size(132, 24);
            this.Waluta2.TabIndex = 0;
            this.Waluta2.SelectedIndexChanged += new System.EventHandler(this.Waluta2_SelectedIndexChanged);
            // 
            // Waluta
            // 
            this.Waluta.FormattingEnabled = true;
            this.Waluta.Items.AddRange(new object[] {
            "AUD",
            "BGN",
            "BRL",
            "CAD",
            "CHF",
            "CLP",
            "CNY",
            "CZK",
            "DKK",
            "EUR",
            "GBP",
            "HKD",
            "HRK",
            "HUF",
            "IDR",
            "ILS",
            "INR",
            "ISK",
            "JPY",
            "KRW",
            "MXN",
            "MYR",
            "NOK",
            "NZD",
            "PHP",
            "RON",
            "RUB",
            "SEK",
            "SGD",
            "THB",
            "TRY",
            "UAH",
            "USD",
            "XDR",
            "ZAR"});
            this.Waluta.Location = new System.Drawing.Point(39, 74);
            this.Waluta.Name = "Waluta";
            this.Waluta.Size = new System.Drawing.Size(132, 24);
            this.Waluta.Sorted = true;
            this.Waluta.TabIndex = 1;
            this.Waluta.SelectedIndexChanged += new System.EventHandler(this.Waluta_SelectedIndexChanged);
            this.Waluta.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Waluta_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(31, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 48);
            this.label1.TabIndex = 2;
            this.label1.Text = "Waluty:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(240, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(280, 48);
            this.label2.TabIndex = 4;
            this.label2.Text = "Zakres czasu:";
            // 
            // Czas
            // 
            this.Czas.FormattingEnabled = true;
            this.Czas.Items.AddRange(new object[] {
            "Tydzień",
            "Dwa Tygodnie",
            "Miesiąc",
            "Kwartał",
            "Pół Roku",
            "Rok"});
            this.Czas.Location = new System.Drawing.Point(248, 74);
            this.Czas.Name = "Czas";
            this.Czas.Size = new System.Drawing.Size(263, 24);
            this.Czas.TabIndex = 3;
            this.Czas.SelectedIndexChanged += new System.EventHandler(this.Czas_SelectedIndexChanged);
            // 
            // Sesje
            // 
            this.Sesje.AutoSize = true;
            this.Sesje.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Sesje.Location = new System.Drawing.Point(39, 208);
            this.Sesje.Name = "Sesje";
            this.Sesje.Size = new System.Drawing.Size(907, 29);
            this.Sesje.TabIndex = 5;
            this.Sesje.TabStop = true;
            this.Sesje.Text = "Wyznaczenie ilości sesji wzrostowych, spadkowych i bez zmian  dla wybranej  walut" +
    "y i zakresu czasu";
            this.Sesje.UseVisualStyleBackColor = true;
            this.Sesje.CheckedChanged += new System.EventHandler(this.Sesje_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(31, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(381, 48);
            this.label3.TabIndex = 6;
            this.label3.Text = "Dostępne operacje:";
            // 
            // Mediana
            // 
            this.Mediana.AutoSize = true;
            this.Mediana.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Mediana.Location = new System.Drawing.Point(39, 243);
            this.Mediana.Name = "Mediana";
            this.Mediana.Size = new System.Drawing.Size(433, 29);
            this.Mediana.TabIndex = 7;
            this.Mediana.TabStop = true;
            this.Mediana.Text = "Mediana  dla wybranej  waluty i zakresu czasu";
            this.Mediana.UseVisualStyleBackColor = true;
            this.Mediana.CheckedChanged += new System.EventHandler(this.Mediana_CheckedChanged);
            // 
            // Dominata
            // 
            this.Dominata.AutoSize = true;
            this.Dominata.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Dominata.Location = new System.Drawing.Point(39, 278);
            this.Dominata.Name = "Dominata";
            this.Dominata.Size = new System.Drawing.Size(440, 29);
            this.Dominata.TabIndex = 8;
            this.Dominata.TabStop = true;
            this.Dominata.Text = "Dominata  dla wybranej  waluty i zakresu czasu";
            this.Dominata.UseVisualStyleBackColor = true;
            this.Dominata.CheckedChanged += new System.EventHandler(this.Dominata_CheckedChanged);
            // 
            // OdchylenieStd
            // 
            this.OdchylenieStd.AutoSize = true;
            this.OdchylenieStd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.OdchylenieStd.Location = new System.Drawing.Point(39, 313);
            this.OdchylenieStd.Name = "OdchylenieStd";
            this.OdchylenieStd.Size = new System.Drawing.Size(568, 29);
            this.OdchylenieStd.TabIndex = 9;
            this.OdchylenieStd.TabStop = true;
            this.OdchylenieStd.Text = "Odchylenie standardowe dla wybranej  waluty i zakresu czasu";
            this.OdchylenieStd.UseVisualStyleBackColor = true;
            this.OdchylenieStd.CheckedChanged += new System.EventHandler(this.OdchylenieStd_CheckedChanged);
            // 
            // WspolczynnikZmiennosci
            // 
            this.WspolczynnikZmiennosci.AutoSize = true;
            this.WspolczynnikZmiennosci.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.WspolczynnikZmiennosci.Location = new System.Drawing.Point(39, 348);
            this.WspolczynnikZmiennosci.Name = "WspolczynnikZmiennosci";
            this.WspolczynnikZmiennosci.Size = new System.Drawing.Size(577, 29);
            this.WspolczynnikZmiennosci.TabIndex = 10;
            this.WspolczynnikZmiennosci.TabStop = true;
            this.WspolczynnikZmiennosci.Text = "Współczynnik zmienności dla wybranej  waluty i zakresu czasu";
            this.WspolczynnikZmiennosci.UseVisualStyleBackColor = true;
            this.WspolczynnikZmiennosci.CheckedChanged += new System.EventHandler(this.WspolczynnikZmiennosci_CheckedChanged);
            // 
            // RozkladCzestosci
            // 
            this.RozkladCzestosci.AutoSize = true;
            this.RozkladCzestosci.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RozkladCzestosci.Location = new System.Drawing.Point(39, 383);
            this.RozkladCzestosci.Name = "RozkladCzestosci";
            this.RozkladCzestosci.Size = new System.Drawing.Size(607, 29);
            this.RozkladCzestosci.TabIndex = 11;
            this.RozkladCzestosci.TabStop = true;
            this.RozkladCzestosci.Text = "Rozkład zmian miesięcznych i kwartalnych dla wybranej pary walut";
            this.RozkladCzestosci.UseVisualStyleBackColor = true;
            this.RozkladCzestosci.CheckedChanged += new System.EventHandler(this.RozkladCzestosci_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(722, 55);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(224, 61);
            this.button1.TabIndex = 12;
            this.button1.Text = "Wykonaj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.RozkladCzestosci);
            this.Controls.Add(this.WspolczynnikZmiennosci);
            this.Controls.Add(this.OdchylenieStd);
            this.Controls.Add(this.Dominata);
            this.Controls.Add(this.Mediana);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Sesje);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Czas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Waluta);
            this.Controls.Add(this.Waluta2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Waluta2;
        private System.Windows.Forms.ComboBox Waluta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Czas;
        private System.Windows.Forms.RadioButton Sesje;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton Mediana;
        private System.Windows.Forms.RadioButton Dominata;
        private System.Windows.Forms.RadioButton OdchylenieStd;
        private System.Windows.Forms.RadioButton WspolczynnikZmiennosci;
        private System.Windows.Forms.RadioButton RozkladCzestosci;
        private System.Windows.Forms.Button button1;
    }
}

