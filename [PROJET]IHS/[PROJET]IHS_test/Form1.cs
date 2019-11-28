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

namespace _PROJET_IHS_test
{
    public partial class Form1 : Form
    {
        Stopwatch watch = new Stopwatch();
        Random rand = new Random();
        string[] operateurs = { "+", "-", "/" ,"x"};
        List<Tuple<int, double>> taillesTemps = new List<Tuple<int, double>>(); // taille de police, temps de réaction
        private static System.Timers.Timer chrono;

        public delegate void Del(string nombre1, string nombre2, string operation, string resultats);

        public Delegate UpdateTextDelegate(string nombre1, string nombre2, string operation, string resultats)
        {
            UpdateText(nombre1, nombre2, operation, resultats);
            return new Del(UpdateText);
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

        private void OnTimedEvent(object source, ElapsedEventArgs e)
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

        public Form1()
        {
            InitializeComponent();
        }
        public void afficherAlarme(int size)
        {
            labelAlarme.Font = new Font("Arial",size,FontStyle.Bold);
            labelAlarme.ForeColor = Color.Red;
            labelAlarme.Refresh();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            taillesTemps.Add(new Tuple<int, double> (20, 0.0));
            taillesTemps.Add(new Tuple<int, double> (15, 0.0));
            taillesTemps.Add(new Tuple<int, double> (10, 0.0));
            taillesTemps.Add(new Tuple<int, double> (18, 0.0));
            taillesTemps.Add(new Tuple<int, double> (12, 0.0));
            taillesTemps.Add(new Tuple<int, double> (14, 0.0));
            taillesTemps.Add(new Tuple<int, double> (11, 0.0));
            taillesTemps.Add(new Tuple<int, double> (6, 0.0));
            taillesTemps.Add(new Tuple<int, double> (13, 0.0));
            taillesTemps.Add(new Tuple<int, double> (19, 0.0));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Hide();
            bool fini = false;
            bool detecte = false;
            int i = 0;

            // Create a timer and set a two second interval.
            chrono = new System.Timers.Timer();
            chrono.Interval = 2000;
            // Hook up the Elapsed event for the timer. 
            chrono.Elapsed += OnTimedEvent;
            // Have the timer fire repeated events (true is the default)
            chrono.AutoReset = true;
            // Start the timer
            chrono.Enabled = true;
            
            /*while (!fini && i<taillesTemps.Count())
            {
                

            }*/
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            labelAlarme.ForeColor = Color.Black;
            labelAlarme.Refresh();
        }
    }
}
