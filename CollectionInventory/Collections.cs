//Author: Levi Liljedahl
//Date: 03/29/2024
//Purpose: Manage the collections that belong to owners and are made of items

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionInventory
{
    internal class Collections
    {
        private string mFirstName;
        private string mLastName;

        private string mCollectionName;
        private string mCollectionDescription;

        private List<Items> itemsList = new List<Items>();

        // This function returns a copy of the items list.
        // A copy is returned specifically to prevent this function from being used to modify the original list
        // this prevents the necessary processing code contained in AddItems() and RemoveItems() from being 
        // bypassed accidentally. 
        public List<Items> getItems()
        {
            List<Items> listCopy = new List<Items>(itemsList);
            return listCopy;
        }

        // Use this function in order to add items to a collection.
        public void AddItems(Items item)
        {
            itemsList.Add(item);
        }

        //Use this function to remove items from a collection
        public void RemoveItems(Items items) 
        { 
            if (itemsList.Contains(items))
            {
                itemsList.Remove(items);
            }
            
        }

        public string FirstName 
            { get { return mFirstName; } set {  mFirstName = value; } }

        public string LastName 
            {  get { return mLastName; } set {  mLastName = value; } }

        public string CollectionName 
            { get { return mCollectionName; } set { mCollectionName = value; } }

        public string CollectionDescription 
            {  get { return mCollectionDescription; } set { mCollectionDescription = value; } }

        public override string ToString()
        {
            return mFirstName + " " + mLastName + "'s " + mCollectionName;
        }
    }
}
