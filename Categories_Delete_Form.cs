using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using Guna.UI2.WinForms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;
namespace MN_Lightining_Shop_Management_System
{
    public partial class Categories_Delete_Form : Form
    {
        Main_Functions mf;
        public Categories_Delete_Form()
        {
            InitializeComponent();
            mf = new Main_Functions();
        }



        private string Get_Cat_ID_Exists(string cat_name)
        {
            string cat_id = "";
            SqlConnection con = mf.get_connection();

            SqlCommand cmd = new SqlCommand("SELECT CAT_ID FROM CATEGORIES WHERE CAT_NAME = @n", con);
            cmd.Parameters.AddWithValue("@n", cat_name);
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            cat_id = dr[0].ToString();
            dr.Close();
            con.Close();
            return cat_id;
        }


        private void Delete_Productst(string cat_id)
        {
            SqlConnection con = mf.get_connection();
            SqlCommand cmd = new SqlCommand("DELETE FROM PRODUCTS WHERE CAT_ID = @cid", con);
            cmd.Parameters.AddWithValue("@cid", cat_id);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void Load_Categories()
        {
            SqlConnection con = mf.get_connection();

            SqlCommand cmd = new SqlCommand("SELECT Cat_Name FROM Categories;", con);

            SqlDataReader dr = cmd.ExecuteReader(); 
            if(!dr.HasRows)
            {
                Alert_Form af = new Alert_Form("خطا فى التحميل\nلا يوجد اصناف للمسح",
                   Main_Functions.AlertType.Information, 80);
                // make the form on the top always 
                af.TopMost = true;
                // show the alert form 
                af.Show();

                dr.Close();
                con.Close();
                

                Delete_Button.Enabled = Cat_Combobox.Enabled = false;

                Cat_Combobox.Items.Clear();

                return;
            }

            string last_cat = "";
            int i = 0;
            Cat_Combobox.Items.Clear();
            while (dr.Read())// while we read the years
            {
                // add the years to the combo box 
                Cat_Combobox.Items.Add(dr[0].ToString());
                if (i == 0)
                {
                    last_cat = dr[0].ToString(); // assign the new year in the variable to get the last year
                    ++i;
                }
            }
            // now we make the last year the default value in the combo box 
            Cat_Combobox.SelectedIndex = Cat_Combobox.Items.IndexOf(last_cat);
            Delete_Button.Enabled = Cat_Combobox.Enabled = true;

            dr.Close();
            con.Close(); 
        }


        private void Close_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Down_Button_Click(object sender, EventArgs e)
        {
            this.WindowState =  FormWindowState.Minimized;
        }


        // this fucntion for the key down enter for all controls 
        private void key_down_function(object sender, KeyEventArgs e)
        {
            // this event to indicate if the button is pressed down or not 
            // the enter key  
            if (e.KeyValue == (char)Keys.Enter)// call the button click event
                Delete_Button_Click(sender, e);
        }


        private void Categories_Delete_Form_Load(object sender, EventArgs e)
        {
            // set the animation of the form using the animator 
            Form_Animation.SetAnimateWindow(this);

            // call this function to add all categories to the combo box
            Load_Categories();
        }

        private void Refresh_Button_Click(object sender, EventArgs e)
        {
            Categories_Delete_Form_Load(sender, e);
        }

        private void Delete_Button_Click(object sender, EventArgs e)
        {

            string name = Cat_Combobox.SelectedItem.ToString();
            // get the id of the category 
            string cat_id = Get_Cat_ID_Exists(name);

            // call this function to delete all products insied that category 
            Delete_Productst(cat_id);

            Cat_Combobox.Items.Remove(name);
            SqlConnection con = mf.get_connection();

            SqlCommand cmd = new SqlCommand("DELETE FROM Categories where Cat_Name = @name;", con);

            cmd.Parameters.AddWithValue("@name", name);

            cmd.ExecuteNonQuery();


            Alert_Form af = new Alert_Form("عملية ناجحه\nتم ازالة الصنف",
                   Main_Functions.AlertType.success, 80);
            // make the form on the top always 
            af.TopMost = true;
            // show the alert form 
            af.Show();


            con.Close();

            Categories_Delete_Form_Load(sender, e);
        }
    }
}
