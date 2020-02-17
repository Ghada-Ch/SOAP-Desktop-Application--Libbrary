namespace Library
{
    partial class SignInForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignInForm));
            this.passwordTB = new System.Windows.Forms.TextBox();
            this.loginTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ButSign = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // passwordTB
            // 
            this.passwordTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTB.Location = new System.Drawing.Point(226, 322);
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.Size = new System.Drawing.Size(213, 38);
            this.passwordTB.TabIndex = 9;
            // 
            // loginTB
            // 
            this.loginTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginTB.Location = new System.Drawing.Point(226, 239);
            this.loginTB.Name = "loginTB";
            this.loginTB.Size = new System.Drawing.Size(213, 38);
            this.loginTB.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 322);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 31);
            this.label3.TabIndex = 7;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 31);
            this.label2.TabIndex = 6;
            this.label2.Text = "Login";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Old English Text MT", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(111, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 79);
            this.label1.TabIndex = 5;
            this.label1.Text = "Welcome";
            // 
            // ButSign
            // 
            this.ButSign.Location = new System.Drawing.Point(177, 383);
            this.ButSign.Name = "ButSign";
            this.ButSign.Size = new System.Drawing.Size(75, 37);
            this.ButSign.TabIndex = 10;
            this.ButSign.Text = "Sign In";
            this.ButSign.UseVisualStyleBackColor = true;
            this.ButSign.Click += new System.EventHandler(this.ButSign_Click);
            // 
            // SignInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.ClientSize = new System.Drawing.Size(478, 450);
            this.Controls.Add(this.ButSign);
            this.Controls.Add(this.passwordTB);
            this.Controls.Add(this.loginTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SignInForm";
            this.Text = "Library GC";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox passwordTB;
        private System.Windows.Forms.TextBox loginTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ButSign;
    }
}