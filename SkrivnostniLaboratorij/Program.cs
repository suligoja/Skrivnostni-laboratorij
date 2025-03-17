using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkrivnostniLaboratorij
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dobrodošli v igri Skrivnostni laboratorij!");
            Console.WriteLine("Za navodila pritisnite 'n' ali katero koli tipko za začetek.");
            string navodila = Console.ReadLine();
            if (navodila == "n")
            {
                ShowInstructions();
            }
            StartGame();
            Console.ReadLine();
        }

        private static void ShowInstructions()
        {
            Console.WriteLine("\nNAVODILA:");
            Console.WriteLine("- Poizkusi pobegniti iz laboratorija.");
            Console.WriteLine("- Na voljo boste imeli izbire, ki jih vnašate kot številke ali besede.");
            Console.WriteLine("- Če vnesete nekaj, kar ni možna izbira, boste izgubili minuto za pobeg.");
            Console.WriteLine("- Vaše odločitve vplivajo na potek zgodbe.");
            Console.WriteLine("\nPritisnite katerokoli tipko za začetek igre...");
            Console.ReadKey();
            Console.WriteLine("\n");
        }

        private static void StartGame()
        {
            int time = 10;
            Console.WriteLine("Prebudiš se v temnem, hladnem laboratoriju. Glava te boli in spomin je meglen.");
            Console.WriteLine("Okoli tebe so razbite epruvete in računalniki, ki prikazujejo opozorilna sporočila.");
            Console.WriteLine("Edina vrata so zaklenjena, rdeča opozorilna luč pa utripa v kotu sobe.");
            Console.WriteLine("Na zaslonu enega od računalnikov se prikaže sporočilo:");
            Console.WriteLine("\"Eksperiment neuspešen. Samouničenje laboratorija čez 10 minut.\"");
            Console.WriteLine("Hitro odkleneš vrata in nadaljuješ po hodniku.");
            Console.WriteLine("Znašel si se pred tremi vrati.");
            Console.WriteLine("Izberi: Leva (L), Sredina (S), Desna (D)");
            while (time > 0)
            {
                string izbira1 = Console.ReadLine().ToLower();
                if (izbira1 == "l" || izbira1 == "leva")
                {
                    Console.WriteLine("Stopil si v nevarno kemijsko sobo in umrl zaradi strupenega plina!");
                    break;
                }
                else if (izbira1 == "s" || izbira1 == "sredina")
                {
                    srednjaZgodba(time);
                    break;
                }
                else if (izbira1 == "d" || izbira1 == "desna")
                {
                    desnaZgodba(time);
                    break;
                }
                else
                {
                    time -= 1;
                    if (time == 0)
                    {
                        Console.WriteLine("Zmanjkalo ti je časa in eksplodiral si.");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Zapravil si minuto in imaš še " + time + " minut.");
                    }
                }
            }
        }

        private static void desnaZgodba(int time)
        {
            Console.WriteLine("Stopil si v dolg hodnik in čez nekaj časa prišel v jedilnico.");
            Console.WriteLine("Počutiš se lačnega in v jedilnici opaziš sendvič.");
            Console.WriteLine("Ali poješ sendvič?");
            while (time > 0)
            {
                Console.WriteLine("Izberi: Da/Ne");

                string izbira3 = Console.ReadLine().ToLower();
                if (izbira3 == "da")
                {
                    Console.WriteLine("Sendvič je bil zastrupljen in si umrl.");
                    break;
                }
                else if (izbira3 == "ne")
                {
                    Console.WriteLine("Sendvič si pustil na mizi in nadaljeval pot.");
                    Console.WriteLine("Pot te je peljala dalje v laboratorij. Videl si, da je nastal virus, ki spremeni ljudi v zombije.");
                    Console.WriteLine("Opaziš, da je računalnik v laboratoriju odprt, ter poskušaš pridobiti informacije o tem, kar se je zgodilo.");
                    Console.WriteLine("Računalnik je zaklenjen z geslom in na njem je listek, na katerem piše \"nesmrtnost\".");
                    string geslo = "nesmrtnost";
                    Console.WriteLine("Pomisliš, da bi to lahko bilo geslo, in poskusiš.");
                    while (time > 0)
                    {
                        Console.WriteLine("Vpiši geslo: ");
                        string poizkus = Console.ReadLine().ToLower();
                        if (poizkus == geslo)
                        {
                            Console.WriteLine("Geslo je pravilno in pridobil si informacije o virusu.");
                            Console.WriteLine("Laboratorij je bil del revolucionarnega poskusa – ustvariti zdravilo za nesmrtnost.");
                            Console.WriteLine("Vendar je poskus spodletel, in namesto večnega življenja je virus začel spreminjati ljudi v brezumne, agresivne zombije.");
                            Console.WriteLine("Našel si tudi informacije o protistrupu, ki ga lahko ustvariš v laboratoriju.");
                            Console.WriteLine("Ali greš v laboratorij in ustvariš protistrup?");
                            while (time > 0)
                            {
                                Console.WriteLine("Izberi: Da/Ne");

                                string izbira4 = Console.ReadLine().ToLower();

                                if (izbira4 == "da")
                                {
                                    Console.WriteLine("Odločil si se, da greš v laboratorij in ustvariš protistrup.");
                                    Console.WriteLine("Hotel si biti heroj in rešiti ljudi, vendar ti ni uspelo.");
                                    Console.WriteLine("V laboratoriju si preživel preveč časa in laboratorij je eksplodiral!");

                                    Environment.Exit(0);//konča program

                                }
                                else if (izbira4 == "ne")
                                {
                                    Console.WriteLine("Odločil si se, da ne ustvariš protistrupa.");
                                    Console.WriteLine("Spomniš se, da se bo laboratorij uničil in se hitro odpraviš proti izhodu.");
                                    Console.WriteLine("Na poti naletiš na nekaj zombijev, vendar se jim uspešno izogneš.");
                                    Console.WriteLine("Končno dosežeš izhod in uspešno pobegneš iz laboratorija!");
                                    Console.WriteLine("Čestitamo! Uspešno si pobegnil iz laboratorija in preživel!");
                                    Environment.Exit(0);

                                }
                                else
                                {
                                    izgubilcas(ref time);
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("Poizkusi znova!");
                            izgubilcas(ref time);
                        }
                    }
                }
                else
                {
                    izgubilcas(ref time);
                }
            }
        }

        private static void izgubilcas(ref int time)
        {
            time -= 1;
            if (time == 0)
            {
                Console.WriteLine("Zmanjkalo ti je časa in eksplodiral si.");
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Zapravil si minuto in imaš še " + time + " minut.");
            }
        }

        private static void srednjaZgodba(int time)
        {
            Console.WriteLine("Izbral si srednja vrata in našel sobo.");
            Console.WriteLine("Raziskal si sobo ter našel pištolo.");
            Console.WriteLine("Ali vzameš pištolo?");
            while (time > 0)
            {
                Console.WriteLine("Izberi: Da/Ne");

                string izbira2 = Console.ReadLine().ToLower();
                if (izbira2 == "da")
                {
                    Console.WriteLine("Pištolo si pobral ter nadaljeval pot.");
                    Console.WriteLine("Pot te je peljala v laboratorij, kjer si naletel na zombija.");
                    Console.WriteLine("Ali uporabiš pištolo?");
                    while (time > 0)
                    {
                        Console.WriteLine("Izberi: Da/Ne");
                        string izbira5 = Console.ReadLine().ToLower();
                        if (izbira5 == "da")
                        {
                            Console.WriteLine("Uporabil si pištolo in ubil zombija.");
                            Console.WriteLine("Nadaljeval si pot, ampak zaradi strela te je začela loviti horda zombijev.");
                            Console.WriteLine("Porabil si vse metke in začel bežati, a horda zombijev ti je bila za petami.");
                            Console.WriteLine("Prispel si do slepe ulice. Zvok njihovih korakov je postajal glasnejši.");
                            Console.WriteLine("Zavpil si za pomoč, vendar te ni nihče slišal.");
                            Console.WriteLine("Zombiji so te obkolili. Tvoji zadnji trenutki so bili polni obupa.");
                            Console.WriteLine("Na žalost je bil to konec tvoje poti.");
                            Environment.Exit(0);
                        }
                        else if (izbira5 == "ne")
                        {
                            Console.WriteLine("Zombi te ni opazil in mirno si nadaljeval pot");
                            Console.WriteLine("hodil si veliko časa in končno naletel na izhod, ampak pred njim je zombi");
                            Console.WriteLine("Ali uporabiš pištolo?");
                            while (time > 0)
                            {
                                Console.WriteLine("Izberi: Da/Ne");
                                string izbira6 = Console.ReadLine().ToLower();
                                if (izbira6 == "da")
                                {
                                    Console.WriteLine("Uporabil si pištolo in ubil zombija.");
                                    Console.WriteLine("Hitro si stekel skozi vrata in pobegnil.");
                                    Console.WriteLine("Takoj po pobegu se je za tabo laboratorij samouničil.");
                                    Console.WriteLine("Čestitamo! Uspešno si pobegnil iz laboratorija in preživel!");
                                    Environment.Exit(0);
                                }
                                else if (izbira6 == "ne")
                                {
                                    Console.WriteLine("Odločil si se, da ne uporabiš pištole in poskušaš najti drug način.");
                                    Console.WriteLine("Zombi te opazi in se približuje, toda se v zadnjem trenutku skriješ.");
                                    Console.WriteLine("Medtem ko te zombi išče, zaslišiš opozorilne sirene. Samouničenje laboratorija čez 10..9..8...");
                                    Console.WriteLine("Poskušaš pobegniti, vendar je prepozno.");
                                    Console.WriteLine(" 3..2..1.. BOOM!");
                                    Console.WriteLine("Celoten laboratorij eksplodira in te ujame v ogromen ognjen val.");
                                    Console.WriteLine("Na žalost je bil to konec tvoje zgodbe.");
                                    Environment.Exit(0);
                                }
                                else
                                {
                                    izgubilcas(ref time);
                                }
                            }
                        }
                        else
                        {
                            izgubilcas(ref time);
                        }
                    }
                }
                else if (izbira2 == "ne")
                {
                    Console.WriteLine("Pot si nadaljeval brez orožja...");
                    Console.WriteLine("Čez nekaj časa si naletel na zombija. Čas se izteka, nazaj ne moreš.");
                    Console.WriteLine("Medtem ko razmišljaš, kaj bi naredil, te zombi napade ter te ubije.");
                    Environment.Exit(0);
                }
                else
                {
                    izgubilcas(ref time);
                }
            }
        }

    }
}
