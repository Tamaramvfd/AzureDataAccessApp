namespace AzureDataAccessWindowsFormsUI
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
            this.gamesList = new System.Windows.Forms.ListBox();
            this.getGamesButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gamesList
            // 
            this.gamesList.FormattingEnabled = true;
            this.gamesList.ItemHeight = 16;
            this.gamesList.Location = new System.Drawing.Point(22, 25);
            this.gamesList.Name = "gamesList";
            this.gamesList.Size = new System.Drawing.Size(312, 308);
            this.gamesList.TabIndex = 0;
            // 
            // getGamesButton
            // 
            this.getGamesButton.Location = new System.Drawing.Point(93, 351);
            this.getGamesButton.Name = "getGamesButton";
            this.getGamesButton.Size = new System.Drawing.Size(143, 69);
            this.getGamesButton.TabIndex = 1;
            this.getGamesButton.Text = "Get Games";
            this.getGamesButton.UseVisualStyleBackColor = true;
            this.getGamesButton.Click += new System.EventHandler(this.getGamesButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.getGamesButton);
            this.Controls.Add(this.gamesList);
            this.Name = "Form1";
            this.Text = "Azure Data Acces";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox gamesList;
        private System.Windows.Forms.Button getGamesButton;
    }
}

