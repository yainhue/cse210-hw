/*
CSE 210:
W03 Project: Scripture Memorizer Program
14/11/2025
- Written by Yain Huento

Showing Creativity and Exceeding Requirements:

    - Randomly select from only those words that are not already hidden (see Scripture.cs)
    - Load scriptures from text files

*/

class Program
{
    // declare default scripture
    static Reference _defReference = new Reference("1 Nephi", 3, 7);
    static Scripture _defScripture = new Scripture(_defReference,
        "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.");

    static Reference _currentReference = _defReference;
    static Scripture _currentScripture = _defScripture;

    public static Reference CreateReference(string book, int chapter, int verse, int endVerse)
    {
        Reference new_ref = new Reference(book, chapter, verse, endVerse);
        return new_ref;
    }
    public static Scripture CreateScripture(Reference reference, string text)
    {
        Scripture new_scripture = new Scripture(reference, text);
        return new_scripture;
    }

    static void Main()
    {
        Console.Clear();
        Console.WriteLine("Welcome to the ScriptureMemorizer Project.");

        int selection = 0;

        // menu
        while (selection != 3)
        {
            Console.WriteLine();
            Console.WriteLine($"1. Practice ({_currentReference.GetDisplayText()})\n2. Load scripture from file\n3. Quit\n Please, choose one.");
            string input = Console.ReadLine();
            selection = int.Parse(input);

            if (selection == 3)
            {
                break;
            }

            else if (selection == 1)
            {
                Console.Clear();
                Console.WriteLine(_currentScripture.GetDisplayText());
                Console.WriteLine();
                Console.WriteLine("Press enter to continue or type 'quit' to go back to the menu");
                input = Console.ReadLine();

                while (!_currentScripture.IsCompletelyHidden() && selection != 0)
                {
                    while (input == "" && input != "quit" && selection != 0)
                    {
                        if (input != "" && input != "quit")
                        {
                            Console.WriteLine("Invalid selection, please try again.");
                            Console.WriteLine("Press enter to continue or type 'quit' to go back to the menu");
                            input = Console.ReadLine();
                        }
                        else if (input == "" && input != "quit")
                        {
                            if (!_currentScripture.IsCompletelyHidden())
                            {
                                _currentScripture.HideRandomWords(3);
                                Console.Clear();
                                Console.WriteLine(_currentScripture.GetDisplayText());
                                Console.WriteLine();
                                Console.WriteLine("Press enter to continue or type 'quit' to go back to the menu");
                                input = Console.ReadLine();
                            }
                            else
                            {
                                selection = 0;
                            }
                        }
                        else
                        {
                            selection = 0;
                        }
                    }

                    if (input != "" && input != "quit")
                    {
                        Console.WriteLine("Invalid selection, please try again.");
                        Console.WriteLine("Press enter to continue or type 'quit' to go back to the menu");
                        input = Console.ReadLine();
                    }
                    else
                    {
                        selection = 0;
                    }
                }
            }

            else if (selection == 2)
            {
                while (selection != 0)
                {
                    Console.WriteLine();
                    Console.WriteLine("Insert the name of the text file (without .txt):");
                    input = Console.ReadLine();

                    string text = File.ReadAllText($"{input}.txt");

                    Console.WriteLine();
                    Console.WriteLine("Insert the scripture's book:");
                    string book = Console.ReadLine();

                    Console.WriteLine("Insert the scripture's chapter:");
                    input = Console.ReadLine();
                    int chapter = int.Parse(input);

                    Console.WriteLine("Insert the scripture's verse:");
                    input = Console.ReadLine();
                    int verse = int.Parse(input);

                    Console.WriteLine("Insert the scripture's end verse (write '0', if none):");
                    input = Console.ReadLine();
                    int endVerse = int.Parse(input);

                    Reference new_ref = CreateReference(book, chapter, verse, 0);
                    Scripture new_scripture = CreateScripture(new_ref, text);

                    _currentReference = new_ref;
                    _currentScripture = new_scripture;
                    selection = 0;
                }
            }

            else
            {
                Console.WriteLine("Invalid selection, please try again.");
            }
        }
    }
}