namespace Project
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnLogOut = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnProfile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnProductInfo = new System.Windows.Forms.Button();
            this.btnSalesReport = new System.Windows.Forms.Button();
            this.btnEmployeeDetails = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogOut
            // 
            this.btnLogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogOut.Location = new System.Drawing.Point(594, 400);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(75, 23);
            this.btnLogOut.TabIndex = 13;
            this.btnLogOut.Text = "LogOut";
            this.btnLogOut.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(346, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(232, 29);
            this.label4.TabIndex = 9;
            this.label4.Text = "Control Dashboard";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel2.Controls.Add(this.lblName);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(232, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(568, 35);
            this.panel2.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Welcome";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            this.panel1.Controls.Add(this.btnProfile);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(232, 450);
            this.panel1.TabIndex = 7;
            // 
            // btnProfile
            // 
            this.btnProfile.BackColor = System.Drawing.Color.White;
            this.btnProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnProfile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProfile.Location = new System.Drawing.Point(23, 239);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(62, 23);
            this.btnProfile.TabIndex = 2;
            this.btnProfile.Text = " Profile";
            this.btnProfile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProfile.UseVisualStyleBackColor = false;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(23, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome Manager";
            // 
            // btnProductInfo
            // 
            this.btnProductInfo.BackColor = System.Drawing.Color.White;
            this.btnProductInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductInfo.Image = global::Project.Properties.Resources.rsz_1rsz_1rsz_1rsz_1rsz_1supermarket_store_business_black_and_white_vector_23606794;
            this.btnProductInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductInfo.Location = new System.Drawing.Point(419, 284);
            this.btnProductInfo.Name = "btnProductInfo";
            this.btnProductInfo.Size = new System.Drawing.Size(124, 52);
            this.btnProductInfo.TabIndex = 12;
            this.btnProductInfo.Text = "  Product Info";
            this.btnProductInfo.UseVisualStyleBackColor = false;
            this.btnProductInfo.Click += new System.EventHandler(this.btnProductInfo_Click);
            // 
            // btnSalesReport
            // 
            this.btnSalesReport.BackColor = System.Drawing.Color.White;
            this.btnSalesReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalesReport.Image = global::Project.Properties.Resources.rsz_1rsz_1rsz_1rsz_sales_report;
            this.btnSalesReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalesReport.Location = new System.Drawing.Point(419, 208);
            this.btnSalesReport.Name = "btnSalesReport";
            this.btnSalesReport.Size = new System.Drawing.Size(124, 55);
            this.btnSalesReport.TabIndex = 11;
            this.btnSalesReport.Text = "Sales Report";
            this.btnSalesReport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalesReport.UseVisualStyleBackColor = false;
            this.btnSalesReport.Click += new System.EventHandler(this.btnSalesReport_Click);
            // 
            // btnEmployeeDetails
            // 
            this.btnEmployeeDetails.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEmployeeDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployeeDetails.Image = ((System.Drawing.Image)(resources.GetObject("btnEmployeeDetails.Image")));
            this.btnEmployeeDetails.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmployeeDetails.Location = new System.Drawing.Point(419, 122);
            this.btnEmployeeDetails.Name = "btnEmployeeDetails";
            this.btnEmployeeDetails.Size = new System.Drawing.Size(124, 66);
            this.btnEmployeeDetails.TabIndex = 10;
            this.btnEmployeeDetails.Text = "   Employee Details";
            this.btnEmployeeDetails.UseVisualStyleBackColor = false;
            this.btnEmployeeDetails.Click += new System.EventHandler(this.btnEmployeeDetails_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(232, 188);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(103, 13);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(0, 13);
            this.lblName.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnProductInfo);
            this.Controls.Add(this.btnSalesReport);
            this.Controls.Add(this.btnEmployeeDetails);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnProductInfo;
        private System.Windows.Forms.Button btnSalesReport;
        private System.Windows.Forms.Button btnEmployeeDetails;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblName;
    }
}

