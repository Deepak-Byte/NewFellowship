using System;
using System.Collections.Generic;
using System.Text;

namespace NEW_OPPS_PROJECT.CliniqueManagement
{
    public class Appointment
    {
        private string doctorName;
        private string doctorAvilability;
        private string patientName;
        private string patientNumber;
        private string meetingDate;

        public string DoctorName { get => doctorName; set => doctorName = value; }
        public string DoctorAvilability { get => doctorAvilability; set => doctorAvilability = value; }
        public string PatientName { get => patientName; set => patientName = value; }
        public string PatientNumber { get => patientNumber; set => patientNumber = value; }
        public string MeetingDate { get => meetingDate; set => meetingDate = value; }
    }
}
