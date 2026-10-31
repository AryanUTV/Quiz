namespace Quiz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int point = 0;

            Console.WriteLine("Fråga 1: Vilket språk är mycket vanligt inom AI & dataanalys?");
            Console.WriteLine("1: Java");
            Console.WriteLine("2: C#");
            Console.WriteLine("3: Python");
            Console.WriteLine("4: HTML");

            Console.WriteLine();

            Console.Write("Ditt svar: ");
            int answer = int.Parse(Console.ReadLine());

            if (answer == 3)
            {
                Console.WriteLine("Korrekt!");
                point += 1;
            }
            else
            {
                Console.WriteLine("Inkorrekt!");
            }

            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Fråga 2: Vad gör en while-loop?");
            Console.WriteLine("1: Kör kod så länge ett villkor är sant");
            Console.WriteLine("2: Tar bort en variabel");
            Console.WriteLine("3: Skapar en klass");
            Console.WriteLine("4: Stoppar alltid programmet");

            Console.WriteLine();

            Console.Write("Ditt svar: ");
            answer = int.Parse(Console.ReadLine());

            if (answer == 1)
            {
                Console.WriteLine("Korrekt!");
                point += 1;
            }
            else
            {
                Console.WriteLine("Inkorrekt!");
            }

            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Fråga 3: Vad gör return i en metod?");
            Console.WriteLine("1: Avslutar hela programmet");
            Console.WriteLine("2: Skickar tillbaka ett värde från metoden");
            Console.WriteLine("3: Startar en loop");
            Console.WriteLine("4: Rensar konsolen");

            Console.WriteLine();

            Console.Write("Ditt svar: ");
            answer = int.Parse(Console.ReadLine());

            if (answer == 2)
            {
                Console.WriteLine("Korrekt!");
                point += 1;
            }
            else
            {
                Console.WriteLine("Inkorrekt!");
            }

            Console.ReadLine();
            Console.Clear();

            // Här anropas metoderna & skickar aktuella poängen med
            point = Fraga4(point);
            point = Fraga5(point);
            point = Fraga6(point);
        }

           
        static int Fraga4(int point) // Metoden tar emot point & returnerar nya poängen
        {
            Console.WriteLine("Fråga 4: Vad används Console.ReadLine() till?");
            Console.WriteLine("1: Skriva ut text");
            Console.WriteLine("2: Läsa in användarens input");
            Console.WriteLine("3: Starta en loop");
            Console.WriteLine("4: Skapa en metod");

            Console.WriteLine();

            Console.Write("Ditt svar: ");
            int answer = int.Parse(Console.ReadLine());

            if (answer == 2)
            {
                Console.WriteLine("Korrekt!");
                point += 1;
            }
            else
            {
                Console.WriteLine("Inkorrekt!");
            }

            Console.ReadLine();
            Console.Clear();


            // Return skickar tillbaka uppdaterade poängen till Main
            return point;
            
        }

        static int Fraga5(int point)
        {
            Console.WriteLine("Fråga 5: Vad används en List<string> till?");
            Console.WriteLine("1: Skriva ut text");
            Console.WriteLine("2: Spara bara ett heltal");
            Console.WriteLine("3: Skapa en loop");
            Console.WriteLine("4: Spara flera texter");

            Console.WriteLine();

            Console.Write("Ditt svar: ");
            int answer = int.Parse(Console.ReadLine());

            if (answer == 4)
            {
                Console.WriteLine("Korrekt!");
                point += 1;
            }
            else
            {
                Console.WriteLine("Inkorrekt!");
            }

            Console.ReadLine();
            Console.Clear();

            return point;
        }
        static int Fraga6(int point)
        {
            Console.WriteLine("Fråga 6: Vad betyder == i C#?");
            Console.WriteLine("1: Tilldelar ett värde");
            Console.WriteLine("2: Ökar ett värde");
            Console.WriteLine("3: Kontrollerar om två värden är lika");
            Console.WriteLine("4: Tar bort ett värde");

            Console.WriteLine();

            Console.Write("Ditt svar: ");
            int answer = int.Parse(Console.ReadLine());

            if (answer == 3)
            {
                Console.WriteLine("Korrekt!");
                point += 1;
            }
            else
            {
                Console.WriteLine("Inkorrekt!");
            }

            Console.WriteLine("Poäng: " + point + "/6");
            Console.ReadLine();

            return point;

        }
    }
}
            







          


          
