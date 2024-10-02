namespace Event_Management_System
{
    partial class ViewParticipantEvents
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
            this.removeEventBTN = new System.Windows.Forms.Button();
            this.loggedTXT = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.text = new System.Windows.Forms.Label();
            this.goBackBTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.eventsDGV = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.refreshBTN = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.eventsDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // removeEventBTN
            // 
            this.removeEventBTN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.removeEventBTN.BackColor = System.Drawing.Color.Red;
            this.removeEventBTN.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold);
            this.removeEventBTN.ForeColor = System.Drawing.Color.White;
            this.removeEventBTN.Location = new System.Drawing.Point(406, 330);
            this.removeEventBTN.Name = "removeEventBTN";
            this.removeEventBTN.Size = new System.Drawing.Size(142, 70);
            this.removeEventBTN.TabIndex = 104;
            this.removeEventBTN.Text = "Remove Event";
            this.removeEventBTN.UseVisualStyleBackColor = false;
            this.removeEventBTN.Click += new System.EventHandler(this.removeEventBTN_Click);
            // 
            // loggedTXT
            // 
            this.loggedTXT.AutoSize = true;
            this.loggedTXT.Font = new System.Drawing.Font("Verdana", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loggedTXT.Location = new System.Drawing.Point(689, 408);
            this.loggedTXT.Name = "loggedTXT";
            this.loggedTXT.Size = new System.Drawing.Size(102, 16);
            this.loggedTXT.TabIndex = 103;
            this.loggedTXT.Text = "Logged in as ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(689, 408);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 16);
            this.label10.TabIndex = 102;
            // 
            // text
            // 
            this.text.AutoSize = true;
            this.text.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text.Location = new System.Drawing.Point(689, 392);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(95, 16);
            this.text.TabIndex = 101;
            this.text.Text = "Logged in as ";
            // 
            // goBackBTN
            // 
            this.goBackBTN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.goBackBTN.BackColor = System.Drawing.Color.White;
            this.goBackBTN.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goBackBTN.ForeColor = System.Drawing.Color.Black;
            this.goBackBTN.Location = new System.Drawing.Point(258, 330);
            this.goBackBTN.Name = "goBackBTN";
            this.goBackBTN.Size = new System.Drawing.Size(142, 70);
            this.goBackBTN.TabIndex = 100;
            this.goBackBTN.Text = "Go Back";
            this.goBackBTN.UseVisualStyleBackColor = false;
            this.goBackBTN.Click += new System.EventHandler(this.goBackBTN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(-1, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 99;
            this.label1.Text = "Event List";
            // 
            // eventsDGV
            // 
            this.eventsDGV.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.eventsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.eventsDGV.Location = new System.Drawing.Point(3, 127);
            this.eventsDGV.Name = "eventsDGV";
            this.eventsDGV.RowHeadersWidth = 51;
            this.eventsDGV.RowTemplate.Height = 24;
            this.eventsDGV.Size = new System.Drawing.Size(799, 171);
            this.eventsDGV.TabIndex = 98;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(261, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(306, 40);
            this.label3.TabIndex = 97;
            this.label3.Text = "View My Events";
            // 
            // refreshBTN
            // 
            this.refreshBTN.AutoSize = true;
            this.refreshBTN.Location = new System.Drawing.Point(12, 408);
            this.refreshBTN.Name = "refreshBTN";
            this.refreshBTN.Size = new System.Drawing.Size(54, 16);
            this.refreshBTN.TabIndex = 105;
            this.refreshBTN.TabStop = true;
            this.refreshBTN.Text = "Refresh";
            this.refreshBTN.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.refreshBTN_LinkClicked);
            // 
            // ViewParticipantEvents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.refreshBTN);
            this.Controls.Add(this.removeEventBTN);
            this.Controls.Add(this.loggedTXT);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.text);
            this.Controls.Add(this.goBackBTN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.eventsDGV);
            this.Controls.Add(this.label3);
            this.Name = "ViewParticipantEvents";
            this.Text = "ViewParticipantEvents";
            this.Load += new System.EventHandler(this.ViewParticipantEvents_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eventsDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button removeEventBTN;
        private System.Windows.Forms.Label loggedTXT;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label text;
        private System.Windows.Forms.Button goBackBTN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView eventsDGV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel refreshBTN;
    }
}