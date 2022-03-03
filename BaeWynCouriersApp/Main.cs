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
            lblCurrentUser.Text = lblCurrentUser.Text + " " + currentUser.Name;

            try
            {
                List<MenuItem> menuItems = currentUser.GetMenuItemsByAccessLevel();        //Use web service method to get all available festivals and store as a dataset.
                lstMenu.DataSource = menuItems;   //Sets the data source for cmbFestivalID combobox as this dataset.
                lstMenu.DisplayMember = "Name";       //Sets the display text for the combobox as the FestivalName field.
                lstMenu.ValueMember = "MenuItemId";           //Sets the value of combo box as the FestivalId field.
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

            switch (lstMenu.SelectedItem)
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
            DataAccess db = new DataAccess();

            db.AddClient(txtBusinessName.Text, txtAddress.Text, txtPhoneNumber.Text, txtEmail.Text, txtNotes.Text, chkContracted.Checked);
        }
    }
}
