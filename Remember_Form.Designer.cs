namespace MN_Lightining_Shop_Management_System
{
    partial class Remember_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Remember_Form));
            this.Side_Panel = new System.Windows.Forms.Panel();
            this.Header_Panel = new System.Windows.Forms.Panel();
            this.Form_Elipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Panel_Drag = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.Name_TextBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Code_TextBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Remeber_Button = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Form_Animation = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.Close_Button = new Bunifu.Framework.UI.BunifuImageButton();
            this.Back_Button = new Bunifu.Framework.UI.BunifuImageButton();
            this.Minimization_Button = new Bunifu.Framework.UI.BunifuImageButton();
            this.Header_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Close_Button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Back_Button)).BeginInit();
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
            this.Side_Panel.TabIndex = 2;
            // 
            // Header_Panel
            // 
            this.Header_Panel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Header_Panel.BackgroundImage")));
            this.Header_Panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Header_Panel.Controls.Add(this.Back_Button);
            this.Header_Panel.Controls.Add(this.Minimization_Button);
            this.Header_Panel.Controls.Add(this.Close_Button);
            this.Header_Panel.Location = new System.Drawing.Point(-14, 0);
            this.Header_Panel.Name = "Header_Panel";
            this.Header_Panel.Size = new System.Drawing.Size(1382, 97);
            this.Header_Panel.TabIndex = 9;
            // 
            // Form_Elipse
            // 
            this.Form_Elipse.ElipseRadius = 100;
            this.Form_Elipse.TargetControl = this;
            // 
            // Panel_Drag
            // 
            this.Panel_Drag.Fixed = true;
            this.Panel_Drag.Horizontal = true;
            this.Panel_Drag.TargetControl = this.Header_Panel;
            this.Panel_Drag.Vertical = true;
            // 
            // Name_TextBox
            // 
            this.Name_TextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Name_TextBox.Font = new System.Drawing.Font("Microsoft New Tai Lue", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Name_TextBox.ForeColor = System.Drawing.Color.White;
            this.Name_TextBox.HintForeColor = System.Drawing.Color.White;
            this.Name_TextBox.HintText = "";
            this.Name_TextBox.isPassword = false;
            this.Name_TextBox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(117)))), ((int)(((byte)(188)))));
            this.Name_TextBox.LineIdleColor = System.Drawing.SystemColors.GrayText;
            this.Name_TextBox.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(117)))), ((int)(((byte)(188)))));
            this.Name_TextBox.LineThickness = 5;
            this.Name_TextBox.Location = new System.Drawing.Point(697, 189);
            this.Name_TextBox.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.Name_TextBox.Name = "Name_TextBox";
            this.Name_TextBox.Size = new System.Drawing.Size(493, 68);
            this.Name_TextBox.TabIndex = 11;
            this.Name_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Name_TextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.key_down_function);
            this.Name_TextBox.Leave += new System.EventHandler(this.Name_TextBox_Leave);
            // 
            // Code_TextBox
            // 
            this.Code_TextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Code_TextBox.Font = new System.Drawing.Font("Microsoft New Tai Lue", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Code_TextBox.ForeColor = System.Drawing.Color.White;
            this.Code_TextBox.HintForeColor = System.Drawing.Color.White;
            this.Code_TextBox.HintText = "";
            this.Code_TextBox.isPassword = true;
            this.Code_TextBox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(117)))), ((int)(((byte)(188)))));
            this.Code_TextBox.LineIdleColor = System.Drawing.SystemColors.GrayText;
            this.Code_TextBox.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(117)))), ((int)(((byte)(188)))));
            this.Code_TextBox.LineThickness = 5;
            this.Code_TextBox.Location = new System.Drawing.Point(697, 444);
            this.Code_TextBox.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.Code_TextBox.Name = "Code_TextBox";
            this.Code_TextBox.Size = new System.Drawing.Size(493, 68);
            this.Code_TextBox.TabIndex = 12;
            this.Code_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Code_TextBox.OnValueChanged += new System.EventHandler(this.Code_TextBox_OnValueChanged);
            this.Code_TextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.key_down_function);
            this.Code_TextBox.Leave += new System.EventHandler(this.Code_TextBox_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Lucida Handwriting", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(117)))), ((int)(((byte)(188)))));
            this.label4.Location = new System.Drawing.Point(793, 388);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(304, 40);
            this.label4.TabIndex = 17;
            this.label4.Text = "أدخل كود التحقيق المرفق";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Lucida Handwriting", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(117)))), ((int)(((byte)(188)))));
            this.label3.Location = new System.Drawing.Point(866, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 40);
            this.label3.TabIndex = 16;
            this.label3.Text = "أدخل اسمك ";
            // 
            // Remeber_Button
            // 
            this.Remeber_Button.ActiveBorderThickness = 1;
            this.Remeber_Button.ActiveCornerRadius = 40;
            this.Remeber_Button.ActiveFillColor = System.Drawing.Color.Aqua;
            this.Remeber_Button.ActiveForecolor = System.Drawing.Color.Red;
            this.Remeber_Button.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Remeber_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Remeber_Button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Remeber_Button.BackgroundImage")));
            this.Remeber_Button.ButtonText = "أسترجاع";
            this.Remeber_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Remeber_Button.Font = new System.Drawing.Font("Lucida Handwriting", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Remeber_Button.ForeColor = System.Drawing.Color.White;
            this.Remeber_Button.IdleBorderThickness = 1;
            this.Remeber_Button.IdleCornerRadius = 40;
            this.Remeber_Button.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(117)))), ((int)(((byte)(188)))));
            this.Remeber_Button.IdleForecolor = System.Drawing.Color.White;
            this.Remeber_Button.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Remeber_Button.Location = new System.Drawing.Point(749, 588);
            this.Remeber_Button.Margin = new System.Windows.Forms.Padding(5);
            this.Remeber_Button.Name = "Remeber_Button";
            this.Remeber_Button.Size = new System.Drawing.Size(389, 64);
            this.Remeber_Button.TabIndex = 18;
            this.Remeber_Button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Remeber_Button.Click += new System.EventHandler(this.Remeber_Button_Click);
            // 
            // Form_Animation
            // 
            this.Form_Animation.Interval = 300;
            // 
            // Close_Button
            // 
            this.Close_Button.BackColor = System.Drawing.Color.White;
            this.Close_Button.Image = ((System.Drawing.Image)(resources.GetObject("Close_Button.Image")));
            this.Close_Button.ImageActive = ((System.Drawing.Image)(resources.GetObject("Close_Button.ImageActive")));
            this.Close_Button.Location = new System.Drawing.Point(1306, 31);
            this.Close_Button.Name = "Close_Button";
            this.Close_Button.Size = new System.Drawing.Size(48, 34);
            this.Close_Button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Close_Button.TabIndex = 1;
            this.Close_Button.TabStop = false;
            this.Close_Button.Zoom = 10;
            this.Close_Button.Click += new System.EventHandler(this.Close_Button_Click);
            // 
            // Back_Button
            // 
            this.Back_Button.BackColor = System.Drawing.Color.White;
            this.Back_Button.Image = ((System.Drawing.Image)(resources.GetObject("Back_Button.Image")));
            this.Back_Button.ImageActive = ((System.Drawing.Image)(resources.GetObject("Back_Button.ImageActive")));
            this.Back_Button.Location = new System.Drawing.Point(1251, 31);
            this.Back_Button.Name = "Back_Button";
            this.Back_Button.Size = new System.Drawing.Size(48, 34);
            this.Back_Button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Back_Button.TabIndex = 15;
            this.Back_Button.TabStop = false;
            this.Back_Button.Zoom = 10;
            this.Back_Button.Click += new System.EventHandler(this.Back_Button_Click);
            // 
            // Minimization_Button
            // 
            this.Minimization_Button.BackColor = System.Drawing.Color.White;
            this.Minimization_Button.Image = ((System.Drawing.Image)(resources.GetObject("Minimization_Button.Image")));
            this.Minimization_Button.ImageActive = ((System.Drawing.Image)(resources.GetObject("Minimization_Button.ImageActive")));
            this.Minimization_Button.Location = new System.Drawing.Point(1196, 31);
            this.Minimization_Button.Name = "Minimization_Button";
            this.Minimization_Button.Size = new System.Drawing.Size(48, 34);
            this.Minimization_Button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Minimization_Button.TabIndex = 2;
            this.Minimization_Button.TabStop = false;
            this.Minimization_Button.Zoom = 10;
            this.Minimization_Button.Click += new System.EventHandler(this.Minimization_Button_Click);
            // 
            // Remember_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(1366, 700);
            this.Controls.Add(this.Remeber_Button);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Name_TextBox);
            this.Controls.Add(this.Code_TextBox);
            this.Controls.Add(this.Header_Panel);
            this.Controls.Add(this.Side_Panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Remember_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Account Recover";
            this.Load += new System.EventHandler(this.Remember_Form_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.key_down_function);
            this.Header_Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Close_Button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Back_Button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimization_Button)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Side_Panel;
        private System.Windows.Forms.Panel Header_Panel;
        private Bunifu.Framework.UI.BunifuElipse Form_Elipse;
        private Bunifu.Framework.UI.BunifuDragControl Panel_Drag;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Name_TextBox;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Code_TextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuThinButton2 Remeber_Button;
        private Guna.UI2.WinForms.Guna2AnimateWindow Form_Animation;
        private Bunifu.Framework.UI.BunifuImageButton Back_Button;
        private Bunifu.Framework.UI.BunifuImageButton Minimization_Button;
        private Bunifu.Framework.UI.BunifuImageButton Close_Button;
    }
}