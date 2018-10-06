using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace readTextFileAndDatabase
{
    /*
   Title: Demonstrating coding program using c#; 
   Purposed: read text file and oop connection to database
   Created by: Liston Sitorus
   Created Date: 01 October 2018

       */

    public partial class ReadDb : Form
    {
        public SQLConn SqlRequest = new SQLConn();

        public ReadDb()
        {
            InitializeComponent();
        }

        void FindByFileName()
        {
            string QryFind = "";
            try
            {
                labelErrMessage.Text = "";
                SqlRequest.getConnStrVal(textBoxServerName.Text.Trim(), textBoxDBName.Text.Trim(), textBoxUID.Text.Trim(), textBoxPswd.Text.Trim());
                SqlRequest.AddParam("@fName", "%" + comboBoxTextFileNameList.SelectedItem.ToString().Trim() + "%");
                QryFind = "select FileName, fileContent from tblExampleColaCola where FileName like @fName";
                readDatabase(QryFind); 
            }
            catch (Exception er)
            {
                labelErrMessage.Text = "Please re-check database connection or may go first to the page 'Demo Read Data from Text File' ";

            }
        }

        void readDatabase(string query = "")
        {
            string qry = "";
            if (query.ToString().Equals(""))
                qry = "select fileName, fileContent from tblExampleColaCola";
            else
                qry = query;

            SqlRequest.ExecuteQuery(qry);
            if (SqlRequest.HasException() == false)
                dataGridViewListFileAndContent.DataSource = SqlRequest.DBDT;
        }

        void loadCombox()
        {
            string qry = "";
            qry = "select distinct fileName from tblExampleColaCola";
            SqlRequest.ExecuteQuery(qry);
            if (SqlRequest.HasException() == false)
            {
                foreach (DataRow dtrow in SqlRequest.DBDT.Rows)
                {
                    comboBoxTextFileNameList.Items.Add(dtrow["fileName"].ToString());
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                labelErrMessage.Text = "";
                //save data for connection string
                SqlRequest.getConnStrVal(textBoxServerName.Text.Trim(), textBoxDBName.Text.Trim(), textBoxUID.Text.Trim(), textBoxPswd.Text.Trim());
                readDatabase();
                loadCombox();
            }
            catch (Exception er)
            {
                labelErrMessage.Text = "Please re-check database connection or firstly shoud go to the page 'Demo Read Data from Text File' ";
            }

            if (textBoxServerName.Text.Trim().Equals("") || textBoxDBName.Text.Trim().Equals("") || textBoxUID.Text.Trim().Equals("") || textBoxPswd.Text.Trim().Equals(""))
                labelErrMessage.Text = "Please provide Database connection";
            else if (SqlRequest.HasException() == true)
                labelErrMessage.Text = "Please re-check database connection or firstly should go to the page 'Demo Read Data from Text File' ";

        }

        private void comboBoxTextFileNameList_SelectedIndexChanged(object sender, EventArgs e)
        {
            FindByFileName();
        }

        private void backToMainPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 actForm = new Form1();
            actForm.Show();

            ReadDb act1Form = new ReadDb();
             
        }
    }
}
