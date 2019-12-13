using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final
{
    public class Appliances : Item
    {
        public Appliances(ConditionType condition, int price, string itemDescription, string firstName, string lastName, string creditCard, bool specificCondition, string itemName) : 
            base(condition, price, itemDescription, firstName, lastName, creditCard, itemName)
        {
            this.Type = ItemType.Appliances;
            if (specificCondition == true)
            {
                this.SpecificCondition = Refurbished();
            }
            else
            {
                this.SpecificCondition = NotRefurbished();
            }
        }
        public Appliances() : base()
        {

        }
        private string Refurbished()
        {
            return "Is Refurbished";
        }
        private string NotRefurbished()
        {
            return "Is not Refurbished";
        }
    }
}
