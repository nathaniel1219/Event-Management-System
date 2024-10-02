namespace Event_Management_System
{
    partial class ViewEvents
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
            this.viewEventsDGV = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.gobackBTN = new System.Windows.Forms.Button();
            this.loggedTXT = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.text = new System.Windows.Forms.Label();
            this.editEventsBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.viewEventsDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // viewEventsDGV
            // 
            this.viewEventsDGV.BackgroundColor = System.Drawing.Color.Black;
            this.viewEventsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewEventsDGV.GridColor = System.Drawing.Color.White;
            this.viewEventsDGV.Location = new System.Drawing.Point(0, 82);
            this.viewEventsDGV.Name = "viewEventsDGV";
            this.viewEventsDGV.ReadOnly = true;
            this.viewEventsDGV.RowHeadersWidth = 51;
            this.viewEventsDGV.RowTemplate.Height = 24;
            this.viewEventsDGV.Size = new System.Drawing.Size(801, 233);
            this.viewEventsDGV.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(261, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(286, 28);
            this.label3.TabIndex = 12;
            this.label3.Text = "View My Events Page";
            // 
            // gobackBTN
            // 
            this.gobackBTN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gobackBTN.BackColor = System.Drawing.Color.White;
            this.gobackBTN.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gobackBTN.ForeColor = System.Drawing.Color.Black;
            this.gobackBTN.Location = new System.Drawing.Point(277, 346);
            this.gobackBTN.Name = "gobackBTN";
            this.gobackBTN.Size = new System.Drawing.Size(125, 66);
            this.gobackBTN.TabIndex = 41;
            this.gobackBTN.Text = "Go Back";
            this.gobackBTN.UseVisualStyleBackColor = false;
            this.gobackBTN.Click += new System.EventHandler(this.gobackBTN_Click);
            // 
            // loggedTXT
            // 
            this.loggedTXT.AutoSize = true;
            this.loggedTXT.Font = new System.Drawing.Font("Verdana", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loggedTXT.Location = new System.Drawing.Point(686, 425);
            this.loggedTXT.Name = "loggedTXT";
            this.loggedTXT.Size = new System.Drawing.Size(102, 16);
            this.loggedTXT.TabIndex = 68;
            this.loggedTXT.Text = "Logged in as ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(686, 425);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 16);
            this.label10.TabIndex = 67;
            // 
            // text
            // 
            this.text.AutoSize = true;
            this.text.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text.Location = new System.Drawing.Point(686, 409);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(95, 16);
            this.text.TabIndex = 66;
            this.text.Text = "Logged in as ";
            // 
            // editEventsBTN
            // 
            this.editEventsBTN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.editEventsBTN.BackColor = System.Drawing.Color.Red;
            this.editEventsBTN.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editEventsBTN.ForeColor = System.Drawing.Color.White;
            this.editEventsBTN.Location = new System.Drawing.Point(408, 346);
            this.editEventsBTN.Name = "editEventsBTN";
            this.editEventsBTN.Size = new System.Drawing.Size(127, 66);
            this.editEventsBTN.TabIndex = 69;
            this.editEventsBTN.Text = "Edit Events";
            this.editEventsBTN.UseVisualStyleBackColor = false;
            this.editEventsBTN.Click += new System.EventHandler(this.editEventsBTN_Click);
            // 
            // ViewEvents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.editEventsBTN);
            this.Controls.Add(this.loggedTXT);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.text);
            this.Controls.Add(this.gobackBTN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.viewEventsDGV);
            this.Name = "ViewEvents";
            this.Text = "ViewEvents";
            this.Load += new System.EventHandler(this.ViewEvents_Load);
            ((System.ComponentModel.ISupportInitialize)(this.viewEventsDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView viewEventsDGV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button gobackBTN;
        private System.Windows.Forms.Label loggedTXT;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label text;
        private System.Windows.Forms.Button editEventsBTN;
    }
}