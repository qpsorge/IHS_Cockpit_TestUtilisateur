using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
using System.Timers;
using System.IO;

namespace _PROJET_IHS_test
{
    public partial class Form1 : Form
    {
        Stopwatch watch = new Stopwatch();
        Random rand = new Random();
        string[] operateurs = { "+", "-", "/" ,"x"};
        List<Tuple<int, double>> taillesTemps = new List<Tuple<int, double>>(); // taille de police, temps de réaction
        private static System.Timers.Timer chrono;
        int alarmeAffichee = -1;
        double tempsAlarmeAffichee = 0.0;
        TimeSpan debutAlarme;
        int iChrono = 0;

        public delegate void Del(string nombre1, string nombre2, string operation, string resultats);
        public delegate void Del2(int size);
        public delegate void Del3();

        public Delegate UpdateAlarmeDelegate(int size)
        {
            UpdateAlarme(size);
            return new Del2(UpdateAlarme);
        }

        public Delegate UpdateTextDelegate(string nombre1, string nombre2, string operation, string resultats)
        {
            UpdateText(nombre1, nombre2, operation, resultats);
            return new Del(UpdateText);
        }

        public Delegate SupprimeAlarmeDelegate()
        {
            SupprimerAlarme();
            return new Del3(SupprimerAlarme);
        }

        public void UpdateAlarme(int size)
        {
            if (labelAlarme.InvokeRequired)
            {
                labelAlarme.Invoke(new Del2(UpdateAlarme), size);
            }
            else
            {
                labelAlarme.Font = new Font("Arial", size, FontStyle.Bold);
                labelAlarme.ForeColor = Color.Red;
                labelAlarme.Refresh();
                debutAlarme = watch.Elapsed;
            }
        }

        public void UpdateText(string nombre1, string nombre2, string operation, string resultat)
        {
            if (labelNombre1.InvokeRequired)
            {
                // This is a worker thread so delegate the task.
                labelNombre1.Invoke(new Del(UpdateText), nombre1, nombre2, operation, resultat);
            }
            else
            {
                // This is the UI thread so perform the task.
                labelNombre1.Text = nombre1;
                labelNombre2.Text = nombre2;
                labelOperateur.Text = operation;
                labelReponse.Text = resultat;
            }
        }
        public void SupprimerAlarme()
        {
            if (labelAlarme.InvokeRequired)
            {
                labelAlarme.Invoke(new Del3(SupprimerAlarme));
            }
            else
            {
                alarmeAffichee = -1;
                tempsAlarmeAffichee = 0.0;
                labelAlarme.ForeColor = Color.Black;
                labelAlarme.Refresh();
            }
        }

        private void OnChronoTimedEvent(object source, ElapsedEventArgs e)
        {
            ++iChrono;

            if (alarmeAffichee != -1)
            {
                tempsAlarmeAffichee += 0.4;
                if (tempsAlarmeAffichee >= 5)
                {
                    taillesTemps[alarmeAffichee] = new Tuple<int, double>(taillesTemps[alarmeAffichee].Item1, 5000);
                    SupprimerAlarme();
                }
            }
            if (iChrono % 5 == 1) // modification opérations
            {
                int choixOperateur = rand.Next(0, 3 + 1);
                string operation = "" + operateurs[choixOperateur];
                string nombre1 = "" + rand.Next(1, 21);
                string nombre2 = "" + rand.Next(1, 21);
                string resultat = "";
                switch (choixOperateur)
                {
                    case 0:
                        resultat = "" + (int.Parse(labelNombre1.Text) + int.Parse(labelNombre2.Text) + rand.Next(0, 4) - 2);
                        break;
                    case 1:
                        resultat = "" + (int.Parse(labelNombre1.Text) - int.Parse(labelNombre2.Text) + rand.Next(0, 4) - 2);
                        break;
                    case 2:
                        resultat = "" + (int.Parse(labelNombre1.Text) / int.Parse(labelNombre2.Text) + rand.Next(0, 4) - 2);
                        break;
                    case 3:
                        resultat = "" + (int.Parse(labelNombre1.Text) * int.Parse(labelNombre2.Text) + rand.Next(0, 4) - 2);
                        break;
                }
                UpdateTextDelegate(nombre1, nombre2, operation, resultat);
            }
            else
            {
                int randnumber = rand.Next(0, 50);
                if (alarmeAffichee == -1 && randnumber >= 48)
                {
                    ChoisirAlarmeAAfficherRandom();
                    UpdateAlarmeDelegate(taillesTemps[alarmeAffichee].Item1);
                }
            }
        }

        public bool termine()
        {
            bool termine = true;
            int i = 0;
            while (termine && i < taillesTemps.Count)
            {
                if (taillesTemps[i].Item2 == 0.0)
                {
                    termine = false;
                }
                ++i;
            }
            if (termine)
            {
                boutonTermine.Show();
                chrono.Close();
            }
            return termine;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void ChoisirAlarmeAAfficherRandom()
        {
            bool trouve = false;
            if (termine())
                return;
            while (!trouve) // TODO vérifier qu'il reste des nouvelles alarmes à afficher
            {
                alarmeAffichee = rand.Next(0, taillesTemps.Count);
                if (taillesTemps[alarmeAffichee].Item2 == 0.0)
                    trouve = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            boutonTermine.Hide();

            taillesTemps.Add(new Tuple<int, double> (6, 0.0));
            taillesTemps.Add(new Tuple<int, double> (7, 0.0));
            taillesTemps.Add(new Tuple<int, double> (8, 0.0));
            taillesTemps.Add(new Tuple<int, double> (9, 0.0));
            taillesTemps.Add(new Tuple<int, double> (10, 0.0));
            taillesTemps.Add(new Tuple<int, double> (11, 0.0));
            taillesTemps.Add(new Tuple<int, double> (12, 0.0));
            taillesTemps.Add(new Tuple<int, double> (13, 0.0));
            taillesTemps.Add(new Tuple<int, double> (14, 0.0));
            taillesTemps.Add(new Tuple<int, double> (15, 0.0));
            taillesTemps.Add(new Tuple<int, double> (16, 0.0));
            taillesTemps.Add(new Tuple<int, double> (17, 0.0));
            taillesTemps.Add(new Tuple<int, double> (18, 0.0));
            taillesTemps.Add(new Tuple<int, double> (19, 0.0));
            taillesTemps.Add(new Tuple<int, double> (20, 0.0));
            taillesTemps.Add(new Tuple<int, double> (21, 0.0));
            taillesTemps.Add(new Tuple<int, double> (22, 0.0));
            taillesTemps.Add(new Tuple<int, double> (23, 0.0));
            taillesTemps.Add(new Tuple<int, double> (24, 0.0));
            taillesTemps.Add(new Tuple<int, double> (25, 0.0));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Hide();

            // Create a timer and set a two second interval.
            chrono = new System.Timers.Timer();
            chrono.Interval = 400;
            // Hook up the Elapsed event for the timer. 
            chrono.Elapsed += OnChronoTimedEvent;
            // Have the timer fire repeated events (true is the default)
            chrono.AutoReset = true;
            // Start the timer
            chrono.Enabled = true;

            watch.Start();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (alarmeAffichee != -1)
            {
                TimeSpan debut = debutAlarme;
                TimeSpan fin = watch.Elapsed;
                double milliseconds = (fin - debut).TotalMilliseconds;
                taillesTemps[alarmeAffichee] = new Tuple<int, double>(taillesTemps[alarmeAffichee].Item1, milliseconds);
                effacerAlarme();
            }
        }

        private void effacerAlarme()
        {
            alarmeAffichee = -1;
            tempsAlarmeAffichee = 0.0;
            labelAlarme.ForeColor = Color.Black;
            labelAlarme.Refresh();
            termine();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //File.Create("./tempsTaille.csv");

            FileStream fs = new FileStream("./tempsTaille.csv", FileMode.Create);
            StreamWriter w = new StreamWriter(fs, Encoding.UTF8);

            w.WriteLine("tailleTexte;tempsReaction");
            foreach(Tuple<int,double> tuple in taillesTemps)
            {
                w.WriteLine(tuple.Item1 + ";" + tuple.Item2);
            }

            w.Flush();
            w.Close();
            fs.Close();
        }
    }
}
