
namespace Furniture_Shop
{
    partial class View_Sold_Items
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
            this.dt_Items_Sold = new System.Windows.Forms.DataGridView();
            this.htmlLabel1 = new MetroFramework.Drawing.Html.HtmlLabel();
            this.rb_All = new System.Windows.Forms.RadioButton();
            this.rb_Online = new System.Windows.Forms.RadioButton();
            this.rb_Offline = new System.Windows.Forms.RadioButton();
            this.htmlLabel2 = new MetroFramework.Drawing.Html.HtmlLabel();
            this.lbl_Items_Sold_Count = new MetroFramework.Drawing.Html.HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dt_Items_Sold)).BeginInit();
            this.SuspendLayout();
            // 
            // dt_Items_Sold
            // 
            this.dt_Items_Sold.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dt_Items_Sold.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_Items_Sold.Location = new System.Drawing.Point(24, 64);
            this.dt_Items_Sold.Name = "dt_Items_Sold";
            this.dt_Items_Sold.Size = new System.Drawing.Size(753, 363);
            this.dt_Items_Sold.TabIndex = 0;
            // 
            // htmlLabel1
            // 
            this.htmlLabel1.AutoScroll = true;
            this.htmlLabel1.AutoScrollMinSize = new System.Drawing.Size(76, 23);
            this.htmlLabel1.AutoSize = false;
            this.htmlLabel1.BackColor = System.Drawing.SystemColors.Window;
            this.htmlLabel1.Location = new System.Drawing.Point(226, 35);
            this.htmlLabel1.Name = "htmlLabel1";
            this.htmlLabel1.Size = new System.Drawing.Size(86, 23);
            this.htmlLabel1.TabIndex = 1;
            this.htmlLabel1.Text = "SOLD TYPE :";
            // 
            // rb_All
            // 
            this.rb_All.AutoSize = true;
            this.rb_All.Checked = true;
            this.rb_All.Location = new System.Drawing.Point(318, 38);
            this.rb_All.Name = "rb_All";
            this.rb_All.Size = new System.Drawing.Size(36, 17);
            this.rb_All.TabIndex = 2;
            this.rb_All.TabStop = true;
            this.rb_All.Text = "All";
            this.rb_All.UseVisualStyleBackColor = true;
            this.rb_All.CheckedChanged += new System.EventHandler(this.rb_All_CheckedChanged);
            // 
            // rb_Online
            // 
            this.rb_Online.AutoSize = true;
            this.rb_Online.Location = new System.Drawing.Point(371, 38);
            this.rb_Online.Name = "rb_Online";
            this.rb_Online.Size = new System.Drawing.Size(55, 17);
            this.rb_Online.TabIndex = 3;
            this.rb_Online.Text = "Online";
            this.rb_Online.UseVisualStyleBackColor = true;
            this.rb_Online.CheckedChanged += new System.EventHandler(this.rb_Online_CheckedChanged);
            // 
            // rb_Offline
            // 
            this.rb_Offline.AutoSize = true;
            this.rb_Offline.Location = new System.Drawing.Point(441, 38);
            this.rb_Offline.Name = "rb_Offline";
            this.rb_Offline.Size = new System.Drawing.Size(55, 17);
            this.rb_Offline.TabIndex = 4;
            this.rb_Offline.Text = "Offline";
            this.rb_Offline.UseVisualStyleBackColor = true;
            this.rb_Offline.CheckedChanged += new System.EventHandler(this.rb_Offline_CheckedChanged);
            // 
            // htmlLabel2
            // 
            this.htmlLabel2.AutoScroll = true;
            this.htmlLabel2.AutoScrollMinSize = new System.Drawing.Size(81, 23);
            this.htmlLabel2.AutoSize = false;
            this.htmlLabel2.BackColor = System.Drawing.SystemColors.Window;
            this.htmlLabel2.Location = new System.Drawing.Point(583, 35);
            this.htmlLabel2.Name = "htmlLabel2";
            this.htmlLabel2.Size = new System.Drawing.Size(86, 23);
            this.htmlLabel2.TabIndex = 2;
            this.htmlLabel2.Text = "ITEMS SOLD :";
            // 
            // lbl_Items_Sold_Count
            // 
            this.lbl_Items_Sold_Count.AutoScroll = true;
            this.lbl_Items_Sold_Count.AutoScrollMinSize = new System.Drawing.Size(17, 23);
            this.lbl_Items_Sold_Count.AutoSize = false;
            this.lbl_Items_Sold_Count.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_Items_Sold_Count.Location = new System.Drawing.Point(675, 35);
            this.lbl_Items_Sold_Count.Name = "lbl_Items_Sold_Count";
            this.lbl_Items_Sold_Count.Size = new System.Drawing.Size(102, 23);
            this.lbl_Items_Sold_Count.TabIndex = 3;
            this.lbl_Items_Sold_Count.Text = "0";
            // 
            // View_Sold_Items
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_Items_Sold_Count);
            this.Controls.Add(this.htmlLabel2);
            this.Controls.Add(this.rb_Offline);
            this.Controls.Add(this.rb_Online);
            this.Controls.Add(this.rb_All);
            this.Controls.Add(this.htmlLabel1);
            this.Controls.Add(this.dt_Items_Sold);
            this.Name = "View_Sold_Items";
            this.Text = "View Sold Items";
            ((System.ComponentModel.ISupportInitialize)(this.dt_Items_Sold)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dt_Items_Sold;
        private MetroFramework.Drawing.Html.HtmlLabel htmlLabel1;
        private System.Windows.Forms.RadioButton rb_All;
        private System.Windows.Forms.RadioButton rb_Online;
        private System.Windows.Forms.RadioButton rb_Offline;
        private MetroFramework.Drawing.Html.HtmlLabel htmlLabel2;
        private MetroFramework.Drawing.Html.HtmlLabel lbl_Items_Sold_Count;
    }
}