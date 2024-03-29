//Author: Levi Liljedahl
//Date: 03/29/2024
//Purpose: This was initially my final project for my .NET Application development course at
//Chippewa Valley Technical College. But the project was initially written in Visual Basic,
//here I am converting the project to C#. Collection_Inventory is a .NET app written in C# that
//allows multiple users to inventory their various collections of different objects ' and add
//various items into that collection. Use a database to store this information.

using System.Drawing.Text;

namespace CollectionInventory
{
    public partial class CollectionInventoryForm : Form
    {
        public CollectionInventoryForm()
        {
            InitializeComponent();
        }



        private void CollectionInventoryForm_Load(object sender, EventArgs e)
        {

        }

        private void addCollectionButton_Click(object sender, EventArgs e)
        {

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
    }
}
