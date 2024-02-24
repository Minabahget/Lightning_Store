namespace MN_Lightining_Shop_Management_System
{
    partial class Categories_Add_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Categories_Add_Form));
            this.Controls_Elipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Header_Panel = new System.Windows.Forms.Panel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Down_Button = new Guna.UI2.WinForms.Guna2ImageButton();
            this.Close_Button = new Guna.UI2.WinForms.Guna2ImageButton();
            this.Header_Drag = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.Category_TextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.Form_Animation = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.Insert_Button = new Guna.UI2.WinForms.Guna2GradientButton();
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
            // Category_TextBox
            // 
            this.Category_TextBox.Animated = true;
            this.Category_TextBox.BorderColor = System.Drawing.Color.Silver;
            this.Category_TextBox.BorderRadius = 15;
            this.Category_TextBox.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.Category_TextBox.BorderThickness = 2;
            this.Category_TextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Category_TextBox.DefaultText = "ادخل اسم الصنف";
            this.Category_TextBox.DisabledState.BorderColor = System.Drawing.Color.Silver;
            this.Category_TextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Category_TextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Category_TextBox.DisabledState.Parent = this.Category_TextBox;
            this.Category_TextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Category_TextBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.Category_TextBox.FocusedState.BorderColor = System.Drawing.Color.Red;
            this.Category_TextBox.FocusedState.Parent = this.Category_TextBox;
            this.Category_TextBox.Font = new System.Drawing.Font("Segoe UI", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Category_TextBox.ForeColor = System.Drawing.Color.White;
            this.Category_TextBox.HoverState.BorderColor = System.Drawing.Color.Red;
            this.Category_TextBox.HoverState.Parent = this.Category_TextBox;
            this.Category_TextBox.IconLeft = ((System.Drawing.Image)(resources.GetObject("Category_TextBox.IconLeft")));
            this.Category_TextBox.IconLeftSize = new System.Drawing.Size(35, 35);
            this.Category_TextBox.Location = new System.Drawing.Point(336, 219);
            this.Category_TextBox.Margin = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.Category_TextBox.Name = "Category_TextBox";
            this.Category_TextBox.PasswordChar = '\0';
            this.Category_TextBox.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.Category_TextBox.PlaceholderText = "";
            this.Category_TextBox.SelectedText = "";
            this.Category_TextBox.SelectionStart = 14;
            this.Category_TextBox.ShadowDecoration.Parent = this.Category_TextBox;
            this.Category_TextBox.Size = new System.Drawing.Size(607, 62);
            this.Category_TextBox.TabIndex = 1;
            this.Category_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Category_TextBox.Enter += new System.EventHandler(this.Category_TextBox_Enter);
            this.Category_TextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.key_down_function);
            this.Category_TextBox.Leave += new System.EventHandler(this.Category_TextBox_Leave);
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
            this.Insert_Button.Location = new System.Drawing.Point(441, 336);
            this.Insert_Button.Name = "Insert_Button";
            this.Insert_Button.PressedColor = System.Drawing.SystemColors.ActiveCaption;
            this.Insert_Button.PressedDepth = 60;
            this.Insert_Button.ShadowDecoration.BorderRadius = 30;
            this.Insert_Button.ShadowDecoration.Color = System.Drawing.Color.Maroon;
            this.Insert_Button.ShadowDecoration.Depth = 40;
            this.Insert_Button.ShadowDecoration.Enabled = true;
            this.Insert_Button.ShadowDecoration.Parent = this.Insert_Button;
            this.Insert_Button.Size = new System.Drawing.Size(415, 74);
            this.Insert_Button.TabIndex = 10;
            this.Insert_Button.Text = "اضافة الصنف";
            this.Insert_Button.Click += new System.EventHandler(this.Insert_Button_Click);
            this.Insert_Button.KeyDown += new System.Windows.Forms.KeyEventHandler(this.key_down_function);
            // 
            // Categories_Add_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(1257, 620);
            this.Controls.Add(this.Insert_Button);
            this.Controls.Add(this.Category_TextBox);
            this.Controls.Add(this.Header_Panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Categories_Add_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Category";
            this.Load += new System.EventHandler(this.Categories_Add_Form_Load);
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
        private Guna.UI2.WinForms.Guna2TextBox Category_TextBox;
        private Guna.UI2.WinForms.Guna2GradientButton Insert_Button;
    }
}