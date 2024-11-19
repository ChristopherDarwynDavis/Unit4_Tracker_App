using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/* Author: Christopher Davis
 * Date: 11.25.2021
 * Description: This is the main form that houses the loadpanel
 * as well as keeps the menu button avalible
 */
namespace DavCFinalProject
{
    public partial class trackerForm : Form
    {
        public trackerForm()
        {
            InitializeComponent();
            //Calling the loadEvent method and passing it dashboardForm
            loadEvent(new dashboardForm());
        }
        private void menuButton_Click(object sender, EventArgs e)
        {
            //If the menuPanel is visible
            if (menuPanel.Visible == true)
            {
                //Setting the menuPanel's visible property to false
                menuPanel.Visible = false;
            }
            //If the menuPanel isn't visible
            else
            {
                //Setting the menuPanel's visible property to true
                menuPanel.Visible = true;
            }
        }

        private void dashboardButton_Click(object sender, EventArgs e)
        {
            //Calling the loadEvnt and passing the form to load
            loadEvent(new dashboardForm());
            //Changes the title's text
            titleLabel.Text = "Dashboard";
        }

        private void seriesButton_Click(object sender, EventArgs e)
        {
            //Calling the loadEvnt and passing the form to load
            loadEvent(new seriesWatchedForm());
            //Changes the title's text
            titleLabel.Text = "Series Watched";
        }

        private void preOrderButton_Click(object sender, EventArgs e)
        {
            //Calling the loadEvnt and passing the form to load
            loadEvent(new preOrderForm());
            //Changes the title's text
            titleLabel.Text = "Pre-Orders";
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            //Calling the loadEvent and passing the form to load
            loadEvent(new settingsForm());
            //Changes the title's text
            titleLabel.Text = "Settings";
        }

        private void loadEvent(object form)
        {
            //If loadPanel's controls count is greater than 0
            if (loadPanel.Controls.Count > 0)
            {
                //Removes the control at 0
                loadPanel.Controls.RemoveAt(0);
            }
            //Creating a Form called load and giving it properties
            Form load = form as Form;
            load.TopLevel = false;
            load.TopMost = false;
            load.Dock = DockStyle.Fill;
            //Adding the load Form to loadPanels controls
            loadPanel.Controls.Add(load);
            //Displaying the load form
            load.Show();
            //Setting menuPanel's visibility to false
            menuPanel.Visible = false;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Closes the program
            this.Close();
        }
    }
}
