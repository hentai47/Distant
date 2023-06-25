using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DateTime today = DateTime.Now;
        MessageBox.Show(today.Date.ToLongDateString());

private void butDateTime_Click(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            af.Items.Clear();
            af.Items.Add("d: " + dt.ToString("d"));
            af.Items.Add("D: " + dt.ToString("D"));
            af.Items.Add("f: " + dt.ToString("f"));
            af.Items.Add("F: " + dt.ToString("F"));
            af.Items.Add("g: " + dt.ToString("g"));
            af.Items.Add("G: " + dt.ToString("G"));
            af.Items.Add("m: " + dt.ToString("m"));
            af.Items.Add("r: " + dt.ToString("r"));
            af.Items.Add("s: " + dt.ToString("s"));
            af.Items.Add("u: " + dt.ToString("u"));
            af.Items.Add("U: " + dt.ToString("U"));
            af.Items.Add("y: " + dt.ToString("y"));
            af.Items.Add("MMMM dd: " + dt.ToString("MMMM dd"));
            af.Items.Add("MM/dd/yyyy: " + dt.ToString("MM/dd/yyyy"));
            af.Items.Add("MM/dd/yyyy HH:mm: " +
            dt.ToString("MM/dd/yyyy HH:mm"));
            af.Items.Add("MM/dd/yyyy hh:mm tt: " +
            dt.ToString("MM/dd/yyyy hh:mm tt"));
            af.Items.Add("MM/dd/yyyy H:mm: " +
            dt.ToString("MM/dd/yyyy H:mm"));
            af.Items.Add("MM/dd/yyyy h:mm tt: " +
            dt.ToString("MM/dd/yyyy h:mm tt"));
            af.Items.Add("MM/dd/yyyy HH:mm:ss: " +
            dt.ToString("MM/dd/yyyy HH:mm:ss"));

            af.Items.Add("dddd, dd MMMM yyyy: " +
            dt.ToString("dddd, dd MMMM yyyy"));
            af.Items.Add("dddd, dd MMMM yyyy HH:mm:ss: " +
            dt.ToString("dddd, dd MMMM yyyy HH:mm:ss"));
            af.Items.Add("ddd, dd MMM yyyy HH':'mm':'ss 'GMT': " +
            dt.ToString("ddd, dd MMM yyyy HH':'mm':'ss 'GMT'"));

            af.Items.Add("yyyy'-'MM'-'dd'T'HH':'mm':'ss.fffffffK: " +
            dt.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss.fffffffK"));
            af.Items.Add("yyyy'-'MM'-'dd'T'HH':'mm':'ss: " +
            dt.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss"));
            af.Items.Add("yyyy MMMM: " + dt.ToString("yyyy MMMM"));
            af.Items.Add("H:mm: " + dt.ToString("H:mm"));
            af.Items.Add("HH:mm: " + dt.ToString("HH:mm"));
            af.Items.Add("HH:mm:ss: " + dt.ToString("HH:mm:ss"));
            af.Items.Add("h:mm tt: " + dt.ToString("h:mm tt"));
            af.Items.Add("hh:mm tt: " + dt.ToString("hh:mm tt"));
        }
        DateTime curdate = DateTime.Now;
        DateTime mydate = curdate.AddDays(7);
        MessageBox.Show(mydate.ToShortDateString());

using Microsoft.VisualBasic
private void butDateDiffVB_Click(object sender, EventArgs e)
        {
            DateTime date1 = new DateTime(1945, 5, 9);
            DateTime date2 = new DateTime(2007, 8, 21);
            long diff = DateAndTime.DateDiff(DateInterval.Day, date1, date2,
            FirstDayOfWeek.Monday, FirstWeekOfYear.System);
            this.Text = diff.ToString();
        }

        public static int DaysDiff(DateTime date1, DateTime date2)
        {
            return date1.Subtract(date2.Date).Days;
        }
        private void butDateDiffCS_Click(object sender, EventArgs e)
        {
            string howdays = DaysDiff(DateTime.Today,
            new DateTime(1966, 07, 27)).ToString();
            System.Windows.Forms.MessageBox.Show("Со дня моего дня рождения прошло: " + howdays);
        }

        bool leapYear = DateTime.IsLeapYear(DateTime.Now.Year);
        MessageBox.Show(
         String.Format("{0} является високосным годом: {1}",
 DateTime.Now.Year, leapYear));
    }
}
