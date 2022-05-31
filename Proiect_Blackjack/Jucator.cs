using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_Blackjack
{
    class Jucator 
    {
        private Carti[] mana;
        private int totalJucator;
        private int totalCarti;

        public Jucator()
        {
            mana = new Carti[5];
            totalJucator = 0;
            totalCarti = 0;
        }

        //Adauga o carte la mana jucatorului
        public void adauga(Carti adauga)
        {
            if (totalCarti < 5)
            {
                mana[totalCarti] = adauga;
                totalCarti++;
            }
            updateCarti();
        }

        //Face update la mana jucatorului.
        public void updateCarti()
        {
            totalJucator = 0;
            for (int i = 0; i < totalCarti; i++)
            {
                totalJucator += mana[i].getValoare();
            }
        }

        public void setMana(Carti[] mana)
        {
            this.mana = mana;
        }

        public Carti[] getMana()
        {
            return mana;
        }

        public void set_totalJucator(int totalJucator)
        {
            this.totalJucator = totalJucator;
        }

        public int get_totalJucator()
        {
            return totalJucator;
        }

        public void set_totalCarti(int totalCarti)
        {
            this.totalCarti = totalCarti;
        }

        public int get_totalCarti()
        {
            return totalCarti;
        }
    }
}
