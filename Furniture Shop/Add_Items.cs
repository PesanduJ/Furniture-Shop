using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Furniture_Shop
{
    public partial class Add_Items : MetroFramework.Forms.MetroForm
    {
        string username, imagename;
        public Add_Items(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void Add_Items_Load(object sender, EventArgs e)
        {
            try
            {
                DatabaseConnection database = new DatabaseConnection();
                SQLiteConnection con = new SQLiteConnection(@"URI=file:" + Application.StartupPath + "\\data_table.db");
                con.Open();

                SQLiteCommand cmd = new SQLiteCommand("SELECT Categoryname FROM Category WHERE Username=@Username", con);
                cmd.Parameters.AddWithValue("@Username", username);
                SQLiteDataReader categoryTypes = cmd.ExecuteReader();
                while (categoryTypes.Read())
                {
                    cmb_Category.Items.Add(categoryTypes["Categoryname"].ToString());
                }

                cmd = new SQLiteCommand("SELECT Supplier_Name FROM Supplier WHERE Username=@Username", con);
                cmd.Parameters.AddWithValue("@Username", username);
                SQLiteDataReader supplierNames = cmd.ExecuteReader();
                while (supplierNames.Read())
                {
                    cmb_Supplier.Items.Add(supplierNames["Supplier_Name"].ToString());
                }

                cmb_Category.SelectedIndex = 0;
                cmb_Supplier.SelectedIndex = 0;
                con.Close();
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message);
            }

        }

        private void btn_add_img_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "IMAGE FILES | *.png;*.jpg;*.jpeg;*.bmp";
                DialogResult result = openFileDialog.ShowDialog(this);
                if (result == DialogResult.OK)
                {
                    imagename = openFileDialog.SafeFileName;
                    string imagefile = openFileDialog.FileName;
                    if (!(File.Exists("./images/" + imagename)))
                        File.Copy(imagefile, "./images/" + imagename);
                    else
                        MetroFramework.MetroMessageBox.Show(this, "Image Exists");
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message);
            }
        }

        private void txt_No_Of_Items_Leave(object sender, EventArgs e)
        {

        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ck_Supplier_Warranty_CheckedChanged(object sender, EventArgs e)
        {
            if (ck_Supplier_Warranty.Checked == true)
                dt_Supplier_Warranty.Enabled = true;
            else
                dt_Supplier_Warranty.Enabled = false;
        }

        private void txt_Item_Bought_Price_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txt_Item_Bought_Price.Text.Length > 0)
                {
                    if (txt_Item_Bought_Price.Text.ToString().Any(char.IsLetter))
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Items Bought Price Cannot Contain Letters!");
                    }
                    else
                    {
                        if (int.Parse(txt_Item_Bought_Price.Text) > 1000000)
                        {
                            MetroFramework.MetroMessageBox.Show(this, "Items Bought Price Cannot Be Larger Than 1000000");
                        }
                        else if (int.Parse(txt_Item_Bought_Price.Text) < 0)
                        {
                            MetroFramework.MetroMessageBox.Show(this, "Items Bought Price Cannot Be Less Than 0");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message);
            }
        }

        private void txt_Item_Selling_Price_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txt_Item_Selling_Price.Text.Length > 0)
                {
                    if (txt_Item_Selling_Price.Text.ToString().Any(char.IsLetter))
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Items Selling Price Cannot Contain Letters!");
                    }
                    else
                    {
                        if (int.Parse(txt_Item_Selling_Price.Text) > 1000000)
                        {
                            MetroFramework.MetroMessageBox.Show(this, "Items Selling Price Cannot Be Larger Than 1000000");
                        }
                        else if (int.Parse(txt_Item_Selling_Price.Text) < 0)
                        {
                            MetroFramework.MetroMessageBox.Show(this, "Items Selling Price Cannot Be Less Than 0");
                        }
                        else if (int.Parse(txt_Item_Selling_Price.Text) < int.Parse(txt_Item_Bought_Price.Text))
                            MetroFramework.MetroMessageBox.Show(this, "Selling Price Should Be Greater Than Bought Price!");
                        {

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message);
            }
        }

        private void txt_Item_Discount_Price_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txt_Item_Discount_Price.Text.Length > 0)
                {
                    if (txt_Item_Discount_Price.Text.ToString().Any(char.IsLetter))
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Items Discount Price Cannot Contain Letters!");
                    }
                    else
                    {
                        if (int.Parse(txt_Item_Discount_Price.Text) > 1000000)
                        {
                            MetroFramework.MetroMessageBox.Show(this, "Items Discount Price Cannot Be More Than 1000000");
                        }
                        else if (int.Parse(txt_Item_Discount_Price.Text) < 0)
                        {
                            MetroFramework.MetroMessageBox.Show(this, "Items Discount Price Cannot Be Less Than 0");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message);
            }
        }

        private void txt_CodeNumber_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txt_CodeNumber.Text.Length >= 10)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Code Number Cannot Contain More Than 10 Characters");
                }
                else if (txt_CodeNumber.Text.Length == 0)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Code Number Cannot Be Empty!");
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message);
            }
        }

        private void txt_Item_Name_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txt_Item_Name.Text.Length > 25)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Items Name Cannot Be More Than 25 Characters!");
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message);
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                DatabaseConnection db = new DatabaseConnection();  
                if (ck_Supplier_Warranty.Checked == false)
                {
                    int value = db.AddItem(username, cmb_Category.Text, cmb_Supplier.Text, txt_Item_Name.Text, int.Parse(txt_Item_Bought_Price.Text)
                        , int.Parse(txt_Item_Selling_Price.Text), int.Parse(txt_Item_Discount_Price.Text), int.Parse(txt_No_Of_Items.Text), int.Parse(txt_No_Of_Items.Text),
                        int.Parse(lbl_Items_Bought_Cost.Text), int.Parse(lbl_Items_Selling_Total.Text), int.Parse(lbl_Profit_Without_Dis.Text), int.Parse(lbl_Profit_With_Dis.Text)
                        , DateTime.Parse(dt_Date_Of_Purchase.Text), txt_CodeNumber.Text, imagename);

                    if (value == 1)
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Item Added!");
                        this.Close();
                    }
                    else
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Error Occured! Try Again!");
                        this.Close();
                    }
                }
                else
                {
                    int value = db.AddItem(username, cmb_Category.Text, cmb_Supplier.Text, txt_Item_Name.Text, int.Parse(txt_Item_Bought_Price.Text)
                        , int.Parse(txt_Item_Selling_Price.Text), int.Parse(txt_Item_Discount_Price.Text), int.Parse(txt_No_Of_Items.Text), int.Parse(txt_No_Of_Items.Text),
                        int.Parse(lbl_Items_Bought_Cost.Text), int.Parse(lbl_Items_Selling_Total.Text), int.Parse(lbl_Profit_Without_Dis.Text), int.Parse(lbl_Profit_With_Dis.Text)
                        , DateTime.Parse(dt_Date_Of_Purchase.Text), txt_CodeNumber.Text, imagename, dt_Supplier_Warranty.Value);

                    if (value == 1)
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Item Added!");
                        this.Close();
                    }
                    else
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Error Occured! Try Again!");
                        this.Close();
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
