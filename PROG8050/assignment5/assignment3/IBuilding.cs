using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace assignment3
{
    public delegate void BDel();
    public interface IBuilding : IComparable<IBuilding>
    {
        int Size { get; set; }
        string HiddenCC { get; }
        int Bulbs { get; set; }
        int Outlets { get; set; }
        string CustomerCC { get; set; }
        string TxtInfo { get; set; }
        string Wired { get; set; }
        string Utilities { get; set; }
        BuildingType T { get; set; }
        [XmlIgnore]
        BDel Del { get; set; }
        abstract void WireBuilding();
        abstract void Info();
        
    }
}
