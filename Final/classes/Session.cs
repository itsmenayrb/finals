using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Final.classes
{
    public static class Session
    {
        //general
        public static int id { get; set; }
        public static string username { get; set; }
        public static string userType { get; set; }

        public static string first_name { get; set; }
        public static string middle_name { get; set; }
        public static string last_name { get; set; }
        public static byte[] profile_picture { get; set; }

        //student
        public static int course { get; set; }
        public static string year_level { get; set; }
        public static string status { get; set; }

        //employee
        public static int department { get; set; }
        public static int position { get; set; }

        //machine
        public static string machine_name { get; set; }
        public static string type { get; set; }
        public static string location { get; set; }
        public static string ip_address { get; set; }
        public static int port { get; set; }
        public static string mac_address { get; set; }
        public static string localaccountinformation_username { get; set; }
        public static string localaccountinformation_password { get; set; }
        public static string machine_status { get; set; }

        //current academic year
        public static int academic_year_id { get; set; }
        public static string semester { get; set; }
        public static string academic_year { get; set; }
    }
}
