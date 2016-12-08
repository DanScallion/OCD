namespace OCD
{
    partial class InGame
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
            this.btnLogOut = new System.Windows.Forms.Button();
            this.lbErrorOrMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(232, 331);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(75, 23);
            this.btnLogOut.TabIndex = 0;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // lbErrorOrMessage
            // 
            this.lbErrorOrMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbErrorOrMessage.AutoSize = true;
            this.lbErrorOrMessage.BackColor = System.Drawing.Color.Black;
            this.lbErrorOrMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbErrorOrMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbErrorOrMessage.ForeColor = System.Drawing.Color.White;
            this.lbErrorOrMessage.Location = new System.Drawing.Point(79, 9);
            this.lbErrorOrMessage.MaximumSize = new System.Drawing.Size(340, 100);
            this.lbErrorOrMessage.MinimumSize = new System.Drawing.Size(340, 25);
            this.lbErrorOrMessage.Name = "lbErrorOrMessage";
            this.lbErrorOrMessage.Size = new System.Drawing.Size(340, 27);
            this.lbErrorOrMessage.TabIndex = 10;
            this.lbErrorOrMessage.Text = "Error and Messages appear here";
            this.lbErrorOrMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 372);
            this.Controls.Add(this.lbErrorOrMessage);
            this.Controls.Add(this.btnLogOut);
            this.Name = "InGame";
            this.Text = "InGame";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Label lbErrorOrMessage;
    }
}