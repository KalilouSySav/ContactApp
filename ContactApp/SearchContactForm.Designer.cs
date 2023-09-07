using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactApp
{
    internal partial class SearchContactForm
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
        private void InitializeComponents()
        {
            this.Text = "Recherche de contact";
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            nameTextBox = new TextBox()
            {
                Location = new Point(20, 20),
                Size = new Size(175, 25)
            };

            searchButton = new Button()
            {
                Text = "Rechercher",
                Location = new Point(nameTextBox.Right + 10, 20),
                Size = new Size(75, 25)
            };

            resultsListBox = new ListBox()
            {
                Location = new Point(20, nameTextBox.Bottom + 20),
                Size = new Size(250, 75),
                HorizontalScrollbar = true,
                //DisplayMember = "ToString"
            };

            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 153);
            this.Controls.Add(nameTextBox);
            this.Controls.Add(searchButton);
            this.Controls.Add(resultsListBox);
            this.AcceptButton = this.searchButton;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SearchForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Search Contact";
            this.ResumeLayout(false);
            this.PerformLayout();

            searchButton.Click += SearchButton_Click;
        }
        private TextBox nameTextBox;
        private Button searchButton;
        private ListBox resultsListBox;
    }
}
