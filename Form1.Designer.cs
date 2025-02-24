namespace Bai13_CanChi
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
            this.txtNam = new System.Windows.Forms.TextBox();
            this.txtCanChi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnTinh = new System.Windows.Forms.Button();
            this.lstKq = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtNam
            // 
            this.txtNam.Location = new System.Drawing.Point(146, 54);
            this.txtNam.Name = "txtNam";
            this.txtNam.Size = new System.Drawing.Size(161, 20);
            this.txtNam.TabIndex = 0;
            // 
            // txtCanChi
            // 
            this.txtCanChi.Location = new System.Drawing.Point(146, 100);
            this.txtCanChi.Name = "txtCanChi";
            this.txtCanChi.Size = new System.Drawing.Size(161, 20);
            this.txtCanChi.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "nam";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ket qua";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(338, 100);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(54, 22);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnTinh
            // 
            this.btnTinh.Location = new System.Drawing.Point(338, 52);
            this.btnTinh.Name = "btnTinh";
            this.btnTinh.Size = new System.Drawing.Size(54, 22);
            this.btnTinh.TabIndex = 2;
            this.btnTinh.Text = "tinh";
            this.btnTinh.UseVisualStyleBackColor = true;
            this.btnTinh.Click += new System.EventHandler(this.btnTinh_Click);
            // 
            // lstKq
            // 
            this.lstKq.FormattingEnabled = true;
            this.lstKq.Location = new System.Drawing.Point(532, 56);
            this.lstKq.Name = "lstKq";
            this.lstKq.Size = new System.Drawing.Size(204, 316);
            this.lstKq.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstKq);
            this.Controls.Add(this.btnTinh);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCanChi);
            this.Controls.Add(this.txtNam);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNam;
        private System.Windows.Forms.TextBox txtCanChi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnTinh;
        private System.Windows.Forms.ListBox lstKq;
    }
}

