namespace Proccess_Project
{
    partial class frm_Proccess
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
            this.btn_currentProccess = new System.Windows.Forms.Button();
            this.btn_KillProccess = new System.Windows.Forms.Button();
            this.btn_AllProccesses = new System.Windows.Forms.Button();
            this.btn_KillSelected = new System.Windows.Forms.Button();
            this.btn_Start = new System.Windows.Forms.Button();
            this.lst_Proccesses = new System.Windows.Forms.ListBox();
            this.txt_ProccessName = new System.Windows.Forms.TextBox();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_currentProccess
            // 
            this.btn_currentProccess.Location = new System.Drawing.Point(29, 77);
            this.btn_currentProccess.Name = "btn_currentProccess";
            this.btn_currentProccess.Size = new System.Drawing.Size(95, 23);
            this.btn_currentProccess.TabIndex = 0;
            this.btn_currentProccess.Text = "current Proccess";
            this.btn_currentProccess.UseVisualStyleBackColor = true;
            this.btn_currentProccess.Click += new System.EventHandler(this.btn_currentProccess_Click);
            // 
            // btn_KillProccess
            // 
            this.btn_KillProccess.Location = new System.Drawing.Point(29, 106);
            this.btn_KillProccess.Name = "btn_KillProccess";
            this.btn_KillProccess.Size = new System.Drawing.Size(95, 23);
            this.btn_KillProccess.TabIndex = 1;
            this.btn_KillProccess.Text = "Kill Proccess";
            this.btn_KillProccess.UseVisualStyleBackColor = true;
            this.btn_KillProccess.Click += new System.EventHandler(this.btn_KillProccess_Click);
            // 
            // btn_AllProccesses
            // 
            this.btn_AllProccesses.Location = new System.Drawing.Point(29, 135);
            this.btn_AllProccesses.Name = "btn_AllProccesses";
            this.btn_AllProccesses.Size = new System.Drawing.Size(95, 23);
            this.btn_AllProccesses.TabIndex = 2;
            this.btn_AllProccesses.Text = "All Proccesses";
            this.btn_AllProccesses.UseVisualStyleBackColor = true;
            this.btn_AllProccesses.Click += new System.EventHandler(this.btn_AllProccesses_Click);
            // 
            // btn_KillSelected
            // 
            this.btn_KillSelected.Location = new System.Drawing.Point(29, 164);
            this.btn_KillSelected.Name = "btn_KillSelected";
            this.btn_KillSelected.Size = new System.Drawing.Size(95, 23);
            this.btn_KillSelected.TabIndex = 3;
            this.btn_KillSelected.Text = "Kill Selected";
            this.btn_KillSelected.UseVisualStyleBackColor = true;
            this.btn_KillSelected.Click += new System.EventHandler(this.btn_KillSelected_Click);
            // 
            // btn_Start
            // 
            this.btn_Start.Location = new System.Drawing.Point(29, 245);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(95, 23);
            this.btn_Start.TabIndex = 4;
            this.btn_Start.Text = "Start";
            this.btn_Start.UseVisualStyleBackColor = true;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // lst_Proccesses
            // 
            this.lst_Proccesses.FormattingEnabled = true;
            this.lst_Proccesses.Location = new System.Drawing.Point(142, 76);
            this.lst_Proccesses.Name = "lst_Proccesses";
            this.lst_Proccesses.Size = new System.Drawing.Size(355, 147);
            this.lst_Proccesses.TabIndex = 5;
            // 
            // txt_ProccessName
            // 
            this.txt_ProccessName.Location = new System.Drawing.Point(142, 244);
            this.txt_ProccessName.Name = "txt_ProccessName";
            this.txt_ProccessName.Size = new System.Drawing.Size(355, 20);
            this.txt_ProccessName.TabIndex = 6;
            // 
            // txt_Search
            // 
            this.txt_Search.Location = new System.Drawing.Point(205, 31);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(292, 20);
            this.txt_Search.TabIndex = 7;
         //   this.txt_Search.TextChanged += new System.EventHandler(this.txt_Search_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(148, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Search";
            // 
            // frm_Proccess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 291);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Search);
            this.Controls.Add(this.txt_ProccessName);
            this.Controls.Add(this.lst_Proccesses);
            this.Controls.Add(this.btn_Start);
            this.Controls.Add(this.btn_KillSelected);
            this.Controls.Add(this.btn_AllProccesses);
            this.Controls.Add(this.btn_KillProccess);
            this.Controls.Add(this.btn_currentProccess);
            this.Name = "frm_Proccess";
            this.Text = "Proccess";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_currentProccess;
        private System.Windows.Forms.Button btn_KillProccess;
        private System.Windows.Forms.Button btn_AllProccesses;
        private System.Windows.Forms.Button btn_KillSelected;
        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.ListBox lst_Proccesses;
        private System.Windows.Forms.TextBox txt_ProccessName;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.Label label1;
    }
}

