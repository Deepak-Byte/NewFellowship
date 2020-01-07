using Nancy.Json;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using NEW_OPPS_PROJECT.CliniqueManagement;

namespace NEW_OPPS_PROJECT.CliniqueManagement
{
    public class CliniqueManagementclass
    {
        JavaScriptSerializer jscript = new JavaScriptSerializer();
        List<Clinicdetails> list = new List<Clinicdetails>();
        List<PatientsDetails> patientlist = new List<PatientsDetails>();
        List<Appointment> appointmentslist = new List<Appointment>();
        //Clinicdetails Clinicdetails = new Clinicdetails();
        //Clinicdetailslist clinicdetailslist = new Clinicdetailslist();
        public void WelcometoHospital()
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("1: ARE YOU DOCTOR THAN PRESS '1'\n2: ARE YOU PATIENT THAN PRESS '2' \n3: TO EXIT A PROGRAM\n");
                int userinput = int.Parse(Console.ReadLine());
                switch (userinput)
                {
                    case 1:
                        DoctorDetails();
                        break;
                    case 2:
                        Addpatient();
                        break;
                    case 3:
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("WRONG INPUT ENTERED TRY AGAIN");
                        break;
                }
            }
        }
        public void DoctorDetails()
        {
            try
            {
                bool flag = true;
                while (flag)
                {
                    Console.WriteLine("1: DO YOU WANT TO SEARCH FOR DOCTOR\n2: DO YOU WANT TO ADD NEW DOCTOR DETAILS\n3: DO YOU WANT TO CHECK YOUR APPOINTS\n4: TO EXIT THE PROGRAM");
                    int userinput = int.Parse(Console.ReadLine());
                    switch (userinput)
                    {
                        case 1:
                            Console.WriteLine("ENTER NAME OF DOCTOR || ID || SPACIALITY || AVALABILITY IN THIS FORMAT ONLY (1:00 PM TO 12:00 PM)");
                            string nameorid = Console.ReadLine();
                            SearchDoctor(nameorid);
                            break;
                        case 2:
                            Console.WriteLine("ENTER NAME OF DOCTOR");
                            string doctorname = Console.ReadLine();
                            Console.WriteLine("ENTER AT WHAT ID NUMBER YOU WANT TO GIVE HIM/HER");
                            string idnumber = Console.ReadLine();
                            Console.WriteLine("ENTER IT'S SPACIALITY");
                            string spacciality = Console.ReadLine();
                            Console.WriteLine("ENTER IT'S AVALABILITY IN THIS FORMAT ONLY =>1:00 AM TO 12:00 AM<= ");
                            string datatime = Console.ReadLine();
                            Adddoctor(doctorname, idnumber, spacciality, datatime, null);
                            break;
                        case 3:
                            CheckDoctoravailability();
                            break;
                        case 4:
                            flag = false;
                            break;
                        default:
                            Console.WriteLine("YOU ARE PASSING WRONG INPUT");
                            break;
                    }
                }
            }
            catch (FormatException FormatException)
            {
                Console.WriteLine(FormatException.Message);
            }
        }

        private void CheckDoctoravailability()
        {
            Console.WriteLine("DR. PLEASE ENTER YOUR NAME ");
            string doctorname = Console.ReadLine();
            string jsondata = AppoinetmentJson();
            appointmentslist = jscript.Deserialize<List<Appointment>>(jsondata);
            Console.WriteLine("YOU HAVE APPOINTMENT WITH FOLLOWING PEOPLE\n");
            foreach (var item in appointmentslist)
            {
                if (doctorname.Equals((item.DoctorName), StringComparison.InvariantCultureIgnoreCase))
                {
                    Console.WriteLine("------------------------------------------------------------------------");
                    Console.WriteLine("PATIENT NAME ->"+item.PatientName);
                    Console.WriteLine("PATIENT NUMBER ->"+item.PatientNumber);
                    Console.WriteLine("MEETING DATE WITH PATIENT ->"+item.MeetingDate);
                    Console.WriteLine("------------------------------------------------------------------------\n");
                }
            }

        }

        private void Adddoctor(string doctorname, string idnumber, string spacciality, string datatime, string appointment)
        {
            string jsondata = System.IO.File.ReadAllText(@"C:\Users\admin\source\repos\NEW OPPS PROJECT\NEW OPPS PROJECT\CliniqueManagement\Doctor.json");
            list = jscript.Deserialize<List<Clinicdetails>>(jsondata);

            list.Add(new Clinicdetails()
            {
                DoctorName = doctorname,
                DoctorId = idnumber,
                DoctorSapcialization = spacciality,
                DoctorAvailability = datatime,
                Appointment = appointment
            });
            jsondata = JsonConvert.SerializeObject(list);
            System.IO.File.WriteAllText(@"C:\Users\admin\source\repos\NEW OPPS PROJECT\NEW OPPS PROJECT\CliniqueManagement\Doctor.json", jsondata);
            Console.WriteLine("NEW DOCTOR DETAILS AADED SUCCESFULLY");
        }

        public string SearchDoctor(string nameId)
        {
            string name = "";
            string avilability = "";
            string jsondata = System.IO.File.ReadAllText(@"C:\Users\admin\source\repos\NEW OPPS PROJECT\NEW OPPS PROJECT\CliniqueManagement\Doctor.json");
            list = jscript.Deserialize<List<Clinicdetails>>(jsondata);
            foreach (var item in list)
            {
                if (nameId.Equals((item.DoctorName), StringComparison.InvariantCultureIgnoreCase) || nameId.Equals(item.DoctorId) || nameId.Equals((item.DoctorSapcialization), StringComparison.InvariantCultureIgnoreCase) || nameId.Equals(item.DoctorAvailability))
                {
                    Console.WriteLine("\n\nDOCTOR NAME : {0}\nDOCTOR ID NUMBER : {1}\nDOCTOR Sapcialization : {2}\nDOCTOR Availability : {3}"
                                           , item.DoctorName,
                                            item.DoctorId,
                                            item.DoctorSapcialization,
                                            item.DoctorAvailability);
                    Console.WriteLine("\n\n");
                    name = item.DoctorName;
                    avilability = item.DoctorAvailability;
                }
            }
            return  name + "_" + avilability;
        }

        public void Addpatient()
        {
            try
            {
                bool flag = true;
                while (flag)
                {
                    Console.WriteLine("1: IF YOU ARE NEW PATEIENT TO TAKE APPOINTMENT\n2: IF YOU ARE ALLREADY VISITED HSRE WANT TO TAKE APPOINTMENT\n3:  IF WANT TO EXIT THIS PAGE\n");
                    int useriput = int.Parse(Console.ReadLine());
                    switch (useriput)
                    {
                        case 1:
                            Console.WriteLine("ENTER THE NAME OF PATIENT ");
                            string patientname = Console.ReadLine();
                            Console.WriteLine("ENTER PATIENT CONTACT NUMBER");
                            string patientnumber = Console.ReadLine();
                            Console.WriteLine("ENTER PATIENT AGE");
                            string patientage = Console.ReadLine();
                            AddnewPatient(patientname, patientnumber, patientage);
                            break;
                        case 2:
                            ExitingPatient();
                            break;
                        case 3:
                            flag = false;
                            break;
                        default:
                            Console.WriteLine("WRONG INPUT ENTERED BY YOU");
                            break;

                    }
                }
            }
            catch (FormatException FormatException)
            {
                Console.WriteLine(FormatException.Message);
            }
        }

        private void ExitingPatient()
        {
            try
            {
                Console.WriteLine("ENTER THE NAME OF PATIENT\n");
                string patientname = Console.ReadLine();
                Console.WriteLine("ENTER PATIENT CONTACT NUMBER\n");
                string patientnumber = Console.ReadLine();
                Console.WriteLine("BUY WHAT METHOD YOU WANT TO SEARCH FOR DOCTOR AS PAR GIVEN BELOW\n");
                Console.WriteLine("ENTER NAME OF DOCTOR |OR| ID |OR| SPACIALITY |OR| AVALABILITY IN THIS FORMAT ONLY (1:00 PM TO 12:00 PM)\n");
                string nameorid = Console.ReadLine();

                string nameid = SearchDoctor(nameorid);
                string[] words = nameid.Split('_');
                string doctorname = words[0];
                string doctoravilability = words[1];
                Appointmentforpatient(patientname, patientnumber, doctorname, doctoravilability);
            }
            catch(FormatException FormatException)
            {
                Console.WriteLine(FormatException.Message); 
            }
        }

        public void AddnewPatient(string patientname,string patientnumber, string patientage)
        {
            try
            {
                int available = 0;
                string jsondata = AppoinetmentJson();
                patientlist = jscript.Deserialize<List<PatientsDetails>>(jsondata);
                foreach (var item in patientlist)
                {
                    available = item.PatientID;
                }
                patientlist.Add(new PatientsDetails()
                {
                    PatientName = patientname,
                    PatientID = available + 1,
                    PatientContact = patientnumber,
                    PatientAge = patientage,
                });
                jsondata = JsonConvert.SerializeObject(patientlist);
                System.IO.File.WriteAllText(@"C:\Users\admin\source\repos\NEW OPPS PROJECT\NEW OPPS PROJECT\CliniqueManagement\Patient.json", jsondata);
                Console.WriteLine("\nYOU ARE SUCCESFULLY GET ADDED INTO PATIENT LIST\n");
                Console.WriteLine("BUY WHAT METHOD YOU WANT TO SEARCH FOR DOCTOR AS PAR GIVEN BELOW\n");
                Console.WriteLine("ENTER NAME OF DOCTOR || ID || SPACIALITY || AVALABILITY IN THIS FORMAT ONLY (1:00 PM TO 12:00 PM)\n");
                string nameorid = Console.ReadLine();

                string nameid = SearchDoctor(nameorid);
                string[] words = nameid.Split('_');
                string doctorname = words[0];
                string doctoravilability = words[1];
                Console.WriteLine("IF WANT TO CONFERM YOUR APPOINTMENT WITH HIM || HER THAN PRESS 'Y' OR 'y' \n");
                char userinput = char.Parse(Console.ReadLine());
                Appointmentforpatient(patientname, patientnumber, doctorname, doctoravilability);
            }
            catch (FormatException FormatException)
            {
                Console.WriteLine(FormatException.Message);
            }
        }

        public void Appointmentforpatient(string patientname, string patientnumber, string doctorname, string doctoravilability)
        {
            bool flag = CheckAvailability(doctorname);
            if (flag == true)
            {
                DateTime todaydate = DateTime.Now;
                string date = todaydate.GetDateTimeFormats('d')[0];
                string jsondata = AppoinetmentJson();
                appointmentslist = jscript.Deserialize<List<Appointment>>(jsondata);
                appointmentslist.Add(new Appointment()
                {
                    DoctorName = doctorname,
                    DoctorAvilability = doctoravilability,
                    PatientName = patientname,
                    PatientNumber = patientnumber,
                    MeetingDate = date
                });
                jsondata = JsonConvert.SerializeObject(appointmentslist);
                System.IO.File.WriteAllText(@"C:\Users\admin\source\repos\NEW OPPS PROJECT\NEW OPPS PROJECT\CliniqueManagement\Appointment.json", jsondata);
                Console.WriteLine("YOUR APPOINTMENT GET FIXED ON " + date + " WITH " + doctorname + " SEE YOU THAT DAY ABHI KE LIYE NIKAL LE \n");
            }
            else
            {
                Console.WriteLine("YOU ARE NOT ELIGIBLE FOR DATE SELECT ANTHOR DATE");
            }
        }

        public bool CheckAvailability(string doctorname)
        {
            int count = 0; 
            string jsondata = AppoinetmentJson();
            appointmentslist = jscript.Deserialize<List<Appointment>>(jsondata);
            foreach (var item in appointmentslist)
            {
                if (doctorname.Equals((item.DoctorName), StringComparison.InvariantCultureIgnoreCase))
                {
                    count++;
                }
            }
            if (count > 5)
            {
                return false;
            }
            return true;
        }

        //public string PatientJson()
        //{
        //    return ;
        //}
        //public string DoctorJson()
        //{

        //}
        public string AppoinetmentJson()
        {
            string Appointmentjson = System.IO.File.ReadAllText(@"C:\Users\admin\source\repos\NEW OPPS PROJECT\NEW OPPS PROJECT\CliniqueManagement\Appointment.json");
            return Appointmentjson;
        }
    }
}
