using System;
using VirtualClinic.Classes;

namespace VirtualClinic
{
    class MainApp
    {
        public static void Main()
        {
            ClinicFactory bayreuth = new BayreuthFactory();
            Klinikum klinikum = new Klinikum(bayreuth);
            klinikum.RunHospital();

            ClinicFactory bamberg = new BambergFactory();
            klinikum = new Klinikum(bamberg);
            klinikum.RunHospital();

            Console.ReadKey();
        }
    }
}