namespace VirtualClinic.Classes
{
    abstract class ClinicFactory
    {
        public abstract Patient CreatePatient();
        public abstract Doctor CreateDoctor();
    }
}
