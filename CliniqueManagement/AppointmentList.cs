using System;
using System.Collections.Generic;
using System.Text;

namespace NEW_OPPS_PROJECT.CliniqueManagement
{
    public class AppointmentList:Appointment
    {
        List<Appointment> appointments;

        public List<Appointment> Appointments { get => appointments; set => appointments = value; }
    }
}
