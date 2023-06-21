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
    public partial class Add_Category : MetroFramework.Forms.MetroForm
    {
        string username;
        public Add_Category(string username)
        {
            InitializeComponent();
            this.username = username;
            lbl_username.Text = username;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (txt_Category.Text.Length == 0)
            {
                MetroFramework.MetroMessageBox.Show(this, "Category Cannot Be Null!");
            }
            else
            {
                try
                {
                    DatabaseConnection conn = new DatabaseConnection();
                    int result=conn.AddCategory(username, txt_Category.Text);
                    if (result > 0)
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Category added successfully.");
                        this.Close();
                    }
                    else
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Error adding category.");
                    }
                }
                catch (Exception ex)
                {
                    MetroFramework.MetroMessageBox.Show(this, ex.Message);
                }
            }   
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
