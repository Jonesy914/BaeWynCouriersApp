using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaeWynCouriersApp
{
    public partial class Main : Form
    {
        User currentUser = new User();      //Initialise user object.
        DataAccess db = new DataAccess();   //Initialise data access object.

        public Main(User currentUserPass)
        {            
            currentUser = currentUserPass;
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (System.Windows.Forms.Application.MessageLoop)
            {
                // WinForms app
                System.Windows.Forms.Application.Exit();
            }
            else
            {
                // Console app
                System.Environment.Exit(1);
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {            
            lblCurrentUser.Text = lblCurrentUser.Text + " " + currentUser.Name; //Display current user's name.
            this.Width = 269;

            try
            {
                List<MenuItem> menuItems = currentUser.GetMenuItemsByAccessLevel(); //Use method to get menu items bases on AccessLevel and store in a list.
                lstMenu.DataSource = menuItems;                                     //Sets the data source for the menu list as this list.
                lstMenu.DisplayMember = "Name";                                     //Sets the display member for the list as the Name field.
                lstMenu.ValueMember = "MenuItemId";                                 //Sets the value of combo box as the MenuItemId field.
            }
            catch (Exception ex)
            {
                //Any errors thrown further down the stack are caught here.
                DialogResult msgErr = MessageBox.Show("Error getting data. \n Do you want more info?", "System Message...", MessageBoxButtons.YesNoCancel);

                //If user selected yes or no for more info.
                if (msgErr == DialogResult.Yes)
                {
                    MessageBox.Show(ex.ToString());    //Display error message as a message box.
                }
            }
        }

        private void lstMenu_Click(object sender, EventArgs e)
        {
            grpClients.Visible = false;
            grpDeliveries.Visible = false;
            grpReports.Visible = false;

            this.Width = 1016;

            switch (lstMenu.Text)
            {
                case "Clients":
                    setupGroupBox(grpClients);
                    break;
                case "Deliveries":

                    //Populate combo boxes.
                    DataSet dsClients = db.ImportDbRecords("Select * From Clients");
                    setupComboBox(cmbDelClientId, dsClients, "ClientId", "BusinessName");

                    DataSet dsTimeBlocks = db.ImportDbRecords("Select * From TimeBlocks");
                    setupComboBox(cmbTimeBlockId, dsTimeBlocks, "TimeBlockId", "BlockDetail");

                    DataSet dsUsers = db.ImportDbRecords("Select * From Users Where AccessLevel = 4");
                    setupComboBox(cmbDelUserId, dsUsers, "UserId", "Name");

                    //Set which controls are visible to user based on access level.
                    if (currentUser.AccessLevel < 4)
                    {
                        pnlDelAdminControl.Visible = true;
                    }
                    else
                    {
                        pnlDelCourierControl.Visible = true;
                    }

                    setupGroupBox(grpDeliveries);
                    break;
                case "Reports":

                    DataSet dsRep1Couriers = db.ImportDbRecords("Select * From Users Where AccessLevel = 4");
                    setupComboBox(cmbRep1Courier, dsRep1Couriers, "UserId", "Name");

                    if (currentUser.AccessLevel == 3)   //Logistics Coordinator can only see Courier reports.
                    {
                        tabReports.TabPages.Remove(tabRep3);
                        tabReports.TabPages.Remove(tabRep4);
                    }

                    setupGroupBox(grpReports);                    
                    break;
            }
        }

        public void setupComboBox(ComboBox combobox, DataSet dataSet, string valueMember, string displayMember)
        {
            combobox.DataSource = dataSet.Tables[0];
            combobox.ValueMember = valueMember;
            combobox.DisplayMember = displayMember;            
        }

        public void setupGroupBox(GroupBox groupbox)
        {
            groupbox.Location = new Point(241, 29);
            groupbox.Size = new Size(719, 449);
            groupbox.Visible = true;
        }

        public void displayErrorMessage(Exception ex)
        {
            //Any errors thrown further down the stack are caught here.
            DialogResult msgErr = MessageBox.Show("Error getting data. \n Do you want more info?", "System Message...", MessageBoxButtons.YesNoCancel);

            //If user selected yes or no for more info.
            if (msgErr == DialogResult.Yes)
            {
                MessageBox.Show(ex.ToString());    //Display error message as a message box.
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            var loginForm = (Login)Tag; //Set Login form as variable loginForm.
            loginForm.Show();           //Opens Login form.
            Close();                    //Close current form.
        }

        //----------------------Clients----------------------//

        private void clearClientFields()
        {
            txtClientId.Clear();
            txtBusinessName.Clear();
            txtAddress.Clear();
            txtPhoneNumber.Clear();
            txtEmail.Clear();
            txtNotes.Clear();
            chkContracted.Checked = false;
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtBusinessName.Text))
            {
                try
                {
                    //Create client object from input fields.
                    Client newClient = new Client { BusinessName = txtBusinessName.Text, Address = txtAddress.Text, PhoneNumber = txtPhoneNumber.Text, Email = txtEmail.Text, Notes = txtNotes.Text, Contracted = chkContracted.Checked };

                    newClient.AddClient();    //Add client using client object.

                    MessageBox.Show(newClient.BusinessName + " successfully created.", "System Information...");

                    clearClientFields();    //Reset client text fields (should only happen if successful insert).
                    searchClients();        //Refresh data grid.
                }
                catch (Exception ex)
                {
                    displayErrorMessage(ex);
                }
            }
            else
            {
                MessageBox.Show("'Business Name' is a required field.", "Invalid Selection...");
            }
        }

        private void btnUpdateClient_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtClientId.Text))
            {
                try
                {
                    //Create client object from input fields
                    Client currClient = new Client { ClientId = int.Parse(txtClientId.Text), BusinessName = txtBusinessName.Text, Address = txtAddress.Text, PhoneNumber = txtPhoneNumber.Text, Email = txtEmail.Text, Notes = txtNotes.Text, Contracted = chkContracted.Checked };
 
                    currClient.UpdateClient();  //Update client using client object.

                    MessageBox.Show(currClient.BusinessName + " successfully updated.", "System Information...");

                    searchClients();    //Refresh data grid.
                }
                catch (Exception ex)
                {
                    displayErrorMessage(ex);
                }
            }
            else
            {
                MessageBox.Show("Select a Client record from the list to update.", "Invalid Selection...");
            }
        }

        private void btnSearchClients_Click(object sender, EventArgs e)
        {
            searchClients();
        }

        private void searchClients()
        {
            try
            {
                DataSet dsClients = db.ImportDbRecords("Select * From Clients");  //Get all clients set as dataset.
                dgvClients.DataSource = dsClients.Tables[0];        //Populate gridview with clients dataset
            }
            catch (Exception ex)
            {
                displayErrorMessage(ex);
            }
        }

        private void dgvClients_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvClients.CurrentRow.Index != dgvClients.Rows.Count - 1)   //Check if selected row is not empty. Referenced from: https://stackoverflow.com/questions/8006774/how-to-check-if-a-selected-row-in-a-datagridview-is-emptyhas-no-item-c-sharp
            {
                if (!dgvClients.AreAllCellsSelected(true))
                {
                    txtClientId.Text = dgvClients.SelectedCells[0].Value.ToString();
                    txtBusinessName.Text = dgvClients.SelectedCells[1].Value.ToString();
                    txtAddress.Text = dgvClients.SelectedCells[2].Value.ToString();
                    txtPhoneNumber.Text = dgvClients.SelectedCells[3].Value.ToString();
                    txtEmail.Text = dgvClients.SelectedCells[4].Value.ToString();
                    txtNotes.Text = dgvClients.SelectedCells[5].Value.ToString();
                    chkContracted.Checked = (bool)dgvClients.SelectedCells[6].Value;
                }
            }
        }

        private void btnClientClear_Click(object sender, EventArgs e)
        {
            clearClientFields();
        }

        //----------------------Deliveries----------------------//

        private void dtpDelDate_Leave(object sender, EventArgs e)
        {
            _ = checkInvalidDate();
        }

        private bool checkInvalidDate()
        {
            DateTime dateValue = dtpDelDate.Value.Date;
            string day = dateValue.DayOfWeek.ToString();
            bool check = false;

            if (day == "Sunday")
            {
                MessageBox.Show("Delivery cannot be on a Sunday.", "Invalid Selection...");
                dtpDelDate.Value = dtpDelDate.Value.AddDays(1);
                check = true;
            }

            if (dateValue < DateTime.Now.Date)
            {
                MessageBox.Show("Cannot select past dates.", "Invalid Selection...");
                dtpDelDate.Value = DateTime.Now.Date;
                check = true;
            }

            return check;
        }

        private void btnAddDelivery_Click(object sender, EventArgs e)
        {
            //Create delivery object from input fields.
            Delivery newDelivery = new Delivery { ClientId = (int)cmbDelClientId.SelectedValue, DeliveryDate = dtpDelDate.Value.Date, TimeBlockId = (int)cmbTimeBlockId.SelectedValue, UserId = (int)cmbDelUserId.SelectedValue, StatusCode = "U" };

            //Check for invalid date selection.
            if (!checkInvalidDate())
            {
                //Check user lunch and time block lunch are not the same.
                if (!newDelivery.CheckUserLunch())
                {
                    //Check delivery record with selected date, time slot and users exists.
                    if (!newDelivery.CheckDeliveryExists(false))
                    {
                        //Add delivery.
                        try
                        {
                            newDelivery.AddDelivery();    //Add delivery using delivery object.

                            MessageBox.Show("Delivery successfully created.", "System Information...");

                            searchDeliveries(); //Refresh data grid.
                        }
                        catch (Exception ex)
                        {
                            displayErrorMessage(ex);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Delivery with this criteria already exists.", "Invalid Selection...");
                    }
                }
                else
                {
                    MessageBox.Show(cmbDelUserId.Text + " is on lunch at time slot " + cmbTimeBlockId.Text + ".", "Invalid Selection...");
                }
            }                       
        }

        private void btnUpdateDelivery_Click(object sender, EventArgs e)
        {
            //Check DeliveryId is not null
            if (!string.IsNullOrEmpty(txtDeliveryId.Text))
            {
                //Create delivery object from input fields.
                Delivery currDelivery = new Delivery { DeliveryId = int.Parse(txtDeliveryId.Text), ClientId = (int)cmbDelClientId.SelectedValue, DeliveryDate = dtpDelDate.Value.Date, TimeBlockId = (int)cmbTimeBlockId.SelectedValue, UserId = (int)cmbDelUserId.SelectedValue };

                if (!checkInvalidDate())
                {
                    //Check user lunch and time block lunch are not the same.
                    if (!currDelivery.CheckUserLunch())
                    {
                        //Check delivery record with selected date, time slot and users exists.
                        if (!currDelivery.CheckDeliveryExists(true))
                        {
                            //Update delivery.
                            try
                            {
                                currDelivery.UpdateDelivery();    //Update delivery using delivery object.

                                MessageBox.Show("Delivery successfully updated.", "System Information...");

                                searchDeliveries(); //Refresh data grid.
                            }
                            catch (Exception ex)
                            {
                                displayErrorMessage(ex);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Delivery with this criteria already exists.", "Invalid Selection...");
                        }
                    }
                    else
                    {
                        MessageBox.Show(cmbDelUserId.Text + " is on lunch at time slot " + cmbTimeBlockId.Text + ".", "Invalid Selection...");
                    }
                }
            }
            else
            {
                MessageBox.Show("Select a Delivery record from the list to update.", "Invalid Selection...");
            }
        }

        private void btnSearchDeliveries_Click(object sender, EventArgs e)
        {
            searchDeliveries();
        }

        private void searchDeliveries()
        {
            try
            {
                if (currentUser.AccessLevel < 4) //If user not courier.
                {
                    DataSet dsDeliveries = db.ImportDbRecords("Select * From Deliveries");  //Get all deliveries set as dataset.
                    dgvDeliveries.DataSource = dsDeliveries.Tables[0];        //Populate gridview with deliveries dataset
                }
                else
                {
                    //Get current courier's unaccepted and accepted deliveries set as dataset.
                    DataSet dsDeliveries = db.ImportDbRecords("Select * From Deliveries Where UserId = " + currentUser.UserId + " and StatusCode In ('A', 'U')");
                    dgvDeliveries.DataSource = dsDeliveries.Tables[0];  //Populate gridview with deliveries dataset
                }
            }
            catch (Exception ex)
            {
                displayErrorMessage(ex);
            }
        }

        private void dgvDeliveries_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDeliveries.CurrentRow.Index != dgvDeliveries.Rows.Count - 1) //Check if selected row is not empty. Referenced from: https://stackoverflow.com/questions/8006774/how-to-check-if-a-selected-row-in-a-datagridview-is-emptyhas-no-item-c-sharp
            {
                if (!dgvDeliveries.AreAllCellsSelected(true))
                {
                    txtDeliveryId.Text = dgvDeliveries.SelectedCells[0].Value.ToString();
                    cmbDelClientId.SelectedValue = dgvDeliveries.SelectedCells[1].Value;
                    dtpDelDate.Value = (DateTime)dgvDeliveries.SelectedCells[2].Value;
                    cmbTimeBlockId.SelectedValue = dgvDeliveries.SelectedCells[3].Value;
                    cmbDelUserId.SelectedValue = dgvDeliveries.SelectedCells[4].Value;
                    txtDelStatus.Text = dgvDeliveries.SelectedCells[5].Value.ToString();
                }
            }
        }

        private void updateDeliveryStatus(string statuscode, string message)
        {
            if (!string.IsNullOrEmpty(txtDeliveryId.Text))
            {
                try
                {
                    Delivery currDelivery = new Delivery { DeliveryId = int.Parse(txtDeliveryId.Text), StatusCode = statuscode };
                    currDelivery.UpdateDeliveryStatus();
                    MessageBox.Show(message, "System Information...");
                    searchDeliveries();
                }
                catch (Exception ex)
                {
                    displayErrorMessage(ex);
                }
            }
            else
            {
                MessageBox.Show("Select a Delivery record from the list to update.", "Invalid Selection...");
            }
        }

        private void btnAcceptDelivery_Click(object sender, EventArgs e)
        {
            updateDeliveryStatus("A", "Delivery accepted.");
        }

        private void btnCompleteDelivery_Click(object sender, EventArgs e)
        {
            updateDeliveryStatus("C", "Delivery completed.");
        }

        private void btnCancelDelivery_Click(object sender, EventArgs e)
        {
            updateDeliveryStatus("X", "Delivery cancelled.");
        }

        //----------------------Reports----------------------//

        private void btnRep1Search_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet dsRep1 = db.ImportDbRecords("Select * From Deliveries Where UserId = " + cmbRep1Courier.SelectedValue + " and DeliveryDate = '" + dtpRep1Date.Value.Date.ToString("yyyy-MM-dd") + "'");  //Get deliveries set as dataset.
                dgvRep1.DataSource = dsRep1.Tables[0];  //Populate gridview with dataset
            }
            catch (Exception ex)
            {
                displayErrorMessage(ex);
            }
        }

        private void btnRep2Search_Click(object sender, EventArgs e)
        {
            DateTime currentDate = DateTime.Today;                                      //Get today's date.
            DateTime startDate = new DateTime(currentDate.Year, currentDate.Month, 1);  //Get start of current month.
            DateTime endDate = startDate.AddMonths(1).AddDays(-1);                      //Work out end of current month.
            try
            {
                DataSet dsRep2 = db.ImportDbRecords("Select * From Deliveries Where DeliveryDate Between '" + startDate.ToString("yyyy-MM-dd") + "' and '" + endDate.ToString("yyyy-MM-dd") + "'");  //Get deliveries set as dataset.
                dgvRep2.DataSource = dsRep2.Tables[0];  //Populate gridview with dataset
            }
            catch (Exception ex)
            {
                displayErrorMessage(ex);
            }
        }

        private void dtpRep3Date_ValueChanged(object sender, EventArgs e)
        {
            txtRep3Month.Text = dtpRep3Date.Value.Date.ToString("MMMM") + " " + dtpRep3Date.Value.Date.ToString("yyyy");
        }

        private void btnRep3Search_Click(object sender, EventArgs e)
        {
            DateTime startDate = new DateTime(dtpRep3Date.Value.Date.Year, dtpRep3Date.Value.Date.Month, 1);    //Get start of selected month.
            DateTime endDate = startDate.AddMonths(1).AddDays(-1);                                              //Work out end of selected month.
            try
            {
                DataSet dsRep3Con = db.ImportDbRecords("Select D.* From Deliveries As D Inner Join Clients C On D.ClientId = C.ClientId Where DeliveryDate Between '" + startDate.ToString("yyyy-MM-dd") + "' and '" + endDate.ToString("yyyy-MM-dd") + "' And Contracted = 'True'");  //Get deliveries set as dataset.
                dgvRep3Con.DataSource = dsRep3Con.Tables[0];  //Populate Contracted gridview with dataset

                DataSet dsRep3Non = db.ImportDbRecords("Select D.* From Deliveries As D Inner Join Clients C On D.ClientId = C.ClientId Where DeliveryDate Between '" + startDate.ToString("yyyy-MM-dd") + "' and '" + endDate.ToString("yyyy-MM-dd") + "' And Contracted = 'False'");  //Get deliveries set as dataset.
                dgvRep3Non.DataSource = dsRep3Non.Tables[0];  //Populate Non-Contracted gridview with dataset
            }
            catch (Exception ex)
            {
                displayErrorMessage(ex);
            }
        }

        private void dtpRep4Date_ValueChanged(object sender, EventArgs e)
        {
            txtRep4Month.Text = dtpRep3Date.Value.Date.ToString("MMMM") + " " + dtpRep3Date.Value.Date.ToString("yyyy");
        }

        private void btnRep4Search_Click(object sender, EventArgs e)
        {
            DateTime startDate = new DateTime(dtpRep4Date.Value.Date.Year, dtpRep3Date.Value.Date.Month, 1);    //Get start of selected month.
            DateTime endDate = startDate.AddMonths(1).AddDays(-1);                                              //Work out end of selected month.

            int allClientCount = 0;
            int delConCount = 0;
            int delNonCount = 0;

            try
            {
                allClientCount = db.GetDbRecordCount("Select Count(*) From Clients Where Contracted = 'True'");
                delConCount = db.GetDbRecordCount("Select Count(*) From Deliveries As D Inner Join Clients As C On D.ClientId = C.ClientId Where D.DeliveryDate Between '" + startDate.ToString("yyyy-MM-dd") + "' and '" + endDate.ToString("yyyy-MM-dd") + "' And C.Contracted = 'True'");
                delNonCount = db.GetDbRecordCount("Select Count(*) From Deliveries As D Inner Join Clients As C On D.ClientId = C.ClientId Where D.DeliveryDate Between '" + startDate.ToString("yyyy-MM-dd") + "' and '" + endDate.ToString("yyyy-MM-dd") + "' And C.Contracted = 'False'");

                ReportsLogic report = new ReportsLogic { AllClientCount = allClientCount, DelConCount = delConCount, DelNonCount = delConCount };

                txtRep4ClientVal.Text = report.ClientValue(allClientCount).ToString("C");
                txtRep4DelConVal.Text = report.ContractDeliveryValue(delConCount).ToString("C");
                txtRep4DelNonVal.Text = report.NonContractDeliveryValue(delNonCount).ToString("C");
                txtRep4MonthVal.Text = report.TotalMonthValue(allClientCount, delConCount, delNonCount).ToString("C");
            }
            catch (Exception ex)
            {
                displayErrorMessage(ex);
            }
        }
    }
}
