using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Healthcare.BL
{
  public  class PatientRepository
    {
        private AddressRepository addressRepository { get; set; }

        public PatientRepository()
        {
            addressRepository = new AddressRepository();
        }
        public Patient Retrieve(int VisitId)
        {
            Patient patient = new Patient(VisitId);

            if(VisitId == 101)
            {
                patient.EmailAddress = "john@email.com";
                patient.Firstname = "John";
                patient.Lastname = "Doe";
                patient.PatientAddressList = addressRepository.RetrieveByPatientId(1).ToList();
                
            }

            return patient;

        }

        

        public bool Save()
        {
            return true;
        }



    }
}
