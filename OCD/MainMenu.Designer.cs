namespace OCD
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.loginName = new System.Windows.Forms.TextBox();
            this.loginPass = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.gbSignIn = new System.Windows.Forms.GroupBox();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.btnCreateAccount = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gbCreateAccount = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.registerPass2 = new System.Windows.Forms.TextBox();
            this.registerPass = new System.Windows.Forms.TextBox();
            this.registerName = new System.Windows.Forms.TextBox();
            this.btnCreateAccount2 = new System.Windows.Forms.Button();
            this.lbErrorOrMessage = new System.Windows.Forms.Label();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbSignIn.SuspendLayout();
            this.gbCreateAccount.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(102, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(384, 96);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // loginName
            // 
            this.loginName.Location = new System.Drawing.Point(48, 35);
            this.loginName.Name = "loginName";
            this.loginName.Size = new System.Drawing.Size(100, 20);
            this.loginName.TabIndex = 1;
            // 
            // loginPass
            // 
            this.loginPass.Location = new System.Drawing.Point(48, 70);
            this.loginPass.Name = "loginPass";
            this.loginPass.Size = new System.Drawing.Size(100, 20);
            this.loginPass.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(117, 433);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // gbSignIn
            // 
            this.gbSignIn.Controls.Add(this.btnSignIn);
            this.gbSignIn.Controls.Add(this.btnCreateAccount);
            this.gbSignIn.Controls.Add(this.loginName);
            this.gbSignIn.Controls.Add(this.loginPass);
            this.gbSignIn.Location = new System.Drawing.Point(194, 224);
            this.gbSignIn.Name = "gbSignIn";
            this.gbSignIn.Size = new System.Drawing.Size(200, 174);
            this.gbSignIn.TabIndex = 6;
            this.gbSignIn.TabStop = false;
            this.gbSignIn.Text = "Sign in";
            // 
            // btnSignIn
            // 
            this.btnSignIn.Location = new System.Drawing.Point(60, 106);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(75, 23);
            this.btnSignIn.TabIndex = 7;
            this.btnSignIn.Text = "Sign in";
            this.btnSignIn.UseVisualStyleBackColor = true;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // btnCreateAccount
            // 
            this.btnCreateAccount.Location = new System.Drawing.Point(39, 135);
            this.btnCreateAccount.Name = "btnCreateAccount";
            this.btnCreateAccount.Size = new System.Drawing.Size(119, 23);
            this.btnCreateAccount.TabIndex = 7;
            this.btnCreateAccount.Text = "Create Account";
            this.btnCreateAccount.UseVisualStyleBackColor = true;
            this.btnCreateAccount.Click += new System.EventHandler(this.btnCreateAccount_Click);
            // 
            // gbCreateAccount
            // 
            this.gbCreateAccount.Controls.Add(this.label3);
            this.gbCreateAccount.Controls.Add(this.label2);
            this.gbCreateAccount.Controls.Add(this.label1);
            this.gbCreateAccount.Controls.Add(this.registerPass2);
            this.gbCreateAccount.Controls.Add(this.registerPass);
            this.gbCreateAccount.Controls.Add(this.registerName);
            this.gbCreateAccount.Controls.Add(this.btnCreateAccount2);
            this.gbCreateAccount.Location = new System.Drawing.Point(161, 228);
            this.gbCreateAccount.Name = "gbCreateAccount";
            this.gbCreateAccount.Size = new System.Drawing.Size(265, 170);
            this.gbCreateAccount.TabIndex = 8;
            this.gbCreateAccount.TabStop = false;
            this.gbCreateAccount.Text = "Create Account";
            this.gbCreateAccount.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Verify Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Login:";
            // 
            // registerPass2
            // 
            this.registerPass2.Location = new System.Drawing.Point(111, 104);
            this.registerPass2.Name = "registerPass2";
            this.registerPass2.Size = new System.Drawing.Size(135, 20);
            this.registerPass2.TabIndex = 3;
            // 
            // registerPass
            // 
            this.registerPass.Location = new System.Drawing.Point(111, 66);
            this.registerPass.Name = "registerPass";
            this.registerPass.Size = new System.Drawing.Size(135, 20);
            this.registerPass.TabIndex = 2;
            // 
            // registerName
            // 
            this.registerName.Location = new System.Drawing.Point(111, 31);
            this.registerName.Name = "registerName";
            this.registerName.Size = new System.Drawing.Size(135, 20);
            this.registerName.TabIndex = 1;
            // 
            // btnCreateAccount2
            // 
            this.btnCreateAccount2.Location = new System.Drawing.Point(76, 141);
            this.btnCreateAccount2.Name = "btnCreateAccount2";
            this.btnCreateAccount2.Size = new System.Drawing.Size(109, 23);
            this.btnCreateAccount2.TabIndex = 0;
            this.btnCreateAccount2.Text = "Create Account";
            this.btnCreateAccount2.UseVisualStyleBackColor = true;
            this.btnCreateAccount2.Click += new System.EventHandler(this.btnCreateAccount2_Click);
            // 
            // lbErrorOrMessage
            // 
            this.lbErrorOrMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbErrorOrMessage.AutoSize = true;
            this.lbErrorOrMessage.BackColor = System.Drawing.Color.Black;
            this.lbErrorOrMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbErrorOrMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbErrorOrMessage.ForeColor = System.Drawing.Color.White;
            this.lbErrorOrMessage.Location = new System.Drawing.Point(128, 126);
            this.lbErrorOrMessage.MaximumSize = new System.Drawing.Size(340, 100);
            this.lbErrorOrMessage.MinimumSize = new System.Drawing.Size(340, 25);
            this.lbErrorOrMessage.Name = "lbErrorOrMessage";
            this.lbErrorOrMessage.Size = new System.Drawing.Size(340, 27);
            this.lbErrorOrMessage.TabIndex = 9;
            this.lbErrorOrMessage.Text = "Error and Messages appear here";
            this.lbErrorOrMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbErrorOrMessage.Visible = false;
            // 
            // MainMenu
            // 
            this.AcceptButton = this.btnSignIn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 410);
            this.Controls.Add(this.lbErrorOrMessage);
            this.Controls.Add(this.gbCreateAccount);
            this.Controls.Add(this.gbSignIn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MainMenu";
            this.Text = "Odd Console Dungeon - Main Menu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbSignIn.ResumeLayout(false);
            this.gbSignIn.PerformLayout();
            this.gbCreateAccount.ResumeLayout(false);
            this.gbCreateAccount.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox loginName;
        private System.Windows.Forms.TextBox loginPass;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox gbSignIn;
        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.Button btnCreateAccount;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox gbCreateAccount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox registerPass2;
        private System.Windows.Forms.TextBox registerPass;
        private System.Windows.Forms.TextBox registerName;
        private System.Windows.Forms.Button btnCreateAccount2;
        private System.Windows.Forms.Label lbErrorOrMessage;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
    }
}

