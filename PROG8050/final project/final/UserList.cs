using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace final
{
    [XmlRoot("UserList")]
    [XmlInclude(typeof(Toys))]
    [XmlInclude(typeof(Appliances))]
    [XmlInclude(typeof(Furniture))]
    public class UserList : IEnumerable<Item>
    {
        private List<Item> list = null;
        [XmlArray("Items")]
        [XmlArrayItem("Item", typeof(Item))]
        public List<Item> List { get => list; set => list = value; }

        public UserList()
        {
            list = new List<Item>();
        }       
        public void Add(Item i)
        {
            list.Add(i);
        }
        public void Remove(Item i)
        {
            list.Remove(i);
        }
        public int Count()
        {
            return list.Count;
        }

        public IEnumerator<Item> GetEnumerator()
        {
            return ((IEnumerable<Item>)list).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable<Item>)list).GetEnumerator();
        }

        public Item this[int i]
        {
            get { return list[i]; }
        }
        public void AddRange(UserList u)
        {
            this.list.AddRange(u);
        }
    
    }
}
