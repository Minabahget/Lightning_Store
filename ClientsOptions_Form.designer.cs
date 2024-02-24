namespace MN_Lightining_Shop_Management_System
{
    partial class ClientsOptions_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientsOptions_Form));
            this.Header_Label = new System.Windows.Forms.Label();
            this.Add_Button = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.Delete_Button = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.SuspendLayout();
            // 
            // Header_Label
            // 
            this.Header_Label.AutoSize = true;
            this.Header_Label.Font = new System.Drawing.Font("Maiandra GD", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Header_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Header_Label.Location = new System.Drawing.Point(370, 96);
            this.Header_Label.Name = "Header_Label";
            this.Header_Label.Size = new System.Drawing.Size(256, 52);
            this.Header_Label.TabIndex = 6;
            this.Header_Label.Text = "عمليات المخزن";
            // 
            // Add_Button
            // 
            this.Add_Button.Animated = true;
            this.Add_Button.BorderRadius = 40;
            this.Add_Button.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.Add_Button.CheckedState.Parent = this.Add_Button;
            this.Add_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Add_Button.CustomImages.Parent = this.Add_Button;
            this.Add_Button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.Add_Button.FillColor2 = System.Drawing.Color.DodgerBlue;
            this.Add_Button.Font = new System.Drawing.Font("Segoe UI", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_Button.ForeColor = System.Drawing.Color.White;
            this.Add_Button.HoverState.Parent = this.Add_Button;
            this.Add_Button.Image = ((System.Drawing.Image)(resources.GetObject("Add_Button.Image")));
            this.Add_Button.ImageSize = new System.Drawing.Size(45, 40);
            this.Add_Button.Location = new System.Drawing.Point(602, 195);
            this.Add_Button.Name = "Add_Button";
            this.Add_Button.PressedColor = System.Drawing.SystemColors.ActiveCaption;
            this.Add_Button.PressedDepth = 60;
            this.Add_Button.ShadowDecoration.Parent = this.Add_Button;
            this.Add_Button.Size = new System.Drawing.Size(310, 117);
            this.Add_Button.TabIndex = 8;
            this.Add_Button.Text = "البحث عن منتج";
            this.Add_Button.Click += new System.EventHandler(this.Add_Button_Click);
            // 
            // Delete_Button
            // 
            this.Delete_Button.Animated = true;
            this.Delete_Button.BorderRadius = 40;
            this.Delete_Button.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.Delete_Button.CheckedState.Parent = this.Delete_Button;
            this.Delete_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Delete_Button.CustomImages.Parent = this.Delete_Button;
            this.Delete_Button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.Delete_Button.FillColor2 = System.Drawing.Color.DodgerBlue;
            this.Delete_Button.Font = new System.Drawing.Font("Segoe UI", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete_Button.ForeColor = System.Drawing.Color.White;
            this.Delete_Button.HoverState.Parent = this.Delete_Button;
            this.Delete_Button.Image = ((System.Drawing.Image)(resources.GetObject("Delete_Button.Image")));
            this.Delete_Button.ImageSize = new System.Drawing.Size(45, 40);
            this.Delete_Button.Location = new System.Drawing.Point(103, 195);
            this.Delete_Button.Name = "Delete_Button";
            this.Delete_Button.PressedColor = System.Drawing.SystemColors.ActiveCaption;
            this.Delete_Button.PressedDepth = 60;
            this.Delete_Button.ShadowDecoration.Parent = this.Delete_Button;
            this.Delete_Button.Size = new System.Drawing.Size(310, 117);
            this.Delete_Button.TabIndex = 9;
            this.Delete_Button.Text = "تقرير المنتجات";
            this.Delete_Button.Click += new System.EventHandler(this.Delete_Button_Click);
            // 
            // Inventory_Options_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(1015, 431);
            this.Controls.Add(this.Delete_Button);
            this.Controls.Add(this.Add_Button);
            this.Controls.Add(this.Header_Label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Inventory_Options_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Categories Options";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Header_Label;
        private Guna.UI2.WinForms.Guna2GradientTileButton Add_Button;
        private Guna.UI2.WinForms.Guna2GradientTileButton Delete_Button;
    }
}