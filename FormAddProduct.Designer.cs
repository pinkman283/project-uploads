namespace SuperShop_Management
{
    partial class FormAddProduct
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtPQuan = new System.Windows.Forms.TextBox();
            this.txtPPrice = new System.Windows.Forms.TextBox();
            this.txtPName = new System.Windows.Forms.TextBox();
            this.txtProductId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.txtPQuan);
            this.panel1.Controls.Add(this.txtPPrice);
            this.panel1.Controls.Add(this.txtPName);
            this.panel1.Controls.Add(this.txtProductId);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(666, 567);
            this.panel1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Font = new System.Drawing.Font("Colonna MT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(60, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(512, 38);
            this.label5.TabIndex = 11;
            this.label5.Text = "Provide All Product Information ";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(257, 437);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(78, 44);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.TabStop = false;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(142, 437);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 44);
            this.button1.TabIndex = 9;
            this.button1.TabStop = false;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtPQuan
            // 
            this.txtPQuan.Location = new System.Drawing.Point(277, 336);
            this.txtPQuan.Name = "txtPQuan";
            this.txtPQuan.Size = new System.Drawing.Size(190, 26);
            this.txtPQuan.TabIndex = 8;
            this.txtPQuan.TabStop = false;
            // 
            // txtPPrice
            // 
            this.txtPPrice.Location = new System.Drawing.Point(278, 270);
            this.txtPPrice.Name = "txtPPrice";
            this.txtPPrice.Size = new System.Drawing.Size(189, 26);
            this.txtPPrice.TabIndex = 7;
            this.txtPPrice.TabStop = false;
            // 
            // txtPName
            // 
            this.txtPName.Location = new System.Drawing.Point(277, 210);
            this.txtPName.Name = "txtPName";
            this.txtPName.Size = new System.Drawing.Size(190, 26);
            this.txtPName.TabIndex = 6;
            this.txtPName.TabStop = false;
            // 
            // txtProductId
            // 
            this.txtProductId.Location = new System.Drawing.Point(277, 155);
            this.txtProductId.Name = "txtProductId";
            this.txtProductId.ReadOnly = true;
            this.txtProductId.Size = new System.Drawing.Size(190, 26);
            this.txtProductId.TabIndex = 5;
            this.txtProductId.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 326);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(231, 36);
            this.label4.TabIndex = 4;
            this.label4.Text = "Product Quantity:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(61, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 36);
            this.label3.TabIndex = 3;
            this.label3.Text = "Product Price:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 36);
            this.label2.TabIndex = 2;
            this.label2.Text = "Product Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(99, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Product Id:";
            // 
            // FormAddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 567);
            this.Controls.Add(this.panel1);
            this.Name = "FormAddProduct";
            this.Text = "FormAddProduct";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtPName;
        private System.Windows.Forms.TextBox txtProductId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPQuan;
        private System.Windows.Forms.TextBox txtPPrice;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label5;
    }
}