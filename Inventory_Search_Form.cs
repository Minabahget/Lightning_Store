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
    public partial class Inventory_Search_Form: Form
    {
        Main_Functions mf;
        public Inventory_Search_Form()
        {
            
            InitializeComponent();
            mf = new Main_Functions();
            
        }


        private string Get_Prod_Name(string prod_id)
        {
            string prod_name = "";
            SqlConnection con = mf.get_connection();

            SqlCommand cmd = new SqlCommand("SELECT PROD_NAME FROM PRODUCTS WHERE PROD_ID = @pid", con);
            cmd.Parameters.AddWithValue("@pid", prod_id);

            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();

            prod_name = dr[0].ToString();

            dr.Close();
            con.Close();

            return prod_name;
        }

        private void Load_Products()
        {
            SqlConnection con = mf.get_connection();

            SqlCommand cmd = new SqlCommand(@"SELECT PROD_NAME FROM Products", con);


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

                Prod_ComboBox.Enabled = Search_Button.Enabled = Prod_ComboBox.Enabled = false;
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
            Prod_ComboBox.Enabled = Search_Button.Enabled = Prod_ComboBox.Enabled = true;

            dr.Close();
            con.Close();

            Prod_ComboBox.SelectedIndex = Prod_ComboBox.Items.IndexOf(last_prod);
        }



        private bool Right_Code(string prod_code)
        {
            bool exists = false;
            SqlConnection con = mf.get_connection();
            SqlCommand cmd = new SqlCommand("SELECT PROD_ID FROM PRODUCTS;", con);
            SqlDataReader dr = cmd.ExecuteReader(); 
            while(dr.Read())
            {
                if(dr[0].ToString() == prod_code)
                {
                    exists = true;
                    break;
                }
            }
            con.Close();
            return exists;
        }


        private void Get_Prod_Data(string prod_code)
        {
            SqlConnection con = mf.get_connection();
            SqlCommand cmd = new SqlCommand("SELECT PROD_ID, PROD_NAME, QUANTITY FROM PRODUCTS WHERE PROD_ID = @pid;", con);
            cmd.Parameters.AddWithValue("@pid", prod_code);
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            CodeDataLabel.Text = dr[0].ToString();
            if (dr[1].ToString().Length > 50)
            {
                string name = dr[1].ToString();
                NameDataLabel.Visible = NameDataLable2.Visible = true;
                NameDataLabel.Text = NameDataLable2.Text = string.Empty;
                for (int i = 0; i < 50; ++i)
                    NameDataLabel.Text += name[i];
                for (int i = 50; i < name.Length; ++i)
                    NameDataLable2.Text += name[i];

            }
            else
            {
                NameDataLabel.Text = dr[1].ToString();
                NameDataLabel.Visible = true;
                NameDataLable2.Visible = false;
            }
            QuantityDataLabel.Text = dr[2].ToString();

            dr.Read();
            con.Close();
        }

        private void Inventory_Search_Form_Load(object sender, EventArgs e)
        {
            // set the animation of the form using the animator 
            Form_Animation.SetAnimateWindow(this);
            // make the focus and the select on the name text box 
            Product_TextBox.Select();
            Product_TextBox.Focus();

            CodeLabel.Visible = NameLabel.Visible = QuantityLabel.Visible
                 = CodeDataLabel.Visible = NameDataLabel.Visible = QuantityDataLabel.Visible
                 = NameDataLable2.Visible = false;


            Load_Products();
        }

        private void Close_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Down_Button_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        
        // this fucntion for the key down enter for all controls 
        private void key_down_function(object sender, KeyEventArgs e)
        {
            // this event to indicate if the button is pressed down or not 
            // the enter key  
            if (e.KeyValue == (char)Keys.Enter)// call the button click event
                Search_Button_Click(sender, e);
        }

        private void Product_TextBox_Enter(object sender, EventArgs e)
        {
            // in case the place holder inside the text box 
            if (Product_TextBox.Text == "ادخل كود المنتج")
                // remove the place holder 
                Product_TextBox.Text = string.Empty;
        }

        private void Product_TextBox_Leave(object sender, EventArgs e)
        {
            // in case the text box is empty 
            if (Product_TextBox.Text.Trim() == string.Empty)
                // put the place holder 
                Product_TextBox.Text = "ادخل كود المنتج";
        }


        private void Search_Button_Click(object sender, EventArgs e)
        {

            string Code = Product_TextBox.Text.Trim();
            if (Product_TextBox.Text.Trim() == string.Empty || Product_TextBox.Text.Trim() == "ادخل كود المنتج")
            {
                Alert_Form af = new Alert_Form("البيانات غير مكتمله\nأدخل كود المنتج كاملا", 
                    Main_Functions.AlertType.error, 80);
                // make the form on the top always 
                af.TopMost = true;
                // show the alert form 
                af.Show();

                Inventory_Search_Form_Load(sender, e);
                // return and exit the function 
                return;
            }

            else if(!Right_Code(Code))
            {
                Alert_Form af = new Alert_Form("خطا ادخال\nالكود غير صحيح",
                    Main_Functions.AlertType.error, 80);
                // make the form on the top always 
                af.TopMost = true;
                // show the alert form 
                af.Show();

                Inventory_Search_Form_Load(sender, e);
                // return and exit the function 
                return;
            }


            // call this function to get the data 
            Get_Prod_Data(Code);

            CodeLabel.Visible = NameLabel.Visible = QuantityLabel.Visible
                  = CodeDataLabel.Visible = NameDataLabel.Visible = QuantityDataLabel.Visible = true;

            // call this function to make the combo box with the name of the entered code 
            string name = Get_Prod_Name(Code);

            Prod_ComboBox.SelectedIndex = Prod_ComboBox.Items.IndexOf(name);

            // back to original 
            Product_TextBox.Text = string.Empty;

            Product_TextBox.Focus();
            Product_TextBox.Select();

        }

        private void Prod_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = mf.get_connection();
            SqlCommand cmd = new SqlCommand("SELECT PROD_ID FROM PRODUCTS WHERE PROD_NAME = @pn", con);

            cmd.Parameters.AddWithValue("@pn", Prod_ComboBox.SelectedItem.ToString());

            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();

            Product_TextBox.Text = dr[0].ToString();

            dr.Close();
            con.Close();


            Product_TextBox.Select();
            Product_TextBox.Focus();
        }
    }
}
