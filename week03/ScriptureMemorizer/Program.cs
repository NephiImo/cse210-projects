using System;

class Program
{
    static void Main(string[] args)
    {
        List<Scripture> scriptureLibrary = new List<Scripture> 
        {
            new Scripture(new Reference("1 Nephi", 3, 7), "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children save he shall prepare a way for them that they may accomplish the thing which he commandeth them."),
            new Scripture(new Reference("2 Nephi", 2, 25), "Adam fell that men might be; and men are, that they might have joy."),
            new Scripture(new Reference("Mosiah", 2, 41), "And moreover, I would desire that ye should consider on the blessed and happy state of those that keep the commandments of God. For behold, they are blessed in all things, both temporal and spiritual; and if they hold out faithful to the end they are received into heaven, that thereby they may dwell with God in a state of never-ending happiness. O remember, remember that these things are true; for the Lord God hath spoken it."),
            new Scripture(new Reference("Mosiah", 2, 17), "And behold, I tell you these things that ye may learn wisdom; that ye may learn that when ye are in the service of your fellow beings ye are only in the service of your God."),
            new Scripture(new Reference("Ether", 12, 26, 27), "26. And when I had said this, the Lord spake unto me, saying: Fools mock, but they shall mourn; and my grace is sufficient for the meek, that they shall take no advantage of your weakness; \n27. And if men come unto me I will show unto them their weakness. I give unto men weakness that they may be humble; and my grace is sufficient for all men that humble themselves before me; for if they humble themselves before me, and have faith in me, then will I make weak things become strong unto them.")
        };

        Random random = new Random();
        Scripture scripture1 = scriptureLibrary[random.Next(scriptureLibrary.Count)];
        
        while (!scripture1.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture1.GetDisplayText());
            Console.Write("\nPress Enter to hide words or type 'quit' to exit: ");
            string input = Console.ReadLine().Trim().ToLower();

            if (input == "quit")
            {
                break;
            }
            scripture1.HideRandomWords(5);
        }

        Console.Clear();
        Console.WriteLine(scripture1.GetDisplayText());
        Console.WriteLine("\nAll words are hidden. Program is complete.");
    }
}





/*     === EXCEEDING CORE REQUIREMENTS ===

       This program exceeds the core requirements by displaying a random scripture from a library of scriptures.
*/