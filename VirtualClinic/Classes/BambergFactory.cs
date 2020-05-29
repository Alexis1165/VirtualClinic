namespace VirtualClinic.Classes
{
    class BambergFactory : ClinicFactory
    {
        public override Patient CreatePatient()
        {
            return new PatientBamberg();
        }
        public override Doctor CreateDoctor()
        {
            return new DoctorBamberg();
        }
    }
}
