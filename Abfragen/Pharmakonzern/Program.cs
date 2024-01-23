namespace Pharmakonzern
{
    internal class Program
    {
        public enum Status
        {
            Valid,
            Invalid
        }
        private static void Main(string[] args)
        {
            Medikament _m = new Medikament();

            IUserInput<float> verlustrate_in = new UserInput<float>(
                    () => float.Parse(Console.ReadLine()), // Parsing method for int input
                    "Bitte Verlustrate eingeben: ",
                    "Error while parsing float input");

            IUserInput<float> grenze_in = new UserInput<float>(
                    () => float.Parse(Console.ReadLine()), // Parsing method for int input
                    "Bitte Grenze eingeben: ",
                    "Error while parsing float input");

            float verlustrate = verlustrate_in.GetValidInput();
            float grenze = grenze_in.GetValidInput();

            _m.medikament(verlustrate, grenze);
        }
    }
}