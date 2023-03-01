using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Rental
{
    public partial class frm_Add_Car : Form
    {
        public frm_Add_Car()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=RYZEN-3;Initial Catalog=Car_Rental;Integrated Security=True");
        Car car = new Car();

        private void btnBackToMenu_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Hide();
            frm_Menu frm_Menu = new frm_Menu();
            frm_Menu.ShowDialog();
           
        }

        private void btnSaveCar_Click(object sender, EventArgs e)
        {



            car.Car_Make = txtMake.Text;
            car.Car_Model = txtCarModel.Text;
            car.Car_Vin = txtVin.Text;
            car.Car_Color = cbColor.Text;
            car.Car_Transmission = cbTransmission.Text;
            car.Car_Year = Convert.ToInt32(cbYear.Text);

            try
            {
                con.Open();
                SqlCommand com = new SqlCommand("SP_GetCarByVinNumber '" + car.Car_Vin + "'",con);
                SqlDataReader reader = com.ExecuteReader();

              
                if (reader.HasRows) 
                {
                    MessageBox.Show("This Car already exists in the system", "Error", MessageBoxButtons.OK);
                    reader.Close();
                    con.Close();
                }
                else
                {
                    reader.Close();
                    con.Close();
                    try
                {
                       con.Open();
                        SqlCommand comm = new SqlCommand("SP_InsertCar '" + car.Car_Make + "', '" +
                            car.Car_Model + "', '" + car.Car_Year + "', '" + car.Car_Color +
                            "', '" + car.Car_Transmission + "', '" + car.Car_Vin + "'", con);
                        comm.ExecuteNonQuery();

                        MessageBox.Show("Car Saved in the system", "Success", MessageBoxButtons.OK);
                        con.Close();
                    }
                    catch (Exception ex) { MessageBox.Show("Failed to Connect to DB.\n" + ex.ToString()); }
                }
                
            }
            catch (Exception ex) { MessageBox.Show("Couldn't Find Vin Number.\n" + ex.ToString()); }


            
        }
    }
}
