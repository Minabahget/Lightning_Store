using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Runtime.InteropServices;
using System.Threading;
namespace MN_Lightining_Shop_Management_System
{
    public partial class NewControls_Form : Form
    {
        // create the child form variable 
        Form currentchild_form;
        // make object from the main functions class 
        Main_Functions mf;
        // default constructor
        public NewControls_Form()
        {
            InitializeComponent();
            // make a new reference for the child form 
            currentchild_form = new Form();
            // initialize the object from the main functions form 
            mf = new Main_Functions();
        }

        // this function to handle the child forms in the main form 
        public void childfrom_open(Form childform)
        {

            // if not any of the buttons is checked (means some form is opened) 
            if (Inventory_Button.Checked || Add_Delete_Button.Checked)
                currentchild_form.Close();// close the current form
               
            
            // open the current form by making the current form as the sender form
            currentchild_form = childform;
            // remove the top bar 
            childform.TopLevel = false;
            // remove the border of the form 
            childform.FormBorderStyle = FormBorderStyle.None;
            // make the dock of the form to fill the current panel 
            childform.Dock = DockStyle.Fill;
            // make the child form fill the container 
            Main_Panel.Controls.Add(childform);
            // make the tag to the current child form 
            Main_Panel.Tag = childform;
            // bring the form to the fornt 
            childform.BringToFront();
            // show the child form 
            childform.Show();
            // initialize the object from the main functions form 
            mf = new Main_Functions();
        }

        private void Close_Button_Click(object sender, EventArgs e)
        {
            Application.Exit(); // exit the application
        }

        private void Down_Button_Click(object sender, EventArgs e)
        {
            // when we click the button make the window minimized 
            WindowState = FormWindowState.Minimized;
        }

        private void LogOut_Button_Click(object sender, EventArgs e)
        {
            // loop on the open forms 
            foreach(Form form in Application.OpenForms)
            {
                
                // check if one of the main controls forms is open 
                if(form.Name == "Categories_Add_Form" || form.Name == "Categories_Delete_Form"
                    || form.Name == "Products_Add_Form" || form.Name == "Products_Delete_Form"
                    || form.Name == "InventoryReport_Form" || form.Name == "Inventory_Search_Form")
                {
                    // call this function to handle the alerts 
                    mf.Handle_Alerts("حدث خطا\nاغلق جميع النوافذ اولا", 
                        Main_Functions.AlertType.Information, 80);
                    // exit the function 
                    return;
                }
            }
            // close the current child form 
            currentchild_form.Close();
            // hide the current form 
            this.Hide();
            // make object from the login form 
            LogIn_Form2 lg = new LogIn_Form2();
            // show the login from 
            lg.Show();
        }

        private void Logo_PictureBox_Click(object sender, EventArgs e)
        {
            // close the current child form 
            currentchild_form.Close();
            Add_Delete_Button.Checked = Inventory_Button.Checked = false;
        }

        private void NewControls_Form_Load(object sender, EventArgs e)
        {
            // set the animation of the form to the animator 
            Form_Animation.SetAnimateWindow(this);
            // get the name of the current manager using this function and assign it to the label
            manager_name.Text = Main_Functions.get_name() + " " + manager_name.Text ;
            // make the timer of the form to start for the digital watch 
            Digital_Timer.Start();
        }

        private void Digital_Timer_Tick(object sender, EventArgs e)
        {
            // take the current time in minutes and hours 
            Time_Label.Text = DateTime.Now.ToString("hh:mm tt");
            // take the current time in seconds 
            Seconds_Label.Text = DateTime.Now.ToString("ss");
            // take the current date in format of months name , day, year 
            Date_Label.Text = DateTime.Now.ToString("MMM dd yyyy");
            // take the current day name 
            Day_Label.Text = DateTime.Now.ToString("ddd");
        }


        private void Categories_Button_Click_1(object sender, EventArgs e)
        {
            // we need to open the child form that is the SearchOptions_Form 
            // call this function for this use 
            childfrom_open(new AddDeleteOptions_Form());
        }

        private void Inventory_Button_Click(object sender, EventArgs e)
        {
            // we need to open the child form that is the SearchOptions_Form 
            // call this function for this use 
            childfrom_open(new Inventory_Options_Form());
        }

        private void Clients_Button_Click(object sender, EventArgs e)
        {
            // childfrom_open(new ());
        }
    }
}
