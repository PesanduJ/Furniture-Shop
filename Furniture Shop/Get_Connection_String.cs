using System;
using System.Data.SqlClient;
using System.IO;

namespace Furniture_Shop
{
    public partial class Get_Connection_String : MetroFramework.Forms.MetroForm
    {
        public Get_Connection_String()
        {
            InitializeComponent();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_computer_name.Text.Length == 0)
                    MetroFramework.MetroMessageBox.Show(this, "Enter The Computer Name");
                else
                {
                    SqlConnection con = new SqlConnection("Data Source=" + txt_computer_name.Text + ";Initial Catalog=Furniture_Shop;Integrated Security=SSPI");
                    con.Open();
                    if (con.State == System.Data.ConnectionState.Open)
                    {
                        saveComputerName();
                        this.Close();
                    }
                    else
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Error Connecting To The Server!");
                    }
                }
            }
            catch (SqlException ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message);
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message);
            }
        }

        public void saveComputerName()
        {
            try
            {
                File.Create("./config").Close();
                StreamWriter streamWriter = new StreamWriter("./config");
                streamWriter.WriteLine(txt_computer_name.Text);
                streamWriter.Close();
            }
            catch(FileNotFoundException ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message);
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message);
            }
        }
    }
}
