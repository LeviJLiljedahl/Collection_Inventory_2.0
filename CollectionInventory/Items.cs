//Author: Levi Liljedahl
//Date: 03/29/2024
//Purpose: Manage the items that belong to collections, multiple Items can belong to one collection

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionInventory
{
    internal class Items
    {

        //Define Class or Module Level Variables
        private string mItemName;
        private string mItemDescription;
        private decimal mItemOriginalPrice;
        private decimal mItemCurrentValue;
        private decimal mItemProfit;

        //Getters and Setters
        public string ItemName
        { get { return mItemName; } set { mItemName = value; } }

        public string ItemDescription
        { get { return mItemDescription; } set { mItemDescription = value; } }

        public decimal ItemOriginalPrice
        { get { return mItemOriginalPrice; } set { mItemOriginalPrice = value; } }

        public decimal ItemCurrentValue
        { get { return mItemCurrentValue; } set { mItemCurrentValue = value; } }

        public decimal ItemProfit
        { get { return mItemProfit; } set { mItemProfit = value; } }


        //Default Constructor

        public Items()
        {
            mItemName = string.Empty;
            mItemDescription = string.Empty;
            mItemOriginalPrice = 0;
            mItemCurrentValue = 0;
            mItemProfit = 0;
        }

        //Overload Constructor
        public Items(string ItemName)
        {
            mItemName = ItemName;
            mItemDescription = string.Empty;
            mItemOriginalPrice = 0;
            mItemCurrentValue = 0;
            mItemProfit = 0;
        }

        public override string ToString()
        {
            // This will provide my formatted data that will be displayed in the listbox

            if (mItemProfit < 0)
            {
                return mItemName + " (Loss of $" + mItemProfit.ToString() + ")";
            }
            else
            {
                return mItemName + " (Profit of $" + mItemProfit.ToString() + ")";
            }
        }
    }
}
