using System;

namespace _08_PragueParkingDiskussion
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Phus = new string[100];
            while (true)
            {
                int menuSelection = Menu();
                switch (menuSelection)
                {
                    case 1:
                        ParkVehicle();
                        break;
                    case 99:
                        break;
                    default:
                        break;
                }
                //if (menuSelection == 99)
                //{
                //    break;
                //}
            }
            Console.WriteLine("Hello World!");
        }

        private static void ParkVehicle()
        {
            throw new NotImplementedException();
        }

        private static int Menu()
        {
            // Display menu on screen
            // Ask user for selection
            // Return menu selection
            return 1;       // Parkera ett fordon

            //return 99; // EXIT
        }

        bool Search(string regNumber, out int slotNumber)
        {
            bool found = false;
            // Loop through Phus looking for regNumber
            // Inside loop: set slotNumber = i when regNumber found
            slotNumber = 36;        // Sätts till det riktiga numret, förstås...

            // Inside loop: when regNumber found set found = true
            found = true;

            return found;
        }

        bool Search(char vehicleType, out int slotNumber)
        {
            // Loopa igenom Phus
            // titta på varje p-plats
            // Om p-plats är tom så är det klart - returnera sant och pplatsens nummer
            // Om fordonstyp = 'C' (för car)
            // Acceptera bara tomma platser

            // Om fordonstyp = 'M' (för MC)
            // Acceptera tomma platser
            // Acceptera även platser med en MC (kolla om pPlats innehåller "MC" men bara en (dvs inget "|")

            // Om vi kommer ända till slutet så är Phuset fullt. Returnera false
            slotNumber = -1;
            return false;
        }

        void ParkVehicle(string vehicleType, string regNummer, int slotNummer)
        {
            // bygger strängen "CAR#ABC123" och stoppar in den på rätt plats
        }
    }
}
