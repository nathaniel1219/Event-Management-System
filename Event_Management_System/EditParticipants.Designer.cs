namespace Event_Management_System
{
    partial class EditParticipants
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
            this.deleteParticipantBTN = new System.Windows.Forms.Button();
            this.loggedTXT = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.text = new System.Windows.Forms.Label();
            this.editParticipantBTN = new System.Windows.Forms.Button();
            this.participantsDGV = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.participantsDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(269, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(322, 40);
            this.label3.TabIndex = 101;
            this.label3.Text = "Edit Participants";
            // 
            // refreshBTN
            // 
            this.refreshBTN.AutoSize = true;
            this.refreshBTN.Location = new System.Drawing.Point(13, 415);
            this.refreshBTN.Name = "refreshBTN";
            this.refreshBTN.Size = new System.Drawing.Size(54, 16);
            this.refreshBTN.TabIndex = 100;
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
            this.goBackBTN.Location = new System.Drawing.Point(157, 350);
            this.goBackBTN.Name = "goBackBTN";
            this.goBackBTN.Size = new System.Drawing.Size(142, 65);
            this.goBackBTN.TabIndex = 99;
            this.goBackBTN.Text = "Go Back";
            this.goBackBTN.UseVisualStyleBackColor = false;
            this.goBackBTN.Click += new System.EventHandler(this.goBackBTN_Click);
            // 
            // deleteParticipantBTN
            // 
            this.deleteParticipantBTN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.deleteParticipantBTN.BackColor = System.Drawing.Color.Red;
            this.deleteParticipantBTN.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteParticipantBTN.ForeColor = System.Drawing.Color.White;
            this.deleteParticipantBTN.Location = new System.Drawing.Point(481, 348);
            this.deleteParticipantBTN.Name = "deleteParticipantBTN";
            this.deleteParticipantBTN.Size = new System.Drawing.Size(168, 67);
            this.deleteParticipantBTN.TabIndex = 98;
            this.deleteParticipantBTN.Text = "Delete Participant";
            this.deleteParticipantBTN.UseVisualStyleBackColor = false;
            this.deleteParticipantBTN.Click += new System.EventHandler(this.deleteParticipantBTN_Click);
            // 
            // loggedTXT
            // 
            this.loggedTXT.AutoSize = true;
            this.loggedTXT.Font = new System.Drawing.Font("Verdana", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loggedTXT.Location = new System.Drawing.Point(686, 415);
            this.loggedTXT.Name = "loggedTXT";
            this.loggedTXT.Size = new System.Drawing.Size(102, 16);
            this.loggedTXT.TabIndex = 97;
            this.loggedTXT.Text = "Logged in as ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(686, 415);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 16);
            this.label10.TabIndex = 96;
            // 
            // text
            // 
            this.text.AutoSize = true;
            this.text.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text.Location = new System.Drawing.Point(686, 399);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(95, 16);
            this.text.TabIndex = 95;
            this.text.Text = "Logged in as ";
            // 
            // editParticipantBTN
            // 
            this.editParticipantBTN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.editParticipantBTN.BackColor = System.Drawing.Color.White;
            this.editParticipantBTN.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editParticipantBTN.ForeColor = System.Drawing.Color.Black;
            this.editParticipantBTN.Location = new System.Drawing.Point(307, 348);
            this.editParticipantBTN.Name = "editParticipantBTN";
            this.editParticipantBTN.Size = new System.Drawing.Size(168, 67);
            this.editParticipantBTN.TabIndex = 94;
            this.editParticipantBTN.Text = "Edit Participant";
            this.editParticipantBTN.UseVisualStyleBackColor = false;
            this.editParticipantBTN.Click += new System.EventHandler(this.editParticipantBTN_Click);
            // 
            // participantsDGV
            // 
            this.participantsDGV.BackgroundColor = System.Drawing.Color.Black;
            this.participantsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.participantsDGV.GridColor = System.Drawing.Color.White;
            this.participantsDGV.Location = new System.Drawing.Point(2, 98);
            this.participantsDGV.Name = "participantsDGV";
            this.participantsDGV.RowHeadersWidth = 51;
            this.participantsDGV.RowTemplate.Height = 24;
            this.participantsDGV.Size = new System.Drawing.Size(801, 233);
            this.participantsDGV.TabIndex = 93;
            this.participantsDGV.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.participantsDGV_CellValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(-2, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 20);
            this.label1.TabIndex = 102;
            this.label1.Text = "Participant List";
            // 
            // EditParticipants
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.refreshBTN);
            this.Controls.Add(this.goBackBTN);
            this.Controls.Add(this.deleteParticipantBTN);
            this.Controls.Add(this.loggedTXT);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.text);
            this.Controls.Add(this.editParticipantBTN);
            this.Controls.Add(this.participantsDGV);
            this.Name = "EditParticipants";
            this.Text = "EditParticipants";
            this.Load += new System.EventHandler(this.EditParticipants_Load);
            ((System.ComponentModel.ISupportInitialize)(this.participantsDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel refreshBTN;
        private System.Windows.Forms.Button goBackBTN;
        private System.Windows.Forms.Button deleteParticipantBTN;
        private System.Windows.Forms.Label loggedTXT;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label text;
        private System.Windows.Forms.Button editParticipantBTN;
        private System.Windows.Forms.DataGridView participantsDGV;
        private System.Windows.Forms.Label label1;
    }
}