using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final
{
    public class Toys : Item
    {
        public Toys(ConditionType condition, int price, string itemDescription, string firstName, string lastName, string creditCard, bool specificCondition, string itemName) : 
            base(condition, price, itemDescription, firstName, lastName, creditCard, itemName)
        {
            this.Type = ItemType.Toys;
            if (specificCondition == true)
            {
                this.SpecificCondition = Plastic();
            }
            else
            {
                this.SpecificCondition = NotPlastic();
            }
        }
        public Toys() : base()
        {

        }
        private string Plastic()
        {
            return "Is plastic";
        }
        private string NotPlastic()
        {
            return "Is not plastic";
        }
    }
}
