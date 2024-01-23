using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmakonzern
{
    internal class Medikament
    {
        private enum Status
        {
            Valid,
            Invalid
        }

        public void medikament(float verlustrate, float grenze)
        {
            float wirkstoff = 1.0f;
            Status current_status = Status.Valid;

            for (byte monat = 1; wirkstoff >= grenze; monat++)
            {
                switch (current_status)
                {
                    case Status.Invalid:
                        break;
                    case Status.Valid:
                    default:
                        wirkstoff = wirkstoff * (1 - verlustrate);

                        if (wirkstoff <= 0.50)
                        {
                            current_status = Status.Invalid;
                        }
                        Console.WriteLine($"Monat: {monat} Wirkstoffgehalt: {wirkstoff * 100} Status: {current_status}");
                        break;
                }
            }
        }
    }
}
