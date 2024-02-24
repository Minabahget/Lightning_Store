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
    public partial class Categories_Add_Form : Form
    {
        Main_Functions mf;
        public Categories_Add_Form()
        {
            
            InitializeComponent();
            mf = new Main_Functions();
            
        }


        private bool Same_Cat(string name)
        {
            bool not_same = true;

            SqlConnection con = mf.get_connection();

            SqlCommand cmd = new SqlCommand("SELECT cat_name FROM Categories;", con);
            SqlDataReader dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                if(dr[0].ToString() == name)
                {
                    not_same = false;
                    break;
                }
            }
            dr.Close();
            con.Close();
            return not_same;
        }

        private string Get_Cat_ID()
        {
            int cat_id = -1;
            SqlConnection con = mf.get_connection();

            SqlCommand cmd = new SqlCommand("SELECT MAX(Cat_ID) FROM Categories;", con);
            SqlDataReader dr = cmd.ExecuteReader();
            try
            {
                dr.Read();
                cat_id = Convert.ToInt32(dr[0].ToString());
                cat_id++;
            }
            catch { cat_id = 1; }
            dr.Close();
            con.Close();
            return cat_id.ToString();
        }

        private void Insert_Cat(string cat_name, string cat_id)
        {
            SqlConnection con = mf.get_connection();

            SqlCommand cmd = new SqlCommand("INSERT INTO Categories(Cat_ID, Cat_Name) VALUES(@id, @name);", con);
            cmd.Parameters.AddWithValue("@id", cat_id);
            cmd.Parameters.AddWithValue("@name", cat_name);
            cmd.ExecuteNonQuery();
            con.Close();

            Alert_Form af = new Alert_Form("عملية ناجحه\nتم اضافة الصنف",
                   Main_Functions.AlertType.success, 80);
            // make the form on the top always 
            af.TopMost = true;
            // show the alert form 
            af.Show();
        }

        private void Categories_Add_Form_Load(object sender, EventArgs e)
        {
            // set the animation of the form using the animator 
            Form_Animation.SetAnimateWindow(this);
            // make the focus and the select on the name text box 
            Category_TextBox.Select();
            Category_TextBox.Focus();
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
                Insert_Button_Click(sender, e);
        }

        private void Category_TextBox_Enter(object sender, EventArgs e)
        {
            // in case the place holder inside the text box 
            if (Category_TextBox.Text == "ادخل اسم الصنف")
                // remove the place holder 
                Category_TextBox.Text = string.Empty;
        }

        private void Category_TextBox_Leave(object sender, EventArgs e)
        {
            // in case the text box is empty 
            if (Category_TextBox.Text.Trim() == string.Empty)
                // put the place holder 
                Category_TextBox.Text = "ادخل اسم الصنف";
        }


        private void Insert_Button_Click(object sender, EventArgs e)
        {

            string name = Category_TextBox.Text.Trim();
            if (Category_TextBox.Text.Trim() == string.Empty || Category_TextBox.Text.Trim() == "ادخل اسم الصنف")
            {
                Alert_Form af = new Alert_Form("البيانات غير مكتمله\nأدخل اسم الصنف كاملا", 
                    Main_Functions.AlertType.error, 80);
                // make the form on the top always 
                af.TopMost = true;
                // show the alert form 
                af.Show();
                // return and exit the function 
                return;
            }

            else if (!Same_Cat(name))
            {
                Alert_Form af = new Alert_Form("خطأ ادخال\nالصنف موجود بالفعل",
                    Main_Functions.AlertType.error, 80);
                // make the form on the top always 
                af.TopMost = true;
                // show the alert form 
                af.Show();
                // return and exit the function 
                return;
            }

            // take the name of the category
            string cat_name = Category_TextBox.Text.Trim();

            // call this function to get the last id in the categories table to insert 
            string cat_id = Get_Cat_ID();

            // call this function to insert the category and return all things to original
            Insert_Cat(cat_name, cat_id);

            // back to original 
            Category_TextBox.Text = string.Empty;
            // Category_TextBox.Text = "ادخل اسم الصنف";

            Category_TextBox.Focus();
            Category_TextBox.Select();

        }

    }
}
