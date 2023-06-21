
namespace Furniture_Shop
{
    partial class Monthly_Sales
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
            this.dt_Monthly_Sales = new System.Windows.Forms.DataGridView();
            this.htmlLabel1 = new MetroFramework.Drawing.Html.HtmlLabel();
            this.rb_Sold_Out = new System.Windows.Forms.RadioButton();
            this.rb_Remaining = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dt_Monthly_Sales)).BeginInit();
            this.SuspendLayout();
            // 
            // dt_Monthly_Sales
            // 
            this.dt_Monthly_Sales.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dt_Monthly_Sales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_Monthly_Sales.Location = new System.Drawing.Point(24, 76);
            this.dt_Monthly_Sales.Name = "dt_Monthly_Sales";
            this.dt_Monthly_Sales.Size = new System.Drawing.Size(753, 351);
            this.dt_Monthly_Sales.TabIndex = 0;
            // 
            // htmlLabel1
            // 
            this.htmlLabel1.AutoScroll = true;
            this.htmlLabel1.AutoScrollMinSize = new System.Drawing.Size(44, 23);
            this.htmlLabel1.AutoSize = false;
            this.htmlLabel1.BackColor = System.Drawing.SystemColors.Window;
            this.htmlLabel1.Location = new System.Drawing.Point(438, 37);
            this.htmlLabel1.Name = "htmlLabel1";
            this.htmlLabel1.Size = new System.Drawing.Size(55, 23);
            this.htmlLabel1.TabIndex = 1;
            this.htmlLabel1.Text = "Items : ";
            // 
            // rb_Sold_Out
            // 
            this.rb_Sold_Out.AutoSize = true;
            this.rb_Sold_Out.Location = new System.Drawing.Point(499, 39);
            this.rb_Sold_Out.Name = "rb_Sold_Out";
            this.rb_Sold_Out.Size = new System.Drawing.Size(66, 17);
            this.rb_Sold_Out.TabIndex = 2;
            this.rb_Sold_Out.Text = "Sold Out";
            this.rb_Sold_Out.UseVisualStyleBackColor = true;
            this.rb_Sold_Out.CheckedChanged += new System.EventHandler(this.rb_Sold_Out_CheckedChanged);
            // 
            // rb_Remaining
            // 
            this.rb_Remaining.AutoSize = true;
            this.rb_Remaining.Checked = true;
            this.rb_Remaining.Location = new System.Drawing.Point(587, 39);
            this.rb_Remaining.Name = "rb_Remaining";
            this.rb_Remaining.Size = new System.Drawing.Size(75, 17);
            this.rb_Remaining.TabIndex = 3;
            this.rb_Remaining.TabStop = true;
            this.rb_Remaining.Text = "Remaining";
            this.rb_Remaining.UseVisualStyleBackColor = true;
            this.rb_Remaining.CheckedChanged += new System.EventHandler(this.rb_Remaining_CheckedChanged);
            // 
            // Monthly_Sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rb_Remaining);
            this.Controls.Add(this.rb_Sold_Out);
            this.Controls.Add(this.htmlLabel1);
            this.Controls.Add(this.dt_Monthly_Sales);
            this.Name = "Monthly_Sales";
            this.Text = "Monthly Sales";
            ((System.ComponentModel.ISupportInitialize)(this.dt_Monthly_Sales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dt_Monthly_Sales;
        private MetroFramework.Drawing.Html.HtmlLabel htmlLabel1;
        private System.Windows.Forms.RadioButton rb_Sold_Out;
        private System.Windows.Forms.RadioButton rb_Remaining;
    }
}