namespace Library
{
    partial class AdminForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabbooks = new System.Windows.Forms.TabPage();
            this.butAdd = new System.Windows.Forms.Button();
            this.butModify = new System.Windows.Forms.Button();
            this.butDelete = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.butCancel = new System.Windows.Forms.Button();
            this.butConfAdd = new System.Windows.Forms.Button();
            this.textBoxPages = new System.Windows.Forms.TextBox();
            this.textBoxPublisher = new System.Windows.Forms.TextBox();
            this.textBoxLanguage = new System.Windows.Forms.TextBox();
            this.textBoxPrix = new System.Windows.Forms.TextBox();
            this.textBoxGenre = new System.Windows.Forms.TextBox();
            this.textBoxAuteur = new System.Windows.Forms.TextBox();
            this.textBoxTitre = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.searchTB = new System.Windows.Forms.TextBox();
            this.searchBut = new System.Windows.Forms.Button();
            this.dataGridBooks = new System.Windows.Forms.DataGridView();
            this.tabUsers = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridUsers = new System.Windows.Forms.DataGridView();
            this.deleteUserBut = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.loginBut = new System.Windows.Forms.ToolStripButton();
            this.loginLab = new System.Windows.Forms.ToolStripLabel();
            this.logOutBut = new System.Windows.Forms.ToolStripButton();
            this.tabControl1.SuspendLayout();
            this.tabbooks.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBooks)).BeginInit();
            this.tabUsers.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUsers)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabbooks);
            this.tabControl1.Controls.Add(this.tabUsers);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.ItemSize = new System.Drawing.Size(70, 40);
            this.tabControl1.Location = new System.Drawing.Point(-2, 38);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1266, 603);
            this.tabControl1.TabIndex = 2;
            // 
            // tabbooks
            // 
            this.tabbooks.BackColor = System.Drawing.Color.White;
            this.tabbooks.Controls.Add(this.butAdd);
            this.tabbooks.Controls.Add(this.butModify);
            this.tabbooks.Controls.Add(this.butDelete);
            this.tabbooks.Controls.Add(this.groupBox2);
            this.tabbooks.Controls.Add(this.groupBox1);
            this.tabbooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabbooks.Location = new System.Drawing.Point(4, 44);
            this.tabbooks.Name = "tabbooks";
            this.tabbooks.Padding = new System.Windows.Forms.Padding(3);
            this.tabbooks.Size = new System.Drawing.Size(1258, 555);
            this.tabbooks.TabIndex = 0;
            this.tabbooks.Text = "Books";
            // 
            // butAdd
            // 
            this.butAdd.BackColor = System.Drawing.Color.Purple;
            this.butAdd.ForeColor = System.Drawing.Color.White;
            this.butAdd.Location = new System.Drawing.Point(434, 492);
            this.butAdd.Name = "butAdd";
            this.butAdd.Size = new System.Drawing.Size(90, 46);
            this.butAdd.TabIndex = 19;
            this.butAdd.Text = "Add";
            this.butAdd.UseVisualStyleBackColor = false;
            this.butAdd.Click += new System.EventHandler(this.butAdd_Click);
            // 
            // butModify
            // 
            this.butModify.BackColor = System.Drawing.Color.Purple;
            this.butModify.ForeColor = System.Drawing.Color.White;
            this.butModify.Location = new System.Drawing.Point(303, 492);
            this.butModify.Name = "butModify";
            this.butModify.Size = new System.Drawing.Size(90, 46);
            this.butModify.TabIndex = 18;
            this.butModify.Text = "Modify";
            this.butModify.UseVisualStyleBackColor = false;
            this.butModify.Click += new System.EventHandler(this.butModify_Click);
            // 
            // butDelete
            // 
            this.butDelete.BackColor = System.Drawing.Color.Purple;
            this.butDelete.ForeColor = System.Drawing.Color.White;
            this.butDelete.Location = new System.Drawing.Point(161, 492);
            this.butDelete.Name = "butDelete";
            this.butDelete.Size = new System.Drawing.Size(90, 46);
            this.butDelete.TabIndex = 17;
            this.butDelete.Text = "Delete";
            this.butDelete.UseVisualStyleBackColor = false;
            this.butDelete.Click += new System.EventHandler(this.butDelete_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.butCancel);
            this.groupBox2.Controls.Add(this.butConfAdd);
            this.groupBox2.Controls.Add(this.textBoxPages);
            this.groupBox2.Controls.Add(this.textBoxPublisher);
            this.groupBox2.Controls.Add(this.textBoxLanguage);
            this.groupBox2.Controls.Add(this.textBoxPrix);
            this.groupBox2.Controls.Add(this.textBoxGenre);
            this.groupBox2.Controls.Add(this.textBoxAuteur);
            this.groupBox2.Controls.Add(this.textBoxTitre);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Purple;
            this.groupBox2.Location = new System.Drawing.Point(839, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(410, 469);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "New";
            // 
            // butCancel
            // 
            this.butCancel.BackColor = System.Drawing.Color.Purple;
            this.butCancel.ForeColor = System.Drawing.Color.White;
            this.butCancel.Location = new System.Drawing.Point(246, 407);
            this.butCancel.Name = "butCancel";
            this.butCancel.Size = new System.Drawing.Size(103, 46);
            this.butCancel.TabIndex = 17;
            this.butCancel.Text = "Cancel";
            this.butCancel.UseVisualStyleBackColor = false;
            this.butCancel.Click += new System.EventHandler(this.butCancel_Click);
            // 
            // butConfAdd
            // 
            this.butConfAdd.BackColor = System.Drawing.Color.Purple;
            this.butConfAdd.ForeColor = System.Drawing.Color.White;
            this.butConfAdd.Location = new System.Drawing.Point(108, 407);
            this.butConfAdd.Name = "butConfAdd";
            this.butConfAdd.Size = new System.Drawing.Size(90, 46);
            this.butConfAdd.TabIndex = 3;
            this.butConfAdd.Text = "Ok";
            this.butConfAdd.UseVisualStyleBackColor = false;
            this.butConfAdd.Click += new System.EventHandler(this.butConfAdd_Click);
            // 
            // textBoxPages
            // 
            this.textBoxPages.Location = new System.Drawing.Point(191, 355);
            this.textBoxPages.Name = "textBoxPages";
            this.textBoxPages.Size = new System.Drawing.Size(210, 32);
            this.textBoxPages.TabIndex = 16;
            // 
            // textBoxPublisher
            // 
            this.textBoxPublisher.Location = new System.Drawing.Point(191, 304);
            this.textBoxPublisher.Name = "textBoxPublisher";
            this.textBoxPublisher.Size = new System.Drawing.Size(210, 32);
            this.textBoxPublisher.TabIndex = 15;
            // 
            // textBoxLanguage
            // 
            this.textBoxLanguage.Location = new System.Drawing.Point(191, 248);
            this.textBoxLanguage.Name = "textBoxLanguage";
            this.textBoxLanguage.Size = new System.Drawing.Size(210, 32);
            this.textBoxLanguage.TabIndex = 14;
            // 
            // textBoxPrix
            // 
            this.textBoxPrix.Location = new System.Drawing.Point(191, 202);
            this.textBoxPrix.Name = "textBoxPrix";
            this.textBoxPrix.Size = new System.Drawing.Size(210, 32);
            this.textBoxPrix.TabIndex = 13;
            // 
            // textBoxGenre
            // 
            this.textBoxGenre.Location = new System.Drawing.Point(191, 147);
            this.textBoxGenre.Name = "textBoxGenre";
            this.textBoxGenre.Size = new System.Drawing.Size(210, 32);
            this.textBoxGenre.TabIndex = 12;
            // 
            // textBoxAuteur
            // 
            this.textBoxAuteur.Location = new System.Drawing.Point(191, 93);
            this.textBoxAuteur.Name = "textBoxAuteur";
            this.textBoxAuteur.Size = new System.Drawing.Size(210, 32);
            this.textBoxAuteur.TabIndex = 11;
            // 
            // textBoxTitre
            // 
            this.textBoxTitre.Location = new System.Drawing.Point(191, 42);
            this.textBoxTitre.Name = "textBoxTitre";
            this.textBoxTitre.Size = new System.Drawing.Size(210, 32);
            this.textBoxTitre.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(31, 362);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "Pages";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(27, 311);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Publisher";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(27, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Language";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(27, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Prix";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(27, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Genre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(27, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Auteur";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(27, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Titre";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.searchTB);
            this.groupBox1.Controls.Add(this.searchBut);
            this.groupBox1.Controls.Add(this.dataGridBooks);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Purple;
            this.groupBox1.Location = new System.Drawing.Point(12, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(810, 469);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Books";
            // 
            // searchTB
            // 
            this.searchTB.Location = new System.Drawing.Point(158, 42);
            this.searchTB.Name = "searchTB";
            this.searchTB.Size = new System.Drawing.Size(210, 32);
            this.searchTB.TabIndex = 17;
            this.searchTB.TextChanged += new System.EventHandler(this.searchTB_TextChanged);
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
            this.dataGridBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridBooks.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridBooks.Location = new System.Drawing.Point(6, 93);
            this.dataGridBooks.Name = "dataGridBooks";
            this.dataGridBooks.RowHeadersWidth = 55;
            this.dataGridBooks.Size = new System.Drawing.Size(798, 344);
            this.dataGridBooks.TabIndex = 2;
            this.dataGridBooks.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridBooks_CellClick);
            // 
            // tabUsers
            // 
            this.tabUsers.Controls.Add(this.groupBox3);
            this.tabUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabUsers.Location = new System.Drawing.Point(4, 44);
            this.tabUsers.Name = "tabUsers";
            this.tabUsers.Padding = new System.Windows.Forms.Padding(3);
            this.tabUsers.Size = new System.Drawing.Size(1258, 555);
            this.tabUsers.TabIndex = 1;
            this.tabUsers.Text = "Users";
            this.tabUsers.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridUsers);
            this.groupBox3.Controls.Add(this.deleteUserBut);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Purple;
            this.groupBox3.Location = new System.Drawing.Point(161, 32);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(665, 469);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Users";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // dataGridUsers
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(10);
            this.dataGridUsers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridUsers.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridUsers.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dataGridUsers.ColumnHeadersHeight = 40;
            this.dataGridUsers.Location = new System.Drawing.Point(22, 104);
            this.dataGridUsers.Name = "dataGridUsers";
            this.dataGridUsers.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridUsers.Size = new System.Drawing.Size(617, 344);
            this.dataGridUsers.TabIndex = 6;
            this.dataGridUsers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridUsers_CellContentClick);
            // 
            // deleteUserBut
            // 
            this.deleteUserBut.Location = new System.Drawing.Point(550, 53);
            this.deleteUserBut.Name = "deleteUserBut";
            this.deleteUserBut.Size = new System.Drawing.Size(89, 33);
            this.deleteUserBut.TabIndex = 5;
            this.deleteUserBut.Text = "Delete";
            this.deleteUserBut.UseVisualStyleBackColor = true;
            this.deleteUserBut.Click += new System.EventHandler(this.deleteUserBut_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.toolStrip1.GripMargin = new System.Windows.Forms.Padding(1000, 2, 2, 2);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginBut,
            this.loginLab,
            this.logOutBut});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 10, 1, 10);
            this.toolStrip1.Size = new System.Drawing.Size(1264, 44);
            this.toolStrip1.TabIndex = 9;
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
            this.loginBut.Size = new System.Drawing.Size(23, 21);
            this.loginBut.Text = "Login";
            // 
            // loginLab
            // 
            this.loginLab.ActiveLinkColor = System.Drawing.Color.Blue;
            this.loginLab.BackColor = System.Drawing.Color.Transparent;
            this.loginLab.Margin = new System.Windows.Forms.Padding(0, 1, 20, 2);
            this.loginLab.Name = "loginLab";
            this.loginLab.RightToLeftAutoMirrorImage = true;
            this.loginLab.Size = new System.Drawing.Size(56, 21);
            this.loginLab.Text = "Admin";
            this.loginLab.VisitedLinkColor = System.Drawing.Color.Blue;
            // 
            // logOutBut
            // 
            this.logOutBut.BackColor = System.Drawing.Color.Transparent;
            this.logOutBut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.logOutBut.Image = ((System.Drawing.Image)(resources.GetObject("logOutBut.Image")));
            this.logOutBut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.logOutBut.Name = "logOutBut";
            this.logOutBut.Size = new System.Drawing.Size(23, 21);
            this.logOutBut.Text = "Log Out";
            this.logOutBut.Click += new System.EventHandler(this.logOutBut_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.ClientSize = new System.Drawing.Size(1264, 639);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminForm";
            this.Text = "Library GC";
            this.tabControl1.ResumeLayout(false);
            this.tabbooks.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBooks)).EndInit();
            this.tabUsers.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUsers)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabbooks;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button butConfAdd;
        private System.Windows.Forms.TextBox textBoxPages;
        private System.Windows.Forms.TextBox textBoxPublisher;
        private System.Windows.Forms.TextBox textBoxLanguage;
        private System.Windows.Forms.TextBox textBoxPrix;
        private System.Windows.Forms.TextBox textBoxGenre;
        private System.Windows.Forms.TextBox textBoxAuteur;
        private System.Windows.Forms.TextBox textBoxTitre;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridBooks;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabPage tabUsers;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridUsers;
        private System.Windows.Forms.Button deleteUserBut;
        private System.Windows.Forms.Button butModify;
        private System.Windows.Forms.Button butDelete;
        private System.Windows.Forms.TextBox searchTB;
        private System.Windows.Forms.Button searchBut;
        private System.Windows.Forms.Button butAdd;
        private System.Windows.Forms.Button butCancel;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton loginBut;
        private System.Windows.Forms.ToolStripButton logOutBut;
        private System.Windows.Forms.ToolStripLabel loginLab;
    }
}