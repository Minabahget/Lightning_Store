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
using ClosedXML.Excel;
namespace MN_Lightining_Shop_Management_System
{
    public partial class InventoryReport_Form : Form
    {
        Main_Functions mf;
        public InventoryReport_Form()
        {
            mf = new Main_Functions();
            InitializeComponent();

        }


        // this function to export the data base to excel sheet
        public void Export_To_ExcelSheet(string query, string location
            , List<string> column_names, string file_name, string cat_id)
        {
            // open the work book first
            using (var workbook = new XLWorkbook())
            {
                // make a new work sheet as excel with the name of the parameter 
                var ws = workbook.Worksheets.Add(file_name);
                // make the headers of the work sheet (loop on the names of the columns)
                for (int i = 1; i <= column_names.Count; ++i)
                    // assign the value of the cell in the row number 1 with the column name 
                    ws.Cell(1, i).Value = column_names[i - 1];

                // make the sqlconnection 
                SqlConnection con = mf.get_connection();
                // make the sql data adapter 
                SqlDataAdapter ad = new SqlDataAdapter(query, con);
                ad.SelectCommand.Parameters.AddWithValue("@cid", cat_id);
                // make data table 
                DataTable dt = new DataTable();
                // fill the data table with the sql data adapter 
                ad.Fill(dt);

                // this variable to count the rows of the excel in the data table rows
                int row_count = 2;
                foreach (DataRow row in dt.Rows)
                {
                    // loop on each column in the data table
                    for (int i = 1; i <= column_names.Count; ++i)
                    {
                            // assign the value to the cell in the selected row 
                            ws.Cell(row_count, i).Value = row[i - 1].ToString();
                    }
                    // increament the row 
                    row_count++;
                }

                // save the excel file 
                workbook.SaveAs(location + ".xlsx");
                // call this function to make the alert 
                mf.Handle_Alerts("عمليه ناجحه\nتم تخزين الملف", Main_Functions.AlertType.success, 80);
                // close the data adapter 
                ad.Dispose();
                // close the connection 
                con.Close();
            }
        }


        private void Load_Categories()
        {
            SqlConnection con = mf.get_connection();

            SqlCommand cmd = new SqlCommand("SELECT Cat_Name FROM Categories;", con);

            SqlDataReader dr = cmd.ExecuteReader();
            if (!dr.HasRows)
            {
                Alert_Form af = new Alert_Form("بيانات فارغه\nلا يوجد اصناف ",
                   Main_Functions.AlertType.Information, 80);
                // make the form on the top always 
                af.TopMost = true;
                // show the alert form 
                af.Show();

                dr.Close();
                con.Close();


                Load_Button.Enabled = Save_Button.Enabled = Cat_Combobox.Enabled = false;

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
            Load_Button.Enabled = Save_Button.Enabled = Cat_Combobox.Enabled = true;

            dr.Close();
            con.Close();
        }


        // this function to handle the gridview for each button 
        public void Handle_GridView(string cat_id)
        {

            SqlConnection con = mf.get_connection();

            SqlCommand cmd = new SqlCommand(@"SELECT Quantity, Unit_Price, PROD_NAME, PROD_ID FROM PRODUCTS
                                                WHERE CAT_ID = @cid", con);

            cmd.Parameters.AddWithValue("@cid", cat_id);

            SqlDataReader dr = cmd.ExecuteReader();
            // check if there is data in the rows of the database 
            if (!dr.HasRows)
            {
                Alert_Form af = new Alert_Form("بيانات فارغه\nلا يوجد منتجات للعرض",
                   Main_Functions.AlertType.Information, 80);
                // make the form on the top always 
                af.TopMost = true;
                // show the alert form 
                af.Show();

                Load_Button.Enabled = Save_Button.Enabled = false;
                // exit the function 
                return;
            }
                // loop on the rows in the data reader 
                while (dr.Read())
                    // add the data in the data grid view for each trainee
                    Report_GridView.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString());
            // close the data reader 
            dr.Close();
            //close the connection 
            con.Close();

            Load_Button.Enabled = Save_Button.Enabled = true;

        }

        private void Close_Button_Click(object sender, EventArgs e)
        {
            // close the current form only 
            this.Close();
        }

        private void Down_Button_Click(object sender, EventArgs e)
        {
            // make the minimization of the form to the down of the desktop 
            WindowState = FormWindowState.Minimized;
        }

        private void InventoryReport_Form_Load(object sender, EventArgs e)
        {
            // set the animation of the form using the animator 
            Form_Animation.SetAnimateWindow(this);

            // to load the categories 
            Load_Categories();


        }

        private void Refresh_Button_Click(object sender, EventArgs e)
        {
            
            InventoryReport_Form_Load(sender, e);
        }


        private void Cat_Combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Report_GridView.Rows.Clear();
            string cat_name = Cat_Combobox.SelectedItem.ToString();
            SqlConnection con = mf.get_connection();

            SqlCommand cmd = new SqlCommand("SELECT CAT_ID FROM CATEGORIES WHERE CAT_NAME = @nc", con);
            cmd.Parameters.AddWithValue("@nc", cat_name);
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();

            string cat_id = dr[0].ToString();

            dr.Close();
            con.Close();
            Handle_GridView(cat_id);
        }

        
        private void Save_Button_Click(object sender, EventArgs e)
        {
            // first open the file diaglog for save 
            SaveFileDialog sfd = new SaveFileDialog();
            // make default name for the save file dialog 
            sfd.FileName = "Defualt Name";
            if (sfd.ShowDialog() == DialogResult.OK)
            {

                string cat_name = Cat_Combobox.SelectedItem.ToString();
                SqlConnection con = mf.get_connection();

                SqlCommand cmd = new SqlCommand("SELECT CAT_ID FROM CATEGORIES WHERE CAT_NAME = @nc", con);
                cmd.Parameters.AddWithValue("@nc", cat_name);
                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();

                string cat_id = dr[0].ToString();

                dr.Close();
                con.Close();




                // get the name of the file





                string file_name = sfd.FileName;





                // make the query 
                string query = @"SELECT PROD_ID, PROD_NAME, UNIT_PRICE, QUANTITY FROM PRODUCTS 
                                    WHERE CAT_ID = @cid";

                // make a list from the names of the columns 
                List<string> column_names = new List<string>() { "كود المنتج", "اسم المنتج" , "سعر الوحده" , "الكميه الموجوده"};
                // just try to do the following 
                try
                {
                    // call this function to save the file in the excel data 
                    Export_To_ExcelSheet(query, file_name, column_names,
                        "تقرير المنتجات", cat_id);
                }
                // in case the error happend 
                catch
                {
                    // call this function to handle the error alert 
                    mf.Handle_Alerts("خطا فى الملف\nيرجى ادخال اسم الملف فقط",
                        Main_Functions.AlertType.error, 80);
                }
            }
        }
        /*
        private void Load_Button_Click(object sender, EventArgs e)
        {
            string file_name = "";
            // open load file dialog to get the name of the excel sheet 
            OpenFileDialog od = new OpenFileDialog();
            od.Title = "Choose Traineers Excel File";
            od.Filter = "Excel Files (*.xlsx)|*.xlsx";
            if (od.ShowDialog() == DialogResult.OK)
            {
                file_name = od.FileName;

                try
                {
                    stc.Import_From_Excel_Sheet_Trainners(file_name);
                }
                catch
                {
                    // call this function to handle the error alert 
                    stc.Handle_Alerts("Worng Input\nRequired The Excel Of Traineers Only",
                        Main_Functions.AlertType.error, 80);
                }
            }
        }*/
    }
}
