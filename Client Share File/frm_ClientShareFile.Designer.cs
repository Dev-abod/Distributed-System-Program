namespace Client_Share_File
{
    partial class frm_ClientShareFile
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
            this.btn_GetFile = new System.Windows.Forms.Button();
            this.txt_GetFile = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_GetFile
            // 
            this.btn_GetFile.Location = new System.Drawing.Point(23, 32);
            this.btn_GetFile.Name = "btn_GetFile";
            this.btn_GetFile.Size = new System.Drawing.Size(106, 34);
            this.btn_GetFile.TabIndex = 0;
            this.btn_GetFile.Text = "Get File";
            this.btn_GetFile.UseVisualStyleBackColor = true;
            this.btn_GetFile.Click += new System.EventHandler(this.btn_GetFile_Click);
            // 
            // txt_GetFile
            // 
            this.txt_GetFile.Location = new System.Drawing.Point(152, 32);
            this.txt_GetFile.Multiline = true;
            this.txt_GetFile.Name = "txt_GetFile";
            this.txt_GetFile.Size = new System.Drawing.Size(331, 34);
            this.txt_GetFile.TabIndex = 1;
            // 
            // frm_ClientShareFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 98);
            this.Controls.Add(this.txt_GetFile);
            this.Controls.Add(this.btn_GetFile);
            this.Name = "frm_ClientShareFile";
            this.Text = "Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_GetFile;
        private System.Windows.Forms.TextBox txt_GetFile;
    }
}

