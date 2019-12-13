using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace assignment3
{
    public abstract class Building : IBuilding
    {
        private int size;
        private int bulbs;
        private int outlets;
        private string customerCC;
        private BDel del = null;
        private BuildingType t;
        string txtInfo = string.Empty;
        string wired = string.Empty;
        string utilities = string.Empty;

        public string Utilities { get => utilities; set => utilities = value; }
        public string Wired { get => wired; set => wired = value; }
        public string TxtInfo { get => txtInfo; set => txtInfo = value; }
        public int Size { get => size; set => size = value; }
        public int Bulbs { get => bulbs; set => bulbs = value; }
        public int Outlets { get => outlets; set => outlets = value; }
        public BDel Del { get => del; set => del = value; }
        public string CustomerCC { get => customerCC; set => customerCC = value; }
        public BuildingType T { get => t; set => t = value; }

        public Building(int size, int bulbs, int outlets, string customerCC)
        {
            this.Size = size;
            this.Bulbs = bulbs;
            this.Outlets = outlets;
            this.CustomerCC = customerCC;
            Del += Info;
            Del += WireBuilding;            
        }
        public int CompareTo(IBuilding other)
        {
            return Size.CompareTo(other.Size);
        }

        public void WireBuilding()
        {
            //Console.WriteLine("Building wired");
            Wired = "Building wired |";
        }
        public void Info()
        {
           // Console.WriteLine("Customer with cardnumber {0} has {1} with the size of {2} square feet, needs placement of {3} bulbs, and {4} outlets", CardOut(), this.T, this.Size, this.Bulbs, this.Outlets);
            TxtInfo = string.Format("Customer with cardnumber {0} has {1} with the size of {2} square feet, needs placement of {3} bulbs, and {4} outlets |", CardOut(), this.T, this.Size, this.Bulbs, this.Outlets);
        }
        public override string ToString()
        {
            string text = string.Empty;
            this.Del();
            text += TxtInfo + Utilities + Wired;
            return text;
        }
        public string CardOut()
        {
            char[] c = this.CustomerCC.ToCharArray();
            for (int i = 4; i < 12; i++)
            {
                c[i] = 'X';
            }
            string r = new string(c);
            return r;
        }
    }
}
