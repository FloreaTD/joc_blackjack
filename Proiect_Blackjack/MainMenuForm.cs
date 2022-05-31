using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_Blackjack
{
    public partial class MainMenuForm : Form
    {
        public static GameScreenForm gameScreen = new GameScreenForm();
        public MainMenuForm()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            gameScreen.Show();
            gameScreen.hitButton.Tag = "FazaPariu";
            gameScreen.afisareDisplay();
            this.Hide();    
        }

        private void rulesBtn_Click(object sender, EventArgs e)
        {
            string title = "Reguli joc";
            string message = "Scopul la blackjack este să obții un scor cât mai aproape de 21 posibil, dacă treci peste 21, pierzi." +
                "\nPuteți alege să „Loviți” pentru a trage o altă carte sau „Stai” dacă ești mulțumit de scorul tău și închei rândul tău." +
                "\nOdată ce ți - a trecut rândul, dealer-ul are o tură, după care, scorurile tale sunt comparate." +
                "\nCâștigă cine are cel mai mare scor." +
                "\n\nPariuri:" +
                "\nÎncepi cu 100$ și poți paria cât de mult vrei la fiecare mână." +
                "\nDacă câștigi o mână, primești pariul dublu, dacă pierzi nu primești nimic înapoi.În caz de egalitate, primești miza înapoi." +
                "\n\nCircumstanțe speciale:" +
                "\nBlackjack - Dacă primești 21 la primele 2 cărți, câștigi instantaneu dublul pariului, plus încă o jumătate din pariu." +
                "\nTruc cu 5 cărți – Dacă reușești să obții 5 cărți fără ca scorul tău să depășească 21, câștigi instantaneu și primești dublu pariul înapoi." +
                "\n\nAltele:" +
                "\nToate cărțile au valoarea feței lor(2 = 2, 3 = 3 etc) cu următoarele excepții:" +
                "\nJ, Q și K au o valoare de 10." +
                "\nAsul are o valoare atât de 1, cât și de 11(dacă treci peste 21 cu și as, ai o a doua șansă).";
            MessageBox.Show(message, title);
        }

        private void quitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
