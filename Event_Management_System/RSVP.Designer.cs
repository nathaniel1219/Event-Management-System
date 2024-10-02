namespace Event_Management_System
{
    partial class RSVP
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
            this.eventsDGV = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.goBackBTN = new System.Windows.Forms.Button();
            this.loggedTXT = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.text = new System.Windows.Forms.Label();
            this.rsvpBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.eventsDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(275, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(251, 40);
            this.label3.TabIndex = 41;
            this.label3.Text = "RSVP Events";
            // 
            // eventsDGV
            // 
            this.eventsDGV.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.eventsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.eventsDGV.Location = new System.Drawing.Point(0, 144);
            this.eventsDGV.Name = "eventsDGV";
            this.eventsDGV.RowHeadersWidth = 51;
            this.eventsDGV.RowTemplate.Height = 24;
            this.eventsDGV.Size = new System.Drawing.Size(799, 171);
            this.eventsDGV.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(-4, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 43;
            this.label1.Text = "Event List";
            // 
            // goBackBTN
            // 
            this.goBackBTN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.goBackBTN.BackColor = System.Drawing.Color.White;
            this.goBackBTN.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goBackBTN.ForeColor = System.Drawing.Color.Black;
            this.goBackBTN.Location = new System.Drawing.Point(255, 347);
            this.goBackBTN.Name = "goBackBTN";
            this.goBackBTN.Size = new System.Drawing.Size(142, 70);
            this.goBackBTN.TabIndex = 92;
            this.goBackBTN.Text = "Go Back";
            this.goBackBTN.UseVisualStyleBackColor = false;
            this.goBackBTN.Click += new System.EventHandler(this.goBackBTN_Click);
            // 
            // loggedTXT
            // 
            this.loggedTXT.AutoSize = true;
            this.loggedTXT.Font = new System.Drawing.Font("Verdana", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loggedTXT.Location = new System.Drawing.Point(686, 425);
            this.loggedTXT.Name = "loggedTXT";
            this.loggedTXT.Size = new System.Drawing.Size(102, 16);
            this.loggedTXT.TabIndex = 95;
            this.loggedTXT.Text = "Logged in as ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(686, 425);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 16);
            this.label10.TabIndex = 94;
            // 
            // text
            // 
            this.text.AutoSize = true;
            this.text.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text.Location = new System.Drawing.Point(686, 409);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(95, 16);
            this.text.TabIndex = 93;
            this.text.Text = "Logged in as ";
            // 
            // rsvpBTN
            // 
            this.rsvpBTN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.rsvpBTN.BackColor = System.Drawing.Color.Red;
            this.rsvpBTN.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold);
            this.rsvpBTN.ForeColor = System.Drawing.Color.White;
            this.rsvpBTN.Location = new System.Drawing.Point(403, 347);
            this.rsvpBTN.Name = "rsvpBTN";
            this.rsvpBTN.Size = new System.Drawing.Size(142, 70);
            this.rsvpBTN.TabIndex = 96;
            this.rsvpBTN.Text = "RSVP Event";
            this.rsvpBTN.UseVisualStyleBackColor = false;
            this.rsvpBTN.Click += new System.EventHandler(this.rsvpBTN_Click);
            // 
            // RSVP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rsvpBTN);
            this.Controls.Add(this.loggedTXT);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.text);
            this.Controls.Add(this.goBackBTN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.eventsDGV);
            this.Controls.Add(this.label3);
            this.Name = "RSVP";
            this.Text = "RSVP";
            this.Load += new System.EventHandler(this.RSVP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eventsDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView eventsDGV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button goBackBTN;
        private System.Windows.Forms.Label loggedTXT;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label text;
        private System.Windows.Forms.Button rsvpBTN;
    }
}