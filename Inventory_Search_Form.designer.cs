namespace MN_Lightining_Shop_Management_System
{
    partial class Inventory_Search_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inventory_Search_Form));
            this.Controls_Elipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Header_Panel = new System.Windows.Forms.Panel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Down_Button = new Guna.UI2.WinForms.Guna2ImageButton();
            this.Close_Button = new Guna.UI2.WinForms.Guna2ImageButton();
            this.Header_Drag = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.Product_TextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.Form_Animation = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.Search_Button = new Guna.UI2.WinForms.Guna2GradientButton();
            this.QuantityLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.CodeLabel = new System.Windows.Forms.Label();
            this.QuantityDataLabel = new System.Windows.Forms.Label();
            this.NameDataLabel = new System.Windows.Forms.Label();
            this.CodeDataLabel = new System.Windows.Forms.Label();
            this.NameDataLable2 = new System.Windows.Forms.Label();
            this.Prod_ComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
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
            this.guna2HtmlLabel2.Text = "جديد صنف اضافه";
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
            this.Product_TextBox.DefaultText = "ادخل كود المنتج";
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
            this.Product_TextBox.Location = new System.Drawing.Point(443, 77);
            this.Product_TextBox.Margin = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.Product_TextBox.Name = "Product_TextBox";
            this.Product_TextBox.PasswordChar = '\0';
            this.Product_TextBox.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.Product_TextBox.PlaceholderText = "";
            this.Product_TextBox.SelectedText = "";
            this.Product_TextBox.SelectionStart = 15;
            this.Product_TextBox.ShadowDecoration.Parent = this.Product_TextBox;
            this.Product_TextBox.Size = new System.Drawing.Size(318, 62);
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
            // Search_Button
            // 
            this.Search_Button.Animated = true;
            this.Search_Button.BackColor = System.Drawing.Color.Transparent;
            this.Search_Button.BorderRadius = 30;
            this.Search_Button.CheckedState.Parent = this.Search_Button;
            this.Search_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Search_Button.CustomImages.Parent = this.Search_Button;
            this.Search_Button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.Search_Button.FillColor2 = System.Drawing.Color.DarkRed;
            this.Search_Button.Font = new System.Drawing.Font("Segoe UI", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Search_Button.ForeColor = System.Drawing.Color.White;
            this.Search_Button.HoverState.Parent = this.Search_Button;
            this.Search_Button.Location = new System.Drawing.Point(400, 223);
            this.Search_Button.Name = "Search_Button";
            this.Search_Button.PressedColor = System.Drawing.SystemColors.ActiveCaption;
            this.Search_Button.PressedDepth = 60;
            this.Search_Button.ShadowDecoration.BorderRadius = 30;
            this.Search_Button.ShadowDecoration.Color = System.Drawing.Color.Maroon;
            this.Search_Button.ShadowDecoration.Depth = 40;
            this.Search_Button.ShadowDecoration.Enabled = true;
            this.Search_Button.ShadowDecoration.Parent = this.Search_Button;
            this.Search_Button.Size = new System.Drawing.Size(415, 63);
            this.Search_Button.TabIndex = 10;
            this.Search_Button.Text = "بحث";
            this.Search_Button.Click += new System.EventHandler(this.Search_Button_Click);
            this.Search_Button.KeyDown += new System.Windows.Forms.KeyEventHandler(this.key_down_function);
            // 
            // QuantityLabel
            // 
            this.QuantityLabel.AutoSize = true;
            this.QuantityLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.QuantityLabel.Font = new System.Drawing.Font("Lucida Handwriting", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.QuantityLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(117)))), ((int)(((byte)(188)))));
            this.QuantityLabel.Location = new System.Drawing.Point(1013, 515);
            this.QuantityLabel.Name = "QuantityLabel";
            this.QuantityLabel.Size = new System.Drawing.Size(217, 40);
            this.QuantityLabel.TabIndex = 16;
            this.QuantityLabel.Text = ": الكميه الموجوده";
            this.QuantityLabel.Visible = false;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NameLabel.Font = new System.Drawing.Font("Lucida Handwriting", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.NameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(117)))), ((int)(((byte)(188)))));
            this.NameLabel.Location = new System.Drawing.Point(1075, 420);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(96, 40);
            this.NameLabel.TabIndex = 14;
            this.NameLabel.Text = ": الاسم";
            this.NameLabel.Visible = false;
            // 
            // CodeLabel
            // 
            this.CodeLabel.AutoSize = true;
            this.CodeLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CodeLabel.Font = new System.Drawing.Font("Lucida Handwriting", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.CodeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(117)))), ((int)(((byte)(188)))));
            this.CodeLabel.Location = new System.Drawing.Point(1075, 324);
            this.CodeLabel.Name = "CodeLabel";
            this.CodeLabel.Size = new System.Drawing.Size(97, 40);
            this.CodeLabel.TabIndex = 13;
            this.CodeLabel.Text = ": الكود";
            this.CodeLabel.Visible = false;
            // 
            // QuantityDataLabel
            // 
            this.QuantityDataLabel.AutoSize = true;
            this.QuantityDataLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.QuantityDataLabel.Font = new System.Drawing.Font("Lucida Handwriting", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.QuantityDataLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(117)))), ((int)(((byte)(188)))));
            this.QuantityDataLabel.Location = new System.Drawing.Point(30, 515);
            this.QuantityDataLabel.Name = "QuantityDataLabel";
            this.QuantityDataLabel.Size = new System.Drawing.Size(217, 40);
            this.QuantityDataLabel.TabIndex = 19;
            this.QuantityDataLabel.Text = ": الكميه الموجوده";
            this.QuantityDataLabel.Visible = false;
            // 
            // NameDataLabel
            // 
            this.NameDataLabel.AutoSize = true;
            this.NameDataLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NameDataLabel.Font = new System.Drawing.Font("Lucida Handwriting", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.NameDataLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(117)))), ((int)(((byte)(188)))));
            this.NameDataLabel.Location = new System.Drawing.Point(29, 393);
            this.NameDataLabel.Name = "NameDataLabel";
            this.NameDataLabel.Size = new System.Drawing.Size(96, 40);
            this.NameDataLabel.TabIndex = 18;
            this.NameDataLabel.Text = ": الاسم";
            this.NameDataLabel.Visible = false;
            // 
            // CodeDataLabel
            // 
            this.CodeDataLabel.AutoSize = true;
            this.CodeDataLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CodeDataLabel.Font = new System.Drawing.Font("Lucida Handwriting", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.CodeDataLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(117)))), ((int)(((byte)(188)))));
            this.CodeDataLabel.Location = new System.Drawing.Point(29, 324);
            this.CodeDataLabel.Name = "CodeDataLabel";
            this.CodeDataLabel.Size = new System.Drawing.Size(97, 40);
            this.CodeDataLabel.TabIndex = 17;
            this.CodeDataLabel.Text = ": الكود";
            this.CodeDataLabel.Visible = false;
            // 
            // NameDataLable2
            // 
            this.NameDataLable2.AutoSize = true;
            this.NameDataLable2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NameDataLable2.Font = new System.Drawing.Font("Lucida Handwriting", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.NameDataLable2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(117)))), ((int)(((byte)(188)))));
            this.NameDataLable2.Location = new System.Drawing.Point(30, 451);
            this.NameDataLable2.Name = "NameDataLable2";
            this.NameDataLable2.Size = new System.Drawing.Size(96, 40);
            this.NameDataLable2.TabIndex = 20;
            this.NameDataLable2.Text = ": الاسم";
            this.NameDataLable2.Visible = false;
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
            this.Prod_ComboBox.Location = new System.Drawing.Point(4, 164);
            this.Prod_ComboBox.MaxDropDownItems = 15;
            this.Prod_ComboBox.Name = "Prod_ComboBox";
            this.Prod_ComboBox.ShadowDecoration.Parent = this.Prod_ComboBox;
            this.Prod_ComboBox.Size = new System.Drawing.Size(1249, 36);
            this.Prod_ComboBox.TabIndex = 23;
            this.Prod_ComboBox.SelectedIndexChanged += new System.EventHandler(this.Prod_ComboBox_SelectedIndexChanged);
            // 
            // Inventory_Search_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(1257, 620);
            this.Controls.Add(this.Prod_ComboBox);
            this.Controls.Add(this.NameDataLable2);
            this.Controls.Add(this.QuantityDataLabel);
            this.Controls.Add(this.NameDataLabel);
            this.Controls.Add(this.CodeDataLabel);
            this.Controls.Add(this.QuantityLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.CodeLabel);
            this.Controls.Add(this.Search_Button);
            this.Controls.Add(this.Product_TextBox);
            this.Controls.Add(this.Header_Panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Inventory_Search_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Category";
            this.Load += new System.EventHandler(this.Inventory_Search_Form_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.key_down_function);
            this.Header_Panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private Guna.UI2.WinForms.Guna2GradientButton Search_Button;
        private System.Windows.Forms.Label QuantityLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label CodeLabel;
        private System.Windows.Forms.Label QuantityDataLabel;
        private System.Windows.Forms.Label NameDataLabel;
        private System.Windows.Forms.Label CodeDataLabel;
        private System.Windows.Forms.Label NameDataLable2;
        private Guna.UI2.WinForms.Guna2ComboBox Prod_ComboBox;
    }
}