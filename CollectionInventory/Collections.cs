//Author: Levi Liljedahl
//Date: 03/29/2024
//Purpose: Manage the collections that belong to owners and are made of items


/////////// ****************** NEEDs WORK *********************************
///


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
        private List<string> mItemsList;
        //private List<string> mItemsList = new List<Items>();

        public string FirstName 
            { get { return mFirstName; } set {  mFirstName = value; } }

        public string LastName 
            {  get { return mLastName; } set {  mLastName = value; } }

        public string CollectionName 
            { get { return mCollectionName; } set { mCollectionName = value; } }

        public string CollectionDescription 
            {  get { return mCollectionDescription; } set { mCollectionDescription = value; } }

        public List<string> ItemsList 
            { get { return mItemsList; } set { mItemsList = value; } }

        ////Adds items to the collection
        //public void AddItem(string item)
        //{
        //    Items.Add(item);
        //}

        // Default Constructor
        public Collections()
        {
            mFirstName = string.Empty;
            mLastName = string.Empty;
            mCollectionName = string.Empty;
            mCollectionDescription = string.Empty;
            mItemsList = new List<string>();
            //for (int count = 0; count  < mItemsList.Count; count++)
            //{
            //    mItemsList.Add(string.Empty);
            //}
        }

        //Overload Constructor
        public Collections(string FirstName)
        {
            mFirstName = FirstName;
            mLastName = string.Empty;
            mCollectionName = string.Empty;
            mCollectionDescription = string.Empty;
            mItemsList = new List<string>();
            //for (int count = 0; count  < mItemsList.Count; count++)
            //{
            //    mItemsList.Add(string.Empty);
            //}
        }

        public string DisplayCollection()
        {
            return mFirstName + " " + mLastName + "'s " + mCollectionName;
        }
    }
}
