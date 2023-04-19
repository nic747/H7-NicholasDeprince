namespace H7_NicholasDeprince
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
            this.DeprinceNicholas = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.test3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DeprinceNicholas
            // 
            this.DeprinceNicholas.Location = new System.Drawing.Point(488, 149);
            this.DeprinceNicholas.Name = "DeprinceNicholas";
            this.DeprinceNicholas.Size = new System.Drawing.Size(134, 199);
            this.DeprinceNicholas.TabIndex = 0;
            this.DeprinceNicholas.Text = "DeprinceNicholas";
            this.DeprinceNicholas.UseVisualStyleBackColor = true;
            this.DeprinceNicholas.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(488, 354);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 31);
            this.button1.TabIndex = 1;
            this.button1.Text = "test nicholas";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // test3
            // 
            this.test3.Location = new System.Drawing.Point(488, 392);
            this.test3.Name = "test3";
            this.test3.Size = new System.Drawing.Size(75, 23);
            this.test3.TabIndex = 2;
            this.test3.Text = "Castle test";
            this.test3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(335, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "jqhsfqsDF";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.test3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DeprinceNicholas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DeprinceNicholas;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button test3;
        private System.Windows.Forms.Label label1;
    }
}

