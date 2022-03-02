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
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
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
            var loginForm = (Login)Tag;   //Set Main form as variable mainForm.
            loginForm.Show();            //Opens Main form.
            Close();                    //Close current form.
        }
    }
}
