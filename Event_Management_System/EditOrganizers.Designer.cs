namespace Event_Management_System
{
    partial class EditOrganizers
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
            this.label3 = new System.Windows.Forms.Label();
            this.refreshBTN = new System.Windows.Forms.LinkLabel();
            this.goBackBTN = new System.Windows.Forms.Button();
            this.deleteOrganizerBTN = new System.Windows.Forms.Button();
            this.loggedTXT = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.text = new System.Windows.Forms.Label();
            this.editOrganizerBTN = new System.Windows.Forms.Button();
            this.organizersDGV = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.organizersDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(269, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(302, 40);
            this.label3.TabIndex = 92;
            this.label3.Text = "Edit Organizers";
            // 
            // refreshBTN
            // 
            this.refreshBTN.AutoSize = true;
            this.refreshBTN.Location = new System.Drawing.Point(13, 415);
            this.refreshBTN.Name = "refreshBTN";
            this.refreshBTN.Size = new System.Drawing.Size(54, 16);
            this.refreshBTN.TabIndex = 91;
            this.refreshBTN.TabStop = true;
            this.refreshBTN.Text = "Refresh";
            this.refreshBTN.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.refreshBTN_LinkClicked);
            // 
            // goBackBTN
            // 
            this.goBackBTN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.goBackBTN.BackColor = System.Drawing.Color.White;
            this.goBackBTN.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goBackBTN.ForeColor = System.Drawing.Color.Black;
            this.goBackBTN.Location = new System.Drawing.Point(192, 345);
            this.goBackBTN.Name = "goBackBTN";
            this.goBackBTN.Size = new System.Drawing.Size(142, 70);
            this.goBackBTN.TabIndex = 90;
            this.goBackBTN.Text = "Go Back";
            this.goBackBTN.UseVisualStyleBackColor = false;
            this.goBackBTN.Click += new System.EventHandler(this.goBackBTN_Click);
            // 
            // deleteOrganizerBTN
            // 
            this.deleteOrganizerBTN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.deleteOrganizerBTN.BackColor = System.Drawing.Color.Red;
            this.deleteOrganizerBTN.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold);
            this.deleteOrganizerBTN.ForeColor = System.Drawing.Color.White;
            this.deleteOrganizerBTN.Location = new System.Drawing.Point(488, 347);
            this.deleteOrganizerBTN.Name = "deleteOrganizerBTN";
            this.deleteOrganizerBTN.Size = new System.Drawing.Size(142, 66);
            this.deleteOrganizerBTN.TabIndex = 89;
            this.deleteOrganizerBTN.Text = "Delete Organizer";
            this.deleteOrganizerBTN.UseVisualStyleBackColor = false;
            this.deleteOrganizerBTN.Click += new System.EventHandler(this.deleteOrganizerBTN_Click);
            // 
            // loggedTXT
            // 
            this.loggedTXT.AutoSize = true;
            this.loggedTXT.Font = new System.Drawing.Font("Verdana", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loggedTXT.Location = new System.Drawing.Point(686, 415);
            this.loggedTXT.Name = "loggedTXT";
            this.loggedTXT.Size = new System.Drawing.Size(102, 16);
            this.loggedTXT.TabIndex = 88;
            this.loggedTXT.Text = "Logged in as ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(686, 415);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 16);
            this.label10.TabIndex = 87;
            // 
            // text
            // 
            this.text.AutoSize = true;
            this.text.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text.Location = new System.Drawing.Point(686, 399);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(95, 16);
            this.text.TabIndex = 86;
            this.text.Text = "Logged in as ";
            // 
            // editOrganizerBTN
            // 
            this.editOrganizerBTN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.editOrganizerBTN.BackColor = System.Drawing.Color.White;
            this.editOrganizerBTN.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editOrganizerBTN.ForeColor = System.Drawing.Color.Black;
            this.editOrganizerBTN.Location = new System.Drawing.Point(340, 345);
            this.editOrganizerBTN.Name = "editOrganizerBTN";
            this.editOrganizerBTN.Size = new System.Drawing.Size(142, 70);
            this.editOrganizerBTN.TabIndex = 85;
            this.editOrganizerBTN.Text = "Edit Organizer";
            this.editOrganizerBTN.UseVisualStyleBackColor = false;
            this.editOrganizerBTN.Click += new System.EventHandler(this.editOrganizerBTN_Click);
            // 
            // organizersDGV
            // 
            this.organizersDGV.BackgroundColor = System.Drawing.Color.Black;
            this.organizersDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.organizersDGV.GridColor = System.Drawing.Color.White;
            this.organizersDGV.Location = new System.Drawing.Point(0, 95);
            this.organizersDGV.Name = "organizersDGV";
            this.organizersDGV.RowHeadersWidth = 51;
            this.organizersDGV.RowTemplate.Height = 24;
            this.organizersDGV.Size = new System.Drawing.Size(801, 233);
            this.organizersDGV.TabIndex = 84;
            this.organizersDGV.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.organizersDGV_CellValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(-4, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 20);
            this.label1.TabIndex = 93;
            this.label1.Text = "Organizer List";
            // 
            // EditOrganizers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.refreshBTN);
            this.Controls.Add(this.goBackBTN);
            this.Controls.Add(this.deleteOrganizerBTN);
            this.Controls.Add(this.loggedTXT);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.text);
            this.Controls.Add(this.editOrganizerBTN);
            this.Controls.Add(this.organizersDGV);
            this.Name = "EditOrganizers";
            this.Text = "EditOrganizers";
            this.Load += new System.EventHandler(this.EditOrganizers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.organizersDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel refreshBTN;
        private System.Windows.Forms.Button goBackBTN;
        private System.Windows.Forms.Button deleteOrganizerBTN;
        private System.Windows.Forms.Label loggedTXT;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label text;
        private System.Windows.Forms.Button editOrganizerBTN;
        private System.Windows.Forms.DataGridView organizersDGV;
        private System.Windows.Forms.Label label1;
    }
}