using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Data_entry_form
{
    public partial class Season_Ticket_Entry_Form : Form
    {
        public Season_Ticket_Entry_Form()
        {
            InitializeComponent();
        }

        private void Season_Ticket_Entry_Form_Load(object sender, EventArgs e)
        {
            string[] myArray = new string[Globals.Site_Combo.Items.Count];
            Globals.Site_Combo.Items.CopyTo(myArray, 0);

            cmbCuTitle.Items.AddRange(myArray);
        }

        private void btnMenuPrivateEntry_Click(object sender, EventArgs e)
        {
            Main_Menu main_Menu = new Main_Menu();
            main_Menu.Show();
        }

        private void btnMenuCorporate_Click(object sender, EventArgs e)
        {
            Main_Menu main_Menu = new Main_Menu();
            main_Menu.Show();
        }

        private void btnEnterDetails_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you wish to continue with the purchase?", "Confirm", MessageBoxButtons.YesNo);

            if (result == DialogResult.No)
            {
                MessageBox.Show("Purchase Cancelled", "Alert");
            }
            else
            {
                priv_ticket New_Details = new priv_ticket();

                if (radioButton1.Checked)
                {
                    New_Details = new priv_ticket(true, txtVIPCost.Text);
                }
                else
                {
                    New_Details = new priv_ticket();
                }


                New_Details.Customer_forename = txtCUName.Text;
                New_Details.Customer_surname = txtCuSurname.Text;
                New_Details.Customer_address = txtCuAddress.Text;
                New_Details.Customer_postcode = txtCuPostcode.Text;
                New_Details.Discount_percentage = Utilities.ConvertToDouble(txtDiscountPercentage.Text);
                New_Details.Employee_number = txtEmployeeID.Text;
                New_Details.Payment_method = txtPaymentMethod.Text;
                Globals.priv_ticket_List.Add(New_Details);

                this.Close();
                MessageBox.Show("Purchase Confirmed", "Alert");

                //MessageBox.Show(New_Details.Ticket_charge(), "Alert");
            }
        }

        private void btnSubmitCorporate_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you wish to continue with the purchase?", "Confirm", MessageBoxButtons.YesNo);

            if (result == DialogResult.No)
            {
                MessageBox.Show("Purchase Cancelled", "Alert");
            }
            else
            {
                Corporate New_Details = new Corporate();

                New_Details.Company_name = txtCOName.Text;
                New_Details.Discount_amount = Utilities.ConvertToDouble(txtCODiscount.Text);
                New_Details.VipAccess = radioButton1.Checked;
                New_Details.VIP_Cost1 = Utilities.ConvertToDouble(txtVIPCost.Text);
                New_Details.Company_Contact1 = txtCOContact.Text;
                New_Details.Company_address1= txtCOAddress.Text;
                New_Details.Company_postcode1 = txtCOPostcode.Text;
                Globals.Corporate_List.Add(New_Details);

                this.Close();
                MessageBox.Show("Purchase Confirmed", "Alert");

                MessageBox.Show(New_Details.Ticket_charge().ToString(), "Alert");
            }
        }
    }
}


