using System;

namespace VirtualClinic.Classes
{
    class DoctorBamberg : Doctor
    {
        public override void Treat(Patient patient)
        {
            Console.WriteLine(this.GetType().Name + " is treating " + patient.GetType().Name);
        }
    }
}
