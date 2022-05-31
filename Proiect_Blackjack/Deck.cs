using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_Blackjack
{
    class Deck
    {
        private Carti[] deck;
        private int topCarte;
        

        public Deck()
        {
            string[] rank = { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };
            string[] tip = { "H", "D", "S", "C" };
            int pozitie = 0;

            deck = new Carti[312];
            for (int numarDeck = 0; numarDeck < 6; numarDeck++) // 6 deckuri
            {
                for (int numarTip = 0; numarTip < 4; numarTip++) // 4 tipuri de carti
                {
                    for (int numarRank = 0; numarRank < 13; numarRank++) // 13 rankuri
                    {
                        string numeImagine = "Proiect_Blackjack.Carti." + rank[numarRank] + tip[numarTip] + ".jpg";
                        Assembly myAssembly = Assembly.GetExecutingAssembly();
                        Stream myStream = myAssembly.GetManifestResourceStream(numeImagine);                  
                        Console.WriteLine(numeImagine + " --> " + "Deck: " + numarDeck + " --> " + "Tip: " + tip[numarTip] + " --> " + "Rank: " + rank[numarRank]);
                        Console.WriteLine("Loading...");
                        Bitmap bmp = new Bitmap(myStream);

                        // determina valoarea cartilor
                        int valoare;
                        if (numarRank == 0)
                        {
                            valoare = 11;
                        }
                        else if (numarRank > 0 && numarRank < 9)
                        {
                            valoare = numarRank + 1;
                        }
                        else
                        {
                            valoare = 10;
                        }
                        Carti Carte = new Carti(numarTip, rank[numarRank], valoare, bmp, Properties.Resources.Cardback);
                        deck[pozitie] = Carte;
                        pozitie++;
                    }
                }
            }
            topCarte = 0;
        }

        public void amestecareDeck()
        {
            Random aleatoriu = new Random();
            for (int i = topCarte; i < (deck.Count() - topCarte); i++)
            {
                //selecteaza o carte random
                int j = aleatoriu.Next(deck.Count() - topCarte);
                //amestecare carti
                Carti temp = deck[i];
                deck[i] = deck[j];
                deck[j] = temp;
            }
            topCarte = 0;
        }

        public Carti extrageCarte()
        {
            Carti extras = deck[topCarte];
            if (extras.getRank() == "A")
            {
                extras.setValoare(11);
            }
            topCarte++;
            if (deck.Length - topCarte < 26)
            {
                amestecareDeck();
            }
            return extras;
        }

        public void setDeck(Carti[] deck)
        {
            this.deck = deck;
        }

        public Carti[] getDeck()
        {
            return deck;
        }

        public void set_topCarte(int topCarte)
        {
            this.topCarte = topCarte;
        }

        public int get_topCarte()
        {
            return topCarte;
        }
    }
}
