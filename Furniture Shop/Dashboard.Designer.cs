
namespace Furniture_Shop
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_hello_username = new MetroFramework.Controls.MetroLabel();
            this.lv_items = new System.Windows.Forms.ListView();
            this.txt_Search_Items = new MetroFramework.Controls.MetroTextBox();
            this.cmb_Search_Selector = new MetroFramework.Controls.MetroComboBox();
            this.btn_Add_Supplier = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.btn_Add_Items = new MetroFramework.Controls.MetroButton();
            this.btn_Settings = new MetroFramework.Controls.MetroButton();
            this.btn_Refresh = new MetroFramework.Controls.MetroButton();
            this.btn_sales = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // lbl_hello_username
            // 
            this.lbl_hello_username.AutoSize = true;
            this.lbl_hello_username.Location = new System.Drawing.Point(23, 60);
            this.lbl_hello_username.Name = "lbl_hello_username";
            this.lbl_hello_username.Size = new System.Drawing.Size(39, 19);
            this.lbl_hello_username.TabIndex = 0;
            this.lbl_hello_username.Text = "Hello";
            // 
            // lv_items
            // 
            this.lv_items.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lv_items.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lv_items.HideSelection = false;
            this.lv_items.Location = new System.Drawing.Point(24, 136);
            this.lv_items.MultiSelect = false;
            this.lv_items.Name = "lv_items";
            this.lv_items.Size = new System.Drawing.Size(753, 291);
            this.lv_items.TabIndex = 6;
            this.lv_items.UseCompatibleStateImageBehavior = false;
            this.lv_items.ItemActivate += new System.EventHandler(this.lv_items_ItemActivate);
            this.lv_items.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lv_items_ItemSelectionChanged);
            // 
            // txt_Search_Items
            // 
            // 
            // 
            // 
            this.txt_Search_Items.CustomButton.Image = null;
            this.txt_Search_Items.CustomButton.Location = new System.Drawing.Point(169, 1);
            this.txt_Search_Items.CustomButton.Name = "";
            this.txt_Search_Items.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_Search_Items.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_Search_Items.CustomButton.TabIndex = 1;
            this.txt_Search_Items.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_Search_Items.CustomButton.UseSelectable = true;
            this.txt_Search_Items.CustomButton.Visible = false;
            this.txt_Search_Items.Enabled = false;
            this.txt_Search_Items.Lines = new string[0];
            this.txt_Search_Items.Location = new System.Drawing.Point(23, 95);
            this.txt_Search_Items.MaxLength = 32767;
            this.txt_Search_Items.Name = "txt_Search_Items";
            this.txt_Search_Items.PasswordChar = '\0';
            this.txt_Search_Items.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_Search_Items.SelectedText = "";
            this.txt_Search_Items.SelectionLength = 0;
            this.txt_Search_Items.SelectionStart = 0;
            this.txt_Search_Items.ShortcutsEnabled = true;
            this.txt_Search_Items.Size = new System.Drawing.Size(191, 23);
            this.txt_Search_Items.TabIndex = 7;
            this.txt_Search_Items.UseSelectable = true;
            this.txt_Search_Items.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_Search_Items.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_Search_Items.Leave += new System.EventHandler(this.txt_Search_Items_Leave);
            // 
            // cmb_Search_Selector
            // 
            this.cmb_Search_Selector.FormattingEnabled = true;
            this.cmb_Search_Selector.ItemHeight = 23;
            this.cmb_Search_Selector.Items.AddRange(new object[] {
            "ALL",
            "CODENO",
            "CATEGORY",
            "SUPPLIER"});
            this.cmb_Search_Selector.Location = new System.Drawing.Point(220, 93);
            this.cmb_Search_Selector.Name = "cmb_Search_Selector";
            this.cmb_Search_Selector.Size = new System.Drawing.Size(121, 29);
            this.cmb_Search_Selector.TabIndex = 8;
            this.cmb_Search_Selector.UseSelectable = true;
            this.cmb_Search_Selector.SelectedIndexChanged += new System.EventHandler(this.cmb_Search_Selector_SelectedIndexChanged);
            // 
            // btn_Add_Supplier
            // 
            this.btn_Add_Supplier.Location = new System.Drawing.Point(336, 60);
            this.btn_Add_Supplier.Name = "btn_Add_Supplier";
            this.btn_Add_Supplier.Size = new System.Drawing.Size(89, 23);
            this.btn_Add_Supplier.TabIndex = 10;
            this.btn_Add_Supplier.Text = "ADD SUPPLIER";
            this.btn_Add_Supplier.UseSelectable = true;
            this.btn_Add_Supplier.Click += new System.EventHandler(this.lbl_add_supplier_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(441, 60);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(101, 23);
            this.metroButton1.TabIndex = 11;
            this.metroButton1.Text = "ADD CATEGORY";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.lbl_Add_Category_Click);
            // 
            // btn_Add_Items
            // 
            this.btn_Add_Items.Location = new System.Drawing.Point(555, 60);
            this.btn_Add_Items.Name = "btn_Add_Items";
            this.btn_Add_Items.Size = new System.Drawing.Size(101, 23);
            this.btn_Add_Items.TabIndex = 12;
            this.btn_Add_Items.Text = "ADD ITEMS";
            this.btn_Add_Items.UseSelectable = true;
            this.btn_Add_Items.Click += new System.EventHandler(this.lbl_add_items_Click);
            // 
            // btn_Settings
            // 
            this.btn_Settings.Location = new System.Drawing.Point(669, 60);
            this.btn_Settings.Name = "btn_Settings";
            this.btn_Settings.Size = new System.Drawing.Size(101, 23);
            this.btn_Settings.TabIndex = 13;
            this.btn_Settings.Text = "SETTINGS";
            this.btn_Settings.UseSelectable = true;
            this.btn_Settings.Click += new System.EventHandler(this.lbl_Settings_Click);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Location = new System.Drawing.Point(669, 99);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(101, 23);
            this.btn_Refresh.TabIndex = 14;
            this.btn_Refresh.Text = "REFRESH";
            this.btn_Refresh.UseSelectable = true;
            this.btn_Refresh.Click += new System.EventHandler(this.lbl_Refresh_Click);
            // 
            // btn_sales
            // 
            this.btn_sales.Location = new System.Drawing.Point(555, 99);
            this.btn_sales.Name = "btn_sales";
            this.btn_sales.Size = new System.Drawing.Size(101, 23);
            this.btn_sales.TabIndex = 15;
            this.btn_sales.Text = "SALES";
            this.btn_sales.UseSelectable = true;
            this.btn_sales.Click += new System.EventHandler(this.btn_sales_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_sales);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.btn_Settings);
            this.Controls.Add(this.btn_Add_Items);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.btn_Add_Supplier);
            this.Controls.Add(this.cmb_Search_Selector);
            this.Controls.Add(this.txt_Search_Items);
            this.Controls.Add(this.lv_items);
            this.Controls.Add(this.lbl_hello_username);
            this.Name = "Dashboard";
            this.Resizable = false;
            this.Text = "Dashboard";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Dashboard_FormClosed);
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lbl_hello_username;
        private System.Windows.Forms.ListView lv_items;
        private MetroFramework.Controls.MetroTextBox txt_Search_Items;
        private MetroFramework.Controls.MetroComboBox cmb_Search_Selector;
        private MetroFramework.Controls.MetroButton btn_Add_Supplier;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton btn_Add_Items;
        private MetroFramework.Controls.MetroButton btn_Settings;
        private MetroFramework.Controls.MetroButton btn_Refresh;
        private MetroFramework.Controls.MetroButton btn_sales;
    }
}