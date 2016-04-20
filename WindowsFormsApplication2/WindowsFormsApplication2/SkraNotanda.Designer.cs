namespace WindowsFormsApplication2
{
    partial class SkraNotanda
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
            this.btSubmit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNotandanafn = new System.Windows.Forms.TextBox();
            this.tbLykilorð = new System.Windows.Forms.TextBox();
            this.cbNotandaRank = new System.Windows.Forms.ComboBox();
            this.lbNotandaRank = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btSubmit
            // 
            this.btSubmit.Location = new System.Drawing.Point(117, 196);
            this.btSubmit.Name = "btSubmit";
            this.btSubmit.Size = new System.Drawing.Size(157, 44);
            this.btSubmit.TabIndex = 0;
            this.btSubmit.Text = "Skrá";
            this.btSubmit.UseVisualStyleBackColor = true;
            this.btSubmit.Click += new System.EventHandler(this.btSubmit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Notandanafn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Lykilorð";
            // 
            // tbNotandanafn
            // 
            this.tbNotandanafn.Location = new System.Drawing.Point(147, 52);
            this.tbNotandanafn.Name = "tbNotandanafn";
            this.tbNotandanafn.Size = new System.Drawing.Size(100, 20);
            this.tbNotandanafn.TabIndex = 4;
            // 
            // tbLykilorð
            // 
            this.tbLykilorð.Location = new System.Drawing.Point(147, 115);
            this.tbLykilorð.Name = "tbLykilorð";
            this.tbLykilorð.Size = new System.Drawing.Size(100, 20);
            this.tbLykilorð.TabIndex = 5;
            // 
            // cbNotandaRank
            // 
            this.cbNotandaRank.FormattingEnabled = true;
            this.cbNotandaRank.Items.AddRange(new object[] {
            "User",
            "Moderator",
            "Administrator"});
            this.cbNotandaRank.Location = new System.Drawing.Point(138, 157);
            this.cbNotandaRank.Name = "cbNotandaRank";
            this.cbNotandaRank.Size = new System.Drawing.Size(121, 21);
            this.cbNotandaRank.TabIndex = 6;
            // 
            // lbNotandaRank
            // 
            this.lbNotandaRank.AutoSize = true;
            this.lbNotandaRank.Location = new System.Drawing.Point(40, 164);
            this.lbNotandaRank.Name = "lbNotandaRank";
            this.lbNotandaRank.Size = new System.Drawing.Size(75, 13);
            this.lbNotandaRank.TabIndex = 7;
            this.lbNotandaRank.Text = "Rank notanda";
            // 
            // SkraNotanda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 338);
            this.Controls.Add(this.lbNotandaRank);
            this.Controls.Add(this.cbNotandaRank);
            this.Controls.Add(this.tbLykilorð);
            this.Controls.Add(this.tbNotandanafn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btSubmit);
            this.Name = "SkraNotanda";
            this.Text = "SkraNotanda";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btSubmit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNotandanafn;
        private System.Windows.Forms.TextBox tbLykilorð;
        private System.Windows.Forms.ComboBox cbNotandaRank;
        private System.Windows.Forms.Label lbNotandaRank;
    }
}