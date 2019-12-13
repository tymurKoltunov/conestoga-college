using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final
{
    public enum ConditionType
    {
        New = 0, Used, Damaged
    }
    public enum ItemType
    {
        Furniture = 1, Appliances, Toys
    }
    public interface IItem
    {
        ItemType Type { get; set; }
        ConditionType Condition { get; set; }
        int Price { get; set; }
        string ItemName { get; set; }
        string ItemDescription { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string CreditCard { get; set; }
        string SpecificCondition { get; set; }
        string HiddenCC { get;}
    }
}
