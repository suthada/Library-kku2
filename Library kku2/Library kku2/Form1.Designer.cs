namespace Library_kku2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnMajor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelLogin = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxMajor = new System.Windows.Forms.TextBox();
            this.labelMajor = new System.Windows.Forms.Label();
            this.textBoxID2 = new System.Windows.Forms.TextBox();
            this.labelID = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelRegister = new System.Windows.Forms.Label();
            this.buttonChickin = new System.Windows.Forms.Button();
            this.buttonChackout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnMajor,
            this.ColumnID,
            this.ColumnName,
            this.ColumnLastName});
            this.dataGridView1.Location = new System.Drawing.Point(272, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(516, 427);
            this.dataGridView1.TabIndex = 0;
            // 
            // ColumnMajor
            // 
            this.ColumnMajor.HeaderText = "Major";
            this.ColumnMajor.MinimumWidth = 6;
            this.ColumnMajor.Name = "ColumnMajor";
            this.ColumnMajor.Width = 125;
            // 
            // ColumnID
            // 
            this.ColumnID.HeaderText = "ID";
            this.ColumnID.MinimumWidth = 6;
            this.ColumnID.Name = "ColumnID";
            this.ColumnID.Width = 125;
            // 
            // ColumnName
            // 
            this.ColumnName.HeaderText = "Name";
            this.ColumnName.MinimumWidth = 6;
            this.ColumnName.Name = "ColumnName";
            this.ColumnName.Width = 125;
            // 
            // ColumnLastName
            // 
            this.ColumnLastName.HeaderText = "LastName";
            this.ColumnLastName.MinimumWidth = 6;
            this.ColumnLastName.Name = "ColumnLastName";
            this.ColumnLastName.Width = 125;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Location = new System.Drawing.Point(27, 44);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(46, 20);
            this.labelLogin.TabIndex = 3;
            this.labelLogin.Text = "Login";
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(27, 77);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(24, 20);
            this.ID.TabIndex = 4;
            this.ID.Text = "ID";
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(107, 74);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(125, 27);
            this.textBoxID.TabIndex = 5;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(107, 107);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(125, 27);
            this.textBoxPassword.TabIndex = 7;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(27, 110);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(70, 20);
            this.labelPassword.TabIndex = 6;
            this.labelPassword.Text = "Password";
            // 
            // textBoxMajor
            // 
            this.textBoxMajor.Location = new System.Drawing.Point(107, 336);
            this.textBoxMajor.Name = "textBoxMajor";
            this.textBoxMajor.Size = new System.Drawing.Size(125, 27);
            this.textBoxMajor.TabIndex = 9;
            // 
            // labelMajor
            // 
            this.labelMajor.AutoSize = true;
            this.labelMajor.Location = new System.Drawing.Point(22, 336);
            this.labelMajor.Name = "labelMajor";
            this.labelMajor.Size = new System.Drawing.Size(48, 20);
            this.labelMajor.TabIndex = 8;
            this.labelMajor.Text = "Major";
            // 
            // textBoxID2
            // 
            this.textBoxID2.Location = new System.Drawing.Point(107, 369);
            this.textBoxID2.Name = "textBoxID2";
            this.textBoxID2.Size = new System.Drawing.Size(125, 27);
            this.textBoxID2.TabIndex = 11;
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(22, 369);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(24, 20);
            this.labelID.TabIndex = 10;
            this.labelID.Text = "ID";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(107, 402);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(125, 27);
            this.textBoxName.TabIndex = 13;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(22, 402);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(49, 20);
            this.labelName.TabIndex = 12;
            this.labelName.Text = "Name";
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(107, 435);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(125, 27);
            this.textBoxLastName.TabIndex = 15;
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(22, 435);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(75, 20);
            this.labelLastName.TabIndex = 14;
            this.labelLastName.Text = "LastName";
            // 
            // labelRegister
            // 
            this.labelRegister.AutoSize = true;
            this.labelRegister.Location = new System.Drawing.Point(22, 306);
            this.labelRegister.Name = "labelRegister";
            this.labelRegister.Size = new System.Drawing.Size(63, 20);
            this.labelRegister.TabIndex = 16;
            this.labelRegister.Text = "Register";
            // 
            // buttonChickin
            // 
            this.buttonChickin.Location = new System.Drawing.Point(107, 140);
            this.buttonChickin.Name = "buttonChickin";
            this.buttonChickin.Size = new System.Drawing.Size(125, 29);
            this.buttonChickin.TabIndex = 17;
            this.buttonChickin.Text = "Chackin";
            this.buttonChickin.UseVisualStyleBackColor = true;
            this.buttonChickin.Click += new System.EventHandler(this.buttonChickin_Click);
            // 
            // buttonChackout
            // 
            this.buttonChackout.Location = new System.Drawing.Point(107, 175);
            this.buttonChackout.Name = "buttonChackout";
            this.buttonChackout.Size = new System.Drawing.Size(125, 29);
            this.buttonChackout.TabIndex = 18;
            this.buttonChackout.Text = "Chackout";
            this.buttonChackout.UseVisualStyleBackColor = true;
            this.buttonChackout.Click += new System.EventHandler(this.buttonChackout_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 528);
            this.Controls.Add(this.buttonChackout);
            this.Controls.Add(this.buttonChickin);
            this.Controls.Add(this.labelRegister);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxID2);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.textBoxMajor);
            this.Controls.Add(this.labelMajor);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private Label labelLogin;
        private Label ID;
        private TextBox textBoxID;
        private TextBox textBoxPassword;
        private Label labelPassword;
        private TextBox textBoxMajor;
        private Label labelMajor;
        private TextBox textBoxID2;
        private Label labelID;
        private TextBox textBoxName;
        private Label labelName;
        private TextBox textBoxLastName;
        private Label labelLastName;
        private Label labelRegister;
        private Button buttonChickin;
        private Button buttonChackout;
        private DataGridViewTextBoxColumn ColumnMajor;
        private DataGridViewTextBoxColumn ColumnID;
        private DataGridViewTextBoxColumn ColumnName;
        private DataGridViewTextBoxColumn ColumnLastName;
    }
}