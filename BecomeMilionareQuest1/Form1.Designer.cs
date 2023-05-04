namespace BecomeMilionareQuest1
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
            this.lblQuestion = new System.Windows.Forms.Label();
            this.lblAnsw1 = new System.Windows.Forms.Label();
            this.lblAnsw2 = new System.Windows.Forms.Label();
            this.lblAnsw3 = new System.Windows.Forms.Label();
            this.lblAnsw4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.BackColor = System.Drawing.Color.RoyalBlue;
            this.lblQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblQuestion.Location = new System.Drawing.Point(342, 92);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(109, 38);
            this.lblQuestion.TabIndex = 0;
            this.lblQuestion.Text = "label1";
            // 
            // lblAnsw1
            // 
            this.lblAnsw1.AutoSize = true;
            this.lblAnsw1.BackColor = System.Drawing.Color.RoyalBlue;
            this.lblAnsw1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnsw1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblAnsw1.Location = new System.Drawing.Point(114, 207);
            this.lblAnsw1.Name = "lblAnsw1";
            this.lblAnsw1.Size = new System.Drawing.Size(98, 32);
            this.lblAnsw1.TabIndex = 1;
            this.lblAnsw1.Text = "label2";
            this.lblAnsw1.Click += new System.EventHandler(this.lblAnsw1_Click);
            // 
            // lblAnsw2
            // 
            this.lblAnsw2.AutoSize = true;
            this.lblAnsw2.BackColor = System.Drawing.Color.RoyalBlue;
            this.lblAnsw2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnsw2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblAnsw2.Location = new System.Drawing.Point(114, 318);
            this.lblAnsw2.Name = "lblAnsw2";
            this.lblAnsw2.Size = new System.Drawing.Size(98, 32);
            this.lblAnsw2.TabIndex = 2;
            this.lblAnsw2.Text = "label3";
            // 
            // lblAnsw3
            // 
            this.lblAnsw3.AutoSize = true;
            this.lblAnsw3.BackColor = System.Drawing.Color.RoyalBlue;
            this.lblAnsw3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnsw3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblAnsw3.Location = new System.Drawing.Point(578, 207);
            this.lblAnsw3.Name = "lblAnsw3";
            this.lblAnsw3.Size = new System.Drawing.Size(98, 32);
            this.lblAnsw3.TabIndex = 3;
            this.lblAnsw3.Text = "label4";
            this.lblAnsw3.Click += new System.EventHandler(this.lblAnsw3_Click);
            // 
            // lblAnsw4
            // 
            this.lblAnsw4.AutoSize = true;
            this.lblAnsw4.BackColor = System.Drawing.Color.RoyalBlue;
            this.lblAnsw4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnsw4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblAnsw4.Location = new System.Drawing.Point(578, 318);
            this.lblAnsw4.Name = "lblAnsw4";
            this.lblAnsw4.Size = new System.Drawing.Size(98, 32);
            this.lblAnsw4.TabIndex = 4;
            this.lblAnsw4.Text = "label5";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblAnsw4);
            this.Controls.Add(this.lblAnsw3);
            this.Controls.Add(this.lblAnsw2);
            this.Controls.Add(this.lblAnsw1);
            this.Controls.Add(this.lblQuestion);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Label lblAnsw1;
        private System.Windows.Forms.Label lblAnsw2;
        private System.Windows.Forms.Label lblAnsw3;
        private System.Windows.Forms.Label lblAnsw4;
    }
}

