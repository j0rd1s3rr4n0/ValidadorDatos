using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidadorDadesJson
{
    public class persona
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Gender { get; set; }
        public string Company { get; set; }
        public string Email { get; set; }
        public string Country { get; set; }
        public string Dni { get; set; }

        public bool comprova_dni()
        {
            if (Dni.Length != 9)
                return false;

            int dniNumber;
            if (!int.TryParse(Dni.Substring(0, 8), out dniNumber))
                return false;

            char expectedLetter = calcula_lletra(dniNumber);
            return expectedLetter == Dni[8];
        }

        public bool comprova_nom()
        {
            return !string.IsNullOrWhiteSpace(Name);
        }

        public bool comprova_mail()
        {
            if (string.IsNullOrWhiteSpace(Email))
                return false;

            if (!Email.Contains("@"))
                return false;

            if (Email[0] == '@' || Email[Email.Length - 1] == '@')
                return false;

            return true;
        }

        private char calcula_lletra(int dniNumber)
        {
            string letters = "TRWAGMYFPDXBNJZSQVHLCKE";
            int index = dniNumber % 23;
            return letters[index];
        }
    }
}