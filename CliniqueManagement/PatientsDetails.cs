using System;
using System.Collections.Generic;
using System.Text;

namespace NEW_OPPS_PROJECT.CliniqueManagement
{
    public class PatientsDetails
    {
        private string patientName;
        private int patientID;
        private string patientContact;
        private string patientAge;

        public string PatientName { get => patientName; set => patientName = value; }
        public int PatientID { get => patientID; set => patientID = value; }
        public string PatientContact { get => patientContact; set => patientContact = value; }
        public string PatientAge { get => patientAge; set => patientAge = value; }



    }
}
