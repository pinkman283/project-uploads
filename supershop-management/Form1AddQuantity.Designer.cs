namespace SuperShop_Management
{
    partial class FormAddQuantity
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtQuan = new System.Windows.Forms.TextBox();
            this.lblQuan = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 44);
            this.label1.TabIndex = 8;
            this.label1.Text = "Quantiry";
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnOk.Location = new System.Drawing.Point(268, 254);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(88, 42);
            this.btnOk.TabIndex = 9;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnCancel.Location = new System.Drawing.Point(56, 254);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(88, 42);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtQuan
            // 
            this.txtQuan.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtQuan.Font = new System.Drawing.Font("Cascadia Code ExtraLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuan.ForeColor = System.Drawing.SystemColors.Window;
            this.txtQuan.Location = new System.Drawing.Point(198, 191);
            this.txtQuan.Name = "txtQuan";
            this.txtQuan.Size = new System.Drawing.Size(247, 35);
            this.txtQuan.TabIndex = 11;
            this.txtQuan.Text = "Write Here";
            this.txtQuan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtQuan.Enter += new System.EventHandler(this.txtQuan_Enter);
            // 
            // lblQuan
            // 
            this.lblQuan.AutoSize = true;
            this.lblQuan.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblQuan.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuan.Location = new System.Drawing.Point(58, 53);
            this.lblQuan.Name = "lblQuan";
            this.lblQuan.Size = new System.Drawing.Size(284, 44);
            this.lblQuan.TabIndex = 12;
            this.lblQuan.Text = "Available Quantity: ";
            // 
            // FormAddQuantity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(477, 323);
            this.Controls.Add(this.lblQuan);
            this.Controls.Add(this.txtQuan);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAddQuantity";
            this.Text = "FormAddQuantity";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtQuan;
        private System.Windows.Forms.Label lblQuan;
    }
}