namespace CollectionInventory
{
    partial class CollectionInventoryForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            collectionGroupBox = new GroupBox();
            deleteCollectionButton = new Button();
            clearCollectionButton = new Button();
            addCollectionButton = new Button();
            collectionsGroupBox = new GroupBox();
            cDescriptionTextBox = new TextBox();
            cNameTextBox = new TextBox();
            cDescriptionLabel = new Label();
            cNameLabel = new Label();
            OwnersGroupBox = new GroupBox();
            lastNameTextBox = new TextBox();
            firstNameTextBox = new TextBox();
            lastNameLabel = new Label();
            firstNameLabel = new Label();
            collectionsListBox = new ListBox();
            itemGroupBox = new GroupBox();
            deleteItemButton = new Button();
            clearItemButton = new Button();
            addItemButton = new Button();
            profitTextBox = new TextBox();
            currentValueTextBox = new TextBox();
            originalPriceTextBox = new TextBox();
            itemDescriptionTextBox = new TextBox();
            itemNameTextBox = new TextBox();
            profitLabel = new Label();
            currentValueLabel = new Label();
            originalPriceLabel = new Label();
            itemDescriptionLabel = new Label();
            itemNameLabel = new Label();
            itemsListBox = new ListBox();
            databaseTextBox = new GroupBox();
            deleteFromDatabaseTextBox = new Button();
            saveToDatabaseButton = new Button();
            collectionGroupBox.SuspendLayout();
            collectionsGroupBox.SuspendLayout();
            OwnersGroupBox.SuspendLayout();
            itemGroupBox.SuspendLayout();
            databaseTextBox.SuspendLayout();
            SuspendLayout();
            // 
            // collectionGroupBox
            // 
            collectionGroupBox.Controls.Add(deleteCollectionButton);
            collectionGroupBox.Controls.Add(clearCollectionButton);
            collectionGroupBox.Controls.Add(addCollectionButton);
            collectionGroupBox.Controls.Add(collectionsGroupBox);
            collectionGroupBox.Controls.Add(OwnersGroupBox);
            collectionGroupBox.Location = new Point(13, 13);
            collectionGroupBox.Margin = new Padding(4);
            collectionGroupBox.Name = "collectionGroupBox";
            collectionGroupBox.Padding = new Padding(4);
            collectionGroupBox.Size = new Size(385, 296);
            collectionGroupBox.TabIndex = 0;
            collectionGroupBox.TabStop = false;
            collectionGroupBox.Text = "Add information about your collection";
            // 
            // deleteCollectionButton
            // 
            deleteCollectionButton.BackColor = Color.MediumTurquoise;
            deleteCollectionButton.Location = new Point(258, 248);
            deleteCollectionButton.Margin = new Padding(4);
            deleteCollectionButton.Name = "deleteCollectionButton";
            deleteCollectionButton.Size = new Size(118, 41);
            deleteCollectionButton.TabIndex = 4;
            deleteCollectionButton.Text = "Delete";
            deleteCollectionButton.UseVisualStyleBackColor = false;
            deleteCollectionButton.Click += deleteCollectionButton_Click;
            // 
            // clearCollectionButton
            // 
            clearCollectionButton.BackColor = Color.MediumTurquoise;
            clearCollectionButton.Location = new Point(132, 248);
            clearCollectionButton.Margin = new Padding(4);
            clearCollectionButton.Name = "clearCollectionButton";
            clearCollectionButton.Size = new Size(118, 41);
            clearCollectionButton.TabIndex = 3;
            clearCollectionButton.Text = "Clear Boxes";
            clearCollectionButton.UseVisualStyleBackColor = false;
            clearCollectionButton.Click += clearCollectionButton_Click;
            // 
            // addCollectionButton
            // 
            addCollectionButton.BackColor = Color.MediumTurquoise;
            addCollectionButton.Location = new Point(6, 248);
            addCollectionButton.Margin = new Padding(4);
            addCollectionButton.Name = "addCollectionButton";
            addCollectionButton.Size = new Size(118, 41);
            addCollectionButton.TabIndex = 2;
            addCollectionButton.Text = "Add Collection";
            addCollectionButton.UseVisualStyleBackColor = false;
            addCollectionButton.Click += addCollectionButton_Click;
            // 
            // collectionsGroupBox
            // 
            collectionsGroupBox.Controls.Add(cDescriptionTextBox);
            collectionsGroupBox.Controls.Add(cNameTextBox);
            collectionsGroupBox.Controls.Add(cDescriptionLabel);
            collectionsGroupBox.Controls.Add(cNameLabel);
            collectionsGroupBox.Location = new Point(6, 135);
            collectionsGroupBox.Margin = new Padding(4);
            collectionsGroupBox.Name = "collectionsGroupBox";
            collectionsGroupBox.Padding = new Padding(4);
            collectionsGroupBox.Size = new Size(371, 105);
            collectionsGroupBox.TabIndex = 1;
            collectionsGroupBox.TabStop = false;
            collectionsGroupBox.Text = "Collection Information";
            // 
            // cDescriptionTextBox
            // 
            cDescriptionTextBox.Location = new Point(115, 65);
            cDescriptionTextBox.Name = "cDescriptionTextBox";
            cDescriptionTextBox.Size = new Size(249, 28);
            cDescriptionTextBox.TabIndex = 3;
            // 
            // cNameTextBox
            // 
            cNameTextBox.Location = new Point(115, 26);
            cNameTextBox.Name = "cNameTextBox";
            cNameTextBox.Size = new Size(249, 28);
            cNameTextBox.TabIndex = 2;
            // 
            // cDescriptionLabel
            // 
            cDescriptionLabel.AutoSize = true;
            cDescriptionLabel.Location = new Point(21, 68);
            cDescriptionLabel.Name = "cDescriptionLabel";
            cDescriptionLabel.Size = new Size(88, 20);
            cDescriptionLabel.TabIndex = 1;
            cDescriptionLabel.Text = "Description:";
            // 
            // cNameLabel
            // 
            cNameLabel.AutoSize = true;
            cNameLabel.Location = new Point(55, 29);
            cNameLabel.Name = "cNameLabel";
            cNameLabel.Size = new Size(54, 20);
            cNameLabel.TabIndex = 0;
            cNameLabel.Text = "Name:";
            // 
            // OwnersGroupBox
            // 
            OwnersGroupBox.Controls.Add(lastNameTextBox);
            OwnersGroupBox.Controls.Add(firstNameTextBox);
            OwnersGroupBox.Controls.Add(lastNameLabel);
            OwnersGroupBox.Controls.Add(firstNameLabel);
            OwnersGroupBox.Location = new Point(6, 24);
            OwnersGroupBox.Margin = new Padding(4);
            OwnersGroupBox.Name = "OwnersGroupBox";
            OwnersGroupBox.Padding = new Padding(4);
            OwnersGroupBox.Size = new Size(371, 105);
            OwnersGroupBox.TabIndex = 0;
            OwnersGroupBox.TabStop = false;
            OwnersGroupBox.Text = "Owner's Information";
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Location = new Point(116, 59);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(248, 28);
            lastNameTextBox.TabIndex = 3;
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.Location = new Point(116, 22);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(248, 28);
            firstNameTextBox.TabIndex = 2;
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new Point(21, 62);
            lastNameLabel.Margin = new Padding(4, 0, 4, 0);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(88, 20);
            lastNameLabel.TabIndex = 1;
            lastNameLabel.Text = "Last Name:";
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new Point(16, 25);
            firstNameLabel.Margin = new Padding(4, 0, 4, 0);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(93, 20);
            firstNameLabel.TabIndex = 0;
            firstNameLabel.Text = "First Name:";
            // 
            // collectionsListBox
            // 
            collectionsListBox.FormattingEnabled = true;
            collectionsListBox.ItemHeight = 20;
            collectionsListBox.Location = new Point(404, 25);
            collectionsListBox.Name = "collectionsListBox";
            collectionsListBox.Size = new Size(195, 284);
            collectionsListBox.TabIndex = 1;
            collectionsListBox.SelectedIndexChanged += collectionsListBox_SelectedIndexChanged;
            // 
            // itemGroupBox
            // 
            itemGroupBox.Controls.Add(deleteItemButton);
            itemGroupBox.Controls.Add(clearItemButton);
            itemGroupBox.Controls.Add(addItemButton);
            itemGroupBox.Controls.Add(profitTextBox);
            itemGroupBox.Controls.Add(currentValueTextBox);
            itemGroupBox.Controls.Add(originalPriceTextBox);
            itemGroupBox.Controls.Add(itemDescriptionTextBox);
            itemGroupBox.Controls.Add(itemNameTextBox);
            itemGroupBox.Controls.Add(profitLabel);
            itemGroupBox.Controls.Add(currentValueLabel);
            itemGroupBox.Controls.Add(originalPriceLabel);
            itemGroupBox.Controls.Add(itemDescriptionLabel);
            itemGroupBox.Controls.Add(itemNameLabel);
            itemGroupBox.Location = new Point(13, 316);
            itemGroupBox.Name = "itemGroupBox";
            itemGroupBox.Size = new Size(385, 294);
            itemGroupBox.TabIndex = 2;
            itemGroupBox.TabStop = false;
            itemGroupBox.Text = "Add an item to your collection";
            // 
            // deleteItemButton
            // 
            deleteItemButton.BackColor = Color.MediumTurquoise;
            deleteItemButton.Location = new Point(254, 247);
            deleteItemButton.Name = "deleteItemButton";
            deleteItemButton.Size = new Size(118, 41);
            deleteItemButton.TabIndex = 12;
            deleteItemButton.Text = "Delete Item";
            deleteItemButton.UseVisualStyleBackColor = false;
            deleteItemButton.Click += deleteItemButton_Click;
            // 
            // clearItemButton
            // 
            clearItemButton.BackColor = Color.MediumTurquoise;
            clearItemButton.Location = new Point(130, 247);
            clearItemButton.Name = "clearItemButton";
            clearItemButton.Size = new Size(118, 41);
            clearItemButton.TabIndex = 11;
            clearItemButton.Text = "Clear Boxes";
            clearItemButton.UseVisualStyleBackColor = false;
            clearItemButton.Click += clearItemButton_Click;
            // 
            // addItemButton
            // 
            addItemButton.BackColor = Color.MediumTurquoise;
            addItemButton.Location = new Point(6, 247);
            addItemButton.Name = "addItemButton";
            addItemButton.Size = new Size(118, 41);
            addItemButton.TabIndex = 10;
            addItemButton.Text = "Add Item";
            addItemButton.UseVisualStyleBackColor = false;
            addItemButton.Click += addItemButton_Click;
            // 
            // profitTextBox
            // 
            profitTextBox.BackColor = Color.MediumTurquoise;
            profitTextBox.Enabled = false;
            profitTextBox.ForeColor = SystemColors.InactiveCaption;
            profitTextBox.Location = new Point(121, 206);
            profitTextBox.Name = "profitTextBox";
            profitTextBox.Size = new Size(249, 28);
            profitTextBox.TabIndex = 9;
            // 
            // currentValueTextBox
            // 
            currentValueTextBox.Location = new Point(121, 164);
            currentValueTextBox.Name = "currentValueTextBox";
            currentValueTextBox.Size = new Size(249, 28);
            currentValueTextBox.TabIndex = 8;
            // 
            // originalPriceTextBox
            // 
            originalPriceTextBox.Location = new Point(121, 120);
            originalPriceTextBox.Name = "originalPriceTextBox";
            originalPriceTextBox.Size = new Size(249, 28);
            originalPriceTextBox.TabIndex = 7;
            // 
            // itemDescriptionTextBox
            // 
            itemDescriptionTextBox.Location = new Point(121, 76);
            itemDescriptionTextBox.Name = "itemDescriptionTextBox";
            itemDescriptionTextBox.Size = new Size(249, 28);
            itemDescriptionTextBox.TabIndex = 6;
            // 
            // itemNameTextBox
            // 
            itemNameTextBox.Location = new Point(121, 32);
            itemNameTextBox.Name = "itemNameTextBox";
            itemNameTextBox.Size = new Size(249, 28);
            itemNameTextBox.TabIndex = 5;
            // 
            // profitLabel
            // 
            profitLabel.AutoSize = true;
            profitLabel.Location = new Point(61, 209);
            profitLabel.Name = "profitLabel";
            profitLabel.Size = new Size(54, 20);
            profitLabel.TabIndex = 4;
            profitLabel.Text = "Profit:";
            // 
            // currentValueLabel
            // 
            currentValueLabel.AutoSize = true;
            currentValueLabel.Location = new Point(10, 167);
            currentValueLabel.Name = "currentValueLabel";
            currentValueLabel.Size = new Size(105, 20);
            currentValueLabel.TabIndex = 3;
            currentValueLabel.Text = "Current Value:";
            // 
            // originalPriceLabel
            // 
            originalPriceLabel.AutoSize = true;
            originalPriceLabel.Location = new Point(10, 123);
            originalPriceLabel.Name = "originalPriceLabel";
            originalPriceLabel.Size = new Size(105, 20);
            originalPriceLabel.TabIndex = 2;
            originalPriceLabel.Text = "Original Price:";
            // 
            // itemDescriptionLabel
            // 
            itemDescriptionLabel.AutoSize = true;
            itemDescriptionLabel.Location = new Point(27, 79);
            itemDescriptionLabel.Name = "itemDescriptionLabel";
            itemDescriptionLabel.Size = new Size(88, 20);
            itemDescriptionLabel.TabIndex = 1;
            itemDescriptionLabel.Text = "Description:";
            // 
            // itemNameLabel
            // 
            itemNameLabel.AutoSize = true;
            itemNameLabel.Location = new Point(25, 35);
            itemNameLabel.Name = "itemNameLabel";
            itemNameLabel.Size = new Size(90, 20);
            itemNameLabel.TabIndex = 0;
            itemNameLabel.Text = "Item Name:";
            // 
            // itemsListBox
            // 
            itemsListBox.FormattingEnabled = true;
            itemsListBox.ItemHeight = 20;
            itemsListBox.Location = new Point(404, 326);
            itemsListBox.Name = "itemsListBox";
            itemsListBox.Size = new Size(195, 284);
            itemsListBox.TabIndex = 3;
            itemsListBox.SelectedIndexChanged += itemsListBox_SelectedIndexChanged;
            // 
            // databaseTextBox
            // 
            databaseTextBox.Controls.Add(deleteFromDatabaseTextBox);
            databaseTextBox.Controls.Add(saveToDatabaseButton);
            databaseTextBox.Location = new Point(12, 616);
            databaseTextBox.Name = "databaseTextBox";
            databaseTextBox.Size = new Size(587, 77);
            databaseTextBox.TabIndex = 4;
            databaseTextBox.TabStop = false;
            databaseTextBox.Text = "Select an Item and its Collection. Then Save it to the Database";
            // 
            // deleteFromDatabaseTextBox
            // 
            deleteFromDatabaseTextBox.BackColor = Color.MediumTurquoise;
            deleteFromDatabaseTextBox.Location = new Point(327, 26);
            deleteFromDatabaseTextBox.Name = "deleteFromDatabaseTextBox";
            deleteFromDatabaseTextBox.Size = new Size(184, 41);
            deleteFromDatabaseTextBox.TabIndex = 1;
            deleteFromDatabaseTextBox.Text = "Delete From Database";
            deleteFromDatabaseTextBox.UseVisualStyleBackColor = false;
            deleteFromDatabaseTextBox.Click += deleteFromDatabaseTextBox_Click;
            // 
            // saveToDatabaseButton
            // 
            saveToDatabaseButton.BackColor = Color.MediumTurquoise;
            saveToDatabaseButton.Location = new Point(72, 26);
            saveToDatabaseButton.Name = "saveToDatabaseButton";
            saveToDatabaseButton.Size = new Size(184, 41);
            saveToDatabaseButton.TabIndex = 0;
            saveToDatabaseButton.Text = "Save to Database";
            saveToDatabaseButton.UseVisualStyleBackColor = false;
            saveToDatabaseButton.Click += saveToDatabaseButton_Click;
            // 
            // CollectionInventoryForm
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumTurquoise;
            ClientSize = new Size(611, 700);
            Controls.Add(databaseTextBox);
            Controls.Add(itemsListBox);
            Controls.Add(itemGroupBox);
            Controls.Add(collectionsListBox);
            Controls.Add(collectionGroupBox);
            Font = new Font("Harlow Solid Italic", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "CollectionInventoryForm";
            Text = "Collection Inventory - Version 2.0";
            Load += CollectionInventoryForm_Load;
            collectionGroupBox.ResumeLayout(false);
            collectionsGroupBox.ResumeLayout(false);
            collectionsGroupBox.PerformLayout();
            OwnersGroupBox.ResumeLayout(false);
            OwnersGroupBox.PerformLayout();
            itemGroupBox.ResumeLayout(false);
            itemGroupBox.PerformLayout();
            databaseTextBox.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox collectionGroupBox;
        private Button deleteCollectionButton;
        private Button clearCollectionButton;
        private Button addCollectionButton;
        private GroupBox collectionsGroupBox;
        private GroupBox OwnersGroupBox;
        private Label lastNameLabel;
        private Label firstNameLabel;
        private TextBox cNameTextBox;
        private Label cDescriptionLabel;
        private Label cNameLabel;
        private TextBox lastNameTextBox;
        private TextBox firstNameTextBox;
        private TextBox cDescriptionTextBox;
        private ListBox collectionsListBox;
        private GroupBox itemGroupBox;
        private Label profitLabel;
        private Label currentValueLabel;
        private Label originalPriceLabel;
        private Label itemDescriptionLabel;
        private Label itemNameLabel;
        private ListBox itemsListBox;
        private Button deleteItemButton;
        private Button clearItemButton;
        private Button addItemButton;
        private TextBox profitTextBox;
        private TextBox currentValueTextBox;
        private TextBox originalPriceTextBox;
        private TextBox itemDescriptionTextBox;
        private TextBox itemNameTextBox;
        private GroupBox databaseTextBox;
        private Button deleteFromDatabaseTextBox;
        private Button saveToDatabaseButton;
    }
}
