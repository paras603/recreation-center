namespace RecreationCenter
{
    partial class StaffLogin
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.staffUsername = new System.Windows.Forms.TextBox();
            this.staffPassword = new System.Windows.Forms.TextBox();
            this.staffLoginBtn = new System.Windows.Forms.Button();
            this.staffExitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(162, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Staff Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(114, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(252, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Recreation Center";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(101, 367);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "User Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(101, 421);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Password";
            // 
            // staffUsername
            // 
            this.staffUsername.Location = new System.Drawing.Point(231, 367);
            this.staffUsername.Name = "staffUsername";
            this.staffUsername.Size = new System.Drawing.Size(126, 20);
            this.staffUsername.TabIndex = 4;
            this.staffUsername.TextChanged += new System.EventHandler(this.staffUsername_TextChanged);
            // 
            // staffPassword
            // 
            this.staffPassword.Location = new System.Drawing.Point(231, 421);
            this.staffPassword.Name = "staffPassword";
            this.staffPassword.Size = new System.Drawing.Size(126, 20);
            this.staffPassword.TabIndex = 5;
            this.staffPassword.UseSystemPasswordChar = true;
            // 
            // staffLoginBtn
            // 
            this.staffLoginBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffLoginBtn.Location = new System.Drawing.Point(120, 487);
            this.staffLoginBtn.Name = "staffLoginBtn";
            this.staffLoginBtn.Size = new System.Drawing.Size(87, 32);
            this.staffLoginBtn.TabIndex = 6;
            this.staffLoginBtn.Text = "Login";
            this.staffLoginBtn.UseVisualStyleBackColor = true;
            this.staffLoginBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // staffExitBtn
            // 
            this.staffExitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffExitBtn.Location = new System.Drawing.Point(231, 487);
            this.staffExitBtn.Name = "staffExitBtn";
            this.staffExitBtn.Size = new System.Drawing.Size(87, 32);
            this.staffExitBtn.TabIndex = 7;
            this.staffExitBtn.Text = "Exit";
            this.staffExitBtn.UseVisualStyleBackColor = true;
            this.staffExitBtn.Click += new System.EventHandler(this.staffLoginExit_Click);
            // 
            // StaffLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 624);
            this.Controls.Add(this.staffExitBtn);
            this.Controls.Add(this.staffLoginBtn);
            this.Controls.Add(this.staffPassword);
            this.Controls.Add(this.staffUsername);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "StaffLogin";
            this.Text = "StaffLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox staffUsername;
        private System.Windows.Forms.TextBox staffPassword;
        private System.Windows.Forms.Button staffLoginBtn;
        private System.Windows.Forms.Button staffExitBtn;
    }
}