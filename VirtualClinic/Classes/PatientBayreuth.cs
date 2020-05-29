using System;

namespace VirtualClinic.Classes
{
    class PatientBayreuth : Patient
    {
        public override void GetAppointment(Doctor doctor)
        {
            Console.WriteLine(this.GetType().Name + " is requesting appointment from " + doctor.GetType().Name);
        }
    }
}
