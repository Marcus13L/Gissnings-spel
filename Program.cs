Random random = new Random();
int Randomrare = random.Next(1, 100);
int antalFörsök = 0;
int gissning = 0;
Console.WriteLine("Gissa ett tal mellan 1 och 100!");
    while (gissning != Randomrare)
    {
        Console.Write("Din gissning: ");
        gissning = int.Parse(Console.ReadLine());
        antalFörsök++;
            if (gissning < Randomrare)
            {
                Console.WriteLine("För lågt");
            }
            else if (gissning > Randomrare)
            {
                Console.WriteLine("För högt");
            }
        }
        Console.WriteLine(string.Format("Du gissade rätt på {0} försök.", antalFörsök));