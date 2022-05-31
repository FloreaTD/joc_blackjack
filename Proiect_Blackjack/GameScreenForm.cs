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
    public partial class GameScreenForm : Form
    {
        Joc jocNou = new Joc();
        PictureBox[][] carti;

        public GameScreenForm()
        {
            InitializeComponent();
            jocNou.getDeck().amestecareDeck();    
            this.ControlBox = false;
            carti = new PictureBox[2][]
            {
                new PictureBox[5]{carteJucator1, carteJucator2, carteJucator3, carteJucator4, carteJucator5},
                new PictureBox[5]{carteCPU1, carteCPU2, carteCPU3, carteCPU4, carteCPU5}
            };
            hitButton.Tag = "FazaPariu";
            afisareDisplay();
        }

        private void dealBtn_Click(object sender, EventArgs e)
        {
            if ((string)hitButton.Tag == "FazaPariu")
            {
                try
                {
                    if (jocNou.plasarePariu(Convert.ToInt32(introducerePariu.Text)))
                    {
                        if (jocNou.get_statusJoc() == false)
                        {
                            jocNou.set_statusJoc(true);
                            stayButton.Visible = true;
                        }
                        hitButton.Tag = "FazaJoc";
                        hitButton.Text = "Hit";
                        afisareDisplay();
                        jocNou.deal();
                        afisareCarti("user");
                        jucatorTotalLabel.BackColor = Color.Black;
                        jucatorTotalLabel.Text = "Total jucator:\n" + jocNou.getJucator().get_totalJucator();
                        cpuTotalLabel.BackColor = Color.Black;
                        cpuTotalLabel.Text = "Total dealer:\n" + jocNou.getCPU().getMana()[1].getValoare();
                    }
                    else
                    {
                        introducerePariu.Text = "";
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Suma introdusa este invalida!", "");
                    introducerePariu.Text = "";
                }
            }
            else
            {
                jocNou.getJucator().adauga(jocNou.getDeck().extrageCarte());
                if (jocNou.getJucator().get_totalJucator() > 21)
                {
                    for (int i = 0; i < jocNou.getJucator().get_totalCarti(); i++)
                    {
                        if (jocNou.getJucator().getMana()[i].getRank() == "A" && jocNou.getJucator().getMana()[i].getValoare() == 11)
                        {
                            jocNou.getJucator().getMana()[i].setValoare(1);
                            break;
                        }
                    }
                }
                jocNou.getJucator().updateCarti();
                afisareCarti("user");
                jucatorTotalLabel.Text = "Total jucator:\n" + jocNou.getJucator().get_totalJucator();

                if (jocNou.getJucator().get_totalCarti() == 5 || jocNou.getJucator().get_totalJucator() > 21)
                {
                    jocNou.rezultatMana();
                }
                else if (jocNou.getJucator().get_totalJucator() == 21)
                {
                    jocNou.dealer();
                }
            }

        }

        private void stayBtn_Click(object sender, EventArgs e)
        {
            if ((string)hitButton.Tag == "FazaPariu")
            {
                jocNou.sfarsitJoc();
            }
            else
            {
                MessageBox.Show("Urmeaza tura dealerului!", "");
                jocNou.dealer();
            }

        }

        public void afisareDisplay()
        {
            if ((string)hitButton.Tag == "FazaPariu")
            {
                hitButton.Text = "Pariaza";
                stayButton.Text = "Iesi din meci";
                valoarePariu.Visible = false;
                cpuTotalLabel.Visible = false;
                jucatorTotalLabel.Visible = false;
                titluPariu.Visible = true;
                introducerePariu.Visible = true;
                introducerePariu.Text = "";
            }
            else
            {
                hitButton.Text = "Hit";
                stayButton.Text = "Stay";
                valoarePariu.ForeColor = Color.White;
                valoarePariu.BackColor = Color.Black;
                valoarePariu.Text = "Pariu: " + jocNou.getPariu() + " (credite)";
                valoarePariu.Visible = true;
                cpuTotalLabel.Visible = true;
                jucatorTotalLabel.Visible = true;
                titluPariu.Visible = false;
                introducerePariu.Visible = false;
            }
            valoareBanca.ForeColor = Color.White;
            valoareBanca.BackColor = Color.Black;
            valoareBanca.Text = "Banca: " + jocNou.getBanca() + " (credite)";
            foreach (PictureBox[] i in carti)
            {
                foreach (PictureBox j in i)
                {
                    j.Visible = false;
                }

            }
        }

        public void afisareCarti(string player)
        {
            for (int i = 0; i < jocNou.getJucator().get_totalCarti(); i++)
            {
                carti[0][i].Visible = true;
                carti[0][i].Image = jocNou.getJucator().getMana()[i].getImagineFront();
                carti[0][i].Update();
            }

            for (int i = 0; i < jocNou.getCPU().get_totalCarti(); i++)
            {
                carti[1][i].Visible = true;
                if (i == 0 && player == "user")
                {
                    carti[1][i].Image = jocNou.getCPU().getMana()[i].getImagineDos();
                    carti[1][i].Update();
                }
                else
                {
                    carti[1][i].Image = jocNou.getCPU().getMana()[i].getImagineFront();
                    carti[1][i].Update();
                }
            }
        }

        private void stopBtn_Click(object sender, EventArgs e)
        {
            jocNou.sfarsitJoc();
        }
    }
}

