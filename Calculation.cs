using System.Collections.Generic;
namespace Shopping
{
    public class Calculation
    {
        public static decimal CalculateSubTotal(List<Item> calculationItems)
        {
            decimal total = 0;
           foreach(Item item in calculationItems)
           {
               total += item.ItemPrice;
           }     

            return total;



        }

        public static decimal CalculateWithVat(List<Item> calculationItems)
        {
            decimal subTotal = CalculateSubTotal(calculationItems);
            return subTotal * ((100 + Tax.VatAmount) / 100);
        }


    }
}