using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;

namespace Pharmacy_APP
{
    public partial class Apoteka : MaterialSkin.Controls.MaterialForm
    {
        public Apoteka()
        {
            InitializeComponent();
            var skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.DARK;
            skinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500,Accent.LightBlue200,TextShade.WHITE);
        }

        private void materialLabel4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'appData.Pharmacy' table. You can move, or remove it, as needed.
            this.pharmacyTableAdapter.Fill(this.appData.Pharmacy);
            Edit(false);
        }
        private void Edit(bool value)
        {
            ime_leka.Enabled = value;
            datum_isteka.Enabled = value;
            kolicina.Enabled = value;    
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            try
            {
                Edit(true);
                appData.Pharmacy.AddPharmacyRow(appData.Pharmacy.NewPharmacyRow());
                pharmacyBindingSource.MoveLast();
                ime_leka.Focus();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                appData.Pharmacy.RejectChanges();
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            Edit(true);
            ime_leka.Focus();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Edit(false);
            pharmacyBindingSource.ResetBindings(false);
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                Edit(true);
                pharmacyBindingSource.EndEdit();
                pharmacyTableAdapter.Update(appData.Pharmacy);
                dataGridView1.Refresh();
                ime_leka.Focus();
                MessageBox.Show("Your data has been sucessfully saved", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Edit(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                appData.Pharmacy.RejectChanges();
            }
        }


        private void search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!string.IsNullOrEmpty(search.Text))
                    pharmacyBindingSource.Filter = string.Format("ime_leka LIKE '{0}'",search.Text);
                else
                    pharmacyBindingSource.Filter = string.Empty;
            }
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Delete)
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    pharmacyBindingSource.RemoveCurrent();
            }
        }
    }
}
