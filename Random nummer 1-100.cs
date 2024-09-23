Random random = new Random();
int Randomrare = random.Next(1, 100);
int antalFörsök = 0;
int tal = 0;
Console.WriteLine("Gissa ett tal mellan 1 och 100!");
    while (tal != Randomrare)
    {
        Console.Write("Din gissning: ");
        tal = int.Parse(Console.ReadLine());
        antalFörsök++;
            if (tal < Randomrare)
            {
                Console.WriteLine("För lågt");
            }
            else if (tal > Randomrare)
            {
                Console.WriteLine("För högt");
            }
        }
        Console.WriteLine(string.Format("Du gissade rätt på {0} försök.", antalFörsök));