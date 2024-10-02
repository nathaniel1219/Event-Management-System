namespace Event_Management_System
{
    partial class EditEvents
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
            this.deleteEventBTN = new System.Windows.Forms.Button();
            this.loggedTXT = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.text = new System.Windows.Forms.Label();
            this.editEventBTN = new System.Windows.Forms.Button();
            this.viewEventsDGV = new System.Windows.Forms.DataGridView();
            this.goBackBTN = new System.Windows.Forms.Button();
            this.refreshBTN = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.viewEventsDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // deleteEventBTN
            // 
            this.deleteEventBTN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.deleteEventBTN.BackColor = System.Drawing.Color.Red;
            this.deleteEventBTN.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteEventBTN.ForeColor = System.Drawing.Color.White;
            this.deleteEventBTN.Location = new System.Drawing.Point(490, 333);
            this.deleteEventBTN.Name = "deleteEventBTN";
            this.deleteEventBTN.Size = new System.Drawing.Size(127, 66);
            this.deleteEventBTN.TabIndex = 76;
            this.deleteEventBTN.Text = "Delete Event";
            this.deleteEventBTN.UseVisualStyleBackColor = false;
            this.deleteEventBTN.Click += new System.EventHandler(this.deleteEventBTN_Click);
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
            // editEventBTN
            // 
            this.editEventBTN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.editEventBTN.BackColor = System.Drawing.Color.White;
            this.editEventBTN.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editEventBTN.ForeColor = System.Drawing.Color.Black;
            this.editEventBTN.Location = new System.Drawing.Point(359, 333);
            this.editEventBTN.Name = "editEventBTN";
            this.editEventBTN.Size = new System.Drawing.Size(125, 66);
            this.editEventBTN.TabIndex = 72;
            this.editEventBTN.Text = "Edit Event";
            this.editEventBTN.UseVisualStyleBackColor = false;
            this.editEventBTN.Click += new System.EventHandler(this.editEventBTN_Click);
            // 
            // viewEventsDGV
            // 
            this.viewEventsDGV.BackgroundColor = System.Drawing.Color.Black;
            this.viewEventsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewEventsDGV.GridColor = System.Drawing.Color.White;
            this.viewEventsDGV.Location = new System.Drawing.Point(0, 71);
            this.viewEventsDGV.Name = "viewEventsDGV";
            this.viewEventsDGV.RowHeadersWidth = 51;
            this.viewEventsDGV.RowTemplate.Height = 24;
            this.viewEventsDGV.Size = new System.Drawing.Size(801, 233);
            this.viewEventsDGV.TabIndex = 70;
            this.viewEventsDGV.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.viewEventsDGV_CellValueChanged);
            // 
            // goBackBTN
            // 
            this.goBackBTN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.goBackBTN.BackColor = System.Drawing.Color.White;
            this.goBackBTN.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goBackBTN.ForeColor = System.Drawing.Color.Black;
            this.goBackBTN.Location = new System.Drawing.Point(228, 333);
            this.goBackBTN.Name = "goBackBTN";
            this.goBackBTN.Size = new System.Drawing.Size(125, 66);
            this.goBackBTN.TabIndex = 77;
            this.goBackBTN.Text = "Go Back";
            this.goBackBTN.UseVisualStyleBackColor = false;
            this.goBackBTN.Click += new System.EventHandler(this.goBackBTN_Click);
            // 
            // refreshBTN
            // 
            this.refreshBTN.AutoSize = true;
            this.refreshBTN.Location = new System.Drawing.Point(13, 414);
            this.refreshBTN.Name = "refreshBTN";
            this.refreshBTN.Size = new System.Drawing.Size(54, 16);
            this.refreshBTN.TabIndex = 78;
            this.refreshBTN.TabStop = true;
            this.refreshBTN.Text = "Refresh";
            this.refreshBTN.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.refreshBTN_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(247, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(327, 40);
            this.label3.TabIndex = 83;
            this.label3.Text = "Edit Events Page";
            // 
            // EditEvents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.refreshBTN);
            this.Controls.Add(this.goBackBTN);
            this.Controls.Add(this.deleteEventBTN);
            this.Controls.Add(this.loggedTXT);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.text);
            this.Controls.Add(this.editEventBTN);
            this.Controls.Add(this.viewEventsDGV);
            this.Name = "EditEvents";
            this.Text = "EditEvents";
            this.Load += new System.EventHandler(this.EditEvents_Load);
            ((System.ComponentModel.ISupportInitialize)(this.viewEventsDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button deleteEventBTN;
        private System.Windows.Forms.Label loggedTXT;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label text;
        private System.Windows.Forms.Button editEventBTN;
        private System.Windows.Forms.DataGridView viewEventsDGV;
        private System.Windows.Forms.Button goBackBTN;
        private System.Windows.Forms.LinkLabel refreshBTN;
        private System.Windows.Forms.Label label3;
    }
}