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
    public partial class Products_Add_Form : Form
    {
        Main_Functions mf;
        public Products_Add_Form()
        {
            
            InitializeComponent();
            mf = new Main_Functions();
            
        }


        private bool Same_Product(string name)
        {
            bool not_same = true;

            SqlConnection con = mf.get_connection();

            SqlCommand cmd = new SqlCommand("SELECT Prod_Name FROM Products;", con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (dr[0].ToString() == name)
                {
                    not_same = false;
                    break;
                }
            }
            dr.Close();
            con.Close();
            return not_same;
        }


        private bool Same_Code(string code)
        {
            bool not_same = true;

            SqlConnection con = mf.get_connection();

            SqlCommand cmd = new SqlCommand("SELECT Prod_ID FROM Products;", con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (dr[0].ToString() == code)
                {
                    not_same = false;
                    break;
                }
            }
            dr.Close();
            con.Close();
            return not_same;
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

                Code_TextBox.Enabled = Product_TextBox.Enabled = 
                   UnitPrice_TextBox.Enabled = BoxPrice_TextBox.Enabled = 
                   Quantity_TextBox.Enabled =  Insert_Button.Enabled = Cat_Combobox.Enabled = false;

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
            Cat_Combobox.SelectedIndex = Cat_Combobox.Items.IndexOf(last_cat);
            Code_TextBox.Enabled = Product_TextBox.Enabled =
                   UnitPrice_TextBox.Enabled = BoxPrice_TextBox.Enabled =
                   Quantity_TextBox.Enabled = Insert_Button.Enabled = Cat_Combobox.Enabled = true;

            Product_TextBox.Focus();
            Product_TextBox.Select();

            dr.Close();
            con.Close();
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

        private void Insert_Product(string prod_name, string code, int quantity, 
            double unitprice, double boxprice, string cat_code)
        {
            SqlConnection con = mf.get_connection();
            SqlCommand cmd = new SqlCommand(@"INSERT INTO PRODUCTS(Prod_ID, Prod_Name, Quantity, Unit_Price, Box_Price, Cat_ID)
                                            VALUES(@id, @name, @q, @up, @bp, @cid); ", con);

            cmd.Parameters.AddWithValue("id", code);
            cmd.Parameters.AddWithValue("name", prod_name);
            cmd.Parameters.AddWithValue("q", quantity);
            cmd.Parameters.AddWithValue("up", unitprice);
            cmd.Parameters.AddWithValue("bp", boxprice);
            cmd.Parameters.AddWithValue("cid", cat_code); 


            cmd.ExecuteNonQuery();


            con.Close();
            Alert_Form af = new Alert_Form("عملية ناجحه\nتم اضافة المنتج",
                   Main_Functions.AlertType.success, 80);
            // make the form on the top always 
            af.TopMost = true;
            // show the alert form 
            af.Show();

        }


        private void Products_Add_Form_Load(object sender, EventArgs e)
        {
            // set the animation of the form using the animator 
            Form_Animation.SetAnimateWindow(this);
            // make the focus and the select on the name text box 
            Product_TextBox.Select();
            Product_TextBox.Focus();

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

        
        // this fucntion for the key down enter for all controls 
        private void key_down_function(object sender, KeyEventArgs e)
        {
            // this event to indicate if the button is pressed down or not 
            // the enter key  
            if (e.KeyValue == (char)Keys.Enter)// call the button click event
                Insert_Button_Click(sender, e);
        }

        private void Product_TextBox_Enter(object sender, EventArgs e)
        {
            // in case the place holder inside the text box 
            if (Product_TextBox.Text == "ادخل اسم المنتج")
                // remove the place holder 
                Product_TextBox.Text = string.Empty;
        }

        private void Product_TextBox_Leave(object sender, EventArgs e)
        {
            // in case the text box is empty 
            if (Product_TextBox.Text.Trim() == string.Empty)
                // put the place holder 
                Product_TextBox.Text = "ادخل اسم المنتج";
        }


        private void Code_TextBox_Enter(object sender, EventArgs e)
        {
            // in case the place holder inside the text box 
            if (Code_TextBox.Text == "ادخل كود المنتج")
                // remove the place holder 
                Code_TextBox.Text = string.Empty;
        }

        private void Code_TextBox_Leave(object sender, EventArgs e)
        {
            // in case the text box is empty 
            if (Code_TextBox.Text.Trim() == string.Empty)
                // put the place holder 
                Code_TextBox.Text = "ادخل كود المنتج";
        }


        private void UnitPrice_TextBox_Enter(object sender, EventArgs e)
        {
            // in case the place holder inside the text box 
            if (UnitPrice_TextBox.Text == "ادخل سعر الوحده")
                // remove the place holder 
                UnitPrice_TextBox.Text = string.Empty;
        }

        private void UnitPrice_TextBox_Leave(object sender, EventArgs e)
        {
            // in case the text box is empty 
            if (UnitPrice_TextBox.Text.Trim() == string.Empty)
                // put the place holder 
                UnitPrice_TextBox.Text = "ادخل سعر الوحده";
        }


        private void BoxPrice_TextBox_Enter(object sender, EventArgs e)
        {
            // in case the place holder inside the text box 
            if (BoxPrice_TextBox.Text == "ادخل سعر الكرتونه")
                // remove the place holder 
                BoxPrice_TextBox.Text = string.Empty;
        }

        private void BoxPrice_TextBox_Leave(object sender, EventArgs e)
        {
            // in case the text box is empty 
            if (BoxPrice_TextBox.Text.Trim() == string.Empty)
                // put the place holder 
                BoxPrice_TextBox.Text = "ادخل سعر الكرتونه";
        }

        private void Quantity_TextBox_Enter(object sender, EventArgs e)
        {
            // in case the place holder inside the text box 
            if (Quantity_TextBox.Text == "ادخل الكميه")
                // remove the place holder 
                Quantity_TextBox.Text = string.Empty;
        }

        private void Quantity_TextBox_Leave(object sender, EventArgs e)
        {
            // in case the text box is empty 
            if (Quantity_TextBox.Text.Trim() == string.Empty)
                // put the place holder 
                Quantity_TextBox.Text = "ادخل الكميه";
        }


        private void Insert_Button_Click(object sender, EventArgs e)
        {
            string prod_name = Product_TextBox.Text.Trim();
            string code = Code_TextBox.Text.Trim();
            string unitprice_str = UnitPrice_TextBox.Text.Trim();
            string boxprice_str = BoxPrice_TextBox.Text.Trim();
            string quantity_str = Quantity_TextBox.Text.Trim();

            if (Product_TextBox.Text.Trim() == string.Empty || Product_TextBox.Text.Trim() == "ادخل اسم المنتج"||
                Code_TextBox.Text.Trim() == string.Empty || Code_TextBox.Text.Trim() == "ادخل كود المنتج" ||
                UnitPrice_TextBox.Text.Trim() == string.Empty || UnitPrice_TextBox.Text.Trim() == "ادخل سعر الوحده" ||
                BoxPrice_TextBox.Text.Trim() == string.Empty || BoxPrice_TextBox.Text.Trim() == "ادخل سعر الكرتونه" ||
                Quantity_TextBox.Text.Trim() == string.Empty || Quantity_TextBox.Text.Trim() == "ادخل الكميه")
            {
                Alert_Form af = new Alert_Form("البيانات غير مكتمله\nأدخل جميع بيانات المنتج", 
                    Main_Functions.AlertType.error, 80);
                // make the form on the top always 
                af.TopMost = true;
                // show the alert form 
                af.Show();
                // return and exit the function 
                return;
            }

            else if (!(Regex.IsMatch(unitprice_str, @"^[0-9]+$")) || !(Regex.IsMatch(boxprice_str, @"^[0-9]+$")) ||
                !(Regex.IsMatch(quantity_str, @"^[0-9]+$")))
            {
                // call this function to handle the alert 
                mf.Handle_Alerts("خطأ ادخال\nيرجى ادخال ارفام صحيحه"
                    , Main_Functions.AlertType.error, 80);
                // exit the function 
                return;
            }

            else if(!Same_Product(prod_name))
            {
                Alert_Form af = new Alert_Form("خطأ ادخال\nالمنتج موجود بالفعل",
                    Main_Functions.AlertType.error, 80);
                // make the form on the top always 
                af.TopMost = true;
                // show the alert form 
                af.Show();
                // return and exit the function 
                return;
            }

            else if(!Same_Code(code))
            {
                Alert_Form af = new Alert_Form("خطأ ادخال\nالكود موجود بالفعل",
                    Main_Functions.AlertType.error, 80);
                // make the form on the top always 
                af.TopMost = true;
                // show the alert form 
                af.Show();
                // return and exit the function 
                return;
            }

            // get the id of the selected category with this function 
            string cat_code = Get_Cat_Code();

            // call this function to insert the data of the product 
            Insert_Product(prod_name, code, Convert.ToInt32(quantity_str),
                Convert.ToDouble(unitprice_str), Convert.ToDouble(boxprice_str), cat_code);

            // back to the original
            

            Code_TextBox.Text = "ادخل كود المنتج";
            UnitPrice_TextBox.Text = "ادخل سعر الوحده";
            BoxPrice_TextBox.Text = "ادخل سعر الكرتونه";
            Quantity_TextBox.Text = "ادخل الكميه";

            Product_TextBox.Text = "ادخل اسم المنتج";
            Product_TextBox.Focus();
            Product_TextBox.Select();
        }

        private void Refresh_Button_Click(object sender, EventArgs e)
        {
            Products_Add_Form_Load(sender, e);
        }
    }
}
