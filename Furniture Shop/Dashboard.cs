using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Furniture_Shop
{
    public partial class Dashboard : MetroFramework.Forms.MetroForm
    {
        DatabaseConnection dc;
        SQLiteConnection con;
        string username, item_name;
        public Dashboard(string username)
        {
            InitializeComponent();
            this.username = username;
            lbl_hello_username.Text = "Hello " + username;
            updateListView("*");
            cmb_Search_Selector.SelectedIndex = 0;
            
            dc = new DatabaseConnection();
            con = new SQLiteConnection(@"URI=file:" + Application.StartupPath + "\\data_table.db");

        }
       

        public void updateListView(string searchtext)
        {
            try
            {
                using (var conn = new SQLiteConnection("Data Source=data_table.db;Version=3;"))
                {
                    conn.Open();

                    var items = new List<(string, string)>();
                    var imageList = new ImageList();
                    imageList.ColorDepth = ColorDepth.Depth32Bit;
                    Size size = new Size(128, 128);
                    imageList.ImageSize = size;
                    lv_items.LargeImageList = imageList;
                    lv_items.Clear();

                    var query = "SELECT Item_Name, ImageName FROM Items WHERE Username = @Username";
                    using (var cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@SearchText", searchtext);

                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string itemName = reader.GetString(0);
                                string imageName = reader.IsDBNull(1) ? "image-not-found-300x169.jpg" : reader.GetString(1);

                                items.Add((itemName, imageName));
                            }
                        }
                    }

                    foreach (var item in items)
                    {
                        if (File.Exists("./images/" + item.Item2))
                        {
                            imageList.Images.Add(Image.FromFile("./images/" + item.Item2));
                        }
                        else
                        {
                            imageList.Images.Add(Image.FromFile("./images/image-not-found-300x169.jpg"));
                        }
                        lv_items.Items.Add(item.Item1, imageList.Images.Count - 1);
                    }

                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message);
            }
        }

        public void updateListView(string searchtype, string searchtext)
        {
            try
            {
                using (var conn = new SQLiteConnection("Data Source=data_table.db;Version=3;"))
                {
                    conn.Open();

                    var items = new List<(string, string)>();
                    var imageList = new ImageList();
                    imageList.ColorDepth = ColorDepth.Depth32Bit;
                    Size size = new Size(128, 128);
                    imageList.ImageSize = size;
                    lv_items.LargeImageList = imageList;
                    lv_items.Clear();

                    var query = "SELECT Item_Name, ImageName FROM Items WHERE Username = @Username AND " + searchtype + " LIKE '%' || @SearchText || '%'";
                    using (var cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@SearchText", searchtext);

                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string itemName = reader.GetString(0);
                                string imageName = reader.IsDBNull(1) ? "image-not-found-300x169.jpg" : reader.GetString(1);

                                items.Add((itemName, imageName));
                            }
                        }
                    }

                    foreach (var item in items)
                    {
                        if (File.Exists("./images/" + item.Item2))
                        {
                            imageList.Images.Add(Image.FromFile("./images/" + item.Item2));
                        }
                        else
                        {
                            imageList.Images.Add(Image.FromFile("./images/image-not-found-300x169.jpg"));
                        }
                        lv_items.Items.Add(item.Item1, imageList.Images.Count - 1);
                    }

                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message);
            }
        }

        private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                Application.Exit();
            }catch(Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message);
            }
        }

        private void lbl_add_items_Click(object sender, EventArgs e)
        {
            try
            {
                Add_Items add_Items = new Add_Items(username);
                add_Items.ShowDialog();
            }catch(FileLoadException ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message);
            }
            
            catch(Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message);
            }
        }

        private void lbl_add_supplier_Click(object sender, EventArgs e)
        {
            Add_Supplier add_Supplier = new Add_Supplier(username);
            add_Supplier.ShowDialog();
        }

        private void lbl_Add_Category_Click(object sender, EventArgs e)
        {
            Add_Category add_Category = new Add_Category(username);
            add_Category.ShowDialog();
        }

        private void lv_items_ItemActivate(object sender, EventArgs e)
        {
            DetailsPage detailsPage = new DetailsPage(username, item_name);
            detailsPage.ShowDialog();
        }

        private void cmb_Search_Selector_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmb_Search_Selector.SelectedIndex == 0)
                {
                    txt_Search_Items.Enabled = false;
                    txt_Search_Items.Clear();
                    updateListView("*");
                }
                else if (cmb_Search_Selector.SelectedIndex == 1)
                {
                    txt_Search_Items.Enabled = true;
                }
                else if (cmb_Search_Selector.SelectedIndex == 2)
                {
                    txt_Search_Items.Enabled = true;
                }
                else if (cmb_Search_Selector.SelectedIndex == 3)
                {
                    txt_Search_Items.Enabled = true;
                }
            }catch(Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message);
            }
        }

        private void txt_Search_Items_Leave(object sender, EventArgs e)
        {
            try
            {
                if (cmb_Search_Selector.SelectedIndex == 1)
                {
                    lv_items.Clear();
                    updateListView("CodeNo", txt_Search_Items.Text);
                }
                else if (cmb_Search_Selector.SelectedIndex == 2)
                {
                    lv_items.Clear();
                    updateListView("Categoryname", txt_Search_Items.Text);
                }
                else if (cmb_Search_Selector.SelectedIndex == 3)
                {
                    lv_items.Clear();
                    updateListView("Supplier_Name", txt_Search_Items.Text);
                }
            }catch(Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message);
            }
        }

        private void lbl_Settings_Click(object sender, EventArgs e)
        {
            SettingsPage settingsPage = new SettingsPage(username);
            settingsPage.ShowDialog();
        }

        private void lbl_Refresh_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmb_Search_Selector.SelectedIndex == 0)
                {
                    lv_items.Clear();
                    updateListView("*");
                }
                else if (cmb_Search_Selector.SelectedIndex == 1)
                {
                    lv_items.Clear();
                    updateListView("CodeNo", txt_Search_Items.Text);
                }
                else if (cmb_Search_Selector.SelectedIndex == 2)
                {
                    lv_items.Clear();
                    updateListView("Categoryname", txt_Search_Items.Text);
                }
                else if (cmb_Search_Selector.SelectedIndex == 3)
                {
                    lv_items.Clear();
                    updateListView("Supplier_Name", txt_Search_Items.Text);
                }
            }
            catch(Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message);
            }
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            updateListView("*");
        }

        private void btn_sales_Click(object sender, EventArgs e)
        {
            Monthly_Sales monthly_Sales = new Monthly_Sales();
            monthly_Sales.ShowDialog();
        }

        private void lv_items_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            item_name = e.Item.Text;
        }
    }
}
