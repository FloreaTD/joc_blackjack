using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Proiect_Blackjack
{
    class Carti 
    {

        private int tip;           //tipul carti(inima, frunza)
        private string rank;
        private int valoare;          //valoarea cartilor
        private Image ImagineFront;    //Imaginea fata carte
        private Image ImagineDos;    //Imagine spate carte


        public Carti(int tip, string rank, int val, Image ImagineFata, Image ImagineSpate)
        {
            this.tip = tip;
            this.rank = rank;
            this.valoare = val;
            this.ImagineFront = ImagineFata;
            this.ImagineDos = ImagineSpate;
        }

        public void setTip(int tip)
        {
            this.tip = tip;
        }

        public int getTip()
        {
            return this.tip;
        }

        public void setRank(string rank)
        {
            this.rank = rank;
        }

        public string getRank()
        {
            return this.rank;
        }

        public void setValoare(int val)
        {
            this.valoare = val;
        }

        public int getValoare()
        {
            return this.valoare;
        }

        // set si get pentru imaginile folosite de carti

        public void setImagineFront(Image ImagineFata)
        {
            this.ImagineFront = ImagineFata;
        }

        public Image getImagineFront()
        {
            return this.ImagineFront;
        }

        public void setImagineDos(Image ImagineSpate)
        {
            this.ImagineDos = ImagineSpate;
        }

        public Image getImagineDos()
        {
            return this.ImagineDos;
        }
    }
}
