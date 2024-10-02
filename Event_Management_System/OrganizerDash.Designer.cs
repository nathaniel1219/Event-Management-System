namespace Event_Management_System
{
    partial class OrganizerDash
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
            this.label1 = new System.Windows.Forms.Label();
            this.text = new System.Windows.Forms.Label();
            this.viewEventsBTN = new System.Windows.Forms.Button();
            this.createEventsBTN = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.logoutBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loggedTXT
            // 
            this.loggedTXT.AutoSize = true;
            this.loggedTXT.Font = new System.Drawing.Font("Verdana", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loggedTXT.Location = new System.Drawing.Point(674, 422);
            this.loggedTXT.Name = "loggedTXT";
            this.loggedTXT.Size = new System.Drawing.Size(102, 16);
            this.loggedTXT.TabIndex = 42;
            this.loggedTXT.Text = "Logged in as ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(674, 422);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 41;
            // 
            // text
            // 
            this.text.AutoSize = true;
            this.text.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text.Location = new System.Drawing.Point(674, 406);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(95, 16);
            this.text.TabIndex = 40;
            this.text.Text = "Logged in as ";
            // 
            // viewEventsBTN
            // 
            this.viewEventsBTN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.viewEventsBTN.BackColor = System.Drawing.Color.White;
            this.viewEventsBTN.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewEventsBTN.ForeColor = System.Drawing.Color.Black;
            this.viewEventsBTN.Location = new System.Drawing.Point(217, 195);
            this.viewEventsBTN.Name = "viewEventsBTN";
            this.viewEventsBTN.Size = new System.Drawing.Size(177, 103);
            this.viewEventsBTN.TabIndex = 39;
            this.viewEventsBTN.Text = "View Events";
            this.viewEventsBTN.UseVisualStyleBackColor = false;
            this.viewEventsBTN.Click += new System.EventHandler(this.viewEventsBTN_Click);
            // 
            // createEventsBTN
            // 
            this.createEventsBTN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.createEventsBTN.BackColor = System.Drawing.Color.Red;
            this.createEventsBTN.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createEventsBTN.ForeColor = System.Drawing.Color.White;
            this.createEventsBTN.Location = new System.Drawing.Point(400, 195);
            this.createEventsBTN.Name = "createEventsBTN";
            this.createEventsBTN.Size = new System.Drawing.Size(178, 103);
            this.createEventsBTN.TabIndex = 38;
            this.createEventsBTN.Text = "Create Events";
            this.createEventsBTN.UseVisualStyleBackColor = false;
            this.createEventsBTN.Click += new System.EventHandler(this.createEventsBTN_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(194, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(410, 40);
            this.label3.TabIndex = 37;
            this.label3.Text = "Organizer Dashboard";
            // 
            // logoutBTN
            // 
            this.logoutBTN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.logoutBTN.BackColor = System.Drawing.Color.Red;
            this.logoutBTN.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutBTN.ForeColor = System.Drawing.Color.White;
            this.logoutBTN.Location = new System.Drawing.Point(12, 406);
            this.logoutBTN.Name = "logoutBTN";
            this.logoutBTN.Size = new System.Drawing.Size(92, 32);
            this.logoutBTN.TabIndex = 83;
            this.logoutBTN.Text = "Logout";
            this.logoutBTN.UseVisualStyleBackColor = false;
            this.logoutBTN.Click += new System.EventHandler(this.logoutBTN_Click);
            // 
            // OrganizerDash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.logoutBTN);
            this.Controls.Add(this.loggedTXT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.text);
            this.Controls.Add(this.viewEventsBTN);
            this.Controls.Add(this.createEventsBTN);
            this.Controls.Add(this.label3);
            this.Name = "OrganizerDash";
            this.Text = "OrganizerDash";
            this.Load += new System.EventHandler(this.OrganizerDash_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label loggedTXT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label text;
        private System.Windows.Forms.Button viewEventsBTN;
        private System.Windows.Forms.Button createEventsBTN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button logoutBTN;
    }
}