using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_entry_form
{
    class Corporate : League
    {
        private string company_name;
        double discount_percentage;
        private double discount_amount;
        double VIP_Cost;
        private string Company_Contact;
        private string Company_address;
        private string Company_postcode;
        private bool vipAccess;



        public string Company_name
        {
            get
            {
                return company_name;
            }

            set
            {
                company_name = value;
            }
        }

        public double Discount_percentage
        {
            get
            {
                return discount_percentage;
            }

            set
            {
                discount_percentage = value;
            }
        }

        public double Discount_amount
        {
            get
            {
                return discount_amount;
            }

            set
            {
                discount_amount = value;
            }
        }

        public double VIP_Cost1
        {
            get
            {
                return VIP_Cost;
            }

            set
            {
                VIP_Cost = value;
            }
        }

        public string Company_Contact1
        {
            get
            {
                return Company_Contact;
            }

            set
            {
                Company_Contact = value;
            }
        }

        public string Company_address1
        {
            get
            {
                return Company_address;
            }

            set
            {
                Company_address = value;
            }
        }

        public string Company_postcode1
        {
            get
            {
                return Company_postcode;
            }

            set
            {
                Company_postcode = value;
            }
        }

        public bool VipAccess
        {
            get
            {
                return VipAccess1;
            }

            set
            {
                VipAccess1 = value;
            }
        }

        public bool VipAccess1
        {
            get
            {
                return vipAccess;
            }

            set
            {
                vipAccess = value;
            }
        }

        public Corporate()
        {
            Company_name = "unknown";
            Discount_percentage = 0.10;
            Discount_amount = Charge * Discount_percentage;
            this.VipAccess = false;
            VIP_Cost1 = 0.0;
            Company_Contact1 = "unkown";
            Company_address1 = "unkown";
            Company_postcode1 = "unkown";
        }

        public Corporate(string cn, double dp, bool VIPA, double VIPC, string cc, string ca, string cp)
        {
            Company_name = cn;
            Discount_percentage = dp;
            this.VipAccess = VIPA;
            VIP_Cost1 = VIPC;
            Company_Contact1 = cc;
            Company_address1 = ca;
            Company_postcode1 = cp;
        }

        public Corporate(string cn, string pc, string ad)
        {
            Company_Contact1 = cn;
            Company_postcode1 = pc;
            Company_address1 = ad;
        }

        public Corporate(string company_name, double discount_percentage, double discount_amount, double vIP_Cost, string company_Contact, string company_address, string company_postcode)
        {
            this.company_name = company_name;
            this.discount_percentage = discount_percentage;
            this.discount_amount = discount_amount;
            VIP_Cost = vIP_Cost;
            Company_Contact = company_Contact;
            Company_address = company_address;
            Company_postcode = company_postcode;
        }

        //public override double Ticket_charge(double money)

        //{
        //return Charge - discount_amount + VIP_Cost;
        //}
    }
}
