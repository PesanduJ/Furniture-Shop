using System;
using System.Linq;

namespace Furniture_Shop
{
    public partial class Update_Item : MetroFramework.Forms.MetroForm
    {
        string username = null;
        int item_ID = 0;
        public Update_Item(string username, int item_ID)
        {
            InitializeComponent();
            this.username = username;
            this.item_ID = item_ID;
        }

        private void txt_No_Of_Items_Leave(object sender, EventArgs e)
        {
            
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (txt_Password.Text == txt_Renter_Password.Text)
            {
                DatabaseConnection database = new DatabaseConnection();

                int verifyOldPassword = database.verifyoldPassword(username, txt_Password.Text);
                
                if (verifyOldPassword == 1)
                {
                    
                    database.updateItemDetails(username, item_ID, int.Parse(txt_Item_Bought_Price.Text), int.Parse(txt_Item_Selling_Price.Text), int.Parse(txt_Item_Discount_Price.Text), int.Parse(txt_No_Of_Items.Text), int.Parse(lbl_Items_Bought_Cost.Text), int.Parse(lbl_Items_Selling_Total.Text), int.Parse(lbl_Profit_Without_Dis.Text), int.Parse(lbl_Profit_With_Dis.Text), dt_Date_Of_Purchase.Value.ToString(), dt_Supplier_Warranty.Value);
                    
                    this.Close();
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "Entered Password Is Incorrect!");
                }

            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Entered Password Is Incorrect!");
            }
        }

        private void ck_Supplier_Warranty_CheckedChanged(object sender, EventArgs e)
        {
            if (ck_Supplier_Warranty.Checked)
                dt_Supplier_Warranty.Enabled = true;
            else
                dt_Supplier_Warranty.Enabled = false;
        }

        private void txt_Password_Leave(object sender, EventArgs e)
        {
            if(txt_Password.Text.Length == 0)
            {
                MetroFramework.MetroMessageBox.Show(this, "Password Cannot Be Null!");
            }else if(txt_Password.Text.Length > 25)
            {
                MetroFramework.MetroMessageBox.Show(this, "Password Cannot Be More Than 25 Characters!");
            }
        }

        private void txt_Renter_Password_Leave(object sender, EventArgs e)
        {
            if (txt_Password.Text != txt_Renter_Password.Text)
            {
                MetroFramework.MetroMessageBox.Show(this, "Passwords Does Not Match!");
            }
            else
            {
                if (txt_Password.Text.Length == 0)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Password Cannot Be Null!");
                }
                else if (txt_Password.Text.Length > 25)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Password Cannot Be More Than 25 Characters!");
                }
            }
        }
    }
}
