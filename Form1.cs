using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Rental
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            frm_Add_Customers frm_Add_Customers = new frm_Add_Customers();  
            frm_Add_Customers.ShowDialog();
            this.Close();
            this.Hide();

        }

        private void btnAddCars_Click(object sender, EventArgs e)
        {
            frm_Add_Car frm_Add_Car = new frm_Add_Car();    
            frm_Add_Car.ShowDialog();   
            this.Close();
            this.Hide();    
        }
    }
}
