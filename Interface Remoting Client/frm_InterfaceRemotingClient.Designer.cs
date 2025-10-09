namespace Interface_Remoting_Client
{
    partial class frm_InterfaceRemotingClient
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
            this.btn_Add = new System.Windows.Forms.Button();
            this.txt_Num1 = new System.Windows.Forms.TextBox();
            this.txt_Num2 = new System.Windows.Forms.TextBox();
            this.tn_Sub = new System.Windows.Forms.Button();
            this.btn_Mul = new System.Windows.Forms.Button();
            this.btn_Div = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(44, 63);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 23);
            this.btn_Add.TabIndex = 0;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            // 
            // txt_Num1
            // 
            this.txt_Num1.Location = new System.Drawing.Point(44, 111);
            this.txt_Num1.Name = "txt_Num1";
            this.txt_Num1.Size = new System.Drawing.Size(341, 20);
            this.txt_Num1.TabIndex = 1;
            // 
            // txt_Num2
            // 
            this.txt_Num2.Location = new System.Drawing.Point(44, 154);
            this.txt_Num2.Name = "txt_Num2";
            this.txt_Num2.Size = new System.Drawing.Size(341, 20);
            this.txt_Num2.TabIndex = 2;
            // 
            // tn_Sub
            // 
            this.tn_Sub.Location = new System.Drawing.Point(132, 63);
            this.tn_Sub.Name = "tn_Sub";
            this.tn_Sub.Size = new System.Drawing.Size(75, 23);
            this.tn_Sub.TabIndex = 3;
            this.tn_Sub.Text = "Sub";
            this.tn_Sub.UseVisualStyleBackColor = true;
            // 
            // btn_Mul
            // 
            this.btn_Mul.Location = new System.Drawing.Point(220, 63);
            this.btn_Mul.Name = "btn_Mul";
            this.btn_Mul.Size = new System.Drawing.Size(75, 23);
            this.btn_Mul.TabIndex = 4;
            this.btn_Mul.Text = "Mul";
            this.btn_Mul.UseVisualStyleBackColor = true;
            this.btn_Mul.Click += new System.EventHandler(this.btn_Mul_Click);
            // 
            // btn_Div
            // 
            this.btn_Div.Location = new System.Drawing.Point(308, 63);
            this.btn_Div.Name = "btn_Div";
            this.btn_Div.Size = new System.Drawing.Size(75, 23);
            this.btn_Div.TabIndex = 5;
            this.btn_Div.Text = "Div";
            this.btn_Div.UseVisualStyleBackColor = true;
            this.btn_Div.Click += new System.EventHandler(this.btn_Div_Click);
            // 
            // frm_InterfaceRemotingClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 217);
            this.Controls.Add(this.btn_Div);
            this.Controls.Add(this.btn_Mul);
            this.Controls.Add(this.tn_Sub);
            this.Controls.Add(this.txt_Num2);
            this.Controls.Add(this.txt_Num1);
            this.Controls.Add(this.btn_Add);
            this.Name = "frm_InterfaceRemotingClient";
            this.Text = "Client";
            this.Load += new System.EventHandler(this.frm_InterfaceRemotingClient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.TextBox txt_Num1;
        private System.Windows.Forms.TextBox txt_Num2;
        private System.Windows.Forms.Button tn_Sub;
        private System.Windows.Forms.Button btn_Mul;
        private System.Windows.Forms.Button btn_Div;
    }
}

