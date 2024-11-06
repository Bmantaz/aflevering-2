namespace Variabler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Velkommen til ENDNU, en dejlig Quiz!");
            Console.WriteLine(" ");
            Console.WriteLine("Tryk på space-tasten for at fortsætte...");

            //tast indtil space-tasten er trykket
            while (true)
            {
                // Vent på et tastetryk
                var key = Console.ReadKey(true);

                // Hvis det er space-tasten, kører koden videre
                if (key.Key == ConsoleKey.Spacebar)
                {
                    break;
                }
            }

            Console.WriteLine("Spørgsmål 1");
            Console.WriteLine("Hvad er dit fornavn?");
            String fornavn = Console.ReadLine();
            Console.WriteLine("Okay");


            Console.WriteLine("Spørgsmål 2");
            Console.WriteLine("Hvad er dit efternavn?");
            String efternavn = Console.ReadLine();
            Console.WriteLine("Hej " + fornavn + " " + efternavn + ". ");
            Console.WriteLine(" ");


            Console.WriteLine("Spørgsmål 3");
            Console.WriteLine("Hvad er dit fødselsår?");
            string input = Console.ReadLine(); // Læser brugerens input fra tastaturet og gemmer det som en tekst (string)
            int fødselsår = int.Parse(input); // Konverterer brugerens input (tekst) til et heltal (int), så vi kan regne med det
            int alder = 2024 - fødselsår;    // Beregner brugerens alder ved at trække fødselsåret fra året 2024
            Console.WriteLine("Så du må være " + alder + " år gammel"); // Udskriver resultatet, som fortæller brugeren, hvor gammel de er
            Console.WriteLine(" ");

            Console.WriteLine("Spørgsmål 3");
            Console.WriteLine("Dette er et Ja/Nej spørgsmål");

            bool gyldigtSvar = false; // Holder styr på, om vi har fået et gyldigt svar
            bool ja = false; // Erklæres én gang uden for løkken

            while (!gyldigtSvar) // Gentager spørgsmålet, indtil der er et gyldigt svar
            {
                Console.WriteLine("Vil du gerne være softwareudvikler?");
                string svar = Console.ReadLine().ToLower();

                if (svar == "ja")
                {
                    ja = true;
                    Console.WriteLine("Fantastisk! Det er et spændende felt med mange muligheder.");
                    gyldigtSvar = true; // Sætter gyldigtSvar til true, så vi kan afslutte løkken
                }
                else if (svar == "nej")
                {
                    ja = false;
                    Console.WriteLine("Det er helt fint! Der er mange andre spændende karriereveje.");
                    gyldigtSvar = true; // Sætter gyldigtSvar til true, så vi kan afslutte løkken
                }
                else
                {
                    Console.WriteLine("Ugyldigt svar, prøv venligst igen med 'ja' eller 'nej'.");
                    // Løkken fortsætter, da gyldigtSvar ikke er sat til true
                }
            }
            { }
            { }
        }
    }
}