namespace ContactApp
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.contactsListBox = new System.Windows.Forms.ListBox();
            this.addContactButton = new System.Windows.Forms.Button();
            this.searchContactsByNameButton = new System.Windows.Forms.Button();
            this.removeContactButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // contactsListBox
            // 
            this.contactsListBox.FormattingEnabled = true;
            this.contactsListBox.Location = new System.Drawing.Point(12, 12);
            this.contactsListBox.Name = "contactsListBox";
            this.contactsListBox.DisplayMember = "Name";
            this.contactsListBox.Size = new System.Drawing.Size(260, 186);
            this.contactsListBox.TabIndex = 0;
            // 
            // addContactButton
            // 
            this.addContactButton.Location = new System.Drawing.Point(12, 204);
            this.addContactButton.Name = "addContactButton";
            this.addContactButton.Size = new System.Drawing.Size(75, 23);
            this.addContactButton.TabIndex = 1;
            this.addContactButton.Text = "Add";
            this.addContactButton.UseVisualStyleBackColor = true;
            this.addContactButton.Click += new System.EventHandler(this.addContactButton_Click);
            //
            // searchContactsByNameButton
            //
            this.searchContactsByNameButton.Location = new System.Drawing.Point(105, 204);
            this.searchContactsByNameButton.Name = "searchContactsByNameButton";
            this.searchContactsByNameButton.Size = new System.Drawing.Size(75, 23);
            this.searchContactsByNameButton.TabIndex = 2;
            this.searchContactsByNameButton.Text = "Search";
            this.searchContactsByNameButton.UseVisualStyleBackColor = true;
            this.searchContactsByNameButton.Click += new System.EventHandler(this.searchContactsByNameButton_Click);
            // 
            // removeContactButton
            // 
            this.removeContactButton.Location = new System.Drawing.Point(197, 204);
            this.removeContactButton.Name = "removeContactButton";
            this.removeContactButton.Size = new System.Drawing.Size(75, 23);
            this.removeContactButton.TabIndex = 3;
            this.removeContactButton.Text = "Remove";
            this.removeContactButton.UseVisualStyleBackColor = true;
            this.removeContactButton.Click += new System.EventHandler(this.removeContactButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 239);
            this.Controls.Add(this.removeContactButton);
            this.Controls.Add(this.addContactButton);
            this.Controls.Add(this.searchContactsByNameButton);
            this.Controls.Add(this.contactsListBox);
            this.Name = "MainForm";
            this.Text = "Contact Manager";
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.ListBox contactsListBox;
        private System.Windows.Forms.Button addContactButton;
        private System.Windows.Forms.Button searchContactsByNameButton;
        private System.Windows.Forms.Button removeContactButton;
    }
}

