/*
 * John Hopson
 * Program 3
 * 5 April 2016
 * CIS 199-75
 * A modified version of the registration program that takes input from the
 * user and determines their earliest date and time of registration based
 * on their year in school and the first letter of their last name based on
 * the UofL Fall/Summer 2016 Priority Registration Schedule.
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Prog2
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        public void findRegTimeBtn_Click(object sender, EventArgs e)
        {
            const float SENIOR_HOURS = 90;    // Min hours for Senior
            const float JUNIOR_HOURS = 60;    // Min hours for Junior
            const float SOPHOMORE_HOURS = 30; // Min hours for Sophomore

            const string DAY1 = "March 30";  // 1st day of registration
            const string DAY2 = "March 31";  // 2nd day of registration
            const string DAY3 = "April 1";   // 3rd day of registration
            const string DAY4 = "April 4";   // 4th day of registration
            const string DAY5 = "April 5";   // 5th day of registration
            const string DAY6 = "April 6";   // 6th day of registration

            const string TIME1 = "8:30 AM";  // 1st time block
            const string TIME2 = "10:00 AM"; // 2nd time block
            const string TIME3 = "11:30 AM"; // 3rd time block
            const string TIME4 = "2:00 PM";  // 4th time block
            const string TIME5 = "4:00 PM";  // 5th time block

            string lastNameStr;       // Entered last name
            char lastNameLetterCh;    // First letter of last name, as char
            string dateStr = "Error"; // Holds date of registration
            string timeStr = "Error"; // Holds time of registration
            float creditHours;        // Entered credit hours
            bool found = false;       // Holds whether the hours were found
            

            if (float.TryParse(creditHrTxt.Text, out creditHours) && creditHours >= 0) // Valid hours
            {
                lastNameStr = lastNameTxt.Text;
                if (lastNameStr.Length > 0) // Empty string?
                {
                    lastNameStr = lastNameStr.ToUpper(); // Ensure upper case
                    lastNameLetterCh = lastNameStr[0];   // First char of last name

                    if (char.IsLetter(lastNameLetterCh)) // Is it a letter?
                    {
                        // Juniors and Seniors share same schedule but different days
                        if (creditHours >= JUNIOR_HOURS)
                        {
                            if (creditHours >= SENIOR_HOURS)
                                dateStr = DAY1;
                            else // Must be juniors
                                dateStr = DAY2;
                            //
                            char[] upperClassLowerLetterArray = { 'D', 'I', 'O', 'S', 'Z' };
                            string[] timeArray = { TIME5, TIME1, TIME2, TIME3, TIME4, };
                            //
                            for (int index = 0; index < upperClassLowerLetterArray.Length && !found; index++)
                            {
                                if (lastNameLetterCh <= upperClassLowerLetterArray[index])
                                {
                                    timeStr = timeArray[index];
                                    found = true;
                                }
                            }
                        }
                        // Sophomores and Freshmen
                        else // Must be soph/fresh
                        {
                            if (creditHours >= SOPHOMORE_HOURS)
                            {
                                // E-Q on one day
                                if ((lastNameLetterCh >= 'E') && // >= E and
                                    (lastNameLetterCh <= 'Q'))   // <= Q
                                    dateStr = DAY3;
                                else // All other letters on next day
                                    dateStr = DAY4;
                            }
                            else // must be freshman
                            {
                                // E-Q on one day
                                if ((lastNameLetterCh >= 'E') && // >= E and
                                    (lastNameLetterCh <= 'Q'))   // <= Q
                                    dateStr = DAY5;
                                else // All other letters on next day
                                    dateStr = DAY6;
                            }
                            //
                            char[] lowerClassLowerLetterArray = { 'B', 'D', 'F', 'I', 'L', 'O', 'Q', 'S', 'V', 'Z' };
                            string[] timeArray = { TIME4, TIME5, TIME1, TIME2, TIME3, TIME4, TIME5, TIME1, TIME2, TIME3 };
                            //
                            for (int index = 0; index < lowerClassLowerLetterArray.Length && !found; index++)
                            {
                                if (lastNameLetterCh <= lowerClassLowerLetterArray[index])
                                {
                                    timeStr = timeArray[index];
                                    found = true;
                                }
                            }
                        }

                        // Output results
                        dateTimeLbl.Text = dateStr + " at " + timeStr;
                    }
                    else // First char not a letter
                        MessageBox.Show("Enter valid last name!");
                }
                else // Empty textbox
                    MessageBox.Show("Enter a last name!");
            }
            else // Can't parse credit hours
                MessageBox.Show("Please enter valid credit hours earned!");
        }

        private void text_Change(object sender, EventArgs e)
        {
            //Clears the output label whenever the text in the text boxes is changed
            dateTimeLbl.Text = "";
        }
    }
}