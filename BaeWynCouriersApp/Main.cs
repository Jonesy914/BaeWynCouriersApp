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

                    DataSet dsClients = db.ImportDbRecords("Clients");
                    setupComboBox(cmbDelClientId, dsClients, "ClientId", "BusinessName");

                    DataSet dsTimeBlocks = db.ImportDbRecords("TimeBlocks");
                    setupComboBox(cmbTimeBlockId, dsTimeBlocks, "TimeBlockId", "BlockDetail");

                    DataSet dsUsers = db.GetAllCouriers();
                    setupComboBox(cmbDelUserId, dsUsers, "UserId", "Name");

                    setupGroupBox(grpDeliveries);
                    break;
                case "Reports":
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

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            try
            {
                //Create client object from input fields.
                Client newClient = new Client { BusinessName = txtBusinessName.Text, Address = txtAddress.Text, PhoneNumber = txtPhoneNumber.Text, Email = txtEmail.Text, Notes = txtNotes.Text, Contracted = chkContracted.Checked };
                
                db.AddClient(newClient);    //Add client using client object.

                MessageBox.Show(newClient.BusinessName + " successfully created.", "System Information...");

                //Reset client text fields (should only happen if successful insert).
                txtBusinessName.Clear();
                txtAddress.Clear();
                txtPhoneNumber.Clear();
                txtEmail.Clear();
                txtNotes.Clear();
                chkContracted.Checked = false;
            }
            catch (Exception ex)
            {
                displayErrorMessage(ex);
            }            
        }

        private void btnUpdateClient_Click(object sender, EventArgs e)
        {
            try
            {
                //Create client object from input fields
                Client currClient = new Client { ClientId = int.Parse(txtClientId.Text), BusinessName = txtBusinessName.Text, Address = txtAddress.Text, PhoneNumber = txtPhoneNumber.Text, Email = txtEmail.Text, Notes = txtNotes.Text, Contracted = chkContracted.Checked };
                
                db.UpdateClient(currClient);    //Update client using client object.

                MessageBox.Show(currClient.BusinessName + " successfully updated.", "System Information...");
            }
            catch (Exception ex)
            {
                displayErrorMessage(ex);
            }
        }

        private void btnSearchClients_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet dsClients = db.ImportDbRecords("Clients");  //Get all clients set as dataset.
                dgvClients.DataSource = dsClients.Tables[0];        //Populate gridview with clients dataset
            }
            catch (Exception ex)
            {
                displayErrorMessage(ex);
            }
        }

        private void dgvClients_CellClick(object sender, DataGridViewCellEventArgs e)
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
            else
            {
                MessageBox.Show("All cells selected.");
            }

        }

        //----------------------Deliveries----------------------//

        private void dtpDelDate_ValueChanged(object sender, EventArgs e)
        {
            DateTime dateValue = dtpDelDate.Value.Date;

            string day = dateValue.DayOfWeek.ToString();
            if (day == "Sunday")
            {
                MessageBox.Show("Delivery cannot be on a Sunday.", "Invalid Selection...");
                dtpDelDate.Value = dtpDelDate.Value.AddDays(1);
            }

            if (dateValue < DateTime.Now.Date)
            {
                MessageBox.Show("Cannot select past dates.", "Invalid Selection...");
                dtpDelDate.Value = DateTime.Now.Date;
            }
        }

        private void btnAddDelivery_Click(object sender, EventArgs e)
        {
            //Create delivery object from input fields.
            Delivery newDelivery = new Delivery { ClientId = (int)cmbDelClientId.SelectedValue, DeliveryDate = dtpDelDate.Value.Date, TimeBlockId = (int)cmbTimeBlockId.SelectedValue, UserId = (int)cmbDelUserId.SelectedValue, StatusCodeId = 1 };

            //Check user lunch and time block lunch are not the same.
            if (!newDelivery.CheckUserLunch())
            {
                //Check delivery record with selected date, time slot and users exists.
                if (!newDelivery.CheckDeliveryExists())
                {
                    //Add delivery.
                    try
                    {
                        db.AddDelivery(newDelivery);    //Add client using client object.

                        MessageBox.Show("Delivery successfully created.", "System Information...");
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

        private void btnSearchDeliveries_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet dsDeliveries = db.ImportDbRecords("Deliveries");  //Get all deliveries set as dataset.
                dgvDeliveries.DataSource = dsDeliveries.Tables[0];        //Populate gridview with deliveries dataset
            }
            catch (Exception ex)
            {
                displayErrorMessage(ex);
            }
        }

        private void dgvDeliveries_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!dgvDeliveries.AreAllCellsSelected(true))
            {
                txtDeliveryId.Text = dgvDeliveries.SelectedCells[0].Value.ToString();
                cmbDelClientId.SelectedValue = dgvDeliveries.SelectedCells[1].Value;
                dtpDelDate.Value = (DateTime)dgvDeliveries.SelectedCells[2].Value;
                cmbTimeBlockId.SelectedValue = dgvDeliveries.SelectedCells[3].Value;
                cmbDelUserId.SelectedValue = dgvDeliveries.SelectedCells[4].Value;
            }
            else
            {
                MessageBox.Show("All cells selected.");
            }
        }
    }
}
