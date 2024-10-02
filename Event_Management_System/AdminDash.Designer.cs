namespace Event_Management_System
{
    partial class AdminDash
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
            this.loggedTXT = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.text = new System.Windows.Forms.Label();
            this.viewUsersBTN = new System.Windows.Forms.Button();
            this.editEventsBTN = new System.Windows.Forms.Button();
            this.logoutBTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.eventsDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(236, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(347, 40);
            this.label3.TabIndex = 18;
            this.label3.Text = "Admin Dashboard";
            // 
            // eventsDGV
            // 
            this.eventsDGV.AllowDrop = true;
            this.eventsDGV.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.eventsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.eventsDGV.Location = new System.Drawing.Point(2, 96);
            this.eventsDGV.Name = "eventsDGV";
            this.eventsDGV.ReadOnly = true;
            this.eventsDGV.RowHeadersWidth = 51;
            this.eventsDGV.RowTemplate.Height = 24;
            this.eventsDGV.Size = new System.Drawing.Size(798, 247);
            this.eventsDGV.TabIndex = 19;
            // 
            // loggedTXT
            // 
            this.loggedTXT.AutoSize = true;
            this.loggedTXT.Font = new System.Drawing.Font("Verdana", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loggedTXT.Location = new System.Drawing.Point(686, 425);
            this.loggedTXT.Name = "loggedTXT";
            this.loggedTXT.Size = new System.Drawing.Size(102, 16);
            this.loggedTXT.TabIndex = 78;
            this.loggedTXT.Text = "Logged in as ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(686, 425);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 16);
            this.label10.TabIndex = 77;
            // 
            // text
            // 
            this.text.AutoSize = true;
            this.text.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text.Location = new System.Drawing.Point(686, 409);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(95, 16);
            this.text.TabIndex = 76;
            this.text.Text = "Logged in as ";
            // 
            // viewUsersBTN
            // 
            this.viewUsersBTN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.viewUsersBTN.BackColor = System.Drawing.Color.White;
            this.viewUsersBTN.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewUsersBTN.ForeColor = System.Drawing.Color.Black;
            this.viewUsersBTN.Location = new System.Drawing.Point(279, 359);
            this.viewUsersBTN.Name = "viewUsersBTN";
            this.viewUsersBTN.Size = new System.Drawing.Size(125, 66);
            this.viewUsersBTN.TabIndex = 79;
            this.viewUsersBTN.Text = "View Users";
            this.viewUsersBTN.UseVisualStyleBackColor = false;
            this.viewUsersBTN.Click += new System.EventHandler(this.viewUsersBTN_Click);
            // 
            // editEventsBTN
            // 
            this.editEventsBTN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.editEventsBTN.BackColor = System.Drawing.Color.Red;
            this.editEventsBTN.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editEventsBTN.ForeColor = System.Drawing.Color.White;
            this.editEventsBTN.Location = new System.Drawing.Point(419, 359);
            this.editEventsBTN.Name = "editEventsBTN";
            this.editEventsBTN.Size = new System.Drawing.Size(127, 66);
            this.editEventsBTN.TabIndex = 81;
            this.editEventsBTN.Text = "Edit Events";
            this.editEventsBTN.UseVisualStyleBackColor = false;
            this.editEventsBTN.Click += new System.EventHandler(this.editEventsBTN_Click);
            // 
            // logoutBTN
            // 
            this.logoutBTN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.logoutBTN.BackColor = System.Drawing.Color.Red;
            this.logoutBTN.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutBTN.ForeColor = System.Drawing.Color.White;
            this.logoutBTN.Location = new System.Drawing.Point(12, 409);
            this.logoutBTN.Name = "logoutBTN";
            this.logoutBTN.Size = new System.Drawing.Size(85, 32);
            this.logoutBTN.TabIndex = 82;
            this.logoutBTN.Text = "Logout";
            this.logoutBTN.UseVisualStyleBackColor = false;
            this.logoutBTN.Click += new System.EventHandler(this.logoutBTN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(-2, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 83;
            this.label1.Text = "Event List";
            // 
            // AdminDash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logoutBTN);
            this.Controls.Add(this.editEventsBTN);
            this.Controls.Add(this.viewUsersBTN);
            this.Controls.Add(this.loggedTXT);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.text);
            this.Controls.Add(this.eventsDGV);
            this.Controls.Add(this.label3);
            this.Name = "AdminDash";
            this.Text = "AdminDash";
            this.Load += new System.EventHandler(this.AdminDash_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eventsDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView eventsDGV;
        private System.Windows.Forms.Label loggedTXT;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label text;
        private System.Windows.Forms.Button viewUsersBTN;
        private System.Windows.Forms.Button editEventsBTN;
        private System.Windows.Forms.Button logoutBTN;
        private System.Windows.Forms.Label label1;
    }
}