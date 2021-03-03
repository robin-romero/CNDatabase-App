using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CNDatabase_App {
    public partial class Form1 : Form {

        string fname, lname, tname;
        public Form1() {
            InitializeComponent();
        }

        private void btnFind_Click(object sender, EventArgs e) {
            pnlBase.Visible = false;
            pnlFind.Visible = true;
        }

        private void btnBackToBase_Click(object sender, EventArgs e) {
            pnlBase.Visible = true;
            pnlFind.Visible = false;
        }

        private void txtLastName_TextChanged(object sender, EventArgs e) {
            lname = txtLastName.Text;
        }

        private void btnFindInfo_Click(object sender, EventArgs e) {
            RunQuery();
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e) {
            fname = txtFirstName.Text;
        }

        private void lblLastName_Click(object sender, EventArgs e) {

        }

        private void textBox1_TextChanged(object sender, EventArgs e) {
            tname = txtTableName.Text + "s";
        }

        void RunQuery() {
            string query = "select * from " + tname + " where firstname = \"" + fname + "\" and lastname = \"" + lname + "\";";

            string mySQLConString = "datasource=127.0.0.1;port=3306;username=root;password=binkytoti;database=codeninjas";

            MySqlConnection dbConnection = new MySqlConnection(mySQLConString);

            MySqlCommand cmdDB = new MySqlCommand(query, dbConnection);
            cmdDB.CommandTimeout = 60;

            try {

                dbConnection.Open();

                MySqlDataReader myReader = cmdDB.ExecuteReader();

                if(tname == "senseis") {
                    if (myReader.HasRows) {
                        while (myReader.Read()) {
                            Console.WriteLine(myReader.GetString(0) + " - " + myReader.GetString(1) + " - " + myReader.GetString(2) + " - " + myReader.GetString(3) + " - " + myReader.GetString(4) + " - " + myReader.GetString(5));
                        }
                    }
                    else {
                        MessageBox.Show("Query successfully executed");
                    }
                }
                if(tname == "directors") {
                    if (myReader.HasRows) {
                        while (myReader.Read()) {
                            Console.WriteLine(myReader.GetString(0) + " - " + myReader.GetString(1) + " - " + myReader.GetString(2) + " - " + myReader.GetString(3) + " - " + myReader.GetString(4));
                        }
                    }
                    else {
                        MessageBox.Show("Query successfully executed");
                    }
                }


            }catch(Exception e) {
                MessageBox.Show("Query ERROR: " + e.Message);
            }
        }
    }
}
