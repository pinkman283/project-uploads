namespace SuperShop_Management
{
    partial class FormChangePass
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtNp1 = new System.Windows.Forms.TextBox();
            this.txtNp2 = new System.Windows.Forms.TextBox();
            this.btnclose2 = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightSlateGray;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(126, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 30);
            this.label1.TabIndex = 6;
            this.label1.Text = "New Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightSlateGray;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(276, 30);
            this.label2.TabIndex = 7;
            this.label2.Text = "Confirm New Password";
            // 
            // txtNp1
            // 
            this.txtNp1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtNp1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNp1.Font = new System.Drawing.Font("Cascadia Code ExtraLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNp1.ForeColor = System.Drawing.SystemColors.Window;
            this.txtNp1.Location = new System.Drawing.Point(340, 108);
            this.txtNp1.Name = "txtNp1";
            this.txtNp1.Size = new System.Drawing.Size(338, 35);
            this.txtNp1.TabIndex = 8;
            this.txtNp1.Text = "Password";
            this.txtNp1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNp2
            // 
            this.txtNp2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtNp2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNp2.Font = new System.Drawing.Font("Cascadia Code ExtraLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNp2.ForeColor = System.Drawing.SystemColors.Window;
            this.txtNp2.Location = new System.Drawing.Point(340, 164);
            this.txtNp2.Name = "txtNp2";
            this.txtNp2.Size = new System.Drawing.Size(338, 35);
            this.txtNp2.TabIndex = 9;
            this.txtNp2.Text = "Confrim Password";
            this.txtNp2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNp2.Enter += new System.EventHandler(this.txtNp2_Enter);
            // 
            // btnclose2
            // 
            this.btnclose2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnclose2.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose2.Location = new System.Drawing.Point(194, 219);
            this.btnclose2.Name = "btnclose2";
            this.btnclose2.Size = new System.Drawing.Size(110, 87);
            this.btnclose2.TabIndex = 19;
            this.btnclose2.Text = "Close";
            this.btnclose2.UseVisualStyleBackColor = false;
            this.btnclose2.Click += new System.EventHandler(this.btnclose2_Click);
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnsave.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.Location = new System.Drawing.Point(460, 219);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(110, 87);
            this.btnsave.TabIndex = 20;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // FormChangePass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 318);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btnclose2);
            this.Controls.Add(this.txtNp2);
            this.Controls.Add(this.txtNp1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormChangePass";
            this.Text = "FormChangePass";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNp1;
        private System.Windows.Forms.TextBox txtNp2;
        private System.Windows.Forms.Button btnclose2;
        private System.Windows.Forms.Button btnsave;
    }
}