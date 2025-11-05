namespace SuperShop_Management
{
    partial class FormEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEmployee));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnclose2 = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.btnMore = new System.Windows.Forms.Button();
            this.lblcart = new System.Windows.Forms.Label();
            this.btncart = new System.Windows.Forms.Button();
            this.btncloseproduct = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnshowproduct = new System.Windows.Forms.Button();
            this.btnaddproduct = new System.Windows.Forms.Button();
            this.lblprofiledetails = new System.Windows.Forms.Label();
            this.btnProfile = new System.Windows.Forms.Button();
            this.lblId = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblAll = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.lblAll);
            this.panel1.Controls.Add(this.btnclose2);
            this.panel1.Controls.Add(this.btnLogOut);
            this.panel1.Controls.Add(this.btnChangePassword);
            this.panel1.Controls.Add(this.lblTime);
            this.panel1.Controls.Add(this.btnMore);
            this.panel1.Controls.Add(this.lblcart);
            this.panel1.Controls.Add(this.btncart);
            this.panel1.Controls.Add(this.btncloseproduct);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnshowproduct);
            this.panel1.Controls.Add(this.btnaddproduct);
            this.panel1.Controls.Add(this.lblprofiledetails);
            this.panel1.Controls.Add(this.btnProfile);
            this.panel1.Controls.Add(this.lblId);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1032, 557);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseHover += new System.EventHandler(this.panel1_MouseHover);
            // 
            // btnclose2
            // 
            this.btnclose2.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose2.Location = new System.Drawing.Point(382, 424);
            this.btnclose2.Name = "btnclose2";
            this.btnclose2.Size = new System.Drawing.Size(110, 87);
            this.btnclose2.TabIndex = 18;
            this.btnclose2.Text = "Close";
            this.btnclose2.UseVisualStyleBackColor = true;
            this.btnclose2.Visible = false;
            this.btnclose2.MouseHover += new System.EventHandler(this.btnclose2_MouseHover);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.Location = new System.Drawing.Point(156, 472);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(220, 40);
            this.btnLogOut.TabIndex = 17;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Visible = false;
            this.btnLogOut.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePassword.Location = new System.Drawing.Point(156, 424);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(220, 42);
            this.btnChangePassword.TabIndex = 16;
            this.btnChangePassword.Text = "Change Password";
            this.btnChangePassword.UseVisualStyleBackColor = true;
            this.btnChangePassword.Visible = false;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(752, 525);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(58, 23);
            this.lblTime.TabIndex = 9;
            this.lblTime.Text = "Time";
            // 
            // btnMore
            // 
            this.btnMore.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMore.Location = new System.Drawing.Point(7, 424);
            this.btnMore.Name = "btnMore";
            this.btnMore.Size = new System.Drawing.Size(143, 87);
            this.btnMore.TabIndex = 15;
            this.btnMore.Text = "More";
            this.btnMore.UseVisualStyleBackColor = true;
            this.btnMore.Click += new System.EventHandler(this.button2_Click);
            this.btnMore.MouseHover += new System.EventHandler(this.btnMore_MouseHover);
            // 
            // lblcart
            // 
            this.lblcart.AutoSize = true;
            this.lblcart.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblcart.Font = new System.Drawing.Font("Candara Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcart.Location = new System.Drawing.Point(3, 304);
            this.lblcart.Name = "lblcart";
            this.lblcart.Size = new System.Drawing.Size(225, 24);
            this.lblcart.TabIndex = 14;
            this.lblcart.Text = "Click Here to sell Products!";
            this.lblcart.Visible = false;
            // 
            // btncart
            // 
            this.btncart.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncart.Location = new System.Drawing.Point(7, 331);
            this.btncart.Name = "btncart";
            this.btncart.Size = new System.Drawing.Size(143, 87);
            this.btncart.TabIndex = 13;
            this.btncart.Text = "Cart";
            this.btncart.UseVisualStyleBackColor = true;
            this.btncart.Click += new System.EventHandler(this.btncart_Click);
            this.btncart.MouseLeave += new System.EventHandler(this.btncart_MouseLeave);
            this.btncart.MouseHover += new System.EventHandler(this.button2_MouseHover_1);
            // 
            // btncloseproduct
            // 
            this.btncloseproduct.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncloseproduct.Location = new System.Drawing.Point(367, 199);
            this.btncloseproduct.Name = "btncloseproduct";
            this.btncloseproduct.Size = new System.Drawing.Size(110, 87);
            this.btncloseproduct.TabIndex = 12;
            this.btncloseproduct.Text = "Close";
            this.btncloseproduct.UseVisualStyleBackColor = true;
            this.btncloseproduct.Visible = false;
            this.btncloseproduct.MouseHover += new System.EventHandler(this.button2_MouseHover);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(3, 195);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 87);
            this.button1.TabIndex = 11;
            this.button1.Text = "Products";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            this.button1.MouseHover += new System.EventHandler(this.button1_MouseHover);
            // 
            // btnshowproduct
            // 
            this.btnshowproduct.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnshowproduct.Location = new System.Drawing.Point(152, 199);
            this.btnshowproduct.Name = "btnshowproduct";
            this.btnshowproduct.Size = new System.Drawing.Size(209, 38);
            this.btnshowproduct.TabIndex = 10;
            this.btnshowproduct.Text = "Show Products";
            this.btnshowproduct.UseVisualStyleBackColor = true;
            this.btnshowproduct.Visible = false;
            this.btnshowproduct.Click += new System.EventHandler(this.btnshowproduct_Click);
            this.btnshowproduct.MouseLeave += new System.EventHandler(this.btnshowproduct_MouseLeave);
            this.btnshowproduct.MouseHover += new System.EventHandler(this.btnshowproduct_MouseHover);
            // 
            // btnaddproduct
            // 
            this.btnaddproduct.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddproduct.Location = new System.Drawing.Point(152, 243);
            this.btnaddproduct.Name = "btnaddproduct";
            this.btnaddproduct.Size = new System.Drawing.Size(209, 40);
            this.btnaddproduct.TabIndex = 7;
            this.btnaddproduct.Text = "Add Products";
            this.btnaddproduct.UseVisualStyleBackColor = true;
            this.btnaddproduct.Visible = false;
            this.btnaddproduct.Click += new System.EventHandler(this.btnaddproduct_Click);
            // 
            // lblprofiledetails
            // 
            this.lblprofiledetails.AutoSize = true;
            this.lblprofiledetails.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblprofiledetails.Font = new System.Drawing.Font("Candara Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprofiledetails.Location = new System.Drawing.Point(752, 258);
            this.lblprofiledetails.Name = "lblprofiledetails";
            this.lblprofiledetails.Size = new System.Drawing.Size(263, 24);
            this.lblprofiledetails.TabIndex = 5;
            this.lblprofiledetails.Text = "Click Here to see profile details!\r\n";
            this.lblprofiledetails.Visible = false;
            // 
            // btnProfile
            // 
            this.btnProfile.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnProfile.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfile.Location = new System.Drawing.Point(829, 285);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(186, 62);
            this.btnProfile.TabIndex = 4;
            this.btnProfile.Text = "Profile";
            this.btnProfile.UseVisualStyleBackColor = false;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            this.btnProfile.MouseLeave += new System.EventHandler(this.btnProfile_MouseLeave);
            this.btnProfile.MouseHover += new System.EventHandler(this.btnProfile_MouseHover);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblId.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(881, 224);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(54, 31);
            this.lblId.TabIndex = 3;
            this.lblId.Text = "ID: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(308, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Employee DashBoard";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(869, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 183);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblAll
            // 
            this.lblAll.AutoSize = true;
            this.lblAll.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAll.Font = new System.Drawing.Font("Candara Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAll.Location = new System.Drawing.Point(152, 163);
            this.lblAll.Name = "lblAll";
            this.lblAll.Size = new System.Drawing.Size(375, 24);
            this.lblAll.TabIndex = 19;
            this.lblAll.Text = "Click here to show,add and update products";
            this.lblAll.Visible = false;
            // 
            // FormEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1032, 557);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormEmployee";
            this.Text = "Employee";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblprofiledetails;
        private System.Windows.Forms.Button btnshowproduct;
        private System.Windows.Forms.Button btnaddproduct;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btncloseproduct;
        private System.Windows.Forms.Label lblcart;
        private System.Windows.Forms.Button btncart;
        private System.Windows.Forms.Button btnMore;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.Button btnclose2;
        private System.Windows.Forms.Label lblAll;
    }
}