using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; // for TextBox

namespace groupProject
{
    //This File is used for data validation, Jan 21,2016 by Alexandre Terekhov
    public static class Validator
    {
        // checks if text box is not empty
        public static bool IsPresent(TextBox tb)
        {
            if (tb.Text != "")
            {
                return true;
            }
            else
            {
                MessageBox.Show(tb.Tag + " input is required", "Input Error");
                tb.Focus();
                return false;
            }
        }
        public static bool IsPresent(ComboBox cb)
        {
            if (cb.Text != "")
            {
                return true;
            }
            else
            {
                MessageBox.Show(cb.Tag + " input is required", "Input Error");
                cb.Focus();
                return false;
            }
        }

        // checks if text box contains decimal number
        public static bool IsDecimal(TextBox tb)
        {
            decimal num; // auxillary for trying to parse
            if (Decimal.TryParse(tb.Text, out num))
            {
                return true;
            }
            else
            {
                
                MessageBox.Show(tb.Tag + " has to be decimal value", "Input Error");
                tb.Focus();
                return false;
            }
        }

        public static bool IsInteger(TextBox tb)
        {
            Int32 num; // auxillary for trying to parse
            if (Int32.TryParse(tb.Text, out num))
            {
                return true;
            }
            else
            {

                MessageBox.Show(tb.Tag + " has to be Integer value", "Input Error");
                tb.Focus();
                return false;
            }
        }
        public static bool IsInteger(ComboBox cb)
        {
            Int32 num; // auxillary for trying to parse
            if (Int32.TryParse(cb.Text, out num))
            {
                return true;
            }
            else
            {

                MessageBox.Show(cb.Tag + " has to be Integer value", "Input Error");
                cb.Focus();
                return false;
            }
        }

        // checks if decimal value in text box is within range from min to max
        public static bool IsWithinRange(TextBox tb, decimal min, decimal max)
        {
            
            decimal value = Convert.ToDecimal(tb.Text);
            if (value >= min && value <= max)
            {
                return true;
            }
            else
            {
                MessageBox.Show(tb.Tag + " must be within range " + min + ".." + max,
                                "Input Error");
                tb.Focus();
                return false;
            }
        }
        public static bool CompareValues(TextBox tmin, TextBox tmax)
        {

            string valuemin = tmin.Text;

            decimal n1 = decimal.Parse(valuemin,NumberStyles.Currency);    

            string valuemax =tmax.Text;

            decimal n2 = decimal.Parse(valuemax, NumberStyles.Currency);

            if (n2 < n1)
            {
                MessageBox.Show(tmin.Tag + " must be smaller than " + tmax.Tag + "..", "Input Error");
                return false;
            }
            else
                return true;
        }
        public static bool CompareDates(DateTime tmin, DateTime tmax)
        {
            int dateLaterThan = DateTime.Compare(tmax, tmin);
            if (dateLaterThan < 0)
            {
                MessageBox.Show("the Package End Date must be later than Package Start Date", "Input Error");
                return false;
            }
            else
                return true;            
        }

        internal static bool IsPresent(decimal kwh)
        {
            throw new NotImplementedException();
        }
        
    } }