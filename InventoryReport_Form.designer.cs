namespace MN_Lightining_Shop_Management_System
{
    partial class InventoryReport_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventoryReport_Form));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Header_Panel = new System.Windows.Forms.Panel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Down_Button = new Guna.UI2.WinForms.Guna2ImageButton();
            this.Close_Button = new Guna.UI2.WinForms.Guna2ImageButton();
            this.Form_Animation = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.Header_Drag = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.Controls_Elipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.AllTraineesButton_Tip = new Guna.UI2.WinForms.Guna2HtmlToolTip();
            this.InProgressTraineesButton_Tip = new Guna.UI2.WinForms.Guna2HtmlToolTip();
            this.FinishedTraineesButton_Tip = new Guna.UI2.WinForms.Guna2HtmlToolTip();
            this.Report_GridView = new System.Windows.Forms.DataGridView();
            this.Refresh_Button = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.Save_Button = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.Load_Button = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.Cat_Combobox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Code_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Payment_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaymentDate_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FinishedDate_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Header_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Report_GridView)).BeginInit();
            this.SuspendLayout();
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
            this.Header_Panel.Location = new System.Drawing.Point(1, 0);
            this.Header_Panel.Name = "Header_Panel";
            this.Header_Panel.Size = new System.Drawing.Size(1558, 54);
            this.Header_Panel.TabIndex = 3;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.AutoSize = false;
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Segoe UI", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(724, 6);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(446, 45);
            this.guna2HtmlLabel2.TabIndex = 3;
            this.guna2HtmlLabel2.Text = "المنتجات تقرير";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.AutoSize = false;
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(8, 6);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(439, 48);
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
            this.Down_Button.Location = new System.Drawing.Point(1426, 6);
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
            this.Close_Button.Location = new System.Drawing.Point(1483, 6);
            this.Close_Button.Name = "Close_Button";
            this.Close_Button.PressedState.Parent = this.Close_Button;
            this.Close_Button.Size = new System.Drawing.Size(61, 39);
            this.Close_Button.TabIndex = 0;
            this.Close_Button.UseTransparentBackground = true;
            this.Close_Button.Click += new System.EventHandler(this.Close_Button_Click);
            // 
            // Form_Animation
            // 
            this.Form_Animation.AnimationType = Guna.UI2.WinForms.Guna2AnimateWindow.AnimateWindowType.AW_HOR_POSITIVE;
            this.Form_Animation.Interval = 300;
            // 
            // Header_Drag
            // 
            this.Header_Drag.Fixed = true;
            this.Header_Drag.Horizontal = true;
            this.Header_Drag.TargetControl = this.Header_Panel;
            this.Header_Drag.Vertical = true;
            // 
            // Controls_Elipse
            // 
            this.Controls_Elipse.ElipseRadius = 30;
            this.Controls_Elipse.TargetControl = this;
            // 
            // AllTraineesButton_Tip
            // 
            this.AllTraineesButton_Tip.AllowLinksHandling = true;
            this.AllTraineesButton_Tip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.AllTraineesButton_Tip.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.AllTraineesButton_Tip.Font = new System.Drawing.Font("Arial", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.AllTraineesButton_Tip.ForeColor = System.Drawing.Color.White;
            this.AllTraineesButton_Tip.MaximumSize = new System.Drawing.Size(0, 0);
            this.AllTraineesButton_Tip.TitleFont = new System.Drawing.Font("Segoe UI", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllTraineesButton_Tip.TitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.AllTraineesButton_Tip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.AllTraineesButton_Tip.ToolTipTitle = "الأستخدام";
            // 
            // InProgressTraineesButton_Tip
            // 
            this.InProgressTraineesButton_Tip.AllowLinksHandling = true;
            this.InProgressTraineesButton_Tip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.InProgressTraineesButton_Tip.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.InProgressTraineesButton_Tip.Font = new System.Drawing.Font("Arial", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.InProgressTraineesButton_Tip.ForeColor = System.Drawing.Color.White;
            this.InProgressTraineesButton_Tip.MaximumSize = new System.Drawing.Size(0, 0);
            this.InProgressTraineesButton_Tip.TitleFont = new System.Drawing.Font("Segoe UI", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InProgressTraineesButton_Tip.TitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.InProgressTraineesButton_Tip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.InProgressTraineesButton_Tip.ToolTipTitle = "الأستخدام";
            // 
            // FinishedTraineesButton_Tip
            // 
            this.FinishedTraineesButton_Tip.AllowLinksHandling = true;
            this.FinishedTraineesButton_Tip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.FinishedTraineesButton_Tip.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.FinishedTraineesButton_Tip.Font = new System.Drawing.Font("Arial", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FinishedTraineesButton_Tip.ForeColor = System.Drawing.Color.White;
            this.FinishedTraineesButton_Tip.MaximumSize = new System.Drawing.Size(0, 0);
            this.FinishedTraineesButton_Tip.TitleFont = new System.Drawing.Font("Segoe UI", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FinishedTraineesButton_Tip.TitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.FinishedTraineesButton_Tip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.FinishedTraineesButton_Tip.ToolTipTitle = "الأستخدام";
            // 
            // Report_GridView
            // 
            this.Report_GridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.Report_GridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Report_GridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Report_GridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.Report_GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Report_GridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Code_Column,
            this.Payment_Column,
            this.PaymentDate_Column,
            this.FinishedDate_Column});
            this.Report_GridView.EnableHeadersVisualStyles = false;
            this.Report_GridView.Location = new System.Drawing.Point(1, 281);
            this.Report_GridView.Name = "Report_GridView";
            this.Report_GridView.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Report_GridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.Report_GridView.RowHeadersVisible = false;
            this.Report_GridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            this.Report_GridView.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.Report_GridView.RowTemplate.Height = 26;
            this.Report_GridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Report_GridView.Size = new System.Drawing.Size(1727, 717);
            this.Report_GridView.TabIndex = 7;
            // 
            // Refresh_Button
            // 
            this.Refresh_Button.Animated = true;
            this.Refresh_Button.BackColor = System.Drawing.Color.Transparent;
            this.Refresh_Button.BorderRadius = 40;
            this.Refresh_Button.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.Refresh_Button.CheckedState.Parent = this.Refresh_Button;
            this.Refresh_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Refresh_Button.CustomImages.Parent = this.Refresh_Button;
            this.Refresh_Button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.Refresh_Button.FillColor2 = System.Drawing.Color.DarkRed;
            this.Refresh_Button.Font = new System.Drawing.Font("Segoe UI", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Refresh_Button.ForeColor = System.Drawing.Color.White;
            this.Refresh_Button.HoverState.Parent = this.Refresh_Button;
            this.Refresh_Button.Image = ((System.Drawing.Image)(resources.GetObject("Refresh_Button.Image")));
            this.Refresh_Button.ImageSize = new System.Drawing.Size(28, 28);
            this.Refresh_Button.Location = new System.Drawing.Point(289, 81);
            this.Refresh_Button.Name = "Refresh_Button";
            this.Refresh_Button.PressedColor = System.Drawing.SystemColors.ActiveCaption;
            this.Refresh_Button.PressedDepth = 60;
            this.Refresh_Button.ShadowDecoration.BorderRadius = 40;
            this.Refresh_Button.ShadowDecoration.Color = System.Drawing.Color.Maroon;
            this.Refresh_Button.ShadowDecoration.Depth = 40;
            this.Refresh_Button.ShadowDecoration.Enabled = true;
            this.Refresh_Button.ShadowDecoration.Parent = this.Refresh_Button;
            this.Refresh_Button.Size = new System.Drawing.Size(232, 97);
            this.Refresh_Button.TabIndex = 15;
            this.Refresh_Button.Text = "اعادة تحميل";
            this.Refresh_Button.Click += new System.EventHandler(this.Refresh_Button_Click);
            // 
            // Save_Button
            // 
            this.Save_Button.Animated = true;
            this.Save_Button.BackColor = System.Drawing.Color.Transparent;
            this.Save_Button.BorderRadius = 40;
            this.Save_Button.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.Save_Button.CheckedState.Parent = this.Save_Button;
            this.Save_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Save_Button.CustomImages.Parent = this.Save_Button;
            this.Save_Button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.Save_Button.FillColor2 = System.Drawing.Color.DarkRed;
            this.Save_Button.Font = new System.Drawing.Font("Segoe UI", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save_Button.ForeColor = System.Drawing.Color.White;
            this.Save_Button.HoverState.Parent = this.Save_Button;
            this.Save_Button.Image = ((System.Drawing.Image)(resources.GetObject("Save_Button.Image")));
            this.Save_Button.ImageSize = new System.Drawing.Size(30, 30);
            this.Save_Button.Location = new System.Drawing.Point(639, 81);
            this.Save_Button.Name = "Save_Button";
            this.Save_Button.PressedColor = System.Drawing.SystemColors.ActiveCaption;
            this.Save_Button.PressedDepth = 60;
            this.Save_Button.ShadowDecoration.BorderRadius = 40;
            this.Save_Button.ShadowDecoration.Color = System.Drawing.Color.Maroon;
            this.Save_Button.ShadowDecoration.Depth = 40;
            this.Save_Button.ShadowDecoration.Enabled = true;
            this.Save_Button.ShadowDecoration.Parent = this.Save_Button;
            this.Save_Button.Size = new System.Drawing.Size(264, 97);
            this.Save_Button.TabIndex = 22;
            this.Save_Button.Text = "تخزين فى اكسل";
            this.Save_Button.Click += new System.EventHandler(this.Save_Button_Click);
            // 
            // Load_Button
            // 
            this.Load_Button.Animated = true;
            this.Load_Button.BackColor = System.Drawing.Color.Transparent;
            this.Load_Button.BorderRadius = 40;
            this.Load_Button.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.Load_Button.CheckedState.Parent = this.Load_Button;
            this.Load_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Load_Button.CustomImages.Parent = this.Load_Button;
            this.Load_Button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.Load_Button.FillColor2 = System.Drawing.Color.DarkRed;
            this.Load_Button.Font = new System.Drawing.Font("Segoe UI", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Load_Button.ForeColor = System.Drawing.Color.White;
            this.Load_Button.HoverState.Parent = this.Load_Button;
            this.Load_Button.Image = ((System.Drawing.Image)(resources.GetObject("Load_Button.Image")));
            this.Load_Button.ImageSize = new System.Drawing.Size(30, 30);
            this.Load_Button.Location = new System.Drawing.Point(1028, 81);
            this.Load_Button.Name = "Load_Button";
            this.Load_Button.PressedColor = System.Drawing.SystemColors.ActiveCaption;
            this.Load_Button.PressedDepth = 60;
            this.Load_Button.ShadowDecoration.BorderRadius = 40;
            this.Load_Button.ShadowDecoration.Color = System.Drawing.Color.Maroon;
            this.Load_Button.ShadowDecoration.Depth = 40;
            this.Load_Button.ShadowDecoration.Enabled = true;
            this.Load_Button.ShadowDecoration.Parent = this.Load_Button;
            this.Load_Button.Size = new System.Drawing.Size(264, 97);
            this.Load_Button.TabIndex = 23;
            this.Load_Button.Text = "تحميل من اكسل";
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
            this.Cat_Combobox.Location = new System.Drawing.Point(300, 204);
            this.Cat_Combobox.MaxDropDownItems = 15;
            this.Cat_Combobox.Name = "Cat_Combobox";
            this.Cat_Combobox.ShadowDecoration.Parent = this.Cat_Combobox;
            this.Cat_Combobox.Size = new System.Drawing.Size(597, 36);
            this.Cat_Combobox.TabIndex = 24;
            this.Cat_Combobox.SelectedIndexChanged += new System.EventHandler(this.Cat_Combobox_SelectedIndexChanged);
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.AutoSize = false;
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Segoe UI", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(963, 203);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(446, 45);
            this.guna2HtmlLabel3.TabIndex = 4;
            this.guna2HtmlLabel3.Text = "الصنف اسم اختر";
            // 
            // Code_Column
            // 
            this.Code_Column.HeaderText = "الكميه";
            this.Code_Column.Name = "Code_Column";
            this.Code_Column.ReadOnly = true;
            // 
            // Payment_Column
            // 
            this.Payment_Column.HeaderText = "سعر الوحده";
            this.Payment_Column.Name = "Payment_Column";
            this.Payment_Column.ReadOnly = true;
            // 
            // PaymentDate_Column
            // 
            this.PaymentDate_Column.HeaderText = "اسم المنتج";
            this.PaymentDate_Column.Name = "PaymentDate_Column";
            this.PaymentDate_Column.ReadOnly = true;
            this.PaymentDate_Column.Width = 800;
            // 
            // FinishedDate_Column
            // 
            this.FinishedDate_Column.HeaderText = "كود المنتج";
            this.FinishedDate_Column.Name = "FinishedDate_Column";
            this.FinishedDate_Column.ReadOnly = true;
            this.FinishedDate_Column.Width = 120;
            // 
            // InventoryReport_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(1558, 1000);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.Cat_Combobox);
            this.Controls.Add(this.Load_Button);
            this.Controls.Add(this.Save_Button);
            this.Controls.Add(this.Refresh_Button);
            this.Controls.Add(this.Report_GridView);
            this.Controls.Add(this.Header_Panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InventoryReport_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory Report";
            this.Load += new System.EventHandler(this.InventoryReport_Form_Load);
            this.Header_Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Report_GridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Header_Panel;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2ImageButton Down_Button;
        private Guna.UI2.WinForms.Guna2ImageButton Close_Button;
        private Guna.UI2.WinForms.Guna2AnimateWindow Form_Animation;
        private Bunifu.Framework.UI.BunifuDragControl Header_Drag;
        private Bunifu.Framework.UI.BunifuElipse Controls_Elipse;
        private Guna.UI2.WinForms.Guna2HtmlToolTip AllTraineesButton_Tip;
        private Guna.UI2.WinForms.Guna2HtmlToolTip InProgressTraineesButton_Tip;
        private Guna.UI2.WinForms.Guna2HtmlToolTip FinishedTraineesButton_Tip;
        private System.Windows.Forms.DataGridView Report_GridView;
        private Guna.UI2.WinForms.Guna2GradientTileButton Refresh_Button;
        private Guna.UI2.WinForms.Guna2GradientTileButton Save_Button;
        private Guna.UI2.WinForms.Guna2GradientTileButton Load_Button;
        internal Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2ComboBox Cat_Combobox;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Payment_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaymentDate_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn FinishedDate_Column;
    }
}