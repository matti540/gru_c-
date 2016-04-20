namespace WindowsFormsApplication2
{
    partial class Form2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listViewNotendur = new System.Windows.Forms.ListView();
            this.btBanna = new System.Windows.Forms.Button();
            this.btBreytaUpplysingum = new System.Windows.Forms.Button();
            this.btUnban = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listViewNotendur);
            this.groupBox1.Location = new System.Drawing.Point(74, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(610, 401);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Notendur";
            // 
            // listViewNotendur
            // 
            this.listViewNotendur.FullRowSelect = true;
            this.listViewNotendur.GridLines = true;
            this.listViewNotendur.Location = new System.Drawing.Point(17, 20);
            this.listViewNotendur.Name = "listViewNotendur";
            this.listViewNotendur.Size = new System.Drawing.Size(587, 375);
            this.listViewNotendur.TabIndex = 0;
            this.listViewNotendur.UseCompatibleStateImageBehavior = false;
            this.listViewNotendur.View = System.Windows.Forms.View.Details;
            this.listViewNotendur.SelectedIndexChanged += new System.EventHandler(this.listViewNotendur_SelectedIndexChanged);
            // 
            // btBanna
            // 
            this.btBanna.Location = new System.Drawing.Point(404, 433);
            this.btBanna.Name = "btBanna";
            this.btBanna.Size = new System.Drawing.Size(112, 23);
            this.btBanna.TabIndex = 1;
            this.btBanna.Text = "Banna";
            this.btBanna.UseVisualStyleBackColor = true;
            this.btBanna.Click += new System.EventHandler(this.btBanna_Click);
            // 
            // btBreytaUpplysingum
            // 
            this.btBreytaUpplysingum.Location = new System.Drawing.Point(522, 433);
            this.btBreytaUpplysingum.Name = "btBreytaUpplysingum";
            this.btBreytaUpplysingum.Size = new System.Drawing.Size(112, 23);
            this.btBreytaUpplysingum.TabIndex = 3;
            this.btBreytaUpplysingum.Text = "Breyta";
            this.btBreytaUpplysingum.UseVisualStyleBackColor = true;
            this.btBreytaUpplysingum.Click += new System.EventHandler(this.btBreytaUpplysingum_Click);
            // 
            // btUnban
            // 
            this.btUnban.Location = new System.Drawing.Point(285, 433);
            this.btUnban.Name = "btUnban";
            this.btUnban.Size = new System.Drawing.Size(112, 23);
            this.btUnban.TabIndex = 4;
            this.btUnban.Text = "Aflétta banni";
            this.btUnban.UseVisualStyleBackColor = true;
            this.btUnban.Click += new System.EventHandler(this.btUnban_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 530);
            this.Controls.Add(this.btUnban);
            this.Controls.Add(this.btBreytaUpplysingum);
            this.Controls.Add(this.btBanna);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btBanna;
        private System.Windows.Forms.Button btBreytaUpplysingum;
        private System.Windows.Forms.ListView listViewNotendur;
        private System.Windows.Forms.Button btUnban;
    }
}