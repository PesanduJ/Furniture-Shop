using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Collections;
using System.Xml.Linq;

namespace Furniture_Shop
{
    internal class DatabaseConnection
    {
        string path = "data_table.db";
        string cs = @"URI=file:" + Application.StartupPath + "\\data_table.db";

        SQLiteConnection con;
        SQLiteCommand cmd;
        SQLiteDataAdapter da;
        SQLiteDataReader dr;

        public DatabaseConnection() //Default Constructor
        {
            if (!System.IO.File.Exists(path))
            {
                SQLiteConnection.CreateFile(path);

                using (var con = new SQLiteConnection(@"Data Source=" + path))
                {
                    string User_Info = "CREATE TABLE IF NOT EXISTS User_Info(" +
                    "UserID INTEGER PRIMARY KEY AUTOINCREMENT," +
                    "FName TEXT NOT NULL," +
                    "LName TEXT NOT NULL," +
                    "Age INTEGER," +
                    "User_Address TEXT," +
                    "Email TEXT," +
                    "Contact_Number TEXT NOT NULL," +
                    "User_Password TEXT NOT NULL," +
                    "Username TEXT NOT NULL UNIQUE)";

                    string Category = "CREATE TABLE IF NOT EXISTS Category(" +
                                        "CategoryID INTEGER PRIMARY KEY AUTOINCREMENT," +
                                        "Username TEXT REFERENCES User_Info(Username)," +
                                        "Categoryname TEXT NOT NULL UNIQUE)";

                    string Supplier = "CREATE TABLE IF NOT EXISTS Supplier(" +
                                        "SupplierID INTEGER PRIMARY KEY AUTOINCREMENT," +
                                        "Username TEXT REFERENCES User_Info(Username)," +
                                        "Supplier_Name TEXT NOT NULL UNIQUE," +
                                        "Supplier_Contact_Number TEXT," +
                                        "Supplier_Email TEXT," +
                                        "Supplier_Address TEXT)";

                    string Items = "CREATE TABLE IF NOT EXISTS Items(" +
                                        "ItemID INTEGER PRIMARY KEY AUTOINCREMENT," +
                                        "Username TEXT REFERENCES User_Info(Username)," +
                                        "Categoryname TEXT REFERENCES Category(Categoryname)," +
                                        "Supplier_Name TEXT REFERENCES Supplier(Supplier_Name)," +
                                        "Item_Name TEXT NOT NULL," +
                                        "Item_Bought_Price INTEGER NOT NULL," +
                                        "Item_Selling_Price INTEGER NOT NULL," +
                                        "Item_Discount_Price INTEGER NOT NULL," +
                                        "Item_Count INTEGER NOT NULL," +
                                        "Total_Items_Purchased INTEGER NOT NULL," +
                                        "Items_Bought_Cost INTEGER NOT NULL," +
                                        "Items_Selling_Total INTEGER NOT NULL," +
                                        "Profit_Without_Dis INTEGER NOT NULL," +
                                        "Profit_With_Dis INTEGER NOT NULL," +
                                        "Date_Of_Purchase DATE NOT NULL," +
                                        "CodeNo TEXT NOT NULL," +
                                        "ImageName TEXT," +
                                        "Supplier_Warranty DATE)";

                    string Items_Sold_List = "CREATE TABLE IF NOT EXISTS Items_Sold_List(" +
                                        "Items_Sold_ID INTEGER PRIMARY KEY AUTOINCREMENT," +
                                        "ItemID INTEGER REFERENCES Items(ItemID)," +
                                        "Username TEXT REFERENCES User_Info(Username)," +
                                        "Customer_Name TEXT NOT NULL," +
                                        "Customer_Contact_Number TEXT," +
                                        "Date_Item_Sold DATETIME NOT NULL," +
                                        "Number_Of_Items_Sold INTEGER NOT NULL," +
                                        "Items_Sold_Type TEXT NOT NULL)";



                    con.Open();
                    cmd = new SQLiteCommand(User_Info, con);
                    cmd.ExecuteNonQuery();
                    con.Close();

                    con.Open();
                    cmd = new SQLiteCommand(Category, con);
                    cmd.ExecuteNonQuery();
                    con.Close();

                    con.Open();
                    cmd = new SQLiteCommand(Supplier, con);
                    cmd.ExecuteNonQuery();
                    con.Close();

                    con.Open();
                    cmd = new SQLiteCommand(Items, con);
                    cmd.ExecuteNonQuery();
                    con.Close();

                    con.Open();
                    cmd = new SQLiteCommand(Items_Sold_List, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }

            con = new SQLiteConnection(cs);

        }

      

        public bool login(string username, string password)
        {
            bool result = false;
            string query = "SELECT * FROM User_Info WHERE Username=@Username AND User_Password=@Password";
            using (SQLiteCommand cmd = new SQLiteCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", password);
                con.Open();
                SQLiteDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    result = true;
                }
                con.Close();
            }
            return result;
        }

        public int AddSupplier(string username, string supplierName, string supplierContactNumber, string supplierEmail, string supplierAddress)
        {
            string query = "INSERT INTO Supplier (Username, Supplier_Name, Supplier_Contact_Number, Supplier_Email, Supplier_Address) " +
                           "VALUES (@Username, @SupplierName, @SupplierContactNumber, @SupplierEmail, @SupplierAddress)";

            using (SQLiteConnection con = new SQLiteConnection(cs))
            {
                con.Open();
                int value;
                using (SQLiteCommand cmd = new SQLiteCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@SupplierName", supplierName);
                    cmd.Parameters.AddWithValue("@SupplierContactNumber", supplierContactNumber);
                    cmd.Parameters.AddWithValue("@SupplierEmail", supplierEmail);
                    cmd.Parameters.AddWithValue("@SupplierAddress", supplierAddress);

                   value = cmd.ExecuteNonQuery();
                }
                con.Close();
                return value;
                
            }
        }

        public int AddUser(string FName, string LName, int Age, string User_Address, string Email, string Contact_Number, string User_Password, string Username)
        {
            string query = "INSERT INTO User_Info (FName, LName, Age, User_Address, Email, Contact_Number, User_Password, Username) " +
               "VALUES (@FName, @LName, @Age, @User_Address, @Email, @Contact_Number, @User_Password, @Username)";

            using (SQLiteConnection con = new SQLiteConnection(cs))
            {
                con.Open();
                int value;
                using (SQLiteCommand cmd = new SQLiteCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@FName", FName);
                    cmd.Parameters.AddWithValue("@LName", LName);
                    cmd.Parameters.AddWithValue("@Age", Age);
                    cmd.Parameters.AddWithValue("@User_Address", User_Address);
                    cmd.Parameters.AddWithValue("@Email", Email);
                    cmd.Parameters.AddWithValue("@Contact_Number", Contact_Number);
                    cmd.Parameters.AddWithValue("@User_Password", User_Password);
                    cmd.Parameters.AddWithValue("@Username", Username);


                    value = cmd.ExecuteNonQuery();
                }
                con.Close();
                return value;

            }
        }

        public int AddCategory(string username,  string category)
        {
            string query = "INSERT INTO Category (Username, Categoryname) VALUES (@Username, @Categoryname)";

            using (SQLiteConnection con = new SQLiteConnection(cs))
            {
                con.Open();
                int value;
                using (SQLiteCommand cmd = new SQLiteCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Categoryname", category);

                    value = cmd.ExecuteNonQuery();
                }
                con.Close();
                return value;

            }
        }

        public int AddItem(string Username,string Categoryname, string Supplier_Name, string Item_Name,int Item_Bought_Price, int Item_Selling_Price, int Item_Discount_Price, int Item_Count, int Total_Items_Purchased,int Items_Bought_Cost, int Items_Selling_Total, int Profit_Without_Dis, int Profit_With_Dis,DateTime Date_Of_Purchase,string CodeNo, string ImageName)
        {
            string query = "INSERT INTO Items(Username, Categoryname, Supplier_Name, Item_Name, Item_Bought_Price, Item_Selling_Price, Item_Discount_Price, Item_Count, Total_Items_Purchased, Items_Bought_Cost, Items_Selling_Total, Profit_Without_Dis, Profit_With_Dis, Date_Of_Purchase, CodeNo, ImageName) VALUES (@Username, @Categoryname, @Supplier_Name, @Item_Name, @Item_Bought_Price, @Item_Selling_Price, @Item_Discount_Price, @Item_Count, @Total_Items_Purchased, @Items_Bought_Cost, @Items_Selling_Total, @Profit_Without_Dis, @Profit_With_Dis, @Date_Of_Purchase, @CodeNo, @ImageName)";

            using (SQLiteConnection con = new SQLiteConnection(cs))
            {
                con.Open();
                int value;
                using (SQLiteCommand command = new SQLiteCommand(query, con))
                {
                    command.Parameters.AddWithValue("@Username", Username);
                    command.Parameters.AddWithValue("@Categoryname", Categoryname);
                    command.Parameters.AddWithValue("@Supplier_Name", Supplier_Name);
                    command.Parameters.AddWithValue("@Item_Name", Item_Name);
                    command.Parameters.AddWithValue("@Item_Bought_Price", Item_Bought_Price);
                    command.Parameters.AddWithValue("@Item_Selling_Price", Item_Selling_Price);
                    command.Parameters.AddWithValue("@Item_Discount_Price", Item_Discount_Price);
                    command.Parameters.AddWithValue("@Item_Count", Item_Count);
                    command.Parameters.AddWithValue("@Total_Items_Purchased", Total_Items_Purchased);
                    command.Parameters.AddWithValue("@Items_Bought_Cost", Items_Bought_Cost);
                    command.Parameters.AddWithValue("@Items_Selling_Total", Items_Selling_Total);
                    command.Parameters.AddWithValue("@Profit_Without_Dis", Profit_Without_Dis);
                    command.Parameters.AddWithValue("@Profit_With_Dis", Profit_With_Dis);
                    command.Parameters.AddWithValue("@Date_Of_Purchase", Date_Of_Purchase);
                    command.Parameters.AddWithValue("@CodeNo", CodeNo);
                    command.Parameters.AddWithValue("@ImageName", ImageName);

                    value = command.ExecuteNonQuery();
                }
                con.Close();
                return value;

            }

        }

        public int AddItem(string Username, string Categoryname, string Supplier_Name, string Item_Name, int Item_Bought_Price, int Item_Selling_Price, int Item_Discount_Price, int Item_Count, int Total_Items_Purchased, int Items_Bought_Cost, int Items_Selling_Total, int Profit_Without_Dis, int Profit_With_Dis, DateTime Date_Of_Purchase, string CodeNo, string ImageName, DateTime Supplier_Warranty)
        {

            string query = "INSERT INTO Items(Username, Categoryname, Supplier_Name, Item_Name, Item_Bought_Price, Item_Selling_Price, Item_Discount_Price, Item_Count, Total_Items_Purchased, Items_Bought_Cost, Items_Selling_Total, Profit_Without_Dis, Profit_With_Dis, Date_Of_Purchase, CodeNo, ImageName, Supplier_Warranty) VALUES (@Username, @Categoryname, @Supplier_Name, @Item_Name, @Item_Bought_Price, @Item_Selling_Price, @Item_Discount_Price, @Item_Count, @Total_Items_Purchased, @Items_Bought_Cost, @Items_Selling_Total, @Profit_Without_Dis, @Profit_With_Dis, @Date_Of_Purchase, @CodeNo, @ImageName, @Supplier_Warranty)";

            using (SQLiteConnection con = new SQLiteConnection(cs))
            {
                con.Open();
                int value;
                using (SQLiteCommand command = new SQLiteCommand(query, con))
                {
                    command.Parameters.AddWithValue("@Username", Username);
                    command.Parameters.AddWithValue("@Categoryname", Categoryname);
                    command.Parameters.AddWithValue("@Supplier_Name", Supplier_Name);
                    command.Parameters.AddWithValue("@Item_Name", Item_Name);
                    command.Parameters.AddWithValue("@Item_Bought_Price", Item_Bought_Price);
                    command.Parameters.AddWithValue("@Item_Selling_Price", Item_Selling_Price);
                    command.Parameters.AddWithValue("@Item_Discount_Price", Item_Discount_Price);
                    command.Parameters.AddWithValue("@Item_Count", Item_Count);
                    command.Parameters.AddWithValue("@Total_Items_Purchased", Total_Items_Purchased);
                    command.Parameters.AddWithValue("@Items_Bought_Cost", Items_Bought_Cost);
                    command.Parameters.AddWithValue("@Items_Selling_Total", Items_Selling_Total);
                    command.Parameters.AddWithValue("@Profit_Without_Dis", Profit_Without_Dis);
                    command.Parameters.AddWithValue("@Profit_With_Dis", Profit_With_Dis);
                    command.Parameters.AddWithValue("@Date_Of_Purchase", Date_Of_Purchase);
                    command.Parameters.AddWithValue("@CodeNo", CodeNo);
                    command.Parameters.AddWithValue("@ImageName", ImageName);
                    command.Parameters.AddWithValue("@Supplier_Warranty", Supplier_Warranty);

                    value = command.ExecuteNonQuery();
                }
                con.Close();
                return value;

            }
        }

        public int deleteItem(string username, string supplier_Name, string item_Name)
        {
            string query = "DELETE FROM Items WHERE Username=@Username AND Supplier_Name=@SupplierName AND Item_Name=@ItemName";

            using (SQLiteConnection con = new SQLiteConnection(cs))
            {
                con.Open();
                int value;
                using (SQLiteCommand cmd = new SQLiteCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@SupplierName", supplier_Name);
                    cmd.Parameters.AddWithValue("@ItemName", item_Name);

                    value = cmd.ExecuteNonQuery();
                }
                con.Close();
                return value;

            }
        }

        public int getItemId(string itemName, string codeNo)
        {
            int num = 0;
            using (SQLiteCommand command = new SQLiteCommand("SELECT ItemID FROM Items WHERE Item_Name = @ItemName AND CodeNo = @CodeNo", con))
            {
                command.Parameters.AddWithValue("@ItemName", itemName);
                command.Parameters.AddWithValue("@CodeNo", codeNo);
                con.Open();
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        num = int.Parse(reader["ItemID"].ToString());
                    }
                }
                con.Close();
            }
            return num;
        }

        public int verifyoldPassword(string username, string oldpassword)
        {
            string text = null;
            int num = 0;
            
                using (SQLiteCommand cmd = new SQLiteCommand("SELECT User_Password FROM User_Info WHERE Username=@Username", con))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    con.Open();
                    SQLiteDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        text = reader["User_Password"].ToString();
                    }
                    con.Close();
                }

                if (text == oldpassword)
                {
                    num = 1;
                    return num;
                }

                num = 0;
                return num;
            
        }

        public void updateItemDetails(string username, int item_ID, int item_Bought_Price, int item_Selling_price, int item_Discount_Price, int Total_Items_Purchased, int items_Bought_Cost, int items_Selling_Total, int profit_Without_Dis, int profit_With_Dis, string date_Of_Purchase, DateTime supplier_Warranty)
        {
            con.Open();
                using (SQLiteCommand cmd = new SQLiteCommand("UPDATE Items SET Item_Bought_Price = @itemBoughtPrice, Item_Selling_Price = @itemSellingPrice, Item_Discount_Price = @itemDiscountPrice, Item_Count = (Item_Count + @totalItemsPurchased), Total_Items_Purchased = (Total_Items_Purchased + @totalItemsPurchased), Items_Bought_Cost = @itemsBoughtCost, Items_Selling_Total = @itemsSellingTotal, Profit_Without_Dis = @profitWithoutDis, Profit_With_Dis = @profitWithDis, Date_Of_Purchase = @dateOfPurchase, Supplier_Warranty = @supplierWarranty WHERE Username = @username AND ItemID = @itemID; ", con))
                {
                    cmd.Parameters.AddWithValue("@itemBoughtPrice", item_Bought_Price);
                    cmd.Parameters.AddWithValue("@itemSellingPrice", item_Selling_price);
                    cmd.Parameters.AddWithValue("@itemDiscountPrice", item_Discount_Price);
                    cmd.Parameters.AddWithValue("@totalItemsPurchased", Total_Items_Purchased);
                    cmd.Parameters.AddWithValue("@itemsBoughtCost", items_Bought_Cost);
                    cmd.Parameters.AddWithValue("@itemsSellingTotal", items_Selling_Total);
                    cmd.Parameters.AddWithValue("@profitWithoutDis", profit_Without_Dis);
                    cmd.Parameters.AddWithValue("@profitWithDis", profit_With_Dis);
                    cmd.Parameters.AddWithValue("@dateOfPurchase", date_Of_Purchase);
                    cmd.Parameters.AddWithValue("@supplierWarranty", supplier_Warranty);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@itemID", item_ID);

                    cmd.ExecuteNonQuery();
                }
            con.Close();
        }


        public void addItemsSold(int itemID, string userName, string cusName, string cusPhoneNumber, DateTime dateItemSold, decimal items_Sold_Count, string itemSoldType)
        {
            con.Open();
                using (var cmd = new SQLiteCommand("INSERT INTO Items_Sold_List (ItemID, Username, Customer_Name, Customer_Contact_Number, Date_Item_Sold, Number_Of_Items_Sold, Items_Sold_Type) VALUES (@itemID, @userName, @cusName, @cusPhoneNumber, @dateItemSold, @itemsSoldCount, @itemSoldType)", con))
                {
                    cmd.Parameters.AddWithValue("@itemID", itemID);
                    cmd.Parameters.AddWithValue("@userName", userName);
                    cmd.Parameters.AddWithValue("@cusName", cusName);
                    cmd.Parameters.AddWithValue("@cusPhoneNumber", cusPhoneNumber);
                    cmd.Parameters.AddWithValue("@dateItemSold", dateItemSold);
                    cmd.Parameters.AddWithValue("@itemsSoldCount", items_Sold_Count);
                    cmd.Parameters.AddWithValue("@itemSoldType", itemSoldType);
                    cmd.ExecuteNonQuery();
                }
            con.Close();
        }

        public void substractItems(string username, string item_name, string supplier_name, decimal value)
        {
            con.Open();
                using (SQLiteCommand cmd = new SQLiteCommand("UPDATE Items SET Item_Count = (Item_Count - @value) WHERE Username = @username AND Supplier_Name = @supplier_name AND Item_Name = @item_name;", con))
                {
                    cmd.Parameters.AddWithValue("@value", value);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@supplier_name", supplier_name);
                    cmd.Parameters.AddWithValue("@item_name", item_name);
                    cmd.ExecuteNonQuery();
                }
            con.Close();
        }

        public SQLiteDataAdapter getItemsSold(int itemID, string username)
        {
            SQLiteDataAdapter sqliteDataAdapter = null;
            try
            {con.Open();
                sqliteDataAdapter = new SQLiteDataAdapter("SELECT * FROM Items_Sold_List WHERE ItemID = " + itemID + " AND Username = '" + username + "';", con);
                con.Close() ;
                return sqliteDataAdapter;
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return sqliteDataAdapter;
            }
            catch (Exception ex2)
            {
                MessageBox.Show(ex2.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return sqliteDataAdapter;
            }
        }

        public int getItemsSoldCount(int itemID, string username)
        {
            int num = 0;
            try
            {
                con.Open();
                using (SQLiteDataReader reader = new SQLiteCommand("SELECT count(Items_Sold_ID) AS ItemsCount FROM Items_Sold_List WHERE ItemID = " + itemID + " AND Username = '" + username + "';", con).ExecuteReader())
                {
                    while (reader.Read())
                    {
                        num = int.Parse(reader["ItemsCount"].ToString());
                    }
                }
                con.Close() ;
                return num;
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return num;
            }
            catch (Exception ex2)
            {
                MessageBox.Show(ex2.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return num;
            }
        }


        public SQLiteDataAdapter getItemsSold(int itemID, string username, string type)
        {
            SQLiteDataAdapter sqlDataAdapter = null;
            try
            {con.Open();
                sqlDataAdapter = new SQLiteDataAdapter("SELECT * FROM Items_Sold_List WHERE ItemID = " + itemID + " AND Username = '" + username + "' AND Items_Sold_Type = '" + type + "';", con);
                con.Close();
                return sqlDataAdapter;
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return sqlDataAdapter;
            }
            catch (Exception ex2)
            {
                MessageBox.Show(ex2.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return sqlDataAdapter;
            }
        }

        public int getItemsSoldCount(int itemID, string username, string type)
        {
            int num = 0;
            try
            {con.Open();
                using (SQLiteDataReader sqlDataReader = new SQLiteCommand("SELECT count(Items_Sold_ID) AS ItemsCount FROM Items_Sold_List WHERE ItemID = " + itemID + " AND Username = '" + username + "' AND Items_Sold_Type = '" + type + "';", con).ExecuteReader())
                {
                    while (sqlDataReader.Read())
                    {
                        num = int.Parse(sqlDataReader["ItemsCount"].ToString());
                    }
                }
                con.Close();
                return num;
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return num;
            }
            catch (Exception ex2)
            {
                MessageBox.Show(ex2.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return num;
            }
        }

        public SQLiteDataAdapter getMonthlySalesAvailable(string username, string startingDate, string endingDate)
        {
            SQLiteDataAdapter sqlDataAdapter = null;
            try
            {
                sqlDataAdapter = new SQLiteDataAdapter("Select * from Items Where Date_Of_Purchase BETWEEN '" + startingDate + "' AND '" + endingDate + "' AND Item_Count > 0 AND Username = '" + username + "';", con);
                return sqlDataAdapter;
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return sqlDataAdapter;
            }
            catch (Exception ex2)
            {
                MessageBox.Show(ex2.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return sqlDataAdapter;
            }
        }

        public SQLiteDataAdapter getMonthlySalesSoldOut(string username, string startingDate, string endingDate)
        {
            SQLiteDataAdapter sqliteDataAdapter = null;
            try
            {
                sqliteDataAdapter = new SQLiteDataAdapter("Select * from Items Where Date_Of_Purchase BETWEEN '" + startingDate + "' AND '" + endingDate + "' AND Item_Count = 0 AND Username = '" + username + "';", con);
                return sqliteDataAdapter;
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return sqliteDataAdapter;
            }
            catch (Exception ex2)
            {
                MessageBox.Show(ex2.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return sqliteDataAdapter;
            }
        }

        public void changePassword(string username, string newpassword)
        {
            try
            {
                con.Open();
                using (SQLiteCommand cmd = new SQLiteCommand("UPDATE UserInfo SET User_Password = @newpassword WHERE Username = @username;", con))
                {
                    cmd.Parameters.AddWithValue("@newpassword", newpassword);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.ExecuteNonQuery();
                    
                }
                con.Close();
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            catch (Exception ex2)
            {
                MessageBox.Show(ex2.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

    }
}
