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

namespace _PROJET_IHS_test
{
    public partial class Form1 : Form
    {
        Stopwatch watch = new Stopwatch();
        Random rand = new Random();
        string[] operateurs = { "+", "-", "/" ,"x"};
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Label5_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < 5; ++i)
            {
                watch.Start();
                int choixOperateur = rand.Next(0, 3 + 1);
                labelOperateur.Text = "" + operateurs[choixOperateur];
                labelOperateur.Refresh();

                labelNombre1.Text  =""+ rand.Next(1, 21);
                labelNombre1.Refresh();

                labelNombre2.Text  =""+ rand.Next(1, 21);
                labelNombre2.Refresh();
                switch(choixOperateur)
                {
                    case 0:
                        labelReponse.Text = "" + (int.Parse(labelNombre1.Text) + int.Parse(labelNombre2.Text) + rand.Next(0, 4) - 2);
                        break;

                    case 1:
                        labelReponse.Text = "" + (int.Parse(labelNombre1.Text) - int.Parse(labelNombre2.Text) + rand.Next(0, 4) - 2);
                        break;

                    case 2:
                        labelReponse.Text = "" + (int.Parse(labelNombre1.Text) / int.Parse(labelNombre2.Text) + rand.Next(0, 4) - 2);
                        break;

                    case 3:
                        labelReponse.Text = "" + (int.Parse(labelNombre1.Text) * int.Parse(labelNombre2.Text) + rand.Next(0, 4) - 2);
                        break;
                }
                labelReponse.Refresh();

                labelAvancement.Text = ""+i+"/4";
                labelAvancement.Refresh();
                do
                {
                    //nothing
                } while (watch.ElapsedMilliseconds <=2000);

                watch.Stop();
                watch.Reset();
                
            }
        }
    }
}
