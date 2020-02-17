namespace Library
{
    partial class UserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.searchBut = new System.Windows.Forms.Button();
            this.dataGridBooks = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.loginBut = new System.Windows.Forms.ToolStripButton();
            this.logOutBut = new System.Windows.Forms.ToolStripButton();
            this.loginTB = new System.Windows.Forms.ToolStripLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.pictureBox14 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBooks)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.textBox8);
            this.groupBox1.Controls.Add(this.searchBut);
            this.groupBox1.Controls.Add(this.dataGridBooks);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(91, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(810, 469);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Books";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Title",
            "Author"});
            this.comboBox1.Location = new System.Drawing.Point(17, 41);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 33);
            this.comboBox1.TabIndex = 18;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(158, 42);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(210, 32);
            this.textBox8.TabIndex = 17;
            // 
            // searchBut
            // 
            this.searchBut.BackColor = System.Drawing.Color.Purple;
            this.searchBut.ForeColor = System.Drawing.Color.White;
            this.searchBut.Location = new System.Drawing.Point(383, 34);
            this.searchBut.Name = "searchBut";
            this.searchBut.Size = new System.Drawing.Size(99, 46);
            this.searchBut.TabIndex = 4;
            this.searchBut.Text = "Search";
            this.searchBut.UseVisualStyleBackColor = false;
            // 
            // dataGridBooks
            // 
            this.dataGridBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridBooks.Location = new System.Drawing.Point(6, 93);
            this.dataGridBooks.Name = "dataGridBooks";
            this.dataGridBooks.RowHeadersWidth = 55;
            this.dataGridBooks.Size = new System.Drawing.Size(798, 344);
            this.dataGridBooks.TabIndex = 2;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.toolStrip1.GripMargin = new System.Windows.Forms.Padding(1100, 2, 2, 2);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginBut,
            this.loginTB,
            this.logOutBut});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 10, 1, 10);
            this.toolStrip1.Size = new System.Drawing.Size(1334, 43);
            this.toolStrip1.TabIndex = 8;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // loginBut
            // 
            this.loginBut.BackColor = System.Drawing.Color.Transparent;
            this.loginBut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.loginBut.Enabled = false;
            this.loginBut.Image = ((System.Drawing.Image)(resources.GetObject("loginBut.Image")));
            this.loginBut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.loginBut.Name = "loginBut";
            this.loginBut.Size = new System.Drawing.Size(23, 20);
            this.loginBut.Text = "Login";
            // 
            // logOutBut
            // 
            this.logOutBut.BackColor = System.Drawing.Color.Transparent;
            this.logOutBut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.logOutBut.Image = ((System.Drawing.Image)(resources.GetObject("logOutBut.Image")));
            this.logOutBut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.logOutBut.Name = "logOutBut";
            this.logOutBut.Size = new System.Drawing.Size(23, 20);
            this.logOutBut.Text = "Log Out";
            this.logOutBut.Click += new System.EventHandler(this.logOutBut_Click);
            // 
            // loginTB
            // 
            this.loginTB.ActiveLinkColor = System.Drawing.Color.Black;
            this.loginTB.BackColor = System.Drawing.Color.Black;
            this.loginTB.Margin = new System.Windows.Forms.Padding(0, 0, 10, 2);
            this.loginTB.Name = "loginTB";
            this.loginTB.Size = new System.Drawing.Size(42, 21);
            this.loginTB.Text = "User";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(930, 73);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(170, 190);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox10.Image")));
            this.pictureBox10.Location = new System.Drawing.Point(1135, 472);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(170, 193);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox10.TabIndex = 28;
            this.pictureBox10.TabStop = false;
            // 
            // pictureBox11
            // 
            this.pictureBox11.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox11.Image")));
            this.pictureBox11.Location = new System.Drawing.Point(930, 472);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(170, 193);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox11.TabIndex = 29;
            this.pictureBox11.TabStop = false;
            // 
            // pictureBox12
            // 
            this.pictureBox12.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox12.Image")));
            this.pictureBox12.Location = new System.Drawing.Point(1135, 273);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(170, 190);
            this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox12.TabIndex = 30;
            this.pictureBox12.TabStop = false;
            // 
            // pictureBox13
            // 
            this.pictureBox13.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox13.Image")));
            this.pictureBox13.Location = new System.Drawing.Point(1135, 73);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(170, 190);
            this.pictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox13.TabIndex = 31;
            this.pictureBox13.TabStop = false;
            // 
            // pictureBox14
            // 
            this.pictureBox14.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox14.Image")));
            this.pictureBox14.Location = new System.Drawing.Point(930, 273);
            this.pictureBox14.Name = "pictureBox14";
            this.pictureBox14.Size = new System.Drawing.Size(170, 193);
            this.pictureBox14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox14.TabIndex = 32;
            this.pictureBox14.TabStop = false;
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.ClientSize = new System.Drawing.Size(1334, 749);
            this.Controls.Add(this.pictureBox14);
            this.Controls.Add(this.pictureBox13);
            this.Controls.Add(this.pictureBox12);
            this.Controls.Add(this.pictureBox11);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UserForm";
            this.Text = "Library GC";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBooks)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Button searchBut;
        private System.Windows.Forms.DataGridView dataGridBooks;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton loginBut;
        private System.Windows.Forms.ToolStripButton logOutBut;
        private System.Windows.Forms.ToolStripLabel loginTB;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.PictureBox pictureBox13;
        private System.Windows.Forms.PictureBox pictureBox14;
    }
}