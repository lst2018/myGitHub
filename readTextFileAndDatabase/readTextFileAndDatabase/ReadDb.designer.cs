namespace readTextFileAndDatabase
{
    partial class ReadDb
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
            this.groupBoxDbConfig = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblServerName = new System.Windows.Forms.Label();
            this.labelDatabaseName = new System.Windows.Forms.Label();
            this.labelUserId = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxServerName = new System.Windows.Forms.TextBox();
            this.textBoxDBName = new System.Windows.Forms.TextBox();
            this.textBoxUID = new System.Windows.Forms.TextBox();
            this.textBoxPswd = new System.Windows.Forms.TextBox();
            this.comboBoxTextFileNameList = new System.Windows.Forms.ComboBox();
            this.labelTexFileName = new System.Windows.Forms.Label();
            this.dataGridViewListFileAndContent = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.labelErrMessage = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.backToMainPageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxDbConfig.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListFileAndContent)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxDbConfig
            // 
            this.groupBoxDbConfig.Controls.Add(this.button1);
            this.groupBoxDbConfig.Controls.Add(this.lblServerName);
            this.groupBoxDbConfig.Controls.Add(this.labelDatabaseName);
            this.groupBoxDbConfig.Controls.Add(this.labelUserId);
            this.groupBoxDbConfig.Controls.Add(this.labelPassword);
            this.groupBoxDbConfig.Controls.Add(this.textBoxServerName);
            this.groupBoxDbConfig.Controls.Add(this.textBoxDBName);
            this.groupBoxDbConfig.Controls.Add(this.textBoxUID);
            this.groupBoxDbConfig.Controls.Add(this.textBoxPswd);
            this.groupBoxDbConfig.Location = new System.Drawing.Point(12, 75);
            this.groupBoxDbConfig.Name = "groupBoxDbConfig";
            this.groupBoxDbConfig.Size = new System.Drawing.Size(303, 209);
            this.groupBoxDbConfig.TabIndex = 0;
            this.groupBoxDbConfig.TabStop = false;
            this.groupBoxDbConfig.Text = "Database connection (MS. SQL Server)";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(102, 176);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Read Data";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblServerName
            // 
            this.lblServerName.AutoSize = true;
            this.lblServerName.Location = new System.Drawing.Point(6, 35);
            this.lblServerName.Name = "lblServerName";
            this.lblServerName.Size = new System.Drawing.Size(75, 13);
            this.lblServerName.TabIndex = 5;
            this.lblServerName.Text = "Server Name :";
            // 
            // labelDatabaseName
            // 
            this.labelDatabaseName.AutoSize = true;
            this.labelDatabaseName.Location = new System.Drawing.Point(6, 70);
            this.labelDatabaseName.Name = "labelDatabaseName";
            this.labelDatabaseName.Size = new System.Drawing.Size(90, 13);
            this.labelDatabaseName.TabIndex = 6;
            this.labelDatabaseName.Text = "Database Name :";
            // 
            // labelUserId
            // 
            this.labelUserId.AutoSize = true;
            this.labelUserId.Location = new System.Drawing.Point(6, 108);
            this.labelUserId.Name = "labelUserId";
            this.labelUserId.Size = new System.Drawing.Size(47, 13);
            this.labelUserId.TabIndex = 7;
            this.labelUserId.Text = "User Id :";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(6, 144);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(59, 13);
            this.labelPassword.TabIndex = 8;
            this.labelPassword.Text = "Password :";
            // 
            // textBoxServerName
            // 
            this.textBoxServerName.Location = new System.Drawing.Point(121, 32);
            this.textBoxServerName.Name = "textBoxServerName";
            this.textBoxServerName.Size = new System.Drawing.Size(176, 20);
            this.textBoxServerName.TabIndex = 1;
            // 
            // textBoxDBName
            // 
            this.textBoxDBName.Location = new System.Drawing.Point(121, 67);
            this.textBoxDBName.Name = "textBoxDBName";
            this.textBoxDBName.Size = new System.Drawing.Size(176, 20);
            this.textBoxDBName.TabIndex = 2;
            // 
            // textBoxUID
            // 
            this.textBoxUID.Location = new System.Drawing.Point(121, 105);
            this.textBoxUID.Name = "textBoxUID";
            this.textBoxUID.Size = new System.Drawing.Size(176, 20);
            this.textBoxUID.TabIndex = 3;
            // 
            // textBoxPswd
            // 
            this.textBoxPswd.Location = new System.Drawing.Point(121, 141);
            this.textBoxPswd.Name = "textBoxPswd";
            this.textBoxPswd.Size = new System.Drawing.Size(176, 20);
            this.textBoxPswd.TabIndex = 4;
            // 
            // comboBoxTextFileNameList
            // 
            this.comboBoxTextFileNameList.FormattingEnabled = true;
            this.comboBoxTextFileNameList.Location = new System.Drawing.Point(581, 75);
            this.comboBoxTextFileNameList.Name = "comboBoxTextFileNameList";
            this.comboBoxTextFileNameList.Size = new System.Drawing.Size(179, 21);
            this.comboBoxTextFileNameList.TabIndex = 5;
            this.comboBoxTextFileNameList.SelectedIndexChanged += new System.EventHandler(this.comboBoxTextFileNameList_SelectedIndexChanged);
            // 
            // labelTexFileName
            // 
            this.labelTexFileName.AutoSize = true;
            this.labelTexFileName.Location = new System.Drawing.Point(481, 78);
            this.labelTexFileName.Name = "labelTexFileName";
            this.labelTexFileName.Size = new System.Drawing.Size(84, 13);
            this.labelTexFileName.TabIndex = 5;
            this.labelTexFileName.Text = "Text File Name :";
            // 
            // dataGridViewListFileAndContent
            // 
            this.dataGridViewListFileAndContent.AllowUserToAddRows = false;
            this.dataGridViewListFileAndContent.AllowUserToDeleteRows = false;
            this.dataGridViewListFileAndContent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListFileAndContent.Location = new System.Drawing.Point(433, 110);
            this.dataGridViewListFileAndContent.Name = "dataGridViewListFileAndContent";
            this.dataGridViewListFileAndContent.ReadOnly = true;
            this.dataGridViewListFileAndContent.Size = new System.Drawing.Size(343, 333);
            this.dataGridViewListFileAndContent.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Demo read data table of database";
            // 
            // labelErrMessage
            // 
            this.labelErrMessage.AutoSize = true;
            this.labelErrMessage.ForeColor = System.Drawing.Color.OrangeRed;
            this.labelErrMessage.Location = new System.Drawing.Point(12, 298);
            this.labelErrMessage.Name = "labelErrMessage";
            this.labelErrMessage.Size = new System.Drawing.Size(0, 13);
            this.labelErrMessage.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(9, 350);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(364, 52);
            this.label2.TabIndex = 10;
            this.label2.Text = "This page is reading data table from database that has been saved through \r\npage " +
    "\"Demo Read Data from Text File\"\r\n\r\nPlease provide Database connection above befo" +
    "re click \"Read Data\"";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToMainPageToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // backToMainPageToolStripMenuItem
            // 
            this.backToMainPageToolStripMenuItem.Name = "backToMainPageToolStripMenuItem";
            this.backToMainPageToolStripMenuItem.Size = new System.Drawing.Size(117, 20);
            this.backToMainPageToolStripMenuItem.Text = "Back to main page";
            this.backToMainPageToolStripMenuItem.Click += new System.EventHandler(this.backToMainPageToolStripMenuItem_Click);
            // 
            // ReadDb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelErrMessage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewListFileAndContent);
            this.Controls.Add(this.labelTexFileName);
            this.Controls.Add(this.comboBoxTextFileNameList);
            this.Controls.Add(this.groupBoxDbConfig);
            this.Controls.Add(this.menuStrip1);
            this.Name = "ReadDb";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ReadDb";
            this.groupBoxDbConfig.ResumeLayout(false);
            this.groupBoxDbConfig.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListFileAndContent)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxDbConfig;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblServerName;
        private System.Windows.Forms.Label labelDatabaseName;
        private System.Windows.Forms.Label labelUserId;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxServerName;
        private System.Windows.Forms.TextBox textBoxDBName;
        private System.Windows.Forms.TextBox textBoxUID;
        private System.Windows.Forms.TextBox textBoxPswd;
        private System.Windows.Forms.ComboBox comboBoxTextFileNameList;
        private System.Windows.Forms.Label labelTexFileName;
        private System.Windows.Forms.DataGridView dataGridViewListFileAndContent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelErrMessage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem backToMainPageToolStripMenuItem;
    }
}