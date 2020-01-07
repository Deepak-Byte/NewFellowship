using System;
using System.Collections.Generic;
using System.Text;

namespace NEW_OPPS_PROJECT.CliniqueManagement
{
    public class PatientDetailsList: PatientsDetails
    {
        List<PatientsDetails> patientsDetails;

        public List<PatientsDetails> PatientsDetails { get => patientsDetails; set => patientsDetails = value; }
    }
}
