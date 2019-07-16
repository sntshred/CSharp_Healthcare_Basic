using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Healthcare.BL
{
    public class Patient
    {

        //To share property to all the instance of the class
        //This propety belongs to the class itself not the instance of the classes which you create
        public static int Patient_Visit_Count { get; set; }

        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int PatientId { get; private set; }

        public string EmailAddress { get; set; }

        public int PatientType { get; set; }

        public List<Address> PatientAddressList { get; set; }


        public Patient():this(0)
        {
           
        }
        public Patient(int patientId)
        {
            PatientId = patientId;
            PatientAddressList = new List<Address>();

        }
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
  

        public bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(Lastname))
            {
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(EmailAddress))
            {
                isValid = false;
            }

            return isValid;

        }

        public bool Save()
        {
            return true;
        }


        public override string ToString()
        {
            return Firstname;
        }

        //// /// <summary>
        //// /// Returns a patient with the VisitId
        //// /// </summary>
        //// /// <param name="VisitID"></param>
        //// /// <returns></returns>
        ////public Patient Retrieve(int VisitID)
        //// {
        ////     return new Patient();
        //// }

        //// /// <summary>
        //// /// Returns all the patients
        //// /// </summary>
        //// /// <param name="VisitID"></param>
        //// /// <returns></returns>
        //// public List<Patient> Retrieve()
        //// {
        ////     return new List<Patient>();
        //// }


    }
}
