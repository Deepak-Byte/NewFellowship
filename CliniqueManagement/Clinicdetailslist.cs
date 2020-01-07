using System;
using System.Collections.Generic;
using System.Text;

namespace NEW_OPPS_PROJECT.CliniqueManagement
{
    public class Clinicdetailslist:Clinicdetails
    {
        List<Clinicdetails> cliniclist;
        public List<Clinicdetails> Cliniclist { get => cliniclist; set => cliniclist = value; }
    }
}
