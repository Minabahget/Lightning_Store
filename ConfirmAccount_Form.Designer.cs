﻿namespace MN_Lightining_Shop_Management_System
{
    partial class ConfirmAccount_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfirmAccount_Form));
            this.Side_Panel = new System.Windows.Forms.Panel();
            this.Panel_Drag = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.Header_Panel = new System.Windows.Forms.Panel();
            this.Back_Button = new Bunifu.Framework.UI.BunifuImageButton();
            this.Close_Button = new Bunifu.Framework.UI.BunifuImageButton();
            this.Minimization_Button = new Bunifu.Framework.UI.BunifuImageButton();
            this.Form_Elipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Confirm_Button = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Password_Label = new System.Windows.Forms.Label();
            this.UserName_Label = new System.Windows.Forms.Label();
            this.Name_Label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Form_Animation = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.Header_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Back_Button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Close_Button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimization_Button)).BeginInit();
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
            this.Side_Panel.TabIndex = 1;
            // 
            // Panel_Drag
            // 
            this.Panel_Drag.Fixed = true;
            this.Panel_Drag.Horizontal = true;
            this.Panel_Drag.TargetControl = this.Header_Panel;
            this.Panel_Drag.Vertical = true;
            // 
            // Header_Panel
            // 
            this.Header_Panel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Header_Panel.BackgroundImage")));
            this.Header_Panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Header_Panel.Controls.Add(this.Back_Button);
            this.Header_Panel.Controls.Add(this.Close_Button);
            this.Header_Panel.Controls.Add(this.Minimization_Button);
            this.Header_Panel.Location = new System.Drawing.Point(-14, 0);
            this.Header_Panel.Name = "Header_Panel";
            this.Header_Panel.Size = new System.Drawing.Size(1382, 97);
            this.Header_Panel.TabIndex = 22;
            // 
            // Back_Button
            // 
            this.Back_Button.BackColor = System.Drawing.Color.White;
            this.Back_Button.Image = ((System.Drawing.Image)(resources.GetObject("Back_Button.Image")));
            this.Back_Button.ImageActive = ((System.Drawing.Image)(resources.GetObject("Back_Button.ImageActive")));
            this.Back_Button.Location = new System.Drawing.Point(1258, 34);
            this.Back_Button.Name = "Back_Button";
            this.Back_Button.Size = new System.Drawing.Size(48, 34);
            this.Back_Button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Back_Button.TabIndex = 15;
            this.Back_Button.TabStop = false;
            this.Back_Button.Zoom = 10;
            this.Back_Button.Click += new System.EventHandler(this.Back_Button_Click);
            // 
            // Close_Button
            // 
            this.Close_Button.BackColor = System.Drawing.Color.White;
            this.Close_Button.Image = ((System.Drawing.Image)(resources.GetObject("Close_Button.Image")));
            this.Close_Button.ImageActive = ((System.Drawing.Image)(resources.GetObject("Close_Button.ImageActive")));
            this.Close_Button.Location = new System.Drawing.Point(1313, 34);
            this.Close_Button.Name = "Close_Button";
            this.Close_Button.Size = new System.Drawing.Size(48, 34);
            this.Close_Button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Close_Button.TabIndex = 1;
            this.Close_Button.TabStop = false;
            this.Close_Button.Zoom = 10;
            this.Close_Button.Click += new System.EventHandler(this.Close_Button_Click);
            // 
            // Minimization_Button
            // 
            this.Minimization_Button.BackColor = System.Drawing.Color.White;
            this.Minimization_Button.Image = ((System.Drawing.Image)(resources.GetObject("Minimization_Button.Image")));
            this.Minimization_Button.ImageActive = ((System.Drawing.Image)(resources.GetObject("Minimization_Button.ImageActive")));
            this.Minimization_Button.Location = new System.Drawing.Point(1203, 34);
            this.Minimization_Button.Name = "Minimization_Button";
            this.Minimization_Button.Size = new System.Drawing.Size(48, 34);
            this.Minimization_Button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Minimization_Button.TabIndex = 2;
            this.Minimization_Button.TabStop = false;
            this.Minimization_Button.Zoom = 10;
            this.Minimization_Button.Click += new System.EventHandler(this.Minimization_Button_Click);
            // 
            // Form_Elipse
            // 
            this.Form_Elipse.ElipseRadius = 100;
            this.Form_Elipse.TargetControl = this;
            // 
            // Confirm_Button
            // 
            this.Confirm_Button.ActiveBorderThickness = 1;
            this.Confirm_Button.ActiveCornerRadius = 40;
            this.Confirm_Button.ActiveFillColor = System.Drawing.Color.Aqua;
            this.Confirm_Button.ActiveForecolor = System.Drawing.Color.Red;
            this.Confirm_Button.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Confirm_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Confirm_Button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Confirm_Button.BackgroundImage")));
            this.Confirm_Button.ButtonText = "تأكيد المعلومات";
            this.Confirm_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Confirm_Button.Font = new System.Drawing.Font("Lucida Handwriting", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Confirm_Button.ForeColor = System.Drawing.Color.Transparent;
            this.Confirm_Button.IdleBorderThickness = 1;
            this.Confirm_Button.IdleCornerRadius = 40;
            this.Confirm_Button.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(117)))), ((int)(((byte)(188)))));
            this.Confirm_Button.IdleForecolor = System.Drawing.Color.White;
            this.Confirm_Button.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Confirm_Button.Location = new System.Drawing.Point(734, 570);
            this.Confirm_Button.Margin = new System.Windows.Forms.Padding(5);
            this.Confirm_Button.Name = "Confirm_Button";
            this.Confirm_Button.Size = new System.Drawing.Size(389, 64);
            this.Confirm_Button.TabIndex = 31;
            this.Confirm_Button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Confirm_Button.Click += new System.EventHandler(this.Confirm_Button_Click);
            this.Confirm_Button.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Confirm_Button_Click);
            // 
            // Password_Label
            // 
            this.Password_Label.AutoSize = true;
            this.Password_Label.Font = new System.Drawing.Font("Courier New", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Password_Label.ForeColor = System.Drawing.Color.White;
            this.Password_Label.Location = new System.Drawing.Point(623, 441);
            this.Password_Label.Name = "Password_Label";
            this.Password_Label.Size = new System.Drawing.Size(123, 34);
            this.Password_Label.TabIndex = 30;
            this.Password_Label.Text = "label8";
            // 
            // UserName_Label
            // 
            this.UserName_Label.AutoSize = true;
            this.UserName_Label.Font = new System.Drawing.Font("Courier New", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.UserName_Label.ForeColor = System.Drawing.Color.White;
            this.UserName_Label.Location = new System.Drawing.Point(623, 318);
            this.UserName_Label.Name = "UserName_Label";
            this.UserName_Label.Size = new System.Drawing.Size(123, 34);
            this.UserName_Label.TabIndex = 29;
            this.UserName_Label.Text = "label7";
            // 
            // Name_Label
            // 
            this.Name_Label.AutoSize = true;
            this.Name_Label.Font = new System.Drawing.Font("Courier New", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Name_Label.ForeColor = System.Drawing.Color.White;
            this.Name_Label.Location = new System.Drawing.Point(623, 191);
            this.Name_Label.Name = "Name_Label";
            this.Name_Label.Size = new System.Drawing.Size(123, 34);
            this.Name_Label.TabIndex = 28;
            this.Name_Label.Text = "label5";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Lucida Handwriting", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(117)))), ((int)(((byte)(188)))));
            this.label3.Location = new System.Drawing.Point(1091, 313);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 40);
            this.label3.TabIndex = 26;
            this.label3.Text = ": اسم المتسخدم";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Lucida Handwriting", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(117)))), ((int)(((byte)(188)))));
            this.label4.Location = new System.Drawing.Point(1095, 436);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 40);
            this.label4.TabIndex = 27;
            this.label4.Text = ": كلمة المرور";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Lucida Handwriting", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(117)))), ((int)(((byte)(188)))));
            this.label2.Location = new System.Drawing.Point(1139, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 40);
            this.label2.TabIndex = 25;
            this.label2.Text = ": الاسم";
            // 
            // Form_Animation
            // 
            this.Form_Animation.Interval = 300;
            // 
            // ConfirmAccount_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(1366, 700);
            this.Controls.Add(this.Header_Panel);
            this.Controls.Add(this.Side_Panel);
            this.Controls.Add(this.Confirm_Button);
            this.Controls.Add(this.Name_Label);
            this.Controls.Add(this.Password_Label);
            this.Controls.Add(this.UserName_Label);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConfirmAccount_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Confirm Account";
            this.Load += new System.EventHandler(this.ConfirmAccount_Form_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.key_down_function);
            this.Header_Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Back_Button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Close_Button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimization_Button)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Side_Panel;
        private Bunifu.Framework.UI.BunifuDragControl Panel_Drag;
        private Bunifu.Framework.UI.BunifuElipse Form_Elipse;
        private Bunifu.Framework.UI.BunifuThinButton2 Confirm_Button;
        private System.Windows.Forms.Label Name_Label;
        private System.Windows.Forms.Label Password_Label;
        private System.Windows.Forms.Label UserName_Label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel Header_Panel;
        private Bunifu.Framework.UI.BunifuImageButton Back_Button;
        private Bunifu.Framework.UI.BunifuImageButton Minimization_Button;
        private Bunifu.Framework.UI.BunifuImageButton Close_Button;
        private Guna.UI2.WinForms.Guna2AnimateWindow Form_Animation;
    }
}