namespace MN_Lightining_Shop_Management_System
{
    partial class SetReportsWord_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SetReportsWord_Form));
            this.Side_Panel = new System.Windows.Forms.Panel();
            this.Form_Elipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Form_Animation = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.Header_Panel = new Guna.UI2.WinForms.Guna2Panel();
            this.Minimization_Button = new Bunifu.Framework.UI.BunifuImageButton();
            this.Close_Button = new Bunifu.Framework.UI.BunifuImageButton();
            this.ShowWord_Button = new Guna.UI2.WinForms.Guna2ImageButton();
            this.Word_TextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.Confirm_Button = new Guna.UI2.WinForms.Guna2GradientButton();
            this.Header_Drag = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.Header_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Minimization_Button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Close_Button)).BeginInit();
            this.SuspendLayout();
            // 
            // Side_Panel
            // 
            this.Side_Panel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Side_Panel.BackgroundImage")));
            this.Side_Panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Side_Panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.Side_Panel.Location = new System.Drawing.Point(0, 0);
            this.Side_Panel.Name = "Side_Panel";
            this.Side_Panel.Size = new System.Drawing.Size(522, 700);
            this.Side_Panel.TabIndex = 22;
            // 
            // Form_Elipse
            // 
            this.Form_Elipse.ElipseRadius = 100;
            this.Form_Elipse.TargetControl = this;
            // 
            // Form_Animation
            // 
            this.Form_Animation.Interval = 300;
            // 
            // Header_Panel
            // 
            this.Header_Panel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Header_Panel.BackgroundImage")));
            this.Header_Panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Header_Panel.Controls.Add(this.Minimization_Button);
            this.Header_Panel.Controls.Add(this.Close_Button);
            this.Header_Panel.Location = new System.Drawing.Point(-14, 0);
            this.Header_Panel.Name = "Header_Panel";
            this.Header_Panel.ShadowDecoration.Parent = this.Header_Panel;
            this.Header_Panel.Size = new System.Drawing.Size(1382, 97);
            this.Header_Panel.TabIndex = 23;
            // 
            // Minimization_Button
            // 
            this.Minimization_Button.BackColor = System.Drawing.Color.White;
            this.Minimization_Button.Image = ((System.Drawing.Image)(resources.GetObject("Minimization_Button.Image")));
            this.Minimization_Button.ImageActive = ((System.Drawing.Image)(resources.GetObject("Minimization_Button.ImageActive")));
            this.Minimization_Button.Location = new System.Drawing.Point(1250, 32);
            this.Minimization_Button.Name = "Minimization_Button";
            this.Minimization_Button.Size = new System.Drawing.Size(48, 34);
            this.Minimization_Button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Minimization_Button.TabIndex = 4;
            this.Minimization_Button.TabStop = false;
            this.Minimization_Button.Zoom = 10;
            this.Minimization_Button.Click += new System.EventHandler(this.Minimization_Button_Click);
            // 
            // Close_Button
            // 
            this.Close_Button.BackColor = System.Drawing.Color.White;
            this.Close_Button.Image = ((System.Drawing.Image)(resources.GetObject("Close_Button.Image")));
            this.Close_Button.ImageActive = ((System.Drawing.Image)(resources.GetObject("Close_Button.ImageActive")));
            this.Close_Button.Location = new System.Drawing.Point(1305, 32);
            this.Close_Button.Name = "Close_Button";
            this.Close_Button.Size = new System.Drawing.Size(48, 34);
            this.Close_Button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Close_Button.TabIndex = 3;
            this.Close_Button.TabStop = false;
            this.Close_Button.Zoom = 10;
            this.Close_Button.Click += new System.EventHandler(this.Close_Button_Click);
            // 
            // ShowWord_Button
            // 
            this.ShowWord_Button.CheckedState.Parent = this.ShowWord_Button;
            this.ShowWord_Button.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("ShowWord_Button.HoverState.Image")));
            this.ShowWord_Button.HoverState.ImageSize = new System.Drawing.Size(32, 32);
            this.ShowWord_Button.HoverState.Parent = this.ShowWord_Button;
            this.ShowWord_Button.Image = ((System.Drawing.Image)(resources.GetObject("ShowWord_Button.Image")));
            this.ShowWord_Button.ImageSize = new System.Drawing.Size(32, 32);
            this.ShowWord_Button.Location = new System.Drawing.Point(1243, 304);
            this.ShowWord_Button.Name = "ShowWord_Button";
            this.ShowWord_Button.PressedState.Parent = this.ShowWord_Button;
            this.ShowWord_Button.Size = new System.Drawing.Size(37, 50);
            this.ShowWord_Button.TabIndex = 32;
            this.ShowWord_Button.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ShowWord_Button_MouseDown);
            this.ShowWord_Button.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ShowWord_Button_MouseUp);
            // 
            // Word_TextBox
            // 
            this.Word_TextBox.Animated = true;
            this.Word_TextBox.BorderColor = System.Drawing.Color.Silver;
            this.Word_TextBox.BorderRadius = 15;
            this.Word_TextBox.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.Word_TextBox.BorderThickness = 2;
            this.Word_TextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Word_TextBox.DefaultText = "أدخل كلمة التقارير السريه";
            this.Word_TextBox.DisabledState.BorderColor = System.Drawing.Color.Silver;
            this.Word_TextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Word_TextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Word_TextBox.DisabledState.Parent = this.Word_TextBox;
            this.Word_TextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Word_TextBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Word_TextBox.FocusedState.BorderColor = System.Drawing.Color.Red;
            this.Word_TextBox.FocusedState.Parent = this.Word_TextBox;
            this.Word_TextBox.Font = new System.Drawing.Font("Segoe UI", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Word_TextBox.ForeColor = System.Drawing.Color.White;
            this.Word_TextBox.HoverState.BorderColor = System.Drawing.Color.Red;
            this.Word_TextBox.HoverState.Parent = this.Word_TextBox;
            this.Word_TextBox.IconLeft = ((System.Drawing.Image)(resources.GetObject("Word_TextBox.IconLeft")));
            this.Word_TextBox.IconLeftSize = new System.Drawing.Size(30, 30);
            this.Word_TextBox.Location = new System.Drawing.Point(633, 297);
            this.Word_TextBox.Margin = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.Word_TextBox.Name = "Word_TextBox";
            this.Word_TextBox.PasswordChar = '\0';
            this.Word_TextBox.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.Word_TextBox.PlaceholderText = "";
            this.Word_TextBox.SelectedText = "";
            this.Word_TextBox.ShadowDecoration.Parent = this.Word_TextBox;
            this.Word_TextBox.Size = new System.Drawing.Size(589, 62);
            this.Word_TextBox.TabIndex = 31;
            this.Word_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Word_TextBox.Enter += new System.EventHandler(this.Word_TextBox_Enter);
            this.Word_TextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.key_down_function);
            this.Word_TextBox.Leave += new System.EventHandler(this.Word_TextBox_Leave);
            // 
            // Confirm_Button
            // 
            this.Confirm_Button.Animated = true;
            this.Confirm_Button.AutoRoundedCorners = true;
            this.Confirm_Button.BorderRadius = 32;
            this.Confirm_Button.CheckedState.Parent = this.Confirm_Button;
            this.Confirm_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Confirm_Button.CustomImages.Parent = this.Confirm_Button;
            this.Confirm_Button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(117)))), ((int)(((byte)(188)))));
            this.Confirm_Button.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Confirm_Button.Font = new System.Drawing.Font("Segoe UI", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Confirm_Button.ForeColor = System.Drawing.Color.White;
            this.Confirm_Button.HoverState.Parent = this.Confirm_Button;
            this.Confirm_Button.Location = new System.Drawing.Point(610, 475);
            this.Confirm_Button.Name = "Confirm_Button";
            this.Confirm_Button.PressedColor = System.Drawing.Color.Maroon;
            this.Confirm_Button.PressedDepth = 150;
            this.Confirm_Button.ShadowDecoration.BorderRadius = 26;
            this.Confirm_Button.ShadowDecoration.Parent = this.Confirm_Button;
            this.Confirm_Button.Size = new System.Drawing.Size(633, 67);
            this.Confirm_Button.TabIndex = 33;
            this.Confirm_Button.Text = "تاكيد";
            this.Confirm_Button.Click += new System.EventHandler(this.Confirm_Button_Click);
            // 
            // Header_Drag
            // 
            this.Header_Drag.Fixed = true;
            this.Header_Drag.Horizontal = true;
            this.Header_Drag.TargetControl = this.Header_Panel;
            this.Header_Drag.Vertical = true;
            // 
            // SetReportsWord_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(1366, 700);
            this.Controls.Add(this.Confirm_Button);
            this.Controls.Add(this.ShowWord_Button);
            this.Controls.Add(this.Word_TextBox);
            this.Controls.Add(this.Header_Panel);
            this.Controls.Add(this.Side_Panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SetReportsWord_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Set Reports Word";
            this.Load += new System.EventHandler(this.SetReportsWord_Form_Load);
            this.Header_Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Minimization_Button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Close_Button)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Side_Panel;
        private Bunifu.Framework.UI.BunifuElipse Form_Elipse;
        private Guna.UI2.WinForms.Guna2AnimateWindow Form_Animation;
        private Guna.UI2.WinForms.Guna2Panel Header_Panel;
        private Bunifu.Framework.UI.BunifuImageButton Minimization_Button;
        private Bunifu.Framework.UI.BunifuImageButton Close_Button;
        private Guna.UI2.WinForms.Guna2ImageButton ShowWord_Button;
        private Guna.UI2.WinForms.Guna2TextBox Word_TextBox;
        private Guna.UI2.WinForms.Guna2GradientButton Confirm_Button;
        private Bunifu.Framework.UI.BunifuDragControl Header_Drag;
    }
}