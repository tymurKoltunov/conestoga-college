using System;
using System.Collections.Generic;
using System.Text;

namespace assignment3
{
    public delegate void BDel();
    interface IBuilding : IComparable<IBuilding>
    {
        int Size { get; set; }
        int Bulbs { get; set; }
        int Outlets { get; set; }
        string CustomerCC { get; set; }
        BuildingType T { get; set; }
        BDel Del { get; set; }
        abstract void WireBuilding();
        abstract void Info();
        
    }
}
