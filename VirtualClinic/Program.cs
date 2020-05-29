using System;
using VirtualClinic.Classes;

namespace VirtualClinic
{
    class MainApp
    {
        public static void Main()
        {
            // Create and run the African animal world

            ClinicFactory bayreuth = new BayreuthFactory();
            Klinikum klinikum = new Klinikum(bayreuth);
            klinikum.RunHospital();

            // Create and run the American animal world

            ClinicFactory bamberg = new BambergFactory();
            klinikum = new Klinikum(bamberg);
            klinikum.RunHospital();

            // Wait for user input

            Console.ReadKey();
        }
    }
}