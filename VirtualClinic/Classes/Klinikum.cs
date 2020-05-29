namespace VirtualClinic.Classes
{
    class Klinikum
    {
        private readonly Patient _patient;
        private readonly Doctor _doctor;

        public Klinikum(ClinicFactory factory)
        {
            _doctor = factory.CreateDoctor();
            _patient = factory.CreatePatient();
        }

        public void RunHospital()
        {
            _doctor.Treat(_patient);
            _patient.GetAppointment(_doctor);
        }
    }
}
