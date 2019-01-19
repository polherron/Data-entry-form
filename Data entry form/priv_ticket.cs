using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_entry_form
{
    class priv_ticket : League
    {

        private string employee_number;
        private double discount_percentage;
        private double discount_amount;
        private double vIP_Cost;
        private bool vIP_Access;
        private double vat;
        private string payment_method;
        private bool v;
        private object text;

        public string Employee_number
        {
            get
            {
                return employee_number;
            }

            set
            {
                employee_number = value;
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

        public double VIP_Cost
        {
            get
            {
                return vIP_Cost;
            }

            set
            {
                vIP_Cost = value;
            }
        }

        public bool VIP_Access
        {
            get
            {
                return vIP_Access;
            }

            set
            {
                vIP_Access = value;
            }
        }

        public double VAT
        {
            get
            {
                return vat;
            }

            set
            {
                vat = value;
            }
        }

        public string Payment_method
        {
            get
            {
                return payment_method;
            }

            set
            {
                payment_method = value;
            }
        }

        public bool V
        {
            get
            {
                return v;
            }

            set
            {
                v = value;
            }
        }

        public object Text
        {
            get
            {
                return text;
            }

            set
            {
                text = value;
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

        public priv_ticket()
        {
        }

        public priv_ticket(bool v, object text)
        {
            this.V = v;
            this.Text = text;
        }

        public priv_ticket(string ct, string fn, string sn, string ad, string pc)
        {
            Customer_title = ct;
            Customer_forename = fn;
            Customer_surname = sn;
            Customer_address = ad;
            Customer_postcode = pc;
        }

        public priv_ticket(int employee_number, double discount_percentage, double discount_amount, double vIP_Cost, bool vIP_Access, double vAT, string payment_method, bool v, object text) //: base(a, ch, team, sd, title, fn, sn, ad, pc, pn)
        {
            //this.Employee_number = employee_number;
            //this.Discount_percentage = discount_percentage;
            //this.Discount_amount = discount_amount;
            //VIP_Cost1 = vIP_Cost;
            //VIP_Access1 = vIP_Access;
            //VAT1 = vAT;
            //this.Payment_method = payment_method;
            //this.V = v;
            //this.Text = text;
        }

        public double calc_VAT(double money)
        {
            return this.vat = Charge * this.vat;
        }
        public override double Ticket_charge()
        {
            return Charge - Discount_amount + this.vat;
        }
 
    }
}
