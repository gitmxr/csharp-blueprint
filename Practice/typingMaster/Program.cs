using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace TypingTest
{
    class Program
    {
        // Function to generate a random passage from a list of passages
        static string GetRandomPassage()
        {
            List<string> passages = new List<string>
            {
                "The sun dipped below the horizon, casting a warm golden glow over the landscape. Birds chirped merrily as they prepared for the night. The gentle breeze rustled through the leaves, creating a symphony of nature's sounds. This magical moment in time invites everyone to pause, breathe, and appreciate the beauty that surrounds us. As the sky turns a deep shade of orange, it feels like nature is painting a masterpiece, reminding us of the tranquility that exists in the world.",

                "In a bustling city, the sound of honking cars and chatter filled the air. People hurried along the streets, each caught up in their own lives, with little time to spare. Street vendors called out enticing passersby with delicious aromas of food. Amidst the chaos, there was a sense of vibrancy, a reminder of the energy that urban life brings. The flashing lights of storefronts and the rhythmic sound of footsteps created a heartbeat for the city, showcasing a blend of cultures and stories that converge in this lively environment.",

                "Gardening can be a therapeutic hobby for many individuals. Tending to plants not only beautifies the surroundings but also offers a sense of accomplishment. Watching seeds sprout into vibrant flowers or fresh vegetables can be an incredibly rewarding experience. Gardening teaches patience and care, allowing individuals to connect with nature in a meaningful way. The joy of nurturing a plant from seed to bloom fosters a sense of pride, making it an enjoyable and fulfilling activity for people of all ages.",

                "Reading opens up a world of imagination and knowledge for readers of all ages. Each book serves as a portal to different realms, allowing readers to explore diverse perspectives and experiences. Whether it’s a gripping novel, an insightful biography, or a captivating fantasy, books have the power to transport us to places we've never been. The smell of old pages, the feel of a book in hand, and the anticipation of turning the next page creates an experience that enriches our minds and souls. Reading not only entertains but also educates, making it a timeless pursuit.",

                "Traveling provides an excellent opportunity to learn about different cultures and traditions across the globe. Each destination has its unique charm, shaped by history and local customs. Engaging with locals, trying new cuisines, and experiencing various ways of life broaden our horizons. Whether exploring ancient ruins or lounging on a pristine beach, traveling fosters appreciation for diversity and helps us understand the world better. Each journey offers lessons that can change our perspectives, making us more empathetic and informed global citizens.",

                "Technology has transformed the way we communicate and interact with one another in modern society. From smartphones to social media, staying connected has never been easier. However, this constant connectivity can also lead to information overload and feelings of isolation. Finding a balance between online and offline interactions is essential for maintaining healthy relationships and mental well-being. As we embrace technological advancements, we must also remember the importance of genuine human connections, fostering meaningful interactions in both the digital and physical realms.",

                "The ocean is a vast and mysterious place, teeming with life and wonder beneath its surface. It covers more than 70% of the Earth's surface and contains a diverse range of ecosystems. From vibrant coral reefs to deep-sea trenches, the ocean is home to countless species. Protecting our oceans is crucial for sustaining the delicate balance of life on our planet. Conservation efforts and awareness about marine life are essential for ensuring a healthy future for generations to come, as the ocean continues to play a vital role in our ecosystem.",

                "Cooking is both an art and a science that allows for creativity and expression through the combination of flavors, textures, and colors. Experimenting with different ingredients can lead to delightful discoveries and culinary masterpieces. Whether preparing a simple meal or an elaborate feast, cooking can bring people together and create lasting memories. The process of cooking can be therapeutic, allowing individuals to express themselves while nurturing those they care about. Each dish tells a story, making cooking an essential aspect of culture and community.",

                "Music has a profound impact on human emotions, influencing our mood and state of mind. It can uplift spirits, provide comfort during tough times, and evoke memories from the past. Different genres cater to various moods and preferences, making music a universal language that resonates with people worldwide. From the soothing notes of a classical symphony to the energetic beats of a pop song, music has the power to unite people across cultures and generations, reminding us of our shared humanity.",

                "Mindfulness and meditation have gained popularity as effective tools for stress relief and mental clarity in recent years. Practicing mindfulness encourages individuals to focus on the present moment, promoting a sense of calm amid daily chaos. Meditation offers a space for self-reflection and personal growth. Incorporating these practices into daily life can enhance overall well-being and improve mental health, fostering resilience and inner peace. As we navigate through the complexities of modern life, embracing mindfulness can provide valuable tools for maintaining balance and harmony."
            };

            Random random = new Random(); // Random number generator
            int randomIndex = random.Next(passages.Count); // Get a random index
            return passages[randomIndex]; // Return the random passage
        }

        // Function to calculate the typing speed in words per minute
        static double CalculateWPM(int totalWords, double timeInSeconds)
        {
            return (totalWords / 5.0) / (timeInSeconds / 60.0);
        }

        // Function to calculate accuracy
        static double CalculateAccuracy(string original, string typed)
        {
            int errors = 0;

            for (int i = 0; i < Math.Min(original.Length, typed.Length); i++)
            {
                if (original[i] != typed[i])
                {
                    errors++;
                }
            }

            // Count remaining characters
            errors += Math.Abs(original.Length - typed.Length);
            Console.WriteLine("Number of errors : "+errors);
            return ((original.Length - errors) / (double)original.Length) * 100.0;
        }

        // Function to get predefined words based on letter
        static List<string> GetLetterDrillWords(string letter)
        {
            Dictionary<string, List<string>> letterWords = new Dictionary<string, List<string>>()
            {
                { "A", new List<string> { "apple", "ant", "astronaut", "art", "arcade", "amazing", "amber", "airplane", "antelope", "aqua" }},
                { "B", new List<string> { "banana", "boat", "bat", "butterfly", "ball", "bicycle", "bird", "brave", "bridge", "bottle" }},
                { "C", new List<string> { "cat", "car", "cake", "clock", "candle", "cactus", "cupcake", "cable", "candy", "crown" }},
                { "D", new List<string> { "dog", "dance", "doll", "drum", "daisy", "dolphin", "dragon", "desk", "dive", "dare" }},
                { "E", new List<string> { "elephant", "egg", "engine", "earth", "ear", "elf", "earring", "energy", "expert", "exercise" }},
                { "F", new List<string> { "fish", "fan", "flower", "fork", "frog", "fire", "fountain", "fruit", "flag", "feather" }},
                { "G", new List<string> { "goat", "giraffe", "gift", "grape", "gown", "gate", "glove", "goal", "glow", "guitar" }},
                { "H", new List<string> { "hat", "house", "horse", "heart", "hand", "honey", "hill", "hammock", "hero", "horizon" }},
                { "I", new List<string> { "ice", "igloo", "island", "iron", "ink", "idea", "index", "icon", "insect", "infinity" }},
                { "J", new List<string> { "jacket", "jam", "jewel", "jungle", "jump", "juice", "joke", "jigsaw", "jet", "jog" }},
                { "K", new List<string> { "kite", "key", "kangaroo", "kitten", "king", "kettle", "koala", "knife", "knot", "keyhole" }},
                { "L", new List<string> { "lion", "lamp", "lake", "lollipop", "leaf", "ladder", "leaf", "lawn", "laptop", "letter" }},
                { "M", new List<string> { "mouse", "moon", "mango", "map", "medal", "muffin", "mirror", "mop", "mystery", "mustard" }},
                { "N", new List<string> { "nose", "notebook", "nest", "necklace", "nail", "nut", "nurse", "newspaper", "noodle", "number" }},
                { "O", new List<string> { "owl", "orange", "ocean", "octopus", "oasis", "olive", "otter", "organ", "oval", "onion" }},
                { "P", new List<string> { "penguin", "piano", "pillow", "potato", "peach", "panda", "pie", "parrot", "pearl", "pumpkin" }},
                { "Q", new List<string> { "quilt", "queen", "question", "quick", "quail", "quack", "quasar", "quiet", "quote", "quench" }},
                { "R", new List<string> { "rabbit", "rainbow", "rocket", "rose", "ring", "rug", "riddle", "road", "rescue", "river" }},
                { "S", new List<string> { "snake", "sun", "star", "sugar", "sock", "sand", "scooter", "spoon", "sailboat", "safety" }},
                { "T", new List<string> { "tiger", "turtle", "tree", "train", "teapot", "taco", "telescope", "trophy", "trick", "treat" }},
                { "U", new List<string> { "umbrella", "unicorn", "ukulele", "uniform", "unit", "utensil", "upgrade", "uplift", "urban", "utility" }},
                { "V", new List<string> { "violin", "vase", "van", "vulture", "village", "vortex", "vacuum", "valley", "vortex", "volt" }},
                { "W", new List<string> { "whale", "window", "water", "wagon", "watch", "wheat", "whistle", "wolf", "wave", "wonder" }},
                { "X", new List<string> { "xylophone", "x-ray", "xerox", "xenon", "xenophobia", "xenophile", "xylophonist", "xyst", "xenolith", "xenogenesis" }},
                { "Y", new List<string> { "yak", "yarn", "yacht", "yellow", "yummy", "yoga", "yawn", "yeti", "young", "yolk" }},
                { "Z", new List<string> { "zebra", "zoo", "zero", "zinc", "zipper", "zesty", "zodiac", "zoom", "zone", "zeal" }}
            };

            // Ensure the letter is uppercase
            letter = letter.ToUpper();

            if (letterWords.ContainsKey(letter))
            {
                return letterWords[letter].Take(10).ToList(); // Return the first 10 words related to the letter
            }

            return new List<string>(); // Return an empty list if the letter is not valid
        }

        static void Main(string[] args)
        {
            bool continueTesting = true; // Control variable for the loop

            while (continueTesting)
            {
                Console.WriteLine("Welcome to the Typing Test!");
                Console.WriteLine("Please choose a drill:");
                Console.WriteLine("1. Letter Drill");
                Console.WriteLine("2. Word Drill");
                Console.WriteLine("3. Paragraph Drill");
                Console.WriteLine("4. Exit");

                string choice = Console.ReadLine()!;

                switch (choice)
                {
                    case "1":
                        // Letter Drill
                        Console.Write("Enter a letter (A-Z): ");
                        string letter = Console.ReadLine()!;
                        var letterDrillWords = GetLetterDrillWords(letter);

                        if (letterDrillWords.Count > 0)
                        {
                            Console.WriteLine($"Type the following words:");
                            foreach (var word in letterDrillWords)
                            {
                                Console.WriteLine(word);
                            }

                            // Start the timer
                            Stopwatch stopwatchLetter = Stopwatch.StartNew();
                            string typedWords = Console.ReadLine()!;
                            stopwatchLetter.Stop();

                            // Calculate WPM and accuracy
                            double elapsedLetter = stopwatchLetter.Elapsed.TotalSeconds;
                            double letterWPM = CalculateWPM(letterDrillWords.Count, elapsedLetter); // Total words typed
                            double letterAccuracy = CalculateAccuracy(string.Join(" ", letterDrillWords), typedWords);

                            // Display results for letter drill
                            Console.WriteLine($"\nTime taken: {elapsedLetter:F2} seconds");
                            Console.WriteLine($"Words per minute: {letterWPM:F2}");
                            Console.WriteLine($"Accuracy: {letterAccuracy:F2}%");
                        }
                        else
                        {
                            Console.WriteLine("Invalid letter entered.");
                        }
                        break;

                    case "2":
                        // Word Drill
                        Console.Write("Enter the number of words to practice: ");
                        if (int.TryParse(Console.ReadLine(), out int numberOfWords) && numberOfWords > 0)
                        {
                            List<string> wordDrillList = new List<string>();
                            for (int i = 0; i < numberOfWords; i++)
                            {
                                wordDrillList.Add(GetRandomPassage().Split(' ').FirstOrDefault()); // Pick first word of random passage
                            }

                            // Combine words into a single string for typing
                            string wordsToType = string.Join(" ", wordDrillList);
                            Console.WriteLine($"Type the following words:\n{wordsToType}\n");

                            // Start the timer
                            Stopwatch stopwatchWord = Stopwatch.StartNew();
                            string typedWordsForDrill = Console.ReadLine();
                            stopwatchWord.Stop();

                            // Calculate WPM and accuracy
                            double elapsedWord = stopwatchWord.Elapsed.TotalSeconds;
                            double wordWPM = CalculateWPM(wordDrillList.Count, elapsedWord); // Count words
                            double wordAccuracy = CalculateAccuracy(wordsToType, typedWordsForDrill);

                            // Display results for word drill
                            Console.WriteLine($"\nTime taken: {elapsedWord:F2} seconds");
                            Console.WriteLine($"Words per minute: {wordWPM:F2}");
                            Console.WriteLine($"Accuracy: {wordAccuracy:F2}%");
                        }
                        else
                        {
                            Console.WriteLine("Please enter a valid number of words.");
                        }
                        break;

                    case "3":
                        // Paragraph Drill
                        string passage = GetRandomPassage();
                        Console.WriteLine("Type the following passage:\n");
                        Console.WriteLine(passage);
                        Console.WriteLine();

                        // Start the timer
                        Stopwatch stopwatchParagraph = Stopwatch.StartNew();
                        string typedPassage = Console.ReadLine();
                        stopwatchParagraph.Stop();

                        // Calculate WPM and accuracy
                        double elapsedParagraph = stopwatchParagraph.Elapsed.TotalSeconds;
                        int totalWords = passage.Split(' ').Length; // Count words in the passage
                        double paragraphWPM = CalculateWPM(totalWords, elapsedParagraph);
                        double paragraphAccuracy = CalculateAccuracy(passage, typedPassage);

                        // Display results for paragraph drill
                        Console.WriteLine($"\nTime taken: {elapsedParagraph:F2} seconds");
                        Console.WriteLine($"Words per minute: {paragraphWPM:F2}");
                        Console.WriteLine($"Accuracy: {paragraphAccuracy:F2}%");
                        break;

                    case "4":
                        continueTesting = false; // Exit the loop
                        break;

                    default:
                        Console.WriteLine("Invalid choice, please try again.");
                        break;
                }

                Console.Write("Do you want to return to the main menu? (Yes/No): ");
                string continueChoice = Console.ReadLine().Trim().ToLower();
                continueTesting = continueChoice == "yes"; // Return to menu based on user input
                Console.WriteLine(); // Print a newline for better readability
            }
        }
    }
}
