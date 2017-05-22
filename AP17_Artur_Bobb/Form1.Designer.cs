namespace Ironman_Auswertung
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.buttonAnzeigen = new System.Windows.Forms.Button();
            this.radioSchwimmen = new System.Windows.Forms.RadioButton();
            this.radioLaufen = new System.Windows.Forms.RadioButton();
            this.radioFahrrad = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.radioGesamt = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioStunden = new System.Windows.Forms.RadioButton();
            this.radioMinuten = new System.Windows.Forms.RadioButton();
            this.buttonuncheck = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxVorname = new System.Windows.Forms.TextBox();
            this.textBoxSchwimmen = new System.Windows.Forms.TextBox();
            this.textBoxVerein = new System.Windows.Forms.TextBox();
            this.textBoxNachname = new System.Windows.Forms.TextBox();
            this.textBoxLaufen = new System.Windows.Forms.TextBox();
            this.textBoxRadfahren = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonAdden = new System.Windows.Forms.Button();
            this.buttonSieger = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 213);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(610, 355);
            this.listBox1.TabIndex = 0;
            // 
            // buttonAnzeigen
            // 
            this.buttonAnzeigen.Location = new System.Drawing.Point(236, 184);
            this.buttonAnzeigen.Name = "buttonAnzeigen";
            this.buttonAnzeigen.Size = new System.Drawing.Size(127, 23);
            this.buttonAnzeigen.TabIndex = 1;
            this.buttonAnzeigen.Text = "Teilnehmer anzeigen";
            this.buttonAnzeigen.UseVisualStyleBackColor = true;
            this.buttonAnzeigen.Click += new System.EventHandler(this.buttonAnzeigen_Click);
            // 
            // radioSchwimmen
            // 
            this.radioSchwimmen.AutoSize = true;
            this.radioSchwimmen.Location = new System.Drawing.Point(12, 27);
            this.radioSchwimmen.Name = "radioSchwimmen";
            this.radioSchwimmen.Size = new System.Drawing.Size(82, 17);
            this.radioSchwimmen.TabIndex = 2;
            this.radioSchwimmen.TabStop = true;
            this.radioSchwimmen.Text = "Schwimmen";
            this.radioSchwimmen.UseVisualStyleBackColor = true;
            // 
            // radioLaufen
            // 
            this.radioLaufen.AutoSize = true;
            this.radioLaufen.Location = new System.Drawing.Point(12, 50);
            this.radioLaufen.Name = "radioLaufen";
            this.radioLaufen.Size = new System.Drawing.Size(58, 17);
            this.radioLaufen.TabIndex = 3;
            this.radioLaufen.TabStop = true;
            this.radioLaufen.Text = "Laufen";
            this.radioLaufen.UseVisualStyleBackColor = true;
            // 
            // radioFahrrad
            // 
            this.radioFahrrad.AutoSize = true;
            this.radioFahrrad.Location = new System.Drawing.Point(103, 27);
            this.radioFahrrad.Name = "radioFahrrad";
            this.radioFahrrad.Size = new System.Drawing.Size(61, 17);
            this.radioFahrrad.TabIndex = 4;
            this.radioFahrrad.TabStop = true;
            this.radioFahrrad.Text = "Fahrrad";
            this.radioFahrrad.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nach Zeit sortieren:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(239, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Umrechnungsmöglichkeiten:";
            // 
            // radioGesamt
            // 
            this.radioGesamt.AutoSize = true;
            this.radioGesamt.Location = new System.Drawing.Point(103, 50);
            this.radioGesamt.Name = "radioGesamt";
            this.radioGesamt.Size = new System.Drawing.Size(89, 17);
            this.radioGesamt.TabIndex = 10;
            this.radioGesamt.TabStop = true;
            this.radioGesamt.Text = "Gesamtsieger";
            this.radioGesamt.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioStunden);
            this.panel1.Controls.Add(this.radioMinuten);
            this.panel1.Location = new System.Drawing.Point(236, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(127, 89);
            this.panel1.TabIndex = 11;
            // 
            // radioStunden
            // 
            this.radioStunden.AutoSize = true;
            this.radioStunden.Location = new System.Drawing.Point(21, 24);
            this.radioStunden.Name = "radioStunden";
            this.radioStunden.Size = new System.Drawing.Size(76, 17);
            this.radioStunden.TabIndex = 1;
            this.radioStunden.TabStop = true;
            this.radioStunden.Text = "in Stunden";
            this.radioStunden.UseVisualStyleBackColor = true;
            // 
            // radioMinuten
            // 
            this.radioMinuten.AutoSize = true;
            this.radioMinuten.Location = new System.Drawing.Point(21, 1);
            this.radioMinuten.Name = "radioMinuten";
            this.radioMinuten.Size = new System.Drawing.Size(74, 17);
            this.radioMinuten.TabIndex = 0;
            this.radioMinuten.TabStop = true;
            this.radioMinuten.Text = "in Minuten";
            this.radioMinuten.UseVisualStyleBackColor = true;
            // 
            // buttonuncheck
            // 
            this.buttonuncheck.Location = new System.Drawing.Point(15, 74);
            this.buttonuncheck.Name = "buttonuncheck";
            this.buttonuncheck.Size = new System.Drawing.Size(97, 23);
            this.buttonuncheck.TabIndex = 12;
            this.buttonuncheck.Text = "Alles uncheck";
            this.buttonuncheck.UseVisualStyleBackColor = true;
            this.buttonuncheck.Click += new System.EventHandler(this.buttonuncheck_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(438, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(218, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Sportler hinzufügen:        Zeiten in Sekunden";
            // 
            // textBoxVorname
            // 
            this.textBoxVorname.Location = new System.Drawing.Point(537, 26);
            this.textBoxVorname.Name = "textBoxVorname";
            this.textBoxVorname.Size = new System.Drawing.Size(135, 20);
            this.textBoxVorname.TabIndex = 14;
            // 
            // textBoxSchwimmen
            // 
            this.textBoxSchwimmen.Location = new System.Drawing.Point(537, 102);
            this.textBoxSchwimmen.Name = "textBoxSchwimmen";
            this.textBoxSchwimmen.Size = new System.Drawing.Size(135, 20);
            this.textBoxSchwimmen.TabIndex = 15;
            // 
            // textBoxVerein
            // 
            this.textBoxVerein.Location = new System.Drawing.Point(537, 76);
            this.textBoxVerein.Name = "textBoxVerein";
            this.textBoxVerein.Size = new System.Drawing.Size(135, 20);
            this.textBoxVerein.TabIndex = 16;
            // 
            // textBoxNachname
            // 
            this.textBoxNachname.Location = new System.Drawing.Point(537, 48);
            this.textBoxNachname.Name = "textBoxNachname";
            this.textBoxNachname.Size = new System.Drawing.Size(135, 20);
            this.textBoxNachname.TabIndex = 17;
            // 
            // textBoxLaufen
            // 
            this.textBoxLaufen.Location = new System.Drawing.Point(537, 154);
            this.textBoxLaufen.Name = "textBoxLaufen";
            this.textBoxLaufen.Size = new System.Drawing.Size(135, 20);
            this.textBoxLaufen.TabIndex = 18;
            // 
            // textBoxRadfahren
            // 
            this.textBoxRadfahren.Location = new System.Drawing.Point(537, 129);
            this.textBoxRadfahren.Name = "textBoxRadfahren";
            this.textBoxRadfahren.Size = new System.Drawing.Size(135, 20);
            this.textBoxRadfahren.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(431, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Vorname";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(431, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Nachname";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(431, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Verein";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(431, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Zeit Schwimmen";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(431, 132);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Zeit Radfahren";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(431, 158);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "Zeit Laufen";
            // 
            // buttonAdden
            // 
            this.buttonAdden.Location = new System.Drawing.Point(513, 184);
            this.buttonAdden.Name = "buttonAdden";
            this.buttonAdden.Size = new System.Drawing.Size(109, 23);
            this.buttonAdden.TabIndex = 26;
            this.buttonAdden.Text = "Sportler Hinzufügen";
            this.buttonAdden.UseVisualStyleBackColor = true;
            this.buttonAdden.Click += new System.EventHandler(this.buttonAdden_Click);
            // 
            // buttonSieger
            // 
            this.buttonSieger.Location = new System.Drawing.Point(29, 184);
            this.buttonSieger.Name = "buttonSieger";
            this.buttonSieger.Size = new System.Drawing.Size(123, 23);
            this.buttonSieger.TabIndex = 27;
            this.buttonSieger.Text = "Nur Sieger ermitteln";
            this.buttonSieger.UseVisualStyleBackColor = true;
            this.buttonSieger.Click += new System.EventHandler(this.buttonSieger_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 580);
            this.Controls.Add(this.buttonSieger);
            this.Controls.Add(this.buttonAdden);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxRadfahren);
            this.Controls.Add(this.textBoxLaufen);
            this.Controls.Add(this.textBoxNachname);
            this.Controls.Add(this.textBoxVerein);
            this.Controls.Add(this.textBoxSchwimmen);
            this.Controls.Add(this.textBoxVorname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonuncheck);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.radioGesamt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioFahrrad);
            this.Controls.Add(this.radioLaufen);
            this.Controls.Add(this.radioSchwimmen);
            this.Controls.Add(this.buttonAnzeigen);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Auswertungsprogramm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button buttonAnzeigen;
        private System.Windows.Forms.RadioButton radioSchwimmen;
        private System.Windows.Forms.RadioButton radioLaufen;
        private System.Windows.Forms.RadioButton radioFahrrad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioGesamt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioStunden;
        private System.Windows.Forms.RadioButton radioMinuten;
        private System.Windows.Forms.Button buttonuncheck;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxVorname;
        private System.Windows.Forms.TextBox textBoxSchwimmen;
        private System.Windows.Forms.TextBox textBoxVerein;
        private System.Windows.Forms.TextBox textBoxNachname;
        private System.Windows.Forms.TextBox textBoxLaufen;
        private System.Windows.Forms.TextBox textBoxRadfahren;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonAdden;
        private System.Windows.Forms.Button buttonSieger;
    }
}

