namespace Kredito
{
    internal class Program
    {
        public enum Status
        {
            Debt,
            No_Debt
        }
        private static void Main(string[] args)
        {
            IUserInput<float> saldo_in = new UserInput<float>(
                    () => float.Parse(Console.ReadLine()), // Parsing method for int input
                    "Bitte Saldo eingeben: ",
                    "Error while parsing float input");

            IUserInput<float> zins_in = new UserInput<float>(
                    () => float.Parse(Console.ReadLine()), // Parsing method for int input
                    "Bitte Zins eingeben: ",
                    "Error while parsing float input");

            IUserInput<float> rate_in = new UserInput<float>(
                    () => float.Parse(Console.ReadLine()), // Parsing method for int input
                    "Bitte Rate eingeben: ",
                    "Error while parsing float input");

            float saldo = saldo_in.GetValidInput();
            float zins = zins_in.GetValidInput();
            float rate = rate_in.GetValidInput();

            kredit(saldo, zins, rate);
        }
        private static void kredit(float saldo, float zins, float rate)
        {
            Status current_status = Status.Debt;
            float gesamtsumme = 0;

            for (byte monat = 1; saldo >= 0.0f; monat++)
            {
                switch (current_status)
                {
                    case Status.No_Debt:
                        break;
                    case Status.Debt:
                    default:
                        saldo = (saldo + (zins * saldo)) - rate;

                        if (saldo <= 0.0f)
                        {
                            current_status = Status.No_Debt;
                            gesamtsumme = (monat * rate) + saldo;
                            saldo = 0;
                        }
                        Console.WriteLine($"Monat: {monat} Saldo: {saldo} Gesamtsumme: {gesamtsumme} Status: {current_status}");
                        break;
                }
            }
        }

        private static void spare_geld(float startbetrag, float zielsumme)
        {
            float zinssatz = 0.0f;
            if (startbetrag < zielsumme &&
                startbetrag >= 3000.0f &&
                startbetrag <= 5000.0f)
            {
                switch (startbetrag)
                {
                    case float n when (n >= 3000.0f && n <= 5000.0f):
                        zinssatz = 0.03f;
                        break;
                    case float n when (n >= 5000.0f && n <= 10000.0f):
                        zinssatz = 0.035f;
                        break;
                    case float n when (n >= 10000.0f && n <= 20000.0f):
                        zinssatz = 0.04f;
                        break;
                    case float n when (n >= 20000.0f):
                        zinssatz = 0.05f;
                        break;
                }
            }
            else
            {
                Console.WriteLine("ERROR");
            }
        }
    }
}