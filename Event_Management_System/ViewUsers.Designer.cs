namespace Event_Management_System
{
    partial class ViewUsers
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
            this.loggedTXT = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.text = new System.Windows.Forms.Label();
            this.viewParticipantsBTN = new System.Windows.Forms.Button();
            this.eventsDGV = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.goBackBTN = new System.Windows.Forms.Button();
            this.viewOrganizersBTN = new System.Windows.Forms.Button();
            this.editOrganizersBTN = new System.Windows.Forms.Button();
            this.editParticipantsBTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.eventsDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // loggedTXT
            // 
            this.loggedTXT.AutoSize = true;
            this.loggedTXT.Font = new System.Drawing.Font("Verdana", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loggedTXT.Location = new System.Drawing.Point(686, 414);
            this.loggedTXT.Name = "loggedTXT";
            this.loggedTXT.Size = new System.Drawing.Size(102, 16);
            this.loggedTXT.TabIndex = 75;
            this.loggedTXT.Text = "Logged in as ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(686, 414);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 16);
            this.label10.TabIndex = 74;
            // 
            // text
            // 
            this.text.AutoSize = true;
            this.text.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text.Location = new System.Drawing.Point(686, 398);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(95, 16);
            this.text.TabIndex = 73;
            this.text.Text = "Logged in as ";
            // 
            // viewParticipantsBTN
            // 
            this.viewParticipantsBTN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.viewParticipantsBTN.BackColor = System.Drawing.Color.White;
            this.viewParticipantsBTN.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewParticipantsBTN.ForeColor = System.Drawing.Color.Black;
            this.viewParticipantsBTN.Location = new System.Drawing.Point(635, 98);
            this.viewParticipantsBTN.Name = "viewParticipantsBTN";
            this.viewParticipantsBTN.Size = new System.Drawing.Size(153, 118);
            this.viewParticipantsBTN.TabIndex = 93;
            this.viewParticipantsBTN.Text = "View Participants";
            this.viewParticipantsBTN.UseVisualStyleBackColor = false;
            this.viewParticipantsBTN.Click += new System.EventHandler(this.viewParticipantsBTN_Click);
            // 
            // eventsDGV
            // 
            this.eventsDGV.AllowDrop = true;
            this.eventsDGV.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.eventsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.eventsDGV.Location = new System.Drawing.Point(1, 98);
            this.eventsDGV.Name = "eventsDGV";
            this.eventsDGV.ReadOnly = true;
            this.eventsDGV.RowHeadersWidth = 51;
            this.eventsDGV.RowTemplate.Height = 24;
            this.eventsDGV.Size = new System.Drawing.Size(622, 247);
            this.eventsDGV.TabIndex = 91;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(291, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(223, 40);
            this.label3.TabIndex = 90;
            this.label3.Text = "View Users";
            // 
            // goBackBTN
            // 
            this.goBackBTN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.goBackBTN.BackColor = System.Drawing.Color.White;
            this.goBackBTN.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goBackBTN.ForeColor = System.Drawing.Color.Black;
            this.goBackBTN.Location = new System.Drawing.Point(167, 364);
            this.goBackBTN.Name = "goBackBTN";
            this.goBackBTN.Size = new System.Drawing.Size(125, 66);
            this.goBackBTN.TabIndex = 96;
            this.goBackBTN.Text = "Go Back";
            this.goBackBTN.UseVisualStyleBackColor = false;
            this.goBackBTN.Click += new System.EventHandler(this.goBackBTN_Click_2);
            // 
            // viewOrganizersBTN
            // 
            this.viewOrganizersBTN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.viewOrganizersBTN.BackColor = System.Drawing.Color.Red;
            this.viewOrganizersBTN.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewOrganizersBTN.ForeColor = System.Drawing.Color.White;
            this.viewOrganizersBTN.Location = new System.Drawing.Point(635, 222);
            this.viewOrganizersBTN.Name = "viewOrganizersBTN";
            this.viewOrganizersBTN.Size = new System.Drawing.Size(153, 123);
            this.viewOrganizersBTN.TabIndex = 98;
            this.viewOrganizersBTN.Text = "View Organizers";
            this.viewOrganizersBTN.UseVisualStyleBackColor = false;
            this.viewOrganizersBTN.Click += new System.EventHandler(this.viewOrganizersBTN_Click);
            // 
            // editOrganizersBTN
            // 
            this.editOrganizersBTN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.editOrganizersBTN.BackColor = System.Drawing.Color.White;
            this.editOrganizersBTN.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editOrganizersBTN.ForeColor = System.Drawing.Color.Black;
            this.editOrganizersBTN.Location = new System.Drawing.Point(445, 364);
            this.editOrganizersBTN.Name = "editOrganizersBTN";
            this.editOrganizersBTN.Size = new System.Drawing.Size(141, 66);
            this.editOrganizersBTN.TabIndex = 99;
            this.editOrganizersBTN.Text = "Edit Organizers";
            this.editOrganizersBTN.UseVisualStyleBackColor = false;
            this.editOrganizersBTN.Click += new System.EventHandler(this.editOrganizersBTN_Click);
            // 
            // editParticipantsBTN
            // 
            this.editParticipantsBTN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.editParticipantsBTN.BackColor = System.Drawing.Color.White;
            this.editParticipantsBTN.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editParticipantsBTN.ForeColor = System.Drawing.Color.Black;
            this.editParticipantsBTN.Location = new System.Drawing.Point(298, 364);
            this.editParticipantsBTN.Name = "editParticipantsBTN";
            this.editParticipantsBTN.Size = new System.Drawing.Size(141, 66);
            this.editParticipantsBTN.TabIndex = 100;
            this.editParticipantsBTN.Text = "Edit Participants";
            this.editParticipantsBTN.UseVisualStyleBackColor = false;
            this.editParticipantsBTN.Click += new System.EventHandler(this.editParticipantsBTN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(-3, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 20);
            this.label1.TabIndex = 101;
            this.label1.Text = "Organizer List";
            // 
            // ViewUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.editParticipantsBTN);
            this.Controls.Add(this.editOrganizersBTN);
            this.Controls.Add(this.viewOrganizersBTN);
            this.Controls.Add(this.goBackBTN);
            this.Controls.Add(this.viewParticipantsBTN);
            this.Controls.Add(this.eventsDGV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.loggedTXT);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.text);
            this.Name = "ViewUsers";
            this.Text = "ViewUsers";
            this.Load += new System.EventHandler(this.ViewUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eventsDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label loggedTXT;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label text;
        private System.Windows.Forms.Button viewParticipantsBTN;
        private System.Windows.Forms.DataGridView eventsDGV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button goBackBTN;
        private System.Windows.Forms.Button viewOrganizersBTN;
        private System.Windows.Forms.Button editOrganizersBTN;
        private System.Windows.Forms.Button editParticipantsBTN;
        private System.Windows.Forms.Label label1;
    }
}