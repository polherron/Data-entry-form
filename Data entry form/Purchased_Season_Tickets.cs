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
    public partial class Purchased_Season_Tickets : Form
    {
        public Purchased_Season_Tickets()
        {
            InitializeComponent();
        }

        private void Purchased_Season_Tickets_Load(object sender, EventArgs e)
        {
            dgv_Tickets.DataSource = Globals.priv_ticket_List;
            
        }

        private void btn_CSP_Click(object sender, EventArgs e)
        {
            dgv_Tickets.DataSource = Globals.Corporate_List;
        }
    }
}
