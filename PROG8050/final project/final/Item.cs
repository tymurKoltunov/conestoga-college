using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final
{
    public abstract class Item : IItem
    {
        private ItemType type;
        private ConditionType condition;
        private int price;
        private string itemDescription;
        private string firstName;
        private string lastName;
        private string creditCard;
        private string specificCondition;
        private string hiddenCC;
        private string itemName;

        public string ItemName { get => itemName; set => itemName = value; }
        public string ItemDescription { get => itemDescription; set => itemDescription = value; }
        public ItemType Type { get => type; set => type = value; }
        public ConditionType Condition { get => condition; set => condition = value; }
        public string SpecificCondition { get => specificCondition; set => specificCondition = value; }      
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName ; set => lastName = value; }
        public string CreditCard { get => creditCard; set => creditCard = value; }       
        public string HiddenCC { get => CardOut(); }
        public int Price { get => price; set => price = value; }
        public Item(ConditionType condition, int price, string itemDescription, string firstName, string lastName, string creditCard, string itemName)
        {
            
            this.condition = condition;
            this.price = price;
            this.itemDescription = itemDescription;
            this.firstName = firstName;
            this.lastName = lastName;
            this.creditCard = creditCard;
            this.itemName = itemName;
            
        }
        public Item()
        {

        }
        public string CardOut()
        {
            char[] c = this.CreditCard.ToCharArray();
            for (int i = 4; i < 12; i++)
            {
                c[i] = 'X';
            }
            string r = new string(c);
            return r;
        }
        
    }
}
