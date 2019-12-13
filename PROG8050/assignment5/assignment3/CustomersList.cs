using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using System.Threading.Tasks;
using System.Linq;

namespace assignment3
{
    [XmlRoot("CustomersList")]
    [XmlInclude(typeof(Barn))]
    [XmlInclude(typeof(Garage))]
    [XmlInclude(typeof(House))]
    public class CustomersList : IEnumerable<Building>
    {
        private List<Building> list = null;
        [XmlArray("Buildings")]
        [XmlArrayItem("Building", typeof(Building))]
        public List<Building> List { get => list; set => list = value; }

        public CustomersList()
        {            
            list = new List<Building>();
        }
        
        public IEnumerator<Building> GetEnumerator()
        {
            return ((IEnumerable<Building>)list).GetEnumerator();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable<Building>)list).GetEnumerator();
        }
        public void Add(Building b)
        {
            list.Add(b);
        }
        public void Remove(Building b)
        {
            list.Remove(b);
        }
        public int Count()
        {
            return list.Count;
        }
        public void Sort()
        {
            list.Sort();
        }
        public IBuilding this[int i]
        {
            get { return list[i]; }
        }
    }
}
