namespace readTextFileAndDatabase
{
    partial class ReadTextFile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReadTextFile));
            this.txtDirectory = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.lblData1 = new System.Windows.Forms.Label();
            this.lblData2 = new System.Windows.Forms.Label();
            this.folderBrowserDialog2 = new System.Windows.Forms.FolderBrowserDialog();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxReadSubDirectory = new System.Windows.Forms.CheckBox();
            this.checkBoxSaveDataToDatabase = new System.Windows.Forms.CheckBox();
            this.txtServerName = new System.Windows.Forms.TextBox();
            this.txtDatabaseName = new System.Windows.Forms.TextBox();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.labelErrPaswd = new System.Windows.Forms.Label();
            this.labelUserId = new System.Windows.Forms.Label();
            this.labelErrDatabaseName = new System.Windows.Forms.Label();
            this.labelErrServerName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelErrMsg = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.backToMainPageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDirectory
            // 
            this.txtDirectory.Location = new System.Drawing.Point(23, 71);
            this.txtDirectory.Name = "txtDirectory";
            this.txtDirectory.Size = new System.Drawing.Size(307, 20);
            this.txtDirectory.TabIndex = 0;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(336, 68);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(133, 23);
            this.btnBrowse.TabIndex = 1;
            this.btnBrowse.Text = "Browse File and save read";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // lblData1
            // 
            this.lblData1.AutoSize = true;
            this.lblData1.Location = new System.Drawing.Point(20, 100);
            this.lblData1.Name = "lblData1";
            this.lblData1.Size = new System.Drawing.Size(0, 13);
            this.lblData1.TabIndex = 2;
            // 
            // lblData2
            // 
            this.lblData2.AutoSize = true;
            this.lblData2.Location = new System.Drawing.Point(20, 285);
            this.lblData2.Name = "lblData2";
            this.lblData2.Size = new System.Drawing.Size(0, 13);
            this.lblData2.TabIndex = 2;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(23, 97);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(446, 330);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(590, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Demo read text file name and its content in folder, can save the data into databa" +
    "se";
            // 
            // checkBoxReadSubDirectory
            // 
            this.checkBoxReadSubDirectory.AutoSize = true;
            this.checkBoxReadSubDirectory.Location = new System.Drawing.Point(19, 16);
            this.checkBoxReadSubDirectory.Name = "checkBoxReadSubDirectory";
            this.checkBoxReadSubDirectory.Size = new System.Drawing.Size(115, 17);
            this.checkBoxReadSubDirectory.TabIndex = 6;
            this.checkBoxReadSubDirectory.Text = "Read sub directory";
            this.checkBoxReadSubDirectory.UseVisualStyleBackColor = true;
            // 
            // checkBoxSaveDataToDatabase
            // 
            this.checkBoxSaveDataToDatabase.AutoSize = true;
            this.checkBoxSaveDataToDatabase.Location = new System.Drawing.Point(135, 17);
            this.checkBoxSaveDataToDatabase.Name = "checkBoxSaveDataToDatabase";
            this.checkBoxSaveDataToDatabase.Size = new System.Drawing.Size(156, 17);
            this.checkBoxSaveDataToDatabase.TabIndex = 7;
            this.checkBoxSaveDataToDatabase.Text = "Save List of Text File Name";
            this.checkBoxSaveDataToDatabase.UseVisualStyleBackColor = true;
            // 
            // txtServerName
            // 
            this.txtServerName.Location = new System.Drawing.Point(93, 22);
            this.txtServerName.Name = "txtServerName";
            this.txtServerName.Size = new System.Drawing.Size(197, 20);
            this.txtServerName.TabIndex = 2;
            // 
            // txtDatabaseName
            // 
            this.txtDatabaseName.Location = new System.Drawing.Point(93, 54);
            this.txtDatabaseName.Name = "txtDatabaseName";
            this.txtDatabaseName.Size = new System.Drawing.Size(197, 20);
            this.txtDatabaseName.TabIndex = 3;
            // 
            // txtUserId
            // 
            this.txtUserId.Location = new System.Drawing.Point(93, 86);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.Size = new System.Drawing.Size(197, 20);
            this.txtUserId.TabIndex = 4;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(93, 123);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(197, 20);
            this.txtPassword.TabIndex = 5;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.labelErrPaswd);
            this.groupBox1.Controls.Add(this.labelUserId);
            this.groupBox1.Controls.Add(this.labelErrDatabaseName);
            this.groupBox1.Controls.Add(this.labelErrServerName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtServerName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.txtDatabaseName);
            this.groupBox1.Controls.Add(this.txtUserId);
            this.groupBox1.Font = new System.Drawing.Font("Arial Narrow", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(475, 126);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(297, 172);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Database connection (MS. SQL Server)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Password";
            // 
            // labelErrPaswd
            // 
            this.labelErrPaswd.AutoSize = true;
            this.labelErrPaswd.Location = new System.Drawing.Point(87, 141);
            this.labelErrPaswd.Name = "labelErrPaswd";
            this.labelErrPaswd.Size = new System.Drawing.Size(0, 15);
            this.labelErrPaswd.TabIndex = 0;
            // 
            // labelUserId
            // 
            this.labelUserId.AutoSize = true;
            this.labelUserId.Location = new System.Drawing.Point(87, 91);
            this.labelUserId.Name = "labelUserId";
            this.labelUserId.Size = new System.Drawing.Size(0, 15);
            this.labelUserId.TabIndex = 0;
            // 
            // labelErrDatabaseName
            // 
            this.labelErrDatabaseName.AutoSize = true;
            this.labelErrDatabaseName.Location = new System.Drawing.Point(90, 59);
            this.labelErrDatabaseName.Name = "labelErrDatabaseName";
            this.labelErrDatabaseName.Size = new System.Drawing.Size(0, 15);
            this.labelErrDatabaseName.TabIndex = 0;
            // 
            // labelErrServerName
            // 
            this.labelErrServerName.AutoSize = true;
            this.labelErrServerName.Location = new System.Drawing.Point(87, 27);
            this.labelErrServerName.Name = "labelErrServerName";
            this.labelErrServerName.Size = new System.Drawing.Size(0, 15);
            this.labelErrServerName.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Server Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Database name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "User Name";
            // 
            // labelErrMsg
            // 
            this.labelErrMsg.AutoSize = true;
            this.labelErrMsg.ForeColor = System.Drawing.Color.Red;
            this.labelErrMsg.Location = new System.Drawing.Point(481, 311);
            this.labelErrMsg.Name = "labelErrMsg";
            this.labelErrMsg.Size = new System.Drawing.Size(0, 13);
            this.labelErrMsg.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(475, 354);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(306, 65);
            this.label6.TabIndex = 12;
            this.label6.Text = resources.GetString("label6.Text");
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBoxSaveDataToDatabase);
            this.groupBox2.Controls.Add(this.checkBoxReadSubDirectory);
            this.groupBox2.Location = new System.Drawing.Point(476, 71);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(296, 41);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Options";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToMainPageToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(795, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // backToMainPageToolStripMenuItem
            // 
            this.backToMainPageToolStripMenuItem.Name = "backToMainPageToolStripMenuItem";
            this.backToMainPageToolStripMenuItem.Size = new System.Drawing.Size(117, 20);
            this.backToMainPageToolStripMenuItem.Text = "Back to Main Page";
            this.backToMainPageToolStripMenuItem.Click += new System.EventHandler(this.backToMainPageToolStripMenuItem_Click);
            // 
            // ReadTextFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 447);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labelErrMsg);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.lblData2);
            this.Controls.Add(this.lblData1);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtDirectory);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ReadTextFile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ReadTextFile";
            this.Load += new System.EventHandler(this.ReadTextFile_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtDirectory;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label lblData1;
        private System.Windows.Forms.Label lblData2;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxReadSubDirectory;
        private System.Windows.Forms.CheckBox checkBoxSaveDataToDatabase;
        private System.Windows.Forms.TextBox txtServerName;
        private System.Windows.Forms.TextBox txtDatabaseName;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelErrPaswd;
        private System.Windows.Forms.Label labelUserId;
        private System.Windows.Forms.Label labelErrDatabaseName;
        private System.Windows.Forms.Label labelErrServerName;
        private System.Windows.Forms.Label labelErrMsg;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem backToMainPageToolStripMenuItem;
    }
}