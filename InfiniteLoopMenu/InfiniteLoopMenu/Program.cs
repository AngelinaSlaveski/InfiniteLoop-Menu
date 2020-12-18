using System;

namespace _5ti_Chas_Correction
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int i = 0; i < 10;)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Odberi zadacha: ");
                Console.WriteLine("1. Proveri dali brojot e od 1 do 10");
                Console.WriteLine("2. Najdi maksimum od 2 broja");
                Console.WriteLine("3. Proveri dali slikata e landspace ili portrait");
                Console.WriteLine("4. Schumacher");
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nZa da izlezesh od programata vnesi EXIT: ");
                Console.ResetColor();

                var vnes = Console.ReadLine();

                if (vnes == "exit")
                {

                    break;
                }

                switch (vnes)
                {
                    case "1":
                        PrvaZadaca();
                        break;

                    case "2":
                        VtoraZadaca();
                        break;
                    case "3":
                        TretaZadaca();
                        break;
                    case "4":
                        CetvrtaZadaca();
                        break;

                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.ResetColor();
                        break;
                }

            }
        }

        public static void PrvaZadaca()
        {
            Console.WriteLine(@"\n
// Da se napise programa koja bara od korisnikot da se vnese broj.
// Korisnokt treba da vnese broj od 1 do 10 za brojot da e validen.
// Ako korisnokot vnese validen broj da se ispecati 'Valid'.
// Ako korisnikot vnese nevaliden broj da se ispecati 'Not Valid'");
            Console.Write("\nVnesi broj: ");
            var input = Console.ReadLine();
            var number = Convert.ToInt32(input);

            if (number > 0 && number <= 10)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Valid!");
                Console.ResetColor();

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Not Valid!");
                Console.ResetColor();
            }
        }

        public static void VtoraZadaca()
        {
            Console.WriteLine("\n//Da se napise programa koja na vlez bara 2 broja i da se ispecati pogolemiot broj.\n");

            Console.Write("Vnesi prv broj: ");
            var number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Vnesi vtor broj: ");
            var number2 = Convert.ToInt32(Console.ReadLine());

            if (number1 > number2)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Maksimumot od broevite e: " + number1);
                Console.ResetColor();
            }
            else if (number1 < number2)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Maksimumot od broevite e: " + number2);
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Broevite se ednakvi.");
                Console.ResetColor();
            }
        }
        public static void TretaZadaca()
        {
            Console.WriteLine(@"
 // Da se napishe programa koja na vlez bara shirina i visina na slikata.
 // Spored vnesenite informacii da se odredi dali slikata e landscape ili portrait");
            Console.WriteLine("\nVnesete shirina na slikata: ");
            var width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nVnesete visina na slikata: ");
            var heigth = Convert.ToInt32(Console.ReadLine());

            var isImagePortrait = false;
            if (heigth > width)
            {
                isImagePortrait = true;
            }
            if (isImagePortrait)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Slikata e portait.");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Slikata e landscape.");
                Console.ResetColor();
            }
        }
        public static void CetvrtaZadaca()
        {
            Console.WriteLine(@"
//Da se napise programa koja na vlez ja bara brzinata na dvizenje na eden avtomobil i dozvolenata brzina na dvizenje. 
//Dokolku brzinata na avtomobilot e vo ramki na dozvolenata brzina da se ispeati OK, vo sprotivno da se presmeta razlikata na dozvolenata brzina i brzinata na avtomobilot i od toa da se presmetaat kaznenite poeni. 
//Dokolku vozacot na voziloto nadmine 100 poenida se ispecati 'Odzemi vozacka' a ako ne nadmine 100 poeni da se ispecati 'Kazneni poeni' i kolku kazneni poeni dobil.");
            Console.WriteLine("\nVnesi brzina na voziloto: ");
            var vehicleSpeed = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nVnesi dozvolena brzina: ");
            var speedLimit = Convert.ToInt32(Console.ReadLine());

            if (vehicleSpeed == speedLimit)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("OK!");
                Console.ResetColor();
            }
            else
            {
                var speedDifference = vehicleSpeed - speedLimit;
                var penaltyPoints = 0;
                var penalty = PenaltyCategory.Below10;

                if (speedDifference <= 10)
                {
                    penalty = PenaltyCategory.Below10;
                }
                else if (speedDifference > 10 && speedDifference <= 20)
                {
                    penalty = PenaltyCategory.From10To20;
                }
                else if (speedDifference > 10 && speedDifference <= 20)
                {
                    penalty = PenaltyCategory.From20To50;
                }
                else if (speedDifference > 50 && speedDifference <= 80)
                {
                    penalty = PenaltyCategory.From50To80;
                }
                else
                {
                    penalty = PenaltyCategory.Above80;
                }

                switch (penalty)
                {
                    case PenaltyCategory.Below10:
                        penaltyPoints = 0;
                        break;
                    case PenaltyCategory.From10To20:
                        penaltyPoints = 10;
                        break;
                    case PenaltyCategory.From20To50:
                        penaltyPoints = 25;
                        break;
                    case PenaltyCategory.From50To80:
                        penaltyPoints = 50;
                        break;
                    case PenaltyCategory.Above80:
                        penaltyPoints = 100;
                        break;
                    default:
                        break;
                }

                if (penalty == PenaltyCategory.Below10)
                {
                    Console.WriteLine("Ok!");
                }
                if (penalty != PenaltyCategory.Below10 && penalty != PenaltyCategory.Above80)
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine($"Kazneni poeni: {penaltyPoints}");
                    Console.ResetColor();
                }
                if (penalty == PenaltyCategory.Above80)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Odzemi vozacka!");
                    Console.ResetColor();

                }
            }
        }
        public enum PenaltyCategory
        {
            Below10,
            From10To20,
            From20To50,
            From50To80,
            Above80
        }
    }
}
