using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Data.OleDb;

namespace Ironman_Auswertung
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAnzeigen_Click(object sender, EventArgs e)
        {
            try
            {
                //Säubern der Listbox
                listBox1.Items.Clear();

                //Datenbank verbindung initialisieren
                OleDbConnection dbDatenbankverbindung = new
                OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source = Ironman_2017.accdb;");

                //Datenbank öffnen
                dbDatenbankverbindung.Open();

                //Allegmein zu den Zeiten bzw anzeigen
                #region Zeiten anzeigen

                #region Radfahren
                //Sieger im Radfahren
                if (radioFahrrad.Checked)
                {
                    OleDbCommand dbAuslesebefehl = new OleDbCommand("SELECT * FROM Sportler ORDER BY Zeit_Radfahren", dbDatenbankverbindung);

                    OleDbDataReader dbGelieferteDaten = dbAuslesebefehl.ExecuteReader();
                    string sBike;
                    int iBike;

                    while (dbGelieferteDaten.Read())
                    {
                        sBike = dbGelieferteDaten["Zeit_Laufen"].ToString();
                        iBike = Convert.ToInt32(sBike);

                        if (radioMinuten.Checked)
                        {
                            iBike = iBike / 60;
                            this.listBox1.Items.Add(dbGelieferteDaten["Vorname"] + " " + dbGelieferteDaten["Nachname"] + " -- Verein: " + dbGelieferteDaten["Verein"] + " -- Zeit Radfahren: " +
                            iBike + "m");
                        }

                        else if (radioStunden.Checked)
                        {
                            iBike = iBike / 60;
                            iBike = iBike / 60;

                            this.listBox1.Items.Add(dbGelieferteDaten["Vorname"] + " " + dbGelieferteDaten["Nachname"] + " -- Verein: " + dbGelieferteDaten["Verein"] + " -- Zeit Radfahren: " +
                            iBike + "h");
                        }
                        else
                        {
                            this.listBox1.Items.Add(dbGelieferteDaten["Vorname"] + " " + dbGelieferteDaten["Nachname"] + " -- Verein: " + dbGelieferteDaten["Verein"] + " -- Zeit Radfahren: " +
                            dbGelieferteDaten["Zeit_Radfahren"] + "s");
                        }
                    }

                    dbGelieferteDaten.Close();
                }
                #endregion

                #region Laufen
                //Sieger im Schwimmen ausfindig machen
                else if (radioLaufen.Checked)
                {
                    OleDbCommand dbAuslesebefehl = new OleDbCommand("SELECT * FROM Sportler ORDER BY Zeit_Laufen", dbDatenbankverbindung);

                    OleDbDataReader dbGelieferteDaten = dbAuslesebefehl.ExecuteReader();

                    string sRun;
                    int iRun;

                    while (dbGelieferteDaten.Read())
                    {
                        sRun = dbGelieferteDaten["Zeit_Laufen"].ToString();
                        iRun = Convert.ToInt32(sRun);

                        if (radioMinuten.Checked)
                        {
                            iRun = iRun / 60;
                            this.listBox1.Items.Add(dbGelieferteDaten["Vorname"] + " " + dbGelieferteDaten["Nachname"] + " -- Verein: " + dbGelieferteDaten["Verein"] + " -- Zeit Laufen: " +
                            iRun + "m");
                        }

                        else if (radioStunden.Checked)
                        {
                            iRun = iRun / 60;
                            iRun = iRun / 60;

                            this.listBox1.Items.Add(dbGelieferteDaten["Vorname"] + " " + dbGelieferteDaten["Nachname"] + " -- Verein: " + dbGelieferteDaten["Verein"] + " -- Zeit Laufen: " +
                            iRun + "h");
                        }
                        else
                        {
                            this.listBox1.Items.Add(dbGelieferteDaten["Vorname"] + " " + dbGelieferteDaten["Nachname"] + " -- Verein: " + dbGelieferteDaten["Verein"] + " -- Zeit Laufen: " +
                            dbGelieferteDaten["Zeit_Laufen"] + "s");
                        }

                    }

                    dbGelieferteDaten.Close();
                }
                #endregion Laufen

                #region RadioSchwimmen
                //Sieger im Schwimmen ausfindig machen
                else if (radioSchwimmen.Checked)
                {
                    OleDbCommand dbAuslesebefehl = new OleDbCommand("SELECT * FROM Sportler ORDER BY Zeit_Schwimmen", dbDatenbankverbindung);

                    OleDbDataReader dbGelieferteDaten = dbAuslesebefehl.ExecuteReader();

                    string sSwim;
                    int iSwim;

                    while (dbGelieferteDaten.Read())
                    {
                        sSwim = dbGelieferteDaten["Zeit_Schwimmen"].ToString();
                        iSwim = Convert.ToInt32(sSwim);

                        if (radioMinuten.Checked)
                        {
                            iSwim = iSwim / 60;

                            this.listBox1.Items.Add(dbGelieferteDaten["Vorname"] + " " + dbGelieferteDaten["Nachname"] + " -- Verein: " + dbGelieferteDaten["Verein"] + " -- Zeit Schwimmen: " +
                           iSwim + "m");
                        }

                        else if (radioStunden.Checked)
                        {
                            iSwim = iSwim / 60;
                            iSwim = iSwim / 60;

                            this.listBox1.Items.Add(dbGelieferteDaten["Vorname"] + " " + dbGelieferteDaten["Nachname"] + " -- Verein: " + dbGelieferteDaten["Verein"] + " -- Zeit Schwimmen: " +
                           iSwim + "h");
                        }

                        else
                        {
                            this.listBox1.Items.Add(dbGelieferteDaten["Vorname"] + " " + dbGelieferteDaten["Nachname"] + " -- Verein: " + dbGelieferteDaten["Verein"] + " -- Zeit Schwimmen: " +
                            dbGelieferteDaten["Zeit_Schwimmen"] + "s");
                        }

                    }

                    dbGelieferteDaten.Close();
                }
                #endregion

                #region Gesamt
                //gesamtsieger ausgeben und falls nötig zeit umwandeln
                else if (radioGesamt.Checked)
                {
                    OleDbCommand dbAuslesebefehl = new OleDbCommand("SELECT * FROM Sportler", dbDatenbankverbindung);

                    //Deklarieren und initialisieren
                    OleDbDataReader dbGelieferteDaten = dbAuslesebefehl.ExecuteReader();
                    string sSwim, sRun, sBike;
                    int iSwim, iRun, iBike, iAvg;

                    while (dbGelieferteDaten.Read())
                    {
                        sSwim = dbGelieferteDaten["Zeit_Schwimmen"].ToString();
                        sRun = dbGelieferteDaten["Zeit_Laufen"].ToString();
                        sBike = dbGelieferteDaten["Zeit_Radfahren"].ToString();

                        iSwim = Convert.ToInt32(sSwim);
                        iRun = Convert.ToInt32(sRun);
                        iBike = Convert.ToInt32(sBike);

                        //Durchschnitt ausrechnen
                        iAvg = iSwim + iRun + iBike / 3;
                        //Stunden ausrechnen
                        if (radioStunden.Checked)
                        {
                            iAvg = iAvg / 60;
                            iAvg = iAvg / 60;

                            this.listBox1.Items.Add(dbGelieferteDaten["Vorname"] + " " + dbGelieferteDaten["Nachname"] + " -- Verein: " + dbGelieferteDaten["Verein"] + "--Durchschnittszeit: " + iAvg + "h");
                        }
                            //Minuten ausrechnen
                        else if (radioMinuten.Checked)
                        {
                            iAvg = iAvg / 60;
                            this.listBox1.Items.Add(dbGelieferteDaten["Vorname"] + " " + dbGelieferteDaten["Nachname"] + " -- Verein: " + dbGelieferteDaten["Verein"] + "--Durchschnittszeit: " + iAvg + "m");
                        }

                        else
                        {
                            this.listBox1.Items.Add(dbGelieferteDaten["Vorname"] + " " + dbGelieferteDaten["Nachname"] + " -- Verein: " + dbGelieferteDaten["Verein"] + "--Durchschnittszeit: " + iAvg + "s");
                        }

                    }

                    dbGelieferteDaten.Close();
                }
                #endregion

                else
                {
                    //Else alles ausgeben in Sekunden
                    OleDbCommand dbAuslesebefehl = new OleDbCommand("SELECT * FROM Sportler", dbDatenbankverbindung);

                    OleDbDataReader dbGelieferteDaten = dbAuslesebefehl.ExecuteReader();

                    while (dbGelieferteDaten.Read())
                    {
                        this.listBox1.Items.Add(dbGelieferteDaten["Vorname"] + " " + dbGelieferteDaten["Nachname"] + " -- Verein: " + dbGelieferteDaten["Verein"] + " -- Zeit Schwimmen: " + dbGelieferteDaten["Zeit_Schwimmen"] + "s" + " -- Zeit Radfahren: " +
                            dbGelieferteDaten["Zeit_Radfahren"] + "s" + " -- Zeit Laufen: " + dbGelieferteDaten["Zeit_Laufen"] + "s");
                    }
                    dbGelieferteDaten.Close();

                }
                #endregion
                //Textdokument Schreiben alle daten
                StreamWriter swtxt = new StreamWriter("D:\\Ironman_2017.txt");
                OleDbCommand dbAuslesebefehlsw = new OleDbCommand("SELECT * FROM Sportler", dbDatenbankverbindung);
                OleDbDataReader dbGelieferteDatensw = dbAuslesebefehlsw.ExecuteReader();

                while (dbGelieferteDatensw.Read())
                {
                    swtxt.WriteLine(dbGelieferteDatensw["Vorname"] + " " + dbGelieferteDatensw["Nachname"] + " -- Verein: " + dbGelieferteDatensw["Verein"] + " -- Zeit Schwimmen: " + dbGelieferteDatensw["Zeit_Schwimmen"] + "s" + " -- Zeit Radfahren: " +
                            dbGelieferteDatensw["Zeit_Radfahren"] + "s" + " -- Zeit Laufen: " + dbGelieferteDatensw["Zeit_Laufen"] + "s");
                }
                swtxt.Close();

            }
            //Fehlermeldung
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        //Alle Radiobuttons zurücksetzen
        private void buttonuncheck_Click(object sender, EventArgs e)
        {
            radioFahrrad.Checked = false;
            radioGesamt.Checked = false;
            radioLaufen.Checked = false;
            radioMinuten.Checked = false;
            radioSchwimmen.Checked = false;
            radioStunden.Checked = false;
        }

        //Sportler Hinzufügen
        private void buttonAdden_Click(object sender, EventArgs e)
        {
            try
            {
                String sVorname = textBoxVorname.Text;
                String sName = textBoxNachname.Text;
                String sVerien = textBoxVerein.Text;
                int iZSwim = Convert.ToInt32(textBoxSchwimmen.Text);
                int iZRun = Convert.ToInt32(textBoxLaufen.Text);
                int iZBike = Convert.ToInt32(textBoxRadfahren.Text);
                int iAktuelleID = 0;

                OleDbConnection dbDatenbankverbindung = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source = Ironman_2017.accdb;");

                dbDatenbankverbindung.Open();
                // Maximale ID raussuchen

                OleDbCommand dbAuslesebefehlID = new OleDbCommand("SELECT MAX(ID) AS MaxID FROM Sportler", dbDatenbankverbindung);
                OleDbDataReader dbGelieferteID = dbAuslesebefehlID.ExecuteReader();
                if (dbGelieferteID.Read() == true)
                {
                    iAktuelleID = Convert.ToInt32(dbGelieferteID["MaxID"]);
                    //Maximale ID plus 1
                    iAktuelleID++;
                }
                OleDbCommand dbInsert = new OleDbCommand("INSERT INTO Sportler (ID, Vorname, Nachname, Verein, Zeit_Schwimmen, Zeit_Radfahren, Zeit_Laufen) VALUES (" + iAktuelleID.ToString() + ",'" + sVorname + "','" + sName + "','" + sVerien + "'," + iZSwim.ToString() + "," + iZBike.ToString() + "," + iZRun + ")", dbDatenbankverbindung);
                dbInsert.ExecuteNonQuery();

                dbDatenbankverbindung.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void buttonSieger_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            //Datenbank verbindung aufbauen
            OleDbConnection dbDatenbankverbindung = new
            OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source = Ironman_2017.accdb;");

            dbDatenbankverbindung.Open();

            //Datenbankabfragen zu den Kategorien
            OleDbCommand dbSchwimmen = new OleDbCommand("SELECT Vorname, Nachname, Zeit_Schwimmen FROM Sportler ORDER BY Zeit_Schwimmen ASC", dbDatenbankverbindung);
            OleDbCommand dbRadfahren = new OleDbCommand("SELECT Vorname, Nachname, Zeit_Radfahren FROM Sportler ORDER BY Zeit_Radfahren ASC", dbDatenbankverbindung);
            OleDbCommand dbLaufen = new OleDbCommand("SELECT Vorname, Nachname, Zeit_Laufen FROM Sportler ORDER BY Zeit_Laufen ASC", dbDatenbankverbindung);

            OleDbDataReader dbAllesgeliefert = dbSchwimmen.ExecuteReader();
            OleDbDataReader dbGDatenRad = dbRadfahren.ExecuteReader();
            OleDbDataReader dbDatenLaufen = dbLaufen.ExecuteReader();


            int integer = 0;
            int integer1 = 0;
            int integer2 = 0;

            //Abfragen der Ganzen sieger
            while (dbAllesgeliefert.Read())
            {

                if (integer == 0)
                {
                    this.listBox1.Items.Add("Der Sieger in der Kategorie Schwimmen ist:\n" + dbAllesgeliefert["Vorname"].ToString() + " " + dbAllesgeliefert["Nachname"].ToString() + " " + "mit einer Zeit von " + dbAllesgeliefert["Zeit_Schwimmen"]);

                }
                integer++;
            }

            while (dbGDatenRad.Read())
            {

                if (integer1 == 0)
                {
                    this.listBox1.Items.Add("\nDer Sieger in der Kategorie Radfahren ist:\n" + dbGDatenRad["Vorname"].ToString() + " " + dbGDatenRad["Nachname"].ToString() + " " + "mit einer Zeit von " + dbGDatenRad["Zeit_Radfahren"]);
                }
                integer1++;
            }

            while (dbDatenLaufen.Read())
            {

                if (integer2 == 0)
                {
                    this.listBox1.Items.Add("\nDer Sieger in der Kategorie Laufen ist:\n" + dbDatenLaufen["Vorname"].ToString() + " " + dbDatenLaufen["Nachname"].ToString() + " " + "mit einer Zeit von " + dbDatenLaufen["Zeit_Laufen"]);
                }
                integer2++;
            }




        }
    }
}
