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
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    class Date
    {
        // Fields
        private int _month;
        private int _day;
        private int _year;

        // Month property
        public int Month
        {
            // Precondition: None
            // Postcondition: Retrives _month
            get { return _month; }

            // Precondition: (0,12]
            // Postcondition: Month is set to numeric value entered by user
            set
            {
                if (value > 0 && value <= 12)
                    _month = value;
            }
        }

        // Day property
        public int Day
        {
            // Precondition: None
            // Postcondition: Retrives _day
            get { return _day; }

            // Precondition: [0,31]
            // Postcondition: Day is set to numeric value entered by user
            set
            {
                if (value >= 0 && value <= 31) 
                _day = value;
            }
        }

        // Year property
        public int Year
        {
            // Precondition: None
            // Postcondition: Retrives _year
            get { return _year; }

            // Precondition: >= 0
            // Postcondition: Year is set to numberic value entered by user
            set
            {
                if (value >= 0) 
                    _year = value;
            }
        }

        // Constructor accepting three parameters
        public Date(int m, int d, int y)
        {
            Month = m;
            Day = d;
            Year = y;
        }

        // Precondition: None
        // Postcondition: Creates a string in MM/DD/YYYY format
        public override string ToString()
        {
            string result = Month.ToString("D2") + "/" + Day.ToString("D2") + "/" + Year.ToString("D4");
            return result;
        }
    }
}
