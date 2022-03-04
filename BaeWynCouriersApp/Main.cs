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
        User currentUser = new User();
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

            try
            {
                List<MenuItem> menuItems = currentUser.GetMenuItemsByAccessLevel(); //Use web service method to get all available festivals and store as a list.
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

            switch (lstMenu.Text)
            {
                case "Clients":
                    grpClients.Visible = true;
                    break;
                case "Deliveries":
                    grpDeliveries.Visible = true;
                    break;
                case "Reports":
                    grpReports.Visible = true;
                    break;
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            var loginForm = (Login)Tag; //Set Login form as variable loginForm.
            loginForm.Show();           //Opens Login form.
            Close();                    //Close current form.
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            try
            {
                //Create client object from input fields
                Client newClient = new Client { BusinessName = txtBusinessName.Text, Address = txtAddress.Text, PhoneNumber = txtPhoneNumber.Text, Email = txtEmail.Text, Notes = txtNotes.Text, Contracted = chkContracted.Checked };
                
                db.AddClient(newClient);    //Add client using client object

                MessageBox.Show(newClient.BusinessName + " successfully created!", "System Information...");

                //Reset text fields (should only happen if successful insert)
                txtBusinessName.Clear();
                txtAddress.Clear();
                txtPhoneNumber.Clear();
                txtEmail.Clear();
                txtNotes.Clear();
                chkContracted.Checked = false;
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
    }
}
