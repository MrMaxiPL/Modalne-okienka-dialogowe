namespace Modalne_okna_dialogowe
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.addPersonButton = new System.Windows.Forms.Button();
            this.personListLabel = new System.Windows.Forms.Label();
            this.personListListBox = new System.Windows.Forms.ListBox();
            this.editButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addPersonButton
            // 
            this.addPersonButton.Location = new System.Drawing.Point(428, 30);
            this.addPersonButton.Name = "addPersonButton";
            this.addPersonButton.Size = new System.Drawing.Size(100, 39);
            this.addPersonButton.TabIndex = 1;
            this.addPersonButton.Text = "Dodaj";
            this.addPersonButton.UseVisualStyleBackColor = true;
            this.addPersonButton.Click += new System.EventHandler(this.addPersonButton_Click);
            // 
            // personListLabel
            // 
            this.personListLabel.AutoSize = true;
            this.personListLabel.Location = new System.Drawing.Point(13, 13);
            this.personListLabel.Name = "personListLabel";
            this.personListLabel.Size = new System.Drawing.Size(55, 13);
            this.personListLabel.TabIndex = 3;
            this.personListLabel.Text = "Lista osób";
            // 
            // personListListBox
            // 
            this.personListListBox.FormattingEnabled = true;
            this.personListListBox.Location = new System.Drawing.Point(16, 30);
            this.personListListBox.Name = "personListListBox";
            this.personListListBox.Size = new System.Drawing.Size(406, 407);
            this.personListListBox.TabIndex = 4;
            // 
            // editButton
            // 
            this.editButton.Enabled = false;
            this.editButton.Location = new System.Drawing.Point(429, 76);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(100, 39);
            this.editButton.TabIndex = 5;
            this.editButton.Text = "Edytuj";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.personListListBox);
            this.Controls.Add(this.personListLabel);
            this.Controls.Add(this.addPersonButton);
            this.Name = "Form1";
            this.Text = "Modalne okna dialogowe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button addPersonButton;
        private System.Windows.Forms.Label personListLabel;
        private System.Windows.Forms.ListBox personListListBox;
        private System.Windows.Forms.Button editButton;
    }
}

