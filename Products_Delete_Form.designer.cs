namespace MN_Lightining_Shop_Management_System
{
    partial class Products_Delete_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Products_Delete_Form));
            this.Controls_Elipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Header_Panel = new System.Windows.Forms.Panel();
            this.Refresh_Button = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Down_Button = new Guna.UI2.WinForms.Guna2ImageButton();
            this.Close_Button = new Guna.UI2.WinForms.Guna2ImageButton();
            this.Header_Drag = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.Form_Animation = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.Delete_Button = new Guna.UI2.WinForms.Guna2GradientButton();
            this.Cat_Combobox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.Prod_ComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Header_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Controls_Elipse
            // 
            this.Controls_Elipse.ElipseRadius = 30;
            this.Controls_Elipse.TargetControl = this;
            // 
            // Header_Panel
            // 
            this.Header_Panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Header_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.Header_Panel.Controls.Add(this.Refresh_Button);
            this.Header_Panel.Controls.Add(this.guna2HtmlLabel2);
            this.Header_Panel.Controls.Add(this.guna2HtmlLabel1);
            this.Header_Panel.Controls.Add(this.Down_Button);
            this.Header_Panel.Controls.Add(this.Close_Button);
            this.Header_Panel.Location = new System.Drawing.Point(0, 1);
            this.Header_Panel.Name = "Header_Panel";
            this.Header_Panel.Size = new System.Drawing.Size(1257, 54);
            this.Header_Panel.TabIndex = 9;
            // 
            // Refresh_Button
            // 
            this.Refresh_Button.BackColor = System.Drawing.Color.Transparent;
            this.Refresh_Button.CheckedState.Parent = this.Refresh_Button;
            this.Refresh_Button.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("Refresh_Button.HoverState.Image")));
            this.Refresh_Button.HoverState.ImageSize = new System.Drawing.Size(25, 25);
            this.Refresh_Button.HoverState.Parent = this.Refresh_Button;
            this.Refresh_Button.Image = ((System.Drawing.Image)(resources.GetObject("Refresh_Button.Image")));
            this.Refresh_Button.ImageSize = new System.Drawing.Size(25, 25);
            this.Refresh_Button.Location = new System.Drawing.Point(1077, 6);
            this.Refresh_Button.Name = "Refresh_Button";
            this.Refresh_Button.PressedState.Parent = this.Refresh_Button;
            this.Refresh_Button.Size = new System.Drawing.Size(61, 39);
            this.Refresh_Button.TabIndex = 10;
            this.Refresh_Button.UseTransparentBackground = true;
            this.Refresh_Button.Click += new System.EventHandler(this.Refresh_Button_Click);
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.AutoSize = false;
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Segoe UI", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(558, 6);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(372, 48);
            this.guna2HtmlLabel2.TabIndex = 3;
            this.guna2HtmlLabel2.Text = "موجود منتج إزاله";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.AutoSize = false;
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(8, 6);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(420, 48);
            this.guna2HtmlLabel1.TabIndex = 2;
            this.guna2HtmlLabel1.Text = "M&N Lightining Shop";
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
            this.Down_Button.Location = new System.Drawing.Point(1135, 6);
            this.Down_Button.Name = "Down_Button";
            this.Down_Button.PressedState.Parent = this.Down_Button;
            this.Down_Button.Size = new System.Drawing.Size(61, 39);
            this.Down_Button.TabIndex = 1;
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
            this.Close_Button.Location = new System.Drawing.Point(1192, 6);
            this.Close_Button.Name = "Close_Button";
            this.Close_Button.PressedState.Parent = this.Close_Button;
            this.Close_Button.Size = new System.Drawing.Size(61, 39);
            this.Close_Button.TabIndex = 3;
            this.Close_Button.UseTransparentBackground = true;
            this.Close_Button.Click += new System.EventHandler(this.Close_Button_Click);
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
            this.Form_Animation.AnimationType = Guna.UI2.WinForms.Guna2AnimateWindow.AnimateWindowType.AW_HOR_POSITIVE;
            this.Form_Animation.Interval = 300;
            // 
            // Delete_Button
            // 
            this.Delete_Button.Animated = true;
            this.Delete_Button.BackColor = System.Drawing.Color.Transparent;
            this.Delete_Button.BorderRadius = 30;
            this.Delete_Button.CheckedState.Parent = this.Delete_Button;
            this.Delete_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Delete_Button.CustomImages.Parent = this.Delete_Button;
            this.Delete_Button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.Delete_Button.FillColor2 = System.Drawing.Color.DarkRed;
            this.Delete_Button.Font = new System.Drawing.Font("Segoe UI", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Delete_Button.ForeColor = System.Drawing.Color.White;
            this.Delete_Button.HoverState.Parent = this.Delete_Button;
            this.Delete_Button.Location = new System.Drawing.Point(427, 449);
            this.Delete_Button.Name = "Delete_Button";
            this.Delete_Button.PressedColor = System.Drawing.SystemColors.ActiveCaption;
            this.Delete_Button.PressedDepth = 60;
            this.Delete_Button.ShadowDecoration.BorderRadius = 30;
            this.Delete_Button.ShadowDecoration.Color = System.Drawing.Color.Maroon;
            this.Delete_Button.ShadowDecoration.Depth = 40;
            this.Delete_Button.ShadowDecoration.Enabled = true;
            this.Delete_Button.ShadowDecoration.Parent = this.Delete_Button;
            this.Delete_Button.Size = new System.Drawing.Size(415, 74);
            this.Delete_Button.TabIndex = 6;
            this.Delete_Button.Text = "ازالة المنتج";
            this.Delete_Button.Click += new System.EventHandler(this.Delete_Button_Click);
            this.Delete_Button.KeyDown += new System.Windows.Forms.KeyEventHandler(this.key_down_function);
            // 
            // Cat_Combobox
            // 
            this.Cat_Combobox.Animated = true;
            this.Cat_Combobox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Cat_Combobox.BorderColor = System.Drawing.Color.White;
            this.Cat_Combobox.BorderRadius = 15;
            this.Cat_Combobox.BorderThickness = 3;
            this.Cat_Combobox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Cat_Combobox.DropDownHeight = 500;
            this.Cat_Combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cat_Combobox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.Cat_Combobox.FocusedColor = System.Drawing.Color.Empty;
            this.Cat_Combobox.FocusedState.Parent = this.Cat_Combobox;
            this.Cat_Combobox.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.Cat_Combobox.ForeColor = System.Drawing.Color.White;
            this.Cat_Combobox.FormattingEnabled = true;
            this.Cat_Combobox.HoverState.ForeColor = System.Drawing.Color.White;
            this.Cat_Combobox.HoverState.Parent = this.Cat_Combobox;
            this.Cat_Combobox.IntegralHeight = false;
            this.Cat_Combobox.ItemHeight = 30;
            this.Cat_Combobox.ItemsAppearance.Parent = this.Cat_Combobox;
            this.Cat_Combobox.ItemsAppearance.SelectedForeColor = System.Drawing.Color.DodgerBlue;
            this.Cat_Combobox.Location = new System.Drawing.Point(423, 195);
            this.Cat_Combobox.MaxDropDownItems = 15;
            this.Cat_Combobox.Name = "Cat_Combobox";
            this.Cat_Combobox.ShadowDecoration.Parent = this.Cat_Combobox;
            this.Cat_Combobox.Size = new System.Drawing.Size(415, 36);
            this.Cat_Combobox.TabIndex = 21;
            this.Cat_Combobox.SelectedIndexChanged += new System.EventHandler(this.Cat_Combobox_SelectedIndexChanged);
            this.Cat_Combobox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.key_down_function);
            // 
            // Prod_ComboBox
            // 
            this.Prod_ComboBox.Animated = true;
            this.Prod_ComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Prod_ComboBox.BorderColor = System.Drawing.Color.White;
            this.Prod_ComboBox.BorderRadius = 15;
            this.Prod_ComboBox.BorderThickness = 3;
            this.Prod_ComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Prod_ComboBox.DropDownHeight = 500;
            this.Prod_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Prod_ComboBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.Prod_ComboBox.FocusedColor = System.Drawing.Color.Empty;
            this.Prod_ComboBox.FocusedState.Parent = this.Prod_ComboBox;
            this.Prod_ComboBox.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.Prod_ComboBox.ForeColor = System.Drawing.Color.White;
            this.Prod_ComboBox.FormattingEnabled = true;
            this.Prod_ComboBox.HoverState.ForeColor = System.Drawing.Color.White;
            this.Prod_ComboBox.HoverState.Parent = this.Prod_ComboBox;
            this.Prod_ComboBox.IntegralHeight = false;
            this.Prod_ComboBox.ItemHeight = 30;
            this.Prod_ComboBox.ItemsAppearance.Parent = this.Prod_ComboBox;
            this.Prod_ComboBox.ItemsAppearance.SelectedForeColor = System.Drawing.Color.DodgerBlue;
            this.Prod_ComboBox.Location = new System.Drawing.Point(423, 357);
            this.Prod_ComboBox.MaxDropDownItems = 15;
            this.Prod_ComboBox.Name = "Prod_ComboBox";
            this.Prod_ComboBox.ShadowDecoration.Parent = this.Prod_ComboBox;
            this.Prod_ComboBox.Size = new System.Drawing.Size(415, 36);
            this.Prod_ComboBox.TabIndex = 22;
            this.Prod_ComboBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.key_down_function);
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.AutoSize = false;
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Segoe UI", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(549, 136);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(372, 48);
            this.guna2HtmlLabel3.TabIndex = 11;
            this.guna2HtmlLabel3.Text = "الصنف اختر";
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.AutoSize = false;
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Segoe UI", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(545, 295);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(372, 48);
            this.guna2HtmlLabel4.TabIndex = 23;
            this.guna2HtmlLabel4.Text = "المنتج اختر";
            // 
            // Products_Delete_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(1257, 620);
            this.Controls.Add(this.guna2HtmlLabel4);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.Prod_ComboBox);
            this.Controls.Add(this.Cat_Combobox);
            this.Controls.Add(this.Delete_Button);
            this.Controls.Add(this.Header_Panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Products_Delete_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delete Product";
            this.Load += new System.EventHandler(this.Products_Delete_Form_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.key_down_function);
            this.Header_Panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2AnimateWindow Form_Animation;
        private Bunifu.Framework.UI.BunifuElipse Controls_Elipse;
        private System.Windows.Forms.Panel Header_Panel;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2ImageButton Down_Button;
        private Guna.UI2.WinForms.Guna2ImageButton Close_Button;
        private Bunifu.Framework.UI.BunifuDragControl Header_Drag;
        private Guna.UI2.WinForms.Guna2GradientButton Delete_Button;
        private Guna.UI2.WinForms.Guna2ImageButton Refresh_Button;
        private Guna.UI2.WinForms.Guna2ComboBox Cat_Combobox;
        private Guna.UI2.WinForms.Guna2ComboBox Prod_ComboBox;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
    }
}