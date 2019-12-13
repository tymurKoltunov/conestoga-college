using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final
{
    public class Furniture : Item
    {
        public Furniture(ConditionType condition, int price, string itemDescription, string firstName, string lastName, string creditCard, bool specificCondition, string itemName) : 
            base(condition, price, itemDescription, firstName, lastName, creditCard, itemName)
        {
            this.Type = ItemType.Furniture;
            if(specificCondition == true)
            {
                this.SpecificCondition = Wooden();
            }
            else
            {
                this.SpecificCondition = NotWooden();
            }            
        }
        public Furniture() : base()
        {

        }
        private string Wooden()
        {
            return "Is wooden";
        }
        private string NotWooden()
        {
            return "Is not wooden";
        }
    }

}
