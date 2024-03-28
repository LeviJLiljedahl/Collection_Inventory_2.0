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
            OwnersGroupBox = new GroupBox();
            groupBox1 = new GroupBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label1 = new Label();
            label2 = new Label();
            collectionGroupBox.SuspendLayout();
            OwnersGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // collectionGroupBox
            // 
            collectionGroupBox.Controls.Add(button3);
            collectionGroupBox.Controls.Add(button2);
            collectionGroupBox.Controls.Add(button1);
            collectionGroupBox.Controls.Add(groupBox1);
            collectionGroupBox.Controls.Add(OwnersGroupBox);
            collectionGroupBox.Location = new Point(13, 13);
            collectionGroupBox.Margin = new Padding(4, 4, 4, 4);
            collectionGroupBox.Name = "collectionGroupBox";
            collectionGroupBox.Padding = new Padding(4, 4, 4, 4);
            collectionGroupBox.Size = new Size(389, 439);
            collectionGroupBox.TabIndex = 0;
            collectionGroupBox.TabStop = false;
            collectionGroupBox.Text = "Add information about your collection";
            // 
            // OwnersGroupBox
            // 
            OwnersGroupBox.Controls.Add(label2);
            OwnersGroupBox.Controls.Add(label1);
            OwnersGroupBox.Location = new Point(9, 43);
            OwnersGroupBox.Margin = new Padding(4, 4, 4, 4);
            OwnersGroupBox.Name = "OwnersGroupBox";
            OwnersGroupBox.Padding = new Padding(4, 4, 4, 4);
            OwnersGroupBox.Size = new Size(370, 133);
            OwnersGroupBox.TabIndex = 0;
            OwnersGroupBox.TabStop = false;
            OwnersGroupBox.Text = "Owner's Information";
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(9, 184);
            groupBox1.Margin = new Padding(4, 4, 4, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 4, 4, 4);
            groupBox1.Size = new Size(370, 176);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Collection Information";
            // 
            // button1
            // 
            button1.BackColor = Color.MediumTurquoise;
            button1.Location = new Point(8, 380);
            button1.Margin = new Padding(4, 4, 4, 4);
            button1.Name = "button1";
            button1.Size = new Size(119, 41);
            button1.TabIndex = 2;
            button1.Text = "Add Collection";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.MediumTurquoise;
            button2.Location = new Point(135, 380);
            button2.Margin = new Padding(4, 4, 4, 4);
            button2.Name = "button2";
            button2.Size = new Size(118, 41);
            button2.TabIndex = 3;
            button2.Text = "Clear Boxes";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.MediumTurquoise;
            button3.Location = new Point(261, 380);
            button3.Margin = new Padding(4, 4, 4, 4);
            button3.Name = "button3";
            button3.Size = new Size(118, 41);
            button3.TabIndex = 4;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 44);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(93, 20);
            label1.TabIndex = 0;
            label1.Text = "First Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 86);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(88, 20);
            label2.TabIndex = 1;
            label2.Text = "Last Name:";
            // 
            // CollectionInventoryForm
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumTurquoise;
            ClientSize = new Size(1143, 600);
            Controls.Add(collectionGroupBox);
            Font = new Font("Harlow Solid Italic", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 4, 4, 4);
            Name = "CollectionInventoryForm";
            Text = "Collection Inventory - Version 2.0";
            Load += CollectionInventoryForm_Load;
            collectionGroupBox.ResumeLayout(false);
            OwnersGroupBox.ResumeLayout(false);
            OwnersGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox collectionGroupBox;
        private Button button3;
        private Button button2;
        private Button button1;
        private GroupBox groupBox1;
        private GroupBox OwnersGroupBox;
        private Label label2;
        private Label label1;
    }
}
