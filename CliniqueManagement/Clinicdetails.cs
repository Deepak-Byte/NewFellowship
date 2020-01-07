using System;
using System.Collections.Generic;
using System.Text;

namespace NEW_OPPS_PROJECT.CliniqueManagement
{
    public class Clinicdetails
    {
        private string doctorName;
        private string doctorId;
        private string doctorSapcialization;
        private string doctorAvailability;
        private string appointment;
        //private string patientAge;
        //private string patientContact;
        //private int patientID;
        //private string patientName;



        public string DoctorName { get => doctorName; set => doctorName = value; }
        public string DoctorId { get => doctorId; set => doctorId = value; }
        public string DoctorSapcialization { get => doctorSapcialization; set => doctorSapcialization = value; }
        public string DoctorAvailability { get => doctorAvailability; set => doctorAvailability = value; }
        public string Appointment { get => appointment; set => appointment = value; }
        //public string PatientName { get => patientName; set => patientName = value; }
        //public int PatientID { get => patientID; set => patientID = value; }
        //public string PatientContact { get => patientContact; set => patientContact = value; }
        //public string PatientAge { get => patientAge; set => patientAge = value; }



    }
}
