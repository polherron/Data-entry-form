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
    public partial class Main_Menu : Form
    {
        public Main_Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Purchased_Season_Tickets purchased_Season_Tickets = new Purchased_Season_Tickets();
            purchased_Season_Tickets.Show();

        }

        private void btnEntryForm_Click(object sender, EventArgs e)
        {
            Season_Ticket_Entry_Form season_Ticket_Entry_Form = new Season_Ticket_Entry_Form();
            season_Ticket_Entry_Form.Show();
        }

        private void btnHelpScreen_Click(object sender, EventArgs e)
        {
            HelpForm helpForm = new HelpForm();
            helpForm.Show();
        }
    }
}
