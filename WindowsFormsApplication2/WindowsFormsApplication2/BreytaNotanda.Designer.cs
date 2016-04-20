namespace WindowsFormsApplication2
{
    partial class BreytaNotanda
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
            this.tbNotandanafn = new System.Windows.Forms.TextBox();
            this.tbLykilord = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbrank = new System.Windows.Forms.ComboBox();
            this.btSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Notandi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lykilorð";
            // 
            // tbNotandanafn
            // 
            this.tbNotandanafn.Location = new System.Drawing.Point(133, 54);
            this.tbNotandanafn.Name = "tbNotandanafn";
            this.tbNotandanafn.Size = new System.Drawing.Size(118, 20);
            this.tbNotandanafn.TabIndex = 2;
            // 
            // tbLykilord
            // 
            this.tbLykilord.Location = new System.Drawing.Point(133, 104);
            this.tbLykilord.Name = "tbLykilord";
            this.tbLykilord.Size = new System.Drawing.Size(118, 20);
            this.tbLykilord.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Rank";
            // 
            // cbrank
            // 
            this.cbrank.FormattingEnabled = true;
            this.cbrank.Items.AddRange(new object[] {
            "User",
            "Moderator",
            "Administrator"});
            this.cbrank.Location = new System.Drawing.Point(133, 156);
            this.cbrank.Name = "cbrank";
            this.cbrank.Size = new System.Drawing.Size(118, 21);
            this.cbrank.TabIndex = 5;
            // 
            // btSubmit
            // 
            this.btSubmit.Location = new System.Drawing.Point(85, 214);
            this.btSubmit.Name = "btSubmit";
            this.btSubmit.Size = new System.Drawing.Size(165, 43);
            this.btSubmit.TabIndex = 6;
            this.btSubmit.Text = "Breyta upplýsingum";
            this.btSubmit.UseVisualStyleBackColor = true;
            this.btSubmit.Click += new System.EventHandler(this.btSubmit_Click);
            // 
            // BreytaNotanda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 311);
            this.Controls.Add(this.btSubmit);
            this.Controls.Add(this.cbrank);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbLykilord);
            this.Controls.Add(this.tbNotandanafn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "BreytaNotanda";
            this.Text = "BreytaNotanda";
            this.Load += new System.EventHandler(this.BreytaNotanda_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNotandanafn;
        private System.Windows.Forms.TextBox tbLykilord;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbrank;
        private System.Windows.Forms.Button btSubmit;
    }
}