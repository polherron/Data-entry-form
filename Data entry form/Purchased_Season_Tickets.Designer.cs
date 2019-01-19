namespace Data_entry_form
{
    partial class Purchased_Season_Tickets
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
            this.dgv_Tickets = new System.Windows.Forms.DataGridView();
            this.btn_CSP = new System.Windows.Forms.Button();
            this.btn_PST = new System.Windows.Forms.Button();
            this.lblTitleListTickets = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Tickets)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Tickets
            // 
            this.dgv_Tickets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Tickets.Location = new System.Drawing.Point(463, 225);
            this.dgv_Tickets.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgv_Tickets.Name = "dgv_Tickets";
            this.dgv_Tickets.Size = new System.Drawing.Size(788, 379);
            this.dgv_Tickets.TabIndex = 0;
            // 
            // btn_CSP
            // 
            this.btn_CSP.Location = new System.Drawing.Point(463, 721);
            this.btn_CSP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_CSP.Name = "btn_CSP";
            this.btn_CSP.Size = new System.Drawing.Size(187, 46);
            this.btn_CSP.TabIndex = 1;
            this.btn_CSP.Text = "Corporate Season Tickets";
            this.btn_CSP.UseVisualStyleBackColor = true;
            this.btn_CSP.Click += new System.EventHandler(this.btn_CSP_Click);
            // 
            // btn_PST
            // 
            this.btn_PST.Location = new System.Drawing.Point(817, 721);
            this.btn_PST.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_PST.Name = "btn_PST";
            this.btn_PST.Size = new System.Drawing.Size(176, 46);
            this.btn_PST.TabIndex = 2;
            this.btn_PST.Text = "Private Season Tickets";
            this.btn_PST.UseVisualStyleBackColor = true;
            // 
            // lblTitleListTickets
            // 
            this.lblTitleListTickets.AutoSize = true;
            this.lblTitleListTickets.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleListTickets.Location = new System.Drawing.Point(533, 23);
            this.lblTitleListTickets.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitleListTickets.Name = "lblTitleListTickets";
            this.lblTitleListTickets.Size = new System.Drawing.Size(583, 42);
            this.lblTitleListTickets.TabIndex = 3;
            this.lblTitleListTickets.Text = "List of purchased season tickets";
            // 
            // Purchased_Season_Tickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1755, 874);
            this.Controls.Add(this.lblTitleListTickets);
            this.Controls.Add(this.btn_PST);
            this.Controls.Add(this.btn_CSP);
            this.Controls.Add(this.dgv_Tickets);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Purchased_Season_Tickets";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Purchased_Season_Tickets_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Tickets)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Tickets;
        private System.Windows.Forms.Button btn_CSP;
        private System.Windows.Forms.Button btn_PST;
        private System.Windows.Forms.Label lblTitleListTickets;
    }
}

