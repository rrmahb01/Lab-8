// Lab 8
// CIS 199-01
// Due: 4/19/2016
// By: Rakesh R. Mahbubani

// This program uses a class to detetmine if the user entered month, day, or year is within their respected interval. Each
// piece of information has its own button, forcing the user to update the date one step at a time. If the user enters a
// valid integer that is not in the required interval, then the user's information will be set to zero. The Date class has
// an override ToString property that will create a string in MM/DD/YYYY format.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab8
{
    public partial class DateForm : Form
    {
        // Sets default date to January 1st, 2000
        private Date myDate = new Date(1, 1, 2000);

        public DateForm()
        {
            InitializeComponent();
        }
        // Precondition: Valid month, day, or year must be entered in respected text box, and button is pushed
        // Postcondition: Date Label will be updated
        private void DateForm_Load(object sender, EventArgs e)
        {
            dateLbl.Text = myDate.ToString();
        }

        // Precondition: Int value entered in monthTxt
        // Postcondition: User input is sent through Date class
        private void monthBtn_Click(object sender, EventArgs e)
        {
            int month;
            if (int.TryParse(monthTxt.Text, out month))
            {
                myDate.Month = month;
                dateLbl.Text = myDate.ToString();
            }
            else // Displays message is valid integer isn't entered
                MessageBox.Show("Enter a valid month.");
        }

        // Precondition: Int value entered in datTxt
        // Postcondition: User input is sent through Date class
        private void dayBtn_Click(object sender, EventArgs e)
        {
            int day;
            if (int.TryParse(dayTxt.Text, out day))
            {
                myDate.Day = day;
                dateLbl.Text = myDate.ToString();
            }
            else // Displays message is valid integer isn't entered
                MessageBox.Show("Enter a valid day.");
        }

        // Precondition: Int value entered in yearTxt
        // Postcondition: User input is sent through Date class
        private void yearBtn_Click(object sender, EventArgs e)
        {
            int year;
            if (int.TryParse(yearTxt.Text, out year))
            {
                myDate.Year = year;
                dateLbl.Text = myDate.ToString();
            }
            else // Displays message is valid integer isn't entered
                MessageBox.Show("Enter a valid year.");
        }
    }
}
