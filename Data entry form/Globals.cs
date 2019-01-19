using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Data_entry_form
{
    class Globals
    {
        public static string[] Customer_Titles = { "Mr", "Mrs", "Miss", "Dr"};
        public static ComboBox Site_Combo = new ComboBox();

        public static List<priv_ticket> priv_ticket_List = new List<priv_ticket>();
        public static List<Corporate> Corporate_List = new List<Corporate>();
    }
}
