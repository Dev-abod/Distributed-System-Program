namespace Thread_Project
{
    partial class frm_Thread
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
            this.btn_StartCount = new System.Windows.Forms.Button();
            this.txt_StartNumber = new System.Windows.Forms.TextBox();
            this.lbl_Count = new System.Windows.Forms.Label();
            this.btn_StartCountFrom = new System.Windows.Forms.Button();
            this.btn_Kill = new System.Windows.Forms.Button();
            this.btn_AbortStartCountThread = new System.Windows.Forms.Button();
            this.btn_AbortAllStartFromThread = new System.Windows.Forms.Button();
            this.btn_Lambda = new System.Windows.Forms.Button();
            this.btn_StartCount_NoThread = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_StartCount
            // 
            this.btn_StartCount.Location = new System.Drawing.Point(12, 77);
            this.btn_StartCount.Name = "btn_StartCount";
            this.btn_StartCount.Size = new System.Drawing.Size(140, 23);
            this.btn_StartCount.TabIndex = 0;
            this.btn_StartCount.Text = "Start Count";
            this.btn_StartCount.UseVisualStyleBackColor = true;
            this.btn_StartCount.Click += new System.EventHandler(this.btn_StartCount_Click);
            // 
            // txt_StartNumber
            // 
            this.txt_StartNumber.Location = new System.Drawing.Point(179, 62);
            this.txt_StartNumber.Name = "txt_StartNumber";
            this.txt_StartNumber.Size = new System.Drawing.Size(100, 20);
            this.txt_StartNumber.TabIndex = 1;
            // 
            // lbl_Count
            // 
            this.lbl_Count.AutoSize = true;
            this.lbl_Count.Location = new System.Drawing.Point(223, 36);
            this.lbl_Count.Name = "lbl_Count";
            this.lbl_Count.Size = new System.Drawing.Size(13, 13);
            this.lbl_Count.TabIndex = 2;
            this.lbl_Count.Text = "0";
            // 
            // btn_StartCountFrom
            // 
            this.btn_StartCountFrom.Location = new System.Drawing.Point(12, 114);
            this.btn_StartCountFrom.Name = "btn_StartCountFrom";
            this.btn_StartCountFrom.Size = new System.Drawing.Size(140, 23);
            this.btn_StartCountFrom.TabIndex = 3;
            this.btn_StartCountFrom.Text = "Start Count From";
            this.btn_StartCountFrom.UseVisualStyleBackColor = true;
            this.btn_StartCountFrom.Click += new System.EventHandler(this.btn_StartCountFrom_Click);
            // 
            // btn_Kill
            // 
            this.btn_Kill.Location = new System.Drawing.Point(12, 151);
            this.btn_Kill.Name = "btn_Kill";
            this.btn_Kill.Size = new System.Drawing.Size(140, 23);
            this.btn_Kill.TabIndex = 4;
            this.btn_Kill.Text = "Kill";
            this.btn_Kill.UseVisualStyleBackColor = true;
            this.btn_Kill.Click += new System.EventHandler(this.btn_Kill_Click);
            // 
            // btn_AbortStartCountThread
            // 
            this.btn_AbortStartCountThread.Location = new System.Drawing.Point(12, 188);
            this.btn_AbortStartCountThread.Name = "btn_AbortStartCountThread";
            this.btn_AbortStartCountThread.Size = new System.Drawing.Size(140, 23);
            this.btn_AbortStartCountThread.TabIndex = 5;
            this.btn_AbortStartCountThread.Text = "Abort Start Count Thread";
            this.btn_AbortStartCountThread.UseVisualStyleBackColor = true;
            this.btn_AbortStartCountThread.Click += new System.EventHandler(this.btn_AbortStartCountThread_Click);
            // 
            // btn_AbortAllStartFromThread
            // 
            this.btn_AbortAllStartFromThread.Location = new System.Drawing.Point(12, 225);
            this.btn_AbortAllStartFromThread.Name = "btn_AbortAllStartFromThread";
            this.btn_AbortAllStartFromThread.Size = new System.Drawing.Size(140, 23);
            this.btn_AbortAllStartFromThread.TabIndex = 6;
            this.btn_AbortAllStartFromThread.Text = "Abort All Start From Thread";
            this.btn_AbortAllStartFromThread.UseVisualStyleBackColor = true;
            this.btn_AbortAllStartFromThread.Click += new System.EventHandler(this.btn_AbortAllStartFromThread_Click);
            // 
            // btn_Lambda
            // 
            this.btn_Lambda.Location = new System.Drawing.Point(12, 262);
            this.btn_Lambda.Name = "btn_Lambda";
            this.btn_Lambda.Size = new System.Drawing.Size(140, 23);
            this.btn_Lambda.TabIndex = 7;
            this.btn_Lambda.Text = "Lambda";
            this.btn_Lambda.UseVisualStyleBackColor = true;
            this.btn_Lambda.Click += new System.EventHandler(this.btn_Lambda_Click);
            // 
            // btn_StartCount_NoThread
            // 
            this.btn_StartCount_NoThread.Location = new System.Drawing.Point(12, 41);
            this.btn_StartCount_NoThread.Name = "btn_StartCount_NoThread";
            this.btn_StartCount_NoThread.Size = new System.Drawing.Size(140, 23);
            this.btn_StartCount_NoThread.TabIndex = 8;
            this.btn_StartCount_NoThread.Text = "Start Count No Thread";
            this.btn_StartCount_NoThread.UseVisualStyleBackColor = true;
            this.btn_StartCount_NoThread.Click += new System.EventHandler(this.btn_StartCount_NoThread_Click);
            // 
            // frm_Thread
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 310);
            this.Controls.Add(this.btn_StartCount_NoThread);
            this.Controls.Add(this.btn_Lambda);
            this.Controls.Add(this.btn_AbortAllStartFromThread);
            this.Controls.Add(this.btn_AbortStartCountThread);
            this.Controls.Add(this.btn_Kill);
            this.Controls.Add(this.btn_StartCountFrom);
            this.Controls.Add(this.lbl_Count);
            this.Controls.Add(this.txt_StartNumber);
            this.Controls.Add(this.btn_StartCount);
            this.Name = "frm_Thread";
            this.Text = "Thread";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_StartCount;
        private System.Windows.Forms.TextBox txt_StartNumber;
        private System.Windows.Forms.Label lbl_Count;
        private System.Windows.Forms.Button btn_StartCountFrom;
        private System.Windows.Forms.Button btn_Kill;
        private System.Windows.Forms.Button btn_AbortStartCountThread;
        private System.Windows.Forms.Button btn_AbortAllStartFromThread;
        private System.Windows.Forms.Button btn_Lambda;
        private System.Windows.Forms.Button btn_StartCount_NoThread;
    }
}

