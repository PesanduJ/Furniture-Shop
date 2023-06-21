using System;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Furniture_Shop
{
    public partial class DetailsPage : MetroFramework.Forms.MetroForm
    {
        DatabaseDLL.Database database;
        string username, item_Name;
        public DetailsPage(string username, string item_Name)
        {
            InitializeComponent();
            this.Text = item_Name;
            this.Refresh();
            this.username = username;
            this.item_Name = item_Name;
            setData();
        }

        private void btn_Sell_Items_Click(object sender, EventArgs e)
        {
            string sel_Item_Type = null;
            if (rb_Offline.Checked)
                sel_Item_Type = "OFFLINE";
            else if (rb_Online.Checked)
                sel_Item_Type = "ONLINE";
            try
            {
                if (decimal.ToInt64(num_Items_Sold.Value) > int.Parse(lbl_Item_Count.Text))
                {
                    MetroFramework.MetroMessageBox.Show(this, "Items Sold Value Cannot Be Larger Than Items In Stock!");
                }
                else
                {
                    DialogResult confirmDelete = MessageBox.Show(this, "ARE YOU SURE YOU WANT TO DEDUCT " + num_Items_Sold.Value.ToString() + " ITEMS?", "SURE TO CONTINUE?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                    if (confirmDelete == DialogResult.Yes)
                    {
                        DatabaseConnection database = new DatabaseConnection();
                        int itemID = database.getItemId(item_Name,lbl_Item_Code.Text);
                        database.addItemsSold(itemID, username, txt_Cus_Name.Text, txt_Cus_Contact_No.Text, DateTime.Now, num_Items_Sold.Value, sel_Item_Type);
                        database.substractItems(username, item_Name, lbl_Item_Supplier.Text, num_Items_Sold.Value);
                        
                        num_Items_Sold.Value = 1;
                        setData();
                    }
                }
            }catch(Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message);
            }
        }

        private void btn_Remove_Iem_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult confirmDelteItem = MessageBox.Show(this, "Sure You Want TO Delete This Item?", "Sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
                if (confirmDelteItem == DialogResult.Yes)
                {
                    DatabaseConnection database = new DatabaseConnection();
                    database.deleteItem(username.ToString(), lbl_Item_Supplier.Text, item_Name);
                    this.Close();
                }
            }catch(Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message);
            }
        }

        private void btn_Update_Item_Click(object sender, EventArgs e)
        {
            DatabaseConnection database = new DatabaseConnection();
            int item_ID = database.getItemId(item_Name, lbl_Item_Code.Text);
            Update_Item change_Price = new Update_Item(username,item_ID);
            change_Price.ShowDialog();
        }

        private void btn_View_Sold_Items_Click(object sender, EventArgs e)
        {
            
            DatabaseConnection database = new DatabaseConnection();
            View_Sold_Items view_Sold_Items = new View_Sold_Items(database.getItemId(item_Name, lbl_Item_Code.Text),username);
            view_Sold_Items.ShowDialog();
        }

        public void setData()
        {
            try
            {
                using (var databaseConnection = new SQLiteConnection("URI=file:data_table.db"))
                {
                    databaseConnection.Open();
                    using (var command = new SQLiteCommand(databaseConnection))
                    {
                        command.CommandText = "SELECT * FROM Items WHERE Username = @username AND Item_Name = @itemName";
                        command.Parameters.AddWithValue("@username", username);
                        command.Parameters.AddWithValue("@itemName", item_Name);
                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                var imageName = reader["ImageName"].ToString();
                                if (File.Exists($"./images/{imageName}"))
                                {
                                    pb_Item_Image.Image = Image.FromFile($"./images/{imageName}");
                                }
                                else
                                {
                                    pb_Item_Image.Image = Image.FromFile("./images/image-not-found-300x169.jpg");
                                }

                                lbl_Item_Category.Text = reader["Categoryname"].ToString();
                                lbl_Item_Supplier.Text = reader["Supplier_Name"].ToString();
                                lbl_name.Text = reader["Item_Name"].ToString();
                                lbl_Bought_Price.Text = reader["Item_Bought_Price"].ToString();
                                lbl_Selling_Price.Text = reader["Item_Selling_Price"].ToString();
                                lbl_Discount_Price.Text = reader["Item_Discount_Price"].ToString();
                                lbl_Item_Count.Text = reader["Item_Count"].ToString();
                                lbl_Total_Items_Purchased.Text = reader["Total_Items_Purchased"].ToString();
                                lbl_Bought_Cost.Text = reader["Items_Bought_Cost"].ToString();
                                lbl_Selling_Total.Text = reader["Items_Selling_Total"].ToString();
                                lbl_Profit_Without_Discount.Text = reader["Profit_Without_Dis"].ToString();
                                lbl_ProfitWith_Discount.Text = reader["Profit_With_Dis"].ToString();
                                lbl_Date_Of_Purchase.Text = reader["Date_Of_Purchase"].ToString().Replace("12:00:00 AM", "");
                                lbl_Supplier_Warranty.Text = reader["Supplier_Warranty"].ToString().Replace("12:00:00 AM", "");
                                lbl_Item_Code.Text = reader["CodeNo"].ToString();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message);
            }

        }
    }
}
