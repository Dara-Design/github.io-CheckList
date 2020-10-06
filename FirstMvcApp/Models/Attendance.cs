using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FirstMvcApp.Models
{
    public class Attendance
    {
        private static List<string> attendants = new List<string>();

        public static void AddAttendant(string attendantName)
        {
            if (attendants != null)
            {
                attendants.Add(attendantName);
            }
        }

        public static List<string> GetAttendants()
        {
            return attendants;
        }

    }
}