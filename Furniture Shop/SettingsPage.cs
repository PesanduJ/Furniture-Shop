using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Furniture_Shop
{
    public partial class SettingsPage : MetroFramework.Forms.MetroForm
    {
        public SettingsPage(string username)
        {
            InitializeComponent();
            lbl_Username.Text = username;
        }

        private void btn_Change_Password_Click(object sender, EventArgs e)
        {
            try {
                if (txt_Old_Password.Text.Length <= 5 || txt_New_Password.Text.Length <= 5 || txt_Confirm_Password.Text.Length <= 5)
                    MetroFramework.MetroMessageBox.Show(this, "Passwords Should Be Greater Than 5 Character!");
                else
                {
                    DatabaseConnection database = new DatabaseConnection();
                    int confirmpassword = database.verifyoldPassword(lbl_Username.Text, txt_Old_Password.Text);
                    if (confirmpassword == 1)
                    {
                        database.changePassword(lbl_Username.Text, txt_New_Password.Text);
                        MetroFramework.MetroMessageBox.Show(this, "Password Changed");
                        this.Close();
                    }
                    else
                        MetroFramework.MetroMessageBox.Show(this, "Incorrect Old Password");
                    
                }
            }catch(Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message);
            }
        }

        private void txt_Old_Password_Leave(object sender, EventArgs e)
        {
            if (txt_Old_Password.Text.Length <= 5 || txt_Old_Password.Text.Length >= 25)
                MetroFramework.MetroMessageBox.Show(this, "Password Should Be Between 5 And 25 Characters!");
        }

        private void txt_New_Password_Leave(object sender, EventArgs e)
        {
            if (txt_New_Password.Text.Length <= 5 || txt_New_Password.Text.Length >= 25)
                MetroFramework.MetroMessageBox.Show(this, "Password Should Be Between 5 And 25 Characters!");
        }

        private void txt_Confirm_Password_Leave(object sender, EventArgs e)
        {
            if (txt_Confirm_Password.Text != txt_New_Password.Text)
                MetroFramework.MetroMessageBox.Show(this, "Passwords Does Not Match!");
        }

        private void btn_Monthly_Sales_Click(object sender, EventArgs e)
        {
            Monthly_Sales monthly_Sales = new Monthly_Sales();
            monthly_Sales.ShowDialog();
        }

        private void btn_About_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowDialog();
        }
    }
}
