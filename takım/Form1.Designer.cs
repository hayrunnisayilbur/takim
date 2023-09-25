namespace takım
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
            this.btnTakim1 = new System.Windows.Forms.Button();
            this.btnTakim2 = new System.Windows.Forms.Button();
            this.btnTakim3 = new System.Windows.Forms.Button();
            this.btnTakim4 = new System.Windows.Forms.Button();
            this.lblTakim = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnTakim1
            // 
            this.btnTakim1.Location = new System.Drawing.Point(30, 33);
            this.btnTakim1.Name = "btnTakim1";
            this.btnTakim1.Size = new System.Drawing.Size(161, 78);
            this.btnTakim1.TabIndex = 0;
            this.btnTakim1.Text = "fenerbahçe";
            this.btnTakim1.UseVisualStyleBackColor = true;
            this.btnTakim1.Click += new System.EventHandler(this.btnTakim1_Click);
            // 
            // btnTakim2
            // 
            this.btnTakim2.Location = new System.Drawing.Point(30, 117);
            this.btnTakim2.Name = "btnTakim2";
            this.btnTakim2.Size = new System.Drawing.Size(161, 78);
            this.btnTakim2.TabIndex = 1;
            this.btnTakim2.Text = "galatasaray";
            this.btnTakim2.UseVisualStyleBackColor = true;
            this.btnTakim2.Click += new System.EventHandler(this.btnTakim2_Click);
            // 
            // btnTakim3
            // 
            this.btnTakim3.Location = new System.Drawing.Point(30, 202);
            this.btnTakim3.Name = "btnTakim3";
            this.btnTakim3.Size = new System.Drawing.Size(161, 79);
            this.btnTakim3.TabIndex = 2;
            this.btnTakim3.Text = "beşiktaş";
            this.btnTakim3.UseVisualStyleBackColor = true;
            this.btnTakim3.Click += new System.EventHandler(this.btnTakim3_Click);
            // 
            // btnTakim4
            // 
            this.btnTakim4.Location = new System.Drawing.Point(30, 288);
            this.btnTakim4.Name = "btnTakim4";
            this.btnTakim4.Size = new System.Drawing.Size(161, 81);
            this.btnTakim4.TabIndex = 3;
            this.btnTakim4.Text = "trabzonspor";
            this.btnTakim4.UseVisualStyleBackColor = true;
            this.btnTakim4.Click += new System.EventHandler(this.btnTakim4_Click);
            // 
            // lblTakim
            // 
            this.lblTakim.AutoSize = true;
            this.lblTakim.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTakim.Location = new System.Drawing.Point(359, 202);
            this.lblTakim.Name = "lblTakim";
            this.lblTakim.Size = new System.Drawing.Size(168, 25);
            this.lblTakim.TabIndex = 4;
            this.lblTakim.Text = "_____________";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTakim);
            this.Controls.Add(this.btnTakim4);
            this.Controls.Add(this.btnTakim3);
            this.Controls.Add(this.btnTakim2);
            this.Controls.Add(this.btnTakim1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTakim1;
        private System.Windows.Forms.Button btnTakim2;
        private System.Windows.Forms.Button btnTakim3;
        private System.Windows.Forms.Button btnTakim4;
        private System.Windows.Forms.Label lblTakim;
    }
}

