namespace Server_Multi_Client_Multi_Messages
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
            this.lstMessage = new System.Windows.Forms.ListBox();
            this.btn_Accept = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstMessage
            // 
            this.lstMessage.FormattingEnabled = true;
            this.lstMessage.Location = new System.Drawing.Point(122, 13);
            this.lstMessage.Name = "lstMessage";
            this.lstMessage.Size = new System.Drawing.Size(278, 212);
            this.lstMessage.TabIndex = 3;
            // 
            // btn_Accept
            // 
            this.btn_Accept.Location = new System.Drawing.Point(12, 194);
            this.btn_Accept.Name = "btn_Accept";
            this.btn_Accept.Size = new System.Drawing.Size(92, 31);
            this.btn_Accept.TabIndex = 2;
            this.btn_Accept.Text = "Accept";
            this.btn_Accept.UseVisualStyleBackColor = true;
            this.btn_Accept.Click += new System.EventHandler(this.btn_Accept_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 239);
            this.Controls.Add(this.lstMessage);
            this.Controls.Add(this.btn_Accept);
            this.Name = "Form1";
            this.Text = "Server Multi Client Multi Messages";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstMessage;
        private System.Windows.Forms.Button btn_Accept;
    }
}

