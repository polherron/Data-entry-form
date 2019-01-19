using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_entry_form
{
    class League
    {
        private int ticket_number;
        private double charge;
        private string team_name;
        private DateTime start_date;
        private DateTime Date_Purchased;
        private string Customer_Title;
        private string Customer_Forename;
        private string Customer_Surname;
        private string Customer_Address;
        private string Customer_PostCode;
        private string Customer_TelephoneNumber;



        public League()
        {
            ticket_number = 0;
            charge = 0.0;
            team_name = "unknown";
            start_date = DateTime.Today;
            Date_Purchased = DateTime.Today;
            Customer_Title = "unknown";
            Customer_Forename = "unknown";
            Customer_Surname = "unknown";
            Customer_Address = "unknown";
            Customer_PostCode = "unknown";
            Customer_TelephoneNumber = "unknown";
        }

        /// <summary>
        /// Short Constructor
        /// </summary>
        /// <param name="tn"></param>
        /// <param name="ch"></param>
        /// <param name="team"></param>
        /// <param name="sd"></param>
        public League(int tn, double ch, string team, DateTime sd)
        {
            ticket_number = tn;
            charge = ch;
            team_name = team;
            start_date = sd;
        }

        /// <summary>
        /// Full Constructor
        /// </summary>
        /// <param name="tn"></param>
        /// <param name="ch"></param>
        /// <param name="team"></param>
        /// <param name="sd"></param>
        /// <param name="title"></param>
        /// <param name="fn"></param>
        /// <param name="sn"></param>
        /// <param name="ad"></param>
        /// <param name="pc"></param>
        /// <param name="pn"></param>
        public League(int tn, double ch, string team, DateTime sd, string title, string fn, string sn, string ad, string pc, string pn)
        {
            ticket_number = tn;
            charge = ch;
            team_name = team;
            start_date = sd;
            Customer_Title = title;
            Customer_Forename = fn;
            Customer_Surname = sn;
            Customer_Address = ad;
            Customer_PostCode = pc;
            Customer_TelephoneNumber = pn;
        }

        public string Customer_address
        {
            get
            {
                return Customer_Address;
                
            }

            set
            {
                Customer_Address = value;
            }
        }

        public string Customer_postcode
        {
            get
            {
                return Customer_PostCode;
            }

            set
            {
                Customer_PostCode = value;
            }
        }

        public double Charge
        {
            get
            {
                return charge;
            }
            set
            {
                charge = value;
            }
        }

        public string Customer_title
        {
            get
            {
                return Customer_Title;

            }

            set
            {
                Customer_Title = value;
            }
        }

        public string Customer_forename
        {
            get
            {
                return Customer_Forename;

            }

            set
            {
                Customer_Forename = value;
            }
        }

        public string Customer_surname
        {
            get
            {
                return Customer_Surname;
            }

            set
            {
                Customer_Surname = value;
            }
        }

        public virtual double Ticket_charge()
        {
            return this.charge;
        }

    }   
}
