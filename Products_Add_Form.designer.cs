namespace MN_Lightining_Shop_Management_System
{
    partial class Products_Add_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Products_Add_Form));
            this.Controls_Elipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Header_Panel = new System.Windows.Forms.Panel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Down_Button = new Guna.UI2.WinForms.Guna2ImageButton();
            this.Close_Button = new Guna.UI2.WinForms.Guna2ImageButton();
            this.Header_Drag = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.Product_TextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.Form_Animation = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.Insert_Button = new Guna.UI2.WinForms.Guna2GradientButton();
            this.UnitPrice_TextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.BoxPrice_TextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.Quantity_TextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.Code_TextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.Refresh_Button = new Guna.UI2.WinForms.Guna2ImageButton();
            this.Cat_Combobox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
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
            this.guna2HtmlLabel2.Text = "جديد منتج اضافه";
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
            // Product_TextBox
            // 
            this.Product_TextBox.Animated = true;
            this.Product_TextBox.BorderColor = System.Drawing.Color.Silver;
            this.Product_TextBox.BorderRadius = 15;
            this.Product_TextBox.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.Product_TextBox.BorderThickness = 2;
            this.Product_TextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Product_TextBox.DefaultText = "ادخل اسم المنتج";
            this.Product_TextBox.DisabledState.BorderColor = System.Drawing.Color.Silver;
            this.Product_TextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Product_TextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Product_TextBox.DisabledState.Parent = this.Product_TextBox;
            this.Product_TextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Product_TextBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.Product_TextBox.FocusedState.BorderColor = System.Drawing.Color.Red;
            this.Product_TextBox.FocusedState.Parent = this.Product_TextBox;
            this.Product_TextBox.Font = new System.Drawing.Font("Segoe UI", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Product_TextBox.ForeColor = System.Drawing.Color.White;
            this.Product_TextBox.HoverState.BorderColor = System.Drawing.Color.Red;
            this.Product_TextBox.HoverState.Parent = this.Product_TextBox;
            this.Product_TextBox.IconLeft = ((System.Drawing.Image)(resources.GetObject("Product_TextBox.IconLeft")));
            this.Product_TextBox.IconLeftSize = new System.Drawing.Size(35, 35);
            this.Product_TextBox.Location = new System.Drawing.Point(93, 95);
            this.Product_TextBox.Margin = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.Product_TextBox.Name = "Product_TextBox";
            this.Product_TextBox.PasswordChar = '\0';
            this.Product_TextBox.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.Product_TextBox.PlaceholderText = "";
            this.Product_TextBox.SelectedText = "";
            this.Product_TextBox.SelectionStart = 15;
            this.Product_TextBox.ShadowDecoration.Parent = this.Product_TextBox;
            this.Product_TextBox.Size = new System.Drawing.Size(607, 62);
            this.Product_TextBox.TabIndex = 1;
            this.Product_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Product_TextBox.Enter += new System.EventHandler(this.Product_TextBox_Enter);
            this.Product_TextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.key_down_function);
            this.Product_TextBox.Leave += new System.EventHandler(this.Product_TextBox_Leave);
            // 
            // Form_Animation
            // 
            this.Form_Animation.AnimationType = Guna.UI2.WinForms.Guna2AnimateWindow.AnimateWindowType.AW_HOR_POSITIVE;
            this.Form_Animation.Interval = 300;
            // 
            // Insert_Button
            // 
            this.Insert_Button.Animated = true;
            this.Insert_Button.BackColor = System.Drawing.Color.Transparent;
            this.Insert_Button.BorderRadius = 30;
            this.Insert_Button.CheckedState.Parent = this.Insert_Button;
            this.Insert_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Insert_Button.CustomImages.Parent = this.Insert_Button;
            this.Insert_Button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.Insert_Button.FillColor2 = System.Drawing.Color.DarkRed;
            this.Insert_Button.Font = new System.Drawing.Font("Segoe UI", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Insert_Button.ForeColor = System.Drawing.Color.White;
            this.Insert_Button.HoverState.Parent = this.Insert_Button;
            this.Insert_Button.Location = new System.Drawing.Point(189, 497);
            this.Insert_Button.Name = "Insert_Button";
            this.Insert_Button.PressedColor = System.Drawing.SystemColors.ActiveCaption;
            this.Insert_Button.PressedDepth = 60;
            this.Insert_Button.ShadowDecoration.BorderRadius = 30;
            this.Insert_Button.ShadowDecoration.Color = System.Drawing.Color.Maroon;
            this.Insert_Button.ShadowDecoration.Depth = 40;
            this.Insert_Button.ShadowDecoration.Enabled = true;
            this.Insert_Button.ShadowDecoration.Parent = this.Insert_Button;
            this.Insert_Button.Size = new System.Drawing.Size(415, 74);
            this.Insert_Button.TabIndex = 6;
            this.Insert_Button.Text = "اضافة المنتج";
            this.Insert_Button.Click += new System.EventHandler(this.Insert_Button_Click);
            this.Insert_Button.KeyDown += new System.Windows.Forms.KeyEventHandler(this.key_down_function);
            // 
            // UnitPrice_TextBox
            // 
            this.UnitPrice_TextBox.Animated = true;
            this.UnitPrice_TextBox.BorderColor = System.Drawing.Color.Silver;
            this.UnitPrice_TextBox.BorderRadius = 15;
            this.UnitPrice_TextBox.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.UnitPrice_TextBox.BorderThickness = 2;
            this.UnitPrice_TextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UnitPrice_TextBox.DefaultText = "ادخل سعر الوحده";
            this.UnitPrice_TextBox.DisabledState.BorderColor = System.Drawing.Color.Silver;
            this.UnitPrice_TextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.UnitPrice_TextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.UnitPrice_TextBox.DisabledState.Parent = this.UnitPrice_TextBox;
            this.UnitPrice_TextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.UnitPrice_TextBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.UnitPrice_TextBox.FocusedState.BorderColor = System.Drawing.Color.Red;
            this.UnitPrice_TextBox.FocusedState.Parent = this.UnitPrice_TextBox;
            this.UnitPrice_TextBox.Font = new System.Drawing.Font("Segoe UI", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.UnitPrice_TextBox.ForeColor = System.Drawing.Color.White;
            this.UnitPrice_TextBox.HoverState.BorderColor = System.Drawing.Color.Red;
            this.UnitPrice_TextBox.HoverState.Parent = this.UnitPrice_TextBox;
            this.UnitPrice_TextBox.IconLeft = ((System.Drawing.Image)(resources.GetObject("UnitPrice_TextBox.IconLeft")));
            this.UnitPrice_TextBox.IconLeftSize = new System.Drawing.Size(35, 35);
            this.UnitPrice_TextBox.Location = new System.Drawing.Point(93, 246);
            this.UnitPrice_TextBox.Margin = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.UnitPrice_TextBox.Name = "UnitPrice_TextBox";
            this.UnitPrice_TextBox.PasswordChar = '\0';
            this.UnitPrice_TextBox.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.UnitPrice_TextBox.PlaceholderText = "";
            this.UnitPrice_TextBox.SelectedText = "";
            this.UnitPrice_TextBox.ShadowDecoration.Parent = this.UnitPrice_TextBox;
            this.UnitPrice_TextBox.Size = new System.Drawing.Size(607, 62);
            this.UnitPrice_TextBox.TabIndex = 3;
            this.UnitPrice_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.UnitPrice_TextBox.Enter += new System.EventHandler(this.UnitPrice_TextBox_Enter);
            this.UnitPrice_TextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.key_down_function);
            this.UnitPrice_TextBox.Leave += new System.EventHandler(this.UnitPrice_TextBox_Leave);
            // 
            // BoxPrice_TextBox
            // 
            this.BoxPrice_TextBox.Animated = true;
            this.BoxPrice_TextBox.BorderColor = System.Drawing.Color.Silver;
            this.BoxPrice_TextBox.BorderRadius = 15;
            this.BoxPrice_TextBox.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.BoxPrice_TextBox.BorderThickness = 2;
            this.BoxPrice_TextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.BoxPrice_TextBox.DefaultText = "ادخل سعر الكرتونه";
            this.BoxPrice_TextBox.DisabledState.BorderColor = System.Drawing.Color.Silver;
            this.BoxPrice_TextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BoxPrice_TextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BoxPrice_TextBox.DisabledState.Parent = this.BoxPrice_TextBox;
            this.BoxPrice_TextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BoxPrice_TextBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.BoxPrice_TextBox.FocusedState.BorderColor = System.Drawing.Color.Red;
            this.BoxPrice_TextBox.FocusedState.Parent = this.BoxPrice_TextBox;
            this.BoxPrice_TextBox.Font = new System.Drawing.Font("Segoe UI", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.BoxPrice_TextBox.ForeColor = System.Drawing.Color.White;
            this.BoxPrice_TextBox.HoverState.BorderColor = System.Drawing.Color.Red;
            this.BoxPrice_TextBox.HoverState.Parent = this.BoxPrice_TextBox;
            this.BoxPrice_TextBox.IconLeft = ((System.Drawing.Image)(resources.GetObject("BoxPrice_TextBox.IconLeft")));
            this.BoxPrice_TextBox.IconLeftSize = new System.Drawing.Size(35, 35);
            this.BoxPrice_TextBox.Location = new System.Drawing.Point(93, 325);
            this.BoxPrice_TextBox.Margin = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.BoxPrice_TextBox.Name = "BoxPrice_TextBox";
            this.BoxPrice_TextBox.PasswordChar = '\0';
            this.BoxPrice_TextBox.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.BoxPrice_TextBox.PlaceholderText = "";
            this.BoxPrice_TextBox.SelectedText = "";
            this.BoxPrice_TextBox.ShadowDecoration.Parent = this.BoxPrice_TextBox;
            this.BoxPrice_TextBox.Size = new System.Drawing.Size(607, 62);
            this.BoxPrice_TextBox.TabIndex = 4;
            this.BoxPrice_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BoxPrice_TextBox.Enter += new System.EventHandler(this.BoxPrice_TextBox_Enter);
            this.BoxPrice_TextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.key_down_function);
            this.BoxPrice_TextBox.Leave += new System.EventHandler(this.BoxPrice_TextBox_Leave);
            // 
            // Quantity_TextBox
            // 
            this.Quantity_TextBox.Animated = true;
            this.Quantity_TextBox.BorderColor = System.Drawing.Color.Silver;
            this.Quantity_TextBox.BorderRadius = 15;
            this.Quantity_TextBox.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.Quantity_TextBox.BorderThickness = 2;
            this.Quantity_TextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Quantity_TextBox.DefaultText = "ادخل الكميه";
            this.Quantity_TextBox.DisabledState.BorderColor = System.Drawing.Color.Silver;
            this.Quantity_TextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Quantity_TextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Quantity_TextBox.DisabledState.Parent = this.Quantity_TextBox;
            this.Quantity_TextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Quantity_TextBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.Quantity_TextBox.FocusedState.BorderColor = System.Drawing.Color.Red;
            this.Quantity_TextBox.FocusedState.Parent = this.Quantity_TextBox;
            this.Quantity_TextBox.Font = new System.Drawing.Font("Segoe UI", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Quantity_TextBox.ForeColor = System.Drawing.Color.White;
            this.Quantity_TextBox.HoverState.BorderColor = System.Drawing.Color.Red;
            this.Quantity_TextBox.HoverState.Parent = this.Quantity_TextBox;
            this.Quantity_TextBox.IconLeft = ((System.Drawing.Image)(resources.GetObject("Quantity_TextBox.IconLeft")));
            this.Quantity_TextBox.IconLeftSize = new System.Drawing.Size(35, 35);
            this.Quantity_TextBox.Location = new System.Drawing.Point(93, 407);
            this.Quantity_TextBox.Margin = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.Quantity_TextBox.Name = "Quantity_TextBox";
            this.Quantity_TextBox.PasswordChar = '\0';
            this.Quantity_TextBox.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.Quantity_TextBox.PlaceholderText = "";
            this.Quantity_TextBox.SelectedText = "";
            this.Quantity_TextBox.ShadowDecoration.Parent = this.Quantity_TextBox;
            this.Quantity_TextBox.Size = new System.Drawing.Size(607, 62);
            this.Quantity_TextBox.TabIndex = 5;
            this.Quantity_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Quantity_TextBox.Enter += new System.EventHandler(this.Quantity_TextBox_Enter);
            this.Quantity_TextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.key_down_function);
            this.Quantity_TextBox.Leave += new System.EventHandler(this.Quantity_TextBox_Leave);
            // 
            // Code_TextBox
            // 
            this.Code_TextBox.Animated = true;
            this.Code_TextBox.BorderColor = System.Drawing.Color.Silver;
            this.Code_TextBox.BorderRadius = 15;
            this.Code_TextBox.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.Code_TextBox.BorderThickness = 2;
            this.Code_TextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Code_TextBox.DefaultText = "ادخل كود المنتج";
            this.Code_TextBox.DisabledState.BorderColor = System.Drawing.Color.Silver;
            this.Code_TextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Code_TextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Code_TextBox.DisabledState.Parent = this.Code_TextBox;
            this.Code_TextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Code_TextBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.Code_TextBox.FocusedState.BorderColor = System.Drawing.Color.Red;
            this.Code_TextBox.FocusedState.Parent = this.Code_TextBox;
            this.Code_TextBox.Font = new System.Drawing.Font("Segoe UI", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Code_TextBox.ForeColor = System.Drawing.Color.White;
            this.Code_TextBox.HoverState.BorderColor = System.Drawing.Color.Red;
            this.Code_TextBox.HoverState.Parent = this.Code_TextBox;
            this.Code_TextBox.IconLeft = ((System.Drawing.Image)(resources.GetObject("Code_TextBox.IconLeft")));
            this.Code_TextBox.IconLeftSize = new System.Drawing.Size(35, 35);
            this.Code_TextBox.Location = new System.Drawing.Point(93, 173);
            this.Code_TextBox.Margin = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.Code_TextBox.Name = "Code_TextBox";
            this.Code_TextBox.PasswordChar = '\0';
            this.Code_TextBox.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.Code_TextBox.PlaceholderText = "";
            this.Code_TextBox.SelectedText = "";
            this.Code_TextBox.ShadowDecoration.Parent = this.Code_TextBox;
            this.Code_TextBox.Size = new System.Drawing.Size(607, 62);
            this.Code_TextBox.TabIndex = 2;
            this.Code_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Code_TextBox.Enter += new System.EventHandler(this.Code_TextBox_Enter);
            this.Code_TextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.key_down_function);
            this.Code_TextBox.Leave += new System.EventHandler(this.Code_TextBox_Leave);
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
            this.Cat_Combobox.Location = new System.Drawing.Point(752, 299);
            this.Cat_Combobox.MaxDropDownItems = 15;
            this.Cat_Combobox.Name = "Cat_Combobox";
            this.Cat_Combobox.ShadowDecoration.Parent = this.Cat_Combobox;
            this.Cat_Combobox.Size = new System.Drawing.Size(415, 36);
            this.Cat_Combobox.TabIndex = 21;
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.AutoSize = false;
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Segoe UI", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(799, 221);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(415, 48);
            this.guna2HtmlLabel3.TabIndex = 20;
            this.guna2HtmlLabel3.Text = "القائمه من الصنف اسم اختر";
            // 
            // Products_Add_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(1257, 620);
            this.Controls.Add(this.Cat_Combobox);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.Code_TextBox);
            this.Controls.Add(this.Quantity_TextBox);
            this.Controls.Add(this.BoxPrice_TextBox);
            this.Controls.Add(this.UnitPrice_TextBox);
            this.Controls.Add(this.Insert_Button);
            this.Controls.Add(this.Product_TextBox);
            this.Controls.Add(this.Header_Panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Products_Add_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Product";
            this.Load += new System.EventHandler(this.Products_Add_Form_Load);
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
        private Guna.UI2.WinForms.Guna2TextBox Product_TextBox;
        private Guna.UI2.WinForms.Guna2GradientButton Insert_Button;
        private Guna.UI2.WinForms.Guna2TextBox Quantity_TextBox;
        private Guna.UI2.WinForms.Guna2TextBox BoxPrice_TextBox;
        private Guna.UI2.WinForms.Guna2TextBox UnitPrice_TextBox;
        private Guna.UI2.WinForms.Guna2TextBox Code_TextBox;
        private Guna.UI2.WinForms.Guna2ImageButton Refresh_Button;
        private Guna.UI2.WinForms.Guna2ComboBox Cat_Combobox;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
    }
}