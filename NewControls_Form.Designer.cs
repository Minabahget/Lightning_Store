namespace MN_Lightining_Shop_Management_System
{
    partial class NewControls_Form
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewControls_Form));
            this.Header_Panel = new System.Windows.Forms.Panel();
            this.LogOut_Button = new Guna.UI2.WinForms.Guna2ImageButton();
            this.Down_Button = new Guna.UI2.WinForms.Guna2ImageButton();
            this.Close_Button = new Guna.UI2.WinForms.Guna2ImageButton();
            this.manager_name = new System.Windows.Forms.Label();
            this.Side_Panel = new System.Windows.Forms.Panel();
            this.Clients_Button = new Guna.UI2.WinForms.Guna2Button();
            this.Inventory_Button = new Guna.UI2.WinForms.Guna2Button();
            this.Add_Delete_Button = new Guna.UI2.WinForms.Guna2Button();
            this.Logo_PictureBox = new System.Windows.Forms.PictureBox();
            this.Controls_Elipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Header_Drag = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.Form_Animation = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.Digital_Timer = new System.Windows.Forms.Timer(this.components);
            this.Time_Label = new System.Windows.Forms.Label();
            this.Seconds_Label = new System.Windows.Forms.Label();
            this.Day_Label = new System.Windows.Forms.Label();
            this.Date_Label = new System.Windows.Forms.Label();
            this.Main_Panel = new System.Windows.Forms.Panel();
            this.Header_Panel.SuspendLayout();
            this.Side_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo_PictureBox)).BeginInit();
            this.Main_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Header_Panel
            // 
            this.Header_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.Header_Panel.Controls.Add(this.LogOut_Button);
            this.Header_Panel.Controls.Add(this.Down_Button);
            this.Header_Panel.Controls.Add(this.Close_Button);
            this.Header_Panel.Controls.Add(this.manager_name);
            this.Header_Panel.Location = new System.Drawing.Point(0, 0);
            this.Header_Panel.Name = "Header_Panel";
            this.Header_Panel.Size = new System.Drawing.Size(1429, 54);
            this.Header_Panel.TabIndex = 1;
            // 
            // LogOut_Button
            // 
            this.LogOut_Button.BackColor = System.Drawing.Color.Transparent;
            this.LogOut_Button.CheckedState.Parent = this.LogOut_Button;
            this.LogOut_Button.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("LogOut_Button.HoverState.Image")));
            this.LogOut_Button.HoverState.ImageSize = new System.Drawing.Size(25, 25);
            this.LogOut_Button.HoverState.Parent = this.LogOut_Button;
            this.LogOut_Button.Image = ((System.Drawing.Image)(resources.GetObject("LogOut_Button.Image")));
            this.LogOut_Button.ImageSize = new System.Drawing.Size(25, 25);
            this.LogOut_Button.Location = new System.Drawing.Point(1253, 7);
            this.LogOut_Button.Name = "LogOut_Button";
            this.LogOut_Button.PressedState.Parent = this.LogOut_Button;
            this.LogOut_Button.Size = new System.Drawing.Size(61, 39);
            this.LogOut_Button.TabIndex = 7;
            this.LogOut_Button.UseTransparentBackground = true;
            this.LogOut_Button.Click += new System.EventHandler(this.LogOut_Button_Click);
            // 
            // Down_Button
            // 
            this.Down_Button.BackColor = System.Drawing.Color.Transparent;
            this.Down_Button.CheckedState.Parent = this.Down_Button;
            this.Down_Button.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("Down_Button.HoverState.Image")));
            this.Down_Button.HoverState.ImageSize = new System.Drawing.Size(25, 25);
            this.Down_Button.HoverState.Parent = this.Down_Button;
            this.Down_Button.Image = ((System.Drawing.Image)(resources.GetObject("Down_Button.Image")));
            this.Down_Button.ImageSize = new System.Drawing.Size(25, 25);
            this.Down_Button.Location = new System.Drawing.Point(1305, 7);
            this.Down_Button.Name = "Down_Button";
            this.Down_Button.PressedState.Parent = this.Down_Button;
            this.Down_Button.Size = new System.Drawing.Size(61, 39);
            this.Down_Button.TabIndex = 6;
            this.Down_Button.UseTransparentBackground = true;
            this.Down_Button.Click += new System.EventHandler(this.Down_Button_Click);
            // 
            // Close_Button
            // 
            this.Close_Button.BackColor = System.Drawing.Color.Transparent;
            this.Close_Button.CheckedState.Parent = this.Close_Button;
            this.Close_Button.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("Close_Button.HoverState.Image")));
            this.Close_Button.HoverState.ImageSize = new System.Drawing.Size(25, 25);
            this.Close_Button.HoverState.Parent = this.Close_Button;
            this.Close_Button.Image = ((System.Drawing.Image)(resources.GetObject("Close_Button.Image")));
            this.Close_Button.ImageSize = new System.Drawing.Size(25, 25);
            this.Close_Button.Location = new System.Drawing.Point(1362, 7);
            this.Close_Button.Name = "Close_Button";
            this.Close_Button.PressedState.Parent = this.Close_Button;
            this.Close_Button.Size = new System.Drawing.Size(61, 39);
            this.Close_Button.TabIndex = 5;
            this.Close_Button.UseTransparentBackground = true;
            this.Close_Button.Click += new System.EventHandler(this.Close_Button_Click);
            // 
            // manager_name
            // 
            this.manager_name.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.manager_name.AutoSize = true;
            this.manager_name.Font = new System.Drawing.Font("Century Gothic", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manager_name.ForeColor = System.Drawing.Color.White;
            this.manager_name.Location = new System.Drawing.Point(594, 0);
            this.manager_name.Name = "manager_name";
            this.manager_name.Size = new System.Drawing.Size(223, 46);
            this.manager_name.TabIndex = 4;
            this.manager_name.Text = ": اسم المستخدم";
            // 
            // Side_Panel
            // 
            this.Side_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.Side_Panel.Controls.Add(this.Clients_Button);
            this.Side_Panel.Controls.Add(this.Inventory_Button);
            this.Side_Panel.Controls.Add(this.Add_Delete_Button);
            this.Side_Panel.Controls.Add(this.Logo_PictureBox);
            this.Side_Panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.Side_Panel.Location = new System.Drawing.Point(0, 0);
            this.Side_Panel.Name = "Side_Panel";
            this.Side_Panel.Size = new System.Drawing.Size(411, 485);
            this.Side_Panel.TabIndex = 2;
            // 
            // Clients_Button
            // 
            this.Clients_Button.Animated = true;
            this.Clients_Button.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.Clients_Button.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.Clients_Button.CheckedState.ForeColor = System.Drawing.Color.Silver;
            this.Clients_Button.CheckedState.Parent = this.Clients_Button;
            this.Clients_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Clients_Button.CustomImages.Parent = this.Clients_Button;
            this.Clients_Button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.Clients_Button.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clients_Button.ForeColor = System.Drawing.Color.Silver;
            this.Clients_Button.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.Clients_Button.HoverState.ForeColor = System.Drawing.Color.Red;
            this.Clients_Button.HoverState.Parent = this.Clients_Button;
            this.Clients_Button.Image = ((System.Drawing.Image)(resources.GetObject("Clients_Button.Image")));
            this.Clients_Button.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Clients_Button.ImageSize = new System.Drawing.Size(36, 36);
            this.Clients_Button.Location = new System.Drawing.Point(0, 303);
            this.Clients_Button.Name = "Clients_Button";
            this.Clients_Button.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.Clients_Button.PressedDepth = 60;
            this.Clients_Button.ShadowDecoration.Parent = this.Clients_Button;
            this.Clients_Button.Size = new System.Drawing.Size(411, 66);
            this.Clients_Button.TabIndex = 12;
            this.Clients_Button.Text = "العملاء";
            this.Clients_Button.Click += new System.EventHandler(this.Clients_Button_Click);
            // 
            // Inventory_Button
            // 
            this.Inventory_Button.Animated = true;
            this.Inventory_Button.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.Inventory_Button.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.Inventory_Button.CheckedState.ForeColor = System.Drawing.Color.Silver;
            this.Inventory_Button.CheckedState.Parent = this.Inventory_Button;
            this.Inventory_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Inventory_Button.CustomImages.Parent = this.Inventory_Button;
            this.Inventory_Button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.Inventory_Button.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Inventory_Button.ForeColor = System.Drawing.Color.Silver;
            this.Inventory_Button.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.Inventory_Button.HoverState.ForeColor = System.Drawing.Color.Red;
            this.Inventory_Button.HoverState.Parent = this.Inventory_Button;
            this.Inventory_Button.Image = ((System.Drawing.Image)(resources.GetObject("Inventory_Button.Image")));
            this.Inventory_Button.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Inventory_Button.ImageSize = new System.Drawing.Size(36, 36);
            this.Inventory_Button.Location = new System.Drawing.Point(0, 231);
            this.Inventory_Button.Name = "Inventory_Button";
            this.Inventory_Button.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.Inventory_Button.PressedDepth = 60;
            this.Inventory_Button.ShadowDecoration.Parent = this.Inventory_Button;
            this.Inventory_Button.Size = new System.Drawing.Size(411, 66);
            this.Inventory_Button.TabIndex = 11;
            this.Inventory_Button.Text = "المخزن";
            this.Inventory_Button.Click += new System.EventHandler(this.Inventory_Button_Click);
            // 
            // Add_Delete_Button
            // 
            this.Add_Delete_Button.Animated = true;
            this.Add_Delete_Button.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.Add_Delete_Button.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.Add_Delete_Button.CheckedState.ForeColor = System.Drawing.Color.Silver;
            this.Add_Delete_Button.CheckedState.Parent = this.Add_Delete_Button;
            this.Add_Delete_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Add_Delete_Button.CustomImages.Parent = this.Add_Delete_Button;
            this.Add_Delete_Button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.Add_Delete_Button.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_Delete_Button.ForeColor = System.Drawing.Color.Silver;
            this.Add_Delete_Button.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.Add_Delete_Button.HoverState.ForeColor = System.Drawing.Color.Red;
            this.Add_Delete_Button.HoverState.Parent = this.Add_Delete_Button;
            this.Add_Delete_Button.Image = ((System.Drawing.Image)(resources.GetObject("Add_Delete_Button.Image")));
            this.Add_Delete_Button.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Add_Delete_Button.ImageSize = new System.Drawing.Size(36, 36);
            this.Add_Delete_Button.Location = new System.Drawing.Point(0, 161);
            this.Add_Delete_Button.Name = "Add_Delete_Button";
            this.Add_Delete_Button.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.Add_Delete_Button.PressedDepth = 60;
            this.Add_Delete_Button.ShadowDecoration.Parent = this.Add_Delete_Button;
            this.Add_Delete_Button.Size = new System.Drawing.Size(411, 66);
            this.Add_Delete_Button.TabIndex = 8;
            this.Add_Delete_Button.Text = "أضافة / أزالة";
            this.Add_Delete_Button.Click += new System.EventHandler(this.Categories_Button_Click_1);
            // 
            // Logo_PictureBox
            // 
            this.Logo_PictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Logo_PictureBox.Image = ((System.Drawing.Image)(resources.GetObject("Logo_PictureBox.Image")));
            this.Logo_PictureBox.Location = new System.Drawing.Point(-12, 60);
            this.Logo_PictureBox.Name = "Logo_PictureBox";
            this.Logo_PictureBox.Size = new System.Drawing.Size(423, 100);
            this.Logo_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Logo_PictureBox.TabIndex = 0;
            this.Logo_PictureBox.TabStop = false;
            this.Logo_PictureBox.Click += new System.EventHandler(this.Logo_PictureBox_Click);
            // 
            // Controls_Elipse
            // 
            this.Controls_Elipse.ElipseRadius = 30;
            this.Controls_Elipse.TargetControl = this;
            // 
            // Header_Drag
            // 
            this.Header_Drag.Fixed = true;
            this.Header_Drag.Horizontal = true;
            this.Header_Drag.TargetControl = this.Header_Panel;
            this.Header_Drag.Vertical = true;
            // 
            // Form_Animation
            // 
            this.Form_Animation.Interval = 300;
            // 
            // Digital_Timer
            // 
            this.Digital_Timer.Tick += new System.EventHandler(this.Digital_Timer_Tick);
            // 
            // Time_Label
            // 
            this.Time_Label.AutoSize = true;
            this.Time_Label.Font = new System.Drawing.Font("Lucida Handwriting", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Time_Label.ForeColor = System.Drawing.Color.White;
            this.Time_Label.Location = new System.Drawing.Point(347, 10);
            this.Time_Label.Name = "Time_Label";
            this.Time_Label.Size = new System.Drawing.Size(309, 78);
            this.Time_Label.TabIndex = 4;
            this.Time_Label.Text = "22:22 ص";
            // 
            // Seconds_Label
            // 
            this.Seconds_Label.AutoSize = true;
            this.Seconds_Label.Font = new System.Drawing.Font("Lucida Handwriting", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Seconds_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Seconds_Label.Location = new System.Drawing.Point(677, 55);
            this.Seconds_Label.Name = "Seconds_Label";
            this.Seconds_Label.Size = new System.Drawing.Size(65, 43);
            this.Seconds_Label.TabIndex = 5;
            this.Seconds_Label.Text = "22";
            // 
            // Day_Label
            // 
            this.Day_Label.AutoSize = true;
            this.Day_Label.Font = new System.Drawing.Font("Lucida Handwriting", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Day_Label.ForeColor = System.Drawing.Color.White;
            this.Day_Label.Location = new System.Drawing.Point(757, 297);
            this.Day_Label.Name = "Day_Label";
            this.Day_Label.Size = new System.Drawing.Size(182, 43);
            this.Day_Label.TabIndex = 6;
            this.Day_Label.Text = "Satuday";
            // 
            // Date_Label
            // 
            this.Date_Label.AutoSize = true;
            this.Date_Label.Font = new System.Drawing.Font("Lucida Handwriting", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date_Label.ForeColor = System.Drawing.Color.White;
            this.Date_Label.Location = new System.Drawing.Point(122, 297);
            this.Date_Label.Name = "Date_Label";
            this.Date_Label.Size = new System.Drawing.Size(348, 43);
            this.Date_Label.TabIndex = 7;
            this.Date_Label.Text = "January 25 2020";
            // 
            // Main_Panel
            // 
            this.Main_Panel.Controls.Add(this.Date_Label);
            this.Main_Panel.Controls.Add(this.Day_Label);
            this.Main_Panel.Controls.Add(this.Seconds_Label);
            this.Main_Panel.Controls.Add(this.Time_Label);
            this.Main_Panel.Location = new System.Drawing.Point(411, 54);
            this.Main_Panel.Name = "Main_Panel";
            this.Main_Panel.Size = new System.Drawing.Size(1015, 431);
            this.Main_Panel.TabIndex = 3;
            // 
            // NewControls_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(1429, 485);
            this.Controls.Add(this.Main_Panel);
            this.Controls.Add(this.Header_Panel);
            this.Controls.Add(this.Side_Panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NewControls_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control Options";
            this.Load += new System.EventHandler(this.NewControls_Form_Load);
            this.Header_Panel.ResumeLayout(false);
            this.Header_Panel.PerformLayout();
            this.Side_Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Logo_PictureBox)).EndInit();
            this.Main_Panel.ResumeLayout(false);
            this.Main_Panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel Header_Panel;
        private System.Windows.Forms.Label manager_name;
        private System.Windows.Forms.Panel Side_Panel;
        private System.Windows.Forms.PictureBox Logo_PictureBox;
        private Bunifu.Framework.UI.BunifuElipse Controls_Elipse;
        private Bunifu.Framework.UI.BunifuDragControl Header_Drag;
        private Guna.UI2.WinForms.Guna2AnimateWindow Form_Animation;
        private System.Windows.Forms.Timer Digital_Timer;
        private System.Windows.Forms.Panel Main_Panel;
        private System.Windows.Forms.Label Date_Label;
        private System.Windows.Forms.Label Day_Label;
        private System.Windows.Forms.Label Seconds_Label;
        private System.Windows.Forms.Label Time_Label;
        private Guna.UI2.WinForms.Guna2Button Add_Delete_Button;
        private Guna.UI2.WinForms.Guna2ImageButton LogOut_Button;
        private Guna.UI2.WinForms.Guna2ImageButton Down_Button;
        private Guna.UI2.WinForms.Guna2ImageButton Close_Button;
        private Guna.UI2.WinForms.Guna2Button Inventory_Button;
        private Guna.UI2.WinForms.Guna2Button Clients_Button;
    }
}