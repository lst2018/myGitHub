using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Environment;

namespace readTextFileAndDatabase
{
    /*
         Title: Demonstrating coding program using c#; 
         Purposed: oop text file and database connection
         Created by: Liston Sitorus
         Created Date: 01 October 2018

         */
    public partial class ReadTextFile : Form
    {
        public SQLConn SqlRequest = new SQLConn();

        public ReadTextFile()
        {
            InitializeComponent();
        }

        private void ReadTextFile_Load(object sender, EventArgs e)
        {

        }
        void readFolderSubFoders(string PathDir)
        { 
            readFileContent(PathDir);
            if (checkBoxReadSubDirectory.Checked)
            {
                string[] Dirs = Directory.GetDirectories(PathDir);
                foreach (string dir in Dirs)
                {
                    if (richTextBox1.Text.Trim().Equals(""))
                        richTextBox1.Text = richTextBox1.Text + dir + Environment.NewLine;
                    else
                        richTextBox1.Text = richTextBox1.Text + dir + Environment.NewLine;
                    readFileContent(PathDir);
                    readFolderSubFoders(dir);
                }
            }
        }

        void saveFileContent(string fileName, string fileContent)
        {
            string qry = "";

            try
            {
                SqlRequest.getConnStrVal(txtServerName.Text.Trim(), txtDatabaseName.Text.Trim(), txtUserId.Text.Trim(), txtPassword.Text.Trim());

                SqlRequest.AddParam("@fileName", "'" + fileName + "'");
                SqlRequest.AddParam("@fileContent", "'" + fileContent + "'");

                qry = "insert into tblExampleColaCola(FileName,FileContent) ";
                qry = qry + " values(@fileName,@fileContent)";
                SqlRequest.ExecuteQuery(qry);

            }
            catch (Exception er)
            {
                labelErrMsg.Text = er.Message;
            } 
        }


        private void createTableInDb(string QueryRequest = "")
        {
            string qry = "";
            int i = 0;
            int checkTbl = 0;
            // This program will check table to save data in the database.
            //if the required table is still not exist, the required table will be created 
            try
            {
                SqlRequest.getConnStrVal(txtServerName.Text.Trim(), txtDatabaseName.Text.Trim(), txtUserId.Text.Trim(), txtPassword.Text.Trim());


                qry = " use " + txtDatabaseName.Text.Trim();
                qry = qry + "; select count(*) CheckTable ";
                qry = qry + " from sys.objects where name = 'tblExampleColaCola'";
                SqlRequest.ExecuteQuery(qry);
                if (SqlRequest.DBDT.Rows.Count > 0)
                {
                    while (i < SqlRequest.DBDT.Rows.Count)
                    {
                        checkTbl = Convert.ToInt32(SqlRequest.DBDT.Rows[i]["CheckTable"].ToString());
                        i = i + 1;
                    }
                }
                if (checkTbl == 0)
                {
                    qry = "create table tblExampleColaCola (id int identity, ";
                    qry = qry + " FileName varchar(150), FileContent text, ";
                    qry = qry + " constraint PK_exColaCola Primary key(id))";
                    SqlRequest.ExecuteQuery(qry);
                }
            }
            catch (Exception er)
            {
                labelErrMsg.Text = er.Message;
            }
        }

        void readFileContent(string path)
        {
            string[] files;
            string strfilesContent = "";
            StreamReader rf;
            labelErrMsg.Text = "";

            // read text file and retrieve text file content
            files = Directory.GetFiles(path, "*.txt");
            if (checkBoxSaveDataToDatabase.Checked)
                createTableInDb();

            foreach (string file in files)
            {
                if (richTextBox1.Text.Trim().Equals(""))
                    richTextBox1.Text = file;
                else
                    richTextBox1.Text = richTextBox1.Text + file;

                //get file content into a stream reader
                rf = new StreamReader(file);
                if (rf.ReadLine() != null)
                {
                    richTextBox1.Text = richTextBox1.Text + "; The content of this file:" + Environment.NewLine;
                    while (!rf.EndOfStream)
                    {
                        strfilesContent = rf.ReadToEnd();
                        richTextBox1.Text = richTextBox1.Text + strfilesContent + Environment.NewLine;
                        if (checkBoxSaveDataToDatabase.Checked)
                            saveFileContent(file, strfilesContent);
                    }
                    rf.Close();
                }
                else
                {
                    richTextBox1.Text = Environment.NewLine + richTextBox1.Text + "no data is found" + Environment.NewLine + Environment.NewLine;
                    if (checkBoxSaveDataToDatabase.Checked)
                        saveFileContent(file, "no data is found");
                    rf.Close();
                }
                rf.Dispose();
            }

            //check if got an error on query process
            if (checkBoxSaveDataToDatabase.Checked)
                if (SqlRequest.HasException() == true)
                    labelErrMsg.Text = "Please Conection to database or permission of user id or other related";
                else
                    labelErrMsg.Text = "text file and its content saved successfully!";
        }
         

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            string path;
            // Browse folder contents
            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            folderDlg.ShowNewFolderButton = true;
            if (folderDlg.ShowDialog() == DialogResult.OK)
            {
                txtDirectory.Text = folderDlg.SelectedPath.ToString();
                SpecialFolder root = folderDlg.RootFolder; 

                path = txtDirectory.Text.Trim();
                //read folder and its content
                readFolderSubFoders(path);
            }
        }

        private void backToMainPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 actForm = new Form1();
            actForm.Show();
            ReadTextFile act1Form = new ReadTextFile();
            act1Form.Close();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
