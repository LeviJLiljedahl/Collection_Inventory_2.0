//Author: Levi Liljedahl
//Date: 03/29/2024
//Purpose: This was initially my final project for my .NET Application development course at
//Chippewa Valley Technical College. But the project was initially written in Visual Basic,
//here I am converting the project to C#. Collection_Inventory is a .NET app written in C# that
//allows multiple users to inventory their various collections of different objects ' and add
//various items into that collection. Use a database to store this information.

using System.ComponentModel;
using System.Drawing.Text;

namespace CollectionInventory
{
    public partial class CollectionInventoryForm : Form
    {
        //class scoped variables
        private Collections selectedCollection;
        private Items selectedCollectionItem;

        private BindingList<Collections> collectionsList = new BindingList<Collections>();
        private BindingList<Items> itemsList = new BindingList<Items>();

        public CollectionInventoryForm()
        {
            InitializeComponent();
        }

        private void CollectionInventoryForm_Load(object sender, EventArgs e)
        {
            collectionsListBox.DataSource = collectionsList;

            itemsListBox.DataSource = itemsList;

            //DatabaseReload()

            firstNameTextBox.Focus();

        }

        private void addCollectionButton_Click(object sender, EventArgs e)
        {
            // Declare Variables
            Collections newCollection = new Collections();

            //Nested If statement used to validate the data that is entered by user, if not give error message
            if (firstNameTextBox.Text != string.Empty)
            {
                if (lastNameTextBox.Text != string.Empty)
                {
                    if (cNameTextBox.Text != string.Empty)
                    {
                        if (cDescriptionTextBox.Text != string.Empty)
                        {

                            // Good code goes here if all data is validated
                            // Set user entered data to objects
                            newCollection.FirstName = firstNameTextBox.Text;
                            newCollection.LastName = lastNameTextBox.Text;

                            newCollection.CollectionName = cNameTextBox.Text;
                            newCollection.CollectionDescription = cDescriptionTextBox.Text;

                            //Set selected object and add data to list
                            selectedCollection = newCollection;
                            collectionsList.Add(newCollection);
                            collectionsListBox.SelectedItem = selectedCollection;

                            //update GUI
                            //refreshDisplay()

                            //Reset textboxes for next entry
                            ClearCollectionBoxes();
                            ClearItemBoxes();

                            //Error Messages clear and refocus to textbox for user efficiency
                        } 
                        else
                        {
                            MessageBox.Show("Please enter a valid Collection Description.");
                            cDescriptionTextBox.Clear();
                            cDescriptionTextBox.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter a valid Collection Name.");
                        cNameTextBox.Clear();
                        cNameTextBox.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a valid Last Name.");
                    lastNameTextBox.Clear();
                    lastNameTextBox.Focus();
                }
            } 
            else
            {
                MessageBox.Show("Please enter a valid First Name.");
                firstNameTextBox.Clear();
                firstNameTextBox.Focus();
            }
        }

        private void clearCollectionButton_Click(object sender, EventArgs e)
        {
            //clear button for clearing textboxes for next entry
            ClearCollectionBoxes();
        }

        private void deleteCollectionButton_Click(object sender, EventArgs e)
        {
            if(collectionsListBox.SelectedItem != null)
            {
                collectionsList.Remove((Collections) collectionsListBox.SelectedItem);
                selectedCollection = (Collections) collectionsListBox.SelectedItem;

                RefreshDisplay();
                ClearCollectionBoxes();
                ClearItemBoxes();
            } 
            else
            {
                MessageBox.Show("You must select a Collection to remove");
            }
        }

        private void collectionsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (collectionsListBox.SelectedItem != null)
            {
                selectedCollection = (Collections)(collectionsListBox.SelectedItem);

                itemsList.Clear();

                foreach (Items items in selectedCollection.getItems())
                {
                    itemsList.Add(items);
                    selectedCollectionItem = items;
                    itemsListBox.SelectedItem = items;

                }

                RefreshDisplay();
                ClearItemBoxes();
            }
        }

        private void addItemButton_Click(object sender, EventArgs e)
        {
            Items newItem = new Items();

            decimal inputPrice = 0;
            decimal inputValue = 0;

            bool isValidPrice;
            bool isValidValue;

            // Validate inputs here
            isValidPrice = Decimal.TryParse(originalPriceTextBox.Text, out inputPrice);
            isValidValue = Decimal.TryParse(currentValueTextBox.Text,out inputValue);

            if (selectedCollection != null)
            {
                if (itemNameTextBox.Text != string.Empty)
                {
                    if (itemDescriptionTextBox.Text != string.Empty)
                    {
                        if (isValidPrice)
                        {
                            if (isValidValue)
                            {

                                // Good code goes here
                                
                                //set user entered data to objects
                                newItem.ItemName = itemNameTextBox.Text;
                                newItem.ItemDescription = itemDescriptionTextBox.Text;
                                newItem.ItemOriginalPrice = inputPrice;
                                newItem.ItemCurrentValue = inputValue;
                                newItem.ItemProfit = (inputValue - inputPrice);

                                //set selected object and send data to listbox
                                selectedCollection.AddItems(newItem);
                                selectedCollectionItem = newItem;
                                itemsListBox.SelectedItem = selectedCollectionItem;

                                //Update GUI
                                RefreshDisplay();

                                //Reset for next entry
                                ClearCollectionBoxes();
                                ClearItemBoxes();

                                //Error messages clear and refocus for user
                            }
                            else
                            {
                                MessageBox.Show("Please enter a valid numeric Current Value.");
                                currentValueTextBox.Clear();
                                currentValueTextBox.Focus();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please enter a valid numeric Original Price.");
                            originalPriceTextBox.Clear();
                            originalPriceTextBox.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter a valid Item Description");
                        itemDescriptionTextBox.Clear();
                        itemDescriptionTextBox.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a valid Item Name");
                    itemNameTextBox.Clear();
                    itemNameTextBox.Focus();
                }
            }
            else
            {
                MessageBox.Show("You must select a Collection that the item belongs to first.");
            }
        }

        private void clearItemButton_Click(object sender, EventArgs e)
        {
            //Clear button for clearing Item texboxes for next entry

            ClearItemBoxes();
        }

        private void deleteItemButton_Click(object sender, EventArgs e)
        {
            if(selectedCollection != null)
            {
                if (itemsListBox.SelectedItem != null)
                {
                    selectedCollection.RemoveItems(selectedCollectionItem);

                    RefreshDisplay();
                    ClearCollectionBoxes();
                    ClearItemBoxes();

                }
                else
                {
                    MessageBox.Show("You must select an Item to remove");
                }
            }
            else
            {
                MessageBox.Show("Please select a collection");
            }
        }

        private void itemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (itemsListBox.SelectedItem != null)
            {
                selectedCollectionItem = (Items)(itemsListBox.SelectedItem);

                itemNameTextBox.Text = selectedCollectionItem.ItemName;
                itemDescriptionTextBox.Text = selectedCollectionItem.ItemDescription;
                originalPriceTextBox.Text = "$" + selectedCollectionItem.ItemOriginalPrice.ToString();
                currentValueTextBox.Text = "$" + selectedCollectionItem.ItemCurrentValue.ToString();
                profitTextBox.Text = "$" + selectedCollectionItem.ItemProfit.ToString();

                ColoredProfit();

            }
        }

        private void saveToDatabaseButton_Click(object sender, EventArgs e)
        {

        }

        private void deleteFromDatabaseTextBox_Click(object sender, EventArgs e)
        {

        }

        private void ClearCollectionBoxes()
        {
            // private void that can be called to clear collection textboxes and focus on first input
            firstNameTextBox.Text = string.Empty;
            lastNameTextBox.Text = string.Empty;
            cNameTextBox.Text = string.Empty;
            cDescriptionTextBox.Text = string.Empty;
            firstNameTextBox.Focus();
        }

        private void ClearItemBoxes()
        {
            // private void that can be called to clear item textboxes and focus on first input
            itemNameTextBox.Text = string.Empty;
            itemDescriptionTextBox.Text = string.Empty;
            originalPriceTextBox.Text = string.Empty;
            currentValueTextBox.Text = string.Empty;
            profitTextBox.Text = string.Empty;
            profitTextBox.BackColor = Color.MediumTurquoise;
            itemNameTextBox.Focus();
        }

        private void ColoredProfit()
        {
            //Changes the background color of the profit textbox to green, red, or silver color based on positive,
            // negative, or no profit
            if (selectedCollectionItem.ItemProfit < 0)
            {
                profitTextBox.BackColor = Color.Red;
            }
            else if (selectedCollectionItem.ItemProfit == 0)
            {
                profitTextBox.BackColor = Color.Silver;
            }
            else if (selectedCollectionItem.ItemProfit > 0)
            {
                profitTextBox.BackColor = Color.LightGreen;
            }
            else
            {
                profitTextBox.BackColor = Color.MediumTurquoise;
            }
        }

        private void RefreshDisplay()
        {
            //Refresh function used for displaying current data, can be called
            DisplayCollections();
            DisplayItems();
        }

        private void DisplayCollections()
        {
            //Private function used for displaying collection information, can be called in nested if easier
            if (selectedCollection != null)
            {
                firstNameTextBox.Text = selectedCollection.FirstName;
                lastNameTextBox.Text = selectedCollection.LastName;

                collectionsListBox.SelectedItem = selectedCollection;
                cNameTextBox.Text = selectedCollection.CollectionName;
                cDescriptionTextBox.Text = selectedCollection.CollectionDescription;
            }
        }

        private void DisplayItems()
        {
            //Displays every item associated with a collection, can associate multiple items with a collection
            itemsList.Clear();

            foreach (Items item in selectedCollection.getItems())
            {
                itemsList.Add(item);
                selectedCollectionItem = item;
            }

            if (selectedCollectionItem != null)
            {
                itemsListBox.SelectedItem = selectedCollectionItem;
                itemNameTextBox.Text = selectedCollectionItem.ItemName;
                itemDescriptionTextBox.Text = selectedCollectionItem.ItemDescription;
                originalPriceTextBox.Text = "$" + selectedCollectionItem.ItemOriginalPrice.ToString();
                currentValueTextBox.Text = "$" + selectedCollectionItem.ItemCurrentValue.ToString();
                profitTextBox.Text = "$" + selectedCollectionItem.ItemProfit.ToString();
            }
        }
    }
}
