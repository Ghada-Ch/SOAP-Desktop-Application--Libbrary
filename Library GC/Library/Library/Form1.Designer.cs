namespace Library
{
    partial class LibraryGCForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LibraryGCForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.loginTB = new System.Windows.Forms.TextBox();
            this.passwordTB = new System.Windows.Forms.TextBox();
            this.logBut = new System.Windows.Forms.Button();
            this.typelog = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Old English Text MT", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(274, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 79);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(203, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Login";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(203, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";
            // 
            // loginTB
            // 
            this.loginTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginTB.Location = new System.Drawing.Point(389, 189);
            this.loginTB.Name = "loginTB";
            this.loginTB.Size = new System.Drawing.Size(213, 38);
            this.loginTB.TabIndex = 3;
            // 
            // passwordTB
            // 
            this.passwordTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTB.Location = new System.Drawing.Point(389, 272);
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.Size = new System.Drawing.Size(213, 38);
            this.passwordTB.TabIndex = 4;
            // 
            // logBut
            // 
            this.logBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logBut.Location = new System.Drawing.Point(430, 362);
            this.logBut.Name = "logBut";
            this.logBut.Size = new System.Drawing.Size(120, 52);
            this.logBut.TabIndex = 5;
            this.logBut.Text = "Log In";
            this.logBut.UseVisualStyleBackColor = true;
            this.logBut.Click += new System.EventHandler(this.logBut_Click);
            // 
            // typelog
            // 
            this.typelog.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typelog.FormattingEnabled = true;
            this.typelog.Items.AddRange(new object[] {
            "Admin",
            "User"});
            this.typelog.Location = new System.Drawing.Point(609, 376);
            this.typelog.Name = "typelog";
            this.typelog.Size = new System.Drawing.Size(121, 28);
            this.typelog.TabIndex = 6;
            this.typelog.Text = "Admin";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(216, 373);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 31);
            this.label4.TabIndex = 7;
            this.label4.Text = "Sign In";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(157, 373);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(53, 41);
            this.button1.TabIndex = 8;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LibraryGCForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.typelog);
            this.Controls.Add(this.logBut);
            this.Controls.Add(this.passwordTB);
            this.Controls.Add(this.loginTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LibraryGCForm";
            this.Text = "Library GC";
            this.Load += new System.EventHandler(this.LibraryGCForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox loginTB;
        private System.Windows.Forms.TextBox passwordTB;
        private System.Windows.Forms.Button logBut;
        private System.Windows.Forms.ComboBox typelog;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}

