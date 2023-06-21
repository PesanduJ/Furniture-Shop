
namespace Furniture_Shop
{
    partial class Add_Category
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
            this.lbl_username = new MetroFramework.Drawing.Html.HtmlLabel();
            this.htmlLabel1 = new MetroFramework.Drawing.Html.HtmlLabel();
            this.htmlLabel2 = new MetroFramework.Drawing.Html.HtmlLabel();
            this.btn_Save = new MetroFramework.Controls.MetroButton();
            this.btn_Cancel = new MetroFramework.Controls.MetroButton();
            this.txt_Category = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // lbl_username
            // 
            this.lbl_username.AutoScroll = true;
            this.lbl_username.AutoScrollMinSize = new System.Drawing.Size(10, 0);
            this.lbl_username.AutoSize = false;
            this.lbl_username.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.Location = new System.Drawing.Point(120, 63);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(485, 31);
            this.lbl_username.TabIndex = 3;
            // 
            // htmlLabel1
            // 
            this.htmlLabel1.AutoScroll = true;
            this.htmlLabel1.AutoScrollMinSize = new System.Drawing.Size(81, 25);
            this.htmlLabel1.AutoSize = false;
            this.htmlLabel1.BackColor = System.Drawing.SystemColors.Window;
            this.htmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.htmlLabel1.Location = new System.Drawing.Point(23, 63);
            this.htmlLabel1.Name = "htmlLabel1";
            this.htmlLabel1.Size = new System.Drawing.Size(91, 31);
            this.htmlLabel1.TabIndex = 2;
            this.htmlLabel1.Text = "Username :";
            // 
            // htmlLabel2
            // 
            this.htmlLabel2.AutoScroll = true;
            this.htmlLabel2.AutoScrollMinSize = new System.Drawing.Size(114, 25);
            this.htmlLabel2.AutoSize = false;
            this.htmlLabel2.BackColor = System.Drawing.SystemColors.Window;
            this.htmlLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.htmlLabel2.Location = new System.Drawing.Point(23, 100);
            this.htmlLabel2.Name = "htmlLabel2";
            this.htmlLabel2.Size = new System.Drawing.Size(118, 31);
            this.htmlLabel2.TabIndex = 3;
            this.htmlLabel2.Text = "Category Name :";
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(550, 171);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 23);
            this.btn_Save.TabIndex = 4;
            this.btn_Save.Text = "SAVE";
            this.btn_Save.UseSelectable = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(422, 171);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 5;
            this.btn_Cancel.Text = "CANCEL";
            this.btn_Cancel.UseSelectable = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // txt_Category
            // 
            // 
            // 
            // 
            this.txt_Category.CustomButton.Image = null;
            this.txt_Category.CustomButton.Location = new System.Drawing.Point(436, 1);
            this.txt_Category.CustomButton.Name = "";
            this.txt_Category.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_Category.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_Category.CustomButton.TabIndex = 1;
            this.txt_Category.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_Category.CustomButton.UseSelectable = true;
            this.txt_Category.CustomButton.Visible = false;
            this.txt_Category.Lines = new string[0];
            this.txt_Category.Location = new System.Drawing.Point(147, 100);
            this.txt_Category.MaxLength = 32767;
            this.txt_Category.Name = "txt_Category";
            this.txt_Category.PasswordChar = '\0';
            this.txt_Category.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_Category.SelectedText = "";
            this.txt_Category.SelectionLength = 0;
            this.txt_Category.SelectionStart = 0;
            this.txt_Category.ShortcutsEnabled = true;
            this.txt_Category.Size = new System.Drawing.Size(458, 23);
            this.txt_Category.TabIndex = 6;
            this.txt_Category.UseSelectable = true;
            this.txt_Category.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_Category.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Add_Category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 220);
            this.Controls.Add(this.txt_Category);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.htmlLabel2);
            this.Controls.Add(this.lbl_username);
            this.Controls.Add(this.htmlLabel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Add_Category";
            this.Resizable = false;
            this.Text = "Add Category";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Drawing.Html.HtmlLabel lbl_username;
        private MetroFramework.Drawing.Html.HtmlLabel htmlLabel1;
        private MetroFramework.Drawing.Html.HtmlLabel htmlLabel2;
        private MetroFramework.Controls.MetroButton btn_Save;
        private MetroFramework.Controls.MetroButton btn_Cancel;
        private MetroFramework.Controls.MetroTextBox txt_Category;
    }
}