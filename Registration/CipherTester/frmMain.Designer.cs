namespace CipherTester
{
    partial class frmMain
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCipher = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDaysLeft = new System.Windows.Forms.TextBox();
            this.btnCipher = new System.Windows.Forms.Button();
            this.btnCipherCheck = new System.Windows.Forms.Button();
            this.btnCipherDate = new System.Windows.Forms.Button();
            this.btnGetLeftDays = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(56, 9);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(304, 20);
            this.txtName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Key:";
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(56, 38);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(304, 20);
            this.txtKey.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Cipher:";
            // 
            // txtCipher
            // 
            this.txtCipher.Location = new System.Drawing.Point(56, 69);
            this.txtCipher.Name = "txtCipher";
            this.txtCipher.Size = new System.Drawing.Size(304, 20);
            this.txtCipher.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Days Left:";
            // 
            // txtDaysLeft
            // 
            this.txtDaysLeft.Location = new System.Drawing.Point(96, 95);
            this.txtDaysLeft.Name = "txtDaysLeft";
            this.txtDaysLeft.Size = new System.Drawing.Size(264, 20);
            this.txtDaysLeft.TabIndex = 6;
            // 
            // btnCipher
            // 
            this.btnCipher.Location = new System.Drawing.Point(15, 131);
            this.btnCipher.Name = "btnCipher";
            this.btnCipher.Size = new System.Drawing.Size(75, 23);
            this.btnCipher.TabIndex = 8;
            this.btnCipher.Text = "Cipher";
            this.btnCipher.UseVisualStyleBackColor = true;
            this.btnCipher.Click += new System.EventHandler(this.btnCipher_Click);
            // 
            // btnCipherCheck
            // 
            this.btnCipherCheck.Location = new System.Drawing.Point(96, 131);
            this.btnCipherCheck.Name = "btnCipherCheck";
            this.btnCipherCheck.Size = new System.Drawing.Size(75, 23);
            this.btnCipherCheck.TabIndex = 9;
            this.btnCipherCheck.Text = "Check";
            this.btnCipherCheck.UseVisualStyleBackColor = true;
            this.btnCipherCheck.Click += new System.EventHandler(this.btnCipherCheck_Click);
            // 
            // btnCipherDate
            // 
            this.btnCipherDate.Location = new System.Drawing.Point(177, 131);
            this.btnCipherDate.Name = "btnCipherDate";
            this.btnCipherDate.Size = new System.Drawing.Size(75, 23);
            this.btnCipherDate.TabIndex = 10;
            this.btnCipherDate.Text = "Cipher Date";
            this.btnCipherDate.UseVisualStyleBackColor = true;
            this.btnCipherDate.Click += new System.EventHandler(this.btnCipherDate_Click);
            // 
            // btnGetLeftDays
            // 
            this.btnGetLeftDays.Location = new System.Drawing.Point(258, 131);
            this.btnGetLeftDays.Name = "btnGetLeftDays";
            this.btnGetLeftDays.Size = new System.Drawing.Size(75, 23);
            this.btnGetLeftDays.TabIndex = 11;
            this.btnGetLeftDays.Text = "Date Check";
            this.btnGetLeftDays.UseVisualStyleBackColor = true;
            this.btnGetLeftDays.Click += new System.EventHandler(this.btnGetLeftDays_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 171);
            this.Controls.Add(this.btnGetLeftDays);
            this.Controls.Add(this.btnCipherDate);
            this.Controls.Add(this.btnCipherCheck);
            this.Controls.Add(this.btnCipher);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDaysLeft);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCipher);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chiper Test Tool";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCipher;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDaysLeft;
        private System.Windows.Forms.Button btnCipher;
        private System.Windows.Forms.Button btnCipherCheck;
        private System.Windows.Forms.Button btnCipherDate;
        private System.Windows.Forms.Button btnGetLeftDays;
    }
}

