namespace Data_entry_form
{
    partial class Main_Menu
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
            this.lblTitleMenu = new System.Windows.Forms.Label();
            this.btnSeasonTicketsList = new System.Windows.Forms.Button();
            this.btnEntryForm = new System.Windows.Forms.Button();
            this.btnHelpScreen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitleMenu
            // 
            this.lblTitleMenu.AutoSize = true;
            this.lblTitleMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleMenu.Location = new System.Drawing.Point(338, 9);
            this.lblTitleMenu.Name = "lblTitleMenu";
            this.lblTitleMenu.Size = new System.Drawing.Size(100, 37);
            this.lblTitleMenu.TabIndex = 0;
            this.lblTitleMenu.Text = "Menu";
            // 
            // btnSeasonTicketsList
            // 
            this.btnSeasonTicketsList.Location = new System.Drawing.Point(100, 177);
            this.btnSeasonTicketsList.Name = "btnSeasonTicketsList";
            this.btnSeasonTicketsList.Size = new System.Drawing.Size(130, 76);
            this.btnSeasonTicketsList.TabIndex = 1;
            this.btnSeasonTicketsList.Text = "List Of Season Tickets";
            this.btnSeasonTicketsList.UseVisualStyleBackColor = true;
            this.btnSeasonTicketsList.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEntryForm
            // 
            this.btnEntryForm.Location = new System.Drawing.Point(316, 177);
            this.btnEntryForm.Name = "btnEntryForm";
            this.btnEntryForm.Size = new System.Drawing.Size(156, 75);
            this.btnEntryForm.TabIndex = 2;
            this.btnEntryForm.Text = "Season ticket Entry Form";
            this.btnEntryForm.UseVisualStyleBackColor = true;
            this.btnEntryForm.Click += new System.EventHandler(this.btnEntryForm_Click);
            // 
            // btnHelpScreen
            // 
            this.btnHelpScreen.Location = new System.Drawing.Point(552, 177);
            this.btnHelpScreen.Name = "btnHelpScreen";
            this.btnHelpScreen.Size = new System.Drawing.Size(133, 75);
            this.btnHelpScreen.TabIndex = 3;
            this.btnHelpScreen.Text = "Help Screen";
            this.btnHelpScreen.UseVisualStyleBackColor = true;
            this.btnHelpScreen.Click += new System.EventHandler(this.btnHelpScreen_Click);
            // 
            // Main_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnHelpScreen);
            this.Controls.Add(this.btnEntryForm);
            this.Controls.Add(this.btnSeasonTicketsList);
            this.Controls.Add(this.lblTitleMenu);
            this.Name = "Main_Menu";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitleMenu;
        private System.Windows.Forms.Button btnSeasonTicketsList;
        private System.Windows.Forms.Button btnEntryForm;
        private System.Windows.Forms.Button btnHelpScreen;
    }
}