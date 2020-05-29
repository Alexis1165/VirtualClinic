namespace VirtualClinic.Classes
{
    class BayreuthFactory : ClinicFactory
    {
        public override Patient CreatePatient()
        {
            return new PatientBayreuth();
        }
        public override Doctor CreateDoctor()
        {
            return new DoctorBayreuth();
        }
    }
}
