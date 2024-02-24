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
namespace MN_Lightining_Shop_Management_System
{
    public partial class Products_Delete_Form : Form
    {
        Main_Functions mf;
        public Products_Delete_Form()
        {
            
            InitializeComponent();
            mf = new Main_Functions();
            
        }

        private void Load_Categories()
        {
            SqlConnection con = mf.get_connection();

            SqlCommand cmd = new SqlCommand("SELECT Cat_Name FROM Categories;", con);

            SqlDataReader dr = cmd.ExecuteReader();
            if (!dr.HasRows)
            {
                Alert_Form af = new Alert_Form("خطا فى التحميل\nلا يوجد اصناف للمسح",
                   Main_Functions.AlertType.Information, 80);
                // make the form on the top always 
                af.TopMost = true;
                // show the alert form 
                af.Show();

                dr.Close();
                con.Close();

                Cat_Combobox.Enabled = Prod_ComboBox.Enabled = Delete_Button.Enabled = false;
                Cat_Combobox.Items.Clear();
                Prod_ComboBox.Items.Clear();


                Close_Button.Focus();
                Close_Button.Select();
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
            Cat_Combobox.Enabled = Prod_ComboBox.Enabled = Delete_Button.Enabled = true;

            dr.Close();
            con.Close();

            Cat_Combobox.SelectedIndex = Cat_Combobox.Items.IndexOf(last_cat);
        }



        private void Load_Products(string cat_id)
        {
            SqlConnection con = mf.get_connection();

            SqlCommand cmd = new SqlCommand(@"SELECT PROD_NAME FROM Products
                                                WHERE CAT_ID = @cid;", con);

            cmd.Parameters.AddWithValue("cid", cat_id);

            SqlDataReader dr = cmd.ExecuteReader();
            if (!dr.HasRows)
            {
                Alert_Form af = new Alert_Form("خطا فى التحميل\nلا يوجد منتجات للمسح",
                   Main_Functions.AlertType.Information, 80);
                // make the form on the top always 
                af.TopMost = true;
                // show the alert form 
                af.Show();

                dr.Close();
                con.Close();

                Prod_ComboBox.Enabled = Delete_Button.Enabled = false;
                Prod_ComboBox.Items.Clear();
                Close_Button.Focus();
                Close_Button.Select();
                return;
            }

            string last_prod = "";
            int i = 0;
            Prod_ComboBox.Items.Clear();
            while (dr.Read())// while we read the years
            {
                // add the years to the combo box 
                Prod_ComboBox.Items.Add(dr[0].ToString());
                if (i == 0)
                {
                    last_prod = dr[0].ToString(); // assign the new year in the variable to get the last year
                    ++i;
                }
            }
            // now we make the last year the default value in the combo box 
            Prod_ComboBox.Enabled = Delete_Button.Enabled = true;

            dr.Close();
            con.Close();

            Prod_ComboBox.SelectedIndex = Prod_ComboBox.Items.IndexOf(last_prod);
        }


        private string Get_Cat_Code()
        {
            SqlConnection con = mf.get_connection();
            SqlCommand cmd = new SqlCommand("SELECT CAT_ID FROM CATEGORIES WHERE CAT_NAME = @name", con);
            cmd.Parameters.AddWithValue("@name", Cat_Combobox.SelectedItem.ToString());
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            string cat_id = dr[0].ToString();
            dr.Close();
            con.Close();
            return cat_id;
        }


        private string Get_Prod_Code(string cat_id)
        {
            SqlConnection con = mf.get_connection();
            SqlCommand cmd = new SqlCommand("SELECT PROD_ID FROM PRODUCTS WHERE PROD_NAME = @name AND CAT_ID = @cid", con);
            cmd.Parameters.AddWithValue("@name", Prod_ComboBox.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@cid", cat_id);
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            string prod_id = dr[0].ToString();
            dr.Close();
            con.Close();
            return prod_id;
        }

        private void Products_Delete_Form_Load(object sender, EventArgs e)
        {
            // set the animation of the form using the animator 
            Form_Animation.SetAnimateWindow(this);

            // call this function to get all the categories in the Combo Box
            Load_Categories();
        }

        private void Close_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Down_Button_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }


        private void Refresh_Button_Click(object sender, EventArgs e)
        {
            Products_Delete_Form_Load(sender, e);
        }

        // this fucntion for the key down enter for all controls 
        private void key_down_function(object sender, KeyEventArgs e)
        {
            // this event to indicate if the button is pressed down or not 
            // the enter key  
            if (e.KeyValue == (char)Keys.Enter)// call the button click event
                Delete_Button_Click(sender, e);
        }

        private void Cat_Combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cat_name = Cat_Combobox.SelectedItem.ToString();
            // get the id of this category 
            string cat_id = Get_Cat_Code();
            // call this function to load the products of this category in the second combo box 
            Load_Products(cat_id);

        }

        private void Delete_Button_Click(object sender, EventArgs e)
        {
            string cat_id = Get_Cat_Code();
            string prod_id = Get_Prod_Code(cat_id);

            SqlConnection con = mf.get_connection();
            SqlCommand cmd = new SqlCommand("DELETE FROM Products  WHERE Prod_ID = @pid AND Cat_ID = @cid;", con);

            cmd.Parameters.AddWithValue("@pid", prod_id);
            cmd.Parameters.AddWithValue("@cid", cat_id);

            cmd.ExecuteNonQuery();

            con.Close();


            Alert_Form af = new Alert_Form("عملية ناجحه\nتم ازالة المنتج",
                   Main_Functions.AlertType.success, 80);
            // make the form on the top always 
            af.TopMost = true;
            // show the alert form 
            af.Show();


            Products_Delete_Form_Load(sender, e);
        }
    }
}
