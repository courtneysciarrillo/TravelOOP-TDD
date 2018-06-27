using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelOOP
{
    public class Travel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }

        public Travel()
        {

        }

        public string GetDate(int month, int day, int year)
        {
            string date = month + "/" + day + "/" + year;
            return date;
        }

        public int TtlTravel(int month, int day, int year)
        {
            return 5;
        }

        public string GetSelection(int number)
        {
            switch (number)
            {
                case 0:
                    return "Stay Home";
                case 1:
                    return "Put in Bay";
                case 2:
                    return "Nashville";
                case 3:
                    return "Florida";
                case 4:
                    return "Georgia";
                case 5:
                    return "Cali";
                case 6:
                    return "The World is Yours";
                default:
                    return "";
            }
        }
    }
}
