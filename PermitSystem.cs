using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace PermitSystem {
    public partial class PermitSystem : Form {

        // create connection string to the data base
        String connection_string = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Eamon\Google Drive\HDIP Software Design and Development\NET Programming\Assignments\Vehicle.accdb;Persist Security Info = False; ";
        OleDbConnection conn = null;


        public PermitSystem() {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e) {
            // connect to database on form load
            connectToolStripMenuItem.PerformClick();

            //load all permits on form load
            ShowAllPermits();

        }

        // on clicking quit in toolstrip menu, the application is to exit 
        private void quitToolStripMenuItem_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        // on clicking connect in toolstrip menu, the application is to connect to database
        private void connectToolStripMenuItem_Click(object sender, EventArgs e) {
            try {
                conn = new OleDbConnection(connection_string);
                conn.Open();
                disconnectToolStripMenuItem.Enabled = true;
                connectToolStripMenuItem.Enabled = false;
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        // on clicking disconnect in toolstrip menu, the application is to connect to database
        private void disconnectToolStripMenuItem_Click(object sender, EventArgs e) {
            try {
                conn.Close();
                disconnectToolStripMenuItem.Enabled = false;
                connectToolStripMenuItem.Enabled = true;
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        //when form closes, disconnect from database
        private void PermitSystem_FormClosing(object sender, FormClosingEventArgs e) {
            disconnectToolStripMenuItem.PerformClick();
        }

        private void button1_Click(object sender, EventArgs e) {

        }

        // function to show all permits in datatable
        private void ShowAllPermits() {

            // SQL query to select all columns
            string query = "SELECT Permit_ID,Vehicle_Model,Registration,Owner,Apartment,Registration_2,Expiry_Date,In_Use FROM Vehicle";

            try {
                OleDbCommand cmd = new OleDbCommand(query, conn);
                OleDbDataAdapter adaptor = new OleDbDataAdapter(cmd);

                DataTable dt = new DataTable();

                adaptor.SelectCommand = cmd;
                adaptor.Fill(dt);

                Results.DataSource = dt;

                Results.AutoResizeColumns();


            } catch (Exception ex) {

                MessageBox.Show(ex.Message);
            }

        }

        private void Results_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }

        // function to delete a permit from system. 
        private void DeletePermit() {

            if (Results.SelectedRows.Count > 0) {
                // permit ID is selected based on the selected index in the datatable
                int selectedIndext = Results.SelectedRows[0].Index;
                int permitID = int.Parse(Results[0, selectedIndext].Value.ToString());

                string query = "DELETE FROM vehicle WHERE Permit_ID = " + permitID;

                try {

                    OleDbCommand cmd = new OleDbCommand(query, conn);

                    cmd.ExecuteNonQuery();
                    ShowAllPermits();
                    clearTextBoxes();
                    MessageBox.Show("Entry successfully deleted!");

                } catch (Exception ex) {

                    MessageBox.Show(ex.Message);
                }

            }
        }
        // show all permits button click, change cursor to waiting while query is being ran
        private void button1_Click_2(object sender, EventArgs e) {
            this.Cursor = Cursors.WaitCursor;
            ShowAllPermits();
            this.Cursor = Cursors.Default;
        }

        // delete permit button click, change cursor to waiting while query is being ran
        private void button4_Click(object sender, EventArgs e) {
            this.Cursor = Cursors.WaitCursor;
            DeletePermit();
            this.Cursor = Cursors.Default;
        }
        // add entry button click, change cursor to waiting while query is being ran
        private void button2_Click(object sender, EventArgs e) {
            this.Cursor = Cursors.WaitCursor;
            addEntry();
            this.Cursor = Cursors.Default;

        }

        // add entry function
        private void addEntry() {
            string query = "INSERT INTO Vehicle(Vehicle_Model, " +
                            "Registration, " +
                            "Owner, " +
                            "Apartment, " +
                            "Registration_2, " +
                            "Expiry_Date) VALUES(@Vehicle_Model, " +
                            "@Registration_1, " +
                            "@Owner, " +
                            "@Apartment, " +
                            "@Registration_2, " +
                            "@Expiry_Date)";

            try {

                OleDbCommand cmd = new OleDbCommand(query, conn);
                cmd.Parameters.AddWithValue("@Vehicle_Model", VehicleTextBox.Text);
                cmd.Parameters.AddWithValue("@Registration_1", reg1TextBox.Text);
                cmd.Parameters.AddWithValue("@Owner", NameTextBox.Text);
                cmd.Parameters.AddWithValue("@Apartment", int.Parse(AptTextBox.Text));
                cmd.Parameters.AddWithValue("@Registration_2", reg2TextBox.Text);
                cmd.Parameters.AddWithValue("@Expiry_Date", dateTimePicker1.Value.Date);
                cmd.ExecuteNonQuery();
                // call show permits method after query is executed
                ShowAllPermits();
                //call clear textboxes method
                clearTextBoxes();
                //show message to user
                MessageBox.Show("Entry successfully added!");

            } catch (Exception ex) {

                MessageBox.Show(ex.Message);
            }
        }
        // update entry button click function
        private void button3_Click(object sender, EventArgs e) {
            this.Cursor = Cursors.WaitCursor;
            updateEntry();
            this.Cursor = Cursors.Default;
        }

        // method to update entry
        private void updateEntry() {
            if (Results.SelectedRows.Count > 0) {
                // permit ID is selected based on the selected index in the datatable
                int selectedIndext = Results.SelectedRows[0].Index;
                int permitID = int.Parse(Results[0, selectedIndext].Value.ToString());

                string query = "UPDATE Vehicle SET Vehicle_Model = @Vehicle_Model,Registration = @Registration_1, Owner = @Owner, Apartment = @Apartment, Registration_2 = @Registration_2 ," +
                    "Expiry_Date = @Expiry_Date WHERE Permit_ID =" + permitID;

                try {

                    OleDbCommand cmd = new OleDbCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Vehicle_Model", VehicleTextBox.Text);
                    cmd.Parameters.AddWithValue("@Registration_1", reg1TextBox.Text);
                    cmd.Parameters.AddWithValue("@Owner", NameTextBox.Text);
                    cmd.Parameters.AddWithValue("@Apartment", int.Parse(AptTextBox.Text));
                    cmd.Parameters.AddWithValue("@Registration_2", reg2TextBox.Text);
                    cmd.Parameters.AddWithValue("@Expiry_Date", dateTimePicker1.Value.Date);

                    cmd.ExecuteNonQuery();
                    ShowAllPermits();
                    clearTextBoxes();
                    MessageBox.Show("Entry successfully updated!");

                } catch (Exception ex) {

                    MessageBox.Show(ex.Message);
                }
            }
        }

        // method to clear the textboxes as needed
        private void clearTextBoxes() {
            NameTextBox.Clear();
            VehicleTextBox.Clear();
            reg1TextBox.Clear();
            reg2TextBox.Clear();
            AptTextBox.Clear();
        }

        // count permits in use button click
        private void CountPermitsInUseBtn_Click(object sender, EventArgs e) {
            this.Cursor = Cursors.WaitCursor;
            // call required functions
            DisplayPermitsInUse();
            DisplayPercentageInUse();
            DisplayTotalPermitsIssued();
            this.Cursor = Cursors.Default;
        }

        // method to display the number of permits in use in the system
        private void DisplayPermitsInUse() {

            string query = "SELECT SUM(In_Use) FROM Vehicle";
            try {

                OleDbCommand cmd = new OleDbCommand(query, conn);
                object result = cmd.ExecuteScalar();

                if (result != null) {
                    totalpermitstextbox.Text = Convert.ToString(cmd.ExecuteScalar());
                }

            } catch (Exception ex) {

                MessageBox.Show(ex.Message);
            }
        }

        // method to display the percentage of permits in use as a function of the total number
        // of permits issued
        private void DisplayPercentageInUse() {

            string query = "SELECT SUM(In_Use)/COUNT(Permit_ID) FROM Vehicle";
            try {

                OleDbCommand cmd = new OleDbCommand(query, conn);
                object result = cmd.ExecuteScalar();

                if (result != null) {

                    // convert to double 
                    double message = Convert.ToDouble(cmd.ExecuteScalar());
                    message = message * 100;
                    percentageInUseText.Text = Convert.ToString(message);
                }
            } catch (Exception ex) {

                MessageBox.Show(ex.Message);
            }
        }

        // method to display total permits issued
        private void DisplayTotalPermitsIssued() {

            string query = "SELECT COUNT(Permit_ID) FROM Vehicle";
            try {

                OleDbCommand cmd = new OleDbCommand(query, conn);
                object result = cmd.ExecuteScalar();

                if (result != null) {

                    totalPermitsIssued.Text = Convert.ToString(cmd.ExecuteScalar());
                }
            } catch (Exception ex) {

                MessageBox.Show(ex.Message);
            }
        }

        private void label8_Click(object sender, EventArgs e) {

        }

        private void textBox1_TextChanged(object sender, EventArgs e) {

        }

        // button click to set permit to in use
        private void button5_Click(object sender, EventArgs e) {
            this.Cursor = Cursors.WaitCursor;
            toggleUseToOne();
            this.Cursor = Cursors.Default;
        }
        // method to set permit to be in use (in use =1)
        private void toggleUseToOne() {
            if (Results.SelectedRows.Count > 0) {

                int selectedIndext = Results.SelectedRows[0].Index;
                int permitID = int.Parse(Results[0, selectedIndext].Value.ToString());

                string query = "UPDATE Vehicle SET In_Use=1 WHERE Permit_ID =" + permitID;


                try {

                    OleDbCommand cmd = new OleDbCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    ShowAllPermits();
                    clearTextBoxes();
                    MessageBox.Show("Permit set to in use !");

                } catch (Exception ex) {

                    MessageBox.Show(ex.Message);
                }
            }
        }
        // button click to set permit to be not in use
        private void button6_Click(object sender, EventArgs e) {
            this.Cursor = Cursors.WaitCursor;
            toggleUseToZero();
            this.Cursor = Cursors.Default;
        }
        //method to set permit to be not in use (in use =0)
        private void toggleUseToZero() {
            if (Results.SelectedRows.Count > 0) {

                int selectedIndext = Results.SelectedRows[0].Index;
                int permitID = int.Parse(Results[0, selectedIndext].Value.ToString());

                string query = "UPDATE Vehicle SET In_Use=0 WHERE Permit_ID =" + permitID;
                try {

                    OleDbCommand cmd = new OleDbCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    ShowAllPermits();
                    clearTextBoxes();
                    MessageBox.Show("Permit set to not in use !");

                } catch (Exception ex) {

                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
