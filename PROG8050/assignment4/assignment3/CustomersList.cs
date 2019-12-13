using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace assignment3
{
    public class CustomersList : IEnumerable<IBuilding>
    {
        private List<IBuilding> list = null;
        
        public CustomersList()
        {            
            list = new List<IBuilding>();
        }
        public IEnumerator<IBuilding> GetEnumerator()
        {
            return ((IEnumerable<IBuilding>)list).GetEnumerator();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable<IBuilding>)list).GetEnumerator();
        }
        public void Add(IBuilding b)
        {
            list.Add(b);
        }
        public void Remove(IBuilding b)
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
