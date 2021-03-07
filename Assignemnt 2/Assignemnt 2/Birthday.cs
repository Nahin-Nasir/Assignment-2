using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignemnt_2
{
    class Birthday
    {
        private int day;
        private int month;
        private int year;
        public Birthday(int day, int month, int year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }
        public int Day
        {
            set { this.day = value; }
            get { return this.day; }

        }
        public int Month
        {
            set { this.month = value; }
            get { return this.month; }
        }
        public int Year
        {
            set { this.year = value; }
            get { return this.year; }
        }
        public string GetBirthday()

        {
       

            {
                return this.day + "," + this.month + "," + this.year;

            }


            
        }

    }
}







