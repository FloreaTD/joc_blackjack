using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_Blackjack
{
    class Joc
    {
        private Deck deck;              
        private Jucator jucator;            
        private Jucator CPU;
        private int banca;               
        private int pariu;                
        private double multipluPariu;   
        private bool statusJoc;

        public Joc()
        {
            deck = new Deck();
            jucator = new Jucator();
            CPU = new Jucator();
            banca = 1000;
            pariu = 0;
            multipluPariu = 0;
            statusJoc = false;
        }

        public bool plasarePariu(int pariuNou)
        {
            if (pariuNou <= 0)
            {
                MessageBox.Show("Trebuie sa pariezi mai mult de 0 credite!");
                return false;
            }
            else if (pariuNou > banca)
            {
                MessageBox.Show("Nu trebuie sa pariezi mai mult decat ai in banca!");
                return false;
            }
            else
            {
                pariu = pariuNou;
                banca -= pariu;
                return true;
            }
        }


        public void deal()
        {
            jucator.adauga(deck.extrageCarte());
            jucator.adauga(deck.extrageCarte());
            CPU.adauga(deck.extrageCarte());
            CPU.adauga(deck.extrageCarte());
        }


        public void resetMana()
        {
            jucator = new Jucator();
            CPU = new Jucator();
            MainMenuForm.gameScreen.hitButton.Tag = "FazaPariu";
            MainMenuForm.gameScreen.afisareDisplay();
        }


        public void dealer()
        {
            System.Threading.Thread.Sleep(1000);
            MainMenuForm.gameScreen.carteCPU1.Image = CPU.getMana()[0].getImagineFront();
            MainMenuForm.gameScreen.cpuTotalLabel.Text = "Dealer Total\n" + CPU.get_totalJucator();
            MainMenuForm.gameScreen.carteCPU1.Update();
            MainMenuForm.gameScreen.cpuTotalLabel.Update();
            while (CPU.get_totalJucator() < 17)
            {
                CPU.adauga(deck.extrageCarte());
                if (CPU.get_totalJucator() > 21)
                {
                    for (int i = 0; i < CPU.get_totalCarti(); i++)
                    {
                        if (CPU.getMana()[i].getRank() == "A" && CPU.getMana()[i].getValoare() == 11)
                        {
                            CPU.getMana()[i].setValoare(1);
                            break;
                        }
                    }
                }
                System.Threading.Thread.Sleep(1000);
                MainMenuForm.gameScreen.afisareCarti("cpu");
                CPU.updateCarti();
                MainMenuForm.gameScreen.cpuTotalLabel.Text = "Total dealer:\n" + CPU.get_totalJucator();
                MainMenuForm.gameScreen.cpuTotalLabel.Update();

            }
            System.Threading.Thread.Sleep(1000);
            rezultatMana();
        }

        public void rezultatMana()
        {
            string mesaj = "";
            string titlu = "";
            if (jucator.get_totalCarti() == 2 && jucator.get_totalJucator() == 21) // jucatorul are blackjack
            {
                mesaj = "Aveti blackjack! Ai castigat!";
                multipluPariu = 2.5;
            }
            else if (jucator.get_totalCarti() == 5 && jucator.get_totalJucator() < 21) // jucatorul are 5 carti
            {
                mesaj = "Aveti 5 carti! Ai castigat!";
                multipluPariu = 2;
            }
            else if ((jucator.get_totalJucator() <= 21) && (jucator.get_totalJucator() > CPU.get_totalJucator()) && (CPU.get_totalJucator() <= 21)) // jucatorul are scor mai mare
            {
                mesaj = "Aveti scor mai bun decat dealerul! Ai castigat!";
                multipluPariu = 2;
            }
            else if ((jucator.get_totalJucator() <= 21) && (jucator.get_totalJucator() < CPU.get_totalJucator()) && (CPU.get_totalJucator() <= 21)) // dealerul are scor mai mare
            {
                mesaj = "Dealerul are scor mai bun decat dumneavoastra! Ai pierdut!";
                multipluPariu = 0;
            }
            else if ((jucator.get_totalJucator() <= 21) && (CPU.get_totalJucator() > 21)) // dealerul trece peste 21
            {
                mesaj = "Dealerul a trecut peste 21! Ai castigat!";
                multipluPariu = 2;
            }
            else if ((jucator.get_totalJucator() <= 21) && (jucator.get_totalJucator() == CPU.get_totalJucator())) // scor egal
            {
                mesaj = "Remiza!";
                multipluPariu = 1;

            }
            else if (jucator.get_totalJucator() > 21) // jucatorul trece peste 21
            {
                mesaj = "Ai trecut peste 21! Ai pierdut!";
                multipluPariu = 0;
            }
            banca += (int)(pariu * multipluPariu);
            MainMenuForm.gameScreen.hitButton.Tag = "FazaPariu";
            MessageBox.Show(mesaj, titlu);
            if (banca > 0)
            {
                resetMana();
            }
            else
            {
                sfarsitJoc();
            }

        }

        public void sfarsitJoc()
        {
            MessageBox.Show("Din pacate ai pierdut toate creditele! :(", "SFARSIT DE JOC!");
            Program.mainMenu.Show();
            statusJoc = false;
            deck.amestecareDeck();
            banca = 1000;
            resetMana();
            MainMenuForm.gameScreen.Hide();
            MainMenuForm.gameScreen.stayButton.Visible = false;

        }

        public void setDeck(Deck deck)
        {
            this.deck = deck;
        }

        public Deck getDeck()
        {
            return deck;
        }

        public void setJucator(Jucator user)
        {
            this.jucator = user;
        }

        public Jucator getJucator()
        {
            return jucator;
        }

        public void setCPU(Jucator CPU)
        {
            this.CPU = CPU;
        }

        public Jucator getCPU()
        {
            return CPU;
        }

        public void setBanca(int banca)
        {
            this.banca = banca;
        }

        public int getBanca()
        {
            return banca;
        }

        public void setPariu(int pariu)
        {
            this.pariu = pariu;
        }

        public int getPariu()
        {
            return pariu;
        }

        public void set_multipluPariu(double multipluPariu)
        {
            this.multipluPariu = multipluPariu;
        }

        public double get_multipluPariu()
        {
            return multipluPariu;
        }

        public void set_statusJoc(bool statusJoc)
        {
            this.statusJoc = statusJoc;
        }

        public bool get_statusJoc()
        {
            return statusJoc;
        }
    }
}
