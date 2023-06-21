
namespace Furniture_Shop
{
    partial class Get_Connection_String
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txt_computer_name = new MetroFramework.Controls.MetroTextBox();
            this.btn_ok = new MetroFramework.Controls.MetroButton();
            this.lbl_status = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(24, 92);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(176, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "ENTER COMPUTER NAME : ";
            // 
            // txt_computer_name
            // 
            // 
            // 
            // 
            this.txt_computer_name.CustomButton.Image = null;
            this.txt_computer_name.CustomButton.Location = new System.Drawing.Point(504, 1);
            this.txt_computer_name.CustomButton.Name = "";
            this.txt_computer_name.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_computer_name.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_computer_name.CustomButton.TabIndex = 1;
            this.txt_computer_name.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_computer_name.CustomButton.UseSelectable = true;
            this.txt_computer_name.CustomButton.Visible = false;
            this.txt_computer_name.Lines = new string[0];
            this.txt_computer_name.Location = new System.Drawing.Point(23, 125);
            this.txt_computer_name.MaxLength = 32767;
            this.txt_computer_name.Name = "txt_computer_name";
            this.txt_computer_name.PasswordChar = '\0';
            this.txt_computer_name.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_computer_name.SelectedText = "";
            this.txt_computer_name.SelectionLength = 0;
            this.txt_computer_name.SelectionStart = 0;
            this.txt_computer_name.ShortcutsEnabled = true;
            this.txt_computer_name.Size = new System.Drawing.Size(526, 23);
            this.txt_computer_name.TabIndex = 1;
            this.txt_computer_name.UseSelectable = true;
            this.txt_computer_name.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_computer_name.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(474, 172);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 23);
            this.btn_ok.TabIndex = 2;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseSelectable = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Location = new System.Drawing.Point(23, 172);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(0, 0);
            this.lbl_status.TabIndex = 3;
            // 
            // Get_Connection_String
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 232);
            this.Controls.Add(this.lbl_status);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.txt_computer_name);
            this.Controls.Add(this.metroLabel1);
            this.MaximizeBox = false;
            this.Name = "Get_Connection_String";
            this.Resizable = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Get Connection String";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txt_computer_name;
        private MetroFramework.Controls.MetroButton btn_ok;
        private MetroFramework.Controls.MetroLabel lbl_status;
    }
}