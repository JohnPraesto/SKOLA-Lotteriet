namespace Lektion230920
{
    internal class Program
    {
        /*
        Skriv ett program som slumpmässigt väljer ett av tre meddelanden att visa för användaren 
        varje gång programmet körs. Användaren ska se ett slumpmässigt meddelande varje gång 
        programmet exekveras


        Skriv ett program som simulerar ett enkelt lotteri. Programmet ska slumpmässigt generera   
        vinnande lottonummer och sedan låta användaren välja sina egna nummer. Användaren har 
        ett begränsat antal försök att försöka matcha sina nummer med de vinnande numren
        */


        static void Main(string[] args)
        {
            string[] greeting = new string[5] { "Hej!", "Nämen hej! Det var länge sen!", "Hallå där, läget?", "Tjena, tjena.", "God dag!" };
            string[] sorry = new string[5] { "Tyvärr ingen vinst på den dragningen.", "Miss! Hoppas på bättre tur nästa dragning!", "Inte denna gången, men kanske nästa.", "Ledsen, ingen vinst!", "Otur! Men nu måste du ha spenderat all otur, så nu har du nog bara tur kvar. Spela lite till!" };
            int[] bet = new int[3];
            string message = "";
            int[] userNumber = new int[3];
            int draw;
            string anwser = "J";
            int money = 1000;
            Random random = new Random();
            Console.WriteLine(greeting[random.Next(0, greeting.Length)]);

            while(anwser == "J")
            {
                Console.Clear();
                Console.WriteLine("Välkommen till LOTTERIET\n");
                Console.WriteLine($"Du har {money} kr att satsa!\n");
                Console.WriteLine("Du får satsa på tre nummer mellan 1-1000. Vilka satsar du på?");
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine($"Nummer {i + 1}: ");
                    userNumber[i] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine($"Dina nummer är: {userNumber[0]}, {userNumber[1]} & {userNumber[2]}.\n");

                int j = 0;
                while (j < 3)
                {
                    Console.WriteLine($"Hur mycket pengar vill du satsa på nr {j + 1}: '{userNumber[j]}'?");
                    bet[j] = Convert.ToInt32(Console.ReadLine());
                    if (bet[j] > money)
                    {
                        Console.WriteLine("Så mycket pengar har du inte på kontot!\n");
                    }
                    else
                    {
                        money -= bet[j];
                        Console.WriteLine($"Du har nu {money} kr kvar.\n");
                        j++;
                    }
                }

                Console.WriteLine("Tryck Enter för att starta spelet");
                Console.ReadLine();
                Console.Clear();

                // Flera bitar av denna kod-hög kan bli metod
                draw = random.Next(1, 1001);
                Console.WriteLine($"Första dragningen: {draw}"); //INFOGA RULL-SLUMP
                message = sorry[random.Next(0, greeting.Length)];
                for (int i = 0; i < 3; i++)
                {
                    if (draw == userNumber[i])
                    {
                        message = $"JACKPOTT!! På denna siffra vinner du {bet[i] * 100} kr!\n";
                        money += bet[i] * 100;
                    }
                    else if (draw < userNumber[i] + 11 && draw > userNumber[i] - 11) // Men om fler av ens tre nummer ligger inom spannet..?
                    {
                        message = $"Grattis! Ditt nummer nr{i}, '{userNumber[i]}' var bara 10 ifrån det dragna nummret! Du vinner {bet[i] * 10} kr!\n";
                        money += bet[i] * 10;
                    }
                    else if (draw < userNumber[i] + 51 && draw > userNumber[i] - 51)
                    {
                        message = $"Se där ja! Ditt nummer {userNumber[i]} var 50 ifrån det dragna nummret! Du vinner {bet[i] * 2} kr!\n";
                        money += bet[i] * 2;
                    }
                }
                Console.WriteLine(message);
                Console.ReadLine();





                draw = random.Next(1, 1001);
                Console.WriteLine($"Andra dragningen: {draw}"); //INFOGA RULL-SLUMP
                message = sorry[random.Next(0, greeting.Length)];
                for (int i = 0; i < 3; i++)
                {
                    if (draw == userNumber[i])
                    {
                        message = $"JACKPOTT!! På denna siffra vinner du {bet[i] * 100} kr!\n";
                        money += bet[i] * 100;
                    }
                    else if (draw < userNumber[i] + 11 && draw > userNumber[i] - 11)
                    {
                        message = $"Grattis! Ditt nummer {userNumber[i]} var bara 10 ifrån det dragna nummret! Du vinner {bet[i] * 10} kr!\n";
                        money += bet[i] * 10;
                    }
                    else if (draw < userNumber[i] + 51 && draw > userNumber[i] - 51)
                    {
                        message = $"Se där ja! Ditt nummer {userNumber[i]} var 50 ifrån det dragna nummret! Du vinner {bet[i] * 2} kr!\n";
                        money += bet[i] * 2;
                    }
                }
                Console.WriteLine(message);
                Console.ReadLine();





                draw = random.Next(1, 1001);
                Console.WriteLine($"Tredje dragningen: {draw}"); //INFOGA RULL-SLUMP
                message = sorry[random.Next(0, greeting.Length)];
                for (int i = 0; i < 3; i++)
                {
                    if (draw == userNumber[i])
                    {
                        message = $"JACKPOTT!! På denna siffra vinner du {bet[i] * 100} kr!\n";
                        money += bet[i] * 100;
                    }
                    else if (draw < userNumber[i] + 11 && draw > userNumber[i] - 11)
                    {
                        message = $"Grattis! Ditt nummer {userNumber[i]} var bara 10 ifrån det dragna nummret! Du vinner {bet[i] * 10} kr!\n";
                        money += bet[i] * 10;
                    }
                    else if (draw < userNumber[i] + 51 && draw > userNumber[i] - 51)
                    {
                        message = $"Se där ja! Ditt nummer {userNumber[i]} var 50 ifrån det dragna nummret! Du vinner {bet[i] * 2} kr!\n";
                        money += bet[i] * 2;
                    }
                }
                Console.WriteLine(message);
                Console.ReadLine();





                while (true)
                {
                    Console.WriteLine($"Du har nu {money} kr. Vill du fortsätta spela? J/N");
                    anwser = Console.ReadLine().ToUpper();
                    if (anwser == "J")
                        break;
                    else if (anwser == "N")
                        break;
                    else
                        Console.WriteLine("Du måste skriva 'J' eller 'N' för att komma vidare\n");
                }
            }
        }
    }
}