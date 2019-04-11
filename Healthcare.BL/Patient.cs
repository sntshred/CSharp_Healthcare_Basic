using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentBasics.BL
{
    public class Patient
    {

        //To share property to all the instance of the class
        //This propety belongs to the class itself not the instance of the classes which you create
        public static int  Patient_Visit_Count { get; set; }

        public string Fullname
        {
            get
            {
                var tempname = Lastname;

                if (!string.IsNullOrWhiteSpace(Firstname))
                {
                    if (!string.IsNullOrWhiteSpace(tempname))
                    {
                        tempname += ", ";
                    }
                    tempname += Firstname;
                }
                return tempname;

            }

        }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int PatientId { get; private set; }

        public string EmailAddress { get; set; }



    }
}
