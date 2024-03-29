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
        private Items selectedItem;

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

        }

        private void collectionsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void addItemButton_Click(object sender, EventArgs e)
        {

        }

        private void clearItemButton_Click(object sender, EventArgs e)
        {
            //Clear button for clearing Item texboxes for next entry

            ClearItemBoxes();
        }

        private void deleteItemButton_Click(object sender, EventArgs e)
        {

        }

        private void itemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

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
            //if (selectedItem.Profit < 0)
            //{
            //    profitTextBox.BackColor = Color.Red;
            //} else if (selectedItem.Profit == 0)
            //{
            //    profitTextBox.BackColor = Color.Silver;
            //} else if (selectedItem.Profit > 0)
            //{
            //    profitTextBox.BackColor = Color.LightGreen;
            //} else
            //{
            //    profitTextBox.BackColor = Color.MediumTurquoise;
            //}
        }

        private void RefreshDisplay()
        {
            //Refresh function used for displaying current data, can be called
            DisplayCollections();
            //DisplayItems();
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
    }
}
