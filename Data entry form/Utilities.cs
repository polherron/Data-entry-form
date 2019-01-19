using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_entry_form
{
    class Utilities
    {
        public static double ConvertToDouble(string value)
        {
            try
            {


                return Convert.ToDouble(value);
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
        public static double calc_vat(double money)

        {
            return money * 0.1;
        }

        public static double Ticket_charge(double charge)

        {
            return charge + calc_vat(charge);
        }
    }
}
