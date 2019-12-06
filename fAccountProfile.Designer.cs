namespace WindowsFormsApplication1
{
    partial class fAccountProfile
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
            this.btExit = new System.Windows.Forms.Button();
            this.btUpdate = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtReEnterPassWord = new System.Windows.Forms.TextBox();
            this.lbReEnterPassWord = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtNewPassWord = new System.Windows.Forms.TextBox();
            this.lbNewPassWord = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lbPassWord = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtDisplayName = new System.Windows.Forms.TextBox();
            this.lbDisplayName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lbUserName = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btExit);
            this.panel1.Controls.Add(this.btUpdate);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(3, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(503, 467);
            this.panel1.TabIndex = 0;
            // 
            // btExit
            // 
            this.btExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btExit.Location = new System.Drawing.Point(382, 418);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(106, 46);
            this.btExit.TabIndex = 7;
            this.btExit.Text = "Thoát";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // btUpdate
            // 
            this.btUpdate.Location = new System.Drawing.Point(259, 418);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(106, 46);
            this.btUpdate.TabIndex = 6;
            this.btUpdate.Text = "Cập nhật";
            this.btUpdate.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.txtReEnterPassWord);
            this.panel6.Controls.Add(this.lbReEnterPassWord);
            this.panel6.Location = new System.Drawing.Point(3, 335);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(488, 77);
            this.panel6.TabIndex = 5;
            // 
            // txtReEnterPassWord
            // 
            this.txtReEnterPassWord.Location = new System.Drawing.Point(193, 31);
            this.txtReEnterPassWord.Name = "txtReEnterPassWord";
            this.txtReEnterPassWord.Size = new System.Drawing.Size(271, 22);
            this.txtReEnterPassWord.TabIndex = 1;
            // 
            // lbReEnterPassWord
            // 
            this.lbReEnterPassWord.AutoSize = true;
            this.lbReEnterPassWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbReEnterPassWord.Location = new System.Drawing.Point(22, 27);
            this.lbReEnterPassWord.Name = "lbReEnterPassWord";
            this.lbReEnterPassWord.Size = new System.Drawing.Size(98, 25);
            this.lbReEnterPassWord.TabIndex = 0;
            this.lbReEnterPassWord.Text = "Nhập lại:";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txtNewPassWord);
            this.panel5.Controls.Add(this.lbNewPassWord);
            this.panel5.Location = new System.Drawing.Point(3, 252);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(488, 77);
            this.panel5.TabIndex = 3;
            // 
            // txtNewPassWord
            // 
            this.txtNewPassWord.Location = new System.Drawing.Point(193, 31);
            this.txtNewPassWord.Name = "txtNewPassWord";
            this.txtNewPassWord.Size = new System.Drawing.Size(271, 22);
            this.txtNewPassWord.TabIndex = 1;
            // 
            // lbNewPassWord
            // 
            this.lbNewPassWord.AutoSize = true;
            this.lbNewPassWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNewPassWord.Location = new System.Drawing.Point(22, 27);
            this.lbNewPassWord.Name = "lbNewPassWord";
            this.lbNewPassWord.Size = new System.Drawing.Size(148, 25);
            this.lbNewPassWord.TabIndex = 0;
            this.lbNewPassWord.Text = "Mật khẩu mới:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtPassword);
            this.panel4.Controls.Add(this.lbPassWord);
            this.panel4.Location = new System.Drawing.Point(3, 169);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(488, 77);
            this.panel4.TabIndex = 4;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(193, 31);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(271, 22);
            this.txtPassword.TabIndex = 1;
            // 
            // lbPassWord
            // 
            this.lbPassWord.AutoSize = true;
            this.lbPassWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPassWord.Location = new System.Drawing.Point(22, 27);
            this.lbPassWord.Name = "lbPassWord";
            this.lbPassWord.Size = new System.Drawing.Size(108, 25);
            this.lbPassWord.TabIndex = 0;
            this.lbPassWord.Text = "Mật khẩu:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtDisplayName);
            this.panel3.Controls.Add(this.lbDisplayName);
            this.panel3.Location = new System.Drawing.Point(3, 86);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(488, 77);
            this.panel3.TabIndex = 3;
            // 
            // txtDisplayName
            // 
            this.txtDisplayName.Location = new System.Drawing.Point(193, 31);
            this.txtDisplayName.Name = "txtDisplayName";
            this.txtDisplayName.Size = new System.Drawing.Size(271, 22);
            this.txtDisplayName.TabIndex = 1;
            // 
            // lbDisplayName
            // 
            this.lbDisplayName.AutoSize = true;
            this.lbDisplayName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDisplayName.Location = new System.Drawing.Point(22, 27);
            this.lbDisplayName.Name = "lbDisplayName";
            this.lbDisplayName.Size = new System.Drawing.Size(133, 25);
            this.lbDisplayName.TabIndex = 0;
            this.lbDisplayName.Text = "Tên hiển thị:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtUserName);
            this.panel2.Controls.Add(this.lbUserName);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(488, 77);
            this.panel2.TabIndex = 2;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(193, 31);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(271, 22);
            this.txtUserName.TabIndex = 1;
            // 
            // lbUserName
            // 
            this.lbUserName.AutoSize = true;
            this.lbUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserName.Location = new System.Drawing.Point(22, 27);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(165, 25);
            this.lbUserName.TabIndex = 0;
            this.lbUserName.Text = "Tên đăng nhập:";
            // 
            // fAccountProfile
            // 
            this.AcceptButton = this.btUpdate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btExit;
            this.ClientSize = new System.Drawing.Size(608, 527);
            this.Controls.Add(this.panel1);
            this.Name = "fAccountProfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AccountProfile";
            this.panel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txtReEnterPassWord;
        private System.Windows.Forms.Label lbReEnterPassWord;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtNewPassWord;
        private System.Windows.Forms.Label lbNewPassWord;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lbPassWord;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtDisplayName;
        private System.Windows.Forms.Label lbDisplayName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lbUserName;
        private System.Windows.Forms.Button btExit;
    }
}