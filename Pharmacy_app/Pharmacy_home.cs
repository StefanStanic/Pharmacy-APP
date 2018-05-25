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

namespace Pharmacy_app
{
    public partial class Pharmacy_home : Form
    {
        public Pharmacy_home()
        {
            InitializeComponent();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.inventoryBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pharmacyDBDataSet);
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            this.inventoryBindingSource.AddNew();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.inventoryBindingSource.RemoveCurrent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.inventoryBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pharmacyDBDataSet);
        }


        private void Pharmacy_home_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pharmacyDBDataSet.sold_drugs' table. You can move, or remove it, as needed.
            this.sold_drugsTableAdapter.Fill(this.pharmacyDBDataSet.sold_drugs);
            // TODO: This line of code loads data into the 'pharmacyDBDataSet.inventory' table. You can move, or remove it, as needed.
            this.inventoryTableAdapter.Fill(this.pharmacyDBDataSet.inventory);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void btnSell_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(id_inventoryTextBox.Text);
            string medicine_name = txtMedicineName.Text;
            string medicine_type = txtMedicineType.Text;
            int medicine_price = Convert.ToInt32(txtMedicinePrice.Text);
            int medicine_quantity = Convert.ToInt32(txtMedicineQuantity.Text);
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            int social_number = Convert.ToInt32(txtSocial.Text);
            string number = txtPhone.Text;
            using (SqlConnection cnn = new SqlConnection("Data Source=DESKTOP-BVA6A0R\\SQLEXPRESS;Initial Catalog=PharmacyDB;Integrated Security=True"))
            {
                string sql1 = "insert into sold_drugs ([socialNumber], [firstName], [lastName], [phoneNumber], [medicine_name], [medicine_type], [medicine_price], [medicine_quantity]) " +
                    "values(@social,@first,@last,@phone,@med_name,@med_type,@med_price,@med_quantity)";
                string sql2 = "UPDATE inventory SET medicine_quantity = medicine_quantity-"+medicine_quantity+"WHERE id_inventory="+ID;
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand(sql1, cnn))
                {
                    cmd.Parameters.AddWithValue("@social", social_number);
                    cmd.Parameters.AddWithValue("@first", firstName);
                    cmd.Parameters.AddWithValue("@last", lastName);
                    cmd.Parameters.AddWithValue("@phone", number);
                    cmd.Parameters.AddWithValue("@med_name", medicine_name);
                    cmd.Parameters.AddWithValue("@med_type", medicine_type);
                    cmd.Parameters.AddWithValue("@med_price", medicine_price);
                    cmd.Parameters.AddWithValue("@med_quantity", medicine_quantity);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Drug has been sold. You can see the status in the next tab!");
                }
                using (SqlCommand cmd = new SqlCommand(sql2, cnn))
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Quantity of drug reduced!");
                }

            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            sold_drugsDataGridView.Update();
            sold_drugsDataGridView.Refresh();
        }
    }
}
